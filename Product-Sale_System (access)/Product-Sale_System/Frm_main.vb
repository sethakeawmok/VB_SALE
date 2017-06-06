Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class Frm_main

    Private Sub Frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
    End Sub
    Sub chkadmin()
        conn.Open()
        strSQl = "SELECT T_Licenses.staff_show,T_Licenses.sale_show,T_Licenses.saledetail_show FROM T_Licenses INNER JOIN T_staff ON T_Licenses.SP_id=T_staff.SP_id WHERE T_staff.SP_id='" & licenses & "'"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        If myreader.HasRows Then
            If myreader("staff_show") = "y" Then
                TSB_staff.Visible = True
                TSS_staff.Visible = True
            Else
                TSB_staff.Visible = False
                TSS_staff.Visible = False
            End If
            If myreader("sale_show") = "y" And myreader("saledetail_show") = "y" Then
                tssb_sale.Enabled = True
                tsm_sale.Enabled = True
                tsm_saleD.Enabled = True
            ElseIf myreader("sale_show") = "y" And myreader("saledetail_show") = "n" Then
                tsm_sale.Enabled = True
                tsm_saleD.Enabled = False
                Frm_sale.TSB_detai.Enabled = False
            ElseIf myreader("sale_show") = "n" And myreader("saledetail_show") = "y" Then
                tsm_sale.Enabled = False
                tsm_saleD.Enabled = True
            Else
                tssb_sale.Enabled = False
            End If
        End If
        conn.Close()
    End Sub
    Sub status_bar()
        TSSL_name.Text = "ผู้ใช้ : " & fname
        TSSL_status.Text = "สถานะ : " & status
    End Sub
    Sub chk_TSL(ByVal a As Boolean)
        TSB_login.Enabled = False
        TSSB_product.Enabled = a
        tssb_sale.Enabled = a
        TSB_member.Enabled = a
        TSB_staff.Enabled = a
        TSB_report.Enabled = a
        TSB_logout.Enabled = a
    End Sub
    Private Sub TSB_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_login.Click
        Frm_login.Show()
    End Sub
    Private Sub TSSB_product_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSSB_product.ButtonClick
        Call chk_TSL(False)
        Frm_product.Show()
        'Label1.Visible = False
        'Label2.Visible = False
        'Frm_product.MdiParent = Me
        'Frm_product.Show()
    End Sub
    Private Sub TSMI_protype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_protype.Click
        frm_protype.Show()
    End Sub
    Private Sub TSMI_prounit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_prounit.Click
        frm_prounit.Show()
    End Sub
    Private Sub TSB_member_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_member.Click
        Call chk_TSL(False)
        Frm_member.Show()
    End Sub
    Private Sub TSB_staff_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_staff.ButtonClick
        Call chk_TSL(False)
        Frm_staff.Show()
    End Sub
    Private Sub tssb_sale_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssb_sale.ButtonClick
        If tsm_sale.Enabled = True Then
            Call chk_TSL(False)
            Frm_sale.Show()
        End If
    End Sub
    Private Sub tsm_sale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_sale.Click
        If tsm_saleD.Enabled = False Then
            Frm_sale.TSB_detai.Enabled = False
        End If
        Call chk_TSL(False)
        Frm_sale.Show()
    End Sub
    Private Sub tsm_saleD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_saleD.Click
        If tsm_sale.Enabled = False Then
            Frm_saledetail.TSB_sale.Enabled = False
        End If
        chk_tsmsaleD = "y"
        Call chk_TSL(False)
        Frm_saledetail.Show()
    End Sub

    Private Sub TSB_report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_report.Click
        Call chk_TSL(False)
        Frm_report.Show()
    End Sub
    Private Sub TSB_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_logout.Click
        Call chk_TSL(False)
        TSB_staff.Visible = False
        TSS_staff.Visible = False
        TSB_login.Enabled = True
    End Sub
    Private Sub tsm_licenses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_licenses.Click
        Frm_licenses.Show()
    End Sub
    Private Sub TSB_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_exit.Click
        Me.Close()
    End Sub
    Private Sub Frm_main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim a As Integer
        a = MessageBox.Show("ออกจากการโปรแกรม ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub tssBtn_IM_EX_ButtonClick(sender As Object, e As EventArgs) Handles tssBtn_IM_EX.ButtonClick
        frm_IMP_EXP.Show()
    End Sub
End Class