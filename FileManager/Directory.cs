using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.ExceptionServices;

namespace FileManager
{
    // Данные о директории.
    class Directory
    {
        DirectoryInfo direct; // Объект для взаимодействия с директорией
        protected FileInfo[] filesDir; // Массив из файлов
        protected DirectoryInfo[] dirsDir; // Массив из папок
        public Directory(string s = @"C:\") // Конструктор класса
        {
            direct = new DirectoryInfo(s);
            filesDir = direct.GetFiles();
            dirsDir = direct.GetDirectories();
        }
    }
}