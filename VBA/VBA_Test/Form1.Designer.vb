<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.file_path = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.date_of_Birth = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.TextBox_Address = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.lbl_Birth = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.lbl_Search = New System.Windows.Forms.Label()
        Me.TextBox_Filter = New System.Windows.Forms.TextBox()
        Me.exportBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'file_path
        '
        Me.file_path.AutoSize = True
        Me.file_path.Location = New System.Drawing.Point(12, 431)
        Me.file_path.Name = "file_path"
        Me.file_path.Size = New System.Drawing.Size(0, 15)
        Me.file_path.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(674, 387)
        Me.DataGridView1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(862, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Enabled = False
        Me.TextBox_Name.Location = New System.Drawing.Point(786, 41)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.PlaceholderText = "Jose"
        Me.TextBox_Name.Size = New System.Drawing.Size(151, 23)
        Me.TextBox_Name.TabIndex = 4
        '
        'date_of_Birth
        '
        Me.date_of_Birth.CustomFormat = "MM/dd/yyyy"
        Me.date_of_Birth.Enabled = False
        Me.date_of_Birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_of_Birth.Location = New System.Drawing.Point(786, 70)
        Me.date_of_Birth.MaxDate = New Date(2022, 5, 9, 0, 0, 0, 0)
        Me.date_of_Birth.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.date_of_Birth.Name = "date_of_Birth"
        Me.date_of_Birth.Size = New System.Drawing.Size(151, 23)
        Me.date_of_Birth.TabIndex = 5
        Me.date_of_Birth.Value = New Date(2022, 5, 9, 0, 0, 0, 0)
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Enabled = False
        Me.TextBox_Email.Location = New System.Drawing.Point(786, 99)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.PlaceholderText = "aa@aa.com"
        Me.TextBox_Email.Size = New System.Drawing.Size(151, 23)
        Me.TextBox_Email.TabIndex = 6
        '
        'TextBox_Address
        '
        Me.TextBox_Address.Enabled = False
        Me.TextBox_Address.Location = New System.Drawing.Point(786, 128)
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.Size = New System.Drawing.Size(151, 23)
        Me.TextBox_Address.TabIndex = 7
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Enabled = False
        Me.lbl_Name.Location = New System.Drawing.Point(692, 41)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Name.TabIndex = 8
        Me.lbl_Name.Text = "Name"
        '
        'lbl_Birth
        '
        Me.lbl_Birth.AutoSize = True
        Me.lbl_Birth.Enabled = False
        Me.lbl_Birth.Location = New System.Drawing.Point(692, 70)
        Me.lbl_Birth.Name = "lbl_Birth"
        Me.lbl_Birth.Size = New System.Drawing.Size(73, 15)
        Me.lbl_Birth.TabIndex = 9
        Me.lbl_Birth.Text = "Date of Birth"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Enabled = False
        Me.lbl_Email.Location = New System.Drawing.Point(695, 99)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(36, 15)
        Me.lbl_Email.TabIndex = 10
        Me.lbl_Email.Text = "Email"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Enabled = False
        Me.lbl_Address.Location = New System.Drawing.Point(692, 128)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(85, 15)
        Me.lbl_Address.TabIndex = 11
        Me.lbl_Address.Text = "Home Address"
        '
        'lbl_Search
        '
        Me.lbl_Search.AutoSize = True
        Me.lbl_Search.Enabled = False
        Me.lbl_Search.Location = New System.Drawing.Point(690, 225)
        Me.lbl_Search.Name = "lbl_Search"
        Me.lbl_Search.Size = New System.Drawing.Size(42, 15)
        Me.lbl_Search.TabIndex = 12
        Me.lbl_Search.Text = "Search"
        '
        'TextBox_Filter
        '
        Me.TextBox_Filter.Enabled = False
        Me.TextBox_Filter.Location = New System.Drawing.Point(837, 225)
        Me.TextBox_Filter.Name = "TextBox_Filter"
        Me.TextBox_Filter.Size = New System.Drawing.Size(100, 23)
        Me.TextBox_Filter.TabIndex = 13
        '
        'exportBtn
        '
        Me.exportBtn.Enabled = False
        Me.exportBtn.Location = New System.Drawing.Point(862, 405)
        Me.exportBtn.Name = "exportBtn"
        Me.exportBtn.Size = New System.Drawing.Size(75, 23)
        Me.exportBtn.TabIndex = 14
        Me.exportBtn.Text = "Export"
        Me.exportBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 475)
        Me.Controls.Add(Me.exportBtn)
        Me.Controls.Add(Me.TextBox_Filter)
        Me.Controls.Add(Me.lbl_Search)
        Me.Controls.Add(Me.lbl_Address)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_Birth)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.TextBox_Address)
        Me.Controls.Add(Me.TextBox_Email)
        Me.Controls.Add(Me.date_of_Birth)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.file_path)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Basic Application"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents file_path As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents date_of_Birth As DateTimePicker
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents lbl_Birth As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Search As Label
    Friend WithEvents TextBox_Filter As TextBox
    Friend WithEvents exportBtn As Button
End Class
