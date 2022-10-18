//Pedro Castaneda
//10-18-2022
//Odd Or Even
//Create a program that will check if users number is odd or even

bool run = true;

while(run)
{
    int validNum = 0;
    bool checkNum = false;

    Console.WriteLine("Welcome to Odd or Even!");
    Console.WriteLine("Enter a number:");
    while(!checkNum)
    {
        checkNum = Int32.TryParse(Console.ReadLine(), out validNum);
        if(checkNum == false)
        {
            Console.WriteLine("Please enter a number!");
        }
        else if(validNum % 2 == 0)
        {
            Console.WriteLine("Your number is even!");
        }
        else
        {
            Console.WriteLine("Your number is odd!");
        }
    }

    PlayAgain();
}

void PlayAgain()
{
    bool replay = true;
    while(replay)
    {
        Console.WriteLine("Would you like to play again? (yes/no)");
        string userInput = Console.ReadLine();
        if(userInput == "yes" || userInput == "y")
        {
            replay = false;
            run = true;
        }
        else if(userInput == "no" || userInput == "n")
        {
            replay = false;
            run = false;
        }
        else
        {
            Console.WriteLine("Please enter yes or no!");
        }
    }
}