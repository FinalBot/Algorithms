using System;
using CSharpLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        /// <summary>
        /// This is a sample test for a simple adding scenario.
        /// </summary>
        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual("3", Solver.Solve("1 2"));
        }
    }
}
