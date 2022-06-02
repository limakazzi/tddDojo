using NUnit.Framework;
using System;

namespace tddDojo.UnitTests
{
    [TestFixture]
    public class PokerTests
    {
        [Test]
        public void PokerHand_WhenCardsInHandCountIsNotFive_ShouldThrowArgumentException()
        {
            var poker = new Poker();
            var cardsInHand = new[] { 1, 2, 5 };

            Assert.Throws<ArgumentException>(() => poker.PokerHand(cardsInHand));
        }

        [Test]
        public void PokerHand_WhenCardsInHandHaveTooBigValue_ShouldThrowArgumentException()
        {
            var poker = new Poker();
            var cardsInHand = new[] { 2, 4, 5, 9, 1 };
            Assert.Throws<ArgumentException>(() => poker.PokerHand(cardsInHand));
        }
        [Test]
        public void PokerHand_WhenCardsInHandHaveTooLowValue_ShouldThrowArgumentException()
        {
            var poker = new Poker();
            var cardsInHand = new[] { 2, 0, 5, 3, 1 };
            Assert.Throws<ArgumentException>(() => poker.PokerHand(cardsInHand));
        }
    }
}

