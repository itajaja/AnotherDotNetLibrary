using Adnl.Windows.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Threading;

namespace UnitTesting
{
    
    
    /// <summary>
    ///This is a test class for DispatcherTimeoutTest and is intended
    ///to contain all DispatcherTimeoutTest Unit Tests
    ///</summary>
    [TestClass]
    public class DispatcherTimeoutTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Timeout
        ///</summary>
        [TestMethod]
        public void TimeoutTest()
        {
            var priority = new DispatcherPriority(); // TODO: Initialize to an appropriate value
            var duration = new TimeSpan(); // TODO: Initialize to an appropriate value
            Action<DispatcherTimeout> callback = null; // TODO: Initialize to an appropriate value
            DispatcherTimeout expected = null; // TODO: Initialize to an appropriate value
            DispatcherTimeout actual;
            actual = DispatcherTimeout.Timeout(priority, duration, callback);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Callback
        ///</summary>
        [TestMethod]
        public void CallbackTest()
        {
            // Creation of the private accessor for 'Microsoft.VisualStudio.TestTools.TypesAndSymbols.Assembly' failed
            Assert.Inconclusive("Creation of the private accessor for \'Microsoft.VisualStudio.TestTools.TypesAndSy" +
                    "mbols.Assembly\' failed");
        }
    }
}
