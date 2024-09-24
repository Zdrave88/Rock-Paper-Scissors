
//                             l    r    p    s    v
//int[] numbers = new int[5] {108, 114, 112, 115, 118};


Random random = new Random();
Console.WriteLine("Enter your username:");
string username = Console.ReadLine();
Console.WriteLine($"Greetings {username}! The game is called 'Rock - Paper - Scissors' and it's typically played between two players." +
    $"\nThe rules are pretty simple - each player chooses one of three possible moves: rock, paper or scissors" +
    $"\n"+
    $"\nRock beats Scissors." +
    $"\nScissors beat Paper." +
    $"\nPaper beats Rock.");
Console.WriteLine();


//                                 r    p     s
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
Console.WriteLine("Write down your choise: ROCK, PAPER or SCISSORS");
string playersPick = Console.ReadLine();


if (playersPick == computersPick)
{
    Console.WriteLine();
    Console.WriteLine($"We've both picked: {computersPick}. This game is draw");
}
else if (playersPick == "ROCK" && computersPick == "SCISSORS")
{
    Console.WriteLine();
    Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
    Console.WriteLine("You've won!");
}
else if (playersPick == "ROCK" && computersPick == "PAPER")
{
    Console.WriteLine();
    Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
    Console.WriteLine("You've lost!");
}
else if (playersPick == "SCISSORS" && computersPick == "PAPER")
{
    Console.WriteLine();
    Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
    Console.WriteLine("You've won!");
}
else if (playersPick == "SCISSORS" && computersPick == "ROCK")
{
    Console.WriteLine();
    Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
    Console.WriteLine("You've lost!");
}
else if (playersPick == "PAPER" && computersPick == "ROCK")
{
    Console.WriteLine();
    Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
    Console.WriteLine("You've won!");
}
else if (playersPick == "PAPER" && computersPick == "SCISSORS")
{
    Console.WriteLine();
    Console.WriteLine($"You've picked: {playersPick}! I've picked: {computersPick}");
    Console.WriteLine("You've lost!");
}
