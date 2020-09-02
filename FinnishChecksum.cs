using System;
using System.Collections.Generic;


namespace TestEnv
{
    class FinnishChecksum
    {
        public readonly string transactionReferenceString;
        
        // default constructor auto generates transactionRefstring acc to Finnish standard
        public FinnishChecksum()
        {
            int specifier = GenerateSpecifier(100, 9999999);
            transactionReferenceString = composeTransactionReference(specifier);
        }

        // constructor with argument if you want to generate own specifier with static method GenerateSpecifier
        public FinnishChecksum(int specifier)
        {
            transactionReferenceString = composeTransactionReference(specifier);
        }

        private string composeTransactionReference(int specifierNumber)
        {
            List<int> specifierDigitList;
            List<int> multiplierDigitList;
            List<int> productList;
            int product;
            int checkNumber;

            specifierDigitList = IntToIntList(specifierNumber);

            multiplierDigitList= CreateMultiplier(specifierDigitList);

            productList = CreateProductList(specifierDigitList, multiplierDigitList);

            product = CreateProduct(productList);

            checkNumber = CreateCheckDigit(product);

            return specifierNumber.ToString() + checkNumber.ToString();
        }

        public static int GenerateSpecifier(int minLength, int maxlength)
        {
            Random random = new Random();
            int specifier;

            specifier = random.Next(minLength, maxlength);

            return specifier;
        }

        private List<int> IntToIntList (int num)
        {
            if (num == 0)
                return new List<int>() { 0 };
    
            List<int> digits = new List<int>();
    
            for (; num != 0; num /= 10)
                digits.Add(num % 10);
    
            return digits;
        }

        private List<int> CreateMultiplier (List<int> digitList)
        {
            List<int> multiplierList = new List<int>();

            for (int i = 0; i < digitList.Count; i+=3)
            {
                multiplierList.Add(7);
                multiplierList.Add(3);
                multiplierList.Add(1);
            }

            return multiplierList;
        }

        private List<int> CreateProductList(List<int> specifierList, List<int> multiplierList)
        {
            for (int i = 0; i < specifierList.Count; i++)
            {
                specifierList[i] = specifierList[i] * multiplierList[i];
            }

            return specifierList;
        }

        private int CreateProduct(List<int> digitList)
        {
            int product = 0;

            foreach (int digit in digitList)
            {
                product += digit;
            }

            return product;
        }

        private int CreateCheckDigit(int product)
        {
            int productRoundOff = ((int)Math.Ceiling(product / 10.0)) * 10;
            
            int checkDigit = productRoundOff - product;

            return checkDigit;
        }  
    }
}
