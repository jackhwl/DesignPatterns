using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Models.Tests
{
	[TestClass]
	public class Frame_UnitTests
	{
        private readonly decimal SmallestPositiveDecimal = 1e-28M;

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Length_ReceivesNegativeValue_Throws()
        {
            AssertLength(-3.5M);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Length_ReceivesZero_Throws()
        {
            AssertLength(0);
        }

        [TestMethod]
        public void Length_ReceivesSmallestPositiveValue_GetterReturnsSameValue()
        {
            AssertLength(SmallestPositiveDecimal);
        }

        [TestMethod]
        public void Length_ReceivesPositiveValue_GetterReturnsSameValue()
        {
            AssertLength(3.7M);
        }

        private void AssertLength(decimal value)
        {
            Frame frame = new Frame();
            frame.Length = value;
            Assert.AreEqual(value, frame.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Width_ReceivesNegativeValue_Throws()
        {
            AssertWidth(-3.3M);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Width_ReceivesZero_Throws()
        {
            AssertWidth(0);
        }

        [TestMethod]
        public void Width_ReceivesSmallestPositiveValue_GetterReturnsSameValue()
        {
            AssertWidth(SmallestPositiveDecimal);
        }

        [TestMethod]
        public void Width_ReceivesPositiveValue_GetterReturnsSameValue()
        {
            AssertWidth(3.1M);
        }

        private static void AssertWidth(decimal value)
        {
            Frame frame = new Frame();
            frame.Width = value;
            Assert.AreEqual(value, frame.Width);
        }
	}
}
