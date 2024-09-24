
//                             l    r    p    s    v
//int[] numbers = new int[5] {108, 114, 112, 115, 118};



// MODIFICATION : NOW THE GAME IS UP TO THREE VICTORIES


Random random = new Random();
Console.WriteLine("Enter your username:");
string username = Console.ReadLine();
Console.WriteLine($"Greetings {username}! The game is called 'Rock - Paper - Scissors' and it's typically played between two players." +
    $"\nThe rules are pretty simple - each player chooses one of three possible moves: rock, paper or scissors" +
    $"\n" +
    $"\nRock beats Scissors." +
    $"\nScissors beat Paper." +
    $"\nPaper beats Rock.");
Console.WriteLine();


Console.WriteLine("Write down your choise: ROCK, PAPER or SCISSORS");
string playersPick = Console.ReadLine();
int playerWins = 0;
int computerWins = 0;

while (true)
{
    int[] numbersArray = new int[3] { 114, 112, 115 };
    int randomIndex = random.Next(0, numbersArray.Length);
    int randomNumber = numbersArray[randomIndex];
    char symbol = (char)randomNumber;

    string computersPick = "";
    switch (symbol)
    {
        case 'r': computersPick = "ROCK"; break;
        case 'p': computersPick = "PAPER"; break;
        case 's': computersPick = "SCISSORS"; break;

    }

    if (playersPick == computersPick)
    {
        Console.WriteLine();
        Console.WriteLine($"We've both picked: {computersPick}. This game is draw");
    }
    else if (playersPick == "ROCK" && computersPick == "SCISSORS")
    {
        playerWins++;
        Console.WriteLine();
        Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
        Console.WriteLine("You've won!");
        if (playerWins == 3)
        {
            Console.WriteLine("You've won 3/3");
            break;
        }
    }
    else if (playersPick == "ROCK" && computersPick == "PAPER")
    {
        computerWins++;
        Console.WriteLine();
        Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
        Console.WriteLine("You've lost!");
        if (computerWins == 3)
        {
            Console.WriteLine("I've won 3/3");
            break;
        }
    }
    else if (playersPick == "SCISSORS" && computersPick == "PAPER")
    {
        playerWins++;
        Console.WriteLine();
        Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
        Console.WriteLine("You've won!");
        if (playerWins == 3)
        {
            Console.WriteLine("You've won 3/3");
            break;
        }
    }
    else if (playersPick == "SCISSORS" && computersPick == "ROCK")
    {
        computerWins++;
        Console.WriteLine();
        Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
        Console.WriteLine("You've lost!");
        if (computerWins == 3)
        {
            Console.WriteLine("I've won 3/3");
            break;
        }
    }
    else if (playersPick == "PAPER" && computersPick == "ROCK")
    {
        playerWins++;
        Console.WriteLine();
        Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
        Console.WriteLine("You've won!");
        if (playerWins == 3)
        {
            Console.WriteLine("You've won 3/3");
            break;
        }
    }
    else if (playersPick == "PAPER" && computersPick == "SCISSORS")
    {
        computerWins++;
        Console.WriteLine();
        Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
        Console.WriteLine("You've lost!");
        if (computerWins == 3)
        {
            Console.WriteLine("I've won 3/3");
            break;
        }
    }
    playersPick = Console.ReadLine();
}
