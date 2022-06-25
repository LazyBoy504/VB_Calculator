Public Class Form1
    Dim firstnumber, secondnumber As Double
    Dim [operator] As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text += "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        firstnumber = TextBox1.Text
        TextBox1.Text += "."
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = "0"
        [operator] = "+"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = "0"
        [operator] = "-"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = "0"
        [operator] = "*"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = "0"
        [operator] = "/"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = "0"
        [operator] = "%"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = "0"
        [operator] = "Mod"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = firstnumber - (firstnumber* 2)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        secondnumber = TextBox1.Text
        Select Case [operator]
            Case "+"
                TextBox1.Text = firstnumber + secondnumber
            Case "-"
                TextBox1.Text = firstnumber - secondnumber
            Case "*"
                TextBox1.Text = firstnumber * secondnumber
            Case "/"
                TextBox1.Text = firstnumber / secondnumber
            Case "Mod"
                TextBox1.Text = firstnumber Mod secondnumber
            Case "%"
                TextBox1.Text = (firstnumber / secondnumber) * 100

        End Select
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = (firstnumber / 10) - ((firstnumber Mod 10) / 10)
    End Sub
End Class
