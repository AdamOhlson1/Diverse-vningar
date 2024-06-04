// See https://aka.ms/new-console-template for more information
/*
int sum = 0; 

for (int i = 1; i < 1000; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        sum += i; 
    }
}

Console.WriteLine(sum);
*/

// Simple Calculator
/* using System.Formats.Asn1;

Console.WriteLine("Choose any number:\n");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose another number:\n");
double num2 = Convert.ToDouble(Console.ReadLine());

double sum = Math.Round(num1 + num2);
double diff = Math.Round(num1 - num2);
double product = Math.Round(num1 * num2);
double div = Math.Round(num1 / num2); 
double pow = Math.Round(Math.Pow(num1, num2));

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {diff}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Divsion: {div}");
Console.WriteLine($"Power to: {pow}");
*/

// Fibonacci Sequence 
int n = 50; 
long a = 1, b = 1;
int sum = 0; 

for (int i = 1; i <= n; i++)
{
        Console.WriteLine(a);
            long temp = a + b;
            a = b;
            b = temp;
// Få ut summan av alla jämna tal under 4 miljoner?
        if (i % 2 == 0 || a <= 4000000)
        {
            sum += i; 
        }
} 
Console.WriteLine(sum);


