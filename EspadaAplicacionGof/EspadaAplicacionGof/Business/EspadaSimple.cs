using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspadaAplicacionGof.Business
{
    public class EspadaSimple : IEspada
    {
        public string nombre{ get; set; } //algunas espadas tienen nombre

        public EspadaSimple(string name) //constructor
        {
            nombre = name;
        }

        public override void Herir()
        {
            Console.WriteLine("Daño aplicado -40");
        }
    }
}
