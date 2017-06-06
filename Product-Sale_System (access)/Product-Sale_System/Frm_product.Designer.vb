<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_product))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_findname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbo_findtype = New System.Windows.Forms.ComboBox()
        Me.lbl_countpro = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.DGV_product = New System.Windows.Forms.DataGridView()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.ofd_pro = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_cost = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbo_unit = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NUD_stock = New System.Windows.Forms.NumericUpDown()
        Me.lblwarnS = New System.Windows.Forms.Label()
        Me.lblwarnP = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_typeid = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_disbrith = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_dismem = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_discus = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.PTB_product = New System.Windows.Forms.PictureBox()
        Me.btn_findpic = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TS_product = New System.Windows.Forms.ToolStrip()
        Me.TSB_protype = New System.Windows.Forms.ToolStripButton()
        Me.TSB_prounit = New System.Windows.Forms.ToolStripButton()
        Me.TSB_exit = New System.Windows.Forms.ToolStripButton()
        Me.pd_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_discustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_dismember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_disbirday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_picture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUD_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTB_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TS_product.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(211, 22)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(65, 57)
        Me.btn_delete.TabIndex = 47
        Me.btn_delete.Text = "ลบข้อมูล"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.txt_findname)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cbo_findtype)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(12, 252)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 91)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหา"
        '
        'txt_findname
        '
        Me.txt_findname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_findname.Location = New System.Drawing.Point(124, 59)
        Me.txt_findname.MaxLength = 13
        Me.txt_findname.Multiline = True
        Me.txt_findname.Name = "txt_findname"
        Me.txt_findname.Size = New System.Drawing.Size(174, 20)
        Me.txt_findname.TabIndex = 67
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(28, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 16)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "รหัส/ชื่อสินค้า :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(30, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "ประเภทสินค้า :"
        '
        'cbo_findtype
        '
        Me.cbo_findtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_findtype.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_findtype.FormattingEnabled = True
        Me.cbo_findtype.Location = New System.Drawing.Point(124, 29)
        Me.cbo_findtype.Name = "cbo_findtype"
        Me.cbo_findtype.Size = New System.Drawing.Size(154, 21)
        Me.cbo_findtype.TabIndex = 35
        '
        'lbl_countpro
        '
        Me.lbl_countpro.AutoSize = True
        Me.lbl_countpro.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_countpro.ForeColor = System.Drawing.Color.Red
        Me.lbl_countpro.Location = New System.Drawing.Point(12, 626)
        Me.lbl_countpro.Name = "lbl_countpro"
        Me.lbl_countpro.Size = New System.Drawing.Size(144, 16)
        Me.lbl_countpro.TabIndex = 70
        Me.lbl_countpro.Text = "สินค้าทั้งหมด  0   รายการ"
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_edit.Location = New System.Drawing.Point(127, 22)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(65, 57)
        Me.btn_edit.TabIndex = 46
        Me.btn_edit.Text = "แก้ไข"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel.Location = New System.Drawing.Point(424, 22)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(65, 56)
        Me.btn_cancel.TabIndex = 49
        Me.btn_cancel.Text = "ยกเลิก"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'DGV_product
        '
        Me.DGV_product.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_product.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_product.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pd_id, Me.pd_name, Me.pd_brand, Me.type_id, Me.type_name, Me.pd_cost, Me.pd_price, Me.pd_stock, Me.unit_id, Me.unit_name, Me.pd_discustomer, Me.pd_dismember, Me.pd_disbirday, Me.pd_picture})
        Me.DGV_product.EnableHeadersVisualStyles = False
        Me.DGV_product.Location = New System.Drawing.Point(13, 10)
        Me.DGV_product.Name = "DGV_product"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_product.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DGV_product.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_product.Size = New System.Drawing.Size(1063, 248)
        Me.DGV_product.TabIndex = 62
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Enabled = False
        Me.btn_save.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_save.Location = New System.Drawing.Point(340, 22)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(65, 57)
        Me.btn_save.TabIndex = 48
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.btn_cancel)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.btn_save)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(395, 252)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 91)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "จัดการข้อมูล"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_add.Location = New System.Drawing.Point(44, 22)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(65, 57)
        Me.btn_add.TabIndex = 45
        Me.btn_add.Text = "เพิ่ม"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'ofd_pro
        '
        Me.ofd_pro.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txt_cost)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cbo_unit)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.NUD_stock)
        Me.GroupBox1.Controls.Add(Me.lblwarnS)
        Me.GroupBox1.Controls.Add(Me.lblwarnP)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbo_typeid)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_disbrith)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_dismem)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.txt_discus)
        Me.GroupBox1.Controls.Add(Me.txt_brand)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(894, 140)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลสินค้า"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(582, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 16)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "บาท"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(623, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 16)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(406, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 16)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "ราคาขาย :"
        '
        'txt_cost
        '
        Me.txt_cost.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_cost.Location = New System.Drawing.Point(476, 40)
        Me.txt_cost.Multiline = True
        Me.txt_cost.Name = "txt_cost"
        Me.txt_cost.Size = New System.Drawing.Size(100, 20)
        Me.txt_cost.TabIndex = 63
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(272, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 16)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "*"
        '
        'cbo_unit
        '
        Me.cbo_unit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_unit.FormattingEnabled = True
        Me.cbo_unit.Location = New System.Drawing.Point(547, 92)
        Me.cbo_unit.Name = "cbo_unit"
        Me.cbo_unit.Size = New System.Drawing.Size(75, 21)
        Me.cbo_unit.TabIndex = 61
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(582, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 16)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "บาท"
        '
        'NUD_stock
        '
        Me.NUD_stock.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NUD_stock.Location = New System.Drawing.Point(477, 91)
        Me.NUD_stock.Name = "NUD_stock"
        Me.NUD_stock.Size = New System.Drawing.Size(64, 23)
        Me.NUD_stock.TabIndex = 59
        '
        'lblwarnS
        '
        Me.lblwarnS.AutoSize = True
        Me.lblwarnS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblwarnS.ForeColor = System.Drawing.Color.Red
        Me.lblwarnS.Location = New System.Drawing.Point(623, 91)
        Me.lblwarnS.Name = "lblwarnS"
        Me.lblwarnS.Size = New System.Drawing.Size(16, 16)
        Me.lblwarnS.TabIndex = 55
        Me.lblwarnS.Text = "*"
        '
        'lblwarnP
        '
        Me.lblwarnP.AutoSize = True
        Me.lblwarnP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblwarnP.ForeColor = System.Drawing.Color.Red
        Me.lblwarnP.Location = New System.Drawing.Point(623, 38)
        Me.lblwarnP.Name = "lblwarnP"
        Me.lblwarnP.Size = New System.Drawing.Size(16, 16)
        Me.lblwarnP.TabIndex = 54
        Me.lblwarnP.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(813, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 16)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(817, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 16)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(813, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 16)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "%"
        '
        'cbo_typeid
        '
        Me.cbo_typeid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_typeid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_typeid.FormattingEnabled = True
        Me.cbo_typeid.Location = New System.Drawing.Point(134, 103)
        Me.cbo_typeid.Name = "cbo_typeid"
        Me.cbo_typeid.Size = New System.Drawing.Size(164, 21)
        Me.cbo_typeid.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(661, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "ส่วนลดวันเกิด :"
        '
        'txt_disbrith
        '
        Me.txt_disbrith.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_disbrith.Location = New System.Drawing.Point(756, 68)
        Me.txt_disbrith.Multiline = True
        Me.txt_disbrith.Name = "txt_disbrith"
        Me.txt_disbrith.Size = New System.Drawing.Size(51, 20)
        Me.txt_disbrith.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(657, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ส่วนลดสมาชิก :"
        '
        'txt_dismem
        '
        Me.txt_dismem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_dismem.Location = New System.Drawing.Point(756, 94)
        Me.txt_dismem.Multiline = True
        Me.txt_dismem.Name = "txt_dismem"
        Me.txt_dismem.Size = New System.Drawing.Size(51, 20)
        Me.txt_dismem.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(665, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "ส่วนลดลูกค้า :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(419, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "จำนวน :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(65, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ชื่อสินค้า :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(87, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ยี่ห้อ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ประเภทสินค้า :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(395, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ราคาต้นทุน :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(59, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "รหัสสินค้า :"
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_price.Location = New System.Drawing.Point(476, 66)
        Me.txt_price.Multiline = True
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 6
        '
        'txt_discus
        '
        Me.txt_discus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_discus.Location = New System.Drawing.Point(756, 43)
        Me.txt_discus.Multiline = True
        Me.txt_discus.Name = "txt_discus"
        Me.txt_discus.Size = New System.Drawing.Size(51, 20)
        Me.txt_discus.TabIndex = 4
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(134, 76)
        Me.txt_brand.Multiline = True
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(132, 20)
        Me.txt_brand.TabIndex = 3
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_name.Location = New System.Drawing.Point(134, 50)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(217, 20)
        Me.txt_name.TabIndex = 2
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_id.Location = New System.Drawing.Point(134, 24)
        Me.txt_id.MaxLength = 13
        Me.txt_id.Multiline = True
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(132, 20)
        Me.txt_id.TabIndex = 1
        '
        'PTB_product
        '
        Me.PTB_product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PTB_product.Image = CType(resources.GetObject("PTB_product.Image"), System.Drawing.Image)
        Me.PTB_product.Location = New System.Drawing.Point(13, 22)
        Me.PTB_product.Name = "PTB_product"
        Me.PTB_product.Size = New System.Drawing.Size(163, 154)
        Me.PTB_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PTB_product.TabIndex = 31
        Me.PTB_product.TabStop = False
        '
        'btn_findpic
        '
        Me.btn_findpic.BackColor = System.Drawing.Color.White
        Me.btn_findpic.Enabled = False
        Me.btn_findpic.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_findpic.Image = CType(resources.GetObject("btn_findpic.Image"), System.Drawing.Image)
        Me.btn_findpic.Location = New System.Drawing.Point(13, 182)
        Me.btn_findpic.Name = "btn_findpic"
        Me.btn_findpic.Size = New System.Drawing.Size(163, 39)
        Me.btn_findpic.TabIndex = 32
        Me.btn_findpic.Text = "ค้นหารูป"
        Me.btn_findpic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_findpic.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Controls.Add(Me.btn_findpic)
        Me.GroupBox4.Controls.Add(Me.PTB_product)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(912, 106)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(192, 237)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "รูปสินค้า"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Controls.Add(Me.DGV_product)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 349)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1092, 264)
        Me.GroupBox5.TabIndex = 71
        Me.GroupBox5.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1113, 45)
        Me.Panel2.TabIndex = 74
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(20, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 29)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "ข้อมูลสินค้า"
        '
        'TS_product
        '
        Me.TS_product.AutoSize = False
        Me.TS_product.BackColor = System.Drawing.Color.White
        Me.TS_product.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_protype, Me.TSB_prounit, Me.TSB_exit})
        Me.TS_product.Location = New System.Drawing.Point(0, 0)
        Me.TS_product.Name = "TS_product"
        Me.TS_product.Size = New System.Drawing.Size(1113, 51)
        Me.TS_product.TabIndex = 75
        Me.TS_product.Text = "ToolStrip1"
        '
        'TSB_protype
        '
        Me.TSB_protype.AutoSize = False
        Me.TSB_protype.BackColor = System.Drawing.Color.White
        Me.TSB_protype.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_protype.ForeColor = System.Drawing.Color.Black
        Me.TSB_protype.Image = CType(resources.GetObject("TSB_protype.Image"), System.Drawing.Image)
        Me.TSB_protype.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_protype.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_protype.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_protype.Name = "TSB_protype"
        Me.TSB_protype.Size = New System.Drawing.Size(100, 45)
        Me.TSB_protype.Text = "ประเภทสินค้า"
        Me.TSB_protype.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSB_prounit
        '
        Me.TSB_prounit.AutoSize = False
        Me.TSB_prounit.BackColor = System.Drawing.Color.White
        Me.TSB_prounit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_prounit.Image = CType(resources.GetObject("TSB_prounit.Image"), System.Drawing.Image)
        Me.TSB_prounit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_prounit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_prounit.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_prounit.Name = "TSB_prounit"
        Me.TSB_prounit.Size = New System.Drawing.Size(100, 45)
        Me.TSB_prounit.Text = "หน่วยนับสินค้า"
        Me.TSB_prounit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.TSB_exit.Size = New System.Drawing.Size(80, 45)
        Me.TSB_exit.Text = "ออก"
        Me.TSB_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pd_id
        '
        Me.pd_id.HeaderText = "รหัสสินค้า"
        Me.pd_id.Name = "pd_id"
        '
        'pd_name
        '
        Me.pd_name.HeaderText = "ชื่อสินค้า"
        Me.pd_name.Name = "pd_name"
        Me.pd_name.Width = 150
        '
        'pd_brand
        '
        Me.pd_brand.HeaderText = "ยี่ห้อ"
        Me.pd_brand.Name = "pd_brand"
        Me.pd_brand.Width = 90
        '
        'type_id
        '
        Me.type_id.HeaderText = "รหัสประเภทสินค้า"
        Me.type_id.Name = "type_id"
        Me.type_id.Visible = False
        '
        'type_name
        '
        Me.type_name.HeaderText = "ประเภทสินค้า"
        Me.type_name.Name = "type_name"
        Me.type_name.Width = 120
        '
        'pd_cost
        '
        Me.pd_cost.HeaderText = "ต้นทุน"
        Me.pd_cost.Name = "pd_cost"
        Me.pd_cost.Width = 65
        '
        'pd_price
        '
        Me.pd_price.HeaderText = "ราคา"
        Me.pd_price.Name = "pd_price"
        Me.pd_price.Width = 60
        '
        'pd_stock
        '
        Me.pd_stock.FillWeight = 80.0!
        Me.pd_stock.HeaderText = "จำนวน"
        Me.pd_stock.Name = "pd_stock"
        Me.pd_stock.Width = 60
        '
        'unit_id
        '
        Me.unit_id.HeaderText = "รหัสหน่วยนับ"
        Me.unit_id.Name = "unit_id"
        Me.unit_id.Visible = False
        '
        'unit_name
        '
        Me.unit_name.HeaderText = "หน่วยนับ"
        Me.unit_name.Name = "unit_name"
        Me.unit_name.Width = 80
        '
        'pd_discustomer
        '
        Me.pd_discustomer.HeaderText = "ส่วนลดลูกค้า/%"
        Me.pd_discustomer.Name = "pd_discustomer"
        '
        'pd_dismember
        '
        Me.pd_dismember.HeaderText = "ส่วนลดสมาชิก/%"
        Me.pd_dismember.Name = "pd_dismember"
        '
        'pd_disbirday
        '
        Me.pd_disbirday.HeaderText = "ส่วนลดวันเกิด/%"
        Me.pd_disbirday.Name = "pd_disbirday"
        '
        'pd_picture
        '
        Me.pd_picture.HeaderText = "ชื่อรูปภาพ"
        Me.pd_picture.Name = "pd_picture"
        Me.pd_picture.Width = 130
        '
        'Frm_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1113, 651)
        Me.Controls.Add(Me.TS_product)
        Me.Controls.Add(Me.lbl_countpro)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลสินค้า"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUD_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTB_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TS_product.ResumeLayout(False)
        Me.TS_product.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbo_findtype As System.Windows.Forms.ComboBox
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents DGV_product As System.Windows.Forms.DataGridView
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents ofd_pro As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbo_unit As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents NUD_stock As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblwarnS As System.Windows.Forms.Label
    Friend WithEvents lblwarnP As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbo_typeid As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_disbrith As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_dismem As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_discus As System.Windows.Forms.TextBox
    Friend WithEvents txt_brand As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents PTB_product As System.Windows.Forms.PictureBox
    Friend WithEvents btn_findpic As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_countpro As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_cost As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TS_product As System.Windows.Forms.ToolStrip
    Friend WithEvents TSB_protype As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_prounit As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_findname As System.Windows.Forms.TextBox
    Friend WithEvents pd_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_discustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_dismember As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_disbirday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_picture As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
