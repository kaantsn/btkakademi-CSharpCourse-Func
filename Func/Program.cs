using System;
using System.Threading;

namespace MyFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik mat = new Matematik();

            Func<int, int, int> add = mat.Topla;
            Console.WriteLine(add(6, 8));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };


            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000); // farklı sayı gelmesi için programı yavaşlatıyoruz.
            Console.WriteLine(getRandomNumber2());

            Console.ReadKey();
        }

        public class Matematik
        {
            public int Topla(int s1, int s2)
            {
                return s1 + s2;
            }
        }
    }
}
