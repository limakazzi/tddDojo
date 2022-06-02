using NUnit.Framework;

namespace tddDojo.Tests
{
    [TestFixture]
    public class PokerTests
    {
        [Test]
        public void PokerHand_WhenCardsInHandCountIsNotFive_ShouldThrowArgumentException()
        {
            var poker = new Poker();
            var cardsInHand = new[] { 1, 2, 5 };

            NUnit.Framework.Assert.Throws<ArgumentException>(() => poker.PokerHand(cardsInHand));
        }
    }
}
