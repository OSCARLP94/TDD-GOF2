using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanoInterpreteGof.Business
{
    public class MilenaExpresion:IExpresion
    {
        public override string Uno()
        {
            return "M";
        }

        public override string Cuatro()
        {
            return " ";
        }

        public override string Cinco()
        {
            return " ";
        }

        public override string Nueve()
        {
            return " ";
        }

        public override int Multiplo()
        {
            return 1000;
        }
    }
}
