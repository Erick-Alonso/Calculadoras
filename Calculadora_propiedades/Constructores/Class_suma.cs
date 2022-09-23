namespace Calculadora_propiedades
{
    internal class Class_op
    {
        protected double can1, can2;

        public double can11{ get { return can1; } set { can1 = value; } }

        public double can22{ get { return can2; } set { can2 = value; } }

        /*
         * creaba una clase y no me permetia heredar asi que utilize
         * la clase suma para heredar tal vez error de compilacion idk
        */

        public double suma()
        {
            return can11 + can22;
        }
    }
}