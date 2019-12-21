Imports System.IO

Public Class SearchCustomer
    Private deleteVerification As DeleteVerification
    Public customer As Customer
    Public customerIndex As Integer = -1
    Private _mainForm As MainForm
    Private saveFileDialog As SaveFileDialog

    Sub New(mainForm As MainForm)
        _mainForm = mainForm
        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Search Button
        Dim query As String = TextBox1.Text
        customerIndex = -1
        For i As Integer = 0 To _mainForm.customers.Count - 1 Step 1
            Dim c As Customer = _mainForm.customers(i)
            If (query = c.nameLast Or query = c.phoneNumber Or query = c.cellNumber) Then
                customer = c
                customerIndex = i
                Exit For
            End If
        Next

        If customerIndex > -1 Then
            TextBox2.Text = customer.toString
        Else
            TextBox2.Text = "Customer could not be found..."
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Export Button
        If (customerIndex > -1) Then
            Dim file As String
            saveFileDialog = New SaveFileDialog()
            saveFileDialog.Filter = "TXT Files (*.txt*)|*txt"
            If saveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                file = saveFileDialog.FileName
                Dim writer As StreamWriter = New StreamWriter(file)

                writer.WriteLine("------------------------------------------------------------")
                writer.WriteLine()
                Dim c As Customer = _mainForm.customers(customerIndex)
                writer.WriteLine(c.toString)
                writer.WriteLine()
                writer.WriteLine("------------------------------------------------------------")

                writer.Close()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Delete Button
        If (customerIndex > -1) Then
            deleteVerification = New DeleteVerification(Me, _mainForm)
            deleteVerification.Show()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Cancel Button
        Me.Close()
    End Sub
End Class