<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_saledetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_saledetail))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSB_sale = New System.Windows.Forms.ToolStripButton()
        Me.TSB_exit = New System.Windows.Forms.ToolStripButton()
        Me.DGV_saledetail = New System.Windows.Forms.DataGridView()
        Me.sale_detailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mem_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_discus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_sum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_sale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGV_subdetail = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_nub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_saletotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_discus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.dtp_End = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Start = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txt_find = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_sumtotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_distotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_totalSale = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGV_saledetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_subdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_sale, Me.TSB_exit})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1007, 51)
        Me.ToolStrip1.TabIndex = 80
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSB_sale
        '
        Me.TSB_sale.AutoSize = False
        Me.TSB_sale.BackColor = System.Drawing.Color.White
        Me.TSB_sale.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_sale.Image = CType(resources.GetObject("TSB_sale.Image"), System.Drawing.Image)
        Me.TSB_sale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_sale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_sale.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_sale.Name = "TSB_sale"
        Me.TSB_sale.Size = New System.Drawing.Size(80, 45)
        Me.TSB_sale.Text = "ขายสินค้า"
        Me.TSB_sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'DGV_saledetail
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_saledetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_saledetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_saledetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sale_detailID, Me.mem_status, Me.sale_total, Me.sale_discus, Me.sale_sum, Me.date_sale, Me.sale_num})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_saledetail.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_saledetail.EnableHeadersVisualStyles = False
        Me.DGV_saledetail.Location = New System.Drawing.Point(6, 10)
        Me.DGV_saledetail.Name = "DGV_saledetail"
        Me.DGV_saledetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_saledetail.Size = New System.Drawing.Size(925, 216)
        Me.DGV_saledetail.TabIndex = 81
        '
        'sale_detailID
        '
        Me.sale_detailID.HeaderText = "รหัสการขาย"
        Me.sale_detailID.Name = "sale_detailID"
        Me.sale_detailID.Width = 120
        '
        'mem_status
        '
        Me.mem_status.HeaderText = "สถานะลูกค้า"
        Me.mem_status.Name = "mem_status"
        Me.mem_status.Width = 150
        '
        'sale_total
        '
        Me.sale_total.HeaderText = "ราคารวม"
        Me.sale_total.Name = "sale_total"
        '
        'sale_discus
        '
        Me.sale_discus.HeaderText = "ส่วนลด"
        Me.sale_discus.Name = "sale_discus"
        '
        'sale_sum
        '
        Me.sale_sum.HeaderText = "ราคาสุทธิ"
        Me.sale_sum.Name = "sale_sum"
        Me.sale_sum.Width = 120
        '
        'date_sale
        '
        Me.date_sale.HeaderText = "วันที่ขาย"
        Me.date_sale.Name = "date_sale"
        Me.date_sale.Width = 170
        '
        'sale_num
        '
        Me.sale_num.HeaderText = "จำนวน/รายการ"
        Me.sale_num.Name = "sale_num"
        Me.sale_num.Width = 120
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(1, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1010, 45)
        Me.Panel2.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ขายสินค้า"
        '
        'DGV_subdetail
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_subdetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_subdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_subdetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.pro_id, Me.pro_name, Me.pro_nub, Me.sub_saletotal, Me.sub_discus, Me.sub_total})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_subdetail.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_subdetail.EnableHeadersVisualStyles = False
        Me.DGV_subdetail.Location = New System.Drawing.Point(6, 9)
        Me.DGV_subdetail.Name = "DGV_subdetail"
        Me.DGV_subdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_subdetail.Size = New System.Drawing.Size(785, 201)
        Me.DGV_subdetail.TabIndex = 83
        '
        'no
        '
        Me.no.HeaderText = "ที่"
        Me.no.Name = "no"
        Me.no.Width = 50
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
        Me.pro_name.Width = 170
        '
        'pro_nub
        '
        Me.pro_nub.HeaderText = "จำนวน"
        Me.pro_nub.Name = "pro_nub"
        Me.pro_nub.Width = 70
        '
        'sub_saletotal
        '
        Me.sub_saletotal.HeaderText = "ราคารวม"
        Me.sub_saletotal.Name = "sub_saletotal"
        '
        'sub_discus
        '
        Me.sub_discus.HeaderText = "ส่วนลด"
        Me.sub_discus.Name = "sub_discus"
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "ราคาสุทธิ"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.Width = 150
        '
        'btn_show
        '
        Me.btn_show.BackColor = System.Drawing.Color.White
        Me.btn_show.BackgroundImage = CType(resources.GetObject("btn_show.BackgroundImage"), System.Drawing.Image)
        Me.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show.Location = New System.Drawing.Point(359, 379)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(41, 48)
        Me.btn_show.TabIndex = 85
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.DGV_saledetail)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(937, 233)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.DGV_subdetail)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 427)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 219)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.White
        Me.btn_clear.BackgroundImage = CType(resources.GetObject("btn_clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clear.Location = New System.Drawing.Point(406, 379)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(41, 48)
        Me.btn_clear.TabIndex = 88
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'dtp_End
        '
        Me.dtp_End.CalendarFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_End.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_End.Location = New System.Drawing.Point(380, 11)
        Me.dtp_End.Name = "dtp_End"
        Me.dtp_End.Size = New System.Drawing.Size(174, 23)
        Me.dtp_End.TabIndex = 91
        Me.dtp_End.Value = New Date(2016, 2, 4, 23, 59, 0, 0)
        '
        'dtp_Start
        '
        Me.dtp_Start.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_Start.Location = New System.Drawing.Point(135, 11)
        Me.dtp_Start.Name = "dtp_Start"
        Me.dtp_Start.Size = New System.Drawing.Size(179, 23)
        Me.dtp_Start.TabIndex = 90
        Me.dtp_Start.Value = New Date(2016, 2, 4, 1, 1, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "เลือกช่วงวันที่ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "ถึงวันที่ :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.btn_ok)
        Me.GroupBox3.Controls.Add(Me.txt_find)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtp_Start)
        Me.GroupBox3.Controls.Add(Me.dtp_End)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(26, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(937, 40)
        Me.GroupBox3.TabIndex = 93
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหา"
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(877, 7)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(54, 30)
        Me.btn_ok.TabIndex = 94
        Me.btn_ok.Text = "ตกลง"
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'txt_find
        '
        Me.txt_find.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_find.Location = New System.Drawing.Point(680, 9)
        Me.txt_find.Name = "txt_find"
        Me.txt_find.Size = New System.Drawing.Size(176, 23)
        Me.txt_find.TabIndex = 93
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(576, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 16)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "รหัส/ชื่อสมาชิก :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.lbl_sumtotal)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.lbl_distotal)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lbl_totalSale)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(832, 427)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(131, 219)
        Me.GroupBox4.TabIndex = 94
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ยอดขาย"
        '
        'lbl_sumtotal
        '
        Me.lbl_sumtotal.BackColor = System.Drawing.Color.White
        Me.lbl_sumtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sumtotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sumtotal.ForeColor = System.Drawing.Color.Red
        Me.lbl_sumtotal.Location = New System.Drawing.Point(18, 158)
        Me.lbl_sumtotal.Name = "lbl_sumtotal"
        Me.lbl_sumtotal.Size = New System.Drawing.Size(107, 25)
        Me.lbl_sumtotal.TabIndex = 45
        Me.lbl_sumtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "ราคาสุทธิ"
        '
        'lbl_distotal
        '
        Me.lbl_distotal.BackColor = System.Drawing.Color.White
        Me.lbl_distotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_distotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_distotal.ForeColor = System.Drawing.Color.Red
        Me.lbl_distotal.Location = New System.Drawing.Point(18, 100)
        Me.lbl_distotal.Name = "lbl_distotal"
        Me.lbl_distotal.Size = New System.Drawing.Size(107, 25)
        Me.lbl_distotal.TabIndex = 43
        Me.lbl_distotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "ส่วนลด"
        '
        'lbl_totalSale
        '
        Me.lbl_totalSale.BackColor = System.Drawing.Color.White
        Me.lbl_totalSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_totalSale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalSale.ForeColor = System.Drawing.Color.Red
        Me.lbl_totalSale.Location = New System.Drawing.Point(18, 47)
        Me.lbl_totalSale.Name = "lbl_totalSale"
        Me.lbl_totalSale.Size = New System.Drawing.Size(107, 25)
        Me.lbl_totalSale.TabIndex = 41
        Me.lbl_totalSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "รวมทั้งหมด"
        '
        'Frm_saledetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1000, 686)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Frm_saledetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_saledetail"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGV_saledetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_subdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TSB_sale As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents DGV_saledetail As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DGV_subdetail As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_nub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_saletotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_discus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents sale_detailID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mem_status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_discus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_sum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_sale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents dtp_End As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_find As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_sumtotal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_distotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_totalSale As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
