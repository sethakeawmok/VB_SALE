Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Frm_saledetail
    Dim GetArrsale_id() As String
    Private Sub Frm_saledetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
        Call showdata()
    End Sub
    Sub showdata()
        Dim pricetotal, distotal, pricesum As Single
        Dim row As Integer
        DGV_saledetail.Rows.Clear()
        With DGV_saledetail
            conn.Open()
            strSQl = "SELECT * FROM T_sale ORDER BY sale_date DESC"

            mycmd = New OleDbCommand(strSQl, conn)
            myreader = mycmd.ExecuteReader
            While myreader.Read
                .Rows.Add()
                .Rows(row).Cells("sale_detailID").Value = myreader("sale_id")
                .Rows(row).Cells("mem_status").Value = myreader("mem_status")
                pricetotal = pricetotal + myreader("sale_total")
                .Rows(row).Cells("sale_total").Value = Format(myreader("sale_total"), "#,##0.00")
                distotal = distotal + myreader("sale_discount")
                .Rows(row).Cells("sale_discus").Value = Format(myreader("sale_discount"), "#,##0.00")
                pricesum = pricesum + myreader("sale_sum")
                .Rows(row).Cells("sale_sum").Value = Format(myreader("sale_sum"), "#,##0.00")
                .Rows(row).Cells("date_sale").Value = myreader("sale_date")
                dtp_End.MinDate = myreader("sale_date")
                dtp_Start.MinDate = myreader("sale_date")
                dtp_Start.Value = myreader("sale_date")
                ReDim Preserve GetArrsale_id(row)
                GetArrsale_id(row) = myreader("sale_id")
                row += 1
            End While
            conn.Close()
            For i = 0 To row - 1
                strSQl = "SELECT COUNT(det_id) AS countpeople FROM T_saledetail WHERE sale_id='" & GetArrsale_id(i) & "'"
                conn.Open()
                mycmd = New OleDbCommand(strSQl, conn)
                myreader = mycmd.ExecuteReader
                myreader.Read()
                .Rows(i).Cells("sale_num").Value = myreader("countpeople")
                conn.Close()
            Next
        End With

        conn.Open()
        strSQl = "SELECT * FROM T_sale ORDER BY sale_date DESC"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader
        myreader.Read()
        dtp_Start.MaxDate = myreader("sale_date")
        dtp_End.MaxDate = myreader("sale_date")
        conn.Close()

        lbl_totalSale.Text = Format(pricetotal, "#,##0.00")
        lbl_distotal.Text = Format(distotal, "#,##0.00")
        lbl_sumtotal.Text = Format(pricesum, "#,##0.00")
    End Sub
    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        Call show_subdata()
    End Sub
    Sub show_subdata()
        On Error Resume Next
        Dim row As Integer
        conn.Open()
        strSQl = "SELECT T_saledetail.*,T_products.pd_name FROM T_saledetail INNER JOIN T_products ON T_saledetail.pd_id=T_products.pd_id WHERE sale_id='" + DGV_saledetail.CurrentRow.Cells("sale_detailID").Value.ToString + "' ORDER BY sale_id ASC"
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader

        DGV_subdetail.Rows.Clear()
        While myreader.Read
            With DGV_subdetail
                .Rows.Add()
                .Rows(row).Cells("no").Value = row + 1
                .Rows(row).Cells("pro_id").Value = myreader("pd_id")
                .Rows(row).Cells("pro_name").Value = myreader("pd_name")
                .Rows(row).Cells("pro_nub").Value = myreader("det_stock")
                .Rows(row).Cells("sub_saletotal").Value = myreader("det_pricetotal")
                .Rows(row).Cells("sub_discus").Value = myreader("det_discus")
                .Rows(row).Cells("sub_total").Value = myreader("det_pricecus")
                row += 1
            End With
        End While
        conn.Close()
    End Sub
    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        DGV_subdetail.Rows.Clear()
    End Sub

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Dim cut, get_st, get_end As String
        For i = 1 To Len(Trim(dtp_Start.Value))
            cut = Mid(dtp_Start.Value, i, 1)
            If cut = " " Then
                get_st = Mid(dtp_Start.Value, 1, i)
                Exit For
            End If
        Next
        For i = 1 To Len(Trim(dtp_End.Value))
            cut = Mid(dtp_End.Value, i, 1)
            If cut = " " Then
                get_end = Mid(dtp_End.Value, 1, i) & "23:59:59"
                Exit For
            End If
        Next

        Dim pricetotal, distotal, pricesum As Single
        Dim row As Integer
        DGV_saledetail.Rows.Clear()
        With DGV_saledetail
            conn.Open()
            'strSQl = "SELECT * FROM T_sale WHERE sale_date BETWEEN '" & dtp_Start.Value & "' AND '" & dtp_End.Value & "'"
            strSQl = "SELECT * FROM T_sale WHERE sale_date >= '" & get_st & "' AND sale_date <= '" & get_end & "'"

            mycmd = New OleDbCommand(strSQl, conn)
            myreader = mycmd.ExecuteReader

            While myreader.Read
                .Rows.Add()
                .Rows(row).Cells("sale_detailID").Value = myreader("sale_id")
                .Rows(row).Cells("mem_status").Value = myreader("mem_status")
                pricetotal = pricetotal + myreader("sale_total")
                .Rows(row).Cells("sale_total").Value = Format(myreader("sale_total"), "#,##0.00")
                distotal = distotal + myreader("sale_discount")
                .Rows(row).Cells("sale_discus").Value = Format(myreader("sale_discount"), "#,##0.00")
                pricesum = pricesum + myreader("sale_sum")
                .Rows(row).Cells("sale_sum").Value = Format(myreader("sale_sum"), "#,##0.00")
                .Rows(row).Cells("date_sale").Value = myreader("sale_date")
                ReDim Preserve GetArrsale_id(row)
                GetArrsale_id(row) = myreader("sale_id")
                row += 1
            End While
            conn.Close()
            For i = 0 To row - 1
                strSQl = "SELECT COUNT(det_id) AS countpeople FROM T_saledetail WHERE sale_id='" & GetArrsale_id(i) & "'"
                conn.Open()
                mycmd = New OleDbCommand(strSQl, conn)
                myreader = mycmd.ExecuteReader
                myreader.Read()
                .Rows(i).Cells("sale_num").Value = myreader("countpeople")
                conn.Close()
            Next
        End With
        lbl_totalSale.Text = Format(pricetotal, "#,##0.00")
        lbl_distotal.Text = Format(distotal, "#,##0.00")
        lbl_sumtotal.Text = Format(pricesum, "#,##0.00")
    End Sub
    Private Sub TSB_sale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_sale.Click

    End Sub
    Private Sub TSB_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_exit.Click
        Me.Close()
    End Sub
    Private Sub Frm_saledetail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If chk_tsmsaleD = "y" Then
            chk_tsmsaleD = ""
            Frm_main.chk_TSL(True)
        End If
    End Sub

   
   
End Class