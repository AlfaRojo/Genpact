Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date_of_Birth.Format = DateTimePickerFormat.Custom
        date_of_Birth.CustomFormat = "MM/dd/yyyy"
        date_of_Birth.MaxDate = DateTime.Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ofd As OpenFileDialog = New OpenFileDialog()
            If ofd.ShowDialog() = DialogResult.OK Then
                DataGrid_DB.Rows.Clear()
                DataGrid_DB.Columns.Clear()
                enable_Elements()
                file_path.Text = ofd.FileName
                Dim fLines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                fill_Columns(fLines)
                For i As Integer = 1 To fLines.Count - 1
                    Dim sData As String() = fLines(i).Split(",")
                    addElements(
                    sData(0),
                    sData(1),
                    sData(2),
                    sData(3),
                    sData(4)
                )
                Next
            End If
        End Using
    End Sub

    Private Sub enable_Elements()
        lbl_Name.Enabled = True
        lbl_Birth.Enabled = True
        lbl_Email.Enabled = True
        lbl_Address.Enabled = True
        lbl_Search.Enabled = True
        TextBox_Address.Enabled = True
        TextBox_Email.Enabled = True
        TextBox_Filter.Enabled = True
        TextBox_Name.Enabled = True
        date_of_Birth.Enabled = True
        exportBtn.Enabled = True
        addBtn.Enabled = True
    End Sub

    Private Sub addElements(Code As String, Name As String, Birth As DateTime, Email As String, Address As String)
        If Not isEmail(Email.Trim) And isEmail(Email.Trim).Equals("") Then
            MsgBox("Email is not on the correct format")
        ElseIf Name = "" Then
            MsgBox("You dont have name? Please complete the name field")
        Else
            DataGrid_DB.Rows.Add(
                Code,
                Name,
                Birth.ToString,
                Email,
                Address
            )
        End If
    End Sub

    Private Sub fill_Columns(lines As List(Of String))
        Dim sColumns() As String = lines(0).Split(",")
        For Each item In sColumns
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = item
            col.Name = item
            col.DataPropertyName = item
            DataGrid_DB.Columns.Add(col)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        addElements(
            (DataGrid_DB.Rows.Count).ToString,
            TextBox_Name.Text,
            date_of_Birth.Value,
            TextBox_Email.Text,
            TextBox_Address.Text
        )
        Using fileWriter As New System.IO.StreamWriter(file_path.Text, True)
            fileWriter.WriteLineAsync(String.Join(
                ",",
                (DataGrid_DB.Rows.Count - 1),
                TextBox_Name.Text,
                date_of_Birth.Value,
                TextBox_Email.Text,
                TextBox_Address.Text
            ))
        End Using 'This close the file once is done

    End Sub

    Function isEmail(ByVal email As String) As Boolean
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Return regex.IsMatch(email)
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Filter.TextChanged
        Dim fLines() As String = IO.File.ReadAllLines(file_path.Text).ToArray

        DataGrid_DB.Rows.Clear()

        For Each sLine As String In fLines
            If Not sLine.Split(",")(0).Equals("Code") Then
                If Not TextBox_Filter.Text.Equals("") Then
                    If Integer.TryParse(TextBox_Filter.Text, New Integer) < 0 Then
                        If Integer.Parse(sLine.Split(",")(0)) = Integer.Parse(TextBox_Filter.Text) Then
                            DataGrid_DB.Rows.Add(sLine.Split(","c))
                        End If
                    Else
                        If sLine.Split(",")(1).Contains(TextBox_Filter.Text) Then
                            DataGrid_DB.Rows.Add(sLine.Split(","c))
                        End If
                    End If
                Else
                    DataGrid_DB.Rows.Add(sLine.Split(","c))
                End If
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles exportBtn.Click
        Dim exportForm = New Export()
        exportForm.Tag = file_path.Text
        exportForm.Show()
    End Sub
End Class
