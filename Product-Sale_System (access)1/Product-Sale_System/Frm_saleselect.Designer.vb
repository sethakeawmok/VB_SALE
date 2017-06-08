<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_saleselect
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PTB_product = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_findselect = New System.Windows.Forms.ComboBox()
        Me.txt_findselect = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGVproduct = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.pd_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pd_picture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PTB_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PTB_product)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Red
        Me.GroupBox4.Location = New System.Drawing.Point(482, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(156, 143)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "รูปสินค้า"
        '
        'PTB_product
        '
        Me.PTB_product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PTB_product.Location = New System.Drawing.Point(6, 21)
        Me.PTB_product.Name = "PTB_product"
        Me.PTB_product.Size = New System.Drawing.Size(144, 116)
        Me.PTB_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PTB_product.TabIndex = 31
        Me.PTB_product.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(51, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 18)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "ประเภทสินค้า :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cbo_findselect)
        Me.GroupBox3.Controls.Add(Me.txt_findselect)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(34, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 107)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหา"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(48, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "รหัส/ชื่อสินค้า :"
        '
        'cbo_findselect
        '
        Me.cbo_findselect.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_findselect.FormattingEnabled = True
        Me.cbo_findselect.Location = New System.Drawing.Point(180, 33)
        Me.cbo_findselect.Name = "cbo_findselect"
        Me.cbo_findselect.Size = New System.Drawing.Size(154, 24)
        Me.cbo_findselect.TabIndex = 1
        '
        'txt_findselect
        '
        Me.txt_findselect.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_findselect.Location = New System.Drawing.Point(180, 63)
        Me.txt_findselect.MaxLength = 30
        Me.txt_findselect.Name = "txt_findselect"
        Me.txt_findselect.Size = New System.Drawing.Size(202, 23)
        Me.txt_findselect.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 165)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'DGVproduct
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVproduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVproduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pd_id, Me.pd_name, Me.pd_brand, Me.type_name, Me.pd_stock, Me.unit_name, Me.pd_price, Me.pd_picture})
        Me.DGVproduct.EnableHeadersVisualStyles = False
        Me.DGVproduct.Location = New System.Drawing.Point(10, 19)
        Me.DGVproduct.Name = "DGVproduct"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DGVproduct.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVproduct.Size = New System.Drawing.Size(647, 286)
        Me.DGVproduct.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_select)
        Me.GroupBox1.Controls.Add(Me.DGVproduct)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 345)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Red
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(584, 310)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(76, 29)
        Me.btn_cancel.TabIndex = 38
        Me.btn_cancel.Text = "ยกเลิก"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.Color.Green
        Me.btn_select.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_select.ForeColor = System.Drawing.Color.White
        Me.btn_select.Location = New System.Drawing.Point(502, 311)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(76, 29)
        Me.btn_select.TabIndex = 37
        Me.btn_select.Text = "เลือก"
        Me.btn_select.UseVisualStyleBackColor = False
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
        Me.pd_name.Width = 120
        '
        'pd_brand
        '
        Me.pd_brand.HeaderText = "ยี่ห้อ"
        Me.pd_brand.Name = "pd_brand"
        Me.pd_brand.Width = 90
        '
        'type_name
        '
        Me.type_name.HeaderText = "ประเภทสินค้า"
        Me.type_name.Name = "type_name"
        Me.type_name.Width = 110
        '
        'pd_stock
        '
        Me.pd_stock.HeaderText = "จำนวน"
        Me.pd_stock.Name = "pd_stock"
        Me.pd_stock.Width = 50
        '
        'unit_name
        '
        Me.unit_name.HeaderText = "หน่วย"
        Me.unit_name.Name = "unit_name"
        Me.unit_name.Width = 50
        '
        'pd_price
        '
        Me.pd_price.HeaderText = "ราคา"
        Me.pd_price.Name = "pd_price"
        '
        'pd_picture
        '
        Me.pd_picture.HeaderText = "ชื่อรูปภาพ"
        Me.pd_picture.Name = "pd_picture"
        Me.pd_picture.Visible = False
        '
        'Frm_saleselect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(697, 539)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_saleselect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกสินค้า"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PTB_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGVproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PTB_product As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_findselect As System.Windows.Forms.ComboBox
    Friend WithEvents txt_findselect As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVproduct As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_select As System.Windows.Forms.Button
    Friend WithEvents pd_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pd_picture As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
