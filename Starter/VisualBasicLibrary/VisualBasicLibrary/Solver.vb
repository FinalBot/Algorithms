Public Class Solver
    ''' <summary>
    ''' This is the entry point to your solution. You can add whatever code and classes you need (within the
    ''' security restrictions), but just be sure this method exists to accept and return a string.
    ''' </summary>
    ''' <param name="input">The test input.</param>
    ''' <returns>Your solution output.</returns>
    Public Shared Function Solve(input As String) As String
        Dim pair As String() = input.Split(" ")
        Return (Integer.Parse(pair(0)) + Integer.Parse(pair(1))).ToString()
    End Function
End Class
