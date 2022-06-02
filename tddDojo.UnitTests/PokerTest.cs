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
    }
}
