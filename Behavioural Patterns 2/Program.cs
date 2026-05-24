using Behavioural_Patterns_2.Classes;
using Behavioural_Patterns_2.Classes.Observer;
using Behavioural_Patterns_2.Classes.Search; 
using Behavioural_Patterns_2.Classes.Sort;
using Behavioural_Patterns_2.Classes.Visitor;
using Behavioural_Patterns_2.Interfaces;
public static class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("TASK 1 & 2\n");

        double[] numbers = { 5.5, 2.3, 9.8, 1.2, 4.6 };
        NumberSequence numberSequence = new NumberSequence(numbers);

        Console.WriteLine("Original sequence:");
        Console.WriteLine(numberSequence);
        numberSequence.SetSortStrategy(new BubbleSort());
        numberSequence.Sort();
        Console.WriteLine(numberSequence);

        Console.WriteLine("\nTASK 3 & 4\n");

        SystemDataProvider provider  = new SystemDataProvider();

        Logger consoleLogger = new ConsoleLogger();
        Logger fileLogger = new FileLogger("system_data_log.txt");

        provider.Attach(consoleLogger);
        provider.Attach(fileLogger);

        /*  while (true)
          {
              float cpu = provider.GetCPULoad();
              float ram = provider.GetAvailableRAM();

              Console.WriteLine($"CPU Load: {cpu}% | Available RAM: {ram} MB");

              Thread.Sleep(5000);
          }
          */

        Console.WriteLine("\n TASK 5, 6 & 7");

        DVD movie = new DVD("Inception",DVDType.MOVIE, 19.99);
        DVD software = new DVD("Visual Studio", DVDType.SOFTWARE, 499.99);
        VHS vhs = new VHS("The Matrix", 9.99);

        Book book = new Book("The Great Gatsby", 10.99);

        Cart cart = new Cart();
        cart.AddItem(movie);
        cart.AddItem(software);
        cart.AddItem(vhs);
        cart.AddItem(book);

        IVisitor buyVisitor = new BuyVisitor();
        IVisitor rentVisitor = new RentVisitor();

        Console.WriteLine($"Price for buying a movie with taxes: {movie.Accept(buyVisitor)}");
        Console.WriteLine($"Price for renting a movie: {movie.Accept(rentVisitor):C}");
        Console.WriteLine($"Price for renting a softwere: {software.Accept(rentVisitor):C}");

        Console.WriteLine($"Total price for buying all items in the cart: {cart.Accept(buyVisitor):C}");
        Console.WriteLine($"Total price for renting all items in the cart: {cart.Accept(rentVisitor):C}");
    }
}