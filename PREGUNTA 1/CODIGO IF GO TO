Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        Dim msg As String
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
        If a > b And b > c Then GoTo mayor1 Else GoTo p1
mayor1:
        msg = a & "-" & b & "-" & c
        TextBox4.Text = msg
        GoTo salir
p1:
        If a > c And c > b Then GoTo mayor2 Else GoTo p2
mayor2:
        msg = a & "-" & c & "-" & b
        TextBox4.Text = msg
        GoTo salir
p2:
        If b > a And a > c Then GoTo mayor3 Else GoTo p3
mayor3:
        msg = b & "-" & a & "-" & c
        TextBox4.Text = msg
        GoTo salir
p3:
        If b > c And c > a Then GoTo mayor4 Else GoTo p4
mayor4:
        msg = b & "-" & c & "-" & a
        TextBox4.Text = msg
        GoTo salir
p4:
        If c > a And a > b Then GoTo mayor5 Else GoTo p5
mayor5:
        msg = c & "-" & a & "-" & b
        TextBox4.Text = msg
        GoTo salir
p5:
        msg = c & "-" & b & "-" & a
        TextBox4.Text = msg
        GoTo salir
salir:
    End Sub
End Class
