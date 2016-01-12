Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Lets get the sum of all Odd numbers using Mod operator
        Dim Odds As Integer = 0
        Dim AnyNumber = Val(TextBox1.Text)
        Dim AnyOtherNumber = Val(TextBox2.Text)

        For i = AnyNumber To AnyOtherNumber
            If i Mod 2 = 1 Then
                Odds += i
            End If
        Next

        Me.TextBox3.Text = Odds
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Lets get the sum of all Even numbers using Mod operator
        Dim Evens As Integer = 0
        Dim AnyNumber = Val(TextBox1.Text)
        Dim AnyOtherNumber = Val(TextBox2.Text)

        For i = AnyNumber To AnyOtherNumber
            If i Mod 2 = 0 Then
                Evens += i
           
            End If
        Next

        Me.TextBox4.Text = Evens
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Lets get the Total of all odd and even numbers
        Dim sum1 As Integer
        Dim sum2 As Integer
        Dim Totalsum As Integer

        sum1 = Val(TextBox4.Text)
        sum2 = Val(TextBox3.Text)

        Totalsum = sum1 + sum2

        Me.TextBox5.Text = Totalsum
    End Sub

   
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Clear all fields and start over
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Lets close the program for now
        Me.Close()
    End Sub
End Class
