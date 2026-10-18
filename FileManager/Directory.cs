using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.ExceptionServices;

namespace FileManager
{
    // Данные о директории. По умолчанию при старте директория C:\
    class Directory 
    {
        protected string directPath; // Путь к директории, хранящийся в виде строки
        DirectoryInfo direct; // Объект для взаимодействия с директорией
        protected FileInfo[] filesDir; // Массив
        public Directory(string s = @"C:\") // Конструктор класса
        {
            directPath = s;
            direct = new DirectoryInfo(directPath);
            filesDir = direct.GetFiles();
        }

    }
    
}
