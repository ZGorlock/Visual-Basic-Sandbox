Public Class Customer
    Public nameLast As String
    Public nameFirst As String
    Public cellNumber As String
    Public address As String
    Public city As String
    Public state As String
    Public zipCode As String
    Public phoneNumber As String
    Public accountBalance As String
    Public lastPayment As String

    Public Overrides Function toString() As String
        Return "Name:         " + nameFirst + " " + nameLast + Environment.NewLine +
               "Phone:        " + phoneNumber + Environment.NewLine +
               "Cell:         " + cellNumber + Environment.NewLine +
               "Address:      " + address + Environment.NewLine +
               "              " + city + ", " + state + " " + zipCode + Environment.NewLine +
               "Balance:      " + accountBalance + Environment.NewLine +
               "Last Payment: " + lastPayment
    End Function

End Class
