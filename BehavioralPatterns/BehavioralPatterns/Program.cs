using BehavioralPatterns.Classes.Iterators;
using BehavioralPatterns.Classes.Loggers;
using BehavioralPatterns.Classes.Mementos;
using BehavioralPatterns.Classes.StringCheckers;
using BehavioralPatterns.Interfaces;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("\nTask 1\n");
       Notebook notebook = new Notebook();
       notebook.AddNote(new Note("Shopping", "Buy something"));
       notebook.AddNote(new Note("Work", "Finish the project"));
       notebook.AddNote(new Note("Study", "Learn design patterns"));

        IAbstractIterator iterator = notebook.GetIterator();

        while (!iterator.IsDone)
        {
            Note currentNote = iterator.Current;
            currentNote.Show();
            iterator.Next();
        }

        Console.WriteLine("\nTask 2\n");

        Box box = new Box();
        box.AddProduct(new Product("Laptop", 999.99));
        box.AddProduct(new Product("Smartphone", 499.99));
        box.AddProduct(new Product("Headphones", 199.99));

        IProductIterator productIterator = box.GetProductIterator();

        while (!productIterator.IsDone)
        {
            Product currentProduct = productIterator.Current;
            Console.WriteLine(currentProduct);
            productIterator.Next();
        }

        Console.WriteLine("\nTASK 3\n");

        ToDoItem task = new ToDoItem("Finish report", "Complete the annual report", DateTime.Now.AddDays(7));
        CareTaker todoCareTaker = new CareTaker();

        todoCareTaker.Push(task.StoreState());
        task.Rename("Finish report ASAP");
        task.ChangeTask("Complete the annual report as soon as possible");

        Console.WriteLine( task + "\n");
        todoCareTaker.Push(task.StoreState());
        task.ChangeTask("Complete the annual report by end of the day");
        task.ChangeTimeDue(DateTime.Now.AddDays(10));
        Console.WriteLine( task + "\n");

        task.RestoreState(todoCareTaker.Pop());
        Console.WriteLine( task + "\n");


        Console.WriteLine("\nTASK 4\n");

        BankAccount account = new BankAccount("Vilim", "Bilice", 5.0m);
        BankCareTaker bankCareTaker = new BankCareTaker();
        
        Console.WriteLine(account + "\n");

        bankCareTaker.Push(account.StoreState());
        account.ChangeOwnerAddress("Slavonski Brod");
        account.UpdateBalance(25m);
        Console.WriteLine( account + "\n");

        account.RestoreState(bankCareTaker.Pop());
        Console.WriteLine(account + "\n");


        Console.WriteLine("\n TASK 5 \n");
        AbstractLogger logger = new ConsoleLogger(MessageType.ALL);

        FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
        
        logger.SetNextLogger(fileLogger);

        logger.Log("We are in", MessageType.INFO);

        logger.Log("WE ARE NOT IN", MessageType.WARNING);


        Console.WriteLine("\n TASK 6 \n");

        StringChecker lengthChecker = new StringLengthChecker(5);
        StringChecker digitChecker = new StringDigitChecker();     
        StringChecker upperChecker = new StringUpperCaseChecker(); 
        StringChecker lowerChecker = new StringLowerCaseChecker();


        lengthChecker.SetNext(digitChecker);
        digitChecker.SetNext(upperChecker);
        upperChecker.SetNext(lowerChecker);

        string[] testPasswords = { "Passw0rd", "password", "PASSWORD", "Pass", "P4ssword" };

        foreach(string password in testPasswords)
        {
            bool isValid = lengthChecker.Check(password);

            Console.WriteLine($"Password: {password}, Valid: {isValid}");
        }


        Console.WriteLine("\n TASK 7 \n");

        PasswordValidator validator = new PasswordValidator(lengthChecker);

        validator.AddChecker(new StringDigitChecker());
        validator.AddChecker(new StringUpperCaseChecker());
        validator.AddChecker(new StringLowerCaseChecker());

        foreach(string password in testPasswords)
        {
            bool isValid = validator.Validate(password);
            Console.WriteLine($"Password: {password}, Valid: {isValid}");
        }

    }
}