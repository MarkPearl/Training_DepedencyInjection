using NUnit.Framework;

namespace DependencyInjection
{
    [TestFixture]
    public class LottoWinnerGenertorTests
    {
        [Test]
        public void DisplayMarkWhenNumberGreaterThanFifty()
        {
            var numberGenerator = new NumberGeneratorTestDouble(51);
            var sut = new LottoWinnerGenerator(numberGenerator);
            Assert.That(sut.DisplayWinningNumber(), Is.EqualTo("Mark"));
        }

        [Test]
        public void DisplayBobWhenNumberEqualOfLessThanFifty()
        {
            var numberGenerator = new NumberGeneratorTestDouble(49);
            var sut = new LottoWinnerGenerator(numberGenerator);
            Assert.That(sut.DisplayWinningNumber(), Is.EqualTo("Bob"));
        }
    }

    public class NumberGeneratorTestDouble: INumberGenerator
    {
        private readonly int _overrideNumber;

        public NumberGeneratorTestDouble(int overrideNumber)
        {
            _overrideNumber = overrideNumber;
        }

        public int Generate()
        {
            return _overrideNumber;
        }
    }
}