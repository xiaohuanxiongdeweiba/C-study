using System;

namespace A飞行棋
{
    class Program
    {
        public static int[] _Map = new int[100];
        public static int[] _lucky = { 6, 23, 40, 55, 69, 83 };
        public static int[] _diLei = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
        public static int[] _pause = { 9, 27, 60, 93 };
        public static int[] _suiDao = { 20, 25, 45, 63, 72, 88, 90 };

        //玩家AB的坐标
        public static int[] _playPos = { 66, 66 };
        //玩家AB的姓名
        public static string[] _playName = new string[2];


        static void Main(string[] args)
        {
            GameShow();
            #region //命名
            Console.WriteLine("请输入玩家A的姓名");
            _playName[0] = Console.ReadLine();
            while (true)
            {
                if (_playName[0] == "")
                {
                    Console.WriteLine("玩家名字不能为空，请重新输入");
                    _playName[0] = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("请输入玩家B的姓名");
            _playName[1] = Console.ReadLine();
            while (true)
            {
                if (_playName[1] == "")
                {
                    Console.WriteLine("玩家名字不能为空，请重新输入");
                    _playName[1] = Console.ReadLine();
                }
                else if (_playName[1] == _playName[0])
                {
                    Console.WriteLine("玩家B名字不能和A相同，请重新输入");
                    _playName[1] = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion


            #region //图例
            //图例 普通地块 0-□ 幸运轮盘 1-♥ 地雷 2-♠ 暂停 3-☆ 时空隧道 4-☀
            //幸运轮盘 6，23，40，55，69，83
            //地雷 5，13，17，33，38，50，64，80，94
            //暂停 9，27，60，93
            //时空隧道 20,25,45,63,72,88,90
            #endregion
            IniMap();
            DawMap(_Map);
        }


        /// <summary>
        /// 画游戏抬头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********飞行棋小游戏***********");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.White;

        }




        /// <summary>
        /// 初始化地图
        /// </summary>
        /// <param name="map"></param>
        public static void IniMap()
        {

            for (int i = 0; i < _lucky.Length; i++)
            {
                _Map[_lucky[i]] = 1;
            }
            for (int i = 0; i < _diLei.Length; i++)
            {
                _Map[_diLei[i]] = 2;
            }
            for (int i = 0; i < _pause.Length; i++)
            {
                _Map[_pause[i]] = 3;
            }
            for (int i = 0; i < _suiDao.Length; i++)
            {
                _Map[_suiDao[i]] = 4;
            }

            return;
        }




        /// <summary>
        /// 画地图
        /// </summary>
        /// <param name="maps"></param>
        public static void DawMap(int[] maps)
        {
            #region//第一横行，前30个
            for (int i = 0; i < 30; i++)
            {

                if (DawPlay(i) == 0)
                {
                    DawNormal(i);
                }
                else if (DawPlay(i) == 1)
                {
                    Console.Write("Ａ");

                }
                else if (DawPlay(i) == 2)
                {
                    Console.Write("Ｂ");

                }
                else if (DawPlay(i) == 3)
                {
                    Console.Write("<>");

                }
            }
            #endregion
            Console.Write("\n");
            #region //第二-6行
            for (int i = 30; i < 35; i++)
            {
                if (DawPlay(i) == 0)
                {
                    Console.Write("                                                          ");
                    DawNormal(i);
                    Console.Write("\n");
                }
                else if (DawPlay(i) == 1)
                {
                    Console.Write("                                                          Ａ\n");

                }
                else if (DawPlay(i) == 2)
                {
                    Console.Write("                                                          Ｂ\n");

                }
                else if (DawPlay(i) == 3)
                {
                    Console.Write("                                                          <>\n");
                }
            }
            #endregion

            #region //第7行 64-35号
            for (int i = 64; i >= 35; i--)
            {
                if (DawPlay(i) == 0)
                {
                    DawNormal(i);
                }
                else if (DawPlay(i) == 1)
                {
                    Console.Write("Ａ");

                }
                else if (DawPlay(i) == 2)
                {
                    Console.Write("Ｂ");

                }
                else if (DawPlay(i) == 3)
                {
                    Console.Write("<>");

                }


            }

            #endregion
            Console.WriteLine();
            #region //第8-12行 65-69
            for (int i = 65; i < 70; i++)
            {
                if (DawPlay(i) == 0)
                {
                    DawNormal(i);
                    Console.Write("\n");
                }
                else if (DawPlay(i) == 1)
                {
                    Console.Write("Ａ");
                    Console.Write("\n");
                }
                else if (DawPlay(i) == 2)
                {
                    Console.Write("Ｂ");
                    Console.Write("\n");
                }
                else if (DawPlay(i) == 3)
                {
                    Console.Write("<>");
                    Console.Write("\n");
                }
            }


            #endregion

            #region//第13横行，71-100
            for (int i = 70; i < 100; i++)
            {

                if (DawPlay(i) == 0)
                {
                    DawNormal(i);
                }
                else if (DawPlay(i) == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ａ");

                }
                else if (DawPlay(i) == 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ｂ");

                }
                else if (DawPlay(i) == 3)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("<>");

                }
            }
            #endregion
        }





        /// <summary>
        /// 判断玩家位置状态
        /// </summary>
        /// <param name="i">当前位置参数</param>
        /// <returns>0未没人  1为 a在  2 b在 3 两个人</returns>
        public static int DawPlay(int i)
        { //i 为当前地图位置
            if ((_playPos[0] == _playPos[1]) && _playPos[0] == i)
            {
                return 3;
            }
            else if (_playPos[0] == i)
            {
                return 1;
            }
            else if (_playPos[1] == i)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }


        public static void DawNormal(int i)
        {
            switch (_Map[i])
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("□");
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("○");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("×");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("☆");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("◇");
                    break;
            }
        }


    }
}
