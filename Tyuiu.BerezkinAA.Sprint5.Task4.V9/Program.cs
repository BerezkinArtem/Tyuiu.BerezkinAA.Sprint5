using Tyuiu.BerezkinAA.Sprint5.Task4.V9.Lib;
namespace Tyuiu.BerezkinAA.Sprint5.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Березкин А.А | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле             *");
            Console.WriteLine("* Вычислить значение по формуле и вывести на консоль.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4.tx");
            Console.WriteLine("Данные находятся в файле:" + path);


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Файл: " + res);
            
            Console.ReadKey();

        }
    }
}