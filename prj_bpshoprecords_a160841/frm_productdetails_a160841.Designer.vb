<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productdetails_a160841
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productdetails_a160841))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_colour = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_production_country = New System.Windows.Forms.Label()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Kristen ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(521, 24)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(228, 36)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Product Details"
        '
        'lst_id
        '
        Me.lst_id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lst_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 24
        Me.lst_id.Location = New System.Drawing.Point(53, 137)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(170, 292)
        Me.lst_id.TabIndex = 1
        '
        'pic_product
        '
        Me.pic_product.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(924, 137)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(200, 294)
        Me.pic_product.TabIndex = 9
        Me.pic_product.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 27)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Product List"
        '
        'lbl_id
        '
        Me.lbl_id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(273, 137)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(140, 29)
        Me.lbl_id.TabIndex = 11
        Me.lbl_id.Text = "Product's ID"
        '
        'lbl_name
        '
        Me.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(273, 179)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(169, 29)
        Me.lbl_name.TabIndex = 12
        Me.lbl_name.Text = "Product's Name"
        '
        'lbl_price
        '
        Me.lbl_price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(273, 221)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(163, 29)
        Me.lbl_price.TabIndex = 13
        Me.lbl_price.Text = "Product's Price"
        '
        'lbl_colour
        '
        Me.lbl_colour.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_colour.AutoSize = True
        Me.lbl_colour.BackColor = System.Drawing.Color.Transparent
        Me.lbl_colour.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_colour.Location = New System.Drawing.Point(273, 352)
        Me.lbl_colour.Name = "lbl_colour"
        Me.lbl_colour.Size = New System.Drawing.Size(176, 29)
        Me.lbl_colour.TabIndex = 16
        Me.lbl_colour.Text = "Product's Colour"
        '
        'lbl_type
        '
        Me.lbl_type.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(273, 310)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(161, 29)
        Me.lbl_type.TabIndex = 15
        Me.lbl_type.Text = "Product's Type"
        '
        'lbl_brand
        '
        Me.lbl_brand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(273, 268)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(172, 29)
        Me.lbl_brand.TabIndex = 14
        Me.lbl_brand.Text = "Product's Brand"
        '
        'btn_back
        '
        Me.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_back.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(560, 495)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(155, 34)
        Me.btn_back.TabIndex = 17
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lbl_production_country
        '
        Me.lbl_production_country.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_production_country.AutoSize = True
        Me.lbl_production_country.BackColor = System.Drawing.Color.Transparent
        Me.lbl_production_country.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_production_country.Location = New System.Drawing.Point(273, 402)
        Me.lbl_production_country.Name = "lbl_production_country"
        Me.lbl_production_country.Size = New System.Drawing.Size(302, 29)
        Me.lbl_production_country.TabIndex = 18
        Me.lbl_production_country.Text = "Product's Production Country"
        '
        'frm_productdetails_a160841
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1185, 577)
        Me.Controls.Add(Me.lbl_production_country)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_colour)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_id)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_productdetails_a160841"
        Me.Text = "frm_productdetails_a160841"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lst_id As System.Windows.Forms.ListBox
    Friend WithEvents pic_product As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents lbl_colour As System.Windows.Forms.Label
    Friend WithEvents lbl_type As System.Windows.Forms.Label
    Friend WithEvents lbl_brand As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents lbl_production_country As System.Windows.Forms.Label
End Class
