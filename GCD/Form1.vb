Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case (gcd(TextBox1.Text, TextBox2.Text))
            Case -1
                lblResult.Text = "input value must over 0"
            Case Else
                lblResult.Text = gcd(TextBox1.Text, TextBox2.Text)
        End Select
    End Sub

    Function gcd(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        If TextBox1.Text = 0 Or TextBox2.Text = 0 Then
            Return -1
        ElseIf n2 Mod n1 = 0 Then
            Return n1
        Else
            Return gcd(n2, n1 Mod n2)
        End If
    End Function

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblResult.Text = "<Result Here>"
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
