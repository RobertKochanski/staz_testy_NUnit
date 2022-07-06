using Prime;

namespace TestProject1
{
    [TestFixture]
    public class PrimeService_IsPrime
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [TestCase(1)]
        [TestCase(4)]
        [TestCase(6)]
        public void IsPrimeFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        public void IsPrimeTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsTrue(result, $"{value} should be prime");
        }
    }
}