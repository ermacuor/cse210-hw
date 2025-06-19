using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;


class Program
{
    static void Main()
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Activity list");
            Console.WriteLine("  5. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
                activity = new BreathingActivity();
            else if (choice == "2")
                activity = new ReflectingActivity();
            else if (choice == "3")
                activity = new ListingActivity();
            else if (choice == "4")
                ShowActivityHistory();
            else if (choice == "5")
                break;

            if (activity != null)
                activity.Start();
        }
    }

    static void ShowActivityHistory()
    {
        string logFile = "activity_log.txt";

        if (File.Exists(logFile))
        {
            Console.WriteLine("Historial de actividades:");
            foreach (var line in File.ReadLines(logFile))
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No hay historial disponible.");
        }
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
