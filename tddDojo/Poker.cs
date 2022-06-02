using System;

namespace tddDojo
{
    public class Poker
    {
        public string PokerHand(int[] cardsInHand)
        {
            if (!CheckIfCardsInHandAreInValidFormat(cardsInHand))
            {
                throw new ArgumentException();
            }


            return string.Empty;
        }

        private bool CheckIfCardsInHandAreInValidFormat(int[] cardsInHand)
        {
            int cardCount = cardsInHand.Length;
            if (cardCount != 5)
            {
                return false;
            }
            else return true;
        }
    }
}
