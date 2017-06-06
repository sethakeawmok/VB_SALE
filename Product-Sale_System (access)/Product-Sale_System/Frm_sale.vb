Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Frm_sale
    Dim row As Integer
    Dim discount As String 'เก็บค่าส่วนลด %
    Private Sub Frm_sale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
        Call showdata()
    End Sub
    Sub showdata()
        conn.Open()
        strSQl = "SELECT * FROM T_member WHERE mem_id='" + txt_memid.Text + "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader

        If myreader.Read.ToString() = False Then
            lbl_showDC.Text = "ทั่วไป"
        End If
        conn.Close()


        txt_findid.Text = product
        If product <> "" Then
            product = ""
            conn.Open()
            strSQl = "SELECT * FROM T_products WHERE pd_id='" + txt_findid.Text + "'"
            mycmd = New OleDbCommand(strSQl, conn)
            myreader = mycmd.ExecuteReader


            myreader.Read()
            txt_findid.Text = myreader("pd_id")
            lbl_name.Text = myreader("pd_name")
            lbl_brand.Text = myreader("pd_brand")
            lbl_storktotal.Text = myreader("pd_stock")

            If discount = "yes" Then
                lbl_discount.Text = myreader("pd_dismember")
            ElseIf discount = "yesbirthday" Then
                lbl_discount.Text = myreader("pd_disbirday")
            Else
                lbl_discount.Text = myreader("pd_discustomer")
            End If

            lbl_price.Text = Format(myreader("pd_price"), "#,##0.00")
            conn.Close()
        End If
    End Sub


    Private Sub txt_findid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_findid.KeyUp
        Dim pricetotal, distotal, pricesum As Single
        conn.Open()
        strSQl = "SELECT * FROM T_sale WHERE sale_id='" + txt_saleid.Text + "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        If myreader.HasRows() = True Then
            MessageBox.Show("รหัสขายนี้มีแล้ว!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            conn.Close()
            txt_saleid.Text = ""
            txt_saleid.Focus()
            Exit Sub
        End If
        conn.Close()

        conn.Open()
        strSQl = "SELECT * FROM T_products WHERE pd_id='" + txt_findid.Text + "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        If myreader.HasRows Then
            If txt_saleid.Text = "" Then
                MessageBox.Show("กรุณากรอกรหัสการขายด้วย!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_saleid.Focus()
                conn.Close()
                Exit Sub
            End If

            lbl_name.Text = myreader("pd_name")
            lbl_brand.Text = myreader("pd_brand")
            lbl_storktotal.Text = myreader("pd_stock")
            If discount = "yes" Then
                lbl_discount.Text = myreader("pd_dismember")
            ElseIf discount = "yesbirthday" Then
                lbl_discount.Text = myreader("pd_disbirday")
            Else
                lbl_discount.Text = myreader("pd_discustomer")
            End If
            lbl_price.Text = Format(myreader("pd_price"), "#,##0.00")

            NUD_num.Value = 1
            pricetotal = Val(lbl_price.Text) * NUD_num.Value.ToString
            'If NUD_num.Value.ToString > myreader("pd_stock") Then
            '    MessageBox.Show("จำนวนสินค้าไม่พอ!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    NUD_num.Focus()
            '    conn.Close()
            '    Exit Sub
            'Else

            With DGV_sale
                .Rows.Add()
                .Rows(row).Cells("No").Value = row + 1
                .Rows(row).Cells("pro_id").Value = myreader("pd_id")
                .Rows(row).Cells("pro_name").Value = myreader("pd_name")
                .Rows(row).Cells("pro_brand").Value = myreader("pd_brand")
                .Rows(row).Cells("pro_price").Value = Format(pricetotal, "#,##0.00")
                .Rows(row).Cells("pro_stork").Value = NUD_num.Value.ToString
                .Rows(row).Cells("price_total").Value = Format(pricetotal, "#,##0.00")
                .Rows(row).Cells("dis_percen").Value = lbl_discount.Text
                If discount = "yes" Then
                    distotal = (pricetotal * myreader("pd_dismember")) / 100
                ElseIf discount = "yesbirthday" Then
                    distotal = (pricetotal * myreader("pd_disbirday")) / 100
                Else
                    distotal = (pricetotal * myreader("pd_discustomer")) / 100
                End If
                .Rows(row).Cells("dis_bath").Value = Format(distotal, "#,##0.00")
                .Rows(row).Cells("price_sum").Value = Format((pricetotal - distotal), "#,##0.00")
            End With
            row += 1
            pricetotal = lbl_pritotal.Text + pricetotal
            lbl_pritotal.Text = Format(pricetotal, "#,##0.00")

            distotal = lbl_distotal.Text + distotal
            lbl_distotal.Text = Format(distotal, "#,##0.00")

            pricesum = lbl_pritotal.Text - lbl_distotal.Text
            lbl_pricesum.Text = Format(pricesum, "#,##0.00")


            txt_saleid.Enabled = False
            txt_memid.Enabled = False
            btn_edit.Enabled = True
            btn_remove.Enabled = True
            btn_cancel.Enabled = True
            btn_confirmsale.Enabled = True
            txt_findid.Text = ""
            txt_findid.Focus()
        End If
        conn.Close()
    End Sub


    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim pricetotal, distotal, pricesum As Single


        conn.Open()
        strSQl = "SELECT * FROM T_sale WHERE sale_id='" + txt_saleid.Text + "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        If myreader.HasRows() = True Then
            MessageBox.Show("รหัสขายนี้มีแล้ว!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            conn.Close()
            txt_saleid.Text = ""
            txt_saleid.Focus()
            Exit Sub
        End If
        conn.Close()

        If txt_saleid.Text = "" Or txt_findid.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบด้วย!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If NUD_num.Value.ToString = 0 Then
            MessageBox.Show("กรุณากรอกจำนวนด้วย!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else

            conn.Open()
            strSQl = "SELECT * FROM T_products WHERE pd_id='" + txt_findid.Text + "'"
            mycmd = New OleDbCommand(strSQl, conn)
            myreader = mycmd.ExecuteReader
            myreader.Read()

            If myreader.HasRows() = False Then
                MessageBox.Show("รหัสสินค้านี้ไม่มี!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                conn.Close()
                txt_findid.Text = ""
                txt_findid.Focus()
                Exit Sub
            End If

            pricetotal = Val(lbl_price.Text) * NUD_num.Value.ToString
            If NUD_num.Value.ToString > myreader("pd_stock") Then
                MessageBox.Show("จำนวนสินค้าไม่พอ!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                NUD_num.Focus()
                conn.Close()
                Exit Sub
            Else
                For i = 0 To row
                    If txt_findid.Text = DGV_sale.Rows(i).Cells("pro_id").Value Then
                        MessageBox.Show("คุณเพิ่มรายการสินค้านี้ไปแล้ว!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        conn.Close()
                        Exit Sub
                    End If
                Next
                With DGV_sale
                    .Rows.Add()
                    .Rows(row).Cells("No").Value = row + 1
                    .Rows(row).Cells("pro_id").Value = myreader("pd_id")
                    .Rows(row).Cells("pro_name").Value = myreader("pd_name")
                    .Rows(row).Cells("pro_brand").Value = myreader("pd_brand")
                    .Rows(row).Cells("pro_price").Value = Format(myreader("pd_price"), "#,##0.00")
                    .Rows(row).Cells("pro_stork").Value = NUD_num.Value.ToString
                    .Rows(row).Cells("price_total").Value = Format(pricetotal, "#,##0.00")
                    .Rows(row).Cells("dis_percen").Value = lbl_discount.Text
                    If discount = "yes" Then
                        distotal = (pricetotal * myreader("pd_dismember")) / 100
                    ElseIf discount = "yesbirthday" Then
                        distotal = (pricetotal * myreader("pd_disbirday")) / 100
                    Else
                        distotal = (pricetotal * myreader("pd_discustomer")) / 100
                    End If
                    .Rows(row).Cells("dis_bath").Value = Format(distotal, "#,##0.00")
                    .Rows(row).Cells("price_sum").Value = Format((pricetotal - distotal), "#,##0.00")
                End With
                row += 1
                pricetotal = lbl_pritotal.Text + pricetotal
                lbl_pritotal.Text = Format(pricetotal, "#,##0.00")

                distotal = lbl_distotal.Text + distotal
                lbl_distotal.Text = Format(distotal, "#,##0.00")

                pricesum = lbl_pritotal.Text - lbl_distotal.Text
                lbl_pricesum.Text = Format(pricesum, "#,##0.00")
            End If
            conn.Close()
        End If
        txt_saleid.Enabled = False
        txt_memid.Enabled = False
        btn_edit.Enabled = True
        btn_remove.Enabled = True
        btn_cancel.Enabled = True
        btn_confirmsale.Enabled = True
        txt_findid.Text = ""
        txt_findid.Focus()
    End Sub


    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim edittotal, editdis, editsum, pricedif, discountdif As Single
        Dim chkrow As Integer
        NUD_num.Focus()

        conn.Open()
        strSQl = "SELECT * FROM T_products WHERE pd_id='" + txt_findid.Text + "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()

        If NUD_num.Value.ToString > myreader("pd_stock") Then
            MessageBox.Show("จำนวนสินค้าไม่พอ!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            NUD_num.Focus()
            conn.Close()
            Exit Sub
        End If
        conn.Close()

        If DGV_sale.Rows.Count > 1 Then
            chkrow = DGV_sale.CurrentRow.Index.ToString
            edittotal = lbl_price.Text * NUD_num.Value.ToString

            pricedif = edittotal - DGV_sale.Rows(chkrow).Cells("price_total").Value 'ผลต่างของราคารวมที่ยังไม่แก้ไขและแก้ไข
            With DGV_sale
                .Rows(chkrow).Cells("pro_stork").Value = NUD_num.Value.ToString
                .Rows(chkrow).Cells("price_total").Value = edittotal

                editdis = (edittotal * lbl_discount.Text) / 100
                discountdif = editdis - DGV_sale.Rows(chkrow).Cells("dis_bath").Value    'ผลต่างของส่วนลดที่ยังไม่แก้ไขและแก้ไข
                .Rows(chkrow).Cells("dis_bath").Value = editdis
                .Rows(chkrow).Cells("price_sum").Value = edittotal - editdis
            End With

            edittotal = lbl_pritotal.Text + pricedif
            lbl_pritotal.Text = Format(edittotal, "#,##0.00")

            editdis = lbl_distotal.Text + discountdif
            lbl_distotal.Text = Format(editdis, "#,##0.00")

            editsum = lbl_pritotal.Text - lbl_distotal.Text
            lbl_pricesum.Text = Format(editsum, "#,##0.00")
        End If
    End Sub
    Private Sub btn_remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_remove.Click
        Dim cuttotal, cutdis, cussum As Single ' เก็บค่าตัวที่ลบออกไป
        Dim Rowremove As Integer

        On Error Resume Next

        If DGV_sale.Rows.Count > 1 Then
            Rowremove = DGV_sale.CurrentRow.Index
            cuttotal = DGV_sale.Rows(Rowremove).Cells("price_total").Value
            cutdis = DGV_sale.Rows(Rowremove).Cells("dis_bath").Value
            cussum = DGV_sale.Rows(Rowremove).Cells("price_sum").Value

            DGV_sale.Rows.RemoveAt(Rowremove)
            If row >= 1 Then
                row -= 1
            End If
            For i = 0 To DGV_sale.Rows.Count - 2
                DGV_sale.Rows(i).Cells("No").Value = i + 1
            Next

            cuttotal = lbl_pritotal.Text - cuttotal
            lbl_pritotal.Text = Format(cuttotal, "#,##0.00")

            cutdis = lbl_distotal.Text - cutdis
            lbl_distotal.Text = Format(cutdis, "#,##0.00")

            cussum = lbl_pricesum.Text - cussum
            lbl_pricesum.Text = Format(cussum, "#,##0.00")
        End If
    End Sub
    Sub New_sale()
        row = 0
        txt_saleid.Enabled = True
        txt_memid.Enabled = True
        txt_saleid.Text = ""
        txt_memid.Text = ""
        txt_findid.Text = ""
        lbl_name.Text = ""
        lbl_brand.Text = ""
        lbl_price.Text = ""
        NUD_num.Value = 0
        lbl_discount.Text = ""
        DGV_sale.Rows.Clear()
        lbl_pritotal.Text = "0"
        lbl_distotal.Text = "0"
        lbl_pricesum.Text = "0"
        btn_edit.Enabled = False
        btn_remove.Enabled = False
        btn_cancel.Enabled = False
        btn_confirmsale.Enabled = False

    End Sub
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Call New_sale()
    End Sub
    Private Sub DGV_sale_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_sale.CellMouseClick
        Call DGV_click()
    End Sub
    Sub DGV_click()
        On Error Resume Next
        txt_findid.Text = DGV_sale.CurrentRow.Cells("pro_id").Value.ToString
        lbl_name.Text = DGV_sale.CurrentRow.Cells("pro_name").Value.ToString
        lbl_brand.Text = DGV_sale.CurrentRow.Cells("pro_brand").Value.ToString
        lbl_price.Text = DGV_sale.CurrentRow.Cells("pro_price").Value.ToString
        NUD_num.Value = DGV_sale.CurrentRow.Cells("pro_stork").Value.ToString
        lbl_discount.Text = DGV_sale.CurrentRow.Cells("dis_percen").Value.ToString
    End Sub
    Private Sub btn_confirmsale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirmsale.Click

        Dim del As MsgBoxResult = MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
        If del = MsgBoxResult.Yes Then
            conn.Open()
            If txt_memid.Text = "" Then
                strSQl = "INSERT INTO T_sale(sale_id,sale_date,sale_total,sale_discount,sale_sum,mem_status) VALUES('" + txt_saleid.Text + "','" + DTP_sale.Value + "','" + lbl_pritotal.Text + "','" + lbl_distotal.Text + "','" + lbl_pricesum.Text + "','" + lbl_showDC.Text + "')"

            Else
                strSQl = "INSERT INTO T_sale(sale_id,sale_date,mem_id,sale_total,sale_discount,sale_sum,mem_status) VALUES('" + txt_saleid.Text + "','" + DTP_sale.Value + "','" + txt_memid.Text + "','" + lbl_pritotal.Text + "','" + lbl_distotal.Text + "','" + lbl_pricesum.Text + "','" + lbl_showDC.Text + "')"
            End If

            mycmd = New OleDbCommand(strSQl, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("เรียบร้อยแล้ว")

                Frm_saletotal.lbl_dissum.Text = lbl_distotal.Text
                Frm_saletotal.lbl_total.Text = lbl_pricesum.Text
                Frm_saletotal.Show()
            Catch ex As Exception
                MsgBox("ไม่สำเร็จ")
                conn.Close()
                Exit Sub
            End Try
            conn.Close()
            Call showdata()


            For i = 0 To DGV_sale.Rows.Count - 2
                conn.Open()
                strSQl = "INSERT INTO T_saledetail(sale_id,pd_id,det_stock,det_pricetotal,det_discus,det_pricecus) VALUES('" + txt_saleid.Text + "','" + DGV_sale.Rows(i).Cells("pro_id").Value.ToString() + "','" + DGV_sale.Rows(i).Cells("pro_stork").Value.ToString() + "','" + DGV_sale.Rows(i).Cells("price_total").Value.ToString() + "','" + DGV_sale.Rows(i).Cells("dis_bath").Value.ToString() + "','" + DGV_sale.Rows(i).Cells("price_sum").Value.ToString() + "')"
                mycmd = New OleDbCommand(strSQl, conn)
                mycmd.ExecuteNonQuery()
                conn.Close()
            Next

            Dim strock As Integer
            For i = 0 To DGV_sale.Rows.Count - 2
                conn.Open()
                strSQl = "SELECT pd_stock FROM T_products WHERE pd_id='" + DGV_sale.Rows(i).Cells("pro_id").Value.ToString() + "'"
                mycmd = New OleDbCommand(strSQl, conn)
                myreader = mycmd.ExecuteReader

                myreader.Read()
                strock = myreader("pd_stock") - DGV_sale.Rows(i).Cells("pro_stork").Value.ToString()
                conn.Close()

                conn.Open()
                strSQl = "UPDATE T_products SET pd_stock='" & strock & "' WHERE pd_id='" + DGV_sale.Rows(i).Cells("pro_id").Value.ToString() + "'"
                mycmd = New OleDbCommand(strSQl, conn)
                mycmd.ExecuteNonQuery()
                conn.Close()
            Next
            Call New_sale()
        End If

    End Sub
    Private Sub TSB_detai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_detai.Click
        Frm_saledetail.Show()
        'Me.Close()
    End Sub
    Private Sub TSB_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_exit.Click
        Me.Close()
    End Sub

    Private Sub Frm_sale_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_main.chk_TSL(True)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        Frm_saleselect.Show()
    End Sub
End Class