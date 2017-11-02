using RomanoInterpreteGof.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanoInterpreteGof
{
    class Program
    {
        static void Main(string[] args)
        {
            string numRomano = "LXI";
            Context context = new Context(numRomano);

            //Contruir el arbol de expresiones
            //OJO! : En este caso el orden de expresiones importa !
            IEnumerable<IExpresion> arbol = new IExpresion[] {
                new MilenaExpresion(),
                new CentenaExpresion(),
                new DecenaExpresion(),
                new UnidadExpresion(),        
            };

            //Se pasa a interpretar
            foreach (IExpresion expresion in arbol)
            {
                expresion.Interpreta(context);
            }

            Console.Write("Numero romano "+numRomano+" = "+context.getValor());
            Console.ReadKey();
        }
    }
}
