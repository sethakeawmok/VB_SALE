<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_sale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_sale))
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.DGV_sale = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_stork = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dis_percen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dis_bath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_sum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUD_num = New System.Windows.Forms.NumericUpDown()
        Me.lbl_showDC = New System.Windows.Forms.Label()
        Me.btn_chkmem = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_namemem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_memid = New System.Windows.Forms.TextBox()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_distotal = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_saleid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_sale = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.lbl_pricesum = New System.Windows.Forms.Label()
        Me.btn_savedb = New System.Windows.Forms.Button()
        Me.lbl_pritotal = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_findid = New System.Windows.Forms.TextBox()
        Me.lbl_storktotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_confirmsale = New System.Windows.Forms.Button()
        Me.CB_report = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSB_detai = New System.Windows.Forms.ToolStripButton()
        Me.TSB_exit = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGV_sale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_discount
        '
        Me.lbl_discount.BackColor = System.Drawing.Color.White
        Me.lbl_discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_discount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_discount.ForeColor = System.Drawing.Color.Black
        Me.lbl_discount.Location = New System.Drawing.Point(700, 36)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(33, 22)
        Me.lbl_discount.TabIndex = 50
        Me.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_edit.Enabled = False
        Me.btn_edit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Location = New System.Drawing.Point(865, 31)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 35)
        Me.btn_edit.TabIndex = 52
        Me.btn_edit.Text = "แก้ไข"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'lbl_price
        '
        Me.lbl_price.BackColor = System.Drawing.Color.White
        Me.lbl_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_price.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.Black
        Me.lbl_price.Location = New System.Drawing.Point(317, 36)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(100, 22)
        Me.lbl_price.TabIndex = 48
        Me.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_find
        '
        Me.btn_find.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_find.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_find.ForeColor = System.Drawing.Color.White
        Me.btn_find.Location = New System.Drawing.Point(215, 37)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(47, 24)
        Me.btn_find.TabIndex = 46
        Me.btn_find.Text = "ค้นหา"
        Me.btn_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_find.UseVisualStyleBackColor = False
        '
        'lbl_brand
        '
        Me.lbl_brand.BackColor = System.Drawing.Color.White
        Me.lbl_brand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_brand.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.Color.Black
        Me.lbl_brand.Location = New System.Drawing.Point(396, 72)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(143, 22)
        Me.lbl_brand.TabIndex = 47
        Me.lbl_brand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGV_sale
        '
        Me.DGV_sale.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_sale.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_sale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.pro_id, Me.pro_name, Me.pro_brand, Me.pro_price, Me.pro_stork, Me.price_total, Me.dis_percen, Me.dis_bath, Me.price_sum})
        Me.DGV_sale.EnableHeadersVisualStyles = False
        Me.DGV_sale.Location = New System.Drawing.Point(13, 314)
        Me.DGV_sale.Name = "DGV_sale"
        Me.DGV_sale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_sale.Size = New System.Drawing.Size(948, 228)
        Me.DGV_sale.TabIndex = 22
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Width = 40
        '
        'pro_id
        '
        Me.pro_id.HeaderText = "รหัสสินค้า"
        Me.pro_id.Name = "pro_id"
        '
        'pro_name
        '
        Me.pro_name.HeaderText = "ชื่อสินค้า"
        Me.pro_name.Name = "pro_name"
        Me.pro_name.Width = 150
        '
        'pro_brand
        '
        Me.pro_brand.HeaderText = "ยี่ห้อ"
        Me.pro_brand.Name = "pro_brand"
        '
        'pro_price
        '
        Me.pro_price.HeaderText = "ราคา"
        Me.pro_price.Name = "pro_price"
        '
        'pro_stork
        '
        Me.pro_stork.HeaderText = "จำนวน"
        Me.pro_stork.Name = "pro_stork"
        '
        'price_total
        '
        Me.price_total.HeaderText = "ราคารวม"
        Me.price_total.Name = "price_total"
        '
        'dis_percen
        '
        Me.dis_percen.HeaderText = "ส่วนลด %"
        Me.dis_percen.Name = "dis_percen"
        Me.dis_percen.Visible = False
        '
        'dis_bath
        '
        Me.dis_bath.HeaderText = "ส่วนลด"
        Me.dis_bath.Name = "dis_bath"
        '
        'price_sum
        '
        Me.price_sum.HeaderText = "ราคาสุทธิ"
        Me.price_sum.Name = "price_sum"
        Me.price_sum.Width = 110
        '
        'lbl_name
        '
        Me.lbl_name.BackColor = System.Drawing.Color.White
        Me.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_name.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_name.Location = New System.Drawing.Point(94, 72)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(249, 22)
        Me.lbl_name.TabIndex = 31
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(536, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "จำนวน :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(736, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(644, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "ส่วนลด :"
        '
        'NUD_num
        '
        Me.NUD_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUD_num.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NUD_num.Location = New System.Drawing.Point(594, 36)
        Me.NUD_num.Name = "NUD_num"
        Me.NUD_num.Size = New System.Drawing.Size(44, 23)
        Me.NUD_num.TabIndex = 58
        Me.NUD_num.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_showDC
        '
        Me.lbl_showDC.AutoSize = True
        Me.lbl_showDC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_showDC.ForeColor = System.Drawing.Color.Red
        Me.lbl_showDC.Location = New System.Drawing.Point(618, 75)
        Me.lbl_showDC.Name = "lbl_showDC"
        Me.lbl_showDC.Size = New System.Drawing.Size(51, 16)
        Me.lbl_showDC.TabIndex = 56
        Me.lbl_showDC.Text = "สมาชิก"
        '
        'btn_chkmem
        '
        Me.btn_chkmem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_chkmem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_chkmem.ForeColor = System.Drawing.Color.White
        Me.btn_chkmem.Location = New System.Drawing.Point(331, 45)
        Me.btn_chkmem.Name = "btn_chkmem"
        Me.btn_chkmem.Size = New System.Drawing.Size(67, 36)
        Me.btn_chkmem.TabIndex = 58
        Me.btn_chkmem.Text = "ตกลง"
        Me.btn_chkmem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_chkmem.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Red
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(865, 72)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 36)
        Me.btn_cancel.TabIndex = 55
        Me.btn_cancel.Text = "ยกเลิก"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.btn_chkmem)
        Me.GroupBox1.Controls.Add(Me.txt_namemem)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_memid)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(16, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 122)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "สำหรับสมาชิก"
        '
        'txt_namemem
        '
        Me.txt_namemem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_namemem.Location = New System.Drawing.Point(138, 65)
        Me.txt_namemem.Name = "txt_namemem"
        Me.txt_namemem.ReadOnly = True
        Me.txt_namemem.Size = New System.Drawing.Size(187, 23)
        Me.txt_namemem.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(55, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "รหัสสมาชิก :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(61, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ชื่อสมาชิก :"
        '
        'txt_memid
        '
        Me.txt_memid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_memid.Location = New System.Drawing.Point(138, 36)
        Me.txt_memid.Name = "txt_memid"
        Me.txt_memid.Size = New System.Drawing.Size(187, 23)
        Me.txt_memid.TabIndex = 2
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_remove.Enabled = False
        Me.btn_remove.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_remove.ForeColor = System.Drawing.Color.White
        Me.btn_remove.Location = New System.Drawing.Point(784, 72)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(75, 35)
        Me.btn_remove.TabIndex = 53
        Me.btn_remove.Text = "เอาออก"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(312, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 19)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "บาท"
        '
        'lbl_distotal
        '
        Me.lbl_distotal.BackColor = System.Drawing.Color.White
        Me.lbl_distotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_distotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_distotal.ForeColor = System.Drawing.Color.Red
        Me.lbl_distotal.Location = New System.Drawing.Point(188, 49)
        Me.lbl_distotal.Name = "lbl_distotal"
        Me.lbl_distotal.Size = New System.Drawing.Size(118, 25)
        Me.lbl_distotal.TabIndex = 60
        Me.lbl_distotal.Text = "0.00"
        Me.lbl_distotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(40, 87)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 19)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "ราคาสุทธิ :"
        '
        'txt_saleid
        '
        Me.txt_saleid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_saleid.Location = New System.Drawing.Point(122, 19)
        Me.txt_saleid.MaxLength = 10
        Me.txt_saleid.Multiline = True
        Me.txt_saleid.Name = "txt_saleid"
        Me.txt_saleid.Size = New System.Drawing.Size(142, 20)
        Me.txt_saleid.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(312, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 19)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "บาท"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "รหัสการขาย :"
        '
        'DTP_sale
        '
        Me.DTP_sale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTP_sale.Enabled = False
        Me.DTP_sale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTP_sale.Location = New System.Drawing.Point(761, 16)
        Me.DTP_sale.Name = "DTP_sale"
        Me.DTP_sale.Size = New System.Drawing.Size(200, 23)
        Me.DTP_sale.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(19, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "รหัสสินค้า :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(713, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "วันที่ :"
        '
        'btn_print
        '
        Me.btn_print.Enabled = False
        Me.btn_print.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_print.Location = New System.Drawing.Point(797, 723)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(84, 35)
        Me.btn_print.TabIndex = 54
        Me.btn_print.Text = "พิมพ์ใบเสร็จ"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'lbl_pricesum
        '
        Me.lbl_pricesum.BackColor = System.Drawing.Color.White
        Me.lbl_pricesum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_pricesum.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pricesum.ForeColor = System.Drawing.Color.Red
        Me.lbl_pricesum.Location = New System.Drawing.Point(134, 84)
        Me.lbl_pricesum.Name = "lbl_pricesum"
        Me.lbl_pricesum.Size = New System.Drawing.Size(172, 25)
        Me.lbl_pricesum.TabIndex = 63
        Me.lbl_pricesum.Text = "0.00"
        Me.lbl_pricesum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_savedb
        '
        Me.btn_savedb.Enabled = False
        Me.btn_savedb.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_savedb.Location = New System.Drawing.Point(661, 723)
        Me.btn_savedb.Name = "btn_savedb"
        Me.btn_savedb.Size = New System.Drawing.Size(127, 35)
        Me.btn_savedb.TabIndex = 56
        Me.btn_savedb.Text = "ยืนยันการขาย"
        Me.btn_savedb.UseVisualStyleBackColor = True
        '
        'lbl_pritotal
        '
        Me.lbl_pritotal.BackColor = System.Drawing.Color.White
        Me.lbl_pritotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_pritotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pritotal.ForeColor = System.Drawing.Color.Red
        Me.lbl_pritotal.Location = New System.Drawing.Point(134, 16)
        Me.lbl_pritotal.Name = "lbl_pritotal"
        Me.lbl_pritotal.Size = New System.Drawing.Size(172, 25)
        Me.lbl_pritotal.TabIndex = 57
        Me.lbl_pritotal.Text = "0.00"
        Me.lbl_pritotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.txt_findid)
        Me.GroupBox3.Controls.Add(Me.lbl_storktotal)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.NUD_num)
        Me.GroupBox3.Controls.Add(Me.lbl_showDC)
        Me.GroupBox3.Controls.Add(Me.btn_cancel)
        Me.GroupBox3.Controls.Add(Me.btn_remove)
        Me.GroupBox3.Controls.Add(Me.lbl_discount)
        Me.GroupBox3.Controls.Add(Me.lbl_price)
        Me.GroupBox3.Controls.Add(Me.btn_edit)
        Me.GroupBox3.Controls.Add(Me.btn_find)
        Me.GroupBox3.Controls.Add(Me.lbl_brand)
        Me.GroupBox3.Controls.Add(Me.lbl_name)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btn_add)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(16, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(948, 135)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "รายการสินค้า"
        '
        'txt_findid
        '
        Me.txt_findid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_findid.Location = New System.Drawing.Point(94, 37)
        Me.txt_findid.MaxLength = 13
        Me.txt_findid.Name = "txt_findid"
        Me.txt_findid.Size = New System.Drawing.Size(122, 23)
        Me.txt_findid.TabIndex = 66
        '
        'lbl_storktotal
        '
        Me.lbl_storktotal.BackColor = System.Drawing.Color.White
        Me.lbl_storktotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_storktotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_storktotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_storktotal.Location = New System.Drawing.Point(484, 36)
        Me.lbl_storktotal.Name = "lbl_storktotal"
        Me.lbl_storktotal.Size = New System.Drawing.Size(46, 22)
        Me.lbl_storktotal.TabIndex = 66
        Me.lbl_storktotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(423, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 16)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "ทั้งหมด :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(569, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "สถานะ :"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_add.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(784, 31)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 35)
        Me.btn_add.TabIndex = 45
        Me.btn_add.Text = "เพิ่มสินค้า"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(268, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 16)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "ราคา :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(349, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 16)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "ยี่ห้อ :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(25, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "ชื่อสินค้า :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(59, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 19)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "ส่วนลด :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.DGV_sale)
        Me.GroupBox5.Controls.Add(Me.txt_saleid)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.DTP_sale)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.btn_print)
        Me.GroupBox5.Controls.Add(Me.btn_savedb)
        Me.GroupBox5.Controls.Add(Me.GroupBox3)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(982, 572)
        Me.GroupBox5.TabIndex = 67
        Me.GroupBox5.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.btn_confirmsale)
        Me.GroupBox2.Controls.Add(Me.CB_report)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lbl_distotal)
        Me.GroupBox2.Controls.Add(Me.lbl_pricesum)
        Me.GroupBox2.Controls.Add(Me.lbl_pritotal)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(449, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(512, 122)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        '
        'btn_confirmsale
        '
        Me.btn_confirmsale.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_confirmsale.Enabled = False
        Me.btn_confirmsale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_confirmsale.ForeColor = System.Drawing.Color.White
        Me.btn_confirmsale.Location = New System.Drawing.Point(379, 77)
        Me.btn_confirmsale.Name = "btn_confirmsale"
        Me.btn_confirmsale.Size = New System.Drawing.Size(127, 35)
        Me.btn_confirmsale.TabIndex = 66
        Me.btn_confirmsale.Text = "ยืนยันการขาย"
        Me.btn_confirmsale.UseVisualStyleBackColor = False
        '
        'CB_report
        '
        Me.CB_report.AutoSize = True
        Me.CB_report.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CB_report.Location = New System.Drawing.Point(388, 54)
        Me.CB_report.Name = "CB_report"
        Me.CB_report.Size = New System.Drawing.Size(88, 17)
        Me.CB_report.TabIndex = 65
        Me.CB_report.Text = "พิมพ์ใบเสร็จ"
        Me.CB_report.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(312, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 19)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "บาท"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(44, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 19)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "ราคารวม :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_detai, Me.TSB_exit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1010, 51)
        Me.ToolStrip1.TabIndex = 79
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSB_detai
        '
        Me.TSB_detai.AutoSize = False
        Me.TSB_detai.BackColor = System.Drawing.Color.White
        Me.TSB_detai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_detai.Image = CType(resources.GetObject("TSB_detai.Image"), System.Drawing.Image)
        Me.TSB_detai.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_detai.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_detai.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_detai.Name = "TSB_detai"
        Me.TSB_detai.Size = New System.Drawing.Size(100, 45)
        Me.TSB_detai.Text = "รายละเอียดการขาย"
        Me.TSB_detai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1010, 45)
        Me.Panel2.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(20, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ขายสินค้า"
        '
        'Frm_sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_sale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ขายสินค้า"
        CType(Me.DGV_sale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_discount As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents btn_find As System.Windows.Forms.Button
    Friend WithEvents lbl_brand As System.Windows.Forms.Label
    Friend WithEvents DGV_sale As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NUD_num As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_showDC As System.Windows.Forms.Label
    Friend WithEvents btn_chkmem As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_namemem As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_memid As System.Windows.Forms.TextBox
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbl_distotal As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_saleid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_sale As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents lbl_pricesum As System.Windows.Forms.Label
    Friend WithEvents btn_savedb As System.Windows.Forms.Button
    Friend WithEvents lbl_pritotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TSB_exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_stork As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dis_percen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dis_bath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_sum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_confirmsale As System.Windows.Forms.Button
    Friend WithEvents CB_report As System.Windows.Forms.CheckBox
    Friend WithEvents TSB_detai As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_storktotal As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_findid As System.Windows.Forms.TextBox
End Class
