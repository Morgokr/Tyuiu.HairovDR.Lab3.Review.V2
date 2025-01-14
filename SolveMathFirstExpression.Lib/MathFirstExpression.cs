namespace SolveMathFirstExpression.Lib
{
    public static class MathFirstExpression
    {
        public static float CalculateFirstExpression(float arg1, float arg2, float arg3)
        {
            var a = (float)arg1;
            var x = (float)arg2;
            var y = (float)arg3;
            return 12 * y - ((3 * x + 2 * a + a) / (3 * a + 2 * x - y)) + 12 * y + ((x / y + 2 + a / y) / ((2 - a + 1 ) / x) );
        }
    }
}
