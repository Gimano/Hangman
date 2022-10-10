using Hangman;

bool game= true;
while (game)
{
    //Console.Clear();
    Console.WriteLine("Välkommen till Hangman");
    Console.WriteLine("1. Spela\n2. Avsluta");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Guess.RunGame();
            break;
        case 2:
            game = false;
            break;
        default:
            break;
    }
}