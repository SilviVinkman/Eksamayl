﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nimekiri = new List<string>();
                while (true)
                {
                    Console.WriteLine("Sisesta inimese nimi, väljumiseks -1");
                    var nimi = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(nimi))
                    { Console.WriteLine("Viga sisestamisel");
                    }
                    if (nimi == "-1")
                    {
                        Console.WriteLine("väljun");
                        break;
                    }

                    nimekiri.Add(nimi);
                    if (nimi == " ")
                        nimekiri.Remove(nimi);
                    else if (nimi == "")
                        nimekiri.Remove(nimi);
                }

                Console.WriteLine("Sisestatud nimed suurte algustähtedega: " );

                var nimiUuesti = new List<string>();
                foreach (string nimi in nimekiri)
                { string Õigenimi = char.ToUpper(nimi[0]) + nimi.ToLower().Substring(1);
                    nimiUuesti.Add(Õigenimi);
                }
                foreach (var Õigenimi in nimiUuesti)
                    Console.WriteLine( Õigenimi);

            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}
