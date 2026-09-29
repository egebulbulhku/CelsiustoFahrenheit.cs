Console.Write("Enter a °C to convert °F : ");
double d = double.Parse(Console.ReadLine());
double f = ((d * 9.0) / 5.0) + 32.0;
Console.WriteLine($"\n{d}°C is equal to {f}°F");