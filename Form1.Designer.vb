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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnDoLoopWhile = New System.Windows.Forms.Button()
        Me.btnDoLoopUntil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(731, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program for Summing the Integers from 1 to N." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please input a value for N"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.Location = New System.Drawing.Point(128, 142)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(62, 37)
        Me.lblN.TabIndex = 1
        Me.lblN.Text = "N="
        Me.lblN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.Location = New System.Drawing.Point(130, 262)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(59, 37)
        Me.lblS.TabIndex = 2
        Me.lblS.Text = "S="
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(275, 248)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(440, 51)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "??"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(282, 142)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(433, 44)
        Me.txtInput.TabIndex = 4
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(106, 423)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(261, 79)
        Me.btnForNext.TabIndex = 5
        Me.btnForNext.Text = "For...Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(458, 414)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(247, 80)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(104, 545)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(263, 80)
        Me.btnDoWhile.TabIndex = 7
        Me.btnDoWhile.Text = "Do While...Loop"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'btnDoUntil
        '
        Me.btnDoUntil.Location = New System.Drawing.Point(458, 551)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(248, 74)
        Me.btnDoUntil.TabIndex = 8
        Me.btnDoUntil.Text = "Do Until...Loop"
        Me.btnDoUntil.UseVisualStyleBackColor = True
        '
        'btnDoLoopWhile
        '
        Me.btnDoLoopWhile.Location = New System.Drawing.Point(106, 679)
        Me.btnDoLoopWhile.Name = "btnDoLoopWhile"
        Me.btnDoLoopWhile.Size = New System.Drawing.Size(261, 92)
        Me.btnDoLoopWhile.TabIndex = 9
        Me.btnDoLoopWhile.Text = "Do...Loop While"
        Me.btnDoLoopWhile.UseVisualStyleBackColor = True
        '
        'btnDoLoopUntil
        '
        Me.btnDoLoopUntil.Location = New System.Drawing.Point(458, 691)
        Me.btnDoLoopUntil.Name = "btnDoLoopUntil"
        Me.btnDoLoopUntil.Size = New System.Drawing.Size(247, 80)
        Me.btnDoLoopUntil.TabIndex = 10
        Me.btnDoLoopUntil.Text = "Do...Loop Until"
        Me.btnDoLoopUntil.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 872)
        Me.Controls.Add(Me.btnDoLoopUntil)
        Me.Controls.Add(Me.btnDoLoopWhile)
        Me.Controls.Add(Me.btnDoUntil)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnForNext)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblN As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnForNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnDoLoopWhile As Button
    Friend WithEvents btnDoLoopUntil As Button
End Class
