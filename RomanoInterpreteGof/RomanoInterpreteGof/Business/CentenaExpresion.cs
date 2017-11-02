using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanoInterpreteGof.Business
{
    public class CentenaExpresion: IExpresion
    {
        public override string Uno()
        {
            return "C";
        }

        public override string Cuatro()
        {
            return "CD";
        }

        public override string Cinco()
        {
            return "D";
        }

        public override string Nueve()
        {
            return "CM";
        }

        public override int Multiplo()
        {
            return 100;
        }
    }
}
