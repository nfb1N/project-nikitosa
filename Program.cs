using System;

namespace project_nikitosa
{
    class Program
    {
        static void Main(string[] args)
        {
          Marker mark = new Marker(-12, ConsoleColor.DarkRed);
          string s = "null";
          mark.write(s);
          System.Console.WriteLine($"count of using: {mark.CountOfUsingProp}");
        }

    }
}
