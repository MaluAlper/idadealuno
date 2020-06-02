using System;

namespace idadealuno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Minha data completa de nascimento:");
            DateTime MariaLuiza = new DateTime (1970, 02, 02, 12, 20, 00);
            string MariaLuizanas = MariaLuiza.ToLongDateString(); //dtl = data longa 
            string DiaDaSemanaQueNasci = MariaLuiza.ToString("dddd");
            Console.WriteLine($"Nascida em: {MariaLuiza} dia da semana: {DiaDaSemanaQueNasci}");
            
            DateTime bday = MariaLuiza.AddYears(18);
            string bday18 = bday.ToLongDateString();
            Console.WriteLine($"Meu aniversário de 18 anos foi em uma {bday18}");

        }
    }
}
