using System;

namespace tddDojo
{
    public class Poker
    {
        private const int CorrectNumberOfCards = 5;

        public string PokerHand(int[] cardsInHand)
        {
            if (!IsCardsInHandCountIsCorrect(cardsInHand))
                throw new ArgumentException();

            return string.Empty;
        }

        private bool IsCardsInHandCountIsCorrect(int[] cardsInHand)
        {
            if (cardsInHand.Length != CorrectNumberOfCards)
                return false;
            else return true;
        }
    }
}
