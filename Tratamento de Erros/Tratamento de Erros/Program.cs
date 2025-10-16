using System;
namespace dotnetproject
{
    class Program
    {
        public static void Main(String[] args)
        {
            int n1, n2, q;

            Console.WriteLine("digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            try
            {
                q = n1 / n2;

                Console.WriteLine($"O quociente da divisão é = {q} ");
            }
            catch(System.DivideByZeroException dbz)
            {
                Console.WriteLine(dbz);
            }

        }
    }
}