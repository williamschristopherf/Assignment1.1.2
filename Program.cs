// See https://aka.ms/new-console-template for more information
//variables
int num1 = 0;
int num2 = 0;
int total = 0;

//User inputs
Console.WriteLine("Enter your first number:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your second number:");
num2 = Convert.ToInt32(Console.ReadLine());

//Calculations
total = num1 + num2;

//Output
Console.WriteLine($"Total of {num1} and {num2} is {total}");