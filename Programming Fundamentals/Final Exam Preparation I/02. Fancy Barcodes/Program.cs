using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string bracodePattern = @"@#+[A-Z][a-zA-Z\d]{4,}[A-Z]@#+";

            int numberOfBarcodesToRecive = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBarcodesToRecive; i++)
            {
                string currentBarcode = Console.ReadLine();

                if (Regex.IsMatch(currentBarcode, bracodePattern))
                {
                    // @###Brea0D@### => B R E A 0 D => 0
                    // @##Che46sE@### => C H E 4 6 S E => 4 6
                    //@#FreshFisH@# => digits.length = 0

                    char[] digits = currentBarcode.Where(char.IsDigit).ToArray();
                    // digits => [4, 6]

                    string barcodeGroup = digits.Length == 0 ? "00" : string.Join("", digits); // [4, 6] => 46
                    Console.WriteLine($"Product group: {barcodeGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
