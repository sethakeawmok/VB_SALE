Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class frm_prounit
    Dim chk_edit As String
    Private Sub frm_prounit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
        Call showdata()
        Call chk_btnlicenses()
    End Sub
    Sub showdata()
        Dim row As Integer
        conn.Open()
        strSQl = "SELECT * FROM T_unit ORDER BY unit_id ASC"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader

        DGVtype.Rows.Clear()
        While myreader.Read
            With DGVtype
                .Rows.Add()
                .Rows(row).Cells("unit_id").Value = myreader("unit_id")
                .Rows(row).Cells("unit_name").Value = myreader("unit_name")
            End With
            row += 1
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


    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_save.Enabled = True
        txt_unitid.Enabled = True
        txt_unitid.Text = ""
        txt_unitname.Text = ""
    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_unitid.Text = "" Or txt_unitname.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลด้วย")
            Exit Sub
        End If
        conn.Open()
        strSQl = "SELECT unit_id FROM T_unit WHERE unit_id='" & txt_unitid.Text & "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        If myreader.HasRows = True Then
            MessageBox.Show("รหัสนี้มีอยู่แล้ว กรุณาเปลี่ยนใหม่", "เตือน!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_unitid.Focus()
            conn.Close()
            Exit Sub
        End If
        conn.Close()
        Dim del As MsgBoxResult = MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
        If del = MsgBoxResult.Yes Then
            conn.Open()
            strSQl = "INSERT INTO T_unit VALUES('" + txt_unitid.Text + "','" + txt_unitname.Text + "')"
            mycmd = New OleDbCommand(strSQl, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("เพิ่มข้อมูลสำเร็จ")
            Catch ex As Exception
                MsgBox("เพิ่มข้อมูลไม่สำเร็จ")
                conn.Close()
                Exit Sub
            End Try
            conn.Close()
            Call showdata()
        End If
        Call chk_btnlicenses()
        txt_unitid.Enabled = False
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        txt_unitname.Focus()
        btn_add.Enabled = False
        btn_delete.Enabled = False
        If chk_edit = 1 Then
            chk_edit = 0

            Dim del As MsgBoxResult
            conn.Open()
            strSQl = "SELECT unit_id FROM T_products WHERE unit_id='" & txt_unitid.Text & "'"
            mycmd = New OleDbCommand(strSQl, conn)
            myreader = mycmd.ExecuteReader

            myreader.Read()
            If myreader.HasRows Then
                del = MsgBox("ข้อมูลนี้ถูกใช้งานอยู่ ต้องการแก้ไขหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
            Else
                del = MsgBox("คุณต้องการแก้ไขข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
            End If
            conn.Close()

            If del = MsgBoxResult.Yes Then
                conn.Open()
                strSQl = "UPDATE T_unit SET unit_name='" + txt_unitname.Text + "' WHERE unit_id='" + txt_unitid.Text + "'"
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
            End If
            Call chk_btnlicenses()
            Call showdata()
        Else
            chk_edit = 1
        End If
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        conn.Open()
        strSQl = "SELECT unit_id FROM T_products WHERE unit_id='" & txt_unitid.Text & "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader

        myreader.Read()
        If myreader.HasRows Then
            MessageBox.Show("ข้อมูลนี้ถูกใช้งานอยู่ ไม่สามารถลบได้", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            conn.Close()
            Exit Sub
        End If
        conn.Close()

        Dim del As MsgBoxResult = MsgBox("คุณต้องการลบข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
        If del = MsgBoxResult.Yes Then
            conn.Open()
            strSQl = "DELETE FROM T_unit WHERE unit_id= '" + txt_unitid.Text + "'"
            mycmd = New OleDbCommand(strSQl, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("ลบข้อมูลเรียบร้อยแล้ว")
            Catch ex As Exception
                MsgBox("ลบข้อมูลไม่สำเร็จ")
            End Try
            conn.Close()
            Call showdata()
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        chk_edit = 0
        txt_unitid.Enabled = False
        Call chk_btnlicenses()
        Call showDGV()
    End Sub
    Private Sub DGVtype_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVtype.CellMouseClick
        Call showDGV()
    End Sub
    Sub showDGV()
        On Error Resume Next
        txt_unitid.Text = DGVtype.CurrentRow.Cells("unit_id").Value.ToString
        txt_unitname.Text = DGVtype.CurrentRow.Cells("unit_name").Value.ToString
    End Sub
    Private Sub TSB_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_exit.Click
        Me.Close()
    End Sub
    Private Sub frm_prounit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_product.TS_product.Enabled = True
        Frm_product.cbo_addAll()
        Frm_product.cbo_find()
        Frm_product.showdata()
    End Sub

   

    
End Class