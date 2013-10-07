using Adnl.Manipulation.Cloning;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    
    
    /// <summary>
    ///This is a test class for IDeepCloneableTest and is intended
    ///to contain all IDeepCloneableTest Unit Tests
    ///</summary>
    [TestClass]
    public class IDeepCloneableTest
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
        ///A test for DeepClone
        ///</summary>
        public void DeepCloneTestHelper<T>()
        {
            var target = CreateIDeepCloneable<T>(); // TODO: Initialize to an appropriate value
            var expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = target.DeepClone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        internal virtual IDeepCloneable<T> CreateIDeepCloneable<T>()
        {
            // TODO: Instantiate an appropriate concrete class.
            IDeepCloneable<T> target = null;
            return target;
        }

        [TestMethod]
        public void DeepCloneTest()
        {
            DeepCloneTestHelper<GenericParameterHelper>();
        }
    }
}
