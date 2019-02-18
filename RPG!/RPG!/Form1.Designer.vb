<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpg
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
        Me.newGame_btn = New System.Windows.Forms.Button()
        Me.ldGame_btn = New System.Windows.Forms.Button()
        Me.quit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'newGame_btn
        '
        Me.newGame_btn.Font = New System.Drawing.Font("Encient German Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newGame_btn.Location = New System.Drawing.Point(97, 69)
        Me.newGame_btn.Name = "newGame_btn"
        Me.newGame_btn.Size = New System.Drawing.Size(108, 42)
        Me.newGame_btn.TabIndex = 0
        Me.newGame_btn.Text = "New Game"
        Me.newGame_btn.UseVisualStyleBackColor = True
        '
        'ldGame_btn
        '
        Me.ldGame_btn.Font = New System.Drawing.Font("Encient German Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldGame_btn.Location = New System.Drawing.Point(97, 143)
        Me.ldGame_btn.Name = "ldGame_btn"
        Me.ldGame_btn.Size = New System.Drawing.Size(108, 42)
        Me.ldGame_btn.TabIndex = 1
        Me.ldGame_btn.Text = "Load Game"
        Me.ldGame_btn.UseVisualStyleBackColor = True
        '
        'quit_btn
        '
        Me.quit_btn.Font = New System.Drawing.Font("Encient German Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit_btn.Location = New System.Drawing.Point(97, 218)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(108, 42)
        Me.quit_btn.TabIndex = 2
        Me.quit_btn.Text = "Exit"
        Me.quit_btn.UseVisualStyleBackColor = True
        '
        'rpg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 367)
        Me.Controls.Add(Me.quit_btn)
        Me.Controls.Add(Me.ldGame_btn)
        Me.Controls.Add(Me.newGame_btn)
        Me.Name = "rpg"
        Me.Text = "RPG!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newGame_btn As Button
    Friend WithEvents ldGame_btn As Button
    Friend WithEvents quit_btn As Button
End Class
