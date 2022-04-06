using System;
using NitroxCLI;

public static class Program
{ 
    public static void Main(string[] args) 
    {
        CLILogic logic;
        if (Environment.OSVersion.Platform == PlatformID.Unix)
        {
            Console.WriteLine("Using Unix");
        }
    }
}
