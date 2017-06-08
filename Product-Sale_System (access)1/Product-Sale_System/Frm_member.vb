Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Frm_member
    Dim chk_edit As String
    Private Sub Frm_member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
        Call showdata()
        Call chk_btnlicenses()
    End Sub
    Sub showdata()
        Dim row As Integer
        conn.Open()
        If txt_find.Text = "" Then
            strSQl = "SELECT * FROM T_member ORDER BY mem_id ASC"
        Else
            strSQl = "SELECT * FROM T_member WHERE mem_id LIKE '%" & txt_find.Text & "%' OR mem_fname LIKE '%" & txt_find.Text & "%' ORDER BY mem_id ASC"
        End If
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader

        DGV_members.Rows.Clear()
        While myreader.Read
            With DGV_members
                .Rows.Add()
                .Rows(row).Cells("mem_id").Value = myreader("mem_id")
                .Rows(row).Cells("mem_fullname").Value = myreader("mem_fname") & " " & myreader("mem_lname")
                .Rows(row).Cells("mem_fname").Value = myreader("mem_fname")
                .Rows(row).Cells("mem_lname").Value = myreader("mem_lname")
                .Rows(row).Cells("mem_sex").Value = myreader("mem_sex")
                .Rows(row).Cells("mem_address").Value = myreader("mem_address")
                .Rows(row).Cells("mem_tel").Value = myreader("mem_tel")
                .Rows(row).Cells("mem_birthday").Value = myreader("mem_birthday")
            End With
            row += 1
        End While
        conn.Close()
        Call showDGV()
    End Sub
    Private Sub txt_find_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_find.TextChanged
        Call showdata()
    End Sub
    Sub chk_btnlicenses()
        conn.Open()
        strSQl = "SELECT * FROM T_Licenses WHERE SP_id='" & licenses & "'"
        'strSQl = "SELECT * FROM T_Licenses WHERE SP_id='" & 1 & "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        If myreader("mem_add") = "y" Then
            btn_add.Enabled = True
            btn_save.Enabled = False
        Else
            btn_add.Enabled = False
        End If
        If myreader("mem_edit") = "y" Then
            btn_edit.Enabled = True
        Else
            btn_edit.Enabled = False
        End If
        If myreader("mem_delect") = "y" Then
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
        txt_memid.Enabled = True
        txt_memid.Focus()
        txt_memid.Text = ""
        txt_fname.Text = ""
        txt_lname.Text = ""
        rdo_sexM.Checked = True
        txt_address.Text = ""
        MkT_tel.Text = ""
        dtp_brithday.Value = Today
    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim chkrdo As String

        If rdo_sexW.Checked Then
            chkrdo = "หญิง"
        Else
            chkrdo = "ชาย"
        End If
        conn.Open()
        strSQl = "SELECT mem_id FROM T_member WHERE mem_id='" & txt_memid.Text & "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        If myreader.HasRows = True Then
            MessageBox.Show("รหัสสมาชิกนี้มีอยู่แล้ว กรุณาเปลี่ยนใหม่", "เตือน!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_memid.Focus()
            conn.Close()
            Exit Sub
        End If
        conn.Close()
        Dim del As MsgBoxResult = MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
        If del = MsgBoxResult.Yes Then

            conn.Open()
            strSQl = "INSERT INTO T_member(mem_id,mem_fname,mem_lname,mem_sex,mem_address,mem_tel,mem_birthday) VALUES('" + txt_memid.Text + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + chkrdo + "','" + txt_address.Text + "','" + MkT_tel.Text + "','" + dtp_brithday.Value + "')"
            mycmd = New OleDbCommand(strSQl, conn)
            Try
                mycmd.ExecuteNonQuery()

                'MsgBox("เพิ่มข้อมูลสำเร็จ")
            Catch ex As Exception
                MessageBox.Show("เพิ่มข้อมูลไม่สำเร็จ!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                conn.Close()
                Exit Sub
            End Try
            conn.Close()
        End If
        Call chk_btnlicenses()
        Call showdata()

        txt_memid.Enabled = False
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim chkrdo As String
        txt_fname.Focus()
        btn_add.Enabled = False
        btn_delete.Enabled = False
        If chk_edit = 1 Then
            chk_edit = 0
            If rdo_sexW.Checked Then
                chkrdo = "หญิง"
            Else
                chkrdo = "ชาย"
            End If

            Dim del As MsgBoxResult = MsgBox("คุณต้องการแก้ไขข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")

            If del = MsgBoxResult.Yes Then
                conn.Open()
                strSQl = "UPDATE T_member SET mem_fname='" + txt_fname.Text + "',mem_lname='" + txt_lname.Text + "',mem_sex='" + chkrdo + "',mem_address='" + txt_address.Text + "',mem_tel='" + MkT_tel.Text + "',mem_birthday='" + dtp_brithday.Value + "' WHERE mem_id='" + txt_memid.Text + "'"
                mycmd = New OleDbCommand(strSQl, conn)
                Try
                    mycmd.ExecuteNonQuery()
                    MsgBox("แก้ไขข้อมูลสำเร็จ")
                Catch ex As Exception
                    MessageBox.Show("แก้ไขข้อมูลไม่สำเร็จ!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
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
        Dim del As MsgBoxResult = MsgBox("คุณต้องการลบข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
        If del = MsgBoxResult.Yes Then
            conn.Open()
            strSQl = "DELETE FROM T_member WHERE mem_id='" + txt_memid.Text + "'"
            mycmd = New OleDbCommand(strSQl, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("ลบข้อมูลสำเร็จ")
            Catch ex As Exception
                MessageBox.Show("ลบข้อมูลไม่สำเร็จ!!!", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            conn.Close()
            Call showdata()
        End If
    End Sub





    Private Sub DGV_members_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_members.CellMouseClick
        Call showDGV()
    End Sub
    Sub showDGV()
        On Error Resume Next
        txt_memid.Text = DGV_members.CurrentRow.Cells("mem_id").Value.ToString
        txt_fname.Text = DGV_members.CurrentRow.Cells("mem_fname").Value.ToString
        txt_lname.Text = DGV_members.CurrentRow.Cells("mem_lname").Value.ToString
        If DGV_members.CurrentRow.Cells("mem_sex").Value.ToString = "ชาย" Then
            rdo_sexW.Checked = True
        Else
            rdo_sexM.Checked = True
        End If
        txt_address.Text = DGV_members.CurrentRow.Cells("mem_address").Value.ToString
        MkT_tel.Text = DGV_members.CurrentRow.Cells("mem_tel").Value.ToString
        dtp_brithday.Value = DGV_members.CurrentRow.Cells("mem_birthday").Value.ToString
    End Sub
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        chk_edit = 0
        txt_memid.Enabled = False
        Call chk_btnlicenses()
        Call showDGV()
    End Sub
    Private Sub TSB_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_exit.Click
        Me.Close()
    End Sub

    Private Sub Frm_member_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_main.chk_TSL(True)
    End Sub

   
End Class