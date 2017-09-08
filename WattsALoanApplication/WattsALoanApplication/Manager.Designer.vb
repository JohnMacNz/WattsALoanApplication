<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txbEmpNum = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEmpNum = New System.Windows.Forms.Label()
        Me.txbSalary = New System.Windows.Forms.TextBox()
        Me.txbTitle = New System.Windows.Forms.TextBox()
        Me.txbLName = New System.Windows.Forms.TextBox()
        Me.txbFName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbCreateLoanType = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbEmpNumMod = New System.Windows.Forms.TextBox()
        Me.txbFNameMod = New System.Windows.Forms.TextBox()
        Me.txbSalaryMod = New System.Windows.Forms.TextBox()
        Me.txbLNameMod = New System.Windows.Forms.TextBox()
        Me.txbTitleMod = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Delete Emp"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 357)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'txbEmpNum
        '
        Me.txbEmpNum.Location = New System.Drawing.Point(173, 22)
        Me.txbEmpNum.Name = "txbEmpNum"
        Me.txbEmpNum.Size = New System.Drawing.Size(100, 20)
        Me.txbEmpNum.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Create Emp"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(162, 22)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 148)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.lblSalary)
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.lblLName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblEmpNum)
        Me.GroupBox2.Controls.Add(Me.txbSalary)
        Me.GroupBox2.Controls.Add(Me.txbTitle)
        Me.GroupBox2.Controls.Add(Me.txbLName)
        Me.GroupBox2.Controls.Add(Me.txbFName)
        Me.GroupBox2.Controls.Add(Me.txbEmpNum)
        Me.GroupBox2.Location = New System.Drawing.Point(414, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 216)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(98, 133)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(36, 13)
        Me.lblSalary.TabIndex = 15
        Me.lblSalary.Text = "Salary"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(98, 104)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Title"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(98, 75)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(41, 13)
        Me.lblLName.TabIndex = 13
        Me.lblLName.Text = "LName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "FName"
        '
        'lblEmpNum
        '
        Me.lblEmpNum.AutoSize = True
        Me.lblEmpNum.Location = New System.Drawing.Point(98, 22)
        Me.lblEmpNum.Name = "lblEmpNum"
        Me.lblEmpNum.Size = New System.Drawing.Size(50, 13)
        Me.lblEmpNum.TabIndex = 11
        Me.lblEmpNum.Text = "EmpNum"
        '
        'txbSalary
        '
        Me.txbSalary.Location = New System.Drawing.Point(173, 126)
        Me.txbSalary.Name = "txbSalary"
        Me.txbSalary.Size = New System.Drawing.Size(100, 20)
        Me.txbSalary.TabIndex = 10
        '
        'txbTitle
        '
        Me.txbTitle.Location = New System.Drawing.Point(173, 101)
        Me.txbTitle.Name = "txbTitle"
        Me.txbTitle.Size = New System.Drawing.Size(100, 20)
        Me.txbTitle.TabIndex = 9
        '
        'txbLName
        '
        Me.txbLName.Location = New System.Drawing.Point(173, 75)
        Me.txbLName.Name = "txbLName"
        Me.txbLName.Size = New System.Drawing.Size(100, 20)
        Me.txbLName.TabIndex = 8
        '
        'txbFName
        '
        Me.txbFName.Location = New System.Drawing.Point(173, 49)
        Me.txbFName.Name = "txbFName"
        Me.txbFName.Size = New System.Drawing.Size(100, 20)
        Me.txbFName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Result"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txbCreateLoanType)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 237)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(273, 80)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "LoanType"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txbCreateLoanType
        '
        Me.txbCreateLoanType.Location = New System.Drawing.Point(162, 26)
        Me.txbCreateLoanType.Name = "txbCreateLoanType"
        Me.txbCreateLoanType.Size = New System.Drawing.Size(100, 20)
        Me.txbCreateLoanType.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Create Loan Type"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txbEmployeeID)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txbEmpNumMod)
        Me.GroupBox4.Controls.Add(Me.txbFNameMod)
        Me.GroupBox4.Controls.Add(Me.txbSalaryMod)
        Me.GroupBox4.Controls.Add(Me.txbLNameMod)
        Me.GroupBox4.Controls.Add(Me.txbTitleMod)
        Me.GroupBox4.Location = New System.Drawing.Point(414, 237)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(383, 246)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Emp ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Salary"
        '
        'txbEmployeeID
        '
        Me.txbEmployeeID.Location = New System.Drawing.Point(173, 19)
        Me.txbEmployeeID.Name = "txbEmployeeID"
        Me.txbEmployeeID.Size = New System.Drawing.Size(100, 20)
        Me.txbEmployeeID.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Title"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(0, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Modify"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "LName"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(98, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "EmpNum"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(98, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "FName"
        '
        'txbEmpNumMod
        '
        Me.txbEmpNumMod.Location = New System.Drawing.Point(173, 45)
        Me.txbEmpNumMod.Name = "txbEmpNumMod"
        Me.txbEmpNumMod.Size = New System.Drawing.Size(100, 20)
        Me.txbEmpNumMod.TabIndex = 16
        '
        'txbFNameMod
        '
        Me.txbFNameMod.Location = New System.Drawing.Point(173, 72)
        Me.txbFNameMod.Name = "txbFNameMod"
        Me.txbFNameMod.Size = New System.Drawing.Size(100, 20)
        Me.txbFNameMod.TabIndex = 17
        '
        'txbSalaryMod
        '
        Me.txbSalaryMod.Location = New System.Drawing.Point(173, 149)
        Me.txbSalaryMod.Name = "txbSalaryMod"
        Me.txbSalaryMod.Size = New System.Drawing.Size(100, 20)
        Me.txbSalaryMod.TabIndex = 20
        '
        'txbLNameMod
        '
        Me.txbLNameMod.Location = New System.Drawing.Point(173, 98)
        Me.txbLNameMod.Name = "txbLNameMod"
        Me.txbLNameMod.Size = New System.Drawing.Size(100, 20)
        Me.txbLNameMod.TabIndex = 18
        '
        'txbTitleMod
        '
        Me.txbTitleMod.Location = New System.Drawing.Point(173, 124)
        Me.txbTitleMod.Name = "txbTitleMod"
        Me.txbTitleMod.Size = New System.Drawing.Size(100, 20)
        Me.txbTitleMod.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(101, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "User ID"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 478)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Manager"
        Me.Text = "Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txbEmpNum As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEmpNum As System.Windows.Forms.Label
    Friend WithEvents txbSalary As System.Windows.Forms.TextBox
    Friend WithEvents txbTitle As System.Windows.Forms.TextBox
    Friend WithEvents txbLName As System.Windows.Forms.TextBox
    Friend WithEvents txbFName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txbCreateLoanType As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txbEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txbEmpNumMod As System.Windows.Forms.TextBox
    Friend WithEvents txbFNameMod As System.Windows.Forms.TextBox
    Friend WithEvents txbSalaryMod As System.Windows.Forms.TextBox
    Friend WithEvents txbLNameMod As System.Windows.Forms.TextBox
    Friend WithEvents txbTitleMod As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
