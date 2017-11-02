using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanoInterpreteGof.Business
{
    public class Context
    {
        private string simbolo;
        private int valor;

        public Context(string entrada)
        {
            simbolo = entrada;
        }

        public String getSimbolo()
        {
            return simbolo;
        }

        public void setSimbolo(String entrada)
        {
            this.simbolo = entrada;
        }

        public int getValor()
        {
            return valor;
        }

        public void setValor(int valor)
        {
            this.valor = valor;
        }
    }
}
