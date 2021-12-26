using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B飞行棋
{
    class Program
    {
        #region //字段
        public static int[] _Map = new int[100];
        public static int[] _lucky = { 6, 23, 40, 55, 69, 83 };
        public static int[] _diLei = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
        public static int[] _pause = { 9, 27, 60, 93 };
        public static int[] _suiDao = { 20, 25, 45, 63, 72, 88, 89
        };

        //玩家AB的坐标
        public static int[] _playPos = { 0, 0 };
        //玩家AB的姓名
        public static string[] _playName = new string[2];
        public static Random _random = new Random();
        //玩家AB的暂停倒计时
        public static int[] stop = { 0, 0 };
        #endregion

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
            Console.Clear();
            GameShow();
            Console.WriteLine("{0}的士兵用A表示", _playName[0]);
            Console.WriteLine("{0}的士兵用B表示", _playName[1]);
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


            while (_playPos[1] < 99 && _playPos[0] < 99)
            {
                if (stop[0] == 0)
                {
                    PlayerMove(_playName[0], ref _playPos[0], ref stop[0], _playName[1], ref _playPos[1], ref stop[1]);
                    if (stop[1] == 0)
                    {
                        PlayerMove(_playName[1], ref _playPos[1], ref stop[1],_playName[0], ref _playPos[0], ref stop[0]);
                    }
                    else
                    {
                        stop[1]-= 1;
                        Console.WriteLine("{0}玩家暂停一回合",_playName[1]);
                        Console.ReadKey();

                    }

                }
                else 
                {
                    stop[0] -= 1;
                    Console.WriteLine("{0}玩家暂停一回合", _playName[0]);

                    if (stop[1] == 0)
                    {
                        PlayerMove(_playName[1], ref _playPos[1], ref stop[1], _playName[0], ref _playPos[0], ref stop[0]);
                    }
                    else
                    {
                        stop[1] -= 1;
                        Console.WriteLine("{0}玩家暂停一回合", _playName[1]);
                        Console.ReadKey();

                    }

                }
                

            }

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
            Console.WriteLine("图例 普通地块 0-□ 幸运轮盘 1-○ 地雷 2-× 暂停 3-☆ 时空隧道 4-◇");

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
            Console.WriteLine();
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

        /// <summary>
        /// 画普通地块
        /// </summary>
        /// <param name="i"></param>
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

        /// <summary>
        /// 玩家行动
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="playerPos"></param>
        public static void PlayerMove(string playerName, ref int playerPos, ref int playerStop, string playerName2, ref int playerPos2, ref int playerStop2)
        {


            Console.WriteLine("{0}按任意键开始掷骰子", playerName);
            Console.ReadKey(true);
            int step = _random.Next(1, 7);
            Console.WriteLine("{0}掷出了{1}", playerName, step);
            Console.ReadKey();
            playerPos += step;
            Console.WriteLine("{0}按任意键开始行动", playerName);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", playerName);
            Console.ReadKey(true);
            #region //判断是否胜利
            if (IsWin() != 0)
            {
                switch (IsWin())
                {
                    case 1:
                        Console.WriteLine("玩家{0}到达终点获胜", _playName[0]);
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}到达终点获胜", _playName[1]);
                        break;//没有人胜利
                }
                Console.WriteLine("游戏结束，按任意键退出");
                Console.ReadKey(true);
                Environment.Exit(0);


            }
            #endregion

            //判断状态
            PanDuanState( ref playerName, ref playerPos, ref playerStop, ref playerName2, ref playerPos2, ref playerStop2);
            Console.Clear();
            DawMap(_Map);



        }
        /// <summary>
        /// 判断是否胜利
        /// </summary>
        /// <returns>返回0  没有人胜利 1 玩家1胜利  2 玩家2 胜利</returns>
        public static int IsWin()
        {
            if (_playPos[1] >= 99)
            {
                _playPos[1] = 99;
                Console.Clear();
                DawMap(_Map);
                return 2;
                //Console.WriteLine("玩家{0}到达终点获胜", _playName[1]);


            }
            else if (_playPos[0] >= 99)
            {
                _playPos[0] = 99;
                Console.Clear();
                DawMap(_Map);
                return 1;
                //Console.WriteLine("玩家{0}到达终点获胜", _playName[0]);

            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 判断player当前状态
        /// </summary>
        /// <param name="playerName">操作玩家名称</param>
        /// <param name="playerPos">操作玩家地址</param>
        /// <param name="playerName2">对手玩家名称</param>
        /// <param name="playerPos2">对手玩家地址</param>
        public static void PanDuanState(ref string playerName, ref int playerPos, ref int playerStop, ref string playerName2, ref int playerPos2, ref int playerStop2)
        {
            IsOutMap();
            if (playerPos == playerPos2)
            {
                Console.WriteLine("{0}踩到了{1}，{2}后退6格", playerName, playerName2, playerName2);
                Console.ReadKey(true);
                playerPos2 -= 6;
                PanDuanState(ref _playName[1], ref _playPos[1], ref stop[1], ref _playName[0], ref _playPos[0], ref stop[0]);
            }
            else
            {
                switch (_Map[playerPos])
                {
                    case 0:
                        Console.WriteLine("{0}踩到了方块，安全", playerName);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("{0}踩到了幸运轮盘，请选择1--交换位置，2--轰炸对方后退6格", playerName);

                        string choose = Console.ReadLine();
                        while (true)
                        {
                            if (choose == "1")
                            {
                                Console.WriteLine("{0}选择和{1}交换位置", playerName, playerName2);
                                Console.ReadKey(true);

                                int temp = playerPos;
                                playerPos = playerPos2;
                                playerPos2 = temp;
                                Console.WriteLine("交换完成，按任意键继续游戏");
                                Console.ReadKey(true);

                                break;
                            }
                            else if (choose == "2")
                            {
                                Console.WriteLine("{0}选择轰炸{1}，{2}后退6格", playerName, playerName2, playerName2);
                                Console.ReadKey(true);

                                playerPos2 -= 6;
                                Console.WriteLine("{0}后退了6格，按任意键继续游戏", playerName2);
                                PanDuanState(ref playerName2, ref playerPos2, ref playerStop2, ref playerName, ref playerPos, ref playerStop);
                                Console.ReadKey(true);

                                break;
                            }
                            else
                            {
                                Console.WriteLine("输入有误，请重新选择，1--交换位置，2--轰炸对方后退6格");


                                choose = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("{0}踩到了地雷，后退6格", playerName);
                        playerPos -= 6;
                        PanDuanState(ref playerName, ref playerPos, ref playerStop, ref playerName2, ref playerPos2, ref playerStop2);
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine("{0}暂停一回合", playerName);
                        playerStop += 1;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("{0}踩到了时空隧道，前进10格", playerName);
                        playerPos += 10;
                        PanDuanState(ref playerName, ref playerPos, ref playerStop, ref playerName2, ref playerPos2, ref playerStop2);
                        Console.ReadKey(true);
                        break;
                }

            }
        }

        /// <summary>
        /// 判断是否退出地图，如果是，将地址改为0
        /// </summary>
        public static void IsOutMap()
        {
            if (_playPos[0] < 0)
            {
                _playPos[0] = 0;
            }
            if (_playPos[1] < 0)
            {
                _playPos[1] = 0;
            }
        }

    }
}
