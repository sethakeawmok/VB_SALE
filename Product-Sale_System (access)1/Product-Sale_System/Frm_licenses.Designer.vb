<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_licenses
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
        Me.CBO_STid = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_sale = New System.Windows.Forms.CheckBox()
        Me.cb_saledetail = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_addmem = New System.Windows.Forms.CheckBox()
        Me.cb_editmem = New System.Windows.Forms.CheckBox()
        Me.cb_delmem = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_addpro = New System.Windows.Forms.CheckBox()
        Me.cb_editpro = New System.Windows.Forms.CheckBox()
        Me.cb_delpro = New System.Windows.Forms.CheckBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cb_addstaff = New System.Windows.Forms.CheckBox()
        Me.cb_editstaff = New System.Windows.Forms.CheckBox()
        Me.cb_delstaff = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBO_STid
        '
        Me.CBO_STid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_STid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CBO_STid.FormattingEnabled = True
        Me.CBO_STid.Location = New System.Drawing.Point(205, 38)
        Me.CBO_STid.Name = "CBO_STid"
        Me.CBO_STid.Size = New System.Drawing.Size(121, 24)
        Me.CBO_STid.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_sale)
        Me.GroupBox3.Controls.Add(Me.cb_saledetail)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(239, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(188, 95)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "การขายสินค้า"
        '
        'cb_sale
        '
        Me.cb_sale.AutoSize = True
        Me.cb_sale.Checked = True
        Me.cb_sale.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_sale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_sale.Location = New System.Drawing.Point(42, 24)
        Me.cb_sale.Name = "cb_sale"
        Me.cb_sale.Size = New System.Drawing.Size(79, 20)
        Me.cb_sale.TabIndex = 0
        Me.cb_sale.Text = "ขายสินค้า"
        Me.cb_sale.UseVisualStyleBackColor = True
        '
        'cb_saledetail
        '
        Me.cb_saledetail.AutoSize = True
        Me.cb_saledetail.Checked = True
        Me.cb_saledetail.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_saledetail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_saledetail.Location = New System.Drawing.Point(42, 47)
        Me.cb_saledetail.Name = "cb_saledetail"
        Me.cb_saledetail.Size = New System.Drawing.Size(131, 20)
        Me.cb_saledetail.TabIndex = 1
        Me.cb_saledetail.Text = "ดูรายละเอียดการาย"
        Me.cb_saledetail.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_addmem)
        Me.GroupBox2.Controls.Add(Me.cb_editmem)
        Me.GroupBox2.Controls.Add(Me.cb_delmem)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(45, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 100)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "จัดการข้อมูลสมาชิก"
        '
        'cb_addmem
        '
        Me.cb_addmem.AutoSize = True
        Me.cb_addmem.Checked = True
        Me.cb_addmem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_addmem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_addmem.Location = New System.Drawing.Point(42, 24)
        Me.cb_addmem.Name = "cb_addmem"
        Me.cb_addmem.Size = New System.Drawing.Size(80, 20)
        Me.cb_addmem.TabIndex = 0
        Me.cb_addmem.Text = "เพิ่มข้อมูล"
        Me.cb_addmem.UseVisualStyleBackColor = True
        '
        'cb_editmem
        '
        Me.cb_editmem.AutoSize = True
        Me.cb_editmem.Checked = True
        Me.cb_editmem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_editmem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_editmem.Location = New System.Drawing.Point(42, 47)
        Me.cb_editmem.Name = "cb_editmem"
        Me.cb_editmem.Size = New System.Drawing.Size(90, 20)
        Me.cb_editmem.TabIndex = 1
        Me.cb_editmem.Text = "แก้ไขข้อมูล"
        Me.cb_editmem.UseVisualStyleBackColor = True
        '
        'cb_delmem
        '
        Me.cb_delmem.AutoSize = True
        Me.cb_delmem.Checked = True
        Me.cb_delmem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_delmem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_delmem.Location = New System.Drawing.Point(42, 70)
        Me.cb_delmem.Name = "cb_delmem"
        Me.cb_delmem.Size = New System.Drawing.Size(75, 20)
        Me.cb_delmem.TabIndex = 2
        Me.cb_delmem.Text = "ลบข้อมูล"
        Me.cb_delmem.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_addpro)
        Me.GroupBox1.Controls.Add(Me.cb_editpro)
        Me.GroupBox1.Controls.Add(Me.cb_delpro)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "จัดการข้อมูลระบบคลังสินค้า"
        '
        'cb_addpro
        '
        Me.cb_addpro.AutoSize = True
        Me.cb_addpro.Checked = True
        Me.cb_addpro.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_addpro.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_addpro.Location = New System.Drawing.Point(42, 24)
        Me.cb_addpro.Name = "cb_addpro"
        Me.cb_addpro.Size = New System.Drawing.Size(80, 20)
        Me.cb_addpro.TabIndex = 0
        Me.cb_addpro.Text = "เพิ่มข้อมูล"
        Me.cb_addpro.UseVisualStyleBackColor = True
        '
        'cb_editpro
        '
        Me.cb_editpro.AutoSize = True
        Me.cb_editpro.Checked = True
        Me.cb_editpro.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_editpro.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_editpro.Location = New System.Drawing.Point(42, 47)
        Me.cb_editpro.Name = "cb_editpro"
        Me.cb_editpro.Size = New System.Drawing.Size(90, 20)
        Me.cb_editpro.TabIndex = 1
        Me.cb_editpro.Text = "แก้ไขข้อมูล"
        Me.cb_editpro.UseVisualStyleBackColor = True
        '
        'cb_delpro
        '
        Me.cb_delpro.AutoSize = True
        Me.cb_delpro.Checked = True
        Me.cb_delpro.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_delpro.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_delpro.Location = New System.Drawing.Point(42, 70)
        Me.cb_delpro.Name = "cb_delpro"
        Me.cb_delpro.Size = New System.Drawing.Size(75, 20)
        Me.cb_delpro.TabIndex = 2
        Me.cb_delpro.Text = "ลบข้อมูล"
        Me.cb_delpro.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(375, 301)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(52, 30)
        Me.btn_edit.TabIndex = 8
        Me.btn_edit.Text = "ok"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cb_addstaff)
        Me.GroupBox4.Controls.Add(Me.cb_editstaff)
        Me.GroupBox4.Controls.Add(Me.cb_delstaff)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(239, 89)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(188, 100)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "จัดการข้อมูลพนักงาน"
        '
        'cb_addstaff
        '
        Me.cb_addstaff.AutoSize = True
        Me.cb_addstaff.Checked = True
        Me.cb_addstaff.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_addstaff.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_addstaff.Location = New System.Drawing.Point(42, 24)
        Me.cb_addstaff.Name = "cb_addstaff"
        Me.cb_addstaff.Size = New System.Drawing.Size(80, 20)
        Me.cb_addstaff.TabIndex = 0
        Me.cb_addstaff.Text = "เพิ่มข้อมูล"
        Me.cb_addstaff.UseVisualStyleBackColor = True
        '
        'cb_editstaff
        '
        Me.cb_editstaff.AutoSize = True
        Me.cb_editstaff.Checked = True
        Me.cb_editstaff.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_editstaff.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_editstaff.Location = New System.Drawing.Point(42, 47)
        Me.cb_editstaff.Name = "cb_editstaff"
        Me.cb_editstaff.Size = New System.Drawing.Size(90, 20)
        Me.cb_editstaff.TabIndex = 1
        Me.cb_editstaff.Text = "แก้ไขข้อมูล"
        Me.cb_editstaff.UseVisualStyleBackColor = True
        '
        'cb_delstaff
        '
        Me.cb_delstaff.AutoSize = True
        Me.cb_delstaff.Checked = True
        Me.cb_delstaff.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_delstaff.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cb_delstaff.Location = New System.Drawing.Point(42, 70)
        Me.cb_delstaff.Name = "cb_delstaff"
        Me.cb_delstaff.Size = New System.Drawing.Size(75, 20)
        Me.cb_delstaff.TabIndex = 2
        Me.cb_delstaff.Text = "ลบข้อมูล"
        Me.cb_delstaff.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "เลือกตำแหน่ง :"
        '
        'Frm_licenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 366)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.CBO_STid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_edit)
        Me.Name = "Frm_licenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สิทธิ์การใช้งาน"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBO_STid As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_sale As System.Windows.Forms.CheckBox
    Friend WithEvents cb_saledetail As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_addmem As System.Windows.Forms.CheckBox
    Friend WithEvents cb_editmem As System.Windows.Forms.CheckBox
    Friend WithEvents cb_delmem As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_addpro As System.Windows.Forms.CheckBox
    Friend WithEvents cb_editpro As System.Windows.Forms.CheckBox
    Friend WithEvents cb_delpro As System.Windows.Forms.CheckBox
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_addstaff As System.Windows.Forms.CheckBox
    Friend WithEvents cb_editstaff As System.Windows.Forms.CheckBox
    Friend WithEvents cb_delstaff As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
