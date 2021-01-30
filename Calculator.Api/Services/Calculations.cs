namespace Calculator.Api.Services
{
    public static class Calculations
    {
        public static decimal Add(decimal value1, decimal value2)
        {
            return decimal.Add(value1, value2);
        }

        public static decimal Subtract(decimal value1, decimal value2)
        {
            return decimal.Subtract(value1, value2);
        }

        public static decimal Multiply(decimal value1, decimal value2)
        {
            return decimal.Multiply(value1, value2);
        }

        public static decimal Divide(decimal value1, decimal value2)
        {
            return decimal.Divide(value1 , value2);
        }
    }
}
