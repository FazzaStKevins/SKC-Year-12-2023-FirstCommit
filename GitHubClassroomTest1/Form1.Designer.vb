<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(73, 69)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(173, 23)
        Me.txtNumber1.TabIndex = 0
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(468, 70)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(214, 23)
        Me.txtNumber2.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(320, 127)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 62)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Button1"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(332, 266)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(64, 15)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.Text = "..................."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblAnswer As Label
End Class
