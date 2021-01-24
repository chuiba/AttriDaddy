using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AttireDaddy
{
    /// <summary>
    /// 服务器端，用于提供数据的处理
    /// </summary>
    class Server
    {
        private SortedDictionary<int, RankItem> rankItems { get; set; } = new SortedDictionary<int, RankItem>();


        public void Run(int number, int interval)
        {
            Bilibili bili = new Bilibili();

            
                /*
             for (int i = 3800; i < 9999; ++i)
            {
                Surplus surplus = bili.getSurplus(i);

                // 防止412访问拦截
                Task.Delay(100).Wait();

                if (surplus != null && surplus.data != null && !String.IsNullOrEmpty(surplus.data.item.name))
                {
                    Console.WriteLine($"id:{i}, {surplus.data.item.name}, 库存数量 {surplus.data.sale_surplus}");
                }
            }
                */
            
           

            FileStream fs = new FileStream($"{number}.txt", FileMode.Append);

            while (true)
            {
                Recent recent = bili.getRecent(number);

                if (recent == null || recent.data == null || recent.data.rank == null) 
                {
                    Console.Write(".");
                    Task.Delay(interval).Wait();
                    continue;
                }

                for (int i = recent.data.rank.Count - 1; i >= 0; --i)
                {
                    var item = recent.data.rank[i];

                    if (!rankItems.ContainsKey(item.number))
                    {
                        rankItems.Add(item.number, item);

                        string str = "\n";
                        str += $"{item.number}\tuid:{item.mid}\t{item.nickname}";

                        Console.Write(str);

                        byte[] info = new UTF8Encoding(true).GetBytes(str);
                        fs.Write(info, 0, info.Length);
                    }
                }

                fs.Flush();

                // 防止412访问拦截, 等待100ms
                Task.Delay(interval).Wait();
            }
            fs.Close();
        }
    }
}
