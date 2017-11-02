using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspadaAplicacionGof.Business
{
    public class VenenoDecorativo : EspadaDecorator
    {
        //obtiene la espada original como base
       public VenenoDecorativo(IEspada espada): base(espada) 
       {
            
       }

        public override void Herir()
        {
            getEspada().Herir(); //sino base.
            Console.WriteLine("Veneno aplicado");
        }
    }
}
