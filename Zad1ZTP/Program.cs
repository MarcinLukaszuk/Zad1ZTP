using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1ZTP
{
    class Program
    {
        static void Main(string[] args)
        {

            var pol1 = Baza.getPolaczenie();
            var pol2 = Baza.getPolaczenie();
            var pol3 = Baza.getPolaczenie();
            var pol4 = Baza.getPolaczenie();


            string zdanie1 = "To jest moja Baza";
            string zdanie2 = "Wszystko powinno dzialac";

            for (int i = 0; i < zdanie1.Length; i++)
            {
                pol1.set(i, zdanie1[i]);
            }

            Console.WriteLine("Polaczenie2");
            for (int i = 0; i < zdanie1.Length; i++)
            {
                Console.Write(pol2.get(i));
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < zdanie2.Length; i++)
            {
                pol3.set(i + zdanie1.Length, zdanie2[i]);
            }

            Console.WriteLine("Polaczenie4");
            for (int i = 0; i < zdanie1.Length + zdanie2.Length; i++)
            {
                Console.Write(pol4.get(i));
            }
            Console.WriteLine();
            Console.WriteLine();
            
            List<IPolaczenie> listaPolaczen = new List<IPolaczenie>();


            for (int i = 0; i < 1000; i++)
            {
                listaPolaczen.Add(Baza.getPolaczenie());
            }
            Console.WriteLine("Dlugosc Listy {0}", listaPolaczen.Count);
            Console.WriteLine("Dlugosc Listy Distinct {0}", listaPolaczen.GroupBy(x => x).Select(x => x.First()).ToList().Count);
            Console.WriteLine(pol1.Equals(pol2));
            Console.WriteLine(pol2.Equals(pol3));
            Console.WriteLine(pol1.Equals(pol4));
            Console.Read();
        }

    }
}
