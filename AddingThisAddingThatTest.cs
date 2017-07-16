using NUnit.Framework;
using System;
using System.Linq;

namespace SpencerStuart
{
    [TestFixture()]
    public class AddingThisAddingThatTest
	{

		[Test()]
		public void TestThreeSameNumbers()
		{
			AddingThisAddingThat atat = new AddingThisAddingThat();
			Assert.AreEqual(new byte[] { 2, 2, 2 }, atat.AddRecursive(new byte[] { 1, 1, 1 }, new byte[] { 1, 1, 1 }));
		}

		[Test()]
		public void TestCarryOver()
		{
			AddingThisAddingThat atat = new AddingThisAddingThat();
			Assert.AreEqual(new byte[] { 1, 2, 0 }, atat.AddRecursive(new byte[] { 1, 1, 255 }, new byte[] { 0, 0, 1 }));
		}

		[Test()]
		public void TestCarryOverOnAllBytes()
		{
			AddingThisAddingThat atat = new AddingThisAddingThat();
			Assert.AreEqual(new byte[] { 255, 255, 254 }, atat.AddRecursive(new byte[] { 255, 255, 255 }, new byte[] { 255, 255, 255 }));
		}

		[Test()]
		public void TestDifferentBytes()
		{
			AddingThisAddingThat atat = new AddingThisAddingThat();
			Assert.AreEqual(new byte[] { 7, 4, 2, 1 }, atat.AddRecursive(new byte[] {3,2,1,0}, new byte[] { 4,2,1, 1}));
		}
    }
}
