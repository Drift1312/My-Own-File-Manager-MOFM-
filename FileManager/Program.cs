using System;

namespace FileManager
{
    class Program
    {
        static void Main()
        {
            Directory obj = new Directory(@"C:\");
            ShowWindow window = new ShowWindow(@"C:\");
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