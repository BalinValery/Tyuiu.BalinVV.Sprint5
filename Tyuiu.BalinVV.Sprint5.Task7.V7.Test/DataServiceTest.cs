using Tyuiu.BalinVV.Sprint5.Task7.V7.Lib;
using System.IO;
namespace Tyuiu.BalinVV.Sprint5.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "C:\\DataSprint5\\Sprint5Task7\\InPutDataFileTask7V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            Assert.IsTrue(fileexists);
        }
    }
}
