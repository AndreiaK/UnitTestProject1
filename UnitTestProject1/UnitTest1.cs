using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

		[TestMethod]
		public void FailingTest()
		{
			// Assert
			Assert.IsTrue(false);
		}
    }
}
