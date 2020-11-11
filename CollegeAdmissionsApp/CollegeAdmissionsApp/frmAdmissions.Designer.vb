<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmissions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grbSAT = New System.Windows.Forms.GroupBox()
        Me.rdbSATHighest = New System.Windows.Forms.RadioButton()
        Me.rdbSAThigh = New System.Windows.Forms.RadioButton()
        Me.rdbSATMedium = New System.Windows.Forms.RadioButton()
        Me.rdbSATLow = New System.Windows.Forms.RadioButton()
        Me.rdbSATLowest = New System.Windows.Forms.RadioButton()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.txtGPA = New System.Windows.Forms.MaskedTextBox()
        Me.grbHS = New System.Windows.Forms.GroupBox()
        Me.rdbHS5 = New System.Windows.Forms.RadioButton()
        Me.rdbHS4 = New System.Windows.Forms.RadioButton()
        Me.rdbHS3 = New System.Windows.Forms.RadioButton()
        Me.rdbHS2 = New System.Windows.Forms.RadioButton()
        Me.rdbHS1 = New System.Windows.Forms.RadioButton()
        Me.rdbHS0 = New System.Windows.Forms.RadioButton()
        Me.grbCurriculum = New System.Windows.Forms.GroupBox()
        Me.rdbCurriculum4 = New System.Windows.Forms.RadioButton()
        Me.rdbCurriculum3 = New System.Windows.Forms.RadioButton()
        Me.rdbCurriculum2 = New System.Windows.Forms.RadioButton()
        Me.rdbCurriculum1 = New System.Windows.Forms.RadioButton()
        Me.rdbCurriculum0 = New System.Windows.Forms.RadioButton()
        Me.rdbCurriculumMinus1 = New System.Windows.Forms.RadioButton()
        Me.rdbCurriculumMinus2 = New System.Windows.Forms.RadioButton()
        Me.grbLocation = New System.Windows.Forms.GroupBox()
        Me.rdbOutOfState = New System.Windows.Forms.RadioButton()
        Me.rdbInState = New System.Windows.Forms.RadioButton()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.grbAlumni = New System.Windows.Forms.GroupBox()
        Me.rdbNoAlumni = New System.Windows.Forms.RadioButton()
        Me.rdbAlumni = New System.Windows.Forms.RadioButton()
        Me.grbAthlete = New System.Windows.Forms.GroupBox()
        Me.rdbNotAthlete = New System.Windows.Forms.RadioButton()
        Me.rdbAthlete = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAccepted = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grbSAT.SuspendLayout()
        Me.grbHS.SuspendLayout()
        Me.grbCurriculum.SuspendLayout()
        Me.grbLocation.SuspendLayout()
        Me.grbAlumni.SuspendLayout()
        Me.grbAthlete.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbSAT
        '
        Me.grbSAT.Controls.Add(Me.rdbSATHighest)
        Me.grbSAT.Controls.Add(Me.rdbSAThigh)
        Me.grbSAT.Controls.Add(Me.rdbSATMedium)
        Me.grbSAT.Controls.Add(Me.rdbSATLow)
        Me.grbSAT.Controls.Add(Me.rdbSATLowest)
        Me.grbSAT.Location = New System.Drawing.Point(16, 41)
        Me.grbSAT.Name = "grbSAT"
        Me.grbSAT.Size = New System.Drawing.Size(108, 142)
        Me.grbSAT.TabIndex = 0
        Me.grbSAT.TabStop = False
        Me.grbSAT.Text = "SAT"
        '
        'rdbSATHighest
        '
        Me.rdbSATHighest.AutoSize = True
        Me.rdbSATHighest.Location = New System.Drawing.Point(6, 111)
        Me.rdbSATHighest.Name = "rdbSATHighest"
        Me.rdbSATHighest.Size = New System.Drawing.Size(103, 17)
        Me.rdbSATHighest.TabIndex = 4
        Me.rdbSATHighest.Text = "1360 - 1600 [12]"
        Me.rdbSATHighest.UseVisualStyleBackColor = True
        '
        'rdbSAThigh
        '
        Me.rdbSAThigh.AutoSize = True
        Me.rdbSAThigh.Location = New System.Drawing.Point(6, 88)
        Me.rdbSAThigh.Name = "rdbSAThigh"
        Me.rdbSAThigh.Size = New System.Drawing.Size(103, 17)
        Me.rdbSAThigh.TabIndex = 4
        Me.rdbSAThigh.Text = "1200 - 1350 [11]"
        Me.rdbSAThigh.UseVisualStyleBackColor = True
        '
        'rdbSATMedium
        '
        Me.rdbSATMedium.AutoSize = True
        Me.rdbSATMedium.Location = New System.Drawing.Point(6, 65)
        Me.rdbSATMedium.Name = "rdbSATMedium"
        Me.rdbSATMedium.Size = New System.Drawing.Size(103, 17)
        Me.rdbSATMedium.TabIndex = 4
        Me.rdbSATMedium.Text = "1010 - 1190 [10]"
        Me.rdbSATMedium.UseVisualStyleBackColor = True
        '
        'rdbSATLow
        '
        Me.rdbSATLow.AutoSize = True
        Me.rdbSATLow.Location = New System.Drawing.Point(6, 42)
        Me.rdbSATLow.Name = "rdbSATLow"
        Me.rdbSATLow.Size = New System.Drawing.Size(91, 17)
        Me.rdbSATLow.TabIndex = 1
        Me.rdbSATLow.Text = "930 - 1000 [6]"
        Me.rdbSATLow.UseVisualStyleBackColor = True
        '
        'rdbSATLowest
        '
        Me.rdbSATLowest.AutoSize = True
        Me.rdbSATLowest.Checked = True
        Me.rdbSATLowest.Location = New System.Drawing.Point(6, 19)
        Me.rdbSATLowest.Name = "rdbSATLowest"
        Me.rdbSATLowest.Size = New System.Drawing.Size(85, 17)
        Me.rdbSATLowest.TabIndex = 0
        Me.rdbSATLowest.TabStop = True
        Me.rdbSATLowest.Text = "400 - 920 [0]"
        Me.rdbSATLowest.UseVisualStyleBackColor = True
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPA.Location = New System.Drawing.Point(12, 9)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(54, 24)
        Me.lblGPA.TabIndex = 2
        Me.lblGPA.Text = "GPA:"
        '
        'txtGPA
        '
        Me.txtGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGPA.Location = New System.Drawing.Point(72, 6)
        Me.txtGPA.Mask = "#.##"
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(49, 29)
        Me.txtGPA.TabIndex = 3
        Me.txtGPA.Text = "000"
        '
        'grbHS
        '
        Me.grbHS.Controls.Add(Me.rdbHS5)
        Me.grbHS.Controls.Add(Me.rdbHS4)
        Me.grbHS.Controls.Add(Me.rdbHS3)
        Me.grbHS.Controls.Add(Me.rdbHS2)
        Me.grbHS.Controls.Add(Me.rdbHS1)
        Me.grbHS.Controls.Add(Me.rdbHS0)
        Me.grbHS.Location = New System.Drawing.Point(131, 41)
        Me.grbHS.Name = "grbHS"
        Me.grbHS.Size = New System.Drawing.Size(132, 142)
        Me.grbHS.TabIndex = 5
        Me.grbHS.TabStop = False
        Me.grbHS.Text = "High School Quality"
        '
        'rdbHS5
        '
        Me.rdbHS5.AutoSize = True
        Me.rdbHS5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbHS5.Location = New System.Drawing.Point(67, 111)
        Me.rdbHS5.Name = "rdbHS5"
        Me.rdbHS5.Size = New System.Drawing.Size(66, 24)
        Me.rdbHS5.TabIndex = 6
        Me.rdbHS5.Text = "5 [10]"
        Me.rdbHS5.UseVisualStyleBackColor = True
        '
        'rdbHS4
        '
        Me.rdbHS4.AutoSize = True
        Me.rdbHS4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbHS4.Location = New System.Drawing.Point(67, 65)
        Me.rdbHS4.Name = "rdbHS4"
        Me.rdbHS4.Size = New System.Drawing.Size(57, 24)
        Me.rdbHS4.TabIndex = 6
        Me.rdbHS4.Text = "4 [8]"
        Me.rdbHS4.UseVisualStyleBackColor = True
        '
        'rdbHS3
        '
        Me.rdbHS3.AutoSize = True
        Me.rdbHS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbHS3.Location = New System.Drawing.Point(67, 19)
        Me.rdbHS3.Name = "rdbHS3"
        Me.rdbHS3.Size = New System.Drawing.Size(57, 24)
        Me.rdbHS3.TabIndex = 6
        Me.rdbHS3.Text = "3 [6]"
        Me.rdbHS3.UseVisualStyleBackColor = True
        '
        'rdbHS2
        '
        Me.rdbHS2.AutoSize = True
        Me.rdbHS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbHS2.Location = New System.Drawing.Point(6, 111)
        Me.rdbHS2.Name = "rdbHS2"
        Me.rdbHS2.Size = New System.Drawing.Size(57, 24)
        Me.rdbHS2.TabIndex = 2
        Me.rdbHS2.Text = "2 [4]"
        Me.rdbHS2.UseVisualStyleBackColor = True
        '
        'rdbHS1
        '
        Me.rdbHS1.AutoSize = True
        Me.rdbHS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbHS1.Location = New System.Drawing.Point(6, 65)
        Me.rdbHS1.Name = "rdbHS1"
        Me.rdbHS1.Size = New System.Drawing.Size(57, 24)
        Me.rdbHS1.TabIndex = 1
        Me.rdbHS1.Text = "1 [2]"
        Me.rdbHS1.UseVisualStyleBackColor = True
        '
        'rdbHS0
        '
        Me.rdbHS0.AutoSize = True
        Me.rdbHS0.Checked = True
        Me.rdbHS0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbHS0.Location = New System.Drawing.Point(6, 19)
        Me.rdbHS0.Name = "rdbHS0"
        Me.rdbHS0.Size = New System.Drawing.Size(57, 24)
        Me.rdbHS0.TabIndex = 0
        Me.rdbHS0.TabStop = True
        Me.rdbHS0.Text = "0 [0]"
        Me.rdbHS0.UseVisualStyleBackColor = True
        '
        'grbCurriculum
        '
        Me.grbCurriculum.Controls.Add(Me.rdbCurriculum4)
        Me.grbCurriculum.Controls.Add(Me.rdbCurriculum3)
        Me.grbCurriculum.Controls.Add(Me.rdbCurriculum2)
        Me.grbCurriculum.Controls.Add(Me.rdbCurriculum1)
        Me.grbCurriculum.Controls.Add(Me.rdbCurriculum0)
        Me.grbCurriculum.Controls.Add(Me.rdbCurriculumMinus1)
        Me.grbCurriculum.Controls.Add(Me.rdbCurriculumMinus2)
        Me.grbCurriculum.Location = New System.Drawing.Point(269, 41)
        Me.grbCurriculum.Name = "grbCurriculum"
        Me.grbCurriculum.Size = New System.Drawing.Size(132, 142)
        Me.grbCurriculum.TabIndex = 7
        Me.grbCurriculum.TabStop = False
        Me.grbCurriculum.Text = "High School Quality"
        '
        'rdbCurriculum4
        '
        Me.rdbCurriculum4.AutoSize = True
        Me.rdbCurriculum4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbCurriculum4.Location = New System.Drawing.Point(70, 88)
        Me.rdbCurriculum4.Name = "rdbCurriculum4"
        Me.rdbCurriculum4.Size = New System.Drawing.Size(57, 24)
        Me.rdbCurriculum4.TabIndex = 8
        Me.rdbCurriculum4.Text = "4 [8]"
        Me.rdbCurriculum4.UseVisualStyleBackColor = True
        '
        'rdbCurriculum3
        '
        Me.rdbCurriculum3.AutoSize = True
        Me.rdbCurriculum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbCurriculum3.Location = New System.Drawing.Point(70, 53)
        Me.rdbCurriculum3.Name = "rdbCurriculum3"
        Me.rdbCurriculum3.Size = New System.Drawing.Size(57, 24)
        Me.rdbCurriculum3.TabIndex = 9
        Me.rdbCurriculum3.Text = "3 [6]"
        Me.rdbCurriculum3.UseVisualStyleBackColor = True
        '
        'rdbCurriculum2
        '
        Me.rdbCurriculum2.AutoSize = True
        Me.rdbCurriculum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCurriculum2.Location = New System.Drawing.Point(70, 19)
        Me.rdbCurriculum2.Name = "rdbCurriculum2"
        Me.rdbCurriculum2.Size = New System.Drawing.Size(57, 24)
        Me.rdbCurriculum2.TabIndex = 8
        Me.rdbCurriculum2.Text = "2 [4]"
        Me.rdbCurriculum2.UseVisualStyleBackColor = True
        '
        'rdbCurriculum1
        '
        Me.rdbCurriculum1.AutoSize = True
        Me.rdbCurriculum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbCurriculum1.Location = New System.Drawing.Point(6, 119)
        Me.rdbCurriculum1.Name = "rdbCurriculum1"
        Me.rdbCurriculum1.Size = New System.Drawing.Size(57, 24)
        Me.rdbCurriculum1.TabIndex = 3
        Me.rdbCurriculum1.Text = "1 [2]"
        Me.rdbCurriculum1.UseVisualStyleBackColor = True
        '
        'rdbCurriculum0
        '
        Me.rdbCurriculum0.AutoSize = True
        Me.rdbCurriculum0.Checked = True
        Me.rdbCurriculum0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbCurriculum0.Location = New System.Drawing.Point(6, 88)
        Me.rdbCurriculum0.Name = "rdbCurriculum0"
        Me.rdbCurriculum0.Size = New System.Drawing.Size(57, 24)
        Me.rdbCurriculum0.TabIndex = 2
        Me.rdbCurriculum0.TabStop = True
        Me.rdbCurriculum0.Text = "0 [0]"
        Me.rdbCurriculum0.UseVisualStyleBackColor = True
        '
        'rdbCurriculumMinus1
        '
        Me.rdbCurriculumMinus1.AutoSize = True
        Me.rdbCurriculumMinus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbCurriculumMinus1.Location = New System.Drawing.Point(6, 53)
        Me.rdbCurriculumMinus1.Name = "rdbCurriculumMinus1"
        Me.rdbCurriculumMinus1.Size = New System.Drawing.Size(67, 24)
        Me.rdbCurriculumMinus1.TabIndex = 1
        Me.rdbCurriculumMinus1.Text = "-1 [-2]"
        Me.rdbCurriculumMinus1.UseVisualStyleBackColor = True
        '
        'rdbCurriculumMinus2
        '
        Me.rdbCurriculumMinus2.AutoSize = True
        Me.rdbCurriculumMinus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbCurriculumMinus2.Location = New System.Drawing.Point(6, 19)
        Me.rdbCurriculumMinus2.Name = "rdbCurriculumMinus2"
        Me.rdbCurriculumMinus2.Size = New System.Drawing.Size(67, 24)
        Me.rdbCurriculumMinus2.TabIndex = 0
        Me.rdbCurriculumMinus2.Text = "-2 [-4]"
        Me.rdbCurriculumMinus2.UseVisualStyleBackColor = True
        '
        'grbLocation
        '
        Me.grbLocation.Controls.Add(Me.rdbOutOfState)
        Me.grbLocation.Controls.Add(Me.rdbInState)
        Me.grbLocation.Location = New System.Drawing.Point(16, 202)
        Me.grbLocation.Name = "grbLocation"
        Me.grbLocation.Size = New System.Drawing.Size(146, 69)
        Me.grbLocation.TabIndex = 10
        Me.grbLocation.TabStop = False
        Me.grbLocation.Text = "Location"
        '
        'rdbOutOfState
        '
        Me.rdbOutOfState.AutoSize = True
        Me.rdbOutOfState.Checked = True
        Me.rdbOutOfState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbOutOfState.Location = New System.Drawing.Point(6, 42)
        Me.rdbOutOfState.Name = "rdbOutOfState"
        Me.rdbOutOfState.Size = New System.Drawing.Size(135, 24)
        Me.rdbOutOfState.TabIndex = 1
        Me.rdbOutOfState.TabStop = True
        Me.rdbOutOfState.Text = "Out of State [0]"
        Me.rdbOutOfState.UseVisualStyleBackColor = True
        '
        'rdbInState
        '
        Me.rdbInState.AutoSize = True
        Me.rdbInState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbInState.Location = New System.Drawing.Point(6, 19)
        Me.rdbInState.Name = "rdbInState"
        Me.rdbInState.Size = New System.Drawing.Size(114, 24)
        Me.rdbInState.TabIndex = 0
        Me.rdbInState.Text = "In State [10]"
        Me.rdbInState.UseVisualStyleBackColor = True
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(19, 186)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(559, 13)
        Me.lblLine.TabIndex = 11
        Me.lblLine.Text = "---------------------------------------------------------------------------------" &
    "--------------------------------------------------------------------------------" &
    "-----------------------"
        '
        'grbAlumni
        '
        Me.grbAlumni.Controls.Add(Me.rdbNoAlumni)
        Me.grbAlumni.Controls.Add(Me.rdbAlumni)
        Me.grbAlumni.Location = New System.Drawing.Point(168, 202)
        Me.grbAlumni.Name = "grbAlumni"
        Me.grbAlumni.Size = New System.Drawing.Size(168, 69)
        Me.grbAlumni.TabIndex = 11
        Me.grbAlumni.TabStop = False
        Me.grbAlumni.Text = "Alumni"
        '
        'rdbNoAlumni
        '
        Me.rdbNoAlumni.AutoSize = True
        Me.rdbNoAlumni.Checked = True
        Me.rdbNoAlumni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbNoAlumni.Location = New System.Drawing.Point(6, 42)
        Me.rdbNoAlumni.Name = "rdbNoAlumni"
        Me.rdbNoAlumni.Size = New System.Drawing.Size(157, 24)
        Me.rdbNoAlumni.TabIndex = 1
        Me.rdbNoAlumni.TabStop = True
        Me.rdbNoAlumni.Text = "No Family Alum [0]"
        Me.rdbNoAlumni.UseVisualStyleBackColor = True
        '
        'rdbAlumni
        '
        Me.rdbAlumni.AutoSize = True
        Me.rdbAlumni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbAlumni.Location = New System.Drawing.Point(6, 19)
        Me.rdbAlumni.Name = "rdbAlumni"
        Me.rdbAlumni.Size = New System.Drawing.Size(154, 24)
        Me.rdbAlumni.TabIndex = 0
        Me.rdbAlumni.Text = "Family Alumni [10]"
        Me.rdbAlumni.UseVisualStyleBackColor = True
        '
        'grbAthlete
        '
        Me.grbAthlete.Controls.Add(Me.rdbNotAthlete)
        Me.grbAthlete.Controls.Add(Me.rdbAthlete)
        Me.grbAthlete.Location = New System.Drawing.Point(342, 202)
        Me.grbAthlete.Name = "grbAthlete"
        Me.grbAthlete.Size = New System.Drawing.Size(132, 69)
        Me.grbAthlete.TabIndex = 12
        Me.grbAthlete.TabStop = False
        Me.grbAthlete.Text = "Athlete"
        '
        'rdbNotAthlete
        '
        Me.rdbNotAthlete.AutoSize = True
        Me.rdbNotAthlete.Checked = True
        Me.rdbNotAthlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbNotAthlete.Location = New System.Drawing.Point(6, 42)
        Me.rdbNotAthlete.Name = "rdbNotAthlete"
        Me.rdbNotAthlete.Size = New System.Drawing.Size(128, 24)
        Me.rdbNotAthlete.TabIndex = 1
        Me.rdbNotAthlete.TabStop = True
        Me.rdbNotAthlete.Text = "Not Athlete [0]"
        Me.rdbNotAthlete.UseVisualStyleBackColor = True
        '
        'rdbAthlete
        '
        Me.rdbAthlete.AutoSize = True
        Me.rdbAthlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rdbAthlete.Location = New System.Drawing.Point(6, 19)
        Me.rdbAthlete.Name = "rdbAthlete"
        Me.rdbAthlete.Size = New System.Drawing.Size(108, 24)
        Me.rdbAthlete.TabIndex = 0
        Me.rdbAthlete.Text = "Athlete [10]"
        Me.rdbAthlete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(480, 202)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 69)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAccepted
        '
        Me.txtAccepted.Enabled = False
        Me.txtAccepted.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccepted.Location = New System.Drawing.Point(408, 76)
        Me.txtAccepted.Multiline = True
        Me.txtAccepted.Name = "txtAccepted"
        Me.txtAccepted.Size = New System.Drawing.Size(170, 107)
        Me.txtAccepted.TabIndex = 14
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(408, 12)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(170, 52)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmAdmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 281)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtAccepted)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grbAthlete)
        Me.Controls.Add(Me.grbAlumni)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.grbLocation)
        Me.Controls.Add(Me.grbCurriculum)
        Me.Controls.Add(Me.grbHS)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.grbSAT)
        Me.Name = "frmAdmissions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admissions"
        Me.grbSAT.ResumeLayout(False)
        Me.grbSAT.PerformLayout()
        Me.grbHS.ResumeLayout(False)
        Me.grbHS.PerformLayout()
        Me.grbCurriculum.ResumeLayout(False)
        Me.grbCurriculum.PerformLayout()
        Me.grbLocation.ResumeLayout(False)
        Me.grbLocation.PerformLayout()
        Me.grbAlumni.ResumeLayout(False)
        Me.grbAlumni.PerformLayout()
        Me.grbAthlete.ResumeLayout(False)
        Me.grbAthlete.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbSAT As GroupBox
    Friend WithEvents rdbSATLowest As RadioButton
    Friend WithEvents lblGPA As Label
    Friend WithEvents txtGPA As MaskedTextBox
    Friend WithEvents rdbSATHighest As RadioButton
    Friend WithEvents rdbSAThigh As RadioButton
    Friend WithEvents rdbSATMedium As RadioButton
    Friend WithEvents rdbSATLow As RadioButton
    Friend WithEvents grbHS As GroupBox
    Friend WithEvents rdbHS5 As RadioButton
    Friend WithEvents rdbHS4 As RadioButton
    Friend WithEvents rdbHS3 As RadioButton
    Friend WithEvents rdbHS2 As RadioButton
    Friend WithEvents rdbHS1 As RadioButton
    Friend WithEvents rdbHS0 As RadioButton
    Friend WithEvents grbCurriculum As GroupBox
    Friend WithEvents rdbCurriculumMinus2 As RadioButton
    Friend WithEvents rdbCurriculum4 As RadioButton
    Friend WithEvents rdbCurriculum3 As RadioButton
    Friend WithEvents rdbCurriculum2 As RadioButton
    Friend WithEvents rdbCurriculum1 As RadioButton
    Friend WithEvents rdbCurriculum0 As RadioButton
    Friend WithEvents rdbCurriculumMinus1 As RadioButton
    Friend WithEvents grbLocation As GroupBox
    Friend WithEvents rdbInState As RadioButton
    Friend WithEvents lblLine As Label
    Friend WithEvents rdbOutOfState As RadioButton
    Friend WithEvents grbAlumni As GroupBox
    Friend WithEvents rdbNoAlumni As RadioButton
    Friend WithEvents rdbAlumni As RadioButton
    Friend WithEvents grbAthlete As GroupBox
    Friend WithEvents rdbNotAthlete As RadioButton
    Friend WithEvents rdbAthlete As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAccepted As TextBox
    Friend WithEvents btnCalculate As Button
End Class
