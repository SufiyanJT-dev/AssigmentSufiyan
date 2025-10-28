namespace TemperatureConverter
{
    
        internal class TemperatureValidator
        {
        public bool TemperatureValidatorfunction(double temperatureValue)
            {
                if (temperatureValue > -273.15 && temperatureValue < 5500)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        
    }
}

