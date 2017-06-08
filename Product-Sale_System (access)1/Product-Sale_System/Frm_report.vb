Public Class Frm_report

   
    Private Sub Frm_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    Private Sub Frm_report_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frm_main.chk_TSL(True)
    End Sub

    Private Sub TSB_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_exit.Click
        Me.Close()
    End Sub
End Class