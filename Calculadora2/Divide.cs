using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    public class Divide : Operador
    {

        public Divide(decimal valor1, decimal valor2) : base(valor1, valor2)
        {

        }

        public override decimal Exec()
        {
            return Valor1 / Valor2;
        }
    }
}
