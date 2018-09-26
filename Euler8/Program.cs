using System;

namespace Euler8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var nText = Console.ReadLine();
            var n = int.Parse(nText);

            var q8 = new Question8();
            var r = q8.AnswerQuestion8(n);

            Console.WriteLine("Answer: {0}", r);
        }
    }
}
