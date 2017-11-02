using EspadaAplicacionGof.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspadaAplicacionGof
{
    class Program
    {
        static void Main(string[] args)
        {
            IEspada espada = new EspadaSimple("Espada de Vicovaro");
           //Aplicando veneno
            espada.Herir();
           
            Console.ReadKey();
        }
    }
}
