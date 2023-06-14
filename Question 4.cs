using System;
using System.Collections;
using System.Collections.Generic;

public class Hand : IEnumerable<Card>
{
    protected List<Card> cards;

    public Hand()
    {
        cards = new List<Card>();
    }

    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    public void Clear()
    {
        cards.Clear();
    }

    public int GetScore()
    {
        int score = 0;
        bool hasAce = false;

        foreach (Card card in cards)
        {
            score += card.Value;
            if (card.Rank == "Ace")
            {
                hasAce = true;
            }
        }

        if (hasAce && score + 10 <= 21)
        {
            score += 10;
        }

        return score;
    }

    public IEnumerator<Card> GetEnumerator()
    {
        return cards.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
