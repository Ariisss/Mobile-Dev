using System.Diagnostics.Contracts;

namespace testapp;

public class Card{

    public string[] ranks = ["Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"];
    public enum Suit
    {
        Hearts,
        Spade,
        Clubs,
        Diamond
    }

    public Suit suit{get; set;}
    public int rank{get; set;}



    public Card(Suit suit, int rank)
    {
        this.suit = suit;
        this.rank = rank;
    }

    public override string ToString()
    {
        return "Suit: " + this.suit + "\tRank: " + ranks[this.rank];
    }

}