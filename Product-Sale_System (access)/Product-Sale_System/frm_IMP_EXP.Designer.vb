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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_IMP_EXP))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp_End = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FIND_START = New System.Windows.Forms.DateTimePicker()
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
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGV_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "เลือกช่วงวันที่ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(377, 15)
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
        Me.btn_ok.Location = New System.Drawing.Point(632, 7)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(79, 30)
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
        Me.GroupBox3.Controls.Add(Me.dtp_End)
        Me.GroupBox3.Controls.Add(Me.dtp_FIND_START)
        Me.GroupBox3.Controls.Add(Me.btn_ok)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(26, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(937, 40)
        Me.GroupBox3.TabIndex = 102
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหา"
        '
        'dtp_End
        '
        Me.dtp_End.CalendarFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_End.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_End.Location = New System.Drawing.Point(437, 11)
        Me.dtp_End.Name = "dtp_End"
        Me.dtp_End.Size = New System.Drawing.Size(174, 23)
        Me.dtp_End.TabIndex = 96
        Me.dtp_End.Value = New Date(2016, 2, 4, 23, 59, 0, 0)
        '
        'dtp_FIND_START
        '
        Me.dtp_FIND_START.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_FIND_START.Location = New System.Drawing.Point(192, 11)
        Me.dtp_FIND_START.Name = "dtp_FIND_START"
        Me.dtp_FIND_START.Size = New System.Drawing.Size(179, 23)
        Me.dtp_FIND_START.TabIndex = 95
        Me.dtp_FIND_START.Value = New Date(2016, 2, 4, 1, 1, 0, 0)
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
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 51)
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
        Me.Panel2.Location = New System.Drawing.Point(1, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 45)
        Me.Panel2.TabIndex = 97
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Controls.Add(Me.DGV_product)
        Me.GroupBox5.Location = New System.Drawing.Point(26, 178)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(937, 343)
        Me.GroupBox5.TabIndex = 103
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "รายละเอียดสินค้า"
        '
        'DGV_product
        '
        Me.DGV_product.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_product.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DGV_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_product.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pd_id, Me.pd_name, Me.pd_brand, Me.type_id, Me.type_name, Me.pd_price, Me.pd_stock, Me.unit_id, Me.unit_name, Me.DATE_CREATE, Me.pd_picture})
        Me.DGV_product.EnableHeadersVisualStyles = False
        Me.DGV_product.Location = New System.Drawing.Point(6, 19)
        Me.DGV_product.Name = "DGV_product"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_product.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DGV_product.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DGV_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_product.Size = New System.Drawing.Size(925, 318)
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
        Me.ClientSize = New System.Drawing.Size(1000, 686)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_IMP_EXP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_IMP_EXP"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DGV_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
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
    Friend WithEvents dtp_FIND_START As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_End As System.Windows.Forms.DateTimePicker
End Class
