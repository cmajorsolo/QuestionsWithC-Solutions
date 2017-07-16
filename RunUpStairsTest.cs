using NUnit.Framework;
using System;

namespace SpencerStuart
{
    [TestFixture()]
    public class RunUpStairsTest
    {
        [Test()]
        public void TestStaircaseNumbersWithOneFlight()
        {
            RunUpStairs rus = new RunUpStairs();
            Assert.AreEqual(8, rus.CalculateStrides(new int[] {15}, 2));
		}

		[Test()]
		public void TestStaircaseNumbersWithTwoFlights()
		{
			RunUpStairs rus = new RunUpStairs();
			Assert.AreEqual(18, rus.CalculateStrides(new int[] { 15, 15 }, 2));
		}

		[Test()]
		public void TestStaircaseNumbersWithMoreThanTwoFlights()
		{
			RunUpStairs rus = new RunUpStairs();
			Assert.AreEqual(44, rus.CalculateStrides(new int[] { 5, 11, 9, 13, 8, 30, 14 }, 3));
		}

        [Test()]
        public void TestStaireSize0Exception()
		{
			RunUpStairs rus = new RunUpStairs();
            var exception = Assert.Throws<ArgumentException>(() => rus.CalculateStrides(new int[] { }, 2));
            Assert.AreEqual(exception.Message, "The staircase has between 1 and 50 flights of stairs");
		}

        [Test()]
        public void TestStaireSize51Exception()
		{
			RunUpStairs rus = new RunUpStairs();
			var exception = Assert.Throws<ArgumentException>(() => rus.CalculateStrides(new int[] { 1,2,3,4,5,6,7,8,9,10,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}, 2));
			Assert.AreEqual(exception.Message, "The staircase has between 1 and 50 flights of stairs");
		}

		[Test()]
		public void TestFlightSizeSmallerThan5Exception()
		{
			RunUpStairs rus = new RunUpStairs();
			var exception = Assert.Throws<ArgumentException>(() => rus.CalculateStrides(new int[] {4,5}, 2));
			Assert.AreEqual(exception.Message, "The flight of stairs has between 5 and 30 steps");
		}

		[Test()]
		public void TestFlightSizeBiggerThan30Exception()
		{
			RunUpStairs rus = new RunUpStairs();
			var exception = Assert.Throws<ArgumentException>(() => rus.CalculateStrides(new int[] { 31, 5 }, 2));
			Assert.AreEqual(exception.Message, "The flight of stairs has between 5 and 30 steps");
		}

		[Test()]
		public void TestStepsPerStrideSmallerThan2Exception()
		{
			RunUpStairs rus = new RunUpStairs();
			var exception = Assert.Throws<ArgumentException>(() => rus.CalculateStrides(new int[] { 4, 5 }, 1));
			Assert.AreEqual(exception.Message, "The steps per stride has between 2 and 5");
		}

		[Test()]
		public void TestStepsPerStrideBiggerThan5Exception()
		{
			RunUpStairs rus = new RunUpStairs();
			var exception = Assert.Throws<ArgumentException>(() => rus.CalculateStrides(new int[] { 4, 5 }, 6));
			Assert.AreEqual(exception.Message, "The steps per stride has between 2 and 5");
		}
    }
}
