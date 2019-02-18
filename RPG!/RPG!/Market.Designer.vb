<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Market
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
        Me.goodsSelector_cmbx = New System.Windows.Forms.ComboBox()
        Me.goods_lbl = New System.Windows.Forms.Label()
        Me.buy_btn = New System.Windows.Forms.Button()
        Me.sell_btn = New System.Windows.Forms.Button()
        Me.amount_lbl = New System.Windows.Forms.Label()
        Me.price_lbl = New System.Windows.Forms.Label()
        Me.qSelector_bx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.correntMarket_lbl = New System.Windows.Forms.Label()
        Me.return_btn = New System.Windows.Forms.Button()
        Me.select_btn = New System.Windows.Forms.Button()
        Me.backpack_list = New System.Windows.Forms.ListBox()
        Me.backpack_lbl = New System.Windows.Forms.Label()
        Me.sPrice_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'goodsSelector_cmbx
        '
        Me.goodsSelector_cmbx.FormattingEnabled = True
        Me.goodsSelector_cmbx.Location = New System.Drawing.Point(128, 9)
        Me.goodsSelector_cmbx.Name = "goodsSelector_cmbx"
        Me.goodsSelector_cmbx.Size = New System.Drawing.Size(192, 21)
        Me.goodsSelector_cmbx.TabIndex = 0
        '
        'goods_lbl
        '
        Me.goods_lbl.AutoSize = True
        Me.goods_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goods_lbl.Location = New System.Drawing.Point(13, 9)
        Me.goods_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.goods_lbl.Name = "goods_lbl"
        Me.goods_lbl.Size = New System.Drawing.Size(108, 28)
        Me.goods_lbl.TabIndex = 17
        Me.goods_lbl.Text = "Commodity"
        '
        'buy_btn
        '
        Me.buy_btn.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buy_btn.Location = New System.Drawing.Point(13, 266)
        Me.buy_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.buy_btn.Name = "buy_btn"
        Me.buy_btn.Size = New System.Drawing.Size(126, 33)
        Me.buy_btn.TabIndex = 18
        Me.buy_btn.Text = "Buy"
        Me.buy_btn.UseVisualStyleBackColor = True
        '
        'sell_btn
        '
        Me.sell_btn.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sell_btn.Location = New System.Drawing.Point(185, 266)
        Me.sell_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.sell_btn.Name = "sell_btn"
        Me.sell_btn.Size = New System.Drawing.Size(89, 33)
        Me.sell_btn.TabIndex = 19
        Me.sell_btn.Text = "Sell"
        Me.sell_btn.UseVisualStyleBackColor = True
        '
        'amount_lbl
        '
        Me.amount_lbl.AutoSize = True
        Me.amount_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount_lbl.Location = New System.Drawing.Point(13, 53)
        Me.amount_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.amount_lbl.Name = "amount_lbl"
        Me.amount_lbl.Size = New System.Drawing.Size(181, 28)
        Me.amount_lbl.TabIndex = 20
        Me.amount_lbl.Text = "Quantity Available:"
        '
        'price_lbl
        '
        Me.price_lbl.AutoSize = True
        Me.price_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_lbl.Location = New System.Drawing.Point(13, 98)
        Me.price_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.price_lbl.Name = "price_lbl"
        Me.price_lbl.Size = New System.Drawing.Size(122, 28)
        Me.price_lbl.TabIndex = 21
        Me.price_lbl.Text = " Buy Price: "
        '
        'qSelector_bx
        '
        Me.qSelector_bx.Font = New System.Drawing.Font("Encient German Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qSelector_bx.Location = New System.Drawing.Point(245, 159)
        Me.qSelector_bx.Name = "qSelector_bx"
        Me.qSelector_bx.Size = New System.Drawing.Size(100, 27)
        Me.qSelector_bx.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 159)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 28)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Quantity Bought/Sold: "
        '
        'correntMarket_lbl
        '
        Me.correntMarket_lbl.AutoSize = True
        Me.correntMarket_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correntMarket_lbl.Location = New System.Drawing.Point(13, 221)
        Me.correntMarket_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.correntMarket_lbl.Name = "correntMarket_lbl"
        Me.correntMarket_lbl.Size = New System.Drawing.Size(149, 28)
        Me.correntMarket_lbl.TabIndex = 24
        Me.correntMarket_lbl.Text = "Current Mrket:"
        '
        'return_btn
        '
        Me.return_btn.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.return_btn.Location = New System.Drawing.Point(315, 266)
        Me.return_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.return_btn.Name = "return_btn"
        Me.return_btn.Size = New System.Drawing.Size(126, 33)
        Me.return_btn.TabIndex = 25
        Me.return_btn.Text = "Return"
        Me.return_btn.UseVisualStyleBackColor = True
        '
        'select_btn
        '
        Me.select_btn.Font = New System.Drawing.Font("Encient German Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_btn.Location = New System.Drawing.Point(352, 7)
        Me.select_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.select_btn.Name = "select_btn"
        Me.select_btn.Size = New System.Drawing.Size(89, 23)
        Me.select_btn.TabIndex = 26
        Me.select_btn.Text = "Select"
        Me.select_btn.UseVisualStyleBackColor = True
        '
        'backpack_list
        '
        Me.backpack_list.Font = New System.Drawing.Font("Encient German Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backpack_list.FormattingEnabled = True
        Me.backpack_list.ItemHeight = 19
        Me.backpack_list.Location = New System.Drawing.Point(468, 64)
        Me.backpack_list.Name = "backpack_list"
        Me.backpack_list.Size = New System.Drawing.Size(230, 232)
        Me.backpack_list.TabIndex = 27
        '
        'backpack_lbl
        '
        Me.backpack_lbl.AutoSize = True
        Me.backpack_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backpack_lbl.Location = New System.Drawing.Point(498, 9)
        Me.backpack_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.backpack_lbl.Name = "backpack_lbl"
        Me.backpack_lbl.Size = New System.Drawing.Size(162, 28)
        Me.backpack_lbl.TabIndex = 28
        Me.backpack_lbl.Text = "Player Backpack"
        '
        'sPrice_lbl
        '
        Me.sPrice_lbl.AutoSize = True
        Me.sPrice_lbl.Font = New System.Drawing.Font("Encient German Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sPrice_lbl.Location = New System.Drawing.Point(244, 98)
        Me.sPrice_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sPrice_lbl.Name = "sPrice_lbl"
        Me.sPrice_lbl.Size = New System.Drawing.Size(119, 28)
        Me.sPrice_lbl.TabIndex = 29
        Me.sPrice_lbl.Text = "Sale Price: "
        '
        'Market
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 311)
        Me.Controls.Add(Me.sPrice_lbl)
        Me.Controls.Add(Me.backpack_lbl)
        Me.Controls.Add(Me.backpack_list)
        Me.Controls.Add(Me.select_btn)
        Me.Controls.Add(Me.return_btn)
        Me.Controls.Add(Me.correntMarket_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.qSelector_bx)
        Me.Controls.Add(Me.price_lbl)
        Me.Controls.Add(Me.amount_lbl)
        Me.Controls.Add(Me.sell_btn)
        Me.Controls.Add(Me.buy_btn)
        Me.Controls.Add(Me.goods_lbl)
        Me.Controls.Add(Me.goodsSelector_cmbx)
        Me.Name = "Market"
        Me.Text = "Market"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents goodsSelector_cmbx As ComboBox
    Friend WithEvents goods_lbl As Label
    Friend WithEvents buy_btn As Button
    Friend WithEvents sell_btn As Button
    Friend WithEvents amount_lbl As Label
    Friend WithEvents price_lbl As Label
    Friend WithEvents qSelector_bx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents correntMarket_lbl As Label
    Friend WithEvents return_btn As Button
    Friend WithEvents select_btn As Button
    Friend WithEvents backpack_list As ListBox
    Friend WithEvents backpack_lbl As Label
    Friend WithEvents sPrice_lbl As Label
End Class
