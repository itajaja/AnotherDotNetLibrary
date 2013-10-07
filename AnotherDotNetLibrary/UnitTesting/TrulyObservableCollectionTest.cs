using Adnl.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;

namespace UnitTesting
{
    
    
    /// <summary>
    ///This is a test class for TrulyObservableCollectionTest and is intended
    ///to contain all TrulyObservableCollectionTest Unit Tests
    ///</summary>
    [TestClass]
    public class TrulyObservableCollectionTest
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
        ///A test for TrulyObservableCollection`1 Constructor
        ///</summary>
        public void TrulyObservableCollectionConstructorTestHelper<T>()
            where T : INotifyPropertyChanged
        {
            var target = new TrulyObservableCollection<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod]
        public void TrulyObservableCollectionConstructorTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
                    "Please call TrulyObservableCollectionConstructorTestHelper<T>() with appropriate" +
                    " type parameters.");
        }
    }
}
