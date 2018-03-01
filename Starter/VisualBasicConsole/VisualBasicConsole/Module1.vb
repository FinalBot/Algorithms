Module Module1

    Sub Main()
        ' Simple test of Solve function.
        Console.WriteLine(Solver.Solve("1 2"))
    End Sub

    Public Class Solver
        ''' <summary>
        ''' This is your solution function.
        ''' </summary>
        ''' <param name="input">The test input.</param>
        ''' <returns>Your solution output.</returns>
        Public Shared Function Solve(input As String) As String
            Dim pair As String() = input.Split(" ")
            Return (Integer.Parse(pair(0)) + Integer.Parse(pair(1))).ToString()
        End Function
    End Class

End Module
