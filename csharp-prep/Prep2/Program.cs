using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("what Percent did you get in the class?");
       string answer = Console.ReadLine();
       int precent = int.Parse(answer);

       string letter = "";

       if (precent >= 90)
       {
        letter = "A";
       }
        else if (precent >= 80)
        {
            letter = "B";
        }
        else if (precent >= 70)
        {
            letter = "C";
        }
        else if (precent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"your grade is {letter}");

        if (precent >= 70)
        {
            Console.WriteLine("you passed");
        }
        else
        {
            Console.WriteLine("better luck next time");
        }


       
    }
}