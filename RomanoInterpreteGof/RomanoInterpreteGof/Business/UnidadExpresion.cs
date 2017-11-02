using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanoInterpreteGof.Business
{
    public class UnidadExpresion : IExpresion
    {
        public override string Uno()
        {
            return "I";
        }

        public override string Cuatro()
        {
            return "IV";
        }

        public override string Cinco()
        {
            return "V";
        }

        public override string Nueve()
        {
            return "IX";
        }

        public override int Multiplo()
        {
            return 1;
        }
       
    }
}
