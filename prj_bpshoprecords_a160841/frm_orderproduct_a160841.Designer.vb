<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderproduct_a160841
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderproduct_a160841))
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.cb_staffid = New System.Windows.Forms.ComboBox()
        Me.cb_customerid = New System.Windows.Forms.ComboBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.nud_quantity = New System.Windows.Forms.NumericUpDown()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.grd_cart = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AllowUserToDeleteRows = False
        Me.grd_product.AllowUserToResizeColumns = False
        Me.grd_product.AllowUserToResizeRows = False
        Me.grd_product.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(52, 59)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.Size = New System.Drawing.Size(637, 211)
        Me.grd_product.TabIndex = 0
        '
        'pic_product
        '
        Me.pic_product.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(734, 59)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(176, 211)
        Me.pic_product.TabIndex = 1
        Me.pic_product.TabStop = False
        '
        'cb_staffid
        '
        Me.cb_staffid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_staffid.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_staffid.FormattingEnabled = True
        Me.cb_staffid.Location = New System.Drawing.Point(310, 290)
        Me.cb_staffid.Name = "cb_staffid"
        Me.cb_staffid.Size = New System.Drawing.Size(95, 31)
        Me.cb_staffid.TabIndex = 3
        '
        'cb_customerid
        '
        Me.cb_customerid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_customerid.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_customerid.FormattingEnabled = True
        Me.cb_customerid.Location = New System.Drawing.Point(594, 290)
        Me.cb_customerid.Name = "cb_customerid"
        Me.cb_customerid.Size = New System.Drawing.Size(95, 31)
        Me.cb_customerid.TabIndex = 4
        '
        'btn_back
        '
        Me.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_back.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(532, 568)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(176, 33)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Location = New System.Drawing.Point(48, 293)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(82, 23)
        Me.lbl_orderid.TabIndex = 6
        Me.lbl_orderid.Text = "Order ID"
        '
        'nud_quantity
        '
        Me.nud_quantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nud_quantity.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_quantity.Location = New System.Drawing.Point(836, 292)
        Me.nud_quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_quantity.Name = "nud_quantity"
        Me.nud_quantity.Size = New System.Drawing.Size(74, 29)
        Me.nud_quantity.TabIndex = 7
        Me.nud_quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_add
        '
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_add.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(734, 348)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(176, 33)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Add To Cart"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_remove.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.Location = New System.Drawing.Point(734, 411)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(176, 33)
        Me.btn_remove.TabIndex = 9
        Me.btn_remove.Text = "Remove From Cart"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'grd_cart
        '
        Me.grd_cart.AllowUserToAddRows = False
        Me.grd_cart.AllowUserToDeleteRows = False
        Me.grd_cart.AllowUserToResizeColumns = False
        Me.grd_cart.AllowUserToResizeRows = False
        Me.grd_cart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_cart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cart.Location = New System.Drawing.Point(52, 356)
        Me.grd_cart.Name = "grd_cart"
        Me.grd_cart.ReadOnly = True
        Me.grd_cart.Size = New System.Drawing.Size(503, 193)
        Me.grd_cart.TabIndex = 10
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.White
        Me.lbl_total.Font = New System.Drawing.Font("Kristen ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(589, 520)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(69, 29)
        Me.lbl_total.TabIndex = 11
        Me.lbl_total.Text = "Total"
        '
        'btn_confirm
        '
        Me.btn_confirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_confirm.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(272, 568)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(176, 35)
        Me.btn_confirm.TabIndex = 12
        Me.btn_confirm.Text = "Confirm Order"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 35)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ORDER PRODUCT"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Customer ID : "
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Staff ID : "
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(730, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Quantity :"
        '
        'frm_orderproduct_a160841
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(977, 615)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.grd_cart)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.nud_quantity)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.cb_customerid)
        Me.Controls.Add(Me.cb_staffid)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.grd_product)
        Me.Name = "frm_orderproduct_a160841"
        Me.Text = "frm_orderproduct_a160841"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_product As System.Windows.Forms.DataGridView
    Friend WithEvents pic_product As System.Windows.Forms.PictureBox
    Friend WithEvents cb_staffid As System.Windows.Forms.ComboBox
    Friend WithEvents cb_customerid As System.Windows.Forms.ComboBox
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents lbl_orderid As System.Windows.Forms.Label
    Friend WithEvents nud_quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents grd_cart As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
