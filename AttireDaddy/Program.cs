using System;

namespace AttireDaddy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入装扮的编号");
            String number = Console.ReadLine();


            Console.WriteLine("请输入刷新间隔，避免被服务器拒绝。单位为毫秒。");
            String interval = Console.ReadLine();


            Server server = new Server();
            server.Run(int.Parse(number), int.Parse(interval));

        }
    }
}
