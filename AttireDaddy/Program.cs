using System;

namespace AttireDaddy
{
    class Program
    {
        static void Main(string[] args)
        {
            String number = string.Empty;
            String interval = String.Empty;
            int useSurplus = 0;


            if (args.Length == 2)
            {
                number = args[0];
                interval = args[1];
            }
            else
            {
                Console.WriteLine("请输入装扮的编号");
                number = Console.ReadLine();

                Console.WriteLine("请输入统计类型：");
                Console.WriteLine("0:按照购买信息统计（有购买者信息，但是最近已经出现高峰期无法获取的情况，以及基于特征的反爬策略）");
                Console.WriteLine("1:按照库存计算（对于部分装扮比如星座系列，无法统计）");
                useSurplus = int.Parse(Console.ReadLine());
                
                Console.WriteLine("请输入刷新间隔，避免被服务器拒绝。单位为毫秒。");
                interval = Console.ReadLine();
            }

            if (String.IsNullOrEmpty(number) || String.IsNullOrEmpty(interval))
            {
                Console.WriteLine("参数输入无效");
                return;
            }

            switch (useSurplus)
            {
                case 0:
                    {
                        Server server = new Server();
                        server.WriteRecentFile(int.Parse(number), int.Parse(interval));
                    }
                    break;
                case 1:
                    {
                        Server server = new Server();
                        server.WriteSurplusFile(int.Parse(number), int.Parse(interval));
                    }                  
                    break;
                default:
                    Console.WriteLine("无法识别的类型");
                    break;
            }

        }
    }
}
