<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice_a160841
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_invoice_a160841))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_invoice = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_order = New System.Windows.Forms.ComboBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.lbl_customer = New System.Windows.Forms.Label()
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Juice ITC", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(202, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO BP SHOP INVOICE PAGE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grd_invoice
        '
        Me.grd_invoice.AllowUserToAddRows = False
        Me.grd_invoice.AllowUserToDeleteRows = False
        Me.grd_invoice.AllowUserToResizeColumns = False
        Me.grd_invoice.AllowUserToResizeRows = False
        Me.grd_invoice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_invoice.Location = New System.Drawing.Point(425, 109)
        Me.grd_invoice.Name = "grd_invoice"
        Me.grd_invoice.ReadOnly = True
        Me.grd_invoice.Size = New System.Drawing.Size(383, 245)
        Me.grd_invoice.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(349, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "BACK TO HOME SCREEN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cb_order
        '
        Me.cb_order.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_order.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_order.FormattingEnabled = True
        Me.cb_order.Location = New System.Drawing.Point(170, 106)
        Me.cb_order.Name = "cb_order"
        Me.cb_order.Size = New System.Drawing.Size(125, 31)
        Me.cb_order.TabIndex = 3
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(67, 331)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_total.Size = New System.Drawing.Size(53, 23)
        Me.lbl_total.TabIndex = 4
        Me.lbl_total.Text = "Total"
        '
        'lbl_order
        '
        Me.lbl_order.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_order.AutoSize = True
        Me.lbl_order.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.Location = New System.Drawing.Point(67, 109)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(97, 23)
        Me.lbl_order.TabIndex = 5
        Me.lbl_order.Text = "Order ID : "
        '
        'lbl_staff
        '
        Me.lbl_staff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.Location = New System.Drawing.Point(67, 168)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(128, 23)
        Me.lbl_staff.TabIndex = 6
        Me.lbl_staff.Text = "Staff ID :        "
        '
        'lbl_customer
        '
        Me.lbl_customer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(67, 227)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(162, 23)
        Me.lbl_customer.TabIndex = 7
        Me.lbl_customer.Text = "Customer ID :        "
        '
        'frm_invoice_a160841
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(884, 471)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.lbl_order)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.cb_order)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grd_invoice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_invoice_a160841"
        Me.Text = "frm_invoice_a160841"
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grd_invoice As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cb_order As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_order As System.Windows.Forms.Label
    Friend WithEvents lbl_staff As System.Windows.Forms.Label
    Friend WithEvents lbl_customer As System.Windows.Forms.Label
End Class
