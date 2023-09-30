#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoEatery.Data.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Calories", "CookedAt", "OrderId", "Price" },
                values: new object[,]
                {
                    { 1, 1580, new DateTime(2023, 9, 30, 9, 29, 54, 641, DateTimeKind.Local).AddTicks(8931), null, 373.746522532923100m },
                    { 2, 1848, new DateTime(2023, 9, 29, 16, 52, 53, 995, DateTimeKind.Local).AddTicks(8913), null, 824.205990673156600m },
                    { 3, 819, new DateTime(2023, 9, 29, 16, 56, 42, 178, DateTimeKind.Local).AddTicks(9760), null, 106.42144288383720100m },
                    { 4, 1296, new DateTime(2023, 9, 29, 19, 31, 13, 772, DateTimeKind.Local).AddTicks(2195), null, 276.093057448989100m },
                    { 5, 983, new DateTime(2023, 9, 30, 3, 10, 16, 274, DateTimeKind.Local).AddTicks(8548), null, 654.288319225168300m },
                    { 6, 1142, new DateTime(2023, 9, 30, 3, 5, 10, 603, DateTimeKind.Local).AddTicks(6591), null, 519.094210386148300m },
                    { 7, 1946, new DateTime(2023, 9, 30, 6, 46, 16, 974, DateTimeKind.Local).AddTicks(1595), null, 162.3966910475346100m },
                    { 8, 1100, new DateTime(2023, 9, 30, 2, 42, 28, 619, DateTimeKind.Local).AddTicks(7579), null, 474.875851504554100m },
                    { 9, 1377, new DateTime(2023, 9, 30, 1, 27, 22, 988, DateTimeKind.Local).AddTicks(3865), null, 582.256840780057600m },
                    { 10, 1493, new DateTime(2023, 9, 30, 9, 18, 23, 228, DateTimeKind.Local).AddTicks(9390), null, 775.753804057646800m },
                    { 11, 834, new DateTime(2023, 9, 30, 3, 36, 24, 319, DateTimeKind.Local).AddTicks(3959), null, 188.8132459803602500m },
                    { 12, 1060, new DateTime(2023, 9, 30, 6, 57, 36, 783, DateTimeKind.Local).AddTicks(8733), null, 746.841464624907100m },
                    { 13, 807, new DateTime(2023, 9, 29, 18, 13, 58, 23, DateTimeKind.Local).AddTicks(8371), null, 729.569306612098900m },
                    { 14, 1747, new DateTime(2023, 9, 29, 17, 10, 14, 588, DateTimeKind.Local).AddTicks(4549), null, 406.903137319768600m },
                    { 15, 800, new DateTime(2023, 9, 30, 4, 6, 27, 772, DateTimeKind.Local).AddTicks(5359), null, 796.00726089675100m },
                    { 16, 1900, new DateTime(2023, 9, 29, 19, 40, 28, 474, DateTimeKind.Local).AddTicks(9117), null, 470.92753611044200m },
                    { 17, 1423, new DateTime(2023, 9, 30, 0, 34, 29, 598, DateTimeKind.Local).AddTicks(9364), null, 899.208015411003400m },
                    { 18, 1628, new DateTime(2023, 9, 30, 10, 50, 57, 962, DateTimeKind.Local).AddTicks(7432), null, 882.750062809938700m },
                    { 19, 1527, new DateTime(2023, 9, 30, 1, 37, 34, 695, DateTimeKind.Local).AddTicks(8813), null, 906.632639027034400m },
                    { 20, 700, new DateTime(2023, 9, 30, 1, 55, 26, 413, DateTimeKind.Local).AddTicks(8618), null, 516.720764059717600m },
                    { 21, 899, new DateTime(2023, 9, 30, 9, 23, 32, 702, DateTimeKind.Local).AddTicks(9894), null, 588.160744040749600m },
                    { 22, 1116, new DateTime(2023, 9, 29, 17, 19, 34, 524, DateTimeKind.Local).AddTicks(286), null, 564.432286661293600m },
                    { 23, 1432, new DateTime(2023, 9, 30, 1, 9, 35, 15, DateTimeKind.Local).AddTicks(4810), null, 100.204969679064181900m },
                    { 24, 1374, new DateTime(2023, 9, 29, 17, 1, 7, 18, DateTimeKind.Local).AddTicks(7816), null, 899.2367910260200m },
                    { 25, 1627, new DateTime(2023, 9, 29, 18, 0, 4, 229, DateTimeKind.Local).AddTicks(5986), null, 674.071563622260700m },
                    { 26, 774, new DateTime(2023, 9, 29, 23, 28, 46, 695, DateTimeKind.Local).AddTicks(637), null, 717.995160103245400m },
                    { 27, 831, new DateTime(2023, 9, 29, 21, 25, 18, 829, DateTimeKind.Local).AddTicks(9622), null, 870.061210802412400m },
                    { 28, 1309, new DateTime(2023, 9, 30, 1, 17, 15, 746, DateTimeKind.Local).AddTicks(6412), null, 308.117850056807500m },
                    { 29, 1714, new DateTime(2023, 9, 30, 7, 55, 21, 610, DateTimeKind.Local).AddTicks(8043), null, 618.110991145475200m },
                    { 30, 1057, new DateTime(2023, 9, 29, 19, 7, 59, 408, DateTimeKind.Local).AddTicks(6537), null, 399.765973483859500m },
                    { 31, 986, new DateTime(2023, 9, 30, 5, 36, 54, 924, DateTimeKind.Local).AddTicks(1022), null, 526.262420633341600m },
                    { 32, 555, new DateTime(2023, 9, 29, 23, 17, 22, 0, DateTimeKind.Local).AddTicks(1393), null, 570.405541825559800m },
                    { 33, 1393, new DateTime(2023, 9, 29, 22, 2, 37, 907, DateTimeKind.Local).AddTicks(8692), null, 854.492349410047900m },
                    { 34, 1458, new DateTime(2023, 9, 30, 3, 38, 16, 591, DateTimeKind.Local).AddTicks(7968), null, 738.019289782713700m },
                    { 35, 1010, new DateTime(2023, 9, 30, 10, 51, 42, 533, DateTimeKind.Local).AddTicks(5313), null, 524.493908480532700m },
                    { 36, 1640, new DateTime(2023, 9, 29, 23, 31, 27, 855, DateTimeKind.Local).AddTicks(1467), null, 417.781352733745600m },
                    { 37, 1381, new DateTime(2023, 9, 30, 5, 51, 0, 109, DateTimeKind.Local).AddTicks(5202), null, 660.312936005205700m },
                    { 38, 1361, new DateTime(2023, 9, 30, 0, 12, 22, 527, DateTimeKind.Local).AddTicks(8736), null, 318.071476102204900m },
                    { 39, 1556, new DateTime(2023, 9, 29, 19, 34, 18, 188, DateTimeKind.Local).AddTicks(98), null, 767.857517564845600m },
                    { 40, 725, new DateTime(2023, 9, 29, 19, 34, 30, 609, DateTimeKind.Local).AddTicks(9259), null, 171.6801788795594500m },
                    { 41, 1103, new DateTime(2023, 9, 30, 10, 24, 18, 667, DateTimeKind.Local).AddTicks(6875), null, 551.937738889959400m },
                    { 42, 1980, new DateTime(2023, 9, 29, 22, 44, 56, 515, DateTimeKind.Local).AddTicks(1055), null, 808.88626946032300m },
                    { 43, 474, new DateTime(2023, 9, 29, 17, 56, 30, 170, DateTimeKind.Local).AddTicks(1495), null, 768.792659443602400m },
                    { 44, 1325, new DateTime(2023, 9, 30, 7, 8, 31, 868, DateTimeKind.Local).AddTicks(6276), null, 519.247858752054100m },
                    { 45, 1384, new DateTime(2023, 9, 30, 11, 51, 45, 730, DateTimeKind.Local).AddTicks(8297), null, 455.314802963735800m },
                    { 46, 1802, new DateTime(2023, 9, 30, 12, 14, 17, 356, DateTimeKind.Local).AddTicks(6611), null, 773.123293224887500m },
                    { 47, 1312, new DateTime(2023, 9, 29, 22, 39, 2, 879, DateTimeKind.Local).AddTicks(2668), null, 693.342315897394600m },
                    { 48, 903, new DateTime(2023, 9, 30, 3, 47, 52, 950, DateTimeKind.Local).AddTicks(4472), null, 639.563092552811800m },
                    { 49, 1153, new DateTime(2023, 9, 29, 21, 48, 0, 736, DateTimeKind.Local).AddTicks(5648), null, 627.498711119921500m },
                    { 50, 1471, new DateTime(2023, 9, 30, 12, 24, 37, 805, DateTimeKind.Local).AddTicks(9927), null, 721.27553537511100m },
                    { 51, 1400, new DateTime(2023, 9, 30, 5, 46, 47, 227, DateTimeKind.Local).AddTicks(2255), null, 279.505472941703800m },
                    { 52, 527, new DateTime(2023, 9, 30, 5, 38, 5, 340, DateTimeKind.Local).AddTicks(8145), null, 973.644809809176100m },
                    { 53, 651, new DateTime(2023, 9, 29, 20, 10, 16, 538, DateTimeKind.Local).AddTicks(9596), null, 487.610090061608800m },
                    { 54, 1785, new DateTime(2023, 9, 30, 0, 20, 18, 637, DateTimeKind.Local).AddTicks(7940), null, 945.144433625114800m },
                    { 55, 790, new DateTime(2023, 9, 30, 8, 36, 41, 605, DateTimeKind.Local).AddTicks(813), null, 204.483432416842900m },
                    { 56, 1667, new DateTime(2023, 9, 30, 6, 59, 11, 533, DateTimeKind.Local).AddTicks(5660), null, 835.175392340970700m },
                    { 57, 1737, new DateTime(2023, 9, 29, 20, 43, 7, 903, DateTimeKind.Local).AddTicks(4909), null, 626.301421650286300m },
                    { 58, 437, new DateTime(2023, 9, 30, 1, 43, 29, 727, DateTimeKind.Local).AddTicks(9662), null, 913.612944478924900m },
                    { 59, 1545, new DateTime(2023, 9, 30, 0, 24, 19, 921, DateTimeKind.Local).AddTicks(7125), null, 744.68057218544800m },
                    { 60, 612, new DateTime(2023, 9, 29, 18, 55, 23, 308, DateTimeKind.Local).AddTicks(4908), null, 750.443136619922200m },
                    { 61, 1509, new DateTime(2023, 9, 30, 8, 55, 21, 470, DateTimeKind.Local).AddTicks(3170), null, 159.7673538045776800m },
                    { 62, 1715, new DateTime(2023, 9, 30, 14, 57, 16, 817, DateTimeKind.Local).AddTicks(6564), null, 954.007412957148700m },
                    { 63, 1442, new DateTime(2023, 9, 30, 13, 15, 20, 852, DateTimeKind.Local).AddTicks(491), null, 438.904019719985500m },
                    { 64, 871, new DateTime(2023, 9, 30, 9, 8, 45, 593, DateTimeKind.Local).AddTicks(769), null, 634.632874928514100m },
                    { 65, 1391, new DateTime(2023, 9, 30, 5, 34, 53, 923, DateTimeKind.Local).AddTicks(1302), null, 308.516478080902300m },
                    { 66, 1686, new DateTime(2023, 9, 30, 6, 50, 5, 179, DateTimeKind.Local).AddTicks(2105), null, 752.261488151440600m },
                    { 67, 1646, new DateTime(2023, 9, 30, 2, 13, 11, 636, DateTimeKind.Local).AddTicks(1281), null, 703.664984807009200m },
                    { 68, 552, new DateTime(2023, 9, 30, 1, 15, 43, 103, DateTimeKind.Local).AddTicks(8661), null, 657.624915664288300m },
                    { 69, 1002, new DateTime(2023, 9, 30, 1, 43, 39, 692, DateTimeKind.Local).AddTicks(5605), null, 604.078285347516700m },
                    { 70, 1783, new DateTime(2023, 9, 30, 4, 33, 6, 647, DateTimeKind.Local).AddTicks(3268), null, 981.167801215096900m },
                    { 71, 1090, new DateTime(2023, 9, 30, 8, 49, 8, 719, DateTimeKind.Local).AddTicks(8371), null, 917.85814249892500m },
                    { 72, 436, new DateTime(2023, 9, 30, 3, 2, 38, 300, DateTimeKind.Local).AddTicks(4214), null, 664.615565577782200m },
                    { 73, 1143, new DateTime(2023, 9, 30, 1, 44, 43, 184, DateTimeKind.Local).AddTicks(9173), null, 359.565573829890700m },
                    { 74, 1367, new DateTime(2023, 9, 30, 10, 50, 38, 170, DateTimeKind.Local).AddTicks(878), null, 937.365757849377100m },
                    { 75, 984, new DateTime(2023, 9, 29, 16, 54, 1, 268, DateTimeKind.Local).AddTicks(4854), null, 129.3673252272056200m },
                    { 76, 1095, new DateTime(2023, 9, 30, 7, 16, 31, 987, DateTimeKind.Local).AddTicks(9209), null, 848.512067850018100m },
                    { 77, 1460, new DateTime(2023, 9, 30, 0, 59, 18, 167, DateTimeKind.Local).AddTicks(1298), null, 267.220796615777800m },
                    { 78, 1436, new DateTime(2023, 9, 30, 3, 55, 3, 252, DateTimeKind.Local).AddTicks(4850), null, 367.85333886554800m },
                    { 79, 1781, new DateTime(2023, 9, 30, 10, 5, 28, 59, DateTimeKind.Local).AddTicks(1068), null, 879.439745780845300m },
                    { 80, 1052, new DateTime(2023, 9, 29, 17, 4, 10, 570, DateTimeKind.Local).AddTicks(2069), null, 631.87725954026800m },
                    { 81, 1456, new DateTime(2023, 9, 30, 1, 41, 7, 633, DateTimeKind.Local).AddTicks(7693), null, 287.878313340643600m },
                    { 82, 1047, new DateTime(2023, 9, 30, 12, 44, 28, 104, DateTimeKind.Local).AddTicks(234), null, 546.879310699234600m },
                    { 83, 1964, new DateTime(2023, 9, 29, 18, 21, 56, 226, DateTimeKind.Local).AddTicks(236), null, 415.529242940121400m },
                    { 84, 413, new DateTime(2023, 9, 29, 21, 53, 34, 80, DateTimeKind.Local).AddTicks(5129), null, 622.291722028444900m },
                    { 85, 442, new DateTime(2023, 9, 30, 10, 28, 54, 559, DateTimeKind.Local).AddTicks(9376), null, 242.360934133406500m },
                    { 86, 612, new DateTime(2023, 9, 30, 5, 5, 9, 878, DateTimeKind.Local).AddTicks(2904), null, 922.27951486216900m },
                    { 87, 1234, new DateTime(2023, 9, 30, 12, 8, 32, 990, DateTimeKind.Local).AddTicks(793), null, 699.226961393940400m },
                    { 88, 1019, new DateTime(2023, 9, 29, 22, 35, 34, 808, DateTimeKind.Local).AddTicks(2475), null, 914.923227856881700m },
                    { 89, 1621, new DateTime(2023, 9, 30, 1, 52, 53, 882, DateTimeKind.Local).AddTicks(9213), null, 372.161768464834300m },
                    { 90, 910, new DateTime(2023, 9, 29, 22, 16, 23, 0, DateTimeKind.Local).AddTicks(9255), null, 407.926326850998400m },
                    { 91, 1056, new DateTime(2023, 9, 30, 9, 31, 15, 726, DateTimeKind.Local).AddTicks(8632), null, 784.567535932357300m },
                    { 92, 1731, new DateTime(2023, 9, 30, 7, 21, 33, 107, DateTimeKind.Local).AddTicks(5314), null, 427.396386010777300m },
                    { 93, 1886, new DateTime(2023, 9, 30, 4, 51, 38, 105, DateTimeKind.Local).AddTicks(7101), null, 217.958726962240300m },
                    { 94, 1758, new DateTime(2023, 9, 30, 6, 19, 54, 457, DateTimeKind.Local).AddTicks(9035), null, 515.592315457686100m },
                    { 95, 1113, new DateTime(2023, 9, 30, 1, 57, 1, 590, DateTimeKind.Local).AddTicks(8923), null, 878.587168122027100m },
                    { 96, 1435, new DateTime(2023, 9, 30, 2, 19, 41, 234, DateTimeKind.Local).AddTicks(4436), null, 593.251278901904800m },
                    { 97, 902, new DateTime(2023, 9, 29, 16, 56, 52, 665, DateTimeKind.Local).AddTicks(8292), null, 141.0854206232203300m },
                    { 98, 1802, new DateTime(2023, 9, 30, 5, 38, 7, 577, DateTimeKind.Local).AddTicks(3105), null, 342.645082393808800m },
                    { 99, 535, new DateTime(2023, 9, 29, 21, 18, 32, 83, DateTimeKind.Local).AddTicks(4105), null, 619.36029108755200m },
                    { 100, 759, new DateTime(2023, 9, 29, 20, 44, 28, 481, DateTimeKind.Local).AddTicks(7841), null, 828.654350115569500m }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "SupplierId" },
                values: new object[,]
                {
                    { 1, "Ингредиент №1", null },
                    { 2, "Ингредиент №2", null },
                    { 3, "Ингредиент №3", null },
                    { 4, "Ингредиент №4", null },
                    { 5, "Ингредиент №5", null },
                    { 6, "Ингредиент №6", null },
                    { 7, "Ингредиент №7", null },
                    { 8, "Ингредиент №8", null },
                    { 9, "Ингредиент №9", null },
                    { 10, "Ингредиент №10", null },
                    { 11, "Ингредиент №11", null },
                    { 12, "Ингредиент №12", null },
                    { 13, "Ингредиент №13", null },
                    { 14, "Ингредиент №14", null },
                    { 15, "Ингредиент №15", null },
                    { 16, "Ингредиент №16", null },
                    { 17, "Ингредиент №17", null },
                    { 18, "Ингредиент №18", null },
                    { 19, "Ингредиент №19", null },
                    { 20, "Ингредиент №20", null },
                    { 21, "Ингредиент №21", null },
                    { 22, "Ингредиент №22", null },
                    { 23, "Ингредиент №23", null },
                    { 24, "Ингредиент №24", null },
                    { 25, "Ингредиент №25", null },
                    { 26, "Ингредиент №26", null },
                    { 27, "Ингредиент №27", null },
                    { 28, "Ингредиент №28", null },
                    { 29, "Ингредиент №29", null },
                    { 30, "Ингредиент №30", null },
                    { 31, "Ингредиент №31", null },
                    { 32, "Ингредиент №32", null },
                    { 33, "Ингредиент №33", null },
                    { 34, "Ингредиент №34", null },
                    { 35, "Ингредиент №35", null },
                    { 36, "Ингредиент №36", null },
                    { 37, "Ингредиент №37", null },
                    { 38, "Ингредиент №38", null },
                    { 39, "Ингредиент №39", null },
                    { 40, "Ингредиент №40", null },
                    { 41, "Ингредиент №41", null },
                    { 42, "Ингредиент №42", null },
                    { 43, "Ингредиент №43", null },
                    { 44, "Ингредиент №44", null },
                    { 45, "Ингредиент №45", null },
                    { 46, "Ингредиент №46", null },
                    { 47, "Ингредиент №47", null },
                    { 48, "Ингредиент №48", null },
                    { 49, "Ингредиент №49", null },
                    { 50, "Ингредиент №50", null },
                    { 51, "Ингредиент №51", null },
                    { 52, "Ингредиент №52", null },
                    { 53, "Ингредиент №53", null },
                    { 54, "Ингредиент №54", null },
                    { 55, "Ингредиент №55", null },
                    { 56, "Ингредиент №56", null },
                    { 57, "Ингредиент №57", null },
                    { 58, "Ингредиент №58", null },
                    { 59, "Ингредиент №59", null },
                    { 60, "Ингредиент №60", null },
                    { 61, "Ингредиент №61", null },
                    { 62, "Ингредиент №62", null },
                    { 63, "Ингредиент №63", null },
                    { 64, "Ингредиент №64", null },
                    { 65, "Ингредиент №65", null },
                    { 66, "Ингредиент №66", null },
                    { 67, "Ингредиент №67", null },
                    { 68, "Ингредиент №68", null },
                    { 69, "Ингредиент №69", null },
                    { 70, "Ингредиент №70", null },
                    { 71, "Ингредиент №71", null },
                    { 72, "Ингредиент №72", null },
                    { 73, "Ингредиент №73", null },
                    { 74, "Ингредиент №74", null },
                    { 75, "Ингредиент №75", null },
                    { 76, "Ингредиент №76", null },
                    { 77, "Ингредиент №77", null },
                    { 78, "Ингредиент №78", null },
                    { 79, "Ингредиент №79", null },
                    { 80, "Ингредиент №80", null },
                    { 81, "Ингредиент №81", null },
                    { 82, "Ингредиент №82", null },
                    { 83, "Ингредиент №83", null },
                    { 84, "Ингредиент №84", null },
                    { 85, "Ингредиент №85", null },
                    { 86, "Ингредиент №86", null },
                    { 87, "Ингредиент №87", null },
                    { 88, "Ингредиент №88", null },
                    { 89, "Ингредиент №89", null },
                    { 90, "Ингредиент №90", null },
                    { 91, "Ингредиент №91", null },
                    { 92, "Ингредиент №92", null },
                    { 93, "Ингредиент №93", null },
                    { 94, "Ингредиент №94", null },
                    { 95, "Ингредиент №95", null },
                    { 96, "Ингредиент №96", null },
                    { 97, "Ингредиент №97", null },
                    { 98, "Ингредиент №98", null },
                    { 99, "Ингредиент №99", null },
                    { 100, "Ингредиент №100", null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "TotalCost" },
                values: new object[,]
                {
                    { 1, 0m },
                    { 2, 0m },
                    { 3, 0m },
                    { 4, 0m },
                    { 5, 0m },
                    { 6, 0m },
                    { 7, 0m },
                    { 8, 0m },
                    { 9, 0m },
                    { 10, 0m },
                    { 11, 0m },
                    { 12, 0m },
                    { 13, 0m },
                    { 14, 0m },
                    { 15, 0m },
                    { 16, 0m },
                    { 17, 0m },
                    { 18, 0m },
                    { 19, 0m },
                    { 20, 0m },
                    { 21, 0m },
                    { 22, 0m },
                    { 23, 0m },
                    { 24, 0m },
                    { 25, 0m },
                    { 26, 0m },
                    { 27, 0m },
                    { 28, 0m },
                    { 29, 0m },
                    { 30, 0m },
                    { 31, 0m },
                    { 32, 0m },
                    { 33, 0m },
                    { 34, 0m },
                    { 35, 0m },
                    { 36, 0m },
                    { 37, 0m },
                    { 38, 0m },
                    { 39, 0m },
                    { 40, 0m },
                    { 41, 0m },
                    { 42, 0m },
                    { 43, 0m },
                    { 44, 0m },
                    { 45, 0m },
                    { 46, 0m },
                    { 47, 0m },
                    { 48, 0m },
                    { 49, 0m },
                    { 50, 0m },
                    { 51, 0m },
                    { 52, 0m },
                    { 53, 0m },
                    { 54, 0m },
                    { 55, 0m },
                    { 56, 0m },
                    { 57, 0m },
                    { 58, 0m },
                    { 59, 0m },
                    { 60, 0m },
                    { 61, 0m },
                    { 62, 0m },
                    { 63, 0m },
                    { 64, 0m },
                    { 65, 0m },
                    { 66, 0m },
                    { 67, 0m },
                    { 68, 0m },
                    { 69, 0m },
                    { 70, 0m },
                    { 71, 0m },
                    { 72, 0m },
                    { 73, 0m },
                    { 74, 0m },
                    { 75, 0m },
                    { 76, 0m },
                    { 77, 0m },
                    { 78, 0m },
                    { 79, 0m },
                    { 80, 0m },
                    { 81, 0m },
                    { 82, 0m },
                    { 83, 0m },
                    { 84, 0m },
                    { 85, 0m },
                    { 86, 0m },
                    { 87, 0m },
                    { 88, 0m },
                    { 89, 0m },
                    { 90, 0m },
                    { 91, 0m },
                    { 92, 0m },
                    { 93, 0m },
                    { 94, 0m },
                    { 95, 0m },
                    { 96, 0m },
                    { 97, 0m },
                    { 98, 0m },
                    { 99, 0m },
                    { 100, 0m }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "OrganizationName" },
                values: new object[,]
                {
                    { 1, "Организация №1" },
                    { 2, "Организация №2" },
                    { 3, "Организация №3" },
                    { 4, "Организация №4" },
                    { 5, "Организация №5" },
                    { 6, "Организация №6" },
                    { 7, "Организация №7" },
                    { 8, "Организация №8" },
                    { 9, "Организация №9" },
                    { 10, "Организация №10" },
                    { 11, "Организация №11" },
                    { 12, "Организация №12" },
                    { 13, "Организация №13" },
                    { 14, "Организация №14" },
                    { 15, "Организация №15" },
                    { 16, "Организация №16" },
                    { 17, "Организация №17" },
                    { 18, "Организация №18" },
                    { 19, "Организация №19" },
                    { 20, "Организация №20" },
                    { 21, "Организация №21" },
                    { 22, "Организация №22" },
                    { 23, "Организация №23" },
                    { 24, "Организация №24" },
                    { 25, "Организация №25" },
                    { 26, "Организация №26" },
                    { 27, "Организация №27" },
                    { 28, "Организация №28" },
                    { 29, "Организация №29" },
                    { 30, "Организация №30" },
                    { 31, "Организация №31" },
                    { 32, "Организация №32" },
                    { 33, "Организация №33" },
                    { 34, "Организация №34" },
                    { 35, "Организация №35" },
                    { 36, "Организация №36" },
                    { 37, "Организация №37" },
                    { 38, "Организация №38" },
                    { 39, "Организация №39" },
                    { 40, "Организация №40" },
                    { 41, "Организация №41" },
                    { 42, "Организация №42" },
                    { 43, "Организация №43" },
                    { 44, "Организация №44" },
                    { 45, "Организация №45" },
                    { 46, "Организация №46" },
                    { 47, "Организация №47" },
                    { 48, "Организация №48" },
                    { 49, "Организация №49" },
                    { 50, "Организация №50" },
                    { 51, "Организация №51" },
                    { 52, "Организация №52" },
                    { 53, "Организация №53" },
                    { 54, "Организация №54" },
                    { 55, "Организация №55" },
                    { 56, "Организация №56" },
                    { 57, "Организация №57" },
                    { 58, "Организация №58" },
                    { 59, "Организация №59" },
                    { 60, "Организация №60" },
                    { 61, "Организация №61" },
                    { 62, "Организация №62" },
                    { 63, "Организация №63" },
                    { 64, "Организация №64" },
                    { 65, "Организация №65" },
                    { 66, "Организация №66" },
                    { 67, "Организация №67" },
                    { 68, "Организация №68" },
                    { 69, "Организация №69" },
                    { 70, "Организация №70" },
                    { 71, "Организация №71" },
                    { 72, "Организация №72" },
                    { 73, "Организация №73" },
                    { 74, "Организация №74" },
                    { 75, "Организация №75" },
                    { 76, "Организация №76" },
                    { 77, "Организация №77" },
                    { 78, "Организация №78" },
                    { 79, "Организация №79" },
                    { 80, "Организация №80" },
                    { 81, "Организация №81" },
                    { 82, "Организация №82" },
                    { 83, "Организация №83" },
                    { 84, "Организация №84" },
                    { 85, "Организация №85" },
                    { 86, "Организация №86" },
                    { 87, "Организация №87" },
                    { 88, "Организация №88" },
                    { 89, "Организация №89" },
                    { 90, "Организация №90" },
                    { 91, "Организация №91" },
                    { 92, "Организация №92" },
                    { 93, "Организация №93" },
                    { 94, "Организация №94" },
                    { 95, "Организация №95" },
                    { 96, "Организация №96" },
                    { 97, "Организация №97" },
                    { 98, "Организация №98" },
                    { 99, "Организация №99" },
                    { 100, "Организация №100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
