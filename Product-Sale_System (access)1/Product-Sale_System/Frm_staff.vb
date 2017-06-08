Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Frm_staff
    Dim chk_edit As String
    Private Sub Frm_staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
        Call CBO_STadd()
        Call showdata()
        Call chk_btn(True)
    End Sub
    Sub showdata()
        Dim row As Integer
        conn.Open()
        If txt_find.Text = "" Then
            strSQl = "SELECT T_staff.*,T_StaffPosition.SP_name FROM T_staff INNER JOIN T_StaffPosition ON T_staff.SP_id=T_StaffPosition.SP_id ORDER BY T_staff.ST_id ASC"
        Else
            strSQl = "SELECT T_staff.*,T_StaffPosition.SP_name FROM T_staff INNER JOIN T_StaffPosition ON T_staff.SP_id=T_StaffPosition.SP_id WHERE ST_id LIKE '%" & txt_find.Text & "%' OR ST_fname LIKE '%" & txt_find.Text & "%' ORDER BY T_staff.ST_id ASC"
        End If
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader

        DGV_staff.Rows.Clear()
        While myreader.Read
            With DGV_staff
                .Rows.Add()
                .Rows(row).Cells("ST_id").Value = myreader("ST_id")
                .Rows(row).Cells("ST_fname").Value = myreader("ST_fname")
                .Rows(row).Cells("ST_lname").Value = myreader("ST_lname")
                .Rows(row).Cells("SP_id").Value = myreader("SP_id")
                .Rows(row).Cells("SP_name").Value = myreader("SP_name")
                .Rows(row).Cells("ST_user").Value = myreader("ST_user")
                .Rows(row).Cells("ST_password").Value = myreader("ST_password")
                .Rows(row).Cells("ST_tel").Value = myreader("ST_tel")
            End With
            row += 1
        End While
        conn.Close()
        Call showDGV()
    End Sub
    Private Sub txt_find_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_find.TextChanged
        Call showdata()
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
        txt_stid.Enabled = True
        txt_stid.Text = ""
        txt_stfname.Text = ""
        txt_stlname.Text = ""
        txt_stuser.Text = ""
        txt_stpass.Text = ""
        MkT_sttel.Text = ""
        MkT_sttel.Mask = "###-###-####"
    End Sub
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
    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_stid.Text = "" Or txt_stfname.Text = "" Or txt_stlname.Text = "" Or txt_stuser.Text = "" Or txt_stpass.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลทีมีเครื่องหมายให้ครบด้วย", "เตือน!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        conn.Open()
        strSQl = "SELECT ST_id FROM T_staff WHERE ST_id='" & txt_stid.Text & "' OR ST_password='" & txt_stpass.Text & "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        If myreader.HasRows = True Then
            MessageBox.Show("รหัสพนักงานหรือ Password นี้ถูกใช้แล้ว กรุณาเปลี่ยนใหม่ด้วย", "เตือน!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_stid.Focus()
            conn.Close()
            Exit Sub
        End If
        conn.Close()

        Dim del As MsgBoxResult = MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
        If del = MsgBoxResult.Yes Then
            conn.Open()
            strSQl = "INSERT INTO T_staff(ST_id,ST_fname,ST_lname,ST_user,ST_password,ST_tel,SP_id) VALUES('" + txt_stid.Text + "','" + txt_stfname.Text + "','" + txt_stlname.Text + "','" + txt_stuser.Text + "','" + txt_stpass.Text + "','" + MkT_sttel.Text + "','" + CBO_STid.SelectedValue.ToString + "')"
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
        Call chk_btn(True)
        txt_stid.Enabled = False
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        txt_stfname.Focus()
        Call chk_btn(False)
        btn_edit.Enabled = True
        btn_save.Enabled = False
        If chk_edit = 1 Then
            chk_edit = 0

            Dim del As MsgBoxResult = MsgBox("คุณต้องการแก้ไขข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
            If del = MsgBoxResult.Yes Then
                conn.Open()
                strSQl = "UPDATE T_staff SET ST_fname='" + txt_stfname.Text + "',ST_lname='" + txt_stlname.Text + "',SP_id='" + CBO_STid.SelectedValue.ToString + "',ST_user='" + txt_stuser.Text + "',ST_password='" + txt_stpass.Text + "',ST_tel='" + MkT_sttel.Mask + "' WHERE ST_id=" + txt_stid.Text
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
        Dim del As MsgBoxResult = MsgBox("คุณต้องการแก้ไขข้อมูลหรือไม่ ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "เตือน!!!")
        If del = MsgBoxResult.Yes Then
            conn.Open()
            strSQl = "DELETE FROM T_staff WHERE ST_id= '" + txt_stid.Text + "'"
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
    Private Sub DGV_staff_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_staff.CellMouseClick
        Call showDGV()
    End Sub
    Sub showDGV()
        On Error Resume Next
        txt_stid.Text = DGV_staff.CurrentRow.Cells("ST_id").Value.ToString
        txt_stfname.Text = DGV_staff.CurrentRow.Cells("ST_fname").Value.ToString
        txt_stlname.Text = DGV_staff.CurrentRow.Cells("ST_lname").Value.ToString
        CBO_STid.Text = DGV_staff.CurrentRow.Cells("SP_name").Value.ToString
        txt_stuser.Text = DGV_staff.CurrentRow.Cells("ST_user").Value.ToString
        txt_stpass.Text = DGV_staff.CurrentRow.Cells("ST_password").Value.ToString
        MkT_sttel.Text = DGV_staff.CurrentRow.Cells("ST_tel").Value.ToString
    End Sub
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        chk_edit = 0
        txt_stid.Enabled = False
        Call chk_btn(True)
        Call showDGV()
    End Sub

    Private Sub TSB_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_exit.Click
        Me.Close()
    End Sub

    Private Sub Frm_staff_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_main.chk_TSL(True)
    End Sub

    Private Sub TSB_position_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_position.Click
        Frm_staff_position.Show()
        TS_staffs.Enabled = False
    End Sub


  

   
   
   
   
    
End Class