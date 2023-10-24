// https://petlja.org/kurs/11171/33/2763
// https://petlja.org/biblioteka/r/Zbirka/histogram
// https://petlja.org/biblioteka/r/problemi/Zbirka/histogram
// https://petlja.org/biblioteka/r/problemi/Zbirka-stara/histogram
// https://arena.petlja.org/competition/r1-07-nizovi-05-preslikavanja#tab_132994
// https://arena.petlja.org/competition/r1-07-nizovi-04-vektori-polinomi#tab_132710
// https://arena.petlja.org/competition/skola-od-kuce-nizovi1-zadaci#tab_97594

using System;

class Zadatak_Histogram_2023_10_23
{
    static void Main()
    {
        string[] sAB = Console.ReadLine().Split();
        decimal a = decimal.Parse(sAB[0]);
        decimal b = decimal.Parse(sAB[1]);
        int n = int.Parse(Console.ReadLine());  // broj podeoka 
        int k = int.Parse(Console.ReadLine());  // ucitavamo ukupan broj tacaka

        decimal dx = (b - a) / n;                // sirina jednog podeoka
        int[] histogram = new int[n];           // histogram cuva broj tacaka u svakom podeoku

        for (int i = 0; i < k; i++)
        {
            decimal x = decimal.Parse(Console.ReadLine());    // ucitavamo sledecu tacku
            int podeok = (int)Math.Floor((x - a) / dx);     // odredjujemo podeok kojem ona pripada
            histogram[podeok]++;                            // uvecavamo broj tacaka u tom podeoku histograma
        }

        // ispisujemo histogram
        decimal t = a;
        foreach (int h in histogram)
        {
            // ispisujemo granice tekuceg podeoka (zaokruzene na tri decimale)
            decimal ta = t;
            decimal tb = t + dx;

            // ta = Math.Round(ta, 3, MidpointRounding.AwayFromZero);
            // tb = Math.Round(tb, 3, MidpointRounding.AwayFromZero);

            //ta = (decimal)Math.Floor(ta * 10000) / 10000.0;
            //tb = (decimal)Math.Floor(tb * 10000) / 10000.0;

            Console.Write("[" + ta.ToString("0.000") + ", " + tb.ToString("0.000") + "): ");
            
            // ispisujemo broj tacaka u tekucem podeoku
            Console.Write(h + "\t");
            
            // ispisujemo zvezdice
            decimal procenat = (decimal)h / (decimal)k;
            int brojZvezdica = (int)Math.Round(100 * procenat);
            for (int i = 0; i < brojZvezdica; i++) { Console.Write("*"); }
            Console.WriteLine();

            // prelazimo na naredni podeok
            t += dx;
        }
        Console.WriteLine();
    }
}