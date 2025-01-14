using SolveTabMathFuction.Lib;
namespace SolveTabMathFuction.Test
{
    [TestClass]
    public sealed class ValidTabMathFuction
    {
        [TestMethod]
        public void TestCalculateTabMathFunction()
        {
            double[] array = {
                2.29,
                2.45,
                3.66,
                3.78,
                4.48,
                5.54,
                6.39,
                7.27,
                8.33,
                9.28,
                10.19
};
            CollectionAssert.AreEqual(array, TabMathFuction.CalculateTabMathFuction(0, 10, 1));
        }
    }
}
