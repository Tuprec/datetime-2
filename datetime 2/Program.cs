using System;

namespace datetime_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Jaar;
            Console.WriteLine("geef een jaar op:");
            Jaar = Convert.ToInt32(Console.ReadLine());



            if (DateTime.IsLeapYear(Jaar)== true)
            {
                Console.WriteLine($"{Jaar} is een schrikkeljaar.");
            }
            else
            {
                Console.WriteLine($"{Jaar} is geen schrikkeljaar.");
            }
        }
    }
}
