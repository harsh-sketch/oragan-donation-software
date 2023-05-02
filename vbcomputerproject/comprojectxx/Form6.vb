Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rect As New Rectangle(10, 10, 100, 50)
        Dim g As Graphics = Me.CreateGraphics()
        g.DrawRectangle(Pens.Black, rect)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Close()
    End Sub

    Dim g, mg As Graphics
    Public bmp As Bitmap
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form7.Label1.Text = TextBox1.Text
        Form7.Show()
        MsgBox("Check Your Name")
        g = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(bmp)
        mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        Form7.PrintPreviewDialog1.ShowDialog()
    End Sub
End Class