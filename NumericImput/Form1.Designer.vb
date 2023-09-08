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
        btnPress = New Button()
        txtNumeric = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnPress
        ' 
        btnPress.Location = New Point(275, 183)
        btnPress.Name = "btnPress"
        btnPress.Size = New Size(167, 59)
        btnPress.TabIndex = 0
        btnPress.Text = "Enter"
        btnPress.UseVisualStyleBackColor = True
        ' 
        ' txtNumeric
        ' 
        txtNumeric.Location = New Point(292, 137)
        txtNumeric.Name = "txtNumeric"
        txtNumeric.Size = New Size(150, 31)
        txtNumeric.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(163, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 25)
        Label1.TabIndex = 2
        Label1.Text = "Enter Numeric"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtNumeric)
        Controls.Add(btnPress)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPress As Button
    Friend WithEvents txtNumeric As TextBox
    Friend WithEvents Label1 As Label
End Class
