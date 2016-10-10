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
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.txtAdultTicket = New System.Windows.Forms.TextBox()
        Me.txtChildPrice = New System.Windows.Forms.TextBox()
        Me.txtChildTickets = New System.Windows.Forms.TextBox()
        Me.txtGrossChild = New System.Windows.Forms.TextBox()
        Me.txtGrossRev = New System.Windows.Forms.TextBox()
        Me.txtNetAdult = New System.Windows.Forms.TextBox()
        Me.txtNetChild = New System.Windows.Forms.TextBox()
        Me.txtGrossAdult = New System.Windows.Forms.TextBox()
        Me.txtNetRev = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblAdultPrice = New System.Windows.Forms.Label()
        Me.lblAdultTicket = New System.Windows.Forms.Label()
        Me.lblChildPrice = New System.Windows.Forms.Label()
        Me.lblChildTicket = New System.Windows.Forms.Label()
        Me.grpAdultTickets = New System.Windows.Forms.GroupBox()
        Me.grpChildTickets = New System.Windows.Forms.GroupBox()
        Me.grpGrossRev = New System.Windows.Forms.GroupBox()
        Me.lblGrossRev = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGrossAdult = New System.Windows.Forms.Label()
        Me.grpNetRev = New System.Windows.Forms.GroupBox()
        Me.lblNetRev = New System.Windows.Forms.Label()
        Me.lblChild = New System.Windows.Forms.Label()
        Me.lblNetAdult = New System.Windows.Forms.Label()
        Me.grpAdultTickets.SuspendLayout()
        Me.grpChildTickets.SuspendLayout()
        Me.grpGrossRev.SuspendLayout()
        Me.grpNetRev.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(116, 47)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(120, 20)
        Me.txtAdultPrice.TabIndex = 0
        '
        'txtAdultTicket
        '
        Me.txtAdultTicket.Location = New System.Drawing.Point(116, 96)
        Me.txtAdultTicket.Name = "txtAdultTicket"
        Me.txtAdultTicket.Size = New System.Drawing.Size(120, 20)
        Me.txtAdultTicket.TabIndex = 1
        '
        'txtChildPrice
        '
        Me.txtChildPrice.Location = New System.Drawing.Point(125, 51)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(127, 20)
        Me.txtChildPrice.TabIndex = 2
        '
        'txtChildTickets
        '
        Me.txtChildTickets.Location = New System.Drawing.Point(125, 96)
        Me.txtChildTickets.Name = "txtChildTickets"
        Me.txtChildTickets.Size = New System.Drawing.Size(127, 20)
        Me.txtChildTickets.TabIndex = 3
        '
        'txtGrossChild
        '
        Me.txtGrossChild.Location = New System.Drawing.Point(141, 78)
        Me.txtGrossChild.Name = "txtGrossChild"
        Me.txtGrossChild.ReadOnly = True
        Me.txtGrossChild.Size = New System.Drawing.Size(105, 20)
        Me.txtGrossChild.TabIndex = 4
        '
        'txtGrossRev
        '
        Me.txtGrossRev.Location = New System.Drawing.Point(141, 124)
        Me.txtGrossRev.Name = "txtGrossRev"
        Me.txtGrossRev.ReadOnly = True
        Me.txtGrossRev.Size = New System.Drawing.Size(105, 20)
        Me.txtGrossRev.TabIndex = 5
        '
        'txtNetAdult
        '
        Me.txtNetAdult.Location = New System.Drawing.Point(160, 38)
        Me.txtNetAdult.Name = "txtNetAdult"
        Me.txtNetAdult.ReadOnly = True
        Me.txtNetAdult.Size = New System.Drawing.Size(105, 20)
        Me.txtNetAdult.TabIndex = 6
        '
        'txtNetChild
        '
        Me.txtNetChild.Location = New System.Drawing.Point(160, 78)
        Me.txtNetChild.Name = "txtNetChild"
        Me.txtNetChild.ReadOnly = True
        Me.txtNetChild.Size = New System.Drawing.Size(105, 20)
        Me.txtNetChild.TabIndex = 7
        '
        'txtGrossAdult
        '
        Me.txtGrossAdult.Location = New System.Drawing.Point(141, 34)
        Me.txtGrossAdult.Name = "txtGrossAdult"
        Me.txtGrossAdult.ReadOnly = True
        Me.txtGrossAdult.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGrossAdult.Size = New System.Drawing.Size(105, 20)
        Me.txtGrossAdult.TabIndex = 8
        '
        'txtNetRev
        '
        Me.txtNetRev.Location = New System.Drawing.Point(160, 133)
        Me.txtNetRev.Name = "txtNetRev"
        Me.txtNetRev.ReadOnly = True
        Me.txtNetRev.Size = New System.Drawing.Size(105, 20)
        Me.txtNetRev.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(64, 419)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 40)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate Ticket Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(228, 419)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(127, 40)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(397, 419)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 40)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblAdultPrice
        '
        Me.lblAdultPrice.AutoSize = True
        Me.lblAdultPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdultPrice.Location = New System.Drawing.Point(7, 54)
        Me.lblAdultPrice.Name = "lblAdultPrice"
        Me.lblAdultPrice.Size = New System.Drawing.Size(85, 13)
        Me.lblAdultPrice.TabIndex = 13
        Me.lblAdultPrice.Text = "Price per Ticket:"
        '
        'lblAdultTicket
        '
        Me.lblAdultTicket.AutoSize = True
        Me.lblAdultTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdultTicket.Location = New System.Drawing.Point(7, 103)
        Me.lblAdultTicket.Name = "lblAdultTicket"
        Me.lblAdultTicket.Size = New System.Drawing.Size(69, 13)
        Me.lblAdultTicket.TabIndex = 14
        Me.lblAdultTicket.Text = "Tickets Sold:"
        '
        'lblChildPrice
        '
        Me.lblChildPrice.AutoSize = True
        Me.lblChildPrice.Location = New System.Drawing.Point(21, 58)
        Me.lblChildPrice.Name = "lblChildPrice"
        Me.lblChildPrice.Size = New System.Drawing.Size(85, 13)
        Me.lblChildPrice.TabIndex = 15
        Me.lblChildPrice.Text = "Price per Ticket:"
        '
        'lblChildTicket
        '
        Me.lblChildTicket.AutoSize = True
        Me.lblChildTicket.Location = New System.Drawing.Point(21, 103)
        Me.lblChildTicket.Name = "lblChildTicket"
        Me.lblChildTicket.Size = New System.Drawing.Size(69, 13)
        Me.lblChildTicket.TabIndex = 16
        Me.lblChildTicket.Text = "Tickets Sold:"
        '
        'grpAdultTickets
        '
        Me.grpAdultTickets.Controls.Add(Me.txtAdultPrice)
        Me.grpAdultTickets.Controls.Add(Me.txtAdultTicket)
        Me.grpAdultTickets.Controls.Add(Me.lblAdultPrice)
        Me.grpAdultTickets.Controls.Add(Me.lblAdultTicket)
        Me.grpAdultTickets.Location = New System.Drawing.Point(13, 12)
        Me.grpAdultTickets.Name = "grpAdultTickets"
        Me.grpAdultTickets.Size = New System.Drawing.Size(261, 158)
        Me.grpAdultTickets.TabIndex = 23
        Me.grpAdultTickets.TabStop = False
        Me.grpAdultTickets.Text = "Adult Ticket Sales"
        '
        'grpChildTickets
        '
        Me.grpChildTickets.Controls.Add(Me.txtChildPrice)
        Me.grpChildTickets.Controls.Add(Me.txtChildTickets)
        Me.grpChildTickets.Controls.Add(Me.lblChildPrice)
        Me.grpChildTickets.Controls.Add(Me.lblChildTicket)
        Me.grpChildTickets.Location = New System.Drawing.Point(294, 12)
        Me.grpChildTickets.Name = "grpChildTickets"
        Me.grpChildTickets.Size = New System.Drawing.Size(281, 158)
        Me.grpChildTickets.TabIndex = 24
        Me.grpChildTickets.TabStop = False
        Me.grpChildTickets.Text = "Child Ticket Sales"
        '
        'grpGrossRev
        '
        Me.grpGrossRev.Controls.Add(Me.lblGrossRev)
        Me.grpGrossRev.Controls.Add(Me.Label1)
        Me.grpGrossRev.Controls.Add(Me.lblGrossAdult)
        Me.grpGrossRev.Controls.Add(Me.txtGrossAdult)
        Me.grpGrossRev.Controls.Add(Me.txtGrossChild)
        Me.grpGrossRev.Controls.Add(Me.txtGrossRev)
        Me.grpGrossRev.Location = New System.Drawing.Point(13, 204)
        Me.grpGrossRev.Name = "grpGrossRev"
        Me.grpGrossRev.Size = New System.Drawing.Size(261, 183)
        Me.grpGrossRev.TabIndex = 25
        Me.grpGrossRev.TabStop = False
        Me.grpGrossRev.Text = "Gross Ticket Revenue"
        '
        'lblGrossRev
        '
        Me.lblGrossRev.AutoSize = True
        Me.lblGrossRev.Location = New System.Drawing.Point(14, 124)
        Me.lblGrossRev.Name = "lblGrossRev"
        Me.lblGrossRev.Size = New System.Drawing.Size(64, 13)
        Me.lblGrossRev.TabIndex = 11
        Me.lblGrossRev.Text = "Total Gross:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Child Ticket Sales:"
        '
        'lblGrossAdult
        '
        Me.lblGrossAdult.AutoSize = True
        Me.lblGrossAdult.Location = New System.Drawing.Point(10, 41)
        Me.lblGrossAdult.Name = "lblGrossAdult"
        Me.lblGrossAdult.Size = New System.Drawing.Size(96, 13)
        Me.lblGrossAdult.TabIndex = 9
        Me.lblGrossAdult.Text = "Adult Ticket Sales:"
        '
        'grpNetRev
        '
        Me.grpNetRev.Controls.Add(Me.lblNetRev)
        Me.grpNetRev.Controls.Add(Me.lblChild)
        Me.grpNetRev.Controls.Add(Me.lblNetAdult)
        Me.grpNetRev.Controls.Add(Me.txtNetRev)
        Me.grpNetRev.Controls.Add(Me.txtNetChild)
        Me.grpNetRev.Controls.Add(Me.txtNetAdult)
        Me.grpNetRev.Location = New System.Drawing.Point(294, 204)
        Me.grpNetRev.Name = "grpNetRev"
        Me.grpNetRev.Size = New System.Drawing.Size(281, 183)
        Me.grpNetRev.TabIndex = 26
        Me.grpNetRev.TabStop = False
        Me.grpNetRev.Text = "Net Ticket Revenue"
        '
        'lblNetRev
        '
        Me.lblNetRev.AutoSize = True
        Me.lblNetRev.Location = New System.Drawing.Point(21, 127)
        Me.lblNetRev.Name = "lblNetRev"
        Me.lblNetRev.Size = New System.Drawing.Size(98, 26)
        Me.lblNetRev.TabIndex = 12
        Me.lblNetRev.Text = "Total Net Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " for Ticket Sales:"
        '
        'lblChild
        '
        Me.lblChild.AutoSize = True
        Me.lblChild.Location = New System.Drawing.Point(25, 85)
        Me.lblChild.Name = "lblChild"
        Me.lblChild.Size = New System.Drawing.Size(95, 13)
        Me.lblChild.TabIndex = 11
        Me.lblChild.Text = "Child Ticket Sales:"
        '
        'lblNetAdult
        '
        Me.lblNetAdult.AutoSize = True
        Me.lblNetAdult.Location = New System.Drawing.Point(24, 41)
        Me.lblNetAdult.Name = "lblNetAdult"
        Me.lblNetAdult.Size = New System.Drawing.Size(96, 13)
        Me.lblNetAdult.TabIndex = 10
        Me.lblNetAdult.Text = "Adult Ticket Sales:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 484)
        Me.Controls.Add(Me.grpNetRev)
        Me.Controls.Add(Me.grpGrossRev)
        Me.Controls.Add(Me.grpChildTickets)
        Me.Controls.Add(Me.grpAdultTickets)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpAdultTickets.ResumeLayout(False)
        Me.grpAdultTickets.PerformLayout()
        Me.grpChildTickets.ResumeLayout(False)
        Me.grpChildTickets.PerformLayout()
        Me.grpGrossRev.ResumeLayout(False)
        Me.grpGrossRev.PerformLayout()
        Me.grpNetRev.ResumeLayout(False)
        Me.grpNetRev.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAdultPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAdultTicket As System.Windows.Forms.TextBox
    Friend WithEvents txtChildPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtChildTickets As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossChild As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossRev As System.Windows.Forms.TextBox
    Friend WithEvents txtNetAdult As System.Windows.Forms.TextBox
    Friend WithEvents txtNetChild As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossAdult As System.Windows.Forms.TextBox
    Friend WithEvents txtNetRev As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblAdultPrice As System.Windows.Forms.Label
    Friend WithEvents lblAdultTicket As System.Windows.Forms.Label
    Friend WithEvents lblChildPrice As System.Windows.Forms.Label
    Friend WithEvents lblChildTicket As System.Windows.Forms.Label
    Friend WithEvents grpAdultTickets As System.Windows.Forms.GroupBox
    Friend WithEvents grpChildTickets As System.Windows.Forms.GroupBox
    Friend WithEvents grpGrossRev As System.Windows.Forms.GroupBox
    Friend WithEvents lblGrossRev As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGrossAdult As System.Windows.Forms.Label
    Friend WithEvents grpNetRev As System.Windows.Forms.GroupBox
    Friend WithEvents lblNetRev As System.Windows.Forms.Label
    Friend WithEvents lblChild As System.Windows.Forms.Label
    Friend WithEvents lblNetAdult As System.Windows.Forms.Label

End Class
