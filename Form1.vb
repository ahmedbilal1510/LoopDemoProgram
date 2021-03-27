Public Class Form1
    Private N, S As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        S = 0
        N = Val(txtInput.Text)

        Dim i As Integer = 1
        Do While (i <= N)
            S += i
            i += 1
        Loop

        lblOutput.Text = Format(S, "#,###")
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        S = 0
        N = Val(txtInput.Text)

        Dim i As Integer = 1
        Do Until (i > N)
            S += i
            i += 1
        Loop

        lblOutput.Text = Format(S, "#,###")
    End Sub

    Private Sub btnDoLoopWhile_Click(sender As Object, e As EventArgs) Handles btnDoLoopWhile.Click
        S = 0
        N = Val(txtInput.Text)

        Dim i As Integer = 1
        Do
            S += i
            i += 1
        Loop While (i <= N)
        lblOutput.Text = Format(S, "#,###")

    End Sub

    Private Sub btnDoLoopUntil_Click(sender As Object, e As EventArgs) Handles btnDoLoopUntil.Click
        S = 0
        N = Val(txtInput.Text)

        Dim i As Integer = 1
        Do
            S += i
            i += 1
        Loop Until (i > N)
        lblOutput.Text = Format(S, "#,###")
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        S = 0
        N = Val(txtInput.Text)

        For i As Integer = 1 To N Step 1
            S += i
        Next
        lblOutput.Text = Format(S, "#,###")

    End Sub
End Class
