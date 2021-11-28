using MinSumNumberArray;
using NUnit.Framework;

namespace TestMinSumArray
{

    public class TestOwnImplementation : TestBase
    {

        [SetUp]
        public void Setup()
        {
            MathOperation = new OwnImplementationMathOperation();
        }

        [Test]
        public void TestSumMinNumbersForNull()
        {
            int[] nullArray = null;

            var test = MathOperation.GetSumMinNumbers(nullArray, 2);

            Assert.IsFalse(test.IsTrue);
            Assert.AreEqual("mas_is_null", test.Error);
        }

        [Test]
        public void TestSumMinNumbersForLengthZero()
        {
            int[] zeroLengthArray = { };

            var test = MathOperation.GetSumMinNumbers(zeroLengthArray, 2);

            Assert.IsFalse(test.IsTrue);
            Assert.AreEqual("mas_length_zero", test.Error);
        }
        [Test]
        public void TestSumMunNumbersCountDigitSumMoreLengthMas()
        {
            int[] zeroLengthArray = new int[1];

            var test = MathOperation.GetSumMinNumbers(zeroLengthArray, 2);

            Assert.IsFalse(test.IsTrue);
            Assert.AreEqual("count_digit_sum_many_mas_length", test.Error);
        }

        [Test]
        public void TestInTaskSumMinNumbers()
        {
            int[] mas = { 4, 0, 3, 19, 492, -10, 1 };

            int expected = -10;

            var test = MathOperation.GetSumMinNumbers(mas, 2);

            Assert.IsTrue(test.IsTrue);
            Assert.AreEqual(expected, test.Information);
        }

        [Test]
        public void TestZeroValuesSumMinNumbers()
        {
            int[] mas = new int[1000];

            int expected = 0;

            var test = MathOperation.GetSumMinNumbers(mas, 2);

            Assert.IsTrue(test.IsTrue);
            Assert.AreEqual(expected, test.Information);
        }

        [Test]
        public void TestSameValuesSumMinNumbers()
        {
            int[] mas = { -36, 200, 43, 3, 5, 0, -35, 12 - 3, 1, 5, 6, 7, 123, -36, -26, -2, 11, 35 };

            int expected = -72;

            var test = MathOperation.GetSumMinNumbers(mas, 2);

            Assert.IsTrue(test.IsTrue);
            Assert.AreEqual(expected, test.Information);
        }
        [Test]
        public void TestNegativeNumberSumMinNumbers()
        {
            int[] mas = { -36, -5, -123, -1000, -23, -1, -632, -643, -31, -42, -1456, -491, -913, -825, -32, -51, -75, -74, -1001, -234 };

            int expected = -2457;

            var test = MathOperation.GetSumMinNumbers(mas, 2);

            Assert.IsTrue(test.IsTrue);
            Assert.AreEqual(expected, test.Information);
        }
        [Test]
        public void TestPositiveNumber()
        {
            int[] mas = { 256, 3, 76, 72, 11, 123, 421, 987, 574, 23, 44, 99, 41, 99, 261, 876, 214, 992, 31, 87 };

            int expected = 14;

            var test = MathOperation.GetSumMinNumbers(mas, 2);

            Assert.IsTrue(test.IsTrue);
            Assert.AreEqual(expected, test.Information);
        }
    }
}