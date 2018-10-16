using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1ZTP
{
    public  interface IPolaczenie
    {
        char get(int indeks);
        void set(int indeks, char c);
        int length();
    }
}
