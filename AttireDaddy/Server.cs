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

        public void WriteRecentFile(int number, int interval)
        {
            Bilibili bili = new Bilibili();

            FileStream fs = new FileStream($"{number}.txt", FileMode.Append);

            try 
            {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        public void WriteSurplusFile(int number, int interval)
        {
            Bilibili bili = new Bilibili();

            FileStream fs = new FileStream($"{number}.surplus.txt", FileMode.Append);

            try
            {
                while (true)
                {
                    Surplus surplus = bili.getSurplus(number);

                    if (surplus != null && surplus.data != null && !String.IsNullOrEmpty(surplus.data.item.name))
                    {
                        var _name = surplus.data.item.name;
                        var _quantity = surplus.data.item.properties.sale_quantity;
                        var _surplus = surplus.data.sale_surplus;
                        var _number = _quantity - _surplus; 


                        string str = $"id:{number} {_name}\t库存：{_quantity}\t销量：{_surplus}\t计算编号：{_number}\n";
                        Console.Write(str);

                        byte[] info = new UTF8Encoding(true).GetBytes(str);
                        fs.Write(info, 0, info.Length);
                    }
                    else
                    {
                        Console.WriteLine("无法获取装扮信息，请检查");
                    }

                    fs.Flush();

                    // 防止412访问拦截, 等待100ms
                    Task.Delay(interval).Wait();
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
