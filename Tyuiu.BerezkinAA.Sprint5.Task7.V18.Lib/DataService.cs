using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerezkinAA.Sprint5.Task7.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V18.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string fileContent = File.ReadAllText(path);

            string modifiedContent = fileContent.Replace("н", "нн");

            File.WriteAllText(pathSaveFile, modifiedContent);
            return pathSaveFile;
        }
    }
}