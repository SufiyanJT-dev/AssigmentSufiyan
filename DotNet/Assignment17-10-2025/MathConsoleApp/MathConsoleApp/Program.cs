// See https://aka.ms/new-console-template for more information
using MathUtilities;
Console.WriteLine("Enter  number");
Mathss Maths = new Mathss();
string stringNumber =Console.ReadLine();
if(int.TryParse(stringNumber, out int number))
{
    Console.WriteLine("even or not");
    Maths.IsEven(number);
    Console.WriteLine("Prime or not");
    Maths.IsPrime(number);
    Console.WriteLine("fact of the number");
    Maths.Factorial(number);
}
else
{
    Console.WriteLine("Enter a Valid Number");
}
