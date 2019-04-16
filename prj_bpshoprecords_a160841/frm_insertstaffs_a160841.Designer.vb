<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaffs_a160841
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertstaffs_a160841))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.up_name = New System.Windows.Forms.TextBox()
        Me.up_id = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_back.Font = New System.Drawing.Font("Tempus Sans ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(506, 513)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(120, 34)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_delete.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(992, 420)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(101, 30)
        Me.btn_delete.TabIndex = 73
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_update.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(992, 369)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(101, 30)
        Me.btn_update.TabIndex = 72
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_insert.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(992, 213)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(101, 30)
        Me.btn_insert.TabIndex = 71
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(469, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(696, 78)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "_________________________________________________________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Update And Delete Pa" & _
            "rt :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(469, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 26)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Insert Part :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(470, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 23)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Staff Name :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(470, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Staff ID :"
        '
        'up_name
        '
        Me.up_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.up_name.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up_name.Location = New System.Drawing.Point(645, 421)
        Me.up_name.Name = "up_name"
        Me.up_name.Size = New System.Drawing.Size(263, 30)
        Me.up_name.TabIndex = 66
        '
        'up_id
        '
        Me.up_id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.up_id.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up_id.Location = New System.Drawing.Point(645, 370)
        Me.up_id.Name = "up_id"
        Me.up_id.ReadOnly = True
        Me.up_id.Size = New System.Drawing.Size(263, 30)
        Me.up_id.TabIndex = 65
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(470, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 23)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Staff Name :"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(470, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 23)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Staff ID :"
        '
        'txt_name
        '
        Me.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_name.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(645, 213)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(263, 30)
        Me.txt_name.TabIndex = 62
        '
        'txt_id
        '
        Me.txt_id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_id.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(645, 162)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(263, 30)
        Me.txt_id.TabIndex = 61
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AllowUserToDeleteRows = False
        Me.grd_staff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_staff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(17, 113)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.Size = New System.Drawing.Size(400, 346)
        Me.grd_staff.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(407, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 40)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Staff Management System"
        '
        'frm_insertstaffs_a160841
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1183, 577)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.up_name)
        Me.Controls.Add(Me.up_id)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_back)
        Me.Name = "frm_insertstaffs_a160841"
        Me.Text = "frm_insertstaffs_a160841"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents up_name As System.Windows.Forms.TextBox
    Friend WithEvents up_id As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents grd_staff As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
