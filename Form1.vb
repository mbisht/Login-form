Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles uname.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "mayank" And TextBox2.Text = "adminpass" Then
            MsgBox("You are now Logged In", MsgBoxStyle.Information, "Login")
        Else
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("No username and/or No password!", MsgBoxStyle.Critical, "Error")
            Else
                If TextBox1.Text = "" Then
                    MsgBox("No username is found!", MsgBoxStyle.Critical, "Error")
                Else
                    If TextBox2.Text = "" Then
                        MsgBox("No password is found!", MsgBoxStyle.Critical, "Error")
                    Else
                        MsgBox("No username and passsword is found!", MsgBoxStyle.Critical, "Error")


                    End If


                End If

            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
