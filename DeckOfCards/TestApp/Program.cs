namespace testapp;

class Program
{
    static void Main(string[] args)
    {

        int action;
        Deck deck = new Deck();
        
        do{
            Console.WriteLine("\nChoose action: ");
            Console.WriteLine("0 - Exit Game");
            Console.WriteLine("1 - Create Deck");
            Console.WriteLine("2 - Shuffle Deck");
            Console.WriteLine("3 - Deal");
            Console.WriteLine("4 - Display Deck\n");

            action = Convert.ToInt16(Console.ReadLine());

            switch(action)
            {
                case 0:
                    Console.WriteLine("\nGame Ended!\n");
                    break;
                case 1:
                    if(deck.Cards.Count == 0)
                    {
                        Console.WriteLine("\nCreating Deck\n");
                        deck.createDeck();
                    }else{
                        Console.WriteLine("There is an existing deck.");
                    }
                    break;
                case 2:
                    if(deck.Cards.Count > 1)
                    {
                        Console.WriteLine("\nShuffling Deck\n");
                        deck.shuffleDeck();
                    }else if(deck.Cards.Count == 1)
                    {
                        Console.WriteLine("Only 1 card in deck!");
                    }else{
                        Console.WriteLine("No existing deck");
                    }
                    break;
                case 3:
                    deck.Deal();
                    break;
                case 4:
                    Console.WriteLine("\nDisplaying deck:\n");
                    deck.displayDeck();
                    Console.WriteLine("Deck card count: " + deck.count);
                    break;
                default:
                    Console.WriteLine("\nChoose a valid number.\n");
                    break;
            }
            
        }while(action != 0);

    }
}
