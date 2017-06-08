Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Frm_product
    Dim chk_edit As String
   
    Private Sub Frm_product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
        Call cbo_addAll()
        Call cbo_find()
        Call showdata()
        Call chk_btnlicenses()
    End Sub
    Sub showdata()
        Dim row As Integer
        conn.Close()
        conn.Open()

        If cbo_findtype.SelectedValue.ToString = "all" Then
            If txt_findname.Text = "" Then
                strSQl = "SELECT T_products.*,T_type.type_name,T_unit.unit_name FROM (T_products LEFT JOIN T_type ON T_products.type_id=T_type.type_id) LEFT JOIN T_unit ON T_products.unit_id=T_unit.unit_id  ORDER BY pd_id ASC"
            Else
                strSQl = "SELECT T_products.*,T_type.type_name,T_unit.unit_name FROM (T_products LEFT JOIN T_type ON T_products.type_id=T_type.type_id) LEFT JOIN T_unit ON T_products.unit_id=T_unit.unit_id WHERE pd_id LIKE '%" & txt_findname.Text & "%' OR pd_name LIKE '%" & txt_findname.Text & "%' ORDER BY pd_id ASC"
            End If
        Else
            If txt_findname.Text = "" Then
                strSQl = "SELECT T_products.*,T_type.type_name,T_unit.unit_name FROM (T_products INNER JOIN T_type ON T_products.type_id=T_type.type_id) LEFT JOIN T_unit ON T_products.unit_id=T_unit.unit_id WHERE T_products.type_id = '" & cbo_findtype.SelectedValue.ToString & "'  ORDER BY pd_id ASC"
            Else
                strSQl = "SELECT T_products.*,T_type.type_name,T_unit.unit_name FROM (T_products INNER JOIN T_type ON T_products.type_id=T_type.type_id) LEFT JOIN T_unit ON T_products.unit_id=T_unit.unit_id WHERE (T_products.type_id = '" & cbo_findtype.SelectedValue.ToString & "') AND pd_id LIKE '%" & txt_findname.Text & "%' OR pd_name LIKE '%" & txt_findname.Text & "%' ORDER BY pd_id ASC"
            End If
        End If
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader

        DGV_product.Rows.Clear()
        While myreader.Read
            With DGV_product
                .Rows.Add()
                .Rows(row).Cells("pd_id").Value = myreader("pd_id")
                .Rows(row).Cells("pd_name").Value = myreader("pd_name")
                .Rows(row).Cells("pd_brand").Value = myreader("pd_brand")
                .Rows(row).Cells("type_id").Value = myreader("type_id")
                .Rows(row).Cells("type_name").Value = myreader("type_name")
                .Rows(row).Cells("pd_cost").Value = Format(myreader("pd_cost"), "#,##0.00")
                .Rows(row).Cells("pd_price").Value = Format(myreader("pd_price"), "#,##0.00")
                .Rows(row).Cells("pd_stock").Value = myreader("pd_stock")
                .Rows(row).Cells("unit_id").Value = myreader("unit_id")
                .Rows(row).Cells("unit_name").Value = myreader("unit_name")
                .Rows(row).Cells("pd_discustomer").Value = myreader("pd_discustomer")
                .Rows(row).Cells("pd_dismember").Value = myreader("pd_dismember")
                .Rows(row).Cells("pd_disbirday").Value = myreader("pd_disbirday")
                .Rows(row).Cells("pd_picture").Value = myreader("pd_picture")
            End With
            row += 1
            lbl_countpro.Text = "สินค้าทั้งหมด " & row & " รายการ"
        End While
        conn.Close()
        Call showDGV()

    End Sub
    Sub chk_btnlicenses()
        conn.Open()
        strSQl = "SELECT * FROM T_Licenses WHERE SP_id='" & licenses & "'"
        'strSQl = "SELECT * FROM T_Licenses WHERE SP_id='" & 1 & "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        If myreader("lc_add") = "y" Then
            btn_add.Enabled = True
            btn_save.Enabled = False
        Else
            btn_add.Enabled = False
        End If
        If myreader("lc_edit") = "y" Then
            btn_edit.Enabled = True
        Else
            btn_edit.Enabled = False
        End If
        If myreader("lc_delect") = "y" Then
            btn_delete.Enabled = True
        Else
            btn_delete.Enabled = False
        End If
        conn.Close()
    End Sub
    Sub cbo_addAll()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet

        conn.Open()
        da = New OleDbDataAdapter("SELECT * FROM T_type WHERE type_chk='" + "0" + "'ORDER BY type_id ASC", conn)
        da.Fill(ds, "T_type")
        With cbo_typeid
            .DataSource = ds.Tables("T_type")

            .ValueMember = "type_id"
            .DisplayMember = "type_name"
        End With
        conn.Close()

        conn.Open()
        da = New OleDbDataAdapter("SELECT * FROM T_unit ORDER BY unit_id ASC", conn)
        da.Fill(ds, "T_unit")
        With cbo_unit
            .DataSource = ds.Tables("T_unit")

            .ValueMember = "unit_id"
            .DisplayMember = "unit_name"
        End With
        conn.Close()
    End Sub
    Dim chk_cbofind As String
    Sub cbo_find()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet

        conn.Open()
        da = New OleDbDataAdapter("SELECT * FROM T_type ORDER BY type_chk DESC", conn)
        da.Fill(ds, "T_type")
        With cbo_findtype
            .DataSource = ds.Tables("T_type")

            .ValueMember = "type_id"
            .DisplayMember = "type_name"
        End With
        conn.Close()
        chk_cbofind = "ok"
    End Sub
    Private Sub cbo_findtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_findtype.SelectedIndexChanged
        If chk_cbofind = "ok" Then
            Call showdata()
        End If
    End Sub
    Private Sub txt_findname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_findname.TextChanged
        Call showdata()
    End Sub
    Private Sub btn_findpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_findpic.Click
        ofd_pro.FileName = ""
        ofd_pro.Filter = ("เปิดไฟล์|*.jpg;*.bmp;*.gif;*.png;*.jpeg")
        ofd_pro.ShowDialog()
        PTB_product.ImageLocation = ofd_pro.FileName
        If btn_add.Enabled = False Then
            If ofd_pro.SafeFileName = "" Then
                PTB_product.ImageLocation = Application.StartupPath & "/Images/" & DGV_product.CurrentRow.Cells("pd_picture").Value.ToString
                If txt_id.Enabled = True Then
                    PTB_product.ImageLocation = Application.StartupPath & "/Images/" & "nopic.jpg"
                End If
            End If
        End If
    End Sub
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click

        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_save.Enabled = True
        btn_findpic.Enabled = True
        txt_id.Enabled = True
        txt_id.Text = ""
        txt_name.Text = ""
        txt_brand.Text = ""
        txt_price.Text = ""
        NUD_stock.Value = 0
        txt_discus.Text = 0
        txt_dismem.Text = 0
        txt_disbrith.Text = 0
        PTB_product.ImageLocation = Application.StartupPath & "/images/" & "nopic.jpg"
    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_id.Text = "" Or txt_cost.Text = "" Or txt_price.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลทีมีเครื่องหมายให้ครบด้วย", "เตือน!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        conn.Open()
        strSQl = "SELECT pd_id FROM T_products WHERE pd_id LIKE '%" & txt_id.Text & "%'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        If myreader.HasRows = True Then
            MessageBox.Show("รหัสสินค้านี้มีอยู่แล้ว กรุณาเปลี่ยนใหม่", "เตือน!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_id.Focus()
            conn.Close()
            Exit Sub
        End If
        conn.Close()

        Dim i As Integer
        Dim cut, Plname, Pfname, namepic As String
        Dim chk As String
        Dim del As MsgBoxResult = MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
        If del = MsgBoxResult.Yes Then
            For i = Len(ofd_pro.SafeFileName) To 1 Step -1
                cut = Mid(ofd_pro.SafeFileName, i, 1)
                If cut = "." Then
                    Plname = Mid(ofd_pro.SafeFileName, i)
                    Exit For
                End If
            Next
            Dim time As DateTime = DateTime.Now
            Dim format As String = "MdyyyyHHmmss"
            Pfname = time.ToString(format)

            If ofd_pro.SafeFileName = "" Or ofd_pro.SafeFileName = "OpenFileDialog1" Then
                namepic = "nopic.jpg"
            Else
                chk = "ok"
                namepic = Pfname & Plname
            End If

            conn.Open()
            strSQl = "INSERT INTO T_products(pd_id,pd_name,pd_brand,type_id,pd_cost,pd_price,pd_stock,unit_id,pd_discustomer,pd_dismember,pd_disbirday,pd_picture) VALUES('" + Trim(txt_id.Text) + "','" + txt_name.Text + "','" + txt_brand.Text + "','" + cbo_typeid.SelectedValue.ToString + "','" + txt_cost.Text + "','" + txt_price.Text + "','" + NUD_stock.Value.ToString + "','" + cbo_unit.SelectedValue.ToString + "','" + txt_discus.Text + "','" + txt_dismem.Text + "','" + txt_disbrith.Text + "','" + namepic + "')"
            mycmd = New OleDbCommand(strSQl, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("เพิ่มข้อมูลสำเร็จ")
                If chk = "ok" Then
                    FileCopy(ofd_pro.FileName, Application.StartupPath & "/images/" & Pfname & Plname)
                End If
            Catch ex As Exception
                MsgBox("เพิ่มข้อมูลไม่สำเร็จ")
                conn.Close()
                Exit Sub
            End Try
            conn.Close()
        End If
        txt_id.Enabled = False
        btn_findpic.Enabled = False
        Call chk_btnlicenses()
        Call showdata()
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim i As Integer
        Dim cut, Plname, Pfname, picedit As String
        Dim chk As String

        txt_name.Focus()
        btn_add.Enabled = False
        btn_delete.Enabled = False
        btn_findpic.Enabled = True
        If chk_edit = 1 Then
            chk_edit = 0

            Dim del As MsgBoxResult = MsgBox("คุณต้องการแก้ไขข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
            If del = MsgBoxResult.Yes Then

                For i = Len(ofd_pro.SafeFileName) To 1 Step -1
                    cut = Mid(ofd_pro.SafeFileName, i, 1)
                    If cut = "." Then
                        Plname = Mid(ofd_pro.SafeFileName, i)
                        Exit For
                    End If
                Next
                Dim time As DateTime = DateTime.Now
                Dim format As String = "MdyyyyHHmmss"
                Pfname = time.ToString(format)


                If ofd_pro.SafeFileName = "" Or ofd_pro.SafeFileName = "OpenFileDialog1" Then
                    strSQl = "UPDATE T_products SET pd_name='" + txt_name.Text + "',pd_brand='" + txt_brand.Text + "',type_id='" + cbo_typeid.SelectedValue.ToString + "',pd_cost='" + txt_cost.Text + "',pd_price='" + txt_price.Text + "',pd_stock='" + NUD_stock.Value.ToString + "',pd_discustomer='" + txt_discus.Text + "',pd_dismember='" + txt_dismem.Text + "',pd_disbirday='" + txt_disbrith.Text + "' WHERE pd_id='" + txt_id.Text + "'"
                Else
                    chk = "ok"
                    picedit = Pfname & Plname
                    strSQl = "UPDATE T_products SET pd_name='" + txt_name.Text + "',pd_brand='" + txt_brand.Text + "',type_id='" + cbo_typeid.SelectedValue.ToString + "',pd_cost='" + txt_cost.Text + "',pd_price='" + txt_price.Text + "',pd_stock='" + NUD_stock.Value.ToString + "',unit_id='" + cbo_unit.SelectedValue.ToString + "',pd_discustomer='" + txt_discus.Text + "',pd_dismember='" + txt_dismem.Text + "',pd_disbirday='" + txt_disbrith.Text + "',pd_picture='" + picedit + "' WHERE pd_id='" + txt_id.Text + "'"
                End If

                conn.Open()
                mycmd = New OleDbCommand(strSQl, conn)
                Try
                    mycmd.ExecuteNonQuery()
                    MsgBox("แก้ไขข้อมูลสำเร็จ")

                    If chk = "ok" Then
                        FileCopy(ofd_pro.FileName, Application.StartupPath & "/images/" & picedit)
                        picedit = DGV_product.CurrentRow.Cells("pd_picture").Value.ToString
                        If (Dir(Application.StartupPath & "/images/" & picedit)) = picedit And picedit <> "" And picedit <> "nopic.jpg" Then
                            Kill(Application.StartupPath & "/images/" & picedit)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("แก้ไขข้อมูลไม่สำเร็จ")
                    conn.Close()
                    Exit Sub
                End Try
                conn.Close()
            End If
            Call chk_btnlicenses()
            btn_findpic.Enabled = False
            Call showdata()
        Else
            chk_edit = 1
        End If
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim picdel As String = DGV_product.CurrentRow.Cells("pd_picture").Value.ToString
        Dim del As MsgBoxResult = MsgBox("คุณต้องการลบข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
        If del = MsgBoxResult.Yes Then
            conn.Open()
            strSQl = "DELETE FROM T_products WHERE pd_id='" + txt_id.Text + "'"
            mycmd = New OleDbCommand(strSQl, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("ลบข้อมูลสำเร็จ")
                If (Dir(Application.StartupPath & "/images/" & picdel)) = picdel And picdel <> "" And picdel <> "nopic.jpg" Then
                    Kill(Application.StartupPath & "/images/" & picdel)
                End If
            Catch ex As Exception
                MsgBox("ลบข้อมูลไม่สำเร็จ")
            End Try
            conn.Close()
            Call showdata()
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        chk_edit = 0
        txt_id.Enabled = False
        btn_findpic.Enabled = False
        Call chk_btnlicenses()
        Call showDGV()
    End Sub
    Private Sub DGV_product_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_product.CellMouseClick
        Call showDGV()
    End Sub
    Sub showDGV()
        On Error Resume Next
        txt_id.Text = DGV_product.CurrentRow.Cells("pd_id").Value.ToString
        txt_name.Text = DGV_product.CurrentRow.Cells("pd_name").Value.ToString
        txt_brand.Text = DGV_product.CurrentRow.Cells("pd_brand").Value.ToString
        cbo_typeid.Text = DGV_product.CurrentRow.Cells("type_name").Value.ToString
        txt_cost.Text = DGV_product.CurrentRow.Cells("pd_cost").Value.ToString
        txt_price.Text = DGV_product.CurrentRow.Cells("pd_price").Value.ToString
        NUD_stock.Value = DGV_product.CurrentRow.Cells("pd_stock").Value.ToString
        cbo_unit.Text = DGV_product.CurrentRow.Cells("unit_name").Value.ToString
        txt_discus.Text = DGV_product.CurrentRow.Cells("pd_discustomer").Value.ToString
        txt_dismem.Text = DGV_product.CurrentRow.Cells("pd_dismember").Value.ToString
        txt_disbrith.Text = DGV_product.CurrentRow.Cells("pd_disbirday").Value.ToString
        PTB_product.ImageLocation = Application.StartupPath & "/images/" & DGV_product.CurrentRow.Cells("pd_picture").Value.ToString
    End Sub
    Private Sub tsb_unit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Frm_member.Show()
    End Sub

   

    Private Sub TSB_protype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_protype.Click
        chk_cbofind = ""
        TS_product.Enabled = False
        frm_protype.Show()
    End Sub

    Private Sub TSB_prounit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_prounit.Click
        chk_cbofind = ""
        TS_product.Enabled = False
        frm_prounit.Show()
    End Sub
    Private Sub Frm_product_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_main.chk_TSL(True)
    End Sub
    Private Sub TSB_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_exit.Click
        Me.Close()
    End Sub
End Class