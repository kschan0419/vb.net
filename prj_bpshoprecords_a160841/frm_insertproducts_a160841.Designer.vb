<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproducts_a160841
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproducts_a160841))
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.up_id = New System.Windows.Forms.TextBox()
        Me.up_name = New System.Windows.Forms.TextBox()
        Me.up_price = New System.Windows.Forms.TextBox()
        Me.up_brand = New System.Windows.Forms.TextBox()
        Me.up_type = New System.Windows.Forms.TextBox()
        Me.up_colour = New System.Windows.Forms.TextBox()
        Me.up_production_country = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.pic_up = New System.Windows.Forms.PictureBox()
        Me.btn_picture2 = New System.Windows.Forms.Button()
        Me.up_pic = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_up, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AllowUserToDeleteRows = False
        Me.grd_products.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(43, 86)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        Me.grd_products.Size = New System.Drawing.Size(440, 598)
        Me.grd_products.TabIndex = 0
        '
        'btn_insert
        '
        Me.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_insert.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(669, 654)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(121, 30)
        Me.btn_insert.TabIndex = 8
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'up_id
        '
        Me.up_id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.up_id.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up_id.Location = New System.Drawing.Point(684, 240)
        Me.up_id.Name = "up_id"
        Me.up_id.ReadOnly = True
        Me.up_id.Size = New System.Drawing.Size(263, 30)
        Me.up_id.TabIndex = 12
        '
        'up_name
        '
        Me.up_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.up_name.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up_name.Location = New System.Drawing.Point(684, 291)
        Me.up_name.Name = "up_name"
        Me.up_name.Size = New System.Drawing.Size(263, 30)
        Me.up_name.TabIndex = 13
        '
        'up_price
        '
        Me.up_price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.up_price.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up_price.Location = New System.Drawing.Point(684, 342)
        Me.up_price.Name = "up_price"
        Me.up_price.Size = New System.Drawing.Size(263, 30)
        Me.up_price.TabIndex = 14
        '
        'up_brand
        '
        Me.up_brand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.up_brand.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up_brand.Location = New System.Drawing.Point(684, 393)
        Me.up_brand.Name = "up_brand"
        Me.up_brand.Size = New System.Drawing.Size(263, 30)
        Me.up_brand.TabIndex = 15
        '
        'up_type
        '
        Me.up_type.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.up_type.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up_type.Location = New System.Drawing.Point(684, 444)
        Me.up_type.Name = "up_type"
        Me.up_type.Size = New System.Drawing.Size(263, 30)
        Me.up_type.TabIndex = 16
        '
        'up_colour
        '
        Me.up_colour.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.up_colour.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up_colour.Location = New System.Drawing.Point(684, 495)
        Me.up_colour.Name = "up_colour"
        Me.up_colour.Size = New System.Drawing.Size(263, 30)
        Me.up_colour.TabIndex = 17
        '
        'up_production_country
        '
        Me.up_production_country.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.up_production_country.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up_production_country.Location = New System.Drawing.Point(684, 546)
        Me.up_production_country.Name = "up_production_country"
        Me.up_production_country.Size = New System.Drawing.Size(263, 30)
        Me.up_production_country.TabIndex = 18
        '
        'btn_update
        '
        Me.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_update.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(826, 654)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(121, 30)
        Me.btn_update.TabIndex = 19
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_delete.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(983, 654)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(121, 30)
        Me.btn_delete.TabIndex = 20
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_back.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(1140, 654)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(121, 30)
        Me.btn_back.TabIndex = 21
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'pic_up
        '
        Me.pic_up.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_up.Location = New System.Drawing.Point(1011, 240)
        Me.pic_up.Name = "pic_up"
        Me.pic_up.Size = New System.Drawing.Size(250, 238)
        Me.pic_up.TabIndex = 22
        Me.pic_up.TabStop = False
        '
        'btn_picture2
        '
        Me.btn_picture2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_picture2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture2.Location = New System.Drawing.Point(1115, 549)
        Me.btn_picture2.Name = "btn_picture2"
        Me.btn_picture2.Size = New System.Drawing.Size(146, 30)
        Me.btn_picture2.TabIndex = 23
        Me.btn_picture2.Text = "Upload Picture"
        Me.btn_picture2.UseVisualStyleBackColor = True
        '
        'up_pic
        '
        Me.up_pic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.up_pic.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up_pic.Location = New System.Drawing.Point(1011, 498)
        Me.up_pic.Name = "up_pic"
        Me.up_pic.ReadOnly = True
        Me.up_pic.Size = New System.Drawing.Size(250, 26)
        Me.up_pic.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(509, 549)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 23)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Production Country :"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(509, 498)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 23)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Colour :"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(509, 447)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 23)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Type :"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(510, 396)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 23)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Brand :"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(509, 345)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 23)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Price :"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(509, 294)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 23)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Product Name :"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(509, 243)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 23)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Product ID :"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(510, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(584, 138)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = resources.GetString("Label16.Text")
        '
        'btn_add
        '
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_add.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(512, 654)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(121, 30)
        Me.btn_add.TabIndex = 41
        Me.btn_add.Text = "ADD NEW"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 40)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Product Management System"
        '
        'frm_insertproducts_a160841
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1294, 750)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.up_pic)
        Me.Controls.Add(Me.btn_picture2)
        Me.Controls.Add(Me.pic_up)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.up_production_country)
        Me.Controls.Add(Me.up_colour)
        Me.Controls.Add(Me.up_type)
        Me.Controls.Add(Me.up_brand)
        Me.Controls.Add(Me.up_price)
        Me.Controls.Add(Me.up_name)
        Me.Controls.Add(Me.up_id)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.grd_products)
        Me.Name = "frm_insertproducts_a160841"
        Me.Text = "frm_insertproducts_a160841"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_up, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_products As System.Windows.Forms.DataGridView
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents up_id As System.Windows.Forms.TextBox
    Friend WithEvents up_name As System.Windows.Forms.TextBox
    Friend WithEvents up_price As System.Windows.Forms.TextBox
    Friend WithEvents up_brand As System.Windows.Forms.TextBox
    Friend WithEvents up_type As System.Windows.Forms.TextBox
    Friend WithEvents up_colour As System.Windows.Forms.TextBox
    Friend WithEvents up_production_country As System.Windows.Forms.TextBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents pic_up As System.Windows.Forms.PictureBox
    Friend WithEvents btn_picture2 As System.Windows.Forms.Button
    Friend WithEvents up_pic As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
