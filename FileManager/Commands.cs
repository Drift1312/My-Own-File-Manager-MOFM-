using System;
using System.Collections.Generic;
using System.Text;

namespace FileManager
{
    // Интерфейс все команд файлового менеджера
    interface Commands
    {
        void ChangeDirectory();
        void HelpMessage();
        void Clear();
        void ShowLast();
    }
    class Commander : Commands
    {
        static string LastDirect = @"C:\";
        // Поменять директорию
        public void ChangeDirectory()
        {
            Console.Write("Смена директории: ");
            string changedDirectory = Console.ReadLine();
            if (!Path.Exists(changedDirectory)) // Проверка на существование директории
            {
                Console.WriteLine("Директория отсутствует");
            }
            else
            {
                Directory dirCh11 = new Directory(changedDirectory);
                ShowWindow dirCh12 = new ShowWindow(changedDirectory);
                LastDirect = changedDirectory;
                Console.Clear();
                dirCh12.Print();
            }
        }
        // Вывести сообщение с командами
        public void HelpMessage()
        {
            MessageBox.Show("help - окно с командами" + "\n" +
                        "cd - смена директории" + "\n" +
                        "clear - очистить экран" + "\n" +
                        "showlast - показать последний каталог");
        }
        // Очистить весь экран
        public void Clear()
        {
            Console.Clear();
        }
        //  Вывести последнюю директорию
        public void ShowLast()
        {
            Console.Clear();
            Directory dirCh21 = new Directory(LastDirect);
            ShowWindow dirCh22 = new ShowWindow(LastDirect);
            dirCh22.Print();
        }
    }
}
