using StructualPatterns.Classes;
using StructualPatterns.Interfaces;

public static class Program
{
    public static void Main(string[] args)
    {
        string filePath = "data.csv";
        Dataset dataset = new Dataset(filePath);

        Analyzer3rdParty service = new Analyzer3rdParty();
        IAnalytics adapter = new Adapter(service);

        double[] rowAverages = adapter.CalculateAveragePerRow(dataset);
        double[] columnAverages = adapter.CalculateAveragePerColumn(dataset);

        Console.WriteLine("Averages per row:");
        foreach (double avg in rowAverages)
        {
            Console.WriteLine(avg);
        }

        Console.WriteLine("\nAverages per column:");
        foreach (double avg in columnAverages)
        {
            Console.WriteLine(avg);
        }
        Console.WriteLine("\n");

        List<IRentable> items = new List<IRentable>();

        items.Add(new Video("Inception"));
        items.Add(new Book("Crime and Punishment"));
        items.Add(new HotItem(new Video("Avatar 2")));
        items.Add(new HotItem(new Book("Dune")));

        RentingConsolePrinter printer = new RentingConsolePrinter();

        Console.WriteLine("--- Rented Items List ---");
        printer.DisplayItems(items);

        Console.WriteLine("-------------------------");
        printer.PrintTotalPrice(items);




        List<IRentable> flashSale = new List<IRentable>();
        foreach (var item in items)
        {
            flashSale.Add(new DiscountedItem(item));
        }

        Console.WriteLine("--- Rented Items List ---");
        printer.DisplayItems(flashSale);

        Console.WriteLine("-------------------------");
        printer.PrintTotalPrice(flashSale);

        Console.WriteLine("\n");

        IPasswordValidatorService passwordService = new PasswordValidator(8);

        string pass1 = "abc123";
        string pass2 = "Abcdefgh1";

        Console.WriteLine("--- Password Testing ---");
        Console.WriteLine($"Password '{pass1}' valid: {passwordService.IsValidPassword(pass1)}");
        Console.WriteLine($"Password '{pass2}' valid: {passwordService.IsValidPassword(pass2)}");


        IEmailValidatorService emailService = new EmailValidator();

        string email1 = "test@gmail.com";
        string email2 = "user@net.ba";
        string email3 = "no-at-sign.hr";

        Console.WriteLine("\n--- Email Testing ---");
        Console.WriteLine($"Email '{email1}' valid: {emailService.IsValidAddress(email1)}");
        Console.WriteLine($"Email '{email2}' valid: {emailService.IsValidAddress(email2)}");
        Console.WriteLine($"Email '{email3}' valid: {emailService.IsValidAddress(email3)}");

        Console.WriteLine("\n");

        IRegistrationValidator registrationFacade = new RegistrationValidator();
        bool isRegistrationSuccessful = false;

        while (!isRegistrationSuccessful)
        {
            Console.WriteLine("\n--- Registration Form ---");
            UserEntry entry = UserEntry.ReadUserFromConsole();

            isRegistrationSuccessful = registrationFacade.IsUserEntryValid(entry);

            if (isRegistrationSuccessful)
            {
                Console.WriteLine("Registration successful! Welcome.");
            }
            else
            {
                Console.WriteLine("Registration failed. Please try again.");
            }
        }
    }
}