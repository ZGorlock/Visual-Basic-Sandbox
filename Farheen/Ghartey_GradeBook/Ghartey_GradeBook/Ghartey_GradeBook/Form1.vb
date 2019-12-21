'Farheen Ghartey
'11/17/2015
'Grade book
'Display student names and their test scores
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim studentNames(4) As String
        Dim Grades(4) As String
        Dim Student1Scores(3) As Integer
        Dim Student2Scores(3) As Integer
        Dim Student3Scores(3) As Integer
        Dim Student4Scores(3) As Integer
        Dim Student5Scores(3) As Integer
        Dim intCount As Integer = 0
        Dim StudentAVG(4) As Double
        lstGrades.Items.Clear()

        Try
            studentNames(0) = txtStudent1.Text
            studentNames(1) = txtStudent2.Text
            studentNames(2) = txtStudent3.Text
            studentNames(3) = txtStudent4.Text
            studentNames(4) = txtStudent5.Text
            Student1Scores(0) = CInt(IsValid(CInt(txtOneScore1.Text)))
            Student1Scores(1) = CInt(IsValid(CInt(txtTwoScore1.Text)))
            Student1Scores(2) = CInt(IsValid(CInt(txtThreeScore1.Text)))
            Student1Scores(3) = CInt(IsValid(CInt(txtFourScore1.Text)))

            Student2Scores(0) = CInt(IsValid(CInt(txtOneScore1.Text)))
            Student2Scores(1) = CInt(IsValid(CInt(txtTwoScore1.Text)))
            Student2Scores(2) = CInt(IsValid(CInt(txtThreeScore1.Text)))
            Student2Scores(3) = CInt(IsValid(CInt(txtFourScore1.Text)))
            Student3Scores(0) =
                CInt(IsValid(CInt(txtThreeScore1.Text)))
            Student3Scores(1) =
                CInt(IsValid(CInt(txtThreeScore2.Text)))
            Student3Scores(2) =
                CInt(IsValid(CInt(txtThreeScore3.Text)))
            Student3Scores(3) =

            IsValid(CInt(txtThreeScore4.Text))
            Student4Scores(0) = CInt(IsValid(CInt(txtFourScore1.Text)))
            Student4Scores(1) = CInt(IsValid(CInt(txtFourScore2.Text)))
            Student4Scores(2) = CInt(IsValid(CInt(txtFourScore3.Text)))
            Student4Scores(3) = CInt(IsValid(CInt(txtFourScore4.Text)))

            Student5Scores(0) = CInt(IsValid(CInt(txtFiveScore1.Text)))
            Student5Scores(1) = CInt(IsValid(CInt(txtFiveScore2.Text)))

            Student5Scores(2) = CInt(IsValid(CInt(txtFiveScore3.Text)))
            Student5Scores(3) = CInt(IsValid(CInt(txtFiveScore4.Text)))
            StudentAVG(0) = CDbl(getAverage(Student1Scores))
            StudentAVG(1) = CDbl(getAverage(Student2Scores))
            StudentAVG(2) = CDbl(getAverage(Student3Scores))
            StudentAVG(3) = CDbl(getAverage(Student4Scores))
            StudentAVG(4) = CDbl(getAverage(Student5Scores))

            For intCount = 0 To 4
                If Student1ScoresAVG(intCount) >= 90 Then
                    Grades(intCount) = "A"
                ElseIf StudentAVG(intCount) >= 80 Then
                    Grades(intCount) = "B"
                ElseIf StudentAVG(intCount) >= 70 Then
                    Grades(intCount) = "C"
                ElseIf StudentAVG(intCount) >= 60 Then
                    Grades(intCount) = "D"
                ElseIf StudentAVG(intCount) >= 0 Then
                    Grades(intCount) = "F"
                End If
            Next
            For intCount = 0 To 4
                lstGrades.Items.Add("Average Score for "&
                                    studentNames(intCount) & " is " & StudentAVG(intCount) & "his Grade is "
                                    & Grades(intCount))

            Next

        Catch

            MessageBox.Show("Invalid Input: Enter Values between (0-100)", "Error")

        End Try
    End Sub

    Public Function getAverage(ByVal StudentScores() As Integer)
        Dim intTotal, intCount As Integer
        Dim dblAverage As Double
        For intCount = 0 To 3
            intTotal += StudentScores(intCount)
        Next
        dblAverage = intTotal / 4
        Return dblAverage
    End Function
    Public Function IsValid(ByVal intNum As Integer)

        If intNum > 0 And intNum <= 100 Then
            Return intNum
        Else
            Return "Error"
        End If
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrades.SelectedIndexChanged

    End Sub

    Private Function Student1ScoresAVG(intCount As Integer) As Integer
        Throw New NotImplementedException
    End Function

End Class
