using Adnl.Windows.Input;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting
{
    
    
    /// <summary>
    ///This is a test class for RelayCommandTest and is intended
    ///to contain all RelayCommandTest Unit Tests
    ///</summary>
    [TestClass]
    public class RelayCommandTest
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
        ///A test for RelayCommand Constructor
        ///</summary>
        [TestMethod]
        public void RelayCommandConstructorTest()
        {
            Action<object> execute = null; // TODO: Initialize to an appropriate value
            var target = new RelayCommand(execute);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for RelayCommand Constructor
        ///</summary>
        [TestMethod]
        public void RelayCommandConstructorTest1()
        {
            Action<object> execute = null; // TODO: Initialize to an appropriate value
            Predicate<object> canExecute = null; // TODO: Initialize to an appropriate value
            var target = new RelayCommand(execute, canExecute);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CanExecute
        ///</summary>
        [TestMethod]
        public void CanExecuteTest()
        {
            Action<object> execute = null; // TODO: Initialize to an appropriate value
            var target = new RelayCommand(execute); // TODO: Initialize to an appropriate value
            object parameter = null; // TODO: Initialize to an appropriate value
            var expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CanExecute(parameter);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        [TestMethod]
        public void ExecuteTest()
        {
            Action<object> execute = null; // TODO: Initialize to an appropriate value
            var target = new RelayCommand(execute); // TODO: Initialize to an appropriate value
            object parameter = null; // TODO: Initialize to an appropriate value
            target.Execute(parameter);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
