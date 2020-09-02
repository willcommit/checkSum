// ------------ EXAMPLE FORMING TRANS REF NUM ------------
// Example: The reference number are formed from the payment specifier, for example 1234567, 
// by calculating a check digit, i.e. the last digit of the reference number, by using multipliers 7-3-1. 
// The specifier’s digits are multiplied from right to left, and the products are added up. 
// The sum is then subtracted from the next highest ten, 
// and the remainder is the check digit added to the specifier.
// Specifier: 1 2 3 4 5 6 7
// Multiplier: 7 1 3 7 1 3 7
// Product: 7 2 9 28 5 18 49 = 118
// Check digit: 120 - 118 = 2
// => The reference number is 12345672

using System;

namespace TestEnv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Autogenerate with random specifier in constructor
            FinnishChecksum finnishChecksum = new FinnishChecksum();
            Console.WriteLine(finnishChecksum.transactionReferenceString);

            //Generate with GenerateSpecificer method provied specifier in constructor
            int specifier = FinnishChecksum.GenerateSpecifier(100000, 999999);
            FinnishChecksum finnishChecksum1 = new FinnishChecksum(specifier);
            Console.WriteLine(finnishChecksum1.transactionReferenceString);

            //Generate with example specifier 
            FinnishChecksum finnishChecksum2 = new FinnishChecksum(1234567);
            Console.WriteLine(finnishChecksum2.transactionReferenceString);
        }
    }
}