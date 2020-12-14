using ConsoleApp;
using System;
using System.Net.Http;

swaggerClient client = new("https://localhost:44330", new HttpClient());
var records = await client.WeatherForecastAsync();

foreach (var r in records)
{
    Console.WriteLine($"{ r.Date }: { r.Summary }");
}

Console.WriteLine($"total postage: { Postage(32.5) }");


static double Postage(double price) => price switch
{
    < 20 => 2.99,
    >= 20 and < 40 => 3.99,
    _ => 4.99
};

public partial class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    private partial double SetPrice();
}

public partial class Product
{
    private partial double SetPrice()
    {
        return 0;
    }
}