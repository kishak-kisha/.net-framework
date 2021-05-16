using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12q3
{
    class Program
    {
        static void Main(string[] args)
        { 
      string rootpath = @"D:\";
            do
            {
                Console.WriteLine("1.To Create a Directory Structure");
                Console.WriteLine("2.Accepting the details");
                Console.WriteLine("3.Backup of the Academy folder");
                Console.WriteLine("4.View the details");
                Console.WriteLine("5.Exit");
                Console.Write("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        {
                            if (!Directory.Exists(@"E:\Academy"))
                            {
                                Directory.CreateDirectory(rootpath);
                                if (!Directory.Exists(@"E:\Academy\Bangalore"))
                                {
                                    Directory.CreateDirectory(@"E:\Academy\Bangalore");
                                }
                                if (!Directory.Exists(@"E:\Academy\Chennai"))
                                {
                                    Directory.CreateDirectory(@"E:\Academy\Chennai");
                                }
                                if (!Directory.Exists(@"E:\Academy\Mumbai"))
                                {
                                    Directory.CreateDirectory(@"E:\Academy\Mumbai");
                                }
                                if (!Directory.Exists(@"E:\Academy\Pune"))
                                {
                                    Directory.CreateDirectory(@"E:\Academy\Pune");
                                }


                            }
                            else
                            {
                                Console.WriteLine("The Directory already exist");
                            }
                            break;
                        }
                    case 2:
                        Console.WriteLine("ACCEPTING DETAILS");
                        Console.Write("Enter your location:");
                        string location = Console.ReadLine();
                        Console.WriteLine("Enter your name");
                        string content = Console.ReadLine();
                        string banglorepath = @"E:\Academy\Bangalore\Bangalore.txt";
                        string mumbaipath = @"E:\Academy\Bangalore\Mumbai.txt";
                        string punepath = @"E:\Academy\Bangalore\Pune.txt";
                        string chennaipath = @"E:\Academy\Bangalore\Chennai.txt";
                        if (location == "Bangalore")
                        {
                            if (!File.Exists(banglorepath))
                            {
                                File.Create(banglorepath);
                            }
                            File.AppendAllText(banglorepath, content + Environment.NewLine);


                        }
                        if (location == "Chennai")
                        {
                            if (!File.Exists(chennaipath))
                            {
                                File.Create(chennaipath);
                            }
                            File.AppendAllText(chennaipath, content + Environment.NewLine);


                        }
                        if (location == "Mumbai")
                        {
                            if (!File.Exists(mumbaipath))
                            {
                                File.Create(mumbaipath);
                            }
                            File.AppendAllText(mumbaipath, content + Environment.NewLine);


                        }
                        if (location == "Pune")
                        {
                            if (!File.Exists(punepath))
                            {
                                File.Create(punepath);
                            }
                            File.AppendAllText(punepath, content + Environment.NewLine);


                        }
                        break;
                    case 3:
                        {
                            string destFolder = @"D:/Academy";
                            string sourceFolder = @"E:/Academy";
                            CopyFolder(sourceFolder, destFolder);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Display");
                            
                                Console.WriteLine("1.Banglore details");
                                Console.WriteLine("2.Mumbai details");
                                Console.WriteLine("3.Pune details");
                                Console.WriteLine("4.Chennai details");
                                int choi = Convert.ToInt32(Console.ReadLine());
                            if(choi == 1)
                            {
                                Read(@"E:\Academy\Bangalore\Bangalore.txt");
                            }
                            if (choi == 2)
                            {
                                Read(@"E:\Academy\Bangalore\Mumbai.txt");
                            }
                            if (choi == 3)
                            {
                                Read(@"E:\Academy\Bangalore\Pune.txt");
                            }
                            if (choi == 4)
                            {
                                Read(@"E:\Academy\Bangalore\Chennai.txt");
                            }



                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            
                            break;
                        }

                }

            } while (true);

        }
        static public void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }
        public static void Read(string file_path)
        {
            
            if (File.Exists(file_path))
            {
                string s = File.ReadAllText(file_path);
                Console.WriteLine(s);
            }
        }
    }
}

