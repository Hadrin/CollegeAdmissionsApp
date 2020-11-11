'Programmer: David McGinley
'Purpose: To create a tool which can determine whether to admit a student
'Date created: 10/23
'Date submitted: TBD
Option Strict On

Public Class frmAdmissions
    Dim GPApoints, SATpoints, HSpoints, Curriculumpoints, Locationpoints, Alumnipoints, Athletepoints, Totalpoints As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Calculate()
    End Sub

    Sub Calculate()
        GPApoints = CInt(CDbl(txtGPA.Text) * 20)

        If rdbSATLowest.Checked Then
            SATpoints = 0
        ElseIf rdbSATLow.Checked Then
            SATpoints = 2
        ElseIf rdbSATMedium.Checked Then
            SATpoints = 4
        ElseIf rdbSAThigh.Checked Then
            SATpoints = 6
        Else
            SATpoints = 8
        End If

        If rdbHS0.Checked Then
            HSpoints = 0
        ElseIf rdbHS1.Checked Then
            HSpoints = 2
        ElseIf rdbHS2.Checked Then
            HSpoints = 4
        ElseIf rdbHS3.Checked Then
            HSpoints = 6
        ElseIf rdbHS4.Checked Then
            HSpoints = 8
        ElseIf rdbHS5.Checked Then
            HSpoints = 10
        End If

        If rdbCurriculumMinus2.Checked Then
            Curriculumpoints = -4
        ElseIf rdbCurriculumMinus1.Checked Then
            Curriculumpoints = -2
        ElseIf rdbCurriculum0.Checked Then
            Curriculumpoints = 0
        ElseIf rdbCurriculum0.Checked Then
            Curriculumpoints = 2
        ElseIf rdbCurriculum2.Checked Then
            Curriculumpoints = 4
        ElseIf rdbCurriculum3.Checked Then
            Curriculumpoints = 6
        Else
            Curriculumpoints = 8
        End If

        If rdbInState.Checked Then
            Locationpoints = 10
        Else
            Locationpoints = 0
        End If

        If rdbAlumni.Checked Then
            Alumnipoints = 10
        Else
            Alumnipoints = 0
        End If

        If rdbAthlete.Checked Then
            Athletepoints = 10
        Else
            Alumnipoints = 0
        End If

        Totalpoints = GPApoints + SATpoints + HSpoints + Curriculumpoints + Locationpoints + Alumnipoints + Athletepoints

        If Totalpoints >= 100 Then
            txtAccepted.Text = Totalpoints.ToString & " of 100 required points." & vbCrLf & "Accepted"
        Else
            txtAccepted.Text = Totalpoints.ToString & " of 100 required points." & vbCrLf & "Not accepted"
        End If

    End Sub

    Private Sub txtGPA_LostFocus(sender As Object, e As EventArgs) Handles txtGPA.LostFocus
        Calculate()
    End Sub

End Class