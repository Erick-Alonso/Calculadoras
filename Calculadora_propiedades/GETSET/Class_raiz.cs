using System;

namespace Calculadora_propiedades
{
    internal class Class_raiz
    {
        private double can1;

        public double can11 { get { return can1; } set { can1 = value; } }

        public double raiz()
        {
            return Math.Sqrt(can11);
        }
    }
}