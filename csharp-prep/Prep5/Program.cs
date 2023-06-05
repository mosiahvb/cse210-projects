using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeWessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResults(userName, squaredNumber);
    }

    static void DisplayWelcomeWessage()
    {
        Console.WriteLine("welcome to the Program!");
    } 

    static string PromptUserName()
    {
        Console.Write("please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");
    }

    
}