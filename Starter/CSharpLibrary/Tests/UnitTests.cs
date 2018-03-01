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
            // Don't forget that the solution will return a string.
            Assert.AreEqual("3", Solver.Solve("1 2"));
        }
    }
}
