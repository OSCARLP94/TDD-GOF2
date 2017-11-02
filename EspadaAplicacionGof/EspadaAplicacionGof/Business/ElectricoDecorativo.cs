using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspadaAplicacionGof.Business
{
    public class ElectricoDecorativo : EspadaDecorator
    {
        public ElectricoDecorativo(IEspada espada) : base(espada)
        {

        }

        public override void Herir()
        {
            getEspada().Herir(); //sino base.
            Console.WriteLine("Daño electrico aplicado");
        }

    }
}
