using Tyuiu.BerezkinAA.Sprint5.Task3.V30.Lib;
namespace Tyuiu.BerezkinAA.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        { 
         string path = @"D:\VisualStudioRepos\Tyuiu.BerezkinAA.Sprint5\Tyuiu.BerezkinAA.Sprint5.Task3.V30\bin\Debug\OutPutFileTask3.bin";


        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists);
        }
    }
}