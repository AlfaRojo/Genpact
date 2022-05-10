Public Class Export
    Private Sub Export_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Tag.ToString
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rangeBtn.CheckedChanged
        nameBtn.Checked = Not rangeBtn.Checked
        lbl_To.Visible = True
        TextBox_Second.Visible = True
        TextBox_Main.PlaceholderText = "Min value"
    End Sub

    Private Sub nameBtn_CheckedChanged(sender As Object, e As EventArgs) Handles nameBtn.CheckedChanged
        rangeBtn.Checked = Not nameBtn.Checked
        lbl_To.Visible = False
        TextBox_Second.Visible = False
        TextBox_Main.PlaceholderText = ""
    End Sub

    Private Sub TextBox_Main_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Main.KeyPress
        If rangeBtn.Checked Then
            remove_Letters(e)
        End If
    End Sub

    Private Sub TextBox_Second_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Second.KeyPress
        remove_Letters(e)
    End Sub

    Private Sub remove_Letters(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim exportList As List(Of String) = New List(Of String)
        If rangeBtn.Checked Then
            Dim iMin As Integer = Integer.Parse(TextBox_Main.Text)
            Dim iMax As Integer = Integer.Parse(TextBox_Second.Text)
            If iMin > iMax Then
                MsgBox("Min value must be lower than the max value.")
                Return
            End If
            Dim fLines() = IO.File.ReadAllLines(Me.Tag.ToString).ToArray
            For Each sMatch In fLines
                If Not sMatch.Split(",")(0).Equals("Code") Then
                    Dim value As Integer = sMatch.Split(",")(0)
                    If value >= iMin And value <= iMax Then
                        exportList.Add(sMatch)
                    End If
                End If
            Next

        ElseIf nameBtn.Checked Then 'This is not needed, since rangeBtn is not checked, that means nameBtn will be checked
            Dim fLines() = IO.File.ReadAllLines(Me.Tag.ToString).Where(Function(x) (x.Split(",")(1).ToLower.Contains(TextBox_Main.Text))).ToArray

            For Each Smatch In fLines
                If Not Smatch.Split(",")(0).Equals("Code") Then
                    exportList.Add(Smatch)
                End If
            Next
        End If
        If exportList.Count > 0 Then
            export_CSV(exportList)
            MsgBox(exportList.Count.ToString + " elements saved!")
        Else
            MsgBox("No records to save")
        End If
    End Sub

    Private Function get_First_Line() As String
        Return IO.File.ReadLines(Me.Tag.ToString).FirstOrDefault
    End Function

    Private Sub export_CSV(list As List(Of String))
        SaveFileDialog1.Filter = "All files (*.*)|*.csv"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Using fileWriter As New System.IO.StreamWriter(SaveFileDialog1.FileName, True)
                fileWriter.WriteLine(get_First_Line)
                For Each line In list
                    fileWriter.WriteLine(line)
                Next
            End Using
        End If

    End Sub
End Class