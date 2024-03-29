using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                double spesteni = 0;

                input = Console.ReadLine();

                string destinacia;
                if (input != "End")
                {
                    destinacia = input;
                }
                else
                {
                    break;
                }


                double minimalenBiodzhet = double.Parse(Console.ReadLine());

                do
                {
                    spesteni += double.Parse(Console.ReadLine());
                }
                while (spesteni < minimalenBiodzhet);

                Console.WriteLine($"Going to {destinacia}!");

            } while (input != "End");

        }
    }
}
