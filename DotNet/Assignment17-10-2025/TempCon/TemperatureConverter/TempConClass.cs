namespace TemperatureConverter
{
    public  class TempConClass
    {
        private TemperatureValidator temperatureValidator=new TemperatureValidator();
        public double CelsiusToFahrenheit(double temperatureValue)
        {
            if (temperatureValidator.TemperatureValidatorfunction(temperatureValue))
            {
               
                double Fahrenheit = (temperatureValue * (1.8) + 32);
                return Fahrenheit;
            }
            else
            {
                Console.WriteLine("Can not be converted");
                return 0.0;
            }
        }
        public double FahrenheitToCelsius(double temperatureValue)
        {
            double Celsius = (temperatureValue-32) * (5.0 / 9.0) ;
            if (temperatureValidator.TemperatureValidatorfunction(Celsius))
            {
                return Celsius; 
            }
            else
            {
               
                    Console.WriteLine("Resulting Celsius value is out of valid range."); ;
                return 0.0;
            }
        }
    }
}