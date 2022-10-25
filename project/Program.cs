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
            if (AH.Length > 2)
            {
                System.Console.WriteLine("Podaj maksymalnie dwa znaku");
                AH = Console.ReadLine();

                if (AH.Length < 2)
                {
                    System.Console.WriteLine("Podaj co najmniej dwa znaki");
                    AH = Console.ReadLine();
                }
                AH = Console.ReadLine();
            }
            // bool chars = IsMaxTwoChar(AH);
            // System.Console.WriteLine("Czy liczba posiada dwie wartości: " + chars);
            bool hexa = IsHex(AH);
            System.Console.WriteLine("Czy liczba jest hexa: " + hexa);


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
        // static bool IsMaxTwoChar(IEnumerable<char> chars)
        // {
        //     bool IsMaxTwoChar;
        //     foreach (var c in chars)
        //     {
        //         IsMaxTwoChar = (c > '1' && c < '3');
        //         if (!IsMaxTwoChar)
        //             return false;
        //     }
        //     return true;
        // }
    }

}