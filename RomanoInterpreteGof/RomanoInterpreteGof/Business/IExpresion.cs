using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanoInterpreteGof.Business
{
    public abstract class IExpresion
    {
        public abstract string Uno();
        public abstract string Cuatro();
        public abstract string Cinco();
        public abstract string Nueve();
        public abstract int Multiplo();

        public void Interpreta(Context context)
        {
            if (context.getSimbolo().StartsWith(Nueve()))
            {
                context.setValor(context.getValor() + 9 * Multiplo());
                context.setSimbolo( context.getSimbolo().Substring(2));
            }

            else if (context.getSimbolo().StartsWith(Cuatro()))
            {
                context.setValor(context.getValor() + 4 * Multiplo());
                context.setSimbolo(context.getSimbolo().Substring(2));
            }

            else if (context.getSimbolo().StartsWith(Cinco()))
            {
                context.setValor(context.getValor() + 5 * Multiplo());
                context.setSimbolo(context.getSimbolo().Substring(1));
            }

            while (context.getSimbolo().StartsWith(Uno()))
            {
                context.setValor(context.getValor() + 1 * Multiplo());
                context.setSimbolo(context.getSimbolo().Substring(1));
            }
        }
    }
}
