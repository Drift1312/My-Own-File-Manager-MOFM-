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
            for (int i = 0; i < filesDir.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + filesDir[i]);
            }
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
            switch (userInp)
            {
                case "cd":
                    Console.Write("Смена директории: ");
                    string changedDirectory = Console.ReadLine();
                    Directory dirCh11 = new Directory(changedDirectory);
                    ShowWindow dirCh12 = new ShowWindow(changedDirectory);
                    dirCh12.Print();
                    break;
                case "help":
                    MessageBox.Show("help - окно с командами" + "\n" +
                        "cd - смена директории");
                    break;
                default:
                    Console.WriteLine("Не та комманда");
                    break;
            }
        }
    }
}
