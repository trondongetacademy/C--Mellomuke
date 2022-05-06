using System;

namespace Mellomuke
{
    class Program
    {
        static void Main(string[] args)
        {
            // oppg 1. Lag 8 variabler og til-ordne dem en verdi

            // int tall1 = 1; // int lagrer hele tall, gjerne mindre verdier
            // long tall2 = 11; // long lagrer hele tall, gjerne større verdier

            // float tallMedDecimal = 1.02F; // presise decimaltall
            // double tallMedDecimal1 = 1.03; // mellomting
            // decimal tallMedDecimal2 = 1.04M; // Mer presise decimaltall

            // string tekst = "Hallo"; // Lagrer tekst
            // char charackter = 'A'; // Lagrer en enkel bokstav
            // bool santEllerUsant = true; // lagrer en sant eller usant

            // Oppg 2. Lag en konsoll-applikasjon som alger 3 variabler.

            int o = 5;
            float n = 3.1F;
            double sum = o + n;

            Console.WriteLine(sum);


            Console.WriteLine("Hei, hva heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Hei, " + name);



        // if else
        Console.WriteLine("Skriv inn ett tall");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv inn ett annet tall");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a != b)
            {
                Console.WriteLine("Tallene er ikke like: " + (a + b));

            }
            else
            {
                Console.WriteLine("Tallene er like: " + (a * b));

            }
            if (a == 30 || b == 30 || a + b == 30)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");

            }



            int[] liste = { 1, 1, 1, 1, 1 };
            string[] liste2 = { "ape", "hest", "bøffel", "ugle" };
            bool condition = true;
            // for løkke
            for (var i = 0; i < liste.Length; i++)
            {
                Console.WriteLine("Trond er kul");
            }

            //foreach
            foreach (var g in liste2)
            {
                Console.WriteLine("Trond er grusom");
            }

            // while løkke
            int h = 1;
            while (condition)
            {
                if (h <= 10)
                {
                    Console.WriteLine("Runde nr: " + h);
                    h++;
                }
                else
                {
                    condition = false;
                }
            }

            // do while
            int c = 1;
            do
            {
                Console.WriteLine("Lene er babe");
                c++;

            } while (c < 6);



            Console.WriteLine(hvaErTallet());
            Console.WriteLine(ReturnerIngentingTekst());

        }

        public static int hvaErTallet()
        {
            int a = 5;
            int b = 3;
            return a + b;
        }
        // oppg 2. Lag en metode skal printe setningen "denne metoden returnerer ingenting" til konsollen
        public static void ReturnerIngenting()
        {
            return;
        }

        public static string ReturnerIngentingTekst()
        {
            string ingenting = "Returnerer ingenting";
            return ingenting;
        }

    
    }
}
