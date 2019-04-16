<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splashscreen_a160841
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_splashscreen_a160841))
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_details = New System.Windows.Forms.Button()
        Me.btn_manage = New System.Windows.Forms.Button()
        Me.btn_makeorder = New System.Windows.Forms.Button()
        Me.btn_allinvoices = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_name
        '
        Me.lbl_name.AllowDrop = True
        Me.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(236, 163)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(337, 48)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Please enter your name below"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_name
        '
        Me.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txt_name.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(282, 244)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(238, 29)
        Me.txt_name.TabIndex = 1
        Me.txt_name.Text = "Anonymous"
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_start
        '
        Me.btn_start.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_start.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.Location = New System.Drawing.Point(282, 345)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(238, 29)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "View Records System"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AllowDrop = True
        Me.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(258, 56)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(283, 63)
        Me.lbl_title.TabIndex = 3
        Me.lbl_title.Text = "BP SHOP RECORDS"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_details
        '
        Me.btn_details.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_details.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_details.Location = New System.Drawing.Point(282, 399)
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(238, 29)
        Me.btn_details.TabIndex = 4
        Me.btn_details.Text = "View Product Detail"
        Me.btn_details.UseVisualStyleBackColor = True
        '
        'btn_manage
        '
        Me.btn_manage.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_manage.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manage.Location = New System.Drawing.Point(282, 450)
        Me.btn_manage.Name = "btn_manage"
        Me.btn_manage.Size = New System.Drawing.Size(238, 29)
        Me.btn_manage.TabIndex = 5
        Me.btn_manage.Text = "To Data Management System"
        Me.btn_manage.UseVisualStyleBackColor = True
        '
        'btn_makeorder
        '
        Me.btn_makeorder.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_makeorder.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeorder.Location = New System.Drawing.Point(282, 496)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.Size = New System.Drawing.Size(238, 29)
        Me.btn_makeorder.TabIndex = 6
        Me.btn_makeorder.Text = "Make Order"
        Me.btn_makeorder.UseVisualStyleBackColor = True
        '
        'btn_allinvoices
        '
        Me.btn_allinvoices.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_allinvoices.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_allinvoices.Location = New System.Drawing.Point(282, 542)
        Me.btn_allinvoices.Name = "btn_allinvoices"
        Me.btn_allinvoices.Size = New System.Drawing.Size(238, 29)
        Me.btn_allinvoices.TabIndex = 7
        Me.btn_allinvoices.Text = "View All Invoices"
        Me.btn_allinvoices.UseVisualStyleBackColor = True
        '
        'frm_splashscreen_a160841
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(776, 615)
        Me.Controls.Add(Me.btn_allinvoices)
        Me.Controls.Add(Me.btn_makeorder)
        Me.Controls.Add(Me.btn_manage)
        Me.Controls.Add(Me.btn_details)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_name)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "frm_splashscreen_a160841"
        Me.Text = "bp shop records"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents btn_details As System.Windows.Forms.Button
    Friend WithEvents btn_manage As System.Windows.Forms.Button
    Friend WithEvents btn_makeorder As System.Windows.Forms.Button
    Friend WithEvents btn_allinvoices As System.Windows.Forms.Button

End Class
