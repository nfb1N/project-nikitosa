using System;

namespace project_nikitosa
{
    class Program
    {
        static void Main(string[] args)
        {
          Drob dr1 = new Drob(2, 5);
          Drob dr2 = new Drob(3, 4);
          Console.WriteLine($"first: {dr1}\n second: {dr2}");
          Console.WriteLine($"first > second?: {dr1 > dr2}");
          Console.WriteLine($"first == second?: {dr1 == dr2}");
          
          Drob dr3 = dr1 + dr2;
          Console.WriteLine($"first + second: {dr3}");
          Console.WriteLine($"reduction: {dr3.reduction()}");
          
        }

    }
}
