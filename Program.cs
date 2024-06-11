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
/*    int n = 50; 
    int m = 4000000; 

    long a = 1, b = 1;
    long sum = 0;


    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(a);
        if (a % 2 == 0 && a <= m)
        {
            sum += a;
        }

        long temp = a + b;
        a = b;
        b = temp;
    }

    while (a <= m)
    {
        if (a % 2 == 0)
        {
            sum += a;
        }

        long temp = a + b;
        a = b;
        b = temp;
    }

    Console.WriteLine(sum);
*/

// Palindrom 
/* string? input = "";

while (string.IsNullOrEmpty(input)) 
{
Console.WriteLine("Enter a word or sentence:\n ");
input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Invalid input");
}
}

if (IsPalindrom(input))
        {
            Console.WriteLine("The text is a palindrom.");
        }
        else
        {
            Console.WriteLine("The text is not a palindrom.");
        }
    

  static bool IsPalindrom(string text)
    {
        
        var rensadText = new string(text.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        
        var omvändText = new string(rensadText.Reverse().ToArray());

        return rensadText == omvändText;
    } */

// Räkna ut median, medelvärde
/*
int numPerson = 20; 
int maxAge = 100; 
int minAge = 1; 

Random rnd = new Random();
int[] ages = new int[numPerson];

for (int i = 0; i < numPerson; i++)
{
    ages[i] = rnd.Next(minAge, maxAge + 1);
}

foreach (int age in ages)
{
    Console.WriteLine(age);
}

int sum = 0; 

foreach (int a in ages) 
{
    sum += a; 
}

double average = Math.Round((double)sum / ages.Length);

Console.WriteLine("Average is: " + average);

Array.Sort(ages);

double median;
int n = ages.Length;

if (n % 2 == 0)
{
    int middle1 = n / 2 - 1;
    int middle2 = n/ 2; 
    median = (ages[middle1] + ages[middle2]) / 2.0;
}
else 
{
    int middle = n / 2;
    median = ages[middle];
}

Console.WriteLine("Median is: "+ median); */

// Sortera strängar 
/*using System.Linq;

string[] pets = { "Dog", "Cat", "Parrot", "Ginuea Pig", "Hamster", "Turtle", "Fish", "Horse", "Crab" };


var sortedPets = pets.OrderBy(p => p.Length).ThenBy(p => p);

var reversedSortedPets = sortedPets.Reverse();


foreach (var pet in reversedSortedPets)
{
    Console.WriteLine(pet);
}*/

// Sortera strängar 2
/*using System.Linq;

string[] footballPlayers = {"Lionel Messi", "Cristiano Ronaldo", "Neymar Jr.", "Kylian Mbappé", 
"Robert Lewandowski", "Kevin De Bruyne", "Virgil van Dijk", "Mohamed Salah", "Harry Kane", 
"Eden Hazard", "Luka Modrić", "Sergio Ramos", "NGolo Kanté", "Karim Benzema", "Manuel Neuer", 
"Antoine Griezmann", "Romelu Lukaku", "Paulo Dybala", "Gianluigi Buffon", "Zlatan Ibrahimović", 
"Erling Haaland", "Jadon Sancho", "Trent Alexander-Arnold", "Sadio Mané", "Raheem Sterling" };

var sortedPlayers = footballPlayers.OrderBy(f => f);

foreach (var players in sortedPlayers)
{
    Console.WriteLine(players);
}*/

// BlackJack 
/*
static List<int> deck = new List<int>();
static int balance = 100;

Console.WriteLine("Hello welcome to Black Jack \nYour balance is " + balance + "kr");

Console.WriteLine("How much do you want to bet?\n");
int bet = Convert.ToInt32(Console.ReadLine());

while (bet > balance || bet == 0 || bet < 0)
            {
                if (bet > balance)
                {
                    Console.WriteLine("You cannot bet more than your balance. Enter a valid bet: ");
                }
                else
                {
                    Console.WriteLine("You cannot bet zero or below. Enter another bet: ");
                }

                bet = Convert.ToInt32(Console.ReadLine());
            }
BlackJack();



static void BlackJack()
{
    Console.WriteLine("Shuffeling cards...");
    Thread.Sleep(5000);

} */

