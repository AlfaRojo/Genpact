<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Export
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rangeBtn = New System.Windows.Forms.RadioButton()
        Me.nameBtn = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Main = New System.Windows.Forms.TextBox()
        Me.lbl_To = New System.Windows.Forms.Label()
        Me.TextBox_Second = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'rangeBtn
        '
        Me.rangeBtn.AutoSize = True
        Me.rangeBtn.Location = New System.Drawing.Point(12, 27)
        Me.rangeBtn.Name = "rangeBtn"
        Me.rangeBtn.Size = New System.Drawing.Size(58, 19)
        Me.rangeBtn.TabIndex = 0
        Me.rangeBtn.TabStop = True
        Me.rangeBtn.Text = "Range"
        Me.rangeBtn.UseVisualStyleBackColor = True
        '
        'nameBtn
        '
        Me.nameBtn.AutoSize = True
        Me.nameBtn.Location = New System.Drawing.Point(115, 27)
        Me.nameBtn.Name = "nameBtn"
        Me.nameBtn.Size = New System.Drawing.Size(57, 19)
        Me.nameBtn.TabIndex = 1
        Me.nameBtn.TabStop = True
        Me.nameBtn.Text = "Name"
        Me.nameBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filter by"
        '
        'TextBox_Main
        '
        Me.TextBox_Main.Location = New System.Drawing.Point(12, 52)
        Me.TextBox_Main.Name = "TextBox_Main"
        Me.TextBox_Main.Size = New System.Drawing.Size(160, 23)
        Me.TextBox_Main.TabIndex = 3
        '
        'lbl_To
        '
        Me.lbl_To.AutoSize = True
        Me.lbl_To.Location = New System.Drawing.Point(83, 78)
        Me.lbl_To.Name = "lbl_To"
        Me.lbl_To.Size = New System.Drawing.Size(19, 15)
        Me.lbl_To.TabIndex = 4
        Me.lbl_To.Text = "To"
        Me.lbl_To.Visible = False
        '
        'TextBox_Second
        '
        Me.TextBox_Second.Location = New System.Drawing.Point(12, 96)
        Me.TextBox_Second.Name = "TextBox_Second"
        Me.TextBox_Second.PlaceholderText = "Max value"
        Me.TextBox_Second.Size = New System.Drawing.Size(160, 23)
        Me.TextBox_Second.TabIndex = 5
        Me.TextBox_Second.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(191, 156)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox_Second)
        Me.Controls.Add(Me.lbl_To)
        Me.Controls.Add(Me.TextBox_Main)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameBtn)
        Me.Controls.Add(Me.rangeBtn)
        Me.Name = "Export"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rangeBtn As RadioButton
    Friend WithEvents nameBtn As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Main As TextBox
    Friend WithEvents lbl_To As Label
    Friend WithEvents TextBox_Second As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
