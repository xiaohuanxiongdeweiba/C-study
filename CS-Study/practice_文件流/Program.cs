using System;
using System.IO;
namespace practice_文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            string copyPath = @"C:\Users\Betta\Videos\music.mp4";
            string targetPath = @"C:\Users\Betta\Videos\new.mp4";
            CopyFile(copyPath,targetPath);
            Console.WriteLine("复制完成");
            Console.ReadLine();


        }


        public static void CopyFile(string source, string target)
        {

            
            byte[] bytes = new byte[1024 * 1024*2];


            using (FileStream fileRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fileWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    
                    int times = 0;
                    while (true)
                    {
                        int r = fileRead.Read(bytes, 0, bytes.Length);
                        if (r == 0)
                        {
                            break;
                        }
                        fileWrite.Write(bytes, 0, r);
                        
                        times+= 1;
                        Console.WriteLine(times);

                    }
                }
            }
        }
    }
}
//Filestream 是操作字符的
//sreamreader 和 streamwriter 是操作字节的