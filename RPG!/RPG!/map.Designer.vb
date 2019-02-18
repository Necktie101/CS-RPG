<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class map
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(map))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pname = New System.Windows.Forms.Label()
        Me.pstat = New System.Windows.Forms.Label()
        Me.slctDest_list = New System.Windows.Forms.ListBox()
        Me.go_btn = New System.Windows.Forms.Button()
        Me.str = New System.Windows.Forms.Label()
        Me.cwght = New System.Windows.Forms.Label()
        Me.int = New System.Windows.Forms.Label()
        Me.intValue_lbl = New System.Windows.Forms.Label()
        Me.strValue_lbl = New System.Windows.Forms.Label()
        Me.cwghtValue_lbl = New System.Windows.Forms.Label()
        Me.lvl = New System.Windows.Forms.Label()
        Me.lvlValue_lbl = New System.Windows.Forms.Label()
        Me.money = New System.Windows.Forms.Label()
        Me.moneyValue_lbl = New System.Windows.Forms.Label()
        Me.crntLocation_lbl = New System.Windows.Forms.Label()
        Me.twnEnt_btn = New System.Windows.Forms.Button()
        Me.Chronos_tmr = New System.Windows.Forms.Timer(Me.components)
        Me.saveGame_btn = New System.Windows.Forms.Button()
        Me.quit_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(16, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(897, 506)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pname
        '
        Me.pname.AutoSize = True
        Me.pname.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pname.Location = New System.Drawing.Point(1205, 13)
        Me.pname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(68, 28)
        Me.pname.TabIndex = 1
        Me.pname.Text = "Name"
        '
        'pstat
        '
        Me.pstat.AutoSize = True
        Me.pstat.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pstat.Location = New System.Drawing.Point(1064, 13)
        Me.pstat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pstat.Name = "pstat"
        Me.pstat.Size = New System.Drawing.Size(63, 28)
        Me.pstat.TabIndex = 3
        Me.pstat.Text = "Class"
        '
        'slctDest_list
        '
        Me.slctDest_list.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slctDest_list.FormattingEnabled = True
        Me.slctDest_list.ItemHeight = 28
        Me.slctDest_list.Location = New System.Drawing.Point(948, 207)
        Me.slctDest_list.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.slctDest_list.Name = "slctDest_list"
        Me.slctDest_list.Size = New System.Drawing.Size(204, 284)
        Me.slctDest_list.TabIndex = 4
        '
        'go_btn
        '
        Me.go_btn.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.go_btn.Location = New System.Drawing.Point(1181, 347)
        Me.go_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.go_btn.Name = "go_btn"
        Me.go_btn.Size = New System.Drawing.Size(126, 33)
        Me.go_btn.TabIndex = 5
        Me.go_btn.Text = "Travel"
        Me.go_btn.UseVisualStyleBackColor = True
        '
        'str
        '
        Me.str.AutoSize = True
        Me.str.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.str.Location = New System.Drawing.Point(943, 110)
        Me.str.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.str.Name = "str"
        Me.str.Size = New System.Drawing.Size(89, 28)
        Me.str.TabIndex = 6
        Me.str.Text = "Strength"
        '
        'cwght
        '
        Me.cwght.AutoSize = True
        Me.cwght.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cwght.Location = New System.Drawing.Point(943, 155)
        Me.cwght.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cwght.Name = "cwght"
        Me.cwght.Size = New System.Drawing.Size(131, 28)
        Me.cwght.TabIndex = 7
        Me.cwght.Text = "Carry Weight"
        '
        'int
        '
        Me.int.AutoSize = True
        Me.int.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.int.Location = New System.Drawing.Point(943, 68)
        Me.int.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.int.Name = "int"
        Me.int.Size = New System.Drawing.Size(113, 28)
        Me.int.TabIndex = 8
        Me.int.Text = "Intelligence"
        '
        'intValue_lbl
        '
        Me.intValue_lbl.AutoSize = True
        Me.intValue_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intValue_lbl.Location = New System.Drawing.Point(1084, 68)
        Me.intValue_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.intValue_lbl.Name = "intValue_lbl"
        Me.intValue_lbl.Size = New System.Drawing.Size(24, 28)
        Me.intValue_lbl.TabIndex = 9
        Me.intValue_lbl.Text = "0"
        '
        'strValue_lbl
        '
        Me.strValue_lbl.AutoSize = True
        Me.strValue_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strValue_lbl.Location = New System.Drawing.Point(1084, 110)
        Me.strValue_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.strValue_lbl.Name = "strValue_lbl"
        Me.strValue_lbl.Size = New System.Drawing.Size(24, 28)
        Me.strValue_lbl.TabIndex = 10
        Me.strValue_lbl.Text = "0"
        '
        'cwghtValue_lbl
        '
        Me.cwghtValue_lbl.AutoSize = True
        Me.cwghtValue_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cwghtValue_lbl.Location = New System.Drawing.Point(1084, 155)
        Me.cwghtValue_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cwghtValue_lbl.Name = "cwghtValue_lbl"
        Me.cwghtValue_lbl.Size = New System.Drawing.Size(24, 28)
        Me.cwghtValue_lbl.TabIndex = 11
        Me.cwghtValue_lbl.Text = "0"
        '
        'lvl
        '
        Me.lvl.AutoSize = True
        Me.lvl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvl.Location = New System.Drawing.Point(1205, 68)
        Me.lvl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lvl.Name = "lvl"
        Me.lvl.Size = New System.Drawing.Size(58, 28)
        Me.lvl.TabIndex = 12
        Me.lvl.Text = "Level"
        '
        'lvlValue_lbl
        '
        Me.lvlValue_lbl.AutoSize = True
        Me.lvlValue_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlValue_lbl.Location = New System.Drawing.Point(1339, 68)
        Me.lvlValue_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lvlValue_lbl.Name = "lvlValue_lbl"
        Me.lvlValue_lbl.Size = New System.Drawing.Size(24, 28)
        Me.lvlValue_lbl.TabIndex = 13
        Me.lvlValue_lbl.Text = "0"
        '
        'money
        '
        Me.money.AutoSize = True
        Me.money.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.money.Location = New System.Drawing.Point(1205, 110)
        Me.money.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.money.Name = "money"
        Me.money.Size = New System.Drawing.Size(72, 28)
        Me.money.TabIndex = 14
        Me.money.Text = "Money"
        '
        'moneyValue_lbl
        '
        Me.moneyValue_lbl.AutoSize = True
        Me.moneyValue_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moneyValue_lbl.Location = New System.Drawing.Point(1339, 110)
        Me.moneyValue_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.moneyValue_lbl.Name = "moneyValue_lbl"
        Me.moneyValue_lbl.Size = New System.Drawing.Size(24, 28)
        Me.moneyValue_lbl.TabIndex = 15
        Me.moneyValue_lbl.Text = "0"
        '
        'crntLocation_lbl
        '
        Me.crntLocation_lbl.AutoSize = True
        Me.crntLocation_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crntLocation_lbl.Location = New System.Drawing.Point(1176, 207)
        Me.crntLocation_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.crntLocation_lbl.Name = "crntLocation_lbl"
        Me.crntLocation_lbl.Size = New System.Drawing.Size(166, 28)
        Me.crntLocation_lbl.TabIndex = 16
        Me.crntLocation_lbl.Text = "Current Location:"
        '
        'twnEnt_btn
        '
        Me.twnEnt_btn.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twnEnt_btn.Location = New System.Drawing.Point(1181, 299)
        Me.twnEnt_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.twnEnt_btn.Name = "twnEnt_btn"
        Me.twnEnt_btn.Size = New System.Drawing.Size(126, 33)
        Me.twnEnt_btn.TabIndex = 17
        Me.twnEnt_btn.Text = "Enter Town"
        Me.twnEnt_btn.UseVisualStyleBackColor = True
        '
        'Chronos_tmr
        '
        '
        'saveGame_btn
        '
        Me.saveGame_btn.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveGame_btn.Location = New System.Drawing.Point(1181, 404)
        Me.saveGame_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.saveGame_btn.Name = "saveGame_btn"
        Me.saveGame_btn.Size = New System.Drawing.Size(126, 33)
        Me.saveGame_btn.TabIndex = 18
        Me.saveGame_btn.Text = "Save Game"
        Me.saveGame_btn.UseVisualStyleBackColor = True
        '
        'quit_btn
        '
        Me.quit_btn.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit_btn.Location = New System.Drawing.Point(1181, 458)
        Me.quit_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(126, 33)
        Me.quit_btn.TabIndex = 19
        Me.quit_btn.Text = "Quit"
        Me.quit_btn.UseVisualStyleBackColor = True
        '
        'map
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1557, 569)
        Me.Controls.Add(Me.quit_btn)
        Me.Controls.Add(Me.saveGame_btn)
        Me.Controls.Add(Me.twnEnt_btn)
        Me.Controls.Add(Me.crntLocation_lbl)
        Me.Controls.Add(Me.moneyValue_lbl)
        Me.Controls.Add(Me.money)
        Me.Controls.Add(Me.lvlValue_lbl)
        Me.Controls.Add(Me.lvl)
        Me.Controls.Add(Me.cwghtValue_lbl)
        Me.Controls.Add(Me.strValue_lbl)
        Me.Controls.Add(Me.intValue_lbl)
        Me.Controls.Add(Me.int)
        Me.Controls.Add(Me.cwght)
        Me.Controls.Add(Me.str)
        Me.Controls.Add(Me.go_btn)
        Me.Controls.Add(Me.slctDest_list)
        Me.Controls.Add(Me.pstat)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "map"
        Me.Text = "The Syndicate of Wedgerock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pname As Label
    Friend WithEvents pstat As Label
    Friend WithEvents slctDest_list As ListBox
    Friend WithEvents go_btn As Button
    Friend WithEvents str As Label
    Friend WithEvents cwght As Label
    Friend WithEvents int As Label
    Friend WithEvents intValue_lbl As Label
    Friend WithEvents strValue_lbl As Label
    Friend WithEvents cwghtValue_lbl As Label
    Friend WithEvents lvl As Label
    Friend WithEvents lvlValue_lbl As Label
    Friend WithEvents money As Label
    Friend WithEvents moneyValue_lbl As Label
    Friend WithEvents crntLocation_lbl As Label
    Friend WithEvents twnEnt_btn As Button
    Friend WithEvents Chronos_tmr As Timer
    Friend WithEvents saveGame_btn As Button
    Friend WithEvents quit_btn As Button
End Class
