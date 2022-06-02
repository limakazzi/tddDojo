using NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Assert.Throws<ArgumentException>(() => poker.PokerHand(cardsInHand));
        }
    }
}
