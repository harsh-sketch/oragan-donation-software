<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BloodTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodTable1DataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet1 = New comprojectxx.Database2DataSet1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BloodTable1TableAdapter1 = New comprojectxx.Database2DataSet1TableAdapters.bloodTable1TableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager1 = New comprojectxx.Database2DataSet1TableAdapters.TableAdapterManager()
        CType(Me.BloodTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodTable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodTable1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BloodTable1BindingSource
        '
        Me.BloodTable1BindingSource.DataMember = "bloodTable1"
        '
        'BloodTable1DataGridView
        '
        Me.BloodTable1DataGridView.AllowUserToOrderColumns = True
        Me.BloodTable1DataGridView.AutoGenerateColumns = False
        Me.BloodTable1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BloodTable1DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BloodTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BloodTable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.BloodGroupDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.OrganDataGridViewTextBoxColumn})
        Me.BloodTable1DataGridView.DataSource = Me.BloodTable1BindingSource1
        Me.BloodTable1DataGridView.Location = New System.Drawing.Point(318, 428)
        Me.BloodTable1DataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.BloodTable1DataGridView.Name = "BloodTable1DataGridView"
        Me.BloodTable1DataGridView.RowHeadersWidth = 51
        Me.BloodTable1DataGridView.Size = New System.Drawing.Size(1359, 271)
        Me.BloodTable1DataGridView.TabIndex = 2
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'BloodGroupDataGridViewTextBoxColumn
        '
        Me.BloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup"
        Me.BloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup"
        Me.BloodGroupDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BloodGroupDataGridViewTextBoxColumn.Name = "BloodGroupDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.WeightDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'OrganDataGridViewTextBoxColumn
        '
        Me.OrganDataGridViewTextBoxColumn.DataPropertyName = "Organ"
        Me.OrganDataGridViewTextBoxColumn.HeaderText = "Organ"
        Me.OrganDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrganDataGridViewTextBoxColumn.Name = "OrganDataGridViewTextBoxColumn"
        '
        'BloodTable1BindingSource1
        '
        Me.BloodTable1BindingSource1.DataMember = "bloodTable1"
        Me.BloodTable1BindingSource1.DataSource = Me.Database2DataSet1
        '
        'Database2DataSet1
        '
        Me.Database2DataSet1.DataSetName = "Database2DataSet1"
        Me.Database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(309, 270)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(398, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Please Enter which body parts you need"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 315)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(472, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Here are contact information of donor you need"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(996, 264)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(794, 268)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 35)
        Me.TextBox1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1324, 77)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 39)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Home "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1458, 77)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 39)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Log Out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BloodTable1TableAdapter1
        '
        Me.BloodTable1TableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label1.Font = New System.Drawing.Font("Blackadder ITC", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(806, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Organ  Needer Panel"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.bloodTable1TableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = comprojectxx.Database2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.BackgroundImage = Global.comprojectxx.My.Resources.Resources.Backgrounddonor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1798, 1017)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BloodTable1DataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.BloodTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodTable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodTable1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents Database2DataSet As Database2DataSet
    Friend WithEvents BloodTable1BindingSource As BindingSource
    'Friend WithEvents BloodTable1TableAdapter As Database2DataSetTableAdapters.bloodTable1TableAdapter
    'Friend WithEvents TableAdapterManager As Database2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BloodTable1DataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Database2DataSet1 As Database2DataSet1
    Friend WithEvents BloodTable1BindingSource1 As BindingSource
    Friend WithEvents BloodTable1TableAdapter1 As Database2DataSet1TableAdapters.bloodTable1TableAdapter
    Friend WithEvents TableAdapterManager1 As Database2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloodGroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
