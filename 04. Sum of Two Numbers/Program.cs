using System;

namespace _04.Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nachaloNaIntervala = int.Parse(Console.ReadLine());
            int kraiNaIntervala = int.Parse(Console.ReadLine());
            int magicheskoChislo = int.Parse(Console.ReadLine());

            int broiNaVsichkiKombinacii = 0;
            int poredenNomer = 0;
            int parvoChislo = 0;
            int vtoroChislo = 0;

            for (int x1 = nachaloNaIntervala; x1 <= kraiNaIntervala; x1++)
            {
                for (int x2 = nachaloNaIntervala; x2 <= kraiNaIntervala; x2++)
                {
                    broiNaVsichkiKombinacii++;
                    if (x1 + x2 == magicheskoChislo)
                    {
                        poredenNomer = broiNaVsichkiKombinacii;
                        parvoChislo = x1;
                        vtoroChislo = x2;
                        break;
                    }
                }
                if (poredenNomer != 0)
                {
                    break;
                }
            }

            if (poredenNomer != 0)
            {
                Console.WriteLine($"Combination N:{poredenNomer} ({parvoChislo} + {vtoroChislo} = {magicheskoChislo})");
            }
            else
            {
                Console.WriteLine($"{broiNaVsichkiKombinacii} combinations - neither equals {magicheskoChislo}");
            }
        }
    }
}
