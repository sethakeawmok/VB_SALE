<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_staff
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_staff))
        Me.txt_stid = New System.Windows.Forms.TextBox()
        Me.txt_stfname = New System.Windows.Forms.TextBox()
        Me.txt_stlname = New System.Windows.Forms.TextBox()
        Me.txt_stpass = New System.Windows.Forms.TextBox()
        Me.txt_stuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBO_STid = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MkT_sttel = New System.Windows.Forms.MaskedTextBox()
        Me.DGV_staff = New System.Windows.Forms.DataGridView()
        Me.ST_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST_password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.txt_find = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TS_staffs = New System.Windows.Forms.ToolStrip()
        Me.TSB_position = New System.Windows.Forms.ToolStripButton()
        Me.TSB_exit = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblwarnP = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TS_staffs.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_stid
        '
        Me.txt_stid.Enabled = False
        Me.txt_stid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_stid.Location = New System.Drawing.Point(101, 41)
        Me.txt_stid.MaxLength = 6
        Me.txt_stid.Multiline = True
        Me.txt_stid.Name = "txt_stid"
        Me.txt_stid.Size = New System.Drawing.Size(128, 22)
        Me.txt_stid.TabIndex = 1
        '
        'txt_stfname
        '
        Me.txt_stfname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_stfname.Location = New System.Drawing.Point(101, 70)
        Me.txt_stfname.MaxLength = 50
        Me.txt_stfname.Multiline = True
        Me.txt_stfname.Name = "txt_stfname"
        Me.txt_stfname.Size = New System.Drawing.Size(150, 22)
        Me.txt_stfname.TabIndex = 2
        '
        'txt_stlname
        '
        Me.txt_stlname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_stlname.Location = New System.Drawing.Point(360, 67)
        Me.txt_stlname.MaxLength = 50
        Me.txt_stlname.Multiline = True
        Me.txt_stlname.Name = "txt_stlname"
        Me.txt_stlname.Size = New System.Drawing.Size(144, 22)
        Me.txt_stlname.TabIndex = 3
        '
        'txt_stpass
        '
        Me.txt_stpass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_stpass.Location = New System.Drawing.Point(101, 129)
        Me.txt_stpass.MaxLength = 30
        Me.txt_stpass.Multiline = True
        Me.txt_stpass.Name = "txt_stpass"
        Me.txt_stpass.Size = New System.Drawing.Size(128, 22)
        Me.txt_stpass.TabIndex = 6
        '
        'txt_stuser
        '
        Me.txt_stuser.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_stuser.Location = New System.Drawing.Point(101, 102)
        Me.txt_stuser.MaxLength = 30
        Me.txt_stuser.Multiline = True
        Me.txt_stuser.Name = "txt_stuser"
        Me.txt_stuser.Size = New System.Drawing.Size(128, 22)
        Me.txt_stuser.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "รหัสพนักงาน :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(290, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "โทรศัพท์ :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(293, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ตำแหน่ง :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(291, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "นามสกุล :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(62, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ชื่อ :"
        '
        'CBO_STid
        '
        Me.CBO_STid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_STid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CBO_STid.FormattingEnabled = True
        Me.CBO_STid.Location = New System.Drawing.Point(360, 99)
        Me.CBO_STid.Name = "CBO_STid"
        Me.CBO_STid.Size = New System.Drawing.Size(121, 24)
        Me.CBO_STid.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblwarnP)
        Me.GroupBox1.Controls.Add(Me.MkT_sttel)
        Me.GroupBox1.Controls.Add(Me.CBO_STid)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_stuser)
        Me.GroupBox1.Controls.Add(Me.txt_stpass)
        Me.GroupBox1.Controls.Add(Me.txt_stlname)
        Me.GroupBox1.Controls.Add(Me.txt_stfname)
        Me.GroupBox1.Controls.Add(Me.txt_stid)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(10, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 180)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "จัดการข้อมูลพนักงาน"
        '
        'MkT_sttel
        '
        Me.MkT_sttel.Location = New System.Drawing.Point(360, 128)
        Me.MkT_sttel.Name = "MkT_sttel"
        Me.MkT_sttel.Size = New System.Drawing.Size(144, 23)
        Me.MkT_sttel.TabIndex = 58
        '
        'DGV_staff
        '
        Me.DGV_staff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_staff.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_staff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ST_id, Me.ST_fname, Me.ST_lname, Me.SP_id, Me.SP_name, Me.ST_user, Me.ST_password, Me.ST_tel})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_staff.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_staff.EnableHeadersVisualStyles = False
        Me.DGV_staff.Location = New System.Drawing.Point(12, 296)
        Me.DGV_staff.Name = "DGV_staff"
        Me.DGV_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_staff.Size = New System.Drawing.Size(915, 220)
        Me.DGV_staff.TabIndex = 19
        '
        'ST_id
        '
        Me.ST_id.HeaderText = "รหัสพนักงาน"
        Me.ST_id.Name = "ST_id"
        Me.ST_id.Width = 110
        '
        'ST_fname
        '
        Me.ST_fname.HeaderText = "ชื่อ"
        Me.ST_fname.Name = "ST_fname"
        Me.ST_fname.Width = 150
        '
        'ST_lname
        '
        Me.ST_lname.HeaderText = "นามสกุล"
        Me.ST_lname.Name = "ST_lname"
        Me.ST_lname.Width = 150
        '
        'SP_id
        '
        Me.SP_id.HeaderText = "รหัสตำแหน่ง"
        Me.SP_id.Name = "SP_id"
        Me.SP_id.Visible = False
        '
        'SP_name
        '
        Me.SP_name.HeaderText = "ตำแหน่ง"
        Me.SP_name.Name = "SP_name"
        Me.SP_name.Width = 130
        '
        'ST_user
        '
        Me.ST_user.HeaderText = "username"
        Me.ST_user.Name = "ST_user"
        '
        'ST_password
        '
        Me.ST_password.HeaderText = "Password"
        Me.ST_password.Name = "ST_password"
        '
        'ST_tel
        '
        Me.ST_tel.HeaderText = "เบอร์โทร"
        Me.ST_tel.Name = "ST_tel"
        Me.ST_tel.Width = 130
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btn_cancel)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.btn_save)
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Location = New System.Drawing.Point(548, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 91)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel.Location = New System.Drawing.Point(303, 19)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(65, 61)
        Me.btn_cancel.TabIndex = 49
        Me.btn_cancel.Text = "ยกเลิก"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.LightCoral
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_add.Location = New System.Drawing.Point(7, 19)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(65, 61)
        Me.btn_add.TabIndex = 11
        Me.btn_add.Text = "เพิ่ม"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.LightCoral
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Enabled = False
        Me.btn_save.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_save.Location = New System.Drawing.Point(220, 19)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(65, 61)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.LightCoral
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(149, 19)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(65, 61)
        Me.btn_delete.TabIndex = 10
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.LightCoral
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_edit.Location = New System.Drawing.Point(78, 19)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(65, 61)
        Me.btn_edit.TabIndex = 9
        Me.btn_edit.Text = "แก้ไข"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'txt_find
        '
        Me.txt_find.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_find.Location = New System.Drawing.Point(162, 33)
        Me.txt_find.MaxLength = 50
        Me.txt_find.Multiline = True
        Me.txt_find.Name = "txt_find"
        Me.txt_find.Size = New System.Drawing.Size(159, 23)
        Me.txt_find.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(52, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "รหัส/ชื่อตำแหน่ง :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_find)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(548, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 83)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหาพนักงาน"
        '
        'TS_staffs
        '
        Me.TS_staffs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TS_staffs.AutoSize = False
        Me.TS_staffs.BackColor = System.Drawing.Color.White
        Me.TS_staffs.Dock = System.Windows.Forms.DockStyle.None
        Me.TS_staffs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_position, Me.TSB_exit})
        Me.TS_staffs.Location = New System.Drawing.Point(0, 0)
        Me.TS_staffs.Name = "TS_staffs"
        Me.TS_staffs.Size = New System.Drawing.Size(949, 51)
        Me.TS_staffs.TabIndex = 78
        Me.TS_staffs.Text = "ToolStrip1"
        '
        'TSB_position
        '
        Me.TSB_position.AutoSize = False
        Me.TSB_position.BackColor = System.Drawing.Color.White
        Me.TSB_position.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_position.Image = CType(resources.GetObject("TSB_position.Image"), System.Drawing.Image)
        Me.TSB_position.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_position.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_position.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_position.Name = "TSB_position"
        Me.TSB_position.Size = New System.Drawing.Size(100, 45)
        Me.TSB_position.Text = "จัดการตำแหน่ง"
        Me.TSB_position.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSB_exit
        '
        Me.TSB_exit.AutoSize = False
        Me.TSB_exit.BackColor = System.Drawing.Color.White
        Me.TSB_exit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_exit.Image = CType(resources.GetObject("TSB_exit.Image"), System.Drawing.Image)
        Me.TSB_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_exit.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_exit.Name = "TSB_exit"
        Me.TSB_exit.Size = New System.Drawing.Size(100, 45)
        Me.TSB_exit.Text = "ออก"
        Me.TSB_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.Brown
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(949, 45)
        Me.Panel2.TabIndex = 79
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(20, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 29)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "พนักงาน"
        '
        'lblwarnP
        '
        Me.lblwarnP.AutoSize = True
        Me.lblwarnP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblwarnP.ForeColor = System.Drawing.Color.Red
        Me.lblwarnP.Location = New System.Drawing.Point(235, 41)
        Me.lblwarnP.Name = "lblwarnP"
        Me.lblwarnP.Size = New System.Drawing.Size(16, 16)
        Me.lblwarnP.TabIndex = 59
        Me.lblwarnP.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(235, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(235, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 16)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(507, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 16)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(257, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 16)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(507, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 16)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "*"
        '
        'Frm_staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(949, 530)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TS_staffs)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGV_staff)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Name = "Frm_staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พนักงาน"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TS_staffs.ResumeLayout(False)
        Me.TS_staffs.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_stid As System.Windows.Forms.TextBox
    Friend WithEvents txt_stfname As System.Windows.Forms.TextBox
    Friend WithEvents txt_stlname As System.Windows.Forms.TextBox
    Friend WithEvents txt_stpass As System.Windows.Forms.TextBox
    Friend WithEvents txt_stuser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBO_STid As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_staff As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents txt_find As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TS_staffs As System.Windows.Forms.ToolStrip
    Friend WithEvents TSB_exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TSB_position As System.Windows.Forms.ToolStripButton
    Friend WithEvents ST_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ST_fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ST_lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SP_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SP_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ST_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ST_password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ST_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MkT_sttel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblwarnP As System.Windows.Forms.Label
End Class
