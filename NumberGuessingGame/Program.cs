//using System;
bool playAgain = true;
while (playAgain)
{
    Console.Clear();
    Console.WriteLine("=================================");
    Console.WriteLine("      NUMBER GUESSING GAME");
    Console.WriteLine("=================================");
    Console.WriteLine("Select Difficulty");
    Console.WriteLine("1. Easy (1 - 50)      10 Attempts");
    Console.WriteLine("2. Medium (1 - 100)    7 Attempts");
    Console.WriteLine("3. Hard (1 - 200)      5 Attempts");
    Console.Write("\nEnter Choice : ");
    if (!int.TryParse(Console.ReadLine(), out int level))
    {
        Console.WriteLine("Invalid Choice");
        Pause();
        continue;
    }
    int maxNumber = 50;
    int attempts = 10;
    switch (level)
    {
        case 1:
            maxNumber = 50;
            attempts = 10;
            break;
        case 2:
            maxNumber = 100;
            attempts = 7;
            break;
        case 3:
            maxNumber = 200;
            attempts = 5;
            break;
        default:
            Console.WriteLine("Invalid Choice");
            Pause();
            continue;
    }
    Random random = new Random();
    int secretNumber = random.Next(1, maxNumber + 1);
    bool guessed = false;
    Console.Clear();
    Console.WriteLine($"Guess the number between 1 and {maxNumber}");
    for (int i = 1; i <= attempts; i++)
    {
        Console.Write($"\nAttempt {i}/{attempts} : ");
        if (!int.TryParse(Console.ReadLine(), out int guess))
        {
            Console.WriteLine("Please enter a valid number.");
            i--;
            continue;
        }
        if (guess == secretNumber)
        {
            guessed = true;
            int score = (attempts - i + 1) * 10;
            Console.WriteLine("\nCongratulations!");
            Console.WriteLine($"You guessed the correct number : {secretNumber}");
            Console.WriteLine($"Your Score : {score}");
            break;
        }
        if (guess < secretNumber)
        {
            Console.WriteLine("Too Low");
        }
        else
        {
            Console.WriteLine("Too High");
        }
        Console.WriteLine($"Attempts Left : {attempts - i}");
    }
    if (!guessed)
    {
        Console.WriteLine("\nGame Over!");
        Console.WriteLine($"Correct Number was : {secretNumber}");
    }
    Console.Write("\nDo you want to play again? (Y/N) : ");
    string answer = Console.ReadLine()!.ToUpper();
    playAgain = answer == "Y";
}
Console.WriteLine("\nThanks for Playing!");
void Pause()
{
    Console.WriteLine("\nPress Enter To Continue...");
    Console.ReadLine();
}