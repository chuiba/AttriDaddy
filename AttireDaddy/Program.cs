using System;

namespace AttireDaddy
{
    class Program
    {
        static void Main(string[] args)
        {
            String number = string.Empty;
            String interval = String.Empty;


            if (args.Length == 2)
            {
                number = args[0];
                interval = args[1];
            }
            else
            {
                Console.WriteLine("请输入装扮的编号");
                number = Console.ReadLine();


                Console.WriteLine("请输入刷新间隔，避免被服务器拒绝。单位为毫秒。");
                interval = Console.ReadLine();
            }

            if (String.IsNullOrEmpty(number) || String.IsNullOrEmpty(interval))
            {
                Console.WriteLine("参数输入无效");
                return;
            }


            Server server = new Server();
            server.Run(int.Parse(number), int.Parse(interval));

        }
    }
}
