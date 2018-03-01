Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VisualBasicLibrary

<TestClass()> Public Class UnitTests
    ''' <summary>
    ''' This is a sample test for a simple adding scenario.
    ''' </summary>
    <TestMethod()> Public Sub SampleTest()
        ' Don't forget that the solution will return a string.
        Assert.AreEqual("3", Solver.Solve("1 2"))
    End Sub

End Class