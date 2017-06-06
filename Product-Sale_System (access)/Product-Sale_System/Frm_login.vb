Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Frm_login
    Private Sub Frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
        btn_showpass.Visible = False
    End Sub
    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If txt_user.Text = "admin" And txt_pass.Text = "1234" Then
            fname = txt_user.Text
            status = "เจ้าของร้าน"
            licenses = "1"
            MsgBox("ยินดีต้อนรับ " & fname)
            Frm_main.status_bar()
            Frm_main.chk_TSL(True)
            Frm_main.chkadmin()
            Me.Close()
            Exit Sub
        End If
        conn.Close()

        conn.Open()
        strSQl = "SELECT T_staff.*,T_StaffPosition.SP_name FROM T_staff INNER JOIN T_StaffPosition ON T_staff.SP_id=T_StaffPosition.SP_id WHERE ST_user='" & Trim(txt_user.Text) & "' AND ST_password='" & Trim(txt_pass.Text) & "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader


        myreader.Read()
        If myreader.HasRows Then
            fname = myreader("ST_fname")
            status = myreader("SP_name")
            licenses = myreader("SP_id")
            conn.Close()

            MsgBox("ยินดีต้อนรับ " & fname)
            Frm_main.status_bar()
            Frm_main.chk_TSL(True)
            Frm_main.chkadmin()
            Me.Close()
        Else
            MsgBox("username หรือ password ผิด")
        End If
        conn.Close()
    End Sub
    Private Sub btn_showpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_showpass.Click
        txt_pass.PasswordChar = "*"
    End Sub

    Private Sub btn_showpass_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_showpass.MouseDown
        txt_pass.PasswordChar = ""
    End Sub

    Private Sub btn_showpass_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_showpass.MouseHover
        btn_showpass.ForeColor = Color.Salmon
        btn_showpass.BackColor = Color.White
    End Sub

    Private Sub btn_showpass_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_showpass.MouseLeave
        btn_showpass.ForeColor = Color.White
    End Sub
    Private Sub txt_pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pass.TextChanged
        If txt_pass.Text = "" Then
            btn_showpass.Visible = False
        Else
            btn_showpass.Visible = True
        End If

    End Sub
End Class