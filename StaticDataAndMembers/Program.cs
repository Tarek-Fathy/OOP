﻿using StaticDataAndMembers;

//Console.WriteLine("***** Fun with Static Data *****\n");
//SavingsAccount s1 = new SavingsAccount(50);
//SavingsAccount s2 = new SavingsAccount(100);
//SavingsAccount s3 = new SavingsAccount(10000.75);
//Console.ReadLine();


Console.WriteLine("***** Fun with Static Data *****\n");
SavingsAccount s1 = new SavingsAccount(50);
SavingsAccount s2 = new SavingsAccount(100);
// Print the current interest rate.
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
// Make new object, this does NOT 'reset' the interest rate.
SavingsAccount s3 = new SavingsAccount(10000.75);
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
Console.ReadLine();