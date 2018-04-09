using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            var loend = new List<DateTime>();
            var d1 = new DateTime(2001, 1, 9);
            var d2 = new DateTime(1944, 12, 13);
            var d3 = new DateTime(1944, 1, 29);
            var d4 = new DateTime(1974, 4, 21);
            var d5 = new DateTime(1970, 12, 31);
            var d6 = new DateTime(1964, 6, 17);
            var d7 = new DateTime(1953, 12, 20);
            var d8 = new DateTime(1979, 2, 13);
            var d9 = new DateTime(1962, 5, 31);
            var d10 = new DateTime(1992, 10, 1);
            var d11 = new DateTime(2005, 1, 1);
            var d12 = new DateTime(1964, 12, 13);
            var d13 = new DateTime(1944, 9, 29);
            var d14 = new DateTime(1974, 4, 1);
            var d15 = new DateTime(1980, 12, 31);
            var d16 = new DateTime(1964, 6, 27);
            var d17 = new DateTime(1958, 12, 20);
            var d18 = new DateTime(1987, 2, 25);
            var d19 = new DateTime(1962, 7, 31);
            var d20 = new DateTime(1971, 10, 1);
            var d21 = new DateTime(2007, 1, 1);
            var d22 = new DateTime(1990, 12, 23);
            var d23 = new DateTime(1988, 1, 29);
            var d24 = new DateTime(1984, 4, 21);
            var d25 = new DateTime(1977, 12, 13);
            var d26 = new DateTime(1966, 3, 8);
            var d27 = new DateTime(1953, 12, 20);
            var d28 = new DateTime(1967, 2, 25);
            var d29 = new DateTime(1955, 5, 18);
            var d30 = new DateTime(2009, 10, 1);


            //lisa kuupäevade listi. list sorteeri kasvavalt
            loend.Add(d1);
            loend.Add(d2);
            loend.Add(d3);
            loend.Add(d4);
            loend.Add(d5);
            loend.Add(d6);
            loend.Add(d7);
            loend.Add(d8);
            loend.Add(d9);
            loend.Add(d10);
            loend.Add(d11);
            loend.Add(d12);
            loend.Add(d13);
            loend.Add(d14);
            loend.Add(d15);
            loend.Add(d16);
            loend.Add(d17);
            loend.Add(d18);
            loend.Add(d19);
            loend.Add(d20);
            loend.Add(d21);
            loend.Add(d22);
            loend.Add(d23);
            loend.Add(d24);
            loend.Add(d25);
            loend.Add(d26);
            loend.Add(d27);
            loend.Add(d28);
            loend.Add(d29);
            loend.Add(d30);

            Console.WriteLine("Loend sorteeritud:");
            loend.Sort();
            for (int i = 0; i < loend.Count; i++)
            {
                Console.WriteLine(loend[i]);
            }

            var vanus = new List<int>();

            for (int i = 0; i < loend.Count; i++)
            {
                var Age = DateTime.Now - loend[i];
                DateTime aastatevahe = DateTime.MinValue + Age;
                int Years = aastatevahe.Year - 1;

                vanus.Add(Years);
            }
            Console.WriteLine();
            Console.WriteLine("Vanim vanus on " + vanus.Max() + " aastat");
            Console.WriteLine("Aritm keskmine vanus on " + vanus.Average() + " aastat");
            Console.WriteLine("Noorim vanus on " + vanus.Min() + " aastat");

            string date1 = d1.ToString();
            string date2 = d2.ToString();
            string date3 = d3.ToString();
            string date4 = d4.ToString();
            string date5 = d5.ToString();
            string date6 = d5.ToString();
            string date7 = d5.ToString();
            string date8 = d5.ToString();
            string date9 = d5.ToString();
            string date10 = d5.ToString();

            var kuud = new List<int>();
            //for (int i = 0; i < loend.Count; i++)
            {
                //tahan kuupäeva stringid teha tähemärkide array-ks
                //string [] datetähed = new char[] ( date1);
                //  tahan tähtede array-s iga liikme küljest ära kustutada 4 esimest märki (aastaarvud) koma)
                // tahan tähtede array-s iga liikme lõpu küljest ära kustutada koma ja kuupäevad.
                //kuud.Add(Months);
            }
            // tahan loendada kõikide liikmete hulga listis "kuud"
            // tahan selle loenduse tulemuse sorteerida

            Console.WriteLine("Kõige rohkem sünnipäevi on 12. kuus");
            Console.WriteLine("Press any key");
            Console.ReadLine();

        }
    }
}
