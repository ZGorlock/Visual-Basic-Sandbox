Imports System.IO

Public Class MainForm
    Private newCustomer As NewCustomer
    Private searchCustomer As SearchCustomer
    Public customers As ArrayList
    Private saveFileDialog As SaveFileDialog

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customers = New ArrayList()
        LoadCustomerData()
    End Sub

    Private Sub LoadCustomerData()
        Dim file As String
        file = "data.txt"
        Dim reader As StreamReader = New StreamReader(file)

        Dim n As Integer
        n = CInt(reader.ReadLine())

        For i As Integer = 1 To n Step 1
            Dim c As Customer = New Customer

            c.nameFirst = reader.ReadLine()
            c.nameLast = reader.ReadLine()
            c.phoneNumber = reader.ReadLine()
            c.cellNumber = reader.ReadLine()
            c.address = reader.ReadLine()
            c.city = reader.ReadLine()
            c.state = reader.ReadLine()
            c.zipCode = reader.ReadLine()
            c.accountBalance = reader.ReadLine()
            c.lastPayment = reader.ReadLine()

            customers.Add(c)
        Next

        reader.Close()

    End Sub

    Public Sub SaveCustomerData()
        Dim file As String
        file = "data.txt"
        Dim writer As StreamWriter = New StreamWriter(file)

        Dim n As Integer
        n = customers.Count
        writer.WriteLine(n.ToString())


        For i As Integer = 1 To n Step 1
            Dim c As Customer = customers(i - 1)

            writer.WriteLine(c.nameFirst)
            writer.WriteLine(c.nameLast)
            writer.WriteLine(c.phoneNumber)
            writer.WriteLine(c.cellNumber)
            writer.WriteLine(c.address)
            writer.WriteLine(c.city)
            writer.WriteLine(c.state)
            writer.WriteLine(c.zipCode)
            writer.WriteLine(c.accountBalance)
            writer.WriteLine(c.lastPayment)

        Next

        writer.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'New Customer Button
        newCustomer = New NewCustomer(Me)
        newCustomer.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Find Customer Button
        searchCustomer = New SearchCustomer(Me)
        searchCustomer.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Export Customers Button
        Dim file As String
        saveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "TXT Files (*.txt*)|*txt"
        If saveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = saveFileDialog.FileName
            Dim writer As StreamWriter = New StreamWriter(file)

            writer.WriteLine("------------------------------------------------------------")
            writer.WriteLine()
            For i As Integer = 1 To customers.Count Step 1
                Dim c As Customer = customers(i - 1)
                writer.WriteLine(c.toString)
                writer.WriteLine()
                writer.WriteLine("------------------------------------------------------------")
                If Not i = customers.Count Then
                    writer.WriteLine()
                End If
            Next i

            writer.Close()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Exit Button
        SaveCustomerData()
        Me.Close()
    End Sub

End Class
