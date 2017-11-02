using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanoInterpreteGof.Business
{
    public class DecenaExpresion: IExpresion
    {
        public override string Uno()
        {
            return "X";
        }

        public override string Cuatro()
        {
            return "XL";
        }

        public override string Cinco()
        {
            return "L";
        }

        public override string Nueve()
        {
            return "XC";
        }

        public override int Multiplo()
        {
            return 10;
        }
    }
}
