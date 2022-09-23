using System;

namespace Calculadora_propiedades
{
    internal class Class_raiz
    {
        double can1;
        public Class_raiz(double can1)
        {
            this.can1 = can1;
        }
        public double raiz()
        {
            return Math.Sqrt(can1);
        }
    }
}