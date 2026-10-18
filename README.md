Общая структура
<img width="1090" height="526" alt="image" src="https://github.com/user-attachments/assets/2bb795e7-96c8-4149-8f63-e2fa5e73a92d" />

Ввод пользователя
<img width="1090" height="519" alt="image" src="https://github.com/user-attachments/assets/ba35c4e4-18ce-4cbb-9d9e-4acac5a4f1af" />

-Program.cs-

•	Directory obj = new Directory(@"C:\"); - создание объекта класса Directory (свойства каталога) и передачей в него значения по умолчанию C:\ в качестве каталога по умолчанию.


•	ShowWindow window = new ShowWindow(@"C:\"); - создание объекта класса ShowWindow (вывод на экран каталога) и передачей в него значения по умолчанию C:\ в качестве каталога по умолчанию.


•	window.Print(); - вывод созданного каталога на экран


•	UserInput(); - вызов функции ввода команды пользователя

UserInput():

•	string userDirect = Console.ReadLine(); - ввод команды пользователем

•	CommandInput userInput = new CommandInput(userDirect); - создание объекта CommandInput и передача в её конструктор введенной команды

•	userInput.DoCommand(); - исполнение команды внутри блока switch

•	UserInput(); - рекурсия функции ввода команды пользователем

Данные о директории
<img width="884" height="647" alt="image" src="https://github.com/user-attachments/assets/49e8ad17-e821-4b25-888c-41741893f3b3" />


-Directory.cs-

Directory: класс со свойствами текущего каталога

•	DirectoryInfo direct; - объект для взаимодействия с директорией

•	protected FileInfo[] filesDir; - массив из файлов каталога

•	protected DirectoryInfo[] dirsDir; - массив из подкаталогов каталога

•	public Directory(string s) – конструктор принимает в качестве параметра дефолтный/введенный пользователем каталог

Команды
<img width="857" height="591" alt="image" src="https://github.com/user-attachments/assets/968ca29e-643d-4ad6-a1cd-493773cf9898" />

-Commands.cs-

•	interface Commands – интерфейс со всеми командами

•	class Commander – класс, реализующий команды интерфейса Commands

Вывод информации на экран
<img width="1048" height="331" alt="image" src="https://github.com/user-attachments/assets/f45b31c7-0044-4bc3-bfae-68295219c81f" />

-Window.cs-

•	class ShowWindow – класс с методом вывода содержимого в консоль. Наследуется от Directory для того, чтобы знать, что выводить

•	class CommandInput – класс для выполнения введенной пользователем команды. Под разную команду вызываются разные методы из Commands.cs. Вызываются команды через объект com класса Commander.
