<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productlist_a160841
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productlist_a160841))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(398, 20)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(219, 49)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Product List"
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AllowUserToDeleteRows = False
        Me.grd_product.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(50, 185)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.Size = New System.Drawing.Size(900, 404)
        Me.grd_product.TabIndex = 1
        '
        'btn_back
        '
        Me.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_back.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(425, 622)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(150, 26)
        Me.btn_back.TabIndex = 2
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_search.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(522, 113)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(281, 33)
        Me.txt_search.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search By Product's Name :"
        '
        'frm_productlist_a160841
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(984, 684)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_productlist_a160841"
        Me.Text = "frm_productlist_a160841"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents grd_product As System.Windows.Forms.DataGridView
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
