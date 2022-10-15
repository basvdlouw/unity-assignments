﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Agent : MonoBehaviour
{
    public Vector3 x;
    public Vector3 v;
    public Vector3 a;
    private World world;
    private AgentConfig conf;


    void Start()
    {
        world = FindObjectOfType<World>();
        conf = world.GetComponent<AgentConfig>();
        x = transform.position;
    }

    void Update()
    {
        float t = Time.deltaTime;

        a = Combine();
        a = Vector3.ClampMagnitude(a, conf.maxA);

        v = v + a * t;
        v = Vector3.ClampMagnitude(v, conf.maxV);

        x = x + v * t;

        WrapAround(ref x, -world.bound, world.bound);

        transform.position = x;

        //Modify the transform to rotate to a point just in front of the agent
        //Position x + velocity v
        if (v.magnitude > 0)
        {
            transform.LookAt(x + v);
        }
    }
    Vector3 Cohesion()
    {
        //Cohesion behaviour

        Vector3 r = new Vector3();

        //Get all neighbours of this agent inside a certain radius
        List<Agent> neighbours = world.getNeigh(this, conf.Rc);
        Debug.Log(neighbours.Count);

        //No neighbours mean no cohesion
        if (neighbours.Count == 0)
        {
            return r;
        }

        //Find the center of mass of all neighbours
        foreach (var agent in neighbours)
        {
            if (isInFieldOfView(agent.x))
            {
                r += agent.x;
            }
        }

        //A vector from our position x towards the center of mass r
        r /= neighbours.Count;

        r = r - this.x;
        r = Vector3.Normalize(r);

        return r;
    }

    Vector3 Separation()
    {
        Vector3 r = new Vector3();

        //Get all neighbours of this agent inside a certain radius
        List<Agent> neighbours = world.getNeigh(this, conf.Rs);

        //No neighbours mean no separation
        if (neighbours.Count == 0)
        {
            return r;
        }

        //Add the contribution of each neighbour towards me
        foreach (Agent neighbour in neighbours)
        {
            if (isInFieldOfView(neighbour.x))
            {
                Vector3 towardsMe = this.x - neighbour.x;

                //Force contribution will vary inversly proportional to distance
                if (towardsMe.magnitude > 0)
                {
                    r += towardsMe.normalized / towardsMe.magnitude;
                }
            }
        }

        return r.normalized;
    }

    Vector3 Alignment()
    {
        //Alignment behaviour
        //Steer agent to match the direction and speed of neighbours

        Vector3 r = new Vector3();

        //Get all neighbours of this agent inside a certain radius
        List<Agent> neighbours = world.getNeigh(this, conf.Rs);

        //No neighbours mean no separation
        if (neighbours.Count == 0)
        {
            return r;
        }

        //Match direction and speed == match velocity
        //Do this for all neighbours
        foreach (Agent agent in neighbours)
        {
            if (isInFieldOfView(agent.x))
            {
            r += agent.v;
            }
        }
        return r.normalized;
    }

    Vector3 Combine()
    {
        //Combine all desires
        //Weighted sum
        Vector3 r = conf.Kc * Cohesion() + conf.Ks * Separation() + conf.Ka * Alignment() + conf.Kw * wander();
        return r;
    }

    void WrapAround(ref Vector3 v, float min, float max)
    {
        v.x = WrapAroundFloat(v.x, min, max);
        v.y = WrapAroundFloat(v.y, min, max);
        v.z = WrapAroundFloat(v.z, min, max);
    }

    float WrapAroundFloat(float value, float min, float max)
    {
        if (value > max)
        {
            value = min;
        }
        else if (value < min)
        {
            value = max;
        }
        return value;
    }

    bool isInFieldOfView(Vector3 stuff)
    {
        return Vector3.Angle(this.v, stuff - this.x) <= conf.maxFieldOfViewAngle;
    }

    Vector3 wanderTarget;
    GameObject debugWanderCube;
    Vector3 wander() {
        float jitter = conf.wanderJitter * Time.deltaTime;

        wanderTarget += new Vector3(RandomBinomial() * jitter, 0, RandomBinomial() * jitter);

        wanderTarget = wanderTarget.normalized;

        wanderTarget *= conf.wanderRadius;

        Vector3 targetInLocalSpace = wanderTarget + new Vector3(0, 0, conf.wanderDistance);

        Vector3 targetInWorldSpace = transform.TransformPoint(targetInLocalSpace);

        targetInWorldSpace -= this.x;

        return targetInWorldSpace.normalized;
    }

    float RandomBinomial() {
        return Random.Range(0f, 1f) - Random.Range(0f, 1f);
    }
}