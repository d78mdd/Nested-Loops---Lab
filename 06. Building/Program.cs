using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiEtaji = int.Parse(Console.ReadLine());
            int broiStai = int.Parse(Console.ReadLine());

            for (int nomerNaEtaj = broiEtaji; nomerNaEtaj > 0; nomerNaEtaj--)
            {
                bool cheten;

                if (nomerNaEtaj % 2 == 0)
                {
                    cheten = true;
                }
                else
                {
                    cheten = false;
                }

                char tipStaia;

                if (nomerNaEtaj == broiEtaji)
                {
                    tipStaia = 'L';
                }
                else
                {
                    if (cheten)
                    {
                        tipStaia = 'O';
                    }
                    else
                    {
                        tipStaia = 'A';
                    }
                }

                for (int nomerNaStaia = 0; nomerNaStaia < broiStai; nomerNaStaia++)  // apartament, ofis, large apartament
                {
                    Console.Write($"{tipStaia}{nomerNaEtaj}{nomerNaStaia} ");
                }

                Console.WriteLine();

            }
        }
    }
}
