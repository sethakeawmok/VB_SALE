Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Frm_staff_position
    Dim chk_edit As String
    Private Sub Frm_staff_position_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
        Call showdata()
        Call chk_btn(True)
    End Sub
    Sub showdata()
        Dim row As Integer
        conn.Open()
        strSQl = "SELECT * FROM T_StaffPosition ORDER BY SP_id ASC"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader

        DGV_prosition.Rows.Clear()
        While myreader.Read
            With DGV_prosition
                .Rows.Add()
                .Rows(row).Cells("SP_id").Value = myreader("SP_id")
                .Rows(row).Cells("SP_name").Value = myreader("SP_name")
            End With
            row += 1
        End While
        conn.Close()
        Call showDGV()
    End Sub
    Sub chk_btn(ByVal a As Boolean)
        btn_add.Enabled = a
        btn_save.Enabled = Not a
        btn_edit.Enabled = a
        btn_delete.Enabled = a
        btn_cancel.Enabled = Not a
    End Sub
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Call chk_btn(False)
        btn_save.Enabled = True
        txt_SPid.Enabled = True
        txt_SPid.Text = ""
        txt_SPname.Text = ""
    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_SPid.Text = "" Or txt_SPname.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลด้วย")
            Exit Sub
        End If
        Dim del As MsgBoxResult = MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
        If del = MsgBoxResult.Yes Then
            conn.Open()
            strSQl = "INSERT INTO T_StaffPosition VALUES('" + txt_SPid.Text + "','" + txt_SPname.Text + "')"
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

            conn.Open()
            strSQl = "INSERT INTO T_Licenses(SP_id) VALUES('" + txt_SPid.Text + "')"
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
            Dim chklicenses As MsgBoxResult = MsgBox("คุณต้องการกำหนดสิทธิการใช้งานหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
            If chklicenses = MsgBoxResult.Yes Then
                Frm_licenses.Show()
            End If
            Call showdata()
        End If
        Call chk_btn(True)
        txt_SPid.Enabled = False
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        txt_SPname.Focus()
        Call chk_btn(False)
        btn_edit.Enabled = True
        btn_save.Enabled = False
        If chk_edit = 1 Then
            chk_edit = 0

            Dim del As MsgBoxResult
            conn.Open()
            strSQl = "SELECT SP_id FROM T_staff WHERE SP_id='" & txt_SPid.Text & "'"
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
                strSQl = "UPDATE T_StaffPosition SET SP_name='" + txt_SPname.Text + "' WHERE SP_id=" + txt_SPid.Text
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
            Call chk_btn(True)
            Call showdata()
        Else
            chk_edit = 1
        End If
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        conn.Open()
        strSQl = "SELECT SP_id FROM T_staff WHERE SP_id='" & txt_SPid.Text & "'"
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
            strSQl = "DELETE FROM T_StaffPosition WHERE SP_id= '" + txt_SPid.Text + "'"
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
    Private Sub DGV_prosition_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_prosition.CellMouseClick
        Call showDGV()
    End Sub
    Sub showDGV()
        On Error Resume Next
        txt_SPid.Text = DGV_prosition.CurrentRow.Cells("SP_id").Value.ToString
        txt_SPname.Text = DGV_prosition.CurrentRow.Cells("SP_name").Value.ToString
    End Sub
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        chk_edit = 0
        txt_SPid.Enabled = False
        Call chk_btn(True)
        Call showDGV()
    End Sub
    Private Sub TSB_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_exit.Click
        Me.Close()
    End Sub
    Private Sub Frm_staff_position_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_staff.TS_staffs.Enabled = True
        Frm_staff.CBO_STadd()
        Frm_staff.showdata()
        Frm_staff.chk_btn(True)
        Frm_staff.Show()
    End Sub

   
End Class