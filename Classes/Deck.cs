using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Deck
    {
        List<Card> cardDeck = new List<Card>();
        Card card;
        Random rand = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// instantiates 52 Card classes and adds them to a list on construction.
        /// </summary>
        public Deck()
        {
            for (int curCard = 0; curCard < 52; curCard++)
            {
                card = new Card(valuePicker(curCard), suitPicker(curCard));
                cardDeck.Add(card); 
            }
        }

        /// <summary>
        /// Picks a string from the array based on the modulus value of the current loop iteration with the number 13 and returns it.
        /// </summary>
        private string valuePicker(int curCard)
        {
            int value = curCard % 13;
            string[] valueS = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            return valueS[value];
        }

        /// <summary>
        /// Picks a string from the array based on the division value of the current loop iteration with the number 13 and returns it.
        /// </summary>
        private string suitPicker(int curCard)
        {
            int suit = curCard / 13;
            string[] suitS = { "Clubs", "Spades", "Diamonds", "Hearts" };
            return suitS[suit];
        }

        /// <summary>
        /// Picks a random card from the list using the Random variable we created and limits the value of this variable to between 0 and the highest value of the list
        /// Each time a card is picked the card is removed from the list to stop being picked again, when the list runs out of members, it throws an exception which is caught
        /// And tells the user that there is no more cards.
        /// </summary>
        public string cardPicker()
        {
            Card curCard;
            int high = cardDeck.Count;
            int randPicked = rand.Next(0, high);

            try
            {
                curCard = cardDeck[randPicked];
            }
            catch (Exception)
            {
                return "The deck has ran out of cards!";
            }

            cardDeck.RemoveAt(randPicked);
            return curCard.DescriptiveText;
        }
    }
}
