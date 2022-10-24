using System;
namespace Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Podaj wartość AH:");

            string AH = Console.ReadLine();


            //Sprawdzenie długości stringa
            while (AH.Length > 2)
            {
                System.Console.WriteLine("Podaj maksymalnie dwa znaku");
                AH = Console.ReadLine();
            }
            bool hexa = IsHex(AH);
            System.Console.WriteLine(hexa);


            System.Console.WriteLine("Długość stringa: " + AH.Length);

            System.Console.WriteLine("Wartość AH: " + AH);
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