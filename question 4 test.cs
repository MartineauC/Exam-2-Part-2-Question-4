using System;

public class Program
{
    public static void Main()
    {
        Hand hand = new Hand();
        hand.AddCard(new Card { Suit = "Spades", Rank = "Ace", Value = 1 });
        hand.AddCard(new Card { Suit = "Diamonds", Rank = "Queen", Value = 10 });
        hand.AddCard(new Card { Suit = "Hearts", Rank = "2", Value = 2 });

        foreach (Card card in hand)
        {
            Console.WriteLine($"Suit: {card.Suit}, Rank: {card.Rank}, Value: {card.Value}");
        }
    }
}