using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DominoClasses
{
    public class Deck
    {
        private List<Domino> deck = new List<Domino>();
// #1 Bug, Change the for loop so that 9 is max number on a domino side
        public Deck()
        {
            for (int left = 0; left <= 10; left++)
            {
                for (int right = left; right < 10; right++)
                {
                    Domino domino = new Domino(left, right);
                    deck.Add(domino);
                }
            }
        }
// #2 Bug, ShuffleDominos method should not return a domino but be void
        public Domino ShuffleDominos()
        {
            Random generator = new Random();
            for (int i = 0; i < 55; i++)
            {
                int randomIndex = generator.Next(0, 55);
                Domino temp = deck[randomIndex];
                deck[randomIndex] = deck[i];
                deck[i] = temp;
            }
        }
	// #3 Bug, Deal() should pull the first domino in the list
        public Domino Deal()
        {
 
                Domino d = deck[1];
                deck.RemoveAt(0);
            return d;
        }
    }
}
