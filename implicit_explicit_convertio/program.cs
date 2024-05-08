using System;

public class Temperature
{
    public double Celsius { get; }


    public Temperature(double celsius)
    {
        Celsius = celsius;
    }


    public static explicit operator Fahrenheit(Temperature temp)
    {
        double fahrenheit = (temp.Celsius * 9 / 5) + 32;
        return new Fahrenheit(fahrenheit);
    }
}

public class Fahrenheit
{
    public double Value { get; }


    public Fahrenheit(double value)
    {
        Value = value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Temperature tempCelsius = new Temperature(25);


        Fahrenheit tempFahrenheit = (Fahrenheit)tempCelsius;

        Console.WriteLine($"Temperature in Fahrenheit: {tempFahrenheit.Value}");
    }
}
