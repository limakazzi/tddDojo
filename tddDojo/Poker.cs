using System;
using System.Linq;

namespace tddDojo
{
    public class Poker
    {
        private const int CorrectNumberOfCards = 5;
        private const int MinCardValue = 1;
        private const int MaxCardValue = 6;

        public string PokerHand(int[] cardsInHand)
        {
            if (!IsCardsInHandCountIsCorrect(cardsInHand) || !IsAnyCardInHandIsOutOfBounds(cardsInHand))
                throw new ArgumentException();

            return string.Empty;
        }

        private bool IsCardsInHandCountIsCorrect(int[] cardsInHand)
        {
            if (cardsInHand.Length != CorrectNumberOfCards)
                return false;
            else return true;
        }

        private bool IsAnyCardInHandIsOutOfBounds(int[] cardsInHand)
        {
            if (cardsInHand.Any(cardValue => cardValue < MinCardValue || cardValue > MaxCardValue))
                return false;
            else return true;
        }
    }
}
