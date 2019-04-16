<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu2_a160841
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu2_a160841))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_productlist = New System.Windows.Forms.Button()
        Me.btn_stafflist = New System.Windows.Forms.Button()
        Me.btn_customerlist = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(881, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BP SHOP DATA MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(940, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Here's where you can update , insert and delete the data"
        '
        'btn_productlist
        '
        Me.btn_productlist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_productlist.Font = New System.Drawing.Font("Tempus Sans ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productlist.Location = New System.Drawing.Point(162, 405)
        Me.btn_productlist.Name = "btn_productlist"
        Me.btn_productlist.Size = New System.Drawing.Size(160, 35)
        Me.btn_productlist.TabIndex = 5
        Me.btn_productlist.Text = "Product List"
        Me.btn_productlist.UseVisualStyleBackColor = True
        '
        'btn_stafflist
        '
        Me.btn_stafflist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_stafflist.Font = New System.Drawing.Font("Tempus Sans ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stafflist.Location = New System.Drawing.Point(430, 405)
        Me.btn_stafflist.Name = "btn_stafflist"
        Me.btn_stafflist.Size = New System.Drawing.Size(160, 35)
        Me.btn_stafflist.TabIndex = 6
        Me.btn_stafflist.Text = "Staff List"
        Me.btn_stafflist.UseVisualStyleBackColor = True
        '
        'btn_customerlist
        '
        Me.btn_customerlist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_customerlist.Font = New System.Drawing.Font("Tempus Sans ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customerlist.Location = New System.Drawing.Point(732, 405)
        Me.btn_customerlist.Name = "btn_customerlist"
        Me.btn_customerlist.Size = New System.Drawing.Size(160, 35)
        Me.btn_customerlist.TabIndex = 7
        Me.btn_customerlist.Text = "Customer List"
        Me.btn_customerlist.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_exit.Font = New System.Drawing.Font("Tempus Sans ITC", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(430, 540)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(160, 35)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "BACK"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_mainmenu2_a160841
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1027, 617)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_customerlist)
        Me.Controls.Add(Me.btn_stafflist)
        Me.Controls.Add(Me.btn_productlist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_mainmenu2_a160841"
        Me.Text = "frm_mainmenu2_a160841"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_productlist As System.Windows.Forms.Button
    Friend WithEvents btn_stafflist As System.Windows.Forms.Button
    Friend WithEvents btn_customerlist As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
End Class
