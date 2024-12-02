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
        ExitButton = New Button()
        ClrButton = New Button()
        Label1 = New Label()
        Value = New TextBox()
        SuspendLayout()
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(464, 131)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(75, 40)
        ExitButton.TabIndex = 0
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' ClrButton
        ' 
        ClrButton.Location = New Point(251, 131)
        ClrButton.Name = "ClrButton"
        ClrButton.Size = New Size(75, 41)
        ClrButton.TabIndex = 1
        ClrButton.Text = "Clear"
        ClrButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(354, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 3
        Label1.Text = "Enter Number"
        ' 
        ' Value
        ' 
        Value.Location = New Point(345, 131)
        Value.Multiline = True
        Value.Name = "Value"
        Value.Size = New Size(100, 41)
        Value.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Value)
        Controls.Add(Label1)
        Controls.Add(ClrButton)
        Controls.Add(ExitButton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ClrButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Value As TextBox

End Class
