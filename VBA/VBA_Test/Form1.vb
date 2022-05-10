Imports System.IO
Imports System.Text.RegularExpressions

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
        If Not isEmail(Email) Then
            MsgBox("Email is not on the correct format")
        ElseIf Not IsValidDate(Birth) Then
            MsgBox("Date is not on the correct format")
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
        Static emailRegex As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailRegex.IsMatch(email)
    End Function

    Public Function IsValidDate(ByVal dateString As String) As Boolean
        'This should not be checked, since the datePicker already is on the requiered format 
        Try
            DateTime.ParseExact(dateString, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            Return True
        Catch ex As FormatException
            Return False
        End Try
    End Function
End Class
