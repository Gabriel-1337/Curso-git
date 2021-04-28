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
                Console.WriteLine("Olá Bom Dia!!");
            }
            else if(t.Hour >= 12.00 && t.Hour <=17.59 )
            {
                Console.WriteLine("Olá Boa Tarde!!");
            }
            else
            {
                Console.WriteLine("Olá Boa Noite!!");
            }
            Console.WriteLine("Que bom vê-lo novamente!! :)");
            Console.ReadLine();
        }
    }
}
