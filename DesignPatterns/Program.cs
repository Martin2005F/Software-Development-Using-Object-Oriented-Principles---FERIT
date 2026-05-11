using System;
using DesignPatterns.Classes;
using DesignPatterns.Interfaces;
public static class Program
{
    public static void Main()
    {
        Product laptop = new Product("High-end gaming laptop", 1500, 5);
        Product phone = new Product("Smartphone", 800, 0.5);

        Box box = new Box("A box");

        box.Add(laptop);
        box.Add(phone);

        box.Description();

        Console.WriteLine("Total Price: $" + box.Price);
        Console.WriteLine("TOtal Weight: " + box.Weight + " kg");

        ShippingService shippingService = new ShippingService();
        Console.WriteLine("Shopping cost: " +shippingService.CalculateShippingCost(box));


        DataConsolePrinter printer = new DataConsolePrinter();

        IDataset virutalProxy = new VirtualProxyDataset("data.csv");

        Console.WriteLine("\n------------------------------------\n");

        User authorized = User.GenerateUser("Pero");
        User unauthorized = User.GenerateUser("Vilim");

        ProtectionProxyDataset protectionAuthorized = new ProtectionProxyDataset(authorized);
        ProtectionProxyDataset protectionUnauthorized = new ProtectionProxyDataset(unauthorized);


        printer.Print(protectionAuthorized.GetData());
        printer.Print(protectionUnauthorized.GetData());

        Console.WriteLine("\n--- TEST: LOGGING PROXY (Zadatak 4) ---");
        IDataset loggingProxy = new LoggingProxyDataset("data.csv");
        printer.Print(loggingProxy.GetData());
       


        Console.WriteLine("\n--- TEST: BRIDGE - BILJESKE I TEME (Zadaci 5 i 6) ---");

        ITheme light = new LightTheme();
        ITheme dark = new DarkTheme();

        GroupNote grupna = new GroupNote("COffe", light);
        grupna.AddMember("Pero");
        grupna.AddMember("Vilim");
        grupna.AddMember("Maja");

        grupna.Show(); 

        Console.WriteLine("\n--- TEST: NOTEBOOK (Zadatak 7) ---");

       
        Notebook myNotebook = new Notebook(dark);

        myNotebook.AddNote(new ReminderNote("Buy something", light));
        myNotebook.AddNote(grupna);

        Console.WriteLine("(Original theme):");
        myNotebook.Display();

       
        Console.WriteLine("Prikaz nakon grupne promjene teme:");
        myNotebook.ChangeTheme(light);

        myNotebook.Display();

    }
}