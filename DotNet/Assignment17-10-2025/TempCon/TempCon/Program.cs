// See https://aka.ms/new-console-template for more information
using TemperatureConverter;
Console.WriteLine("Enter a Tempature to convert");
string StringTemp=Console.ReadLine();
TempConClass tempConClass = new TempConClass();
if(double.TryParse(StringTemp, out double temp))
{
    Console.WriteLine("Choose an Option to Convert \n 1.To Celsius \n 2.To Fahrenheit");
    String ch=Console.ReadLine();
    switch (ch)
    {
        case "1":

            Console.WriteLine(tempConClass.FahrenheitToCelsius(temp));
            break;
        case "2":
            Console.WriteLine(tempConClass.CelsiusToFahrenheit(temp));
            break;
        default:
            break;

    }
}