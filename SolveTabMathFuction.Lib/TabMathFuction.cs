namespace SolveTabMathFuction.Lib
{
    public static class TabMathFuction
    {
        public static double[] CalculateTabMathFuction(int startValue, int stopValue, int yArg)
        {
            int range = Math.Abs(startValue - stopValue) + 1;
            var res = new double[range];
            double x = startValue;
            double y = yArg;
            for (int i = 0; i < range; i++)
            {
                res[i] = Math.Round((Math.Pow(2, -1 * x) + (5 / 3) * (Math.Pow(x, -1)) - Math.Cos(Math.Pow(x, 2)) + Math.Sin(2 * x)), 2);
                x += 1;
            }
            return res;
        }
    }
}
