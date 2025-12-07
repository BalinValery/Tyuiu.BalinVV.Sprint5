using Tyuiu.BalinVV.Sprint5.Task5.V9.Lib;
using System.IO;
namespace Tyuiu.BalinVV.Sprint5.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 2;
            double result = Math.Round((0.7 * (Math.Pow(x, 3))) + (1.52 * (Math.Pow(x, 2))), 3);
            double wait = 11.68;
            Assert.AreEqual(wait, result);
        }
    }
}
