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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.lblSides = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblCM = New System.Windows.Forms.Label()
        Me.txtnumSides = New System.Windows.Forms.TextBox()
        Me.txtLenghtSides = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(412, 72)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 29)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(526, 72)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 29)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(637, 72)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 29)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(577, 438)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.Enabled = False
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 20
        Me.lstResults.Location = New System.Drawing.Point(24, 223)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(462, 244)
        Me.lstResults.TabIndex = 4
        '
        'lblSides
        '
        Me.lblSides.AutoSize = True
        Me.lblSides.Location = New System.Drawing.Point(13, 27)
        Me.lblSides.Name = "lblSides"
        Me.lblSides.Size = New System.Drawing.Size(120, 20)
        Me.lblSides.TabIndex = 5
        Me.lblSides.Text = "Amount of sides:"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(12, 72)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(118, 20)
        Me.lblLength.TabIndex = 6
        Me.lblLength.Text = "Length of a side:"
        '
        'lblCM
        '
        Me.lblCM.AutoSize = True
        Me.lblCM.Location = New System.Drawing.Point(271, 76)
        Me.lblCM.Name = "lblCM"
        Me.lblCM.Size = New System.Drawing.Size(29, 20)
        Me.lblCM.TabIndex = 7
        Me.lblCM.Text = "cm"
        '
        'txtnumSides
        '
        Me.txtnumSides.Location = New System.Drawing.Point(140, 27)
        Me.txtnumSides.Name = "txtnumSides"
        Me.txtnumSides.Size = New System.Drawing.Size(125, 27)
        Me.txtnumSides.TabIndex = 8
        '
        'txtLenghtSides
        '
        Me.txtLenghtSides.Location = New System.Drawing.Point(140, 69)
        Me.txtLenghtSides.Name = "txtLenghtSides"
        Me.txtLenghtSides.Size = New System.Drawing.Size(125, 27)
        Me.txtLenghtSides.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 491)
        Me.Controls.Add(Me.txtLenghtSides)
        Me.Controls.Add(Me.txtnumSides)
        Me.Controls.Add(Me.lblCM)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblSides)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Polygon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents lblSides As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblCM As Label
    Friend WithEvents txtnumSides As TextBox
    Friend WithEvents txtLenghtSides As TextBox
End Class
