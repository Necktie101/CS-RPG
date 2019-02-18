<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class charCreate
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
        Me.clsSelect_list = New System.Windows.Forms.ListBox()
        Me.chrName_txt = New System.Windows.Forms.TextBox()
        Me.ccMenu_btn = New System.Windows.Forms.Button()
        Me.ccPlay_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'clsSelect_list
        '
        Me.clsSelect_list.FormattingEnabled = True
        Me.clsSelect_list.Location = New System.Drawing.Point(68, 54)
        Me.clsSelect_list.Name = "clsSelect_list"
        Me.clsSelect_list.Size = New System.Drawing.Size(120, 95)
        Me.clsSelect_list.TabIndex = 0
        '
        'chrName_txt
        '
        Me.chrName_txt.Location = New System.Drawing.Point(68, 187)
        Me.chrName_txt.Name = "chrName_txt"
        Me.chrName_txt.Size = New System.Drawing.Size(120, 20)
        Me.chrName_txt.TabIndex = 1
        '
        'ccMenu_btn
        '
        Me.ccMenu_btn.Font = New System.Drawing.Font("Encient German Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccMenu_btn.Location = New System.Drawing.Point(32, 242)
        Me.ccMenu_btn.Name = "ccMenu_btn"
        Me.ccMenu_btn.Size = New System.Drawing.Size(85, 30)
        Me.ccMenu_btn.TabIndex = 3
        Me.ccMenu_btn.Text = "Menu"
        Me.ccMenu_btn.UseVisualStyleBackColor = True
        '
        'ccPlay_btn
        '
        Me.ccPlay_btn.Font = New System.Drawing.Font("Encient German Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccPlay_btn.Location = New System.Drawing.Point(141, 242)
        Me.ccPlay_btn.Name = "ccPlay_btn"
        Me.ccPlay_btn.Size = New System.Drawing.Size(85, 30)
        Me.ccPlay_btn.TabIndex = 4
        Me.ccPlay_btn.Text = "Accept"
        Me.ccPlay_btn.UseVisualStyleBackColor = True
        '
        'charCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 324)
        Me.Controls.Add(Me.ccPlay_btn)
        Me.Controls.Add(Me.ccMenu_btn)
        Me.Controls.Add(Me.chrName_txt)
        Me.Controls.Add(Me.clsSelect_list)
        Me.Name = "charCreate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clsSelect_list As ListBox
    Friend WithEvents chrName_txt As TextBox
    Friend WithEvents ccMenu_btn As Button
    Friend WithEvents ccPlay_btn As Button
End Class
