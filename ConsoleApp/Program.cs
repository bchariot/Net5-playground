using ConsoleApp;
using System;
using System.Net.Http;

/*
swaggerClient client = new("https://localhost:44330", new HttpClient());
var records = await client.WeatherForecastAsync();

foreach (var r in records)
{
    Console.WriteLine($"{ r.Date }: { r.Summary }");
}
*/

Console.WriteLine($"total postage for 32.5: { Postage(32.5) }");
Console.WriteLine($"total postage for 55.2: { Postage(55.2) }");
Console.WriteLine("");

C2 c2a = new("a", "b", "c");
C2 c2b = new("a", "b", "c");
Console.WriteLine($"C2a: { c2a }");
Console.WriteLine($"C2b: { c2b }");
Console.WriteLine($"C2a == C2b: { c2a == c2b }");
Console.WriteLine($"Equals(C2a, C2b): { Equals(c2a, c2b) }");
Console.WriteLine($"ReferenceEquals(C2a, C2b): { ReferenceEquals(c2a, c2b) }");
Console.WriteLine("");

R2 r2a = new("a", "b", "c");
R2 r2b = new("a", "b", "c");
Console.WriteLine($"R2a: { r2a }");
Console.WriteLine($"R2b: { r2b }");
Console.WriteLine($"R2a == R2b: { r2a == r2b }");
Console.WriteLine($"Equals(R2a, R2b): { Equals(r2a, r2b) }");
Console.WriteLine($"ReferenceEquals(R2a, R2b): { ReferenceEquals(r2a, r2b) }");
Console.ReadLine();

static double Postage(double price) => price switch
{
    < 20 => 2.99,
    >= 20 and < 40 => 3.99,
    _ => 4.99
};

public class C1
{
    public string A { get; init; }
    public string B { get; init; }

    public C1 () { }

    public C1 (string a, string b)
    {
        A = a;
        B = b;
    }
}

public class C2 : C1
{
    string C { get; init; }

    public C2 (string a, string b, string c) : base(a, b)
    {
        C = c;
    }

    public override string ToString()
    {
        return $"C2 {{ a = {base.A}, b = {base.B}, c = {C} }}";
    }
}

record R1(string a, string b);
record R2(string a, string b, string c) : R1(a, b);

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
