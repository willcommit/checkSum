

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