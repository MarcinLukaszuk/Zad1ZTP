using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1ZTP
{

    public sealed class Baza
    {
        private char[] tab = new char[100];
        private Baza() { }

        private static Baza _instanceBaza;
        static Baza getBazaInstance()
        {
            if (_instanceBaza == null) _instanceBaza = new Baza();
            return _instanceBaza;
        }

        public static IPolaczenie getPolaczenie()
        {
            return Polaczenie.getInstance();
        }
        public sealed class Polaczenie : IPolaczenie
        {
            static Baza baza = getBazaInstance();
            static List<Polaczenie> _polaczeniaInstances = new List<Polaczenie>() { new Polaczenie(), new Polaczenie(), new Polaczenie() };
            static int instanceNumber = 0;

            private Polaczenie() { }
            public static IPolaczenie getInstance()
            {
                return _polaczeniaInstances[instanceNumber++ % 3];
            }

            public char get(int indeks)
            {
                return baza.tab[indeks];
            }
            public void set(int indeks, char c)
            {
                baza.tab[indeks] = c;
            }
            public int length()
            {
                return baza.tab.Count();
            }
        }
    }
}



