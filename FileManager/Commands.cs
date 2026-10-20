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
        void ShowFiles();
        void ShowFolders();
        void ShowAll();
    }
    class Commander : Commands
    {
        static string LastDirect = @"C:\";
        Directory dirCh = new Directory();
        ShowWindow dirCh1 = new ShowWindow();
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
                dirCh = new Directory(changedDirectory);
                dirCh1 = new ShowWindow(changedDirectory);
                LastDirect = changedDirectory;
                Console.Clear();
                dirCh1.Print(true, false, false);
            }
        }
        // Вывести сообщение с командами
        public void HelpMessage()
        {
            MessageBox.Show("help - окно с командами" + "\n" +
                        "cd - смена директории" + "\n" +
                        "clear - очистить экран" + "\n" +
                        "showlast - показать последний каталог" + "\n" +
                        "showfiles - показать только файлы" + "\n" +
                        "showfolders - показать только папки" + "\n" +
                        "showall - показать и файлы, и папки");
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
            dirCh = new Directory(LastDirect);
            dirCh1 = new ShowWindow(LastDirect);
            dirCh1.Print();
        }
        // Показать ТОЛЬКО ФАЙЛЫ
        public void ShowFiles()
        {
            Console.Clear();
            dirCh = new Directory(LastDirect);
            dirCh1 = new ShowWindow(LastDirect);
            dirCh1.Print(false, true, false);
        }
        // Показать ТОЛЬКО ПАПКИ
        public void ShowFolders()
        {
            Console.Clear();
            dirCh = new Directory(LastDirect);
            dirCh1 = new ShowWindow(LastDirect);
            dirCh1.Print(false, false, true);
        }
        // Показать И ФАЙЛЫ, И ПАПКИ
        public void ShowAll()
        {
            Console.Clear();
            dirCh = new Directory(LastDirect);
            dirCh1 = new ShowWindow(LastDirect);
            dirCh1.Print(true, true, true);
        }
    }
}
