using System;
namespace Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Podaj wartość AH:");

            string AH = Console.ReadLine();
            bool hexa = IsHex(AH);
            System.Console.WriteLine(AH);
            System.Console.WriteLine(hexa);

        }
        static bool IsHex(IEnumerable<char> chars)
        {
            bool isHex;
            foreach (var c in chars)
            {
                isHex = ((c >= '0' && c <= '9') ||
                          (c >= 'a' && c <= 'f') ||
                           (c >= 'A' && c <= 'F'));

                if (!isHex)
                    return false;
            }
            return true;
        }
    }

}