using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerezkinAA.Sprint5.Task0.V28.Lib
{
    public class DataService : ISprint5Task0V28
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double z = (double)x * Math.Sqrt((double)x + 3);
            z = Math.Round(z, 2);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
