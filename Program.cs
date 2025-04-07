// See https://aka.ms/new-console-template for more information
//variables
double num1 = 0;
double num2 = 0;
double total = 0;

//User inputs
Console.WriteLine("Enter your first number:");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your second number:");
num2 = Convert.ToDouble(Console.ReadLine());

//Calculations
total = num1 + num2;

//Output
Console.WriteLine($"Total of {num1} and {num2} is {total}");