using Tyuiu.BerezkinAA.Sprint5.Task7.V18.Lib;
namespace Tyuiu.BerezkinAA.Sprint5.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Березкин А.А | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #6                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Заменить все буквы н   *");
            Console.WriteLine("* на нн. Полученный результат сохранить в файл                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V18.txt");
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V18.txt");
            Console.WriteLine("Данные находятся в файле:" + path);


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine("Находится в файле: " + pathSaveFile);

            Console.ReadKey();

        }
    }
}