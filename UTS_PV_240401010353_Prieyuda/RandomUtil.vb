Public Class RandomUtil
    Private Shared ReadOnly rng As New Random()

    Public Shared Function GenerateId() As String
        Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim result As New System.Text.StringBuilder(6)

        For i As Integer = 1 To 6
            Dim index As Integer = rng.Next(0, chars.Length)
            result.Append(chars(index))
        Next

        Return result.ToString()
    End Function
End Class
