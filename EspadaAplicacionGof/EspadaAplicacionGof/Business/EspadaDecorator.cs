using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspadaAplicacionGof.Business
{
    public abstract class EspadaDecorator:IEspada
    {
        private IEspada espada;

        //Constructor
        public EspadaDecorator(IEspada espada)
        {
            this.espada = espada;
        }

        //solo para las clases hijas eh
        protected IEspada getEspada()
        {
            return espada;
        }

    }
}
