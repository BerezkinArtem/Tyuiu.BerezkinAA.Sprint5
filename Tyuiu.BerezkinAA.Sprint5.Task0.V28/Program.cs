using Tyuiu.BerezkinAA.Sprint5.Task0.V28.Lib;
namespace Tyuiu.BerezkinAA.Sprint5.Task0.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            DataService ds = new DataService();

            

            Console.Title = "Спринт #5 | Выполнил: Березкин А.А | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись данных в текстовый файл                                    *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("х = "+ a);

            

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(a);
            
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}