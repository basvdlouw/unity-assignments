// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt4x2
    {
        [TestCompiler]
        public static void int4x2_zero()
        {
            TestUtils.AreEqual(int4x2.zero.c0.x, 0);
            TestUtils.AreEqual(int4x2.zero.c0.y, 0);
            TestUtils.AreEqual(int4x2.zero.c0.z, 0);
            TestUtils.AreEqual(int4x2.zero.c0.w, 0);
            TestUtils.AreEqual(int4x2.zero.c1.x, 0);
            TestUtils.AreEqual(int4x2.zero.c1.y, 0);
            TestUtils.AreEqual(int4x2.zero.c1.z, 0);
            TestUtils.AreEqual(int4x2.zero.c1.w, 0);
        }

        [TestCompiler]
        public static void int4x2_operator_equal_wide_wide()
        {
            int4x2 a0 = int4x2(790229414, 970783976, 1428432738, 1578747135, 1733797753, 2001507228, 1446876437, 1777406370);
            int4x2 b0 = int4x2(612337669, 1214209108, 2120643427, 295461214, 1510890331, 1893316566, 921816149, 1834958575);
            bool4x2 r0 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int4x2 a1 = int4x2(1426387268, 1809275021, 1843770816, 1172185222, 1469608940, 869874758, 458603090, 581282460);
            int4x2 b1 = int4x2(1482011863, 2062852792, 226398742, 770290735, 36812057, 543224481, 1565350150, 1909926604);
            bool4x2 r1 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int4x2 a2 = int4x2(1948324909, 1129078206, 1638391029, 1135553683, 2079295200, 576232476, 608208235, 11172509);
            int4x2 b2 = int4x2(1619900436, 1849990483, 1261604411, 161864811, 843379453, 1780425458, 215681636, 2123130580);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int4x2 a3 = int4x2(1025529486, 2095601864, 193500113, 1780908384, 1587636094, 1892083815, 1250768669, 1984341771);
            int4x2 b3 = int4x2(708665810, 1902328998, 1808456602, 563830672, 200493241, 1391620681, 1035522654, 168447603);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_equal_wide_scalar()
        {
            int4x2 a0 = int4x2(1211464300, 1921862607, 508076684, 1249127920, 1394594555, 746862310, 1733655277, 1884008277);
            int b0 = (746972502);
            bool4x2 r0 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int4x2 a1 = int4x2(1682018538, 936027116, 927605411, 672785749, 1465584610, 585324157, 404448210, 969511077);
            int b1 = (795585660);
            bool4x2 r1 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int4x2 a2 = int4x2(442746747, 1884034177, 451512860, 425476075, 1370577708, 597010220, 1249636005, 211986678);
            int b2 = (1772925698);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int4x2 a3 = int4x2(1305479811, 1150443719, 177122433, 511346787, 1442445694, 667984966, 1684122010, 1962874832);
            int b3 = (255635293);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_equal_scalar_wide()
        {
            int a0 = (1150044438);
            int4x2 b0 = int4x2(233855098, 924242519, 1402948791, 601381975, 2120518068, 629187703, 1971977031, 47183124);
            bool4x2 r0 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (1061805787);
            int4x2 b1 = int4x2(1009011238, 312511148, 1460673064, 737210539, 1737844479, 1892405453, 2133024000, 455818693);
            bool4x2 r1 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (2003197687);
            int4x2 b2 = int4x2(1276241219, 534746610, 559824292, 1758388240, 1023494292, 719963017, 1883763832, 597498209);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (367814403);
            int4x2 b3 = int4x2(1839429063, 223575614, 79701214, 1699606118, 759455864, 2017599457, 1395605233, 1191785903);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_not_equal_wide_wide()
        {
            int4x2 a0 = int4x2(1660932106, 982847023, 97046264, 1739517447, 1253499180, 1830584069, 1841470429, 1397841646);
            int4x2 b0 = int4x2(107139049, 75478496, 2055495054, 358586687, 942338347, 111564990, 113811950, 948912488);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int4x2 a1 = int4x2(1770890135, 1906548631, 169082967, 2099271786, 1909317609, 46519139, 1433204003, 931492669);
            int4x2 b1 = int4x2(1080084121, 1400504872, 1032134499, 1061123400, 221862069, 858950046, 989094643, 2023070999);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int4x2 a2 = int4x2(670504132, 1551558665, 1204055048, 1623586740, 226381077, 1145987803, 644253929, 475189890);
            int4x2 b2 = int4x2(1269317127, 531883744, 687761409, 278427731, 296354221, 536981557, 1134676193, 1749879634);
            bool4x2 r2 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int4x2 a3 = int4x2(922313145, 2006448607, 1574579050, 1839580033, 155350910, 313644534, 2008975915, 1072866331);
            int4x2 b3 = int4x2(1944210269, 92849031, 164029425, 628797607, 2069207270, 2022667842, 880567401, 264404537);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_not_equal_wide_scalar()
        {
            int4x2 a0 = int4x2(747758183, 1033001286, 1439973882, 2138928797, 1197845089, 1432672459, 950170763, 238704450);
            int b0 = (248693828);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int4x2 a1 = int4x2(2105962247, 1640688041, 276313906, 2126300423, 791998981, 2035077187, 1171827730, 1412347883);
            int b1 = (727205263);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int4x2 a2 = int4x2(1622176923, 1072798259, 1808712713, 1497830076, 1582645163, 1876273820, 90244766, 30493685);
            int b2 = (768370497);
            bool4x2 r2 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int4x2 a3 = int4x2(904014575, 11554610, 2016093187, 1515760622, 1596313927, 363921847, 1555396158, 913218907);
            int b3 = (384643370);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_not_equal_scalar_wide()
        {
            int a0 = (2076921066);
            int4x2 b0 = int4x2(2037494727, 1989050616, 48833929, 1897435904, 514354517, 1783749164, 364694471, 754315072);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (124108032);
            int4x2 b1 = int4x2(1512967900, 1178825850, 1854793298, 50286949, 2100802631, 1640811853, 82110247, 472172806);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (266984506);
            int4x2 b2 = int4x2(2003668365, 1826089250, 1041416160, 356140110, 2057237962, 799920703, 1916347720, 510966350);
            bool4x2 r2 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (572038024);
            int4x2 b3 = int4x2(1936481966, 1366859342, 1775285431, 604757336, 1047551607, 1311703338, 676012224, 627370253);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_less_wide_wide()
        {
            int4x2 a0 = int4x2(1182186063, 415538999, 1667335818, 1566618442, 1166180837, 639095188, 1080836365, 771119973);
            int4x2 b0 = int4x2(524633529, 1032195686, 760723389, 1505751409, 431962172, 1287906509, 1560084663, 1450178202);
            bool4x2 r0 = bool4x2(false, true, false, false, false, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int4x2 a1 = int4x2(928263233, 789225474, 665243110, 1003542034, 1032480172, 1961336172, 923379558, 21210619);
            int4x2 b1 = int4x2(2066166337, 1107069023, 1640077524, 2103263105, 684229139, 1234033624, 1278743281, 1953079347);
            bool4x2 r1 = bool4x2(true, true, true, true, false, false, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int4x2 a2 = int4x2(1089772116, 1707633052, 778986024, 158153146, 336715101, 1839141169, 1706859710, 1928438162);
            int4x2 b2 = int4x2(1228832942, 2082539723, 1088437561, 1058382082, 207459172, 750531081, 2015788562, 2126542133);
            bool4x2 r2 = bool4x2(true, true, true, true, false, false, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int4x2 a3 = int4x2(1638101724, 2044698552, 1543260981, 471462349, 1668575142, 2147199161, 946870864, 582371851);
            int4x2 b3 = int4x2(271967348, 1601249324, 1373999400, 1689592186, 459759541, 983106679, 332584818, 2034921203);
            bool4x2 r3 = bool4x2(false, false, false, true, false, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_less_wide_scalar()
        {
            int4x2 a0 = int4x2(608447185, 818840405, 869219329, 2080125385, 1214500548, 1361741203, 1667165786, 1615392341);
            int b0 = (1491216667);
            bool4x2 r0 = bool4x2(true, true, true, false, true, true, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int4x2 a1 = int4x2(840091491, 1247103789, 315321650, 930950514, 1100560246, 933855388, 908563901, 1127696709);
            int b1 = (469591900);
            bool4x2 r1 = bool4x2(false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int4x2 a2 = int4x2(1286331950, 971148054, 1827886929, 1056649851, 1579735991, 689044913, 1960894027, 371987110);
            int b2 = (380753337);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int4x2 a3 = int4x2(867559111, 1698536333, 41716206, 243673862, 1274625476, 611065092, 118750042, 1829327996);
            int b3 = (1703747625);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_less_scalar_wide()
        {
            int a0 = (548436837);
            int4x2 b0 = int4x2(282703327, 14370648, 1862117300, 1304793311, 826073259, 988910157, 445132446, 1139670255);
            bool4x2 r0 = bool4x2(false, false, true, true, true, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (111349251);
            int4x2 b1 = int4x2(1102440676, 112183144, 1594415311, 1890019295, 2098715503, 608933527, 183989010, 1596056507);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (1027318999);
            int4x2 b2 = int4x2(146281093, 358911716, 874278078, 1106057699, 1256807459, 2111973919, 1736480659, 810406400);
            bool4x2 r2 = bool4x2(false, false, false, true, true, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (1329939911);
            int4x2 b3 = int4x2(1276652605, 593690439, 771851138, 590897155, 386688344, 1290583204, 1984930954, 743544838);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_greater_wide_wide()
        {
            int4x2 a0 = int4x2(592884447, 2133928932, 918957182, 1284069471, 194584707, 739120780, 241654068, 1340158550);
            int4x2 b0 = int4x2(138737040, 192863971, 1700841444, 1044631301, 1391589821, 730837695, 253553987, 2078872742);
            bool4x2 r0 = bool4x2(true, true, false, true, false, true, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int4x2 a1 = int4x2(2099542537, 1182623667, 1399607274, 789301637, 180400925, 594688333, 1877031463, 1360073500);
            int4x2 b1 = int4x2(910845808, 976047676, 202633078, 1223618940, 641600530, 1830470354, 1570701388, 1104256103);
            bool4x2 r1 = bool4x2(true, true, true, false, false, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int4x2 a2 = int4x2(1091782422, 546676424, 348221770, 716039145, 458742739, 1365508046, 1523167942, 1574478622);
            int4x2 b2 = int4x2(1838646932, 740166101, 1549021845, 1457092873, 1790630950, 907793213, 555122804, 1418910265);
            bool4x2 r2 = bool4x2(false, false, false, false, false, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int4x2 a3 = int4x2(1295065160, 715285504, 1130323487, 677530432, 1496919050, 12463046, 1106153111, 1315083485);
            int4x2 b3 = int4x2(335209251, 1094341422, 1465325455, 390251369, 910309992, 277356652, 1601082764, 771366966);
            bool4x2 r3 = bool4x2(true, false, false, true, true, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_greater_wide_scalar()
        {
            int4x2 a0 = int4x2(1097138316, 211763648, 1883002501, 56406996, 43662641, 1923456111, 1437755186, 1219010035);
            int b0 = (438688675);
            bool4x2 r0 = bool4x2(true, false, true, false, false, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int4x2 a1 = int4x2(2125058448, 893125636, 48044515, 711945018, 1035679270, 577943770, 572743717, 1016617211);
            int b1 = (304028799);
            bool4x2 r1 = bool4x2(true, true, false, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int4x2 a2 = int4x2(2063134811, 64009107, 1462961460, 1143565920, 3715845, 689362811, 263973424, 1045140419);
            int b2 = (1577403353);
            bool4x2 r2 = bool4x2(true, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int4x2 a3 = int4x2(1058332184, 1183316983, 1107974092, 212839726, 523727054, 112709358, 614746280, 1000986708);
            int b3 = (524569092);
            bool4x2 r3 = bool4x2(true, true, true, false, false, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_greater_scalar_wide()
        {
            int a0 = (2024896938);
            int4x2 b0 = int4x2(599356784, 185671342, 1932327391, 2025591013, 1257191721, 1312388500, 1443698859, 779217735);
            bool4x2 r0 = bool4x2(true, true, true, false, true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (691047512);
            int4x2 b1 = int4x2(741776730, 732565983, 668302204, 1556466996, 858599525, 1896917159, 701542098, 1052151621);
            bool4x2 r1 = bool4x2(false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (1023307544);
            int4x2 b2 = int4x2(1435392907, 1858177345, 299897686, 632930355, 1387203601, 483722222, 863042711, 1713088900);
            bool4x2 r2 = bool4x2(false, false, true, true, false, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (315569296);
            int4x2 b3 = int4x2(292652611, 1002628348, 927789921, 108145064, 425005337, 2093233588, 2063431853, 2079035844);
            bool4x2 r3 = bool4x2(true, false, false, true, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_less_equal_wide_wide()
        {
            int4x2 a0 = int4x2(1577248162, 2043073061, 1688380407, 176431985, 223299035, 1502802140, 1691709825, 386789394);
            int4x2 b0 = int4x2(903445031, 2108974565, 210822256, 1281704747, 453681718, 66138830, 1229799377, 1620922595);
            bool4x2 r0 = bool4x2(false, true, false, true, true, false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int4x2 a1 = int4x2(117182003, 1665770435, 1958490731, 420032601, 1251092689, 2011681765, 749743684, 183784440);
            int4x2 b1 = int4x2(1715833766, 1366430432, 13102000, 46919981, 486470891, 1709514236, 2145785285, 854254454);
            bool4x2 r1 = bool4x2(true, false, false, false, false, false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int4x2 a2 = int4x2(1150674774, 1633828822, 1719442172, 336047314, 743733218, 1393995865, 1854442658, 1498138884);
            int4x2 b2 = int4x2(1273278658, 810263315, 1862773824, 201799013, 974166844, 1320622967, 2058099616, 522102017);
            bool4x2 r2 = bool4x2(true, false, true, false, true, false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int4x2 a3 = int4x2(912169992, 1992682021, 1619593455, 1883313982, 483412430, 857881876, 346624138, 531961063);
            int4x2 b3 = int4x2(620752145, 1213693681, 1281818305, 1564146162, 1996153080, 1201909516, 614401396, 224997397);
            bool4x2 r3 = bool4x2(false, false, false, false, true, true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_less_equal_wide_scalar()
        {
            int4x2 a0 = int4x2(1722165358, 1219858357, 860410743, 411099660, 348104022, 1963256951, 212084836, 58924407);
            int b0 = (1688048545);
            bool4x2 r0 = bool4x2(false, true, true, true, true, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int4x2 a1 = int4x2(1459242706, 532949158, 262559763, 690091301, 1806172431, 2091514001, 1857173043, 1617221948);
            int b1 = (1745758438);
            bool4x2 r1 = bool4x2(true, true, true, true, false, false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int4x2 a2 = int4x2(2017733017, 981729559, 2032949254, 910922522, 2079225209, 26179915, 238796519, 1917813750);
            int b2 = (804204255);
            bool4x2 r2 = bool4x2(false, false, false, false, false, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int4x2 a3 = int4x2(1258115260, 1337879822, 959460446, 1599429457, 1279143037, 1551937606, 626254356, 1162369122);
            int b3 = (20607406);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_less_equal_scalar_wide()
        {
            int a0 = (1777585);
            int4x2 b0 = int4x2(1181030049, 1787703989, 1729760948, 1816537388, 1359786460, 874999193, 1678863148, 1711365839);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (762067160);
            int4x2 b1 = int4x2(11953554, 1131583906, 1175393186, 1293698493, 48893340, 66196247, 1958607116, 1576473309);
            bool4x2 r1 = bool4x2(false, true, true, true, false, false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (861890786);
            int4x2 b2 = int4x2(478252419, 957887737, 117849810, 1348693584, 105489302, 259034238, 530713566, 601413850);
            bool4x2 r2 = bool4x2(false, true, false, true, false, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (830430286);
            int4x2 b3 = int4x2(145552297, 1697295044, 1150680564, 2091065664, 1796096704, 1572008712, 1556906486, 205552788);
            bool4x2 r3 = bool4x2(false, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_greater_equal_wide_wide()
        {
            int4x2 a0 = int4x2(263000030, 744235661, 1893760267, 237248, 1062370984, 1676977687, 816766880, 1089431546);
            int4x2 b0 = int4x2(1395535146, 1178373944, 1237373760, 1364855321, 600811864, 362060472, 290870624, 1839067862);
            bool4x2 r0 = bool4x2(false, false, true, false, true, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int4x2 a1 = int4x2(1394493730, 1176473380, 1193988637, 1703862455, 1806186947, 1253571980, 589397635, 1951842887);
            int4x2 b1 = int4x2(396958580, 1336888643, 1019684398, 1697684196, 1227300220, 2044269675, 1898323839, 874509380);
            bool4x2 r1 = bool4x2(true, false, true, true, true, false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int4x2 a2 = int4x2(798931197, 808426484, 744869638, 1959531616, 207430702, 1533946595, 1148381840, 2011549474);
            int4x2 b2 = int4x2(1873505472, 1268843918, 1606949562, 1263896445, 1805518202, 1412091359, 1240330374, 1955056253);
            bool4x2 r2 = bool4x2(false, false, false, true, false, true, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int4x2 a3 = int4x2(605043041, 1707339660, 2038122892, 345761584, 1839156338, 1519670644, 2131285427, 775457686);
            int4x2 b3 = int4x2(2025187918, 750755999, 869709740, 1390799279, 1194035112, 666460047, 103451220, 1311530792);
            bool4x2 r3 = bool4x2(false, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_greater_equal_wide_scalar()
        {
            int4x2 a0 = int4x2(2112791350, 1043657935, 101764761, 1529909067, 556026890, 281734132, 1186600258, 815093894);
            int b0 = (1470533736);
            bool4x2 r0 = bool4x2(true, false, false, true, false, false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int4x2 a1 = int4x2(609211196, 829548642, 244604867, 1419295004, 471843809, 1819986195, 1460027917, 1646290021);
            int b1 = (1604309397);
            bool4x2 r1 = bool4x2(false, false, false, false, false, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int4x2 a2 = int4x2(196833647, 1905036391, 1771391775, 1584946560, 370941146, 440219668, 1607345862, 1449142607);
            int b2 = (1596738181);
            bool4x2 r2 = bool4x2(false, true, true, false, false, false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int4x2 a3 = int4x2(1223010129, 1719435169, 258833609, 1389585003, 612593660, 42612027, 1138747386, 1491562090);
            int b3 = (379014762);
            bool4x2 r3 = bool4x2(true, true, false, true, true, false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_greater_equal_scalar_wide()
        {
            int a0 = (1525542481);
            int4x2 b0 = int4x2(1503244746, 861711266, 817773856, 925984572, 571221723, 683686810, 118252990, 1653952090);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (1240253990);
            int4x2 b1 = int4x2(1947039008, 1869136019, 152012637, 1214546726, 917376832, 303549425, 2111728811, 945321577);
            bool4x2 r1 = bool4x2(false, false, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (173706579);
            int4x2 b2 = int4x2(625318949, 519443238, 1583588379, 1026799433, 1713083717, 394922760, 1216218189, 1336522452);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (233894308);
            int4x2 b3 = int4x2(479913036, 984991199, 172993285, 2121050903, 465645173, 788510727, 337378780, 273010835);
            bool4x2 r3 = bool4x2(false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_add_wide_wide()
        {
            int4x2 a0 = int4x2(2049228671, 1658660009, 491719392, 937013355, 81108663, 1063894558, 86954702, 843159721);
            int4x2 b0 = int4x2(2088751567, 645762023, 306868786, 4360271, 506047997, 2094559874, 1634712736, 1601474440);
            int4x2 r0 = int4x2(-156987058, -1990545264, 798588178, 941373626, 587156660, -1136512864, 1721667438, -1850333135);
            TestUtils.AreEqual(a0 + b0, r0);

            int4x2 a1 = int4x2(698977704, 192867135, 1683407172, 137301303, 2103582820, 526139155, 447937230, 2127411006);
            int4x2 b1 = int4x2(1586485231, 908746788, 1812370320, 1247342357, 2043773873, 223363428, 175115707, 985928617);
            int4x2 r1 = int4x2(-2009504361, 1101613923, -799189804, 1384643660, -147610603, 749502583, 623052937, -1181627673);
            TestUtils.AreEqual(a1 + b1, r1);

            int4x2 a2 = int4x2(1670579390, 1914969141, 997691756, 857841794, 2129024875, 267535529, 978891383, 657092366);
            int4x2 b2 = int4x2(507662836, 1231457019, 776127866, 607782424, 1160366210, 1384832242, 702057048, 703554905);
            int4x2 r2 = int4x2(-2116725070, -1148541136, 1773819622, 1465624218, -1005576211, 1652367771, 1680948431, 1360647271);
            TestUtils.AreEqual(a2 + b2, r2);

            int4x2 a3 = int4x2(941872903, 906908654, 1940071697, 862186205, 1951450264, 689662850, 1928213278, 1703906688);
            int4x2 b3 = int4x2(2106992817, 1994483489, 539473, 236858351, 411317652, 595429166, 713649927, 2053476603);
            int4x2 r3 = int4x2(-1246101576, -1393575153, 1940611170, 1099044556, -1932199380, 1285092016, -1653104091, -537584005);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_add_wide_scalar()
        {
            int4x2 a0 = int4x2(2038218457, 134923711, 875689667, 1338884463, 997710928, 340490871, 1067888129, 70433301);
            int b0 = (2124409227);
            int4x2 r0 = int4x2(-132339612, -2035634358, -1294868402, -831673606, -1172847141, -1830067198, -1102669940, -2100124768);
            TestUtils.AreEqual(a0 + b0, r0);

            int4x2 a1 = int4x2(2003021861, 1160398286, 85446202, 1068152966, 1239387100, 1497676888, 1727477485, 1095438654);
            int b1 = (1635971971);
            int4x2 r1 = int4x2(-655973464, -1498597039, 1721418173, -1590842359, -1419608225, -1161318437, -931517840, -1563556671);
            TestUtils.AreEqual(a1 + b1, r1);

            int4x2 a2 = int4x2(756559204, 658923552, 1610518921, 1585755398, 692843300, 1068593469, 1704776233, 577782260);
            int b2 = (1818718931);
            int4x2 r2 = int4x2(-1719689161, -1817324813, -865729444, -890492967, -1783405065, -1407654896, -771472132, -1898466105);
            TestUtils.AreEqual(a2 + b2, r2);

            int4x2 a3 = int4x2(736972565, 564257439, 2051736283, 1572837697, 1628006545, 1855700263, 656748782, 272774516);
            int b3 = (711894571);
            int4x2 r3 = int4x2(1448867136, 1276152010, -1531336442, -2010235028, -1955066180, -1727372462, 1368643353, 984669087);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_add_scalar_wide()
        {
            int a0 = (391092078);
            int4x2 b0 = int4x2(519908870, 851424292, 328314822, 135622204, 740923360, 655394201, 1451896269, 1781697072);
            int4x2 r0 = int4x2(911000948, 1242516370, 719406900, 526714282, 1132015438, 1046486279, 1842988347, -2122178146);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (996031825);
            int4x2 b1 = int4x2(1557774949, 779774940, 1111541302, 783046445, 1130163944, 288279584, 1397683861, 1636583489);
            int4x2 r1 = int4x2(-1741160522, 1775806765, 2107573127, 1779078270, 2126195769, 1284311409, -1901251610, -1662351982);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (673263339);
            int4x2 b2 = int4x2(1469300874, 14855965, 1116636999, 1488863300, 1600990886, 190651301, 1307459768, 920085839);
            int4x2 r2 = int4x2(2142564213, 688119304, 1789900338, -2132840657, -2020713071, 863914640, 1980723107, 1593349178);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (2082229835);
            int4x2 b3 = int4x2(1992405574, 1213924458, 505841452, 981421162, 1488337699, 1113826640, 1806146508, 1841791222);
            int4x2 r3 = int4x2(-220331887, -998813003, -1706896009, -1231316299, -724399762, -1098910821, -406590953, -370946239);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_sub_wide_wide()
        {
            int4x2 a0 = int4x2(1353441118, 797269833, 659988112, 56022121, 365847472, 2062899435, 1380988474, 799885138);
            int4x2 b0 = int4x2(1332656812, 1827794007, 972557431, 2078233689, 1508184327, 1372307701, 810327977, 936799885);
            int4x2 r0 = int4x2(20784306, -1030524174, -312569319, -2022211568, -1142336855, 690591734, 570660497, -136914747);
            TestUtils.AreEqual(a0 - b0, r0);

            int4x2 a1 = int4x2(1306058185, 579775276, 1239163824, 344591081, 86359575, 1049709943, 721529513, 1767221271);
            int4x2 b1 = int4x2(71562303, 1418723328, 1971342989, 1226053395, 136565478, 1979903295, 600719425, 837912956);
            int4x2 r1 = int4x2(1234495882, -838948052, -732179165, -881462314, -50205903, -930193352, 120810088, 929308315);
            TestUtils.AreEqual(a1 - b1, r1);

            int4x2 a2 = int4x2(7652784, 545192611, 176298787, 1477774126, 1426963688, 2032787858, 2059525977, 445200454);
            int4x2 b2 = int4x2(632054793, 711091688, 904695656, 1640069560, 750244414, 1385118097, 1102391291, 1221949855);
            int4x2 r2 = int4x2(-624402009, -165899077, -728396869, -162295434, 676719274, 647669761, 957134686, -776749401);
            TestUtils.AreEqual(a2 - b2, r2);

            int4x2 a3 = int4x2(425848588, 2026967474, 1128492011, 61421784, 988065731, 1741434432, 2070331135, 1356704176);
            int4x2 b3 = int4x2(609588723, 1054324682, 1678086165, 1529581776, 1718700085, 523422634, 223602473, 1912611694);
            int4x2 r3 = int4x2(-183740135, 972642792, -549594154, -1468159992, -730634354, 1218011798, 1846728662, -555907518);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_sub_wide_scalar()
        {
            int4x2 a0 = int4x2(1176369558, 1934521195, 309452150, 1417634074, 108910717, 1306356714, 1502312334, 1451794815);
            int b0 = (462232403);
            int4x2 r0 = int4x2(714137155, 1472288792, -152780253, 955401671, -353321686, 844124311, 1040079931, 989562412);
            TestUtils.AreEqual(a0 - b0, r0);

            int4x2 a1 = int4x2(281174200, 1913724431, 2041593336, 557239990, 1119051448, 1590376732, 819090189, 816382635);
            int b1 = (87530840);
            int4x2 r1 = int4x2(193643360, 1826193591, 1954062496, 469709150, 1031520608, 1502845892, 731559349, 728851795);
            TestUtils.AreEqual(a1 - b1, r1);

            int4x2 a2 = int4x2(815920639, 1792801932, 1113440549, 1418937976, 1277257189, 2092779398, 642236742, 1605250794);
            int b2 = (1829033117);
            int4x2 r2 = int4x2(-1013112478, -36231185, -715592568, -410095141, -551775928, 263746281, -1186796375, -223782323);
            TestUtils.AreEqual(a2 - b2, r2);

            int4x2 a3 = int4x2(819644478, 128303186, 553494257, 1017126971, 1999744782, 2017272758, 1817991764, 1280985500);
            int b3 = (1468003019);
            int4x2 r3 = int4x2(-648358541, -1339699833, -914508762, -450876048, 531741763, 549269739, 349988745, -187017519);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_sub_scalar_wide()
        {
            int a0 = (1691534405);
            int4x2 b0 = int4x2(2022393810, 1612688515, 496689713, 887037586, 2097630964, 374934538, 939035482, 935242277);
            int4x2 r0 = int4x2(-330859405, 78845890, 1194844692, 804496819, -406096559, 1316599867, 752498923, 756292128);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (1789300421);
            int4x2 b1 = int4x2(264712893, 1231856067, 1818112748, 1428436109, 1258745460, 1077380396, 1330722719, 518111829);
            int4x2 r1 = int4x2(1524587528, 557444354, -28812327, 360864312, 530554961, 711920025, 458577702, 1271188592);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (967128529);
            int4x2 b2 = int4x2(344666254, 1082267918, 907866696, 1816885123, 460340568, 962154498, 557113461, 1701216709);
            int4x2 r2 = int4x2(622462275, -115139389, 59261833, -849756594, 506787961, 4974031, 410015068, -734088180);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (1980098777);
            int4x2 b3 = int4x2(730060552, 1444397827, 853570556, 138836432, 1013190428, 718089530, 506757390, 1216448041);
            int4x2 r3 = int4x2(1250038225, 535700950, 1126528221, 1841262345, 966908349, 1262009247, 1473341387, 763650736);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_mul_wide_wide()
        {
            int4x2 a0 = int4x2(245827027, 208934650, 1019478917, 568231809, 877289039, 1585782440, 2111178729, 1186019069);
            int4x2 b0 = int4x2(759663997, 350129201, 477450108, 1635735015, 388710278, 757722665, 1509388321, 1841703980);
            int4x2 r0 = int4x2(-632811769, 1402281434, 332447596, -1932977561, -1670918566, 1455036648, 2128344329, -594088068);
            TestUtils.AreEqual(a0 * b0, r0);

            int4x2 a1 = int4x2(571481445, 1570087048, 629447153, 619383734, 2055121568, 700402816, 263414349, 187830569);
            int4x2 b1 = int4x2(1826369331, 1524322467, 1605207974, 428419155, 1460605791, 1968043860, 771161742, 2037340417);
            int4x2 r1 = int4x2(-1654168033, 2093463192, -1207506618, -1133560830, 990589280, -938173952, -1341723466, 1156600361);
            TestUtils.AreEqual(a1 * b1, r1);

            int4x2 a2 = int4x2(2048056680, 546694675, 853585367, 933370718, 990212476, 1915885905, 1984212358, 368146234);
            int4x2 b2 = int4x2(322304267, 651448359, 1608326767, 1427155898, 1092185338, 665119139, 223634707, 694718952);
            int4x2 r2 = int4x2(649177976, 678952165, 1063621177, -1611682740, -2142428392, -573253741, -1652113678, 1626072720);
            TestUtils.AreEqual(a2 * b2, r2);

            int4x2 a3 = int4x2(899438811, 1765718681, 409003054, 2069758852, 140280263, 442491280, 1924530939, 1372320666);
            int4x2 b3 = int4x2(675813713, 999254223, 1326064110, 788102700, 1927999142, 1706356773, 747671596, 106127297);
            int4x2 r3 = int4x2(1891467339, 335415735, 1128927428, -1656253776, -1433851638, 479369680, -366628060, -250163942);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_mul_wide_scalar()
        {
            int4x2 a0 = int4x2(1762033447, 465343930, 1570757881, 1326409563, 1824319147, 1356578909, 72749215, 154616909);
            int b0 = (1476837906);
            int4x2 r0 = int4x2(-1313177922, 1326807828, -2138555518, -276153754, -65548794, -1318584182, -1839224530, -1720506518);
            TestUtils.AreEqual(a0 * b0, r0);

            int4x2 a1 = int4x2(975743632, 1958912969, 971327747, 1818877398, 1324050764, 660611671, 1279757657, 391009467);
            int b1 = (573770299);
            int4x2 r1 = int4x2(414773040, -699623085, 1045098929, -1129153454, 1954692228, 970215437, 1522404739, 631100697);
            TestUtils.AreEqual(a1 * b1, r1);

            int4x2 a2 = int4x2(1186856590, 800117742, 606927173, 1338014500, 1688964615, 1439447294, 387721300, 1192501703);
            int b2 = (890343818);
            int4x2 r2 = int4x2(218605196, 908725324, -805080014, -1528445592, 1365477062, 1262261996, 2040090952, 691203142);
            TestUtils.AreEqual(a2 * b2, r2);

            int4x2 a3 = int4x2(1613845584, 124378112, 970518733, 1370700538, 1978842602, 1451974062, 987919119, 1659987051);
            int b3 = (76318055);
            int4x2 r3 = int4x2(-1335460816, 1256424448, -545299589, 628661398, 357366566, 753276674, 2132219401, -825295347);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_mul_scalar_wide()
        {
            int a0 = (99541948);
            int4x2 b0 = int4x2(1764461774, 657072478, 1459784358, 1610646683, 1632058826, 868441654, 1408757883, 335917146);
            int4x2 r0 = int4x2(-950398648, -102049016, 1260585960, 1158730452, -1606056, -466153048, 2108402516, 1966690328);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (2105124483);
            int4x2 b1 = int4x2(1178393968, 1963904348, 1409533767, 243286231, 1336308795, 517963367, 1733623488, 459880225);
            int4x2 r1 = int4x2(-1028919216, 2084093460, 1286996821, 910923781, 1886305329, -1039959883, 644799552, 1815059427);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (994616533);
            int4x2 b2 = int4x2(1420531535, 1821413700, 677771573, 2132626845, 1158827713, 640102997, 944551639, 1323243330);
            int4x2 r2 = int4x2(585859259, 2021158292, 1046891801, -1941821535, -738776427, -1715252039, -160572189, 1259643370);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (1186460236);
            int4x2 b3 = int4x2(657101857, 1275563580, 1031291523, 1008470115, 1155301041, 1046199281, 2138825098, 1273008873);
            int4x2 r3 = int4x2(-901633076, -879300144, 1278776548, 1761940324, -675287412, 2049744268, -375297800, -1944395988);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_div_wide_wide()
        {
            int4x2 a0 = int4x2(1590198532, 507812502, 126627032, 1058247011, 427387861, 290676154, 1829594484, 1127868739);
            int4x2 b0 = int4x2(1434703236, 911965201, 390415521, 128746927, 525835375, 816946613, 878264647, 146789678);
            int4x2 r0 = int4x2(1, 0, 0, 8, 0, 0, 2, 7);
            TestUtils.AreEqual(a0 / b0, r0);

            int4x2 a1 = int4x2(499016351, 1341209632, 134906097, 785470242, 788249865, 1099825433, 1552968283, 1822367139);
            int4x2 b1 = int4x2(2089524057, 254213018, 1916850021, 1737806518, 1906634983, 437754923, 825037958, 902508708);
            int4x2 r1 = int4x2(0, 5, 0, 0, 0, 2, 1, 2);
            TestUtils.AreEqual(a1 / b1, r1);

            int4x2 a2 = int4x2(1021812060, 1937073018, 645757349, 1097576782, 1246027674, 1152153253, 1900577195, 172149343);
            int4x2 b2 = int4x2(896853614, 49452028, 1921327824, 787000669, 1032149621, 858558868, 1422112429, 837098844);
            int4x2 r2 = int4x2(1, 39, 0, 1, 1, 1, 1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int4x2 a3 = int4x2(1735128704, 816492592, 2012272185, 632330092, 649232994, 123715336, 1438073735, 723262291);
            int4x2 b3 = int4x2(616122946, 2035322800, 1324534444, 1820832158, 917489631, 367475696, 620492088, 1749833550);
            int4x2 r3 = int4x2(2, 0, 1, 0, 0, 0, 2, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_div_wide_scalar()
        {
            int4x2 a0 = int4x2(560951562, 1218680769, 375341724, 1613542090, 1919409166, 1397425408, 1349573078, 524526253);
            int b0 = (947861580);
            int4x2 r0 = int4x2(0, 1, 0, 1, 2, 1, 1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int4x2 a1 = int4x2(341995568, 1515313790, 1676971657, 2131487088, 2105094094, 1017891310, 542666029, 1646044372);
            int b1 = (495895326);
            int4x2 r1 = int4x2(0, 3, 3, 4, 4, 2, 1, 3);
            TestUtils.AreEqual(a1 / b1, r1);

            int4x2 a2 = int4x2(1447236569, 19616726, 896899915, 707389627, 1249475421, 1486968988, 1738891885, 1919705924);
            int b2 = (107215658);
            int4x2 r2 = int4x2(13, 0, 8, 6, 11, 13, 16, 17);
            TestUtils.AreEqual(a2 / b2, r2);

            int4x2 a3 = int4x2(1244966864, 206442634, 1508567412, 1825701056, 1117255783, 929925156, 1725332114, 1949103348);
            int b3 = (1200843642);
            int4x2 r3 = int4x2(1, 0, 1, 1, 0, 0, 1, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_div_scalar_wide()
        {
            int a0 = (1161272038);
            int4x2 b0 = int4x2(187325733, 1594107378, 2016183849, 1589343709, 388768753, 1417077283, 1773486938, 1154044032);
            int4x2 r0 = int4x2(6, 0, 0, 0, 2, 0, 0, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (81831373);
            int4x2 b1 = int4x2(1476877645, 653688843, 45756703, 631027637, 396671391, 784365696, 1250594097, 1818363859);
            int4x2 r1 = int4x2(0, 0, 1, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (1653451772);
            int4x2 b2 = int4x2(270557729, 48974453, 1796936382, 1427856423, 981056957, 1955700573, 705450043, 1054404890);
            int4x2 r2 = int4x2(6, 33, 0, 1, 1, 0, 2, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (351914083);
            int4x2 b3 = int4x2(131970646, 1320586926, 366944102, 1575786200, 257204865, 1582754309, 2114509003, 1266146708);
            int4x2 r3 = int4x2(2, 0, 0, 0, 1, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_mod_wide_wide()
        {
            int4x2 a0 = int4x2(146150818, 1846543305, 1071447756, 308965362, 659881575, 1002365460, 861198439, 1510617532);
            int4x2 b0 = int4x2(983050390, 771341152, 942375212, 367361754, 749500619, 750718852, 2095151755, 88438806);
            int4x2 r0 = int4x2(146150818, 303861001, 129072544, 308965362, 659881575, 251646608, 861198439, 7157830);
            TestUtils.AreEqual(a0 % b0, r0);

            int4x2 a1 = int4x2(778525078, 1458458044, 101987897, 1249565173, 938026607, 1692541775, 1518877124, 1806965510);
            int4x2 b1 = int4x2(769227442, 647214624, 1026513788, 1544950956, 160166322, 1099108075, 1158422232, 1798905209);
            int4x2 r1 = int4x2(9297636, 164028796, 101987897, 1249565173, 137194997, 593433700, 360454892, 8060301);
            TestUtils.AreEqual(a1 % b1, r1);

            int4x2 a2 = int4x2(1325139851, 994457255, 1372400564, 1770508529, 100255877, 452674793, 1545968777, 629019189);
            int4x2 b2 = int4x2(164686701, 327889784, 1082162785, 1213537518, 608481038, 329133821, 1824387961, 1223426748);
            int4x2 r2 = int4x2(7646243, 10787903, 290237779, 556971011, 100255877, 123540972, 1545968777, 629019189);
            TestUtils.AreEqual(a2 % b2, r2);

            int4x2 a3 = int4x2(1402964707, 2138294579, 1641714420, 1782022072, 1880968864, 1980798192, 1397317084, 995968277);
            int4x2 b3 = int4x2(798137669, 79717779, 1233582258, 1267120677, 301592349, 911281434, 1357340934, 1648942990);
            int4x2 r3 = int4x2(604827038, 65632325, 408132162, 514901395, 71414770, 158235324, 39976150, 995968277);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_mod_wide_scalar()
        {
            int4x2 a0 = int4x2(164800505, 1062177828, 1898749675, 1701653318, 820393245, 19002208, 128329633, 1464010899);
            int b0 = (883951171);
            int4x2 r0 = int4x2(164800505, 178226657, 130847333, 817702147, 820393245, 19002208, 128329633, 580059728);
            TestUtils.AreEqual(a0 % b0, r0);

            int4x2 a1 = int4x2(896587769, 1982762194, 959236935, 712321026, 172564850, 1540068445, 1085897743, 1607489717);
            int b1 = (405208598);
            int4x2 r1 = int4x2(86170573, 361927802, 148819739, 307112428, 172564850, 324442651, 275480547, 391863923);
            TestUtils.AreEqual(a1 % b1, r1);

            int4x2 a2 = int4x2(165478511, 915707999, 1602830401, 928191283, 1084934806, 488509689, 2087820912, 377501313);
            int b2 = (647846716);
            int4x2 r2 = int4x2(165478511, 267861283, 307136969, 280344567, 437088090, 488509689, 144280764, 377501313);
            TestUtils.AreEqual(a2 % b2, r2);

            int4x2 a3 = int4x2(1778384846, 812183417, 1153802502, 1642671870, 1924710742, 665297470, 1568090825, 2050982942);
            int b3 = (1216011754);
            int4x2 r3 = int4x2(562373092, 812183417, 1153802502, 426660116, 708698988, 665297470, 352079071, 834971188);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_mod_scalar_wide()
        {
            int a0 = (242383789);
            int4x2 b0 = int4x2(740000543, 1556450291, 1104736385, 437976569, 1911837205, 1507212038, 1906405167, 247693265);
            int4x2 r0 = int4x2(242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789, 242383789);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (293460573);
            int4x2 b1 = int4x2(1495295166, 873323603, 530681233, 1298102643, 2057984657, 1000742091, 1461372131, 1859742342);
            int4x2 r1 = int4x2(293460573, 293460573, 293460573, 293460573, 293460573, 293460573, 293460573, 293460573);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (797184687);
            int4x2 b2 = int4x2(821888842, 1083192997, 840114986, 1894865954, 615159964, 1485575122, 2028738, 2122220318);
            int4x2 r2 = int4x2(797184687, 797184687, 797184687, 797184687, 182024723, 797184687, 1919391, 797184687);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (164578061);
            int4x2 b3 = int4x2(730088119, 1444946139, 1305792037, 1110829011, 872723581, 166847388, 1477846418, 511428733);
            int4x2 r3 = int4x2(164578061, 164578061, 164578061, 164578061, 164578061, 164578061, 164578061, 164578061);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_plus()
        {
            int4x2 a0 = int4x2(1643476803, 907898539, 379615839, 1140483021, 1735287433, 1743199272, 1472881565, 339091479);
            int4x2 r0 = int4x2(1643476803, 907898539, 379615839, 1140483021, 1735287433, 1743199272, 1472881565, 339091479);
            TestUtils.AreEqual(+a0, r0);

            int4x2 a1 = int4x2(401565897, 849339193, 174532915, 1864850812, 1566098441, 1145639744, 1615499926, 2049663954);
            int4x2 r1 = int4x2(401565897, 849339193, 174532915, 1864850812, 1566098441, 1145639744, 1615499926, 2049663954);
            TestUtils.AreEqual(+a1, r1);

            int4x2 a2 = int4x2(1723005749, 591286416, 1706631096, 1079164488, 1808261782, 1201290141, 82958939, 308695413);
            int4x2 r2 = int4x2(1723005749, 591286416, 1706631096, 1079164488, 1808261782, 1201290141, 82958939, 308695413);
            TestUtils.AreEqual(+a2, r2);

            int4x2 a3 = int4x2(1575280693, 1673126612, 500666137, 640289062, 836003812, 336058393, 829347661, 33442669);
            int4x2 r3 = int4x2(1575280693, 1673126612, 500666137, 640289062, 836003812, 336058393, 829347661, 33442669);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_neg()
        {
            int4x2 a0 = int4x2(1955022112, 662160019, 370300775, 2141283773, 1004505619, 28153593, 33894270, 505708349);
            int4x2 r0 = int4x2(-1955022112, -662160019, -370300775, -2141283773, -1004505619, -28153593, -33894270, -505708349);
            TestUtils.AreEqual(-a0, r0);

            int4x2 a1 = int4x2(1115028238, 694995093, 1542206286, 213087293, 243937487, 341522275, 841085242, 574159094);
            int4x2 r1 = int4x2(-1115028238, -694995093, -1542206286, -213087293, -243937487, -341522275, -841085242, -574159094);
            TestUtils.AreEqual(-a1, r1);

            int4x2 a2 = int4x2(1687250035, 1175014732, 1259809073, 1212465326, 1190569920, 2047955772, 2120729864, 1440774928);
            int4x2 r2 = int4x2(-1687250035, -1175014732, -1259809073, -1212465326, -1190569920, -2047955772, -2120729864, -1440774928);
            TestUtils.AreEqual(-a2, r2);

            int4x2 a3 = int4x2(1485596454, 1387601718, 1745651998, 319115626, 1119959806, 739132284, 1954173314, 1709857098);
            int4x2 r3 = int4x2(-1485596454, -1387601718, -1745651998, -319115626, -1119959806, -739132284, -1954173314, -1709857098);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_prefix_inc()
        {
            int4x2 a0 = int4x2(864455342, 2035793213, 1275443862, 971919915, 411610189, 446210725, 395072276, 115573442);
            int4x2 r0 = int4x2(864455343, 2035793214, 1275443863, 971919916, 411610190, 446210726, 395072277, 115573443);
            TestUtils.AreEqual(++a0, r0);

            int4x2 a1 = int4x2(913293639, 1208161871, 1385544935, 1835605516, 831396561, 388229350, 696475402, 1786514683);
            int4x2 r1 = int4x2(913293640, 1208161872, 1385544936, 1835605517, 831396562, 388229351, 696475403, 1786514684);
            TestUtils.AreEqual(++a1, r1);

            int4x2 a2 = int4x2(993189311, 1622410417, 1398865015, 241906003, 1705625817, 609525897, 172599489, 504806865);
            int4x2 r2 = int4x2(993189312, 1622410418, 1398865016, 241906004, 1705625818, 609525898, 172599490, 504806866);
            TestUtils.AreEqual(++a2, r2);

            int4x2 a3 = int4x2(519296647, 1541894135, 924683935, 259568871, 1349062584, 1120518661, 65514038, 1495168208);
            int4x2 r3 = int4x2(519296648, 1541894136, 924683936, 259568872, 1349062585, 1120518662, 65514039, 1495168209);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_postfix_inc()
        {
            int4x2 a0 = int4x2(1751003569, 2063707595, 1500486291, 969189211, 1007848192, 2028651936, 1643023524, 1190630527);
            int4x2 r0 = int4x2(1751003569, 2063707595, 1500486291, 969189211, 1007848192, 2028651936, 1643023524, 1190630527);
            TestUtils.AreEqual(a0++, r0);

            int4x2 a1 = int4x2(1396179607, 177416855, 1524860667, 1408994706, 375284401, 1580130369, 1676086778, 717006530);
            int4x2 r1 = int4x2(1396179607, 177416855, 1524860667, 1408994706, 375284401, 1580130369, 1676086778, 717006530);
            TestUtils.AreEqual(a1++, r1);

            int4x2 a2 = int4x2(506142468, 2026873940, 130175844, 1513142653, 420613464, 1219979307, 586574160, 357567451);
            int4x2 r2 = int4x2(506142468, 2026873940, 130175844, 1513142653, 420613464, 1219979307, 586574160, 357567451);
            TestUtils.AreEqual(a2++, r2);

            int4x2 a3 = int4x2(1468020171, 1127356901, 101238629, 2131648021, 423320704, 827539403, 1919960927, 840371710);
            int4x2 r3 = int4x2(1468020171, 1127356901, 101238629, 2131648021, 423320704, 827539403, 1919960927, 840371710);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_prefix_dec()
        {
            int4x2 a0 = int4x2(200904609, 871077500, 968578728, 638967721, 1995396216, 435367037, 1782514098, 1589827826);
            int4x2 r0 = int4x2(200904608, 871077499, 968578727, 638967720, 1995396215, 435367036, 1782514097, 1589827825);
            TestUtils.AreEqual(--a0, r0);

            int4x2 a1 = int4x2(1434377580, 1699290403, 1758478358, 1914114460, 71237375, 389120307, 1022184392, 1310293956);
            int4x2 r1 = int4x2(1434377579, 1699290402, 1758478357, 1914114459, 71237374, 389120306, 1022184391, 1310293955);
            TestUtils.AreEqual(--a1, r1);

            int4x2 a2 = int4x2(356565557, 906734601, 799006218, 1383897383, 1040798388, 1469596990, 1719228297, 220897829);
            int4x2 r2 = int4x2(356565556, 906734600, 799006217, 1383897382, 1040798387, 1469596989, 1719228296, 220897828);
            TestUtils.AreEqual(--a2, r2);

            int4x2 a3 = int4x2(1454322707, 14227726, 293093918, 1065286595, 1249415499, 1009503100, 157482354, 965385343);
            int4x2 r3 = int4x2(1454322706, 14227725, 293093917, 1065286594, 1249415498, 1009503099, 157482353, 965385342);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_postfix_dec()
        {
            int4x2 a0 = int4x2(283970262, 1109329936, 1073216143, 649439137, 1932646215, 1174104498, 484207852, 524156737);
            int4x2 r0 = int4x2(283970262, 1109329936, 1073216143, 649439137, 1932646215, 1174104498, 484207852, 524156737);
            TestUtils.AreEqual(a0--, r0);

            int4x2 a1 = int4x2(691209285, 802721301, 377162390, 526366486, 1504625034, 590919177, 60677868, 1867810045);
            int4x2 r1 = int4x2(691209285, 802721301, 377162390, 526366486, 1504625034, 590919177, 60677868, 1867810045);
            TestUtils.AreEqual(a1--, r1);

            int4x2 a2 = int4x2(2095777993, 324944916, 242636153, 1659736954, 1316734088, 1030072405, 1751972064, 1868889881);
            int4x2 r2 = int4x2(2095777993, 324944916, 242636153, 1659736954, 1316734088, 1030072405, 1751972064, 1868889881);
            TestUtils.AreEqual(a2--, r2);

            int4x2 a3 = int4x2(1726583208, 175622377, 181847458, 665549439, 530897466, 635466911, 416440036, 1447690298);
            int4x2 r3 = int4x2(1726583208, 175622377, 181847458, 665549439, 530897466, 635466911, 416440036, 1447690298);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_bitwise_and_wide_wide()
        {
            int4x2 a0 = int4x2(779935043, 1097962163, 1939593304, 800599247, 952140918, 782792558, 1608557706, 396446406);
            int4x2 b0 = int4x2(307705143, 1710882162, 866836769, 532490608, 679371720, 1794035877, 1439832202, 519529812);
            int4x2 r0 = int4x2(39064835, 1097961522, 864731136, 263727168, 675283008, 715673636, 1438646410, 379666500);
            TestUtils.AreEqual(a0 & b0, r0);

            int4x2 a1 = int4x2(2039894114, 1286974642, 442394124, 1759739564, 233435438, 665207770, 1942050241, 1022352952);
            int4x2 b1 = int4x2(23633139, 1209152681, 646737179, 1255867027, 1900854122, 413173763, 1409138251, 2087190272);
            int4x2 r1 = int4x2(16781410, 1209017504, 34366472, 1220739712, 21541162, 10485762, 1405162561, 1013440000);
            TestUtils.AreEqual(a1 & b1, r1);

            int4x2 a2 = int4x2(60340400, 329119345, 406517382, 1126764634, 343425836, 1957552749, 1624478957, 341972372);
            int4x2 b2 = int4x2(563439483, 354579077, 642224854, 1650432515, 755290290, 902865191, 661389406, 2134212586);
            int4x2 r2 = int4x2(26222640, 285241857, 168582, 1107890178, 67125280, 880844837, 541065292, 337646976);
            TestUtils.AreEqual(a2 & b2, r2);

            int4x2 a3 = int4x2(181537307, 130347414, 1240828622, 526120460, 695449226, 1477446724, 201628999, 737924014);
            int4x2 b3 = int4x2(1855189321, 185194029, 810374380, 133197864, 1989578783, 38739182, 387425484, 1690486314);
            int4x2 r3 = int4x2(177340425, 50384900, 4522188, 122712072, 538087434, 3140, 67404868, 549634602);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_bitwise_and_wide_scalar()
        {
            int4x2 a0 = int4x2(443615469, 490057985, 2042441263, 1524760558, 1405175110, 510212004, 1941875181, 1236735839);
            int b0 = (93423598);
            int4x2 r0 = int4x2(1114348, 85033216, 26281518, 8488942, 25232710, 67176356, 26247660, 26281806);
            TestUtils.AreEqual(a0 & b0, r0);

            int4x2 a1 = int4x2(1365509729, 607982857, 650270920, 1249238550, 814629680, 1862276471, 143502472, 861733033);
            int b1 = (428270198);
            int4x2 r1 = int4x2(285475424, 262144, 8536128, 134529558, 277234224, 150995062, 142909440, 285474848);
            TestUtils.AreEqual(a1 & b1, r1);

            int4x2 a2 = int4x2(1408932942, 1567715668, 1102952410, 322053683, 1599352836, 208656708, 1272226025, 462670926);
            int b2 = (957693145);
            int4x2 r2 = int4x2(286268488, 420556880, 18167000, 286270481, 420753408, 134551616, 152314057, 420547656);
            TestUtils.AreEqual(a2 & b2, r2);

            int4x2 a3 = int4x2(1817145060, 1817277774, 818900583, 772681077, 1630437952, 546018772, 872875431, 1143080525);
            int b3 = (1466722981);
            int4x2 r3 = int4x2(1145858724, 1145069572, 273443365, 101460005, 1093403136, 524420, 335806629, 1142948357);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_bitwise_and_scalar_wide()
        {
            int a0 = (1144543590);
            int4x2 b0 = int4x2(420346723, 562416448, 1393127318, 1560699552, 851218057, 703880958, 1159378889, 2031211279);
            int4x2 r0 = int4x2(547170, 18752, 1074284806, 1140867104, 3672064, 3168358, 1142427968, 1074811142);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (1089518981);
            int4x2 b1 = int4x2(270607307, 1349288930, 520199596, 1763483957, 1248975349, 236938635, 185023291, 1085233038);
            int4x2 r1 = int4x2(2105729, 1080066432, 40324, 1074831621, 1081121157, 1058177, 14593, 1084233092);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (1845693112);
            int4x2 b2 = int4x2(946052961, 1436238522, 2042776519, 56356886, 1770159840, 1872339579, 1439201366, 1233066417);
            int4x2 r2 = int4x2(671287840, 1141047992, 1744964224, 33751056, 1744964256, 1845559864, 1140852752, 1208158384);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (1214109404);
            int4x2 b3 = int4x2(2255485, 1814885263, 1711986588, 1286898282, 915476451, 1870138851, 372814411, 1623486506);
            int4x2 r3 = int4x2(16988, 1208799884, 1074321052, 1209303624, 1115840, 1213727936, 1610312, 1078218760);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_bitwise_or_wide_wide()
        {
            int4x2 a0 = int4x2(1731159103, 659068416, 382702471, 1821032196, 1565773438, 1004000514, 948501377, 600951835);
            int4x2 b0 = int4x2(1583847161, 692672727, 1161585489, 1756207130, 1321374429, 1287357212, 2075767170, 1273513430);
            int4x2 r0 = int4x2(2138044159, 793370327, 1476391895, 1823457054, 1607720703, 2147473182, 2075786115, 1811533279);
            TestUtils.AreEqual(a0 | b0, r0);

            int4x2 a1 = int4x2(669346222, 396691477, 2108560248, 2117522137, 330307355, 818676817, 1774459567, 1117506257);
            int4x2 b1 = int4x2(1610830169, 1316929125, 511625048, 573925879, 1502255628, 1841676448, 1682928938, 1115131952);
            int4x2 r1 = int4x2(1743223295, 1610595957, 2147407736, 2117598207, 1538957087, 2110637297, 1842315183, 1124063985);
            TestUtils.AreEqual(a1 | b1, r1);

            int4x2 a2 = int4x2(1254511182, 1017865993, 1883021644, 1140203470, 759288967, 2122744307, 335621148, 715028074);
            int4x2 b2 = int4x2(1541423910, 1416096228, 188606371, 1041599540, 219545389, 560097663, 1087543661, 936383841);
            int4x2 r2 = int4x2(1541821294, 2096099309, 2067654639, 2146934782, 760610735, 2145839615, 1423162749, 1071544171);
            TestUtils.AreEqual(a2 | b2, r2);

            int4x2 a3 = int4x2(543305337, 662107399, 1934997335, 436754869, 1613808671, 362365372, 342908672, 2129231210);
            int4x2 b3 = int4x2(108816721, 1694053551, 452638547, 1219534055, 85142537, 1027930490, 2126839395, 2030328147);
            int4x2 r3 = int4x2(645820281, 1744827823, 2080356183, 1522064887, 1697901599, 1037957630, 2129985379, 2146270587);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_bitwise_or_wide_scalar()
        {
            int4x2 a0 = int4x2(961259683, 471103264, 1733389229, 1591585258, 386953869, 1148351449, 1048929715, 1814263250);
            int b0 = (1666102508);
            int4x2 r0 = int4x2(2068823279, 2136930284, 1734344685, 2145369582, 2002712301, 1736374269, 2144335359, 1869608446);
            TestUtils.AreEqual(a0 | b0, r0);

            int4x2 a1 = int4x2(860336789, 1227888278, 774029856, 879300408, 1179087439, 797240690, 1977614655, 46921989);
            int b1 = (1637162093);
            int4x2 r1 = int4x2(1943518973, 1773477631, 1874321005, 1979522941, 1742175855, 1872100735, 1978998143, 1675623789);
            TestUtils.AreEqual(a1 | b1, r1);

            int4x2 a2 = int4x2(1980838747, 64304104, 313591807, 1393862490, 1890090886, 521303722, 2021379070, 2055963359);
            int b2 = (284225881);
            int4x2 r2 = int4x2(1995567963, 334885881, 317847551, 1408563035, 1895366623, 536016891, 2029779967, 2063332319);
            TestUtils.AreEqual(a2 | b2, r2);

            int4x2 a3 = int4x2(1511253082, 1142751163, 1767274359, 1421981808, 1501294791, 485944015, 539526284, 310877895);
            int b3 = (1775629833);
            int4x2 r3 = int4x2(2077750875, 1843265467, 1775761279, 2111176313, 2046817999, 2113404623, 1778251405, 2077753039);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1213433101);
            int4x2 b0 = int4x2(1212928242, 1614462616, 936937728, 764766995, 306352095, 574719481, 1283571271, 2109131012);
            int4x2 r0 = int4x2(1213978111, 1752940445, 2145094925, 1842867999, 1515425759, 1783858685, 1288945487, 2113391885);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (979469710);
            int4x2 b1 = int4x2(1348323481, 1407542578, 697517649, 1059093741, 627815046, 418822515, 83214352, 424663473);
            int4x2 r1 = int4x2(2055064991, 2078664126, 1005832159, 1063386607, 1064023950, 989314559, 1056294302, 997187007);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (447949225);
            int4x2 b2 = int4x2(527022375, 1947148461, 305251437, 1254601325, 1752329425, 1592402684, 1587055329, 1088734150);
            int4x2 r2 = int4x2(536590767, 2126457261, 447999469, 1526184941, 2062773753, 1593519101, 1589357545, 1526197231);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (298563808);
            int4x2 b3 = int4x2(2052547661, 582843231, 656983670, 1944993640, 1081208038, 829763560, 990961386, 547309556);
            int4x2 r3 = int4x2(2078276845, 872414207, 938213110, 1945092072, 1375468774, 838844392, 1004273386, 836763636);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_bitwise_xor_wide_wide()
        {
            int4x2 a0 = int4x2(1556324760, 207002929, 1843444873, 1632079131, 1460334334, 1607815585, 220623650, 38668553);
            int4x2 b0 = int4x2(1054997548, 1523759632, 251164872, 110472397, 384031112, 1109163205, 535118981, 179106262);
            int4x2 r0 = int4x2(1646419380, 1451501345, 1662567489, 1741824470, 1105803126, 499723620, 314783655, 149092575);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int4x2 a1 = int4x2(47193340, 643663548, 1371932564, 94957188, 700973621, 370621508, 2087573076, 351476570);
            int4x2 b1 = int4x2(1523031711, 1713313372, 1294118730, 520360641, 1040688781, 1020757245, 1143954843, 1281933464);
            int4x2 r1 = int4x2(1477935715, 1078104288, 484747486, 447544389, 399484088, 717273273, 943885263, 1486609346);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int4x2 a2 = int4x2(1340815927, 681577472, 314138777, 446857644, 1368661599, 1672499683, 1259759761, 2049102405);
            int4x2 b2 = int4x2(175288469, 326874157, 1192052687, 1087083643, 1900865484, 1521193463, 569695524, 1622101483);
            int4x2 r2 = int4x2(1167690402, 1004255277, 1437869910, 1516836311, 551090579, 958119956, 1793242549, 445489070);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int4x2 a3 = int4x2(1972524935, 91962333, 1960780785, 1303778459, 960040360, 822786011, 2028027011, 170382968);
            int4x2 b3 = int4x2(1340735463, 546583617, 1034420616, 262206030, 1834125935, 802756092, 611321886, 316379491);
            int4x2 r3 = int4x2(981182560, 636424092, 1232544377, 1108797141, 1416333255, 517186087, 1553020061, 419186459);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_bitwise_xor_wide_scalar()
        {
            int4x2 a0 = int4x2(2124666952, 177397845, 574879617, 1937385541, 1136545648, 213863690, 535061373, 289301586);
            int b0 = (493665894);
            int4x2 r0 = int4x2(1674536494, 402546227, 1060063719, 1846973987, 1590882582, 299103084, 42523931, 206756404);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int4x2 a1 = int4x2(1305234431, 1308626970, 1267729267, 125659640, 1315625690, 1730088797, 116862046, 375757978);
            int b1 = (353786540);
            int4x2 r1 = int4x2(1490686291, 1528187574, 1585863135, 309015380, 1534886006, 1913214449, 333543154, 57919030);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int4x2 a2 = int4x2(491079274, 187129429, 967051293, 549951551, 653124416, 788984, 1479174924, 1680011736);
            int b2 = (191750702);
            int4x2 r2 = int4x2(371762244, 4897915, 852093491, 732592657, 763363694, 190966742, 1397197090, 1867453430);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int4x2 a3 = int4x2(447453839, 293394300, 527727631, 529042816, 1382138962, 1206186973, 1059509471, 744733291);
            int b3 = (890841598);
            int4x2 r3 = int4x2(800240497, 610664066, 711808497, 714187902, 1735978412, 1929239075, 171965729, 427463573);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1288453276);
            int4x2 b0 = int4x2(1077599928, 884741329, 212164516, 1585020328, 152985454, 1775851275, 1416249064, 1309317737);
            int4x2 r0 = int4x2(217506340, 2020616269, 1080648504, 313868596, 1171416050, 622160791, 413532788, 46573301);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (1773918217);
            int4x2 b1 = int4x2(1509843030, 1206045972, 1154916424, 1947871003, 1774252400, 1946113778, 1079717492, 290620937);
            int4x2 r1 = int4x2(809875551, 777590045, 762148929, 497155858, 8071545, 440700667, 702609021, 2028559872);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1382343363);
            int4x2 b2 = int4x2(939045099, 1309568053, 221134131, 885841718, 612068188, 194068085, 1396957881, 573581481);
            int4x2 r2 = int4x2(1704743464, 476745462, 1598742512, 1722301941, 1981778335, 1509285046, 19333242, 1884605034);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (1813817520);
            int4x2 b3 = int4x2(86594349, 2006985393, 1431761813, 905646837, 1522414781, 192882943, 714832744, 374210759);
            int4x2 r3 = int4x2(1765145501, 465338881, 961174309, 1508358725, 916626445, 1734574159, 1183306712, 2052237431);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_left_shift()
        {
            int4x2 a0 = int4x2(197771193, 622182602, 1283988958, 1327917304, 473415985, 432425717, 870301196, 2058433484);
            int b0 = (1321149625);
            int4x2 r0 = int4x2(1912602624, -1811939328, -1140850688, -268435456, 1644167168, -369098752, 402653184, -1744830464);
            TestUtils.AreEqual(a0 << b0, r0);

            int4x2 a1 = int4x2(1200694230, 1360008038, 1008296534, 1447702302, 1079614371, 35667343, 1664454606, 2045594989);
            int b1 = (1531607705);
            int4x2 r1 = int4x2(-1409286144, -872415232, -1409286144, 1006632960, 1174405120, 503316480, -1677721600, -637534208);
            TestUtils.AreEqual(a1 << b1, r1);

            int4x2 a2 = int4x2(2077023268, 297755411, 1722762487, 1161625759, 37265945, 997793693, 1521705181, 263886278);
            int b2 = (592678686);
            int4x2 r2 = int4x2(0, -1073741824, -1073741824, -1073741824, 1073741824, 1073741824, 1073741824, -2147483648);
            TestUtils.AreEqual(a2 << b2, r2);

            int4x2 a3 = int4x2(221147365, 230910816, 71403448, 481375728, 1176038816, 1382694875, 1824729613, 1535276688);
            int b3 = (2084190583);
            int4x2 r3 = int4x2(1920991232, -1342177280, -603979776, -134217728, -805306368, -310378496, 109051904, 1207959552);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_right_shift()
        {
            int4x2 a0 = int4x2(548167301, 1161338299, 1617625829, 1860731847, 713958715, 196552656, 770466193, 1265099998);
            int b0 = (1266801540);
            int4x2 r0 = int4x2(34260456, 72583643, 101101614, 116295740, 44622419, 12284541, 48154137, 79068749);
            TestUtils.AreEqual(a0 >> b0, r0);

            int4x2 a1 = int4x2(572763124, 426807581, 2031319045, 701927980, 917785020, 569504877, 185593382, 1102123711);
            int b1 = (506619530);
            int4x2 r1 = int4x2(559338, 416804, 1983710, 685476, 896274, 556157, 181243, 1076292);
            TestUtils.AreEqual(a1 >> b1, r1);

            int4x2 a2 = int4x2(334005460, 280138733, 1598620011, 1840564178, 736389149, 1279158873, 408822762, 763607760);
            int b2 = (1624751550);
            int4x2 r2 = int4x2(0, 0, 1, 1, 0, 1, 0, 0);
            TestUtils.AreEqual(a2 >> b2, r2);

            int4x2 a3 = int4x2(348013684, 774126687, 1587054000, 600069797, 29576474, 1880981389, 352174824, 1164508476);
            int b3 = (1568185874);
            int4x2 r3 = int4x2(1327, 2953, 6054, 2289, 112, 7175, 1343, 4442);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public static void int4x2_operator_bitwise_not()
        {
            int4x2 a0 = int4x2(1403358969, 831360921, 2088190243, 976721016, 878283189, 308994339, 1935567517, 1420884856);
            int4x2 r0 = int4x2(-1403358970, -831360922, -2088190244, -976721017, -878283190, -308994340, -1935567518, -1420884857);
            TestUtils.AreEqual(~a0, r0);

            int4x2 a1 = int4x2(472965491, 627580960, 2061524024, 753208488, 2097179283, 1303022493, 664744603, 1289372466);
            int4x2 r1 = int4x2(-472965492, -627580961, -2061524025, -753208489, -2097179284, -1303022494, -664744604, -1289372467);
            TestUtils.AreEqual(~a1, r1);

            int4x2 a2 = int4x2(1635981125, 1545651937, 717936457, 1284504687, 1342785385, 869629475, 2045854321, 1282546942);
            int4x2 r2 = int4x2(-1635981126, -1545651938, -717936458, -1284504688, -1342785386, -869629476, -2045854322, -1282546943);
            TestUtils.AreEqual(~a2, r2);

            int4x2 a3 = int4x2(1562433528, 1736570715, 508906058, 2060752880, 1867418756, 388530274, 695179852, 1766938039);
            int4x2 r3 = int4x2(-1562433529, -1736570716, -508906059, -2060752881, -1867418757, -388530275, -695179853, -1766938040);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
