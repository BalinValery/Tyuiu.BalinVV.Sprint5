using Tyuiu.BalinVV.Sprint5.Task6.V18.Lib;
namespace Tyuiu.BalinVV.Sprint5.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = @"C:\DataSprint5\InPutDataFileTask6V18.txt";
            FileInfo fileInfo = new FileInfo(s);
            bool file = fileInfo.Exists;
            Assert.AreEqual(true, file);
        }
    }
}
