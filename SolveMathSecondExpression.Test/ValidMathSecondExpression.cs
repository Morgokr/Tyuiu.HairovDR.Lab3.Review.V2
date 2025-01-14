using SolveMathSecondExpression.Lib;
namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public sealed class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestCalculateSecondExpression()
        {
            Assert.AreEqual(Math.Round(MathSecondExpression.CalculateSecondExpression(5, 2, 4), 2), Math.Round(28.84761905, 2));
        }
    }
}
