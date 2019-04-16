<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderlist_a160841
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderlist_a160841))
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(42, 191)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.Size = New System.Drawing.Size(900, 404)
        Me.grd_order.TabIndex = 3
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(407, 133)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(152, 38)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Order List"
        '
        'btn_back
        '
        Me.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_back.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(425, 655)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(150, 26)
        Me.btn_back.TabIndex = 4
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_orderlist_a160841
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(984, 729)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_orderlist_a160841"
        Me.Text = "frm_orderlist_a160841"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_order As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
End Class
