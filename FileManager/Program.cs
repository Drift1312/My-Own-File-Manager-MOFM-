using System;

namespace FileManager
{
    class Program
    {
        static void Main()
        {
            string direct = @"C:\";
            Directory obj = new Directory(direct);
            ShowWindow window = new ShowWindow(direct);
            window.Print();
            UserInput();
        }
        static void UserInput()
        {
            Console.Write("COMMAND: ");
            string userDirect = Console.ReadLine();
            CommandInput userInput = new CommandInput(userDirect);
            userInput.DoCommand();
            UserInput();
        }
    }
}