'Farheen Ghartey
'11/24/2015
'Number Analysis Program
'Application allows use to enter 10 numbers and store the numbers in array and display the highest,lowest,total and average numbers in the array
Public Class Form1
    'This application stores the numbers in the array and then displays highest,lowest,total and average numbers in the array. 
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Const intMAX_SUBSCRIPT As Integer = 9 'the maximum subscript 
        Dim intNumbers(intMAX_SUBSCRIPT) As Integer 'array declaration
        Dim intCount As Integer 'Loop count
        Dim intHighest As Integer 'to hold the highest value
        Dim intSmallest As Integer 'to hold the lowest value
        Dim intTotal As Integer = 0 'to hold the total value
        Dim dblAverage As Double 'to hold the average value of input values
        'get first high value
        For intCount = 0 To (intMAX_SUBSCRIPT)
            intNumbers(intCount) = =lstValues.Items(intCount)
        Next
        intHighest = intNumbers(intMAX_SUBSCRIPT)
        'search for the highest value.
        For intCount = 1 To (intNumbers.Length - 1)
            If intNumbers(intCount) > intHighest Then
                intHighest = intNumbers(intCount)

            End If
        Next
        lblHighest.Text = intHighest.ToString
        'get the first low value
        intSmallest = intNumbers(intMAX_SUBSCRIPT)
        'search for the lowest value
        For intCount = 0 To (intNumbers.Length - 1)
            InitializeComponent intNumbers(intCount) < intSmallest Then
            intSmallest = intNumbers(intCount)
            End If 
        Next
        lblLowest.Text = intSmallest.ToString
        'Calculate the Total of the Values
        For intCount = 0 To (intNumbers.Length - 1)
            intTotal += intNumbers(intCount)

        Next
        'calculate the average
        dblAverage = intTotal / intNumbers.Length
        lblAverage.Text = dblAverage.ToString
        lblTotal.Text = intTotal.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Clear function
        lstValues.Items.Clear()
        lblHighest.Text = String.Empty
        lblLowest.Text = String.Empty
        lblTotal.Text = String.Empty
        lblAverage.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnInputValues_Click(sender As Object, e As EventArgs) Handles btnInputValues.Click
        'Create an array to hold the 10 numbers
        Const intMAX_SUBSCRIPT As Integer = 9 'The maximum subscript
        Dim intNumbers(intMAX_SUBSCRIPT) As Integer 'array declaration
        Dim intCount As Integer 'Loop Count
        'Tells the user waht will happen 
        MessageBox.Show ("An input box will appear, please enter 10 numbers 
                         (one after another) into the input boxes.")
        Try
            'get the numbers from the user
            For intCount = 0 To intMAX_SUBSCRIPT
                intNumbers(intCount) = InputBox("Enter a number.")
            Next
            'Clear the list box of its current contents
            lstValues.Items.Clear()
            'Display the contents of the array in the list box.
            For intCount = 0 To intMAX_SUBSCRIPT
                lstValues.Items.Add(intNumbers(intCount))
            Next
        Catch
            MessageBox.Show("Input Numeric Values only", "ERROR")
        End Try
    End Sub
End Class
