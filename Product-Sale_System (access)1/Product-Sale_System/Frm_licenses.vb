Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Frm_licenses
    Private Sub Frm_licenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
        Call CBO_STadd()
        Call showdata()
    End Sub
    Sub showdata()
        conn.Open()
        strSQl = "SELECT * FROM T_Licenses WHERE SP_id='" & CBO_STid.SelectedValue.ToString & "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        'จัดการข้อมูลสินค้า
        If myreader("lc_add") = "y" Then
            cb_addpro.Checked = True
        Else
            cb_addpro.Checked = False
        End If
        If myreader("lc_edit") = "y" Then
            cb_editpro.Checked = True
        Else
            cb_editpro.Checked = False
        End If
        If myreader("lc_delect") = "y" Then
            cb_delpro.Checked = True
        Else
            cb_delpro.Checked = False
        End If

        'จัดการสมาชิก
        If myreader("mem_add") = "y" Then
            cb_addmem.Checked = True
        Else
            cb_addmem.Checked = False
        End If
        If myreader("mem_edit") = "y" Then
            cb_editmem.Checked = True
        Else
            cb_editmem.Checked = False
        End If
        If myreader("mem_delect") = "y" Then
            cb_delmem.Checked = True
        Else
            cb_delmem.Checked = False
        End If

        'จัดการพนักงาน
        If myreader("staff_add") = "y" Then
            cb_addstaff.Checked = True
        Else
            cb_addstaff.Checked = False
        End If
        If myreader("staff_edit") = "y" Then
            cb_editstaff.Checked = True
        Else
            cb_editstaff.Checked = False
        End If
        If myreader("staff_delect") = "y" Then
            cb_delstaff.Checked = True
        Else
            cb_delstaff.Checked = False
        End If

        'ขายสินค้า
        If myreader("sale_show") = "y" Then
            cb_sale.Checked = True
        Else
            cb_sale.Checked = False
        End If
        If myreader("saledetail_show") = "y" Then
            cb_saledetail.Checked = True
        Else
            cb_saledetail.Checked = False
        End If
        conn.Close()
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim addpro, editpro, delectpro, addmem, editmem, delmem As String
        Dim st_show, st_add, st_edit, st_del As String
        If cb_addpro.Checked Then
            addpro = "y"
        Else
            addpro = "n"
        End If
        If cb_editpro.Checked Then
            editpro = "y"
        Else
            editpro = "n"
        End If
        If cb_delpro.Checked Then
            delectpro = "y"
        Else
            delectpro = "n"
        End If

        If cb_addmem.Checked Then
            addmem = "y"
        Else
            addmem = "n"
        End If
        If cb_editmem.Checked Then
            editmem = "y"
        Else
            editmem = "n"
        End If
        If cb_delmem.Checked Then
            delmem = "y"
        Else
            delmem = "n"
        End If
        If cb_addstaff.Checked Or cb_editstaff.Checked Or cb_delstaff.Checked Then
            st_show = "y"
        Else
            st_show = "n"
        End If
        If cb_addstaff.Checked Then
            st_add = "y"
        Else
            st_add = "n"
        End If
        If cb_editstaff.Checked Then
            st_edit = "y"
        Else
            st_edit = "n"
        End If
        If cb_delstaff.Checked Then
            st_del = "y"
        Else
            st_del = "n"
        End If
        'ขายสินค้า
        Dim sale_show, saleD_show As String
        If cb_sale.Checked Then
            sale_show = "y"
        Else
            sale_show = "n"
        End If
        If cb_saledetail.Checked Then
            saleD_show = "y"
        Else
            saleD_show = "n"
        End If
        conn.Open()
        'strSQl = "UPDATE T_Licenses SET lc_add='" + addpro + "',lc_edit='" + editpro + "',lc_delect='" + delectpro + "',mem_add='" + addmem + "',mem_edit='" + editmem + "',mem_delect='" + delmem + "' WHERE SP_id='" & CBO_STid.SelectedValue.ToString & "'"
        strSQl = "UPDATE T_Licenses SET lc_add='" + addpro + "',lc_edit='" + editpro + "',lc_delect='" + delectpro + "',mem_add='" + addmem + "',mem_edit='" + editmem + "',mem_delect='" + delmem + "'," & _
                 "staff_show='" + st_show + "',staff_add='" + st_add + "',staff_delect='" + st_del + "',staff_edit='" + st_edit + "',sale_show='" + sale_show + "',saledetail_show='" + saleD_show + "' " & _
                 "WHERE SP_id='" & CBO_STid.SelectedValue.ToString & "'"
        MsgBox(strSQl)
        mycmd = New OleDbCommand(strSQl, conn)
        Try
            mycmd.ExecuteNonQuery()
            MsgBox("แก้ไขข้อมูลสำเร็จ")
        Catch ex As Exception
            MsgBox("แก้ไขข้อมูลไม่สำเร็จ")
            conn.Close()
            Exit Sub
        End Try
        conn.Close()
        Call showdata()
    End Sub
    Dim chk_cbo As String
    Sub CBO_STadd()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet

        conn.Open()
        da = New OleDbDataAdapter("SELECT * FROM T_StaffPosition ORDER BY SP_id ASC", conn)
        da.Fill(ds, "T_StaffPosition")
        With CBO_STid
            .DataSource = ds.Tables("T_StaffPosition")

            .ValueMember = "SP_id"
            .DisplayMember = "SP_name"
        End With
        conn.Close()
        chk_cbo = "ok"
    End Sub
    Private Sub CBO_STid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBO_STid.SelectedIndexChanged
        If chk_cbo = "ok" Then
            Call showdata()
        End If
    End Sub

   
End Class