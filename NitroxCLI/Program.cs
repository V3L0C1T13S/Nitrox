using System;
using NitroxCLI;

public static class Program
{ 
    public static void Main(string[] args) 
    {
        CLILogic logic = new CLILogic();

        if (Environment.OSVersion.Platform == PlatformID.Unix)
        {
            Console.WriteLine("Using Unix");
        }

        // Ask for what to do
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Patch Subnautica");
        Console.WriteLine("2. Unpatch Subnautica");
        Console.WriteLine("3. Exit");

        // Get input
        string input = Console.ReadLine();

        switch(input)
        {
            case "1":
                logic.BeginPatch();
                Console.WriteLine("Patched! Would you like to play now? (y/n)");
                string play = Console.ReadLine();
                if (play == "y")
                {
                    Console.WriteLine("Launching Subnautica...");
                    logic.LaunchSubnautica();
                }
                break;
            case "2":
                logic.Dispose();
                break;
            case "3":
                return;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}
