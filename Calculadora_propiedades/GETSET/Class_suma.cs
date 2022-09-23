namespace Calculadora_propiedades
{
    internal class Class_suma
    {
        private double can1, can2;

        public double can11 { get { return can1; } set { can1 = value; } }

        public double can22 { get { return can2; } set { can2 = value; } }

        public double suma()
        {
            return can11 + can22;
        }
    }
}