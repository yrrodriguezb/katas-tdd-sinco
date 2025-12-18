namespace Calculator
{
    public class Calculator
    {
        public int Add(int sumando1, int sumando2) => sumando1 + sumando2;

        public int Subtract(int minuendo, int sustraendo) => minuendo - sustraendo;

        public int Multiply(int multiplicando, int multiplicador) => multiplicando * multiplicador;

        public int Divide(int dividendo, int divisor)
        {
            LanzarExcepcionSiElDivisorEsCero(divisor);

            return dividendo / divisor;
        }

        private static void LanzarExcepcionSiElDivisorEsCero(int divisor)
        {
            if (divisor == 0)
                throw  new DivideByZeroException("No es posible dividir por cero");
        }
    }
}