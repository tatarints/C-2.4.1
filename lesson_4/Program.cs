using System.Diagnostics;

namespace lesson_4
{
    class lesson_4
    {
        public void ArrayTest()
        {
            Random r = new Random();
            string[] strs = new string[10_000];
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = ((char)r.Next('a', 'z' + 1)).ToString();
            }

            string line = "d";
            if (strs.Contains(line))
            {
                Console.WriteLine(string.Format("Слово '{0}' содержится в массиве", line));
            }
        }
        public void HeshSetTest()
        {
            HashSet<string> hs = new HashSet<string>();
            for (int i = 0; i < 10_000; i++)
            {
                hs.Add(i.ToString());
            }

            if (hs.Contains("d"))
                Console.WriteLine("Строка есть");
            else
                Console.WriteLine("Строка отсутствует");
        }
        static void Main(string[] args)
        {
            var ls = new lesson_4();

            Stopwatch stopwatch = Stopwatch.StartNew();//создаем и запускаем таймер
            
            ls.ArrayTest();

            //останавливаем счётчик 
            stopwatch.Stop(); //смотрим сколько миллисекунд было затрачено на выполнение 
            Console.WriteLine($"Массив {stopwatch.ElapsedMilliseconds}");

            stopwatch.Restart(); //перезапускаем счётчик

            ls.HeshSetTest();

            stopwatch.Stop(); //смотрим сколько миллисекунд было затрачено на выполнение 
            Console.WriteLine($"HeshSet {stopwatch.ElapsedMilliseconds}");
        }
    }
}
