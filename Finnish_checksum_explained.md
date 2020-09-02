## FINNISH CHECKSUM EXPLAINED
Example: The reference number are formed from the payment specifier, for example 1234567,   by calculating a check digit, i.e. the last digit of the reference number, by using multipliers 7-3-1.  
The specifier’s digits are multiplied from right to left, and the products are added up.  
The sum is then subtracted from the next highest ten, and the remainder is the check digit added to the specifier.  
Specifier: 1 2 3 4 5 6 7  
Multiplier: 7 1 3 7 1 3 7  
Product: 7 2 9 28 5 18 49 = 118  
Check digit: 120 - 118 = 2  
=> The reference number is 12345672  