Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Data

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date_of_Birth.Format = DateTimePickerFormat.Custom
        date_of_Birth.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ofd As OpenFileDialog = New OpenFileDialog()
            If ofd.ShowDialog() = DialogResult.OK Then
                file_path.Text = ofd.FileName
                Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                Dim list As List(Of User) = New List(Of User)
                fill_Columns(lines)
                For i As Integer = 1 To lines.Count - 1
                    Dim data As String() = lines(i).Split(",")
                    addElements(
                    data(0),
                    data(1),
                    data(2),
                    data(3),
                    data(4)
                )
                Next
            End If
        End Using
    End Sub

    Private Sub addElements(Code As String, Name As String, Birth As DateTime, Email As String, Address As String)
        If Not isEmail(Email.Trim) Then
            MsgBox("Email is not on the correct format")
        ElseIf Name = "" Then
            MsgBox("You dont have name? Please complete the name field")
        Else
            DataGridView1.Rows.Add(
                Code,
                Name,
                Birth.ToString,
                Email,
                Address
            )
        End If
    End Sub

    Private Sub fill_Columns(lines As List(Of String))
        Dim columns() As String = lines(0).Split(",")
        For Each item In columns
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = item
            col.Name = item
            col.DataPropertyName = item
            DataGridView1.Columns.Add(col)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addElements(
            (DataGridView1.Rows.Count - 1).ToString,
            TextBox_Name.Text,
            date_of_Birth.Value,
            TextBox_Email.Text,
            TextBox_Address.Text
        )
    End Sub

    Function isEmail(ByVal email As String) As Boolean
        'Static emailRegex As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        'Dim isMail As Boolean = emailRegex.IsMatch(email)
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(email)
        Return regex.IsMatch(email)
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Filter.TextChanged
        Dim lines() As String = IO.File.ReadAllLines(file_path.text).Where(Function(s) s.StartsWith(TextBox_Filter.Text)).ToArray

        DataGridView1.Rows.Clear()

        For Each line As String In lines
            If Not line.Split(",")(0).Equals("Code") Then
                DataGridView1.Rows.Add(line.Split(","c))
            End If
        Next
    End Sub
End Class
