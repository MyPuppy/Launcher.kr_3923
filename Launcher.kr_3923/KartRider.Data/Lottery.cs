using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.IO;

namespace KartRider
{
    public static class Lottery
    {
        public static short ItemID = 0;
        public static byte Unk = 0;
        public static int Type = 0;

        public static int OpenType = 0;
        public static short KartID = 0;
        public static short StockID = 0;

        public static void LotteryList()
        {
            Random random = new Random();
            if (Lottery.ItemID == 558) //블랙 기어
            {
                Lottery.OpenType = 0;
                Lottery.KartID = 0;
                int reward = random.Next(1, 66);
                if (reward == 1)
                {
                    Lottery.KartID = 854;
                    Lottery.StockID = 13745;
                }
                else if (reward == 2)
                {
                    Lottery.KartID = 839;
                    Lottery.StockID = 13158;
                }
                else if (reward == 3)
                {
                    Lottery.KartID = 872;
                    Lottery.StockID = 14239;
                }
                else if (reward == 4)
                {
                    Lottery.KartID = 829;
                    Lottery.StockID = 12174;
                }
                else if (reward == 5)
                {
                    Lottery.KartID = 840;
                    Lottery.StockID = 12958;
                }
                else if (reward == 6)
                {
                    Lottery.KartID = 943;
                    Lottery.StockID = 15747;
                }
                else if (reward == 7)
                {
                    Lottery.KartID = 940;
                    Lottery.StockID = 15651;
                }
                else if (reward == 8)
                {
                    Lottery.KartID = 931;
                    Lottery.StockID = 15507;
                }
                else if (reward == 9)
                {
                    Lottery.KartID = 932;
                    Lottery.StockID = 15413;
                }
                else if (reward == 10)
                {
                    Lottery.KartID = 919;
                    Lottery.StockID = 15141;
                }
                else if (reward == 11)
                {
                    Lottery.KartID = 909;
                    Lottery.StockID = 14358;
                }
                else if (reward == 12)
                {
                    Lottery.KartID = 908;
                    Lottery.StockID = 14299;
                }
                else if (reward == 13)
                {
                    Lottery.KartID = 907;
                    Lottery.StockID = 14296;
                }
                else if (reward == 14)
                {
                    Lottery.KartID = 906;
                    Lottery.StockID = 14277;
                }
                else if (reward == 15)
                {
                    Lottery.KartID = 904;
                    Lottery.StockID = 14132;
                }
                else if (reward == 16)
                {
                    Lottery.KartID = 900;
                    Lottery.StockID = 14096;
                }
                else if (reward == 17)
                {
                    Lottery.KartID = 899;
                    Lottery.StockID = 14042;
                }
                else if (reward == 18)
                {
                    Lottery.KartID = 896;
                    Lottery.StockID = 14041;
                }
                else if (reward == 19)
                {
                    Lottery.KartID = 888;
                    Lottery.StockID = 13973;
                }
                else if (reward == 20)
                {
                    Lottery.KartID = 887;
                    Lottery.StockID = 13931;
                }
                else if (reward == 21)
                {
                    Lottery.KartID = 885;
                    Lottery.StockID = 13876;
                }
                else if (reward == 22)
                {
                    Lottery.KartID = 884;
                    Lottery.StockID = 13875;
                }
                else if (reward == 23)
                {
                    Lottery.KartID = 883;
                    Lottery.StockID = 13855;
                }
                else if (reward == 24)
                {
                    Lottery.KartID = 882;
                    Lottery.StockID = 13853;
                }
                else if (reward == 25)
                {
                    Lottery.KartID = 881;
                    Lottery.StockID = 13847;
                }
                else if (reward == 26)
                {
                    Lottery.KartID = 879;
                    Lottery.StockID = 13986;
                }
                else if (reward == 27)
                {
                    Lottery.KartID = 878;
                    Lottery.StockID = 13985;
                }
                else if (reward == 28)
                {
                    Lottery.KartID = 877;
                    Lottery.StockID = 13814;
                }
                else if (reward == 29)
                {
                    Lottery.KartID = 875;
                    Lottery.StockID = 13807;
                }
                else if (reward == 30)
                {
                    Lottery.KartID = 874;
                    Lottery.StockID = 13754;
                }
                else if (reward == 31)
                {
                    Lottery.KartID = 869;
                    Lottery.StockID = 13644;
                }
                else if (reward == 32)
                {
                    Lottery.KartID = 868;
                    Lottery.StockID = 13974;
                }
                else if (reward == 33)
                {
                    Lottery.KartID = 866;
                    Lottery.StockID = 13548;
                }
                else if (reward == 34)
                {
                    Lottery.KartID = 865;
                    Lottery.StockID = 13546;
                }
                else if (reward == 35)
                {
                    Lottery.KartID = 864;
                    Lottery.StockID = 13498;
                }
                else if (reward == 36)
                {
                    Lottery.KartID = 862;
                    Lottery.StockID = 13474;
                }
                else if (reward == 37)
                {
                    Lottery.KartID = 859;
                    Lottery.StockID = 13425;
                }
                else if (reward == 38)
                {
                    Lottery.KartID = 858;
                    Lottery.StockID = 13424;
                }
                else if (reward == 39)
                {
                    Lottery.KartID = 857;
                    Lottery.StockID = 13407;
                }
                else if (reward == 40)
                {
                    Lottery.KartID = 855;
                    Lottery.StockID = 13386;
                }
                else if (reward == 41)
                {
                    Lottery.KartID = 849;
                    Lottery.StockID = 13264;
                }
                else if (reward == 42)
                {
                    Lottery.KartID = 834;
                    Lottery.StockID = 12726;
                }
                else if (reward == 43)
                {
                    Lottery.KartID = 805;
                    Lottery.StockID = 12435;
                }
                else if (reward == 44)
                {
                    Lottery.KartID = 852;
                    Lottery.StockID = 13299;
                }
                else if (reward == 45)
                {
                    Lottery.KartID = 844;
                    Lottery.StockID = 13301;
                }
                else if (reward == 46)
                {
                    Lottery.KartID = 817;
                    Lottery.StockID = 12052;
                }
                else if (reward == 47)
                {
                    Lottery.KartID = 813;
                    Lottery.StockID = 11211;
                }
                else if (reward == 48)
                {
                    Lottery.KartID = 812;
                    Lottery.StockID = 11212;
                }
                else if (reward == 49)
                {
                    Lottery.KartID = 827;
                    Lottery.StockID = 12051;
                }
                else if (reward == 50)
                {
                    Lottery.KartID = 756;
                    Lottery.StockID = 12462;
                }
                else if (reward == 51)
                {
                    Lottery.KartID = 806;
                    Lottery.StockID = 12723;
                }
                else if (reward == 52)
                {
                    Lottery.KartID = 758;
                    Lottery.StockID = 10875;
                }
                else if (reward == 53)
                {
                    Lottery.KartID = 828;
                    Lottery.StockID = 12748;
                }
                else if (reward == 54)
                {
                    Lottery.KartID = 850;
                    Lottery.StockID = 13303;
                }
                else if (reward == 55)
                {
                    Lottery.KartID = 751;
                    Lottery.StockID = 12443;
                }
                else if (reward == 56)
                {
                    Lottery.KartID = 819;
                    Lottery.StockID = 12439;
                }
                else if (reward == 57)
                {
                    Lottery.KartID = 800;
                    Lottery.StockID = 12548;
                }
                else if (reward == 58)
                {
                    Lottery.KartID = 797;
                    Lottery.StockID = 12547;
                }
                else if (reward == 59)
                {
                    Lottery.KartID = 796;
                    Lottery.StockID = 10522;
                }
                else if (reward == 60)
                {
                    Lottery.KartID = 787;
                    Lottery.StockID = 12441;
                }
                else if (reward == 61)
                {
                    Lottery.KartID = 747;
                    Lottery.StockID = 8369;
                }
                else if (reward == 62)
                {
                    Lottery.KartID = 633;
                    Lottery.StockID = 12453;
                }
                else if (reward == 63)
                {
                    Lottery.KartID = 807;
                    Lottery.StockID = 11197;
                }
                else if (reward == 64)
                {
                    Lottery.KartID = 799;
                    Lottery.StockID = 12461;
                }
                else if (reward == 65)
                {
                    Lottery.KartID = 671;
                    Lottery.StockID = 7208;
                }
            }
            else if (Lottery.ItemID == 623) //프리미엄 3.6.9 기어
            {
                Lottery.OpenType = 0;
                Lottery.KartID = 0;
                int reward = random.Next(1, 49);
                if (reward == 1) Lottery.StockID = 16874;
                else if (reward == 2) Lottery.StockID = 16875;
                else if (reward == 3) Lottery.StockID = 16876;
                else if (reward == 4) Lottery.StockID = 16111;
                else if (reward == 5) Lottery.StockID = 16112;
                else if (reward == 6) Lottery.StockID = 16113;
                else if (reward == 7) Lottery.StockID = 15787;
                else if (reward == 8) Lottery.StockID = 15788;
                else if (reward == 9) Lottery.StockID = 15789;
                else if (reward == 10) Lottery.StockID = 15605;
                else if (reward == 11) Lottery.StockID = 15928;
                else if (reward == 12) Lottery.StockID = 15929;
                else if (reward == 13) Lottery.StockID = 15790;
                else if (reward == 14) Lottery.StockID = 15791;
                else if (reward == 15) Lottery.StockID = 15792;
                else if (reward == 16) Lottery.StockID = 15793;
                else if (reward == 17) Lottery.StockID = 15794;
                else if (reward == 18) Lottery.StockID = 15795;
                else if (reward == 19) Lottery.StockID = 16325;
                else if (reward == 20) Lottery.StockID = 16877;
                else if (reward == 21) Lottery.StockID = 16878;
                else if (reward == 22) Lottery.StockID = 16604;
                else if (reward == 23) Lottery.StockID = 17585;
                else if (reward == 24) Lottery.StockID = 17586;
                else if (reward == 25) Lottery.StockID = 17587;
                else if (reward == 26) Lottery.StockID = 17588;
                else if (reward == 27) Lottery.StockID = 17589;
                else if (reward == 28) Lottery.StockID = 17163;
                else if (reward == 29) Lottery.StockID = 17590;
                else if (reward == 30) Lottery.StockID = 17591;
                else if (reward == 31) Lottery.StockID = 17592;
                else if (reward == 32) Lottery.StockID = 17593;
                else if (reward == 33) Lottery.StockID = 17594;
                else if (reward == 34) Lottery.StockID = 13854;
                else if (reward == 35) Lottery.StockID = 15820;
                else if (reward == 36) Lottery.StockID = 15821;
                else if (reward == 37) Lottery.StockID = 14449;
                else if (reward == 38) Lottery.StockID = 15804;
                else if (reward == 39) Lottery.StockID = 15805;
                else if (reward == 40) Lottery.StockID = 14130;
                else if (reward == 41) Lottery.StockID = 15816;
                else if (reward == 42) Lottery.StockID = 15817;
                else if (reward == 43) Lottery.StockID = 15094;
                else if (reward == 44) Lottery.StockID = 15785;
                else if (reward == 45) Lottery.StockID = 15786;
                else if (reward == 46) Lottery.StockID = 16063;
                else if (reward == 47) Lottery.StockID = 16115;
                else if (reward == 48) Lottery.StockID = 16116;
            }
            else if (Lottery.ItemID == 697)//TOP 10 카트 기어
            {
                Lottery.OpenType = 0;
                int reward = random.Next(1, 11);
                if (reward == 1)
                {
                    Lottery.KartID = 955;
                    Lottery.StockID = 16592;
                }
                else if (reward == 2)
                {
                    Lottery.KartID = 854;
                    Lottery.StockID = 13745;
                }
                else if (reward == 3)
                {
                    Lottery.KartID = 905;
                    Lottery.StockID = 16048;
                }
                else if (reward == 4)
                {
                    Lottery.KartID = 872;
                    Lottery.StockID = 14239;
                }
                else if (reward == 5)
                {
                    Lottery.KartID = 935;
                    Lottery.StockID = 15604;
                }
                else if (reward == 6)
                {
                    Lottery.KartID = 963;
                    Lottery.StockID = 16267;
                }
                else if (reward == 7)
                {
                    Lottery.KartID = 882;
                    Lottery.StockID = 13853;
                }
                else if (reward == 8)
                {
                    Lottery.KartID = 878;
                    Lottery.StockID = 13985;
                }
                else if (reward == 9)
                {
                    Lottery.KartID = 904;
                    Lottery.StockID = 14132;
                }
                else if (reward == 10)
                {
                    Lottery.KartID = 903;
                    Lottery.StockID = 15087;
                }
            }
            else if (Lottery.ItemID == 699)//TOP 20 카트 기어
            {
                Lottery.OpenType = 0;
                int reward = random.Next(1, 21);
                if (reward == 1)
                {
                    Lottery.KartID = 955;
                    Lottery.StockID = 16592;
                }
                else if (reward == 2)
                {
                    Lottery.KartID = 854;
                    Lottery.StockID = 13745;
                }
                else if (reward == 3)
                {
                    Lottery.KartID = 905;
                    Lottery.StockID = 16048;
                }
                else if (reward == 4)
                {
                    Lottery.KartID = 872;
                    Lottery.StockID = 14239;
                }
                else if (reward == 5)
                {
                    Lottery.KartID = 935;
                    Lottery.StockID = 15604;
                }
                else if (reward == 6)
                {
                    Lottery.KartID = 963;
                    Lottery.StockID = 16267;
                }
                else if (reward == 7)
                {
                    Lottery.KartID = 882;
                    Lottery.StockID = 13853;
                }
                else if (reward == 8)
                {
                    Lottery.KartID = 878;
                    Lottery.StockID = 13985;
                }
                else if (reward == 9)
                {
                    Lottery.KartID = 904;
                    Lottery.StockID = 14132;
                }
                else if (reward == 10)
                {
                    Lottery.KartID = 903;
                    Lottery.StockID = 15087;
                }
                else if (reward == 11)
                {
                    Lottery.KartID = 956;
                    Lottery.StockID = 16405;
                }
                else if (reward == 12)
                {
                    Lottery.KartID = 879;
                    Lottery.StockID = 13986;
                }
                else if (reward == 13)
                {
                    Lottery.KartID = 864;
                    Lottery.StockID = 13498;
                }
                else if (reward == 14)
                {
                    Lottery.KartID = 877;
                    Lottery.StockID = 13814;
                }
                else if (reward == 15)
                {
                    Lottery.KartID = 883;
                    Lottery.StockID = 13855;
                }
                else if (reward == 16)
                {
                    Lottery.KartID = 903;
                    Lottery.StockID = 15087;
                }
                else if (reward == 17)
                {
                    Lottery.KartID = 938;
                    Lottery.StockID = 16057;
                }
                else if (reward == 18)
                {
                    Lottery.KartID = 858;
                    Lottery.StockID = 13424;
                }
                else if (reward == 19)
                {
                    Lottery.KartID = 887;
                    Lottery.StockID = 13931;
                }
                else if (reward == 20)
                {
                    Lottery.KartID = 906;
                    Lottery.StockID = 14277;
                }
            }
            else
            {
                Lottery.OpenType = 5;
                Lottery.KartID = 0;
                Lottery.StockID = 0;
            }
            Lottery.SpRpLotteryPacket();
        }

        public static void SpRpLotteryPacket()
        {
            using (OutPacket outPacket = new OutPacket("SpRpLotteryPacket"))
            {
                outPacket.WriteInt(Lottery.OpenType);
                outPacket.WriteInt(Lottery.StockID);
                outPacket.WriteHexString("FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00");
                RouterListener.MySession.Client.Send(outPacket);
            }
        }

        public static void PrRequestKartInfoPacket()
        {
            Launcher.KartSN++;
            Console.WriteLine("KartSN: {0}", Launcher.KartSN);
            using (OutPacket outPacket = new OutPacket("PrRequestKartInfoPacket"))
            {
                outPacket.WriteByte(1);
                outPacket.WriteInt(1);
                outPacket.WriteShort(3);
                outPacket.WriteShort(Lottery.KartID);
                outPacket.WriteShort(Launcher.KartSN);
                outPacket.WriteShort(1);//수량
                outPacket.WriteShort(0);
                outPacket.WriteShort(-1);
                outPacket.WriteShort(0);
                outPacket.WriteShort(0);
                outPacket.WriteShort(0);
                RouterListener.MySession.Client.Send(outPacket);
            }
        }
    }
}