using Tyuiu.BerezkinAA.Sprint5.Task7.V18.Lib; 
namespace Tyuiu.BerezkinAA.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\VisualStudioRepos\Tyuiu.BerezkinAA.Sprint5\Tyuiu.BerezkinAA.Sprint5.Task7.V18\bin\Debug\InPutDataFileTask7V18.txt";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}