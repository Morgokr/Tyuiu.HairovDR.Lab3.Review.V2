namespace SolveMathSecondExpression.Lib
{
    public static class MathSecondExpression
    {
        public static float CalculateSecondExpression(float arg1, float arg2, float arg3)
        {
            var a = (float)arg1;
            var x = (float)arg2;
            var y = (float)arg3;

            return 6 * x + ((2 * x + y - 3 * a) / (a + 2 * x - 7 * y)) + ( ((x+3) / y) / ((2 - x) / x));
        }

    }
}
