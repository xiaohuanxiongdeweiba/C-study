using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 飞行棋
{
    class Program
    {
        public static int[] _level = new int[100];
        public static int playA = 35;//A的位置
        public static int playB = 63;//B的位置
        public static Random random = new Random();



        static void Main(string[] args)
        {
            GameTitle();
            Console.WriteLine("请输入玩家A的姓名");
            string nameA = Console.ReadLine();
            Console.WriteLine("请输入玩家B的姓名");
            string nameB = Console.ReadLine();
            Console.Clear();
            GameTitle();
            Console.WriteLine("{0}的士兵用A表示", nameA);
            Console.WriteLine("{0}的士兵用B表示", nameB);
            playA = 0;
            playB = 0;

            InitMap(_level);
            DrawMap(_level);
            Console.WriteLine();


            while (playA < 99 && playB < 99)
            {
                APlay(nameA, nameB);
                BPlay(nameA, nameB);

            }


            Console.ReadKey();
        }

        public static void APlay(string nameA, string nameB)
        {
            Console.WriteLine("{0}按任意键开始掷骰子", nameA);
            Console.ReadKey(true);

            int step = random.Next(1, 7);
            Console.WriteLine("{0}投掷的点数为：{1}", nameA, step);
            Console.ReadKey(true);

            Console.WriteLine("{0}按任意键开始行动", nameA);
            Console.ReadKey(true);
            playA += step;
            Console.Clear();
            GameTitle();
            Console.WriteLine("{0}的士兵用A表示", nameA);
            Console.WriteLine("{0}的士兵用B表示", nameB);
            DrawMap(_level);
            Console.WriteLine();
            if (playA >= 100)
            {
                Console.WriteLine("{0}胜利！！！！！！！！！！！！！！！！！！！！！", nameA);
                return;
            }

            PanDuan(_level[playA], nameA, nameB,nameA);

            Console.WriteLine("{0}行动完了", nameA);

            Console.ReadKey(true);


        }

        public static void BPlay(string nameA, string nameB)
        {
            Console.WriteLine("{0}按任意键开始掷骰子", nameB);
            Console.ReadKey(true);

            int step = random.Next(1, 7);
            Console.WriteLine("{0}投掷的点数为：{1}", nameB, step);
            Console.ReadKey(true);

            Console.WriteLine("{0}按任意键开始行动", nameB);
            Console.ReadKey(true);
            playB += step;
            Console.Clear();
            GameTitle();
            Console.WriteLine("{0}的士兵用A表示", nameA);
            Console.WriteLine("{0}的士兵用B表示", nameB);
            DrawMap(_level);
            Console.WriteLine();
            if (playB >= 100)
            {
                Console.WriteLine("{0}胜利！！！！！！！！！！！！！！！！！！！！！", nameB);
                return;
            }

            PanDuan(_level[playB], nameB, nameA, nameA);

            Console.WriteLine("{0}行动完了", nameB);

            Console.ReadKey(true);


        }

        public static void PanDuan(int result, string nameA, string nameB, string Play1)
        {
            switch (result)
            {
                case 0:
                    Console.WriteLine("{0}踩到了方格子，安全", nameA);
                    Console.ReadKey(true);

                    break;//踩到了方格子，安全
                case 1:

                    Console.WriteLine("{0}踩到了幸运轮盘，请选择操作，1--交换位置， 2--向对方投放炸弹，使对方后退6格", nameA);
                    if (nameA == Play1)
                    {
                        Choose(nameA, playB);
                    }
                    else
                    {
                        Choose(nameA, playA);

                    }
                    Choose(nameA, playB);
                    Console.Clear();
                    GameTitle();
                    Console.WriteLine("{0}的士兵用A表示", nameA);
                    Console.WriteLine("{0}的士兵用B表示", nameB);
                    DrawMap(_level);
                    Console.ReadKey(true);



                    break;//踩到了方格子，安全
                case 2:

                    Console.WriteLine("{0}踩到了地雷，后退6格", nameA);
                    playA -= 10;

                    Console.ReadKey(true);
                    Console.Clear();
                    GameTitle();
                    Console.WriteLine("{0}的士兵用A表示", nameA);
                    Console.WriteLine("{0}的士兵用B表示", nameB);
                    DrawMap(_level);



                    break;//踩到了方格子，安全
                case 3:

                    Console.WriteLine("{0}踩到了暂停，停一回合", nameA);
                    Console.ReadKey(true);

                    break;//踩到了方格子，安全
                case 4:

                    Console.WriteLine("{0}踩到了时空隧道，前进10格", nameA);
                    Console.ReadKey(true);

                    playA += 10;
                    break;//踩到了方格子，安全


            }


        }

        public static void Choose(string name, int playBei)
        {
            string choose = "";
            choose = Console.ReadLine();
            while (true)
            {
                if (choose == "1")
                {
                    int temp = playA;
                    playA = playB;
                    playB = temp;
                    Console.WriteLine("您和对方交换了位置");

                    break;
                }
                else if (choose == "2")
                {
                    Console.WriteLine("您投掷了炸弹，对方后退6格");
                    playBei -= 6;
                    break;
                }
                else
                {
                    Console.WriteLine("您必须输入1或者2，1--交换位置， 2--向对方投放炸弹，使对方后退6格");
                    choose = Console.ReadLine();

                }
            }


        }

        /// <summary>
        /// 游戏开头
        /// </summary>
        public static void GameTitle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********飞行棋小游戏**********");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************************");
            return;
        }
        //normal                                    □
        //luckyturn =[6,23,40,55,69,83] ,幸运轮盘  ¤
        //landmine=[5,13,17,33,38,50,64,80,94],    △
        //pause = {9,27,60,93}                     ★
        //timetunnel={20,25,45,63,72,88,90}        ※  

        /// <summary>
        /// 初始化地图
        /// </summary>
        /// <param name="map">存放地图的数组</param>
        public static void InitMap(int[] map)
        {
            int[] luckyTurn = { 6, 23, 40, 55, 69, 83 };
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            int[] pause = { 9, 27, 60, 93 };
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };


            for (int i = 0; i < luckyTurn.Length; i++)
            {
                int index = luckyTurn[i];
                map[index] = 1;
            }


            for (int i = 0; i < landMine.Length; i++)
            {
                int index = landMine[i];
                map[index] = 2;
            }


            for (int i = 0; i < pause.Length; i++)
            {
                int index = pause[i];
                map[index] = 3;
            }

            for (int i = 0; i < timeTunnel.Length; i++)
            {
                int index = timeTunnel[i];
                map[index] = 4;
            }
        }

        /// <summary>
        /// 画地图
        /// </summary>
        /// <param name="map">地图数组</param>
        public static void DrawMap(int[] map)
        {
            //判断玩家是否超出边界，超出的话则变为0
            if (playA < 0)
            {
                playA = 0;
            }
            if (playB < 0)
            {
                playB = 0;

            }
            //第一行
            for (int i = 0; i < 30; i++)
            {
                if (playA != i && playB != i)
                {
                    DrawStringMap(map[i]);
                }
                else
                {
                    DrawPlayers(i, false, false);
                }

            }
            Console.Write("\n");
            //第二行

            for (int i = 30; i < 35; i++)
            {
                //画玩家的位置
                if (playA != i && playB != i)
                {
                    for (int j = 0; j < 29; j++)
                    {
                        Console.Write("　");
                    }
                    DrawStringMapChangeLine(map[i]);
                }
                else
                {
                    DrawPlayers(i, true, true);
                }
            }

            //第三行
            for (int i = 64; i >= 35; i--)
            {
                if (playA != i && playB != i)
                {
                    DrawStringMap(map[i]);
                }
                else
                {
                    DrawPlayers(i, false, false);

                }




            }
            Console.Write("\n");
            //第四行
            for (int i = 65; i < 70; i++)
            {
                if (playA != i && playB != i)
                {
                    DrawStringMapChangeLine(map[i]);
                }
                else
                {
                    DrawPlayers(i, true, true);

                }



            }
            //最后一行
            for (int i = 70; i < 100; i++)
            {
                if (playA != i && playB != i)
                {
                    DrawStringMap(map[i]);
                }
                else
                {
                    DrawPlayers(i, false, false);

                }





            }
        }

        /// <summary>
        /// 画地图的标志，不换行
        /// </summary>
        /// <param name="i">地图格子的编号</param>
        public static void DrawStringMap(int i)
        {
            switch (i)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("□");
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("¤");

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("△");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("★");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("※");
                    break;
            }
        }

        /// <summary>
        /// 画地图的标志，换行
        /// </summary>
        /// <param name="i">地图格子的编号</param>
        public static void DrawStringMapChangeLine(int i)
        {
            switch (i)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("□");
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¤");

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("△");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("★");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("※");
                    break;

            }
        }

        /// <summary>
        /// 画玩家的位置
        /// </summary>
        /// <param name="i">当前格子</param>
        /// <param name="isBack">是否是靠右</param>
        /// <param name="isChangeLine">是否换行</param>
        public static void DrawPlayers(int i, bool isBack, bool isChangeLine)
        {

            if (i == playA && i == playB)
            {
                if (playA < 0)
                {
                    playA = 0;
                    playB = 0;
                }
                if (isBack)
                {
                    DrawBlank(29);
                }
                if (isChangeLine)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("<>");
                }
                if (!isChangeLine)
                {
                    Console.Write("<>");
                }



            }
            else if (i == playA)
            {
                if (isBack)
                {
                    DrawBlank(29);
                }
                if (isChangeLine)
                { Console.WriteLine("Ａ"); }
                if (!isChangeLine)
                {
                    Console.Write("Ａ");
                }


            }

            else if (i == playB)
            {
                if (isBack)
                {
                    DrawBlank(29);
                }
                if (isChangeLine)
                { Console.WriteLine("Ｂ"); }
                if (!isChangeLine)
                {
                    Console.Write("Ｂ");
                }


            }


        }

        public static void DrawPlayersChangeLine(int i)
        {
            if (i == playA && i == playB)
            {
                if (playA < 0)
                {
                    playA = 0;
                    playB = 0;
                }
                Console.WriteLine("<>");


            }
            else if (i == playA)
            {
                Console.WriteLine("Ａ");

            }

            else if (i == playB)
            {
                Console.WriteLine("Ｂ");

            }

        }

        /// <summary>
        /// 画空格
        /// </summary>
        /// <param name="time">画空格的个数</param>
        public static void DrawBlank(int time)
        {
            for (int i = 0; i < time; i++)
            {
                Console.Write("　");
            }
        }


    }
}

