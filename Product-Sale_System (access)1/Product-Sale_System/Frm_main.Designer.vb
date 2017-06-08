<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSB_login = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSSB_product = New System.Windows.Forms.ToolStripSplitButton()
        Me.TSMI_protype = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_prounit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssb_sale = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsm_sale = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_saleD = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSB_member = New System.Windows.Forms.ToolStripButton()
        Me.TSS_staff = New System.Windows.Forms.ToolStripSeparator()
        Me.TSB_staff = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_licenses = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSB_report = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSB_logout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSB_exit = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSSL_name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(309, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 66)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "ระบบร้านขายสินค้าทั่วไป"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(259, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(471, 66)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "(Sales and Management System)"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_login, Me.ToolStripSeparator2, Me.TSSB_product, Me.ToolStripSeparator3, Me.tssb_sale, Me.ToolStripSeparator4, Me.TSB_member, Me.TSS_staff, Me.TSB_staff, Me.ToolStripSeparator6, Me.TSB_report, Me.ToolStripSeparator7, Me.TSB_logout, Me.ToolStripSeparator1, Me.TSB_exit})
        Me.ToolStrip1.Location = New System.Drawing.Point(-4, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1133, 73)
        Me.ToolStrip1.TabIndex = 78
        '
        'TSB_login
        '
        Me.TSB_login.AutoSize = False
        Me.TSB_login.BackColor = System.Drawing.Color.White
        Me.TSB_login.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_login.ForeColor = System.Drawing.Color.Blue
        Me.TSB_login.Image = CType(resources.GetObject("TSB_login.Image"), System.Drawing.Image)
        Me.TSB_login.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_login.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_login.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_login.Name = "TSB_login"
        Me.TSB_login.Size = New System.Drawing.Size(76, 75)
        Me.TSB_login.Text = "เข้าสู่ระบบ"
        Me.TSB_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 73)
        '
        'TSSB_product
        '
        Me.TSSB_product.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_protype, Me.TSMI_prounit})
        Me.TSSB_product.Enabled = False
        Me.TSSB_product.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSB_product.Image = CType(resources.GetObject("TSSB_product.Image"), System.Drawing.Image)
        Me.TSSB_product.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSSB_product.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSSB_product.Name = "TSSB_product"
        Me.TSSB_product.Size = New System.Drawing.Size(76, 70)
        Me.TSSB_product.Text = "คลังสินค้า"
        Me.TSSB_product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSMI_protype
        '
        Me.TSMI_protype.Name = "TSMI_protype"
        Me.TSMI_protype.Size = New System.Drawing.Size(154, 22)
        Me.TSMI_protype.Text = "ประเภทสินค้า"
        '
        'TSMI_prounit
        '
        Me.TSMI_prounit.Name = "TSMI_prounit"
        Me.TSMI_prounit.Size = New System.Drawing.Size(154, 22)
        Me.TSMI_prounit.Text = "ข้อมูลหน่วยนับ"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 73)
        '
        'tssb_sale
        '
        Me.tssb_sale.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_sale, Me.tsm_saleD})
        Me.tssb_sale.Enabled = False
        Me.tssb_sale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssb_sale.Image = CType(resources.GetObject("tssb_sale.Image"), System.Drawing.Image)
        Me.tssb_sale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tssb_sale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssb_sale.Name = "tssb_sale"
        Me.tssb_sale.Size = New System.Drawing.Size(76, 70)
        Me.tssb_sale.Text = "ขายสินค้า"
        Me.tssb_sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsm_sale
        '
        Me.tsm_sale.Enabled = False
        Me.tsm_sale.Name = "tsm_sale"
        Me.tsm_sale.Size = New System.Drawing.Size(180, 22)
        Me.tsm_sale.Text = "ขายสินค้า"
        '
        'tsm_saleD
        '
        Me.tsm_saleD.Enabled = False
        Me.tsm_saleD.Name = "tsm_saleD"
        Me.tsm_saleD.Size = New System.Drawing.Size(180, 22)
        Me.tsm_saleD.Text = "รายละเอียดการขาย"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 73)
        '
        'TSB_member
        '
        Me.TSB_member.AutoSize = False
        Me.TSB_member.BackColor = System.Drawing.Color.White
        Me.TSB_member.Enabled = False
        Me.TSB_member.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_member.Image = CType(resources.GetObject("TSB_member.Image"), System.Drawing.Image)
        Me.TSB_member.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_member.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_member.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_member.Name = "TSB_member"
        Me.TSB_member.Size = New System.Drawing.Size(76, 75)
        Me.TSB_member.Text = "สมาชิก"
        Me.TSB_member.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSS_staff
        '
        Me.TSS_staff.Name = "TSS_staff"
        Me.TSS_staff.Size = New System.Drawing.Size(6, 73)
        Me.TSS_staff.Visible = False
        '
        'TSB_staff
        '
        Me.TSB_staff.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.tsm_licenses})
        Me.TSB_staff.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_staff.Image = CType(resources.GetObject("TSB_staff.Image"), System.Drawing.Image)
        Me.TSB_staff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_staff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_staff.Name = "TSB_staff"
        Me.TSB_staff.Size = New System.Drawing.Size(97, 70)
        Me.TSB_staff.Text = "พนักงาน,สิทธิ"
        Me.TSB_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSB_staff.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem1.Text = "ตำแหน่งพนักงาน"
        '
        'tsm_licenses
        '
        Me.tsm_licenses.Name = "tsm_licenses"
        Me.tsm_licenses.Size = New System.Drawing.Size(165, 22)
        Me.tsm_licenses.Text = "สิทธิการใช้งาน"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 73)
        '
        'TSB_report
        '
        Me.TSB_report.AutoSize = False
        Me.TSB_report.BackColor = System.Drawing.Color.White
        Me.TSB_report.Enabled = False
        Me.TSB_report.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_report.Image = CType(resources.GetObject("TSB_report.Image"), System.Drawing.Image)
        Me.TSB_report.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_report.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_report.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_report.Name = "TSB_report"
        Me.TSB_report.Size = New System.Drawing.Size(76, 75)
        Me.TSB_report.Text = "รายงาน"
        Me.TSB_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 73)
        '
        'TSB_logout
        '
        Me.TSB_logout.AutoSize = False
        Me.TSB_logout.BackColor = System.Drawing.Color.White
        Me.TSB_logout.Enabled = False
        Me.TSB_logout.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_logout.Image = CType(resources.GetObject("TSB_logout.Image"), System.Drawing.Image)
        Me.TSB_logout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_logout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_logout.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_logout.Name = "TSB_logout"
        Me.TSB_logout.Size = New System.Drawing.Size(80, 75)
        Me.TSB_logout.Text = "ออกจากระบบ"
        Me.TSB_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 73)
        '
        'TSB_exit
        '
        Me.TSB_exit.AutoSize = False
        Me.TSB_exit.BackColor = System.Drawing.Color.White
        Me.TSB_exit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSB_exit.Image = CType(resources.GetObject("TSB_exit.Image"), System.Drawing.Image)
        Me.TSB_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSB_exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_exit.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TSB_exit.Name = "TSB_exit"
        Me.TSB_exit.Size = New System.Drawing.Size(100, 75)
        Me.TSB_exit.Text = "ออกจากโปรแกรม"
        Me.TSB_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_name, Me.ToolStripStatusLabel1, Me.TSSL_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 687)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1063, 24)
        Me.StatusStrip1.TabIndex = 79
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSL_name
        '
        Me.TSSL_name.BackColor = System.Drawing.Color.White
        Me.TSSL_name.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_name.ForeColor = System.Drawing.Color.Black
        Me.TSSL_name.Name = "TSSL_name"
        Me.TSSL_name.Size = New System.Drawing.Size(36, 19)
        Me.TSSL_name.Text = "ผู้ใช้ :"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(50, 19)
        '
        'TSSL_status
        '
        Me.TSSL_status.BackColor = System.Drawing.Color.White
        Me.TSSL_status.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_status.ForeColor = System.Drawing.Color.Black
        Me.TSSL_status.Name = "TSSL_status"
        Me.TSSL_status.Size = New System.Drawing.Size(47, 19)
        Me.TSSL_status.Text = "สถานะ :"
        '
        'Frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1063, 711)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Location = New System.Drawing.Point(100, 10)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบร้านขายสินค้าทั่วไป"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TSB_member As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_report As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_logout As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB_login As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSS_staff As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSSB_product As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents TSMI_protype As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_prounit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSB_exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSSL_name As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSB_staff As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_licenses As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssb_sale As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsm_sale As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_saleD As System.Windows.Forms.ToolStripMenuItem

End Class
