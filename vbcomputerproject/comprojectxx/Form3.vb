Public Class Form3
    Private Sub BloodTable1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BloodTable1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BloodTable1BindingSource.EndEdit()
        '        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'TODO: This line of code loads data into the 'Database2DataSet1.bloodTable1' table. You can move, or remove it, as needed.
        Me.BloodTable1TableAdapter1.Fill(Me.Database2DataSet1.bloodTable1)
        'TODO: This line of code loads data into the 'Database2DataSet.bloodTable1' table. You can move, or remove it, as needed.
        '        Me.BloodTable1TableAdapter.Fill(Me.Database2DataSet.bloodTable1)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.ResetText()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        BloodTable1BindingSource1.EndEdit()
        BloodTable1TableAdapter1.Update(Database2DataSet1.bloodTable1)

        Me.BloodTable1TableAdapter1.Fill(Database2DataSet1.bloodTable1)
        MsgBox("record saved successfully")


saveerror:

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BloodTable1BindingSource1.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BloodTable1BindingSource1.RemoveCurrent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class