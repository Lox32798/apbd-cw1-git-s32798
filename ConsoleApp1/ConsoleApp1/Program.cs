// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Press nothing to exit");

var a = 1;
var b = 2;
var c = a + b;
Console.WriteLine(c);;
Console.WriteLine("Feature1");
Console.WriteLine("Feature2");
Console.WriteLine("Niezalezny commit");

int CalculateMax(int[] values)
{
    return values.Max();
}

int[] val = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
Console.WriteLine(CalculateMax(val));