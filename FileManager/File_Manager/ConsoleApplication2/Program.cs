using System;
using System.IO;

namespace ConsoleApplication2
{
    internal class Program
    {
        private static void Main()
        {
            int i;
            do
            {
                Console.Write(
                    "Меню:\n1) Просмотр файлов  \n2) Копировать \n3) заменить \n4) удалить \n5) Открыть \n6) Выйти из программы\n\nВаше решение: ");
                // ReSharper disable once AssignNullToNotNullAttribute
                i = int.Parse(Console.ReadLine());
                Files files ;
                switch (i)
                {
                    case 1:
                        Console.Clear();
                        files = new Files();
                        Console.Write("Введите путь");
                        files.Per = Console.ReadLine();                
                        // ReSharper disable once UnusedVariable
                        foreach (var i1 in files._information())
                        {
                            Console.WriteLine(files.Name);
                            Console.WriteLine(files.Path);
                            Console.WriteLine(files.Size);
                            Console.WriteLine(files.DateOfChange);
                            Console.WriteLine(files.DateOfCreation);
                            Console.WriteLine(files.DateOfLastAccess);
                            Console.WriteLine("___________________________________________");
                            
                        }
                        break;
                    case 2:
                       /* files = new Files();
                        Console.WriteLine("Файл который необходимо скопировать");
                        files.Per = Console.ReadLine();
                        files.Write();
                        Console.WriteLine("Куда скопировать файл");
                        files.Copy();*/
                        break;
                    case 3:
                        files = new Files();
                        Console.WriteLine("Файл который необходимо переместить");
                        files.Per = Console.ReadLine();
                       // files.Write();
                        Console.WriteLine("Куда переместить файл файл");
                        files.Replace(Console.ReadLine());
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Путь к файлу");
                        files = new Files{Per = Console.ReadLine()};
                        files.Remove();
                        Console.WriteLine("Удалено");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Путь к файлу");
                        files = new Files {Per = Console.ReadLine()};
                        files.Open();
                        break;
                    case 6:
                        
                        break;
                    default:
                        Console.WriteLine("Вы что-то другое нажали...");
                        break;
                }
                Console.Write("\n\n\t\t\tНажмите любую клавишу...");
                Console.ReadLine();
                Console.Clear();
            } while (i != 6);
        }
    }
}
