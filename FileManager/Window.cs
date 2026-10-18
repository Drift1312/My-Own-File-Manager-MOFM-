using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FileManager
{
    // Вывод информации на экран
    class ShowWindow : Directory
    {
        public ShowWindow(string s) : base(s) { } // Принимает путь директории от class Directory
        public void Print()
        {
            Console.Clear();
            Console.WriteLine("My Own File Manager");
            Console.WriteLine("VIEW MODE");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("-------------------------FOLDERS----------------------------");
            for (int i = 0; i < dirsDir.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + dirsDir[i]);
            }
            Console.WriteLine("--------------------------FILES-----------------------------");
            for (int i = 0; i < filesDir.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + filesDir[i]);
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");
        }
    }
    class CommandInput
    {
        private string userInp;
        public CommandInput(string s)
        {
            userInp = s;
        }
        
        public void DoCommand()
        {
            Commander com = new Commander(); // Объект класса для взаимодействия с командами
            switch (userInp)
            {
                case "cd":
                    com.ChangeDirectory();
                    break;
                case "help":
                    com.HelpMessage();
                    break;
                case "clear":
                    com.Clear();
                    break;
                case "showlast":
                    com.ShowLast();
                    break;
                default:
                    com.Clear();
                    com.ShowLast();
                    break;
            }
        }
    }
}