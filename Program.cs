using System.Collections;

int hero = 10;
int monster = 10;

Random dice = new Random();
do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} and now has {monster} health.");
    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} and now has {hero} health.");
} while (hero > 0 && monster > 0);
Console.WriteLine(hero > monster ? "Hero wins!" : " Monster wins!");
        