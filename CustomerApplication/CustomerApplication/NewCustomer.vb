Public Class NewCustomer
    Private _mainForm As MainForm
    Private customer As Customer

    Sub New(mainForm As MainForm)
        _mainForm = mainForm
        customer = New Customer()
        InitializeComponent()
    End Sub

    Private Sub NewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Cancel Button
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Submit Button
        _mainForm.customers.Add(customer)
        _mainForm.SaveCustomerData()

        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        customer.nameFirst = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        customer.nameLast = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        customer.phoneNumber = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        customer.cellNumber = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        customer.accountBalance = TextBox5.Text
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        customer.lastPayment = TextBox6.Text
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        customer.address = TextBox7.Text
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        customer.city = TextBox8.Text
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        customer.state = TextBox9.Text
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        customer.zipCode = TextBox10.Text
    End Sub

End Class