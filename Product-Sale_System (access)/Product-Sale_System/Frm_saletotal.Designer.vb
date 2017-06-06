<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_saletotal
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_dissum = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_sum = New System.Windows.Forms.Label()
        Me.lbl_getmonn = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txt_remonn = New System.Windows.Forms.TextBox()
        Me.btn_tod = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_dissum)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_sum)
        Me.GroupBox1.Controls.Add(Me.lbl_getmonn)
        Me.GroupBox1.Controls.Add(Me.lbl_total)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(366, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 30)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ลด :"
        '
        'lbl_dissum
        '
        Me.lbl_dissum.BackColor = System.Drawing.Color.Black
        Me.lbl_dissum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_dissum.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dissum.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_dissum.Location = New System.Drawing.Point(424, 25)
        Me.lbl_dissum.Name = "lbl_dissum"
        Me.lbl_dissum.Size = New System.Drawing.Size(118, 37)
        Me.lbl_dissum.TabIndex = 5
        Me.lbl_dissum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(55, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 30)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "เงินทอน :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(73, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 30)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "รับเงิน :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(46, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ราคารวม :"
        '
        'lbl_sum
        '
        Me.lbl_sum.BackColor = System.Drawing.Color.Black
        Me.lbl_sum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_sum.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sum.ForeColor = System.Drawing.Color.Lime
        Me.lbl_sum.Location = New System.Drawing.Point(159, 100)
        Me.lbl_sum.Name = "lbl_sum"
        Me.lbl_sum.Size = New System.Drawing.Size(183, 37)
        Me.lbl_sum.TabIndex = 2
        Me.lbl_sum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_getmonn
        '
        Me.lbl_getmonn.BackColor = System.Drawing.Color.Black
        Me.lbl_getmonn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_getmonn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_getmonn.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_getmonn.Location = New System.Drawing.Point(159, 25)
        Me.lbl_getmonn.Name = "lbl_getmonn"
        Me.lbl_getmonn.Size = New System.Drawing.Size(183, 37)
        Me.lbl_getmonn.TabIndex = 1
        Me.lbl_getmonn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.Black
        Me.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_total.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_total.Location = New System.Drawing.Point(159, 62)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(183, 37)
        Me.lbl_total.TabIndex = 0
        Me.lbl_total.Text = "300.00"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_ok)
        Me.GroupBox2.Controls.Add(Me.txt_remonn)
        Me.GroupBox2.Controls.Add(Me.btn_tod)
        Me.GroupBox2.Controls.Add(Me.btn_0)
        Me.GroupBox2.Controls.Add(Me.btn_3)
        Me.GroupBox2.Controls.Add(Me.btn_2)
        Me.GroupBox2.Controls.Add(Me.btn_1)
        Me.GroupBox2.Controls.Add(Me.btn_6)
        Me.GroupBox2.Controls.Add(Me.btn_5)
        Me.GroupBox2.Controls.Add(Me.btn_4)
        Me.GroupBox2.Controls.Add(Me.btn_9)
        Me.GroupBox2.Controls.Add(Me.btn_8)
        Me.GroupBox2.Controls.Add(Me.btn_7)
        Me.GroupBox2.Location = New System.Drawing.Point(433, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 159)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(108, 42)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(43, 30)
        Me.btn_clear.TabIndex = 13
        Me.btn_clear.Text = "<--"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(108, 12)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(43, 30)
        Me.btn_ok.TabIndex = 12
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'txt_remonn
        '
        Me.txt_remonn.BackColor = System.Drawing.Color.Black
        Me.txt_remonn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_remonn.ForeColor = System.Drawing.Color.Yellow
        Me.txt_remonn.Location = New System.Drawing.Point(7, 12)
        Me.txt_remonn.Multiline = True
        Me.txt_remonn.Name = "txt_remonn"
        Me.txt_remonn.Size = New System.Drawing.Size(101, 30)
        Me.txt_remonn.TabIndex = 11
        Me.txt_remonn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_tod
        '
        Me.btn_tod.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_tod.Location = New System.Drawing.Point(73, 125)
        Me.btn_tod.Name = "btn_tod"
        Me.btn_tod.Size = New System.Drawing.Size(35, 30)
        Me.btn_tod.TabIndex = 10
        Me.btn_tod.Text = "."
        Me.btn_tod.UseVisualStyleBackColor = True
        '
        'btn_0
        '
        Me.btn_0.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_0.Location = New System.Drawing.Point(7, 125)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(68, 30)
        Me.btn_0.TabIndex = 9
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_3.Location = New System.Drawing.Point(73, 97)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(35, 30)
        Me.btn_3.TabIndex = 8
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_2.Location = New System.Drawing.Point(40, 97)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(35, 30)
        Me.btn_2.TabIndex = 7
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_1
        '
        Me.btn_1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_1.Location = New System.Drawing.Point(7, 97)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(35, 30)
        Me.btn_1.TabIndex = 6
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_6.Location = New System.Drawing.Point(73, 70)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(35, 30)
        Me.btn_6.TabIndex = 5
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'btn_5
        '
        Me.btn_5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_5.Location = New System.Drawing.Point(40, 70)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(35, 30)
        Me.btn_5.TabIndex = 4
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = True
        '
        'btn_4
        '
        Me.btn_4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_4.Location = New System.Drawing.Point(7, 70)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(35, 30)
        Me.btn_4.TabIndex = 3
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'btn_9
        '
        Me.btn_9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_9.Location = New System.Drawing.Point(73, 42)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(35, 30)
        Me.btn_9.TabIndex = 2
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = True
        '
        'btn_8
        '
        Me.btn_8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_8.Location = New System.Drawing.Point(40, 42)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(35, 30)
        Me.btn_8.TabIndex = 1
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = True
        '
        'btn_7
        '
        Me.btn_7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_7.Location = New System.Drawing.Point(7, 42)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(35, 30)
        Me.btn_7.TabIndex = 0
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(433, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 23)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "รับเงิน"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.Lime
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(13, 177)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(416, 180)
        Me.ListBox1.TabIndex = 3
        '
        'Frm_saletotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(607, 376)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_saletotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "คิดเงิน"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_sum As System.Windows.Forms.Label
    Friend WithEvents lbl_getmonn As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_dissum As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents txt_remonn As System.Windows.Forms.TextBox
    Friend WithEvents btn_tod As System.Windows.Forms.Button
    Friend WithEvents btn_0 As System.Windows.Forms.Button
    Friend WithEvents btn_3 As System.Windows.Forms.Button
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents btn_6 As System.Windows.Forms.Button
    Friend WithEvents btn_5 As System.Windows.Forms.Button
    Friend WithEvents btn_4 As System.Windows.Forms.Button
    Friend WithEvents btn_9 As System.Windows.Forms.Button
    Friend WithEvents btn_8 As System.Windows.Forms.Button
    Friend WithEvents btn_7 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
