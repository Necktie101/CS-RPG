<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class City
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(City))
        Me.cityIcon = New System.Windows.Forms.PictureBox()
        Me.twnNme_lbl = New System.Windows.Forms.Label()
        Me.ext_btn = New System.Windows.Forms.Button()
        Me.mrkt_btn = New System.Windows.Forms.Button()
        CType(Me.cityIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cityIcon
        '
        Me.cityIcon.Image = CType(resources.GetObject("cityIcon.Image"), System.Drawing.Image)
        Me.cityIcon.Location = New System.Drawing.Point(12, 12)
        Me.cityIcon.Name = "cityIcon"
        Me.cityIcon.Size = New System.Drawing.Size(192, 193)
        Me.cityIcon.TabIndex = 0
        Me.cityIcon.TabStop = False
        '
        'twnNme_lbl
        '
        Me.twnNme_lbl.AutoSize = True
        Me.twnNme_lbl.Font = New System.Drawing.Font("Encient German Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twnNme_lbl.Location = New System.Drawing.Point(227, 12)
        Me.twnNme_lbl.Name = "twnNme_lbl"
        Me.twnNme_lbl.Size = New System.Drawing.Size(49, 22)
        Me.twnNme_lbl.TabIndex = 1
        Me.twnNme_lbl.Text = "  City"
        '
        'ext_btn
        '
        Me.ext_btn.Font = New System.Drawing.Font("Encient German Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ext_btn.Location = New System.Drawing.Point(231, 179)
        Me.ext_btn.Name = "ext_btn"
        Me.ext_btn.Size = New System.Drawing.Size(63, 26)
        Me.ext_btn.TabIndex = 2
        Me.ext_btn.Text = "Leave"
        Me.ext_btn.UseVisualStyleBackColor = True
        '
        'mrkt_btn
        '
        Me.mrkt_btn.Font = New System.Drawing.Font("Encient German Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrkt_btn.Location = New System.Drawing.Point(231, 136)
        Me.mrkt_btn.Name = "mrkt_btn"
        Me.mrkt_btn.Size = New System.Drawing.Size(70, 26)
        Me.mrkt_btn.TabIndex = 3
        Me.mrkt_btn.Text = "Market"
        Me.mrkt_btn.UseVisualStyleBackColor = True
        '
        'City
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 226)
        Me.Controls.Add(Me.mrkt_btn)
        Me.Controls.Add(Me.ext_btn)
        Me.Controls.Add(Me.twnNme_lbl)
        Me.Controls.Add(Me.cityIcon)
        Me.Name = "City"
        Me.Text = "City"
        CType(Me.cityIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cityIcon As PictureBox
    Friend WithEvents twnNme_lbl As Label
    Friend WithEvents ext_btn As Button
    Friend WithEvents mrkt_btn As Button
End Class
