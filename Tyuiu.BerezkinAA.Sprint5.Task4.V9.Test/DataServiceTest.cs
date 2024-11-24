using Tyuiu.BerezkinAA.Sprint5.Task4.V9.Lib;
namespace Tyuiu.BerezkinAA.Sprint5.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\VisualStudioRepos\Tyuiu.BerezkinAA.Sprint5\Tyuiu.BerezkinAA.Sprint5.Task4.V9\bin\Debug\InPutDataFileTask4V9.txt";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
