<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.grpShape = New System.Windows.Forms.GroupBox()
        Me.Sq = New System.Windows.Forms.RadioButton()
        Me.Rd = New System.Windows.Forms.RadioButton()
        Me.lblNumSlices = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDiameter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.grpShape.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtWidth)
        Me.GroupBox2.Controls.Add(Me.txtLength)
        Me.GroupBox2.Controls.Add(Me.lblWidth)
        Me.GroupBox2.Controls.Add(Me.lblLength)
        Me.GroupBox2.Location = New System.Drawing.Point(261, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 96)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Square Pizza"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(115, 50)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 3
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(115, 19)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 2
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(19, 57)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 1
        Me.lblWidth.Text = "Width:"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(19, 26)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(43, 13)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "Length:"
        '
        'grpShape
        '
        Me.grpShape.Controls.Add(Me.Sq)
        Me.grpShape.Controls.Add(Me.Rd)
        Me.grpShape.Location = New System.Drawing.Point(12, 124)
        Me.grpShape.Name = "grpShape"
        Me.grpShape.Size = New System.Drawing.Size(144, 100)
        Me.grpShape.TabIndex = 7
        Me.grpShape.TabStop = False
        Me.grpShape.Text = "Pizza Shape"
        '
        'Sq
        '
        Me.Sq.AutoSize = True
        Me.Sq.Checked = True
        Me.Sq.Location = New System.Drawing.Point(33, 33)
        Me.Sq.Name = "Sq"
        Me.Sq.Size = New System.Drawing.Size(59, 17)
        Me.Sq.TabIndex = 2
        Me.Sq.TabStop = True
        Me.Sq.Text = "Square"
        Me.Sq.UseVisualStyleBackColor = True
        '
        'Rd
        '
        Me.Rd.AutoSize = True
        Me.Rd.Location = New System.Drawing.Point(33, 56)
        Me.Rd.Name = "Rd"
        Me.Rd.Size = New System.Drawing.Size(57, 17)
        Me.Rd.TabIndex = 1
        Me.Rd.Text = "Round"
        Me.Rd.UseVisualStyleBackColor = True
        '
        'lblNumSlices
        '
        Me.lblNumSlices.Location = New System.Drawing.Point(345, 154)
        Me.lblNumSlices.Name = "lblNumSlices"
        Me.lblNumSlices.ReadOnly = True
        Me.lblNumSlices.Size = New System.Drawing.Size(131, 20)
        Me.lblNumSlices.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Number of Slices:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(220, 201)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(324, 201)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(421, 201)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDiameter)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 96)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Round Pizza"
        '
        'txtDiameter
        '
        Me.txtDiameter.Location = New System.Drawing.Point(87, 23)
        Me.txtDiameter.Name = "txtDiameter"
        Me.txtDiameter.Size = New System.Drawing.Size(100, 20)
        Me.txtDiameter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diameter:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 241)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNumSlices)
        Me.Controls.Add(Me.grpShape)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Pizza Slice Calculator"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpShape.ResumeLayout(False)
        Me.grpShape.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents grpShape As System.Windows.Forms.GroupBox
    Friend WithEvents Sq As System.Windows.Forms.RadioButton
    Friend WithEvents Rd As System.Windows.Forms.RadioButton
    Friend WithEvents lblNumSlices As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiameter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
