using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    public abstract class Operador
    { 
        public decimal Valor1 { get; set; }

        public decimal Valor2 { get; set; }

        public Operador(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public abstract decimal Exec();

        public override string ToString()
        {
            return Exec().ToString(); 
        }
    }
}
