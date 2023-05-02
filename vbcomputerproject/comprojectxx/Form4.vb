Public Class Form4
    Private Sub BloodTable1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BloodTable1BindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'TODO: This line of code loads data into the 'Database2DataSet1.bloodTable1' table. You can move, or remove it, as needed.
        Me.BloodTable1TableAdapter1.Fill(Me.Database2DataSet1.bloodTable1)
        'TODO: This line of code loads data into the 'Database2DataSet.bloodTable1' table. You can move, or remove it, as needed.
        'Me.BloodTable1TableAdapter.Fill(Me.Database2DataSet.bloodTable1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BloodTable1TableAdapter1.FillBy(Me.Database2DataSet1.bloodTable1, TextBox1.Text)

    End Sub

    'Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
    'Try
    'Me.BloodTable1TableAdapter1.FillBy(Me.Database2DataSet1.bloodTable1, OrganToolStripTextBox.Text)
    'Catch ex As System.Exception
    '       System.Windows.Forms.MessageBox.Show(ex.Message)
    'End Try

    'End Sub

    'Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs)
    'Try
    '    Me.BloodTable1TableAdapter1.FillBy(Me.Database2DataSet1.bloodTable1, OrganToolStripTextBox.Text)
    '  Catch ex As System.Exception
    '     System.Windows.Forms.MessageBox.Show(ex.Message)
    '   End Try

    'End Sub
End Class