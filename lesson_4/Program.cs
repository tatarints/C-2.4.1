using System.Diagnostics;

namespace lesson_4
{
    class lesson_4
    {
        static void Main(string []args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();//создаем и запускаем таймер

            Random r = new Random();
            string[] strs = new string[10_000];
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = ((char)r.Next('a', 'z' + 1)).ToString();
            }

            string line = "d";
            foreach (string str in strs)
            {
                if (str == "d")
                {
                    Console.WriteLine(string.Format("Слово '{0}' содержится в массиве", line));
                }
            }


            //останавливаем счётчик 
            stopwatch.Stop(); //смотрим сколько миллисекунд было затрачено на выполнение 
            Console.WriteLine($"Массив {stopwatch.ElapsedMilliseconds}");
            stopwatch.Restart(); //перезапускаем счётчик

            HashSet<string> hs = new HashSet<string>();
            for (int i = 0; i < 10_000; i++)
            {
                hs.Add(i.ToString());
            }

            if (hs.Contains("tat"))
                Console.WriteLine("Строка есть");
            else
                Console.WriteLine("Строка отсутствует");

            stopwatch.Stop(); //смотрим сколько миллисекунд было затрачено на выполнение 
            Console.WriteLine($"HeshSet {stopwatch.ElapsedMilliseconds}");
        }
    }
}
