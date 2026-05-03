using Notification.Classes;
using Notification.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // === 1. SINGLETON: MATRIX GENERATOR ===
            Console.WriteLine("=== 1. SINGLETON: MATRIX GENERATOR ===");
            MatrixGenerator matrixGen = MatrixGenerator.GetInstance();
            double[][] matrix = matrixGen.FillMatrix(3, 3);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]:F4} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // === 2. SINGLETON: LOGGER ===
            Console.WriteLine("=== 2. SINGLETON: LOGGER ===");
            Logger logger = Logger.GetInstance();
            logger.FilePath = "app_log.txt";
            logger.Log("Test log entry.");
            Console.WriteLine($"Logger path: {logger.FilePath}\n");

            // === 3. BUILDER & DIRECTOR ===
            Console.WriteLine("=== 3. BUILDER & DIRECTOR ===");
            IBuilder builder = new NotificationBuilder();
            NotificationDirector director = new NotificationDirector(builder);
            NotificationManager manager = new NotificationManager();

            ConsoleNotification errorNote = director.CreateDefaultError("AdminUser");
            manager.Display(errorNote);
            Console.WriteLine();

            // === 4. PROTOTYPE: CLONING NOTIFICATION ===
            Console.WriteLine("=== 4. PROTOTYPE: CLONING NOTIFICATION ===");
            ConsoleNotification originalNote = director.CreateDefaultInfo("Operator");
            ConsoleNotification clonedNote = (ConsoleNotification)originalNote.Clone();

            Console.WriteLine("Original Author: " + originalNote.Author);
            Console.WriteLine("Cloned Author: " + clonedNote.Author);
            Console.WriteLine($"Objects are same reference: {Object.ReferenceEquals(originalNote, clonedNote)}\n");

            // === 5. PROTOTYPE: DEEP COPY DATASET ===
            Console.WriteLine("=== 5. PROTOTYPE: DEEP COPY DATASET ===");
            try
            {
                if (!System.IO.File.Exists("data.csv"))
                {
                    System.IO.File.WriteAllText("data.csv", "A,B,C\nD,E,F\nG,H,I");
                }

                Dataset originalDS = new Dataset("data.csv");
                Dataset clonedDS = (Dataset)originalDS.Clone();


                clonedDS.ClearData();


                Console.WriteLine($"Original Rows: {originalDS.GetData().Count}");
                Console.WriteLine($"Cloned Rows: {clonedDS.GetData().Count}");

                if (originalDS.GetData().Count > 0 && clonedDS.GetData().Count == 0)
                {
                    Console.WriteLine("RESULT: Deep Copy Successful (Original intact).");
                }
                else
                {
                    Console.WriteLine("RESULT: Deep Copy Failed (Original was modified).");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dataset Error: {ex.Message}");
            }

            Console.WriteLine("\nTesting finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
