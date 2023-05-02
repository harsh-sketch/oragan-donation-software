Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim uname As String
        Dim pass As String

        uname = TextBox1.Text
        pass = TextBox2.Text

        If uname = "" And pass = "" Then
            MsgBox("please enter all fields")

        Else
            Try
                If uname = "runali" And pass = "pass" Then
                    MsgBox("login successful")
                    Form5.Show()
                    Form1.Hide()
                    Me.Hide()
                Else
                    MsgBox("please enter valid info")
                    TextBox1.Clear()
                    TextBox2.Clear()

                End If
            Catch ex As Exception
                MsgBox("error")
            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.ControlBox = False
    End Sub
End Class