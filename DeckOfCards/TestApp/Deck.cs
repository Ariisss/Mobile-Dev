namespace testapp;

public class Deck
{

    public List<Card> Cards = new List<Card>();
    private static Random rng = new Random();

    public int count = 0;

    public List<Card> createDeck()
    {

        int rndx;
        foreach(Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
        {
            for(rndx = 0; rndx < 13; rndx++)
            {
                Cards.Add(new Card(suit, rndx));
            }
            
        }
        this.count = Cards.Count();

        return Cards;
    }

    public void displayDeck()
    {
        foreach(Card card in Cards)
        {
            Console.WriteLine($"{card}");
        }
    }

    public void shuffleDeck()
    {
        int n = Cards.Count();
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            (Cards[n], Cards[k]) = (Cards[k], Cards[n]);
        }
    }

    public void Deal()
    {
        Console.WriteLine("How many?");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num > count){
            Console.WriteLine("Not enough cards in deck.");
            return;
        }

        while (num != 0)
        {
            int ran = rng.Next(Cards.Count());
            Card temp = Cards[ran];
            if(temp != null)
            {
                Console.WriteLine($"{temp}");
                Cards.Remove(temp);
            }
            num--;
        }

        this.count = Cards.Count();
    }

}