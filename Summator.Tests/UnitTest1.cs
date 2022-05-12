using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]
        public void TestSumTwoPositiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5, 8 });
            //Assert.That(result==13);
            Assert.AreEqual(13, result);
        }

        [Test]
        public void TestSumOnePositiveNumber()
        {
            int result = Summator.Sum(new int[] { 10 });
            Assert.That(result == 10);
        }

        [Test]
        public void TestSumTwoNegativeNumbers()
        {
            int result = Summator.Sum(new int[] { -5, -8 });
            Assert.AreEqual(-13, result);
        }

        [Test]
        public void TestSumEmpty()
        {
            int result = Summator.Sum(new int[] { });
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestSumBigNums()
        {
            int result = Summator.Sum(new int[] { 20000000, 1000000000, 1000000000 });
            Assert.AreEqual(2020000000, result);
        }

        [Test]
        public void TestAvgTwoPositiveNumbers()
        {
            int result = Summator.Average(new int[] { 5, 10, 15 });
            Assert.AreEqual(10, result);
        }
    }
}