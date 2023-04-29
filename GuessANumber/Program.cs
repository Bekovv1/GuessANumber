Random Number = new Random();

int PCNumber = Number.Next(1, 101);

while (true)
{
    Console.WriteLine("Guess a number(1 - 100):");
    string input = Console.ReadLine();
    
    bool isValid = int.TryParse(input, out int playerNum);
    
    if (isValid)
    {
        
        if (playerNum == PCNumber)
        {
            Console.WriteLine("You guessed it!");
            break;

        }
        
        else if (playerNum > PCNumber)
        
        {
            Console.WriteLine("Too High");
        }
        
        else
        
        {
            Console.WriteLine("Too Low");
        
        }


    }
    
    else
    {
        Console.WriteLine("Invalid input");
    }
}