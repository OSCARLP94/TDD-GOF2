using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspadaAplicacionGof.Business
{
    //interfaz me obligó a usar el metodo en una clase asbtracta que hereda(java no obliga a las abstractas hijas)
    public abstract class IEspada 
    {
        public abstract void Herir();
    }
}
