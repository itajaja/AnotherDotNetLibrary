using System;
using Adnl.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTesting
{
    
    
    /// <summary>
    ///This is a test class for ObservableStackTest and is intended
    ///to contain all ObservableStackTest Unit Tests
    ///</summary>
    [TestClass]
    public class ObservableStackTest
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
        ///A test for ObservableStack`1 Constructor
        ///</summary>
        [TestMethod]
        public void ObservableStackConstructorTest1()
        {
            IEnumerable<int> collection = new List<int>{1,2,3,4,5,6,7,8,9,10};
            var target = new ObservableStack<int>(collection);
            Assert.AreEqual(target.Count, 10);
            for (int i = 10; i > 0; i--)
            {
                Assert.AreEqual(i,target.Pop());
            }
        }

        [TestMethod]
        public void ClearTest()
        {
            IEnumerable<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var target = new ObservableStack<int>(collection);
            Assert.AreEqual(target.Count, 10);
            target.Clear();
            Assert.AreEqual(target.Count, 0);
        }

        [TestMethod]
        public void PopTest()
        {
            IEnumerable<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var target = new ObservableStack<int>(collection);
            var expected = 10;
            for (int i = 0; i < 10; i++)
            {
                int actual = target.Pop();
                Assert.AreEqual(expected, actual);
                expected--;
            }
            try
            {
                target.Pop();
                Assert.Fail("should throw exception!");
            }
            catch (InvalidOperationException){}
        }

        [TestMethod]
        public void PushTest()
        {
            var target = new ObservableStack<int>();
            Assert.AreEqual(target.Count, 0);
            const int item = 4;
            target.Push(item);
            Assert.AreEqual(target.Count,1);
            Assert.AreEqual(target.Peek(),item);
        }
    }
}
