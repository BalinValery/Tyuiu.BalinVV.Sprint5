using System.IO;
using Tyuiu.BalinVV.Sprint5.Task1.V18.Lib;
namespace Tyuiu.BalinVV.Sprint5.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string wait = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint5\Tyuiu.BalinVV.Sprint5.Task1.V18\bin\Debug\OutPutFileTask1.txt";

            string path = ds.SaveToFileTextData(-5, 5);
            bool res = File.Exists(path);
            bool b_wait = true;

            Assert.AreEqual(b_wait, res);

        }
    }
}
