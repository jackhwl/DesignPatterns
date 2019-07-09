using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Common;
using Moq;

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

		        [TestMethod]
        public void TryAddCircle_CircleEntirelyInsideFrame_ReturnsTrue()
        {
            AssertTryAddCircleResult(1.5M, 1.5M, true);
        }

        [TestMethod]
        public void TryAddCircle_CircleTouchesLeftEdge_ReturnsTrue()
        {
            AssertTryAddCircleResult(1.0M, 1.5M, true);
        }

        [TestMethod]
        public void TryAddCircle_CircleTouchesTopEdge_ReturnsTrue()
        {
            AssertTryAddCircleResult(1.5M, 1.0M, true);
        }

        [TestMethod]
        public void TryAddCircle_CircleTouchesRightEdge_ReturnsTrue()
        {
            AssertTryAddCircleResult(2.0M, 1.5M, true);
        }

        [TestMethod]
        public void TryAddCircle_CircleTouchesBottomEdge_ReturnsTrue()
        {
            AssertTryAddCircleResult(1.5M, 2.0M, true);
        }

        [TestMethod]
        public void TryAddCircle_CircleCrossesLeftEdge_ReturnsFalse()
        {
            AssertTryAddCircleResult(0.7M, 1.5M, false);
        }

        [TestMethod]
        public void TryAddCircle_CircleCrossesTopEdge_ReturnsFalse()
        {
            AssertTryAddCircleResult(1.5M, 0.7M, false);
        }

        [TestMethod]
        public void TryAddCircle_CircleCrossesRightEdge_ReturnsFalse()
        {
            AssertTryAddCircleResult(2.3M, 1.5M, false);
        }

        [TestMethod]
        public void TryAddCircle_CircleCrossesBottomEdge_ReturnsFalse()
        {
            AssertTryAddCircleResult(1.5m, 2.3M, false);
        }

        [TestMethod]
        public void TryAddCircle_CircleCompletelyOutsideTheFrame_ReturnsFalse()
        {
            AssertTryAddCircleResult(5.4M, 6.1M, false);
        }
		private void AssertTryAddCircleResult(decimal x, decimal y, bool expectedResult)
        {
			Frame frame = new Frame();
			frame.Length = 3.0M;
			frame.Width = 3.0M;

			Mock<ICircle> circleMock = new Mock<ICircle>();
			circleMock.SetupGet(c => c.X).Returns(x);
			circleMock.SetupGet(c => c.Y).Returns(y);
			circleMock.SetupGet(c => c.Radius).Returns(1.0M);

			ICircle circle = circleMock.Object;

            bool result = frame.TryAddCircle(circle);
            Assert.AreEqual(expectedResult, result);
        }
	}
}
