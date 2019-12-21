Public Class DeleteVerification

    Private _searchCustomer As SearchCustomer
    Private _mainForm As MainForm

    Sub New(searchCustomer As SearchCustomer, mainForm As MainForm)
        _searchCustomer = searchCustomer
        _mainForm = mainForm
        InitializeComponent()
    End Sub

    Private Sub DeleteVerification_Load(sender As Object, e As EventArgs)
        'RadioButton2.Checked = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'RadioButton1.Checked = True
        'RadioButton2.Checked = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'RadioButton2.Checked = True
        'RadioButton1.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton2.Checked Then
            _mainForm.customers.RemoveAt(_searchCustomer.customerIndex)
            _mainForm.SaveCustomerData()

            _searchCustomer.TextBox1.Text = ""
            _searchCustomer.TextBox2.Text = ""
        End If
        Me.Close()
    End Sub

End Class