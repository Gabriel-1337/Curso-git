using System;

namespace Projeto_teste_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime t = new DateTime();
            if (t.Hour >= 05.00 && t.Hour <=11.59 )
            {
                Console.WriteLine("Bom Dia!!");
            }
            else if(t.Hour >= 12.00 && t.Hour <=17.59 )
            {
                Console.WriteLine("Boa Tarde!!");
            }
            else
            {
                Console.WriteLine("Boa Noite!!");
            }
            Console.ReadLine();
        }
    }
}
