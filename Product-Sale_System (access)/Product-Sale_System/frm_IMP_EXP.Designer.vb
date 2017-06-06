<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_IMP_EXP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_IMP_EXP))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_Start = New System.Windows.Forms.DateTimePicker()
        Me.dtp_End = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_subdetail = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_nub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_saletotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_discus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSB_sale = New System.Windows.Forms.ToolStripButton()
        Me.TSB_exit = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DGV_product = New System.Windows.Forms.DataGridView()
        Me.pd_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_CREATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_picture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_subdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGV_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "ราคาสุทธิ"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.Width = 150
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
        'dtp_Start
        '
        Me.dtp_Start.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_Start.Location = New System.Drawing.Point(135, 11)
        Me.dtp_Start.Name = "dtp_Start"
        Me.dtp_Start.Size = New System.Drawing.Size(179, 23)
        Me.dtp_Start.TabIndex = 90
        Me.dtp_Start.Value = New Date(2016, 2, 4, 1, 1, 0, 0)
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
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(575, 9)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(54, 30)
        Me.btn_ok.TabIndex = 94
        Me.btn_ok.Text = "ตกลง"
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.btn_ok)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtp_Start)
        Me.GroupBox3.Controls.Add(Me.dtp_End)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(34, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1309, 40)
        Me.GroupBox3.TabIndex = 102
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหา"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.DGV_subdetail)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 427)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 219)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        '
        'DGV_subdetail
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_subdetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_subdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_subdetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.pro_id, Me.pro_name, Me.pro_nub, Me.sub_saletotal, Me.sub_discus, Me.sub_total})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_subdetail.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_subdetail.EnableHeadersVisualStyles = False
        Me.DGV_subdetail.Location = New System.Drawing.Point(6, 9)
        Me.DGV_subdetail.Name = "DGV_subdetail"
        Me.DGV_subdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_subdetail.Size = New System.Drawing.Size(794, 201)
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
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_sale, Me.TSB_exit})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1379, 51)
        Me.ToolStrip1.TabIndex = 96
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(29, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 29)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "ขายสินค้า"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(9, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1382, 45)
        Me.Panel2.TabIndex = 97
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Controls.Add(Me.DGV_product)
        Me.GroupBox5.Location = New System.Drawing.Point(34, 157)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1350, 264)
        Me.GroupBox5.TabIndex = 103
        Me.GroupBox5.TabStop = False
        '
        'DGV_product
        '
        Me.DGV_product.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_product.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_product.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pd_id, Me.pd_name, Me.pd_brand, Me.type_id, Me.type_name, Me.pd_price, Me.pd_stock, Me.unit_id, Me.unit_name, Me.DATE_CREATE, Me.pd_picture})
        Me.DGV_product.EnableHeadersVisualStyles = False
        Me.DGV_product.Location = New System.Drawing.Point(6, 10)
        Me.DGV_product.Name = "DGV_product"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_product.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DGV_product.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_product.Size = New System.Drawing.Size(1303, 248)
        Me.DGV_product.TabIndex = 62
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
        'DATE_CREATE
        '
        Me.DATE_CREATE.HeaderText = "วันที่นำเข้า"
        Me.DATE_CREATE.Name = "DATE_CREATE"
        '
        'pd_picture
        '
        Me.pd_picture.HeaderText = "ชื่อรูปภาพ"
        Me.pd_picture.Name = "pd_picture"
        Me.pd_picture.Width = 130
        '
        'frm_IMP_EXP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 688)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_IMP_EXP"
        Me.Text = "frm_IMP_EXP"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_subdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DGV_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sub_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_End As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_subdetail As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_nub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_saletotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_discus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TSB_sale As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_product As System.Windows.Forms.DataGridView
    Friend WithEvents pd_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATE_CREATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_picture As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
