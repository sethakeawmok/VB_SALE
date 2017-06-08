Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Frm_saleselect
    Private Sub Frm_saleselect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call condb()
        Call cbo_findadd()
        Call showdata()
    End Sub
    Sub showdata()
        Dim row As Integer
        conn.Open()
        If cbo_findselect.SelectedValue.ToString = "all" Then
            If txt_findselect.Text = "" Then
                strSQl = "SELECT T_products.*,T_type.type_name,T_unit.unit_name FROM (T_products INNER JOIN T_type ON T_products.type_id=T_type.type_id) INNER JOIN T_unit ON T_products.unit_id=T_unit.unit_id  ORDER BY pd_id ASC"
            Else
                strSQl = "SELECT T_products.*,T_type.type_name,T_unit.unit_name FROM (T_products INNER JOIN T_type ON T_products.type_id=T_type.type_id) INNER JOIN T_unit ON T_products.unit_id=T_unit.unit_id WHERE pd_id LIKE '%" & txt_findselect.Text & "%' OR pd_name LIKE '%" & txt_findselect.Text & "%' ORDER BY pd_id ASC"
            End If
        Else
            If txt_findselect.Text = "" Then
                strSQl = "SELECT T_products.*,T_type.type_name,T_unit.unit_name FROM (T_products INNER JOIN T_type ON T_products.type_id=T_type.type_id) INNER JOIN T_unit ON T_products.unit_id=T_unit.unit_id WHERE T_products.type_id = '" & cbo_findselect.SelectedValue.ToString & "'  ORDER BY pd_id ASC"
            Else
                strSQl = "SELECT T_products.*,T_type.type_name,T_unit.unit_name FROM (T_products INNER JOIN T_type ON T_products.type_id=T_type.type_id) INNER JOIN T_unit ON T_products.unit_id=T_unit.unit_id WHERE (T_products.type_id = '" & cbo_findselect.SelectedValue.ToString & "') AND pd_id LIKE '%" & txt_findselect.Text & "%' OR pd_name LIKE '%" & txt_findselect.Text & "%' ORDER BY pd_id ASC"
            End If
        End If
        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader

        DGVproduct.Rows.Clear()
        While myreader.Read
            With DGVproduct
                .Rows.Add()
                .Rows(row).Cells("pd_id").Value = myreader("pd_id")
                .Rows(row).Cells("pd_name").Value = myreader("pd_name")
                .Rows(row).Cells("pd_brand").Value = myreader("pd_brand")
                .Rows(row).Cells("type_name").Value = myreader("type_name")
                .Rows(row).Cells("pd_stock").Value = myreader("pd_stock")
                .Rows(row).Cells("unit_name").Value = myreader("unit_name")
                .Rows(row).Cells("pd_price").Value = Format(myreader("pd_price"), "#,##0.00")
                .Rows(row).Cells("pd_picture").Value = myreader("pd_picture")
            End With
            row += 1
        End While
        conn.Close()
        Call DGV_add()
    End Sub
    Dim chk_cbofind As String
    Sub cbo_findadd()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet

        conn.Open()
        da = New OleDbDataAdapter("SELECT * FROM T_type ORDER BY type_chk DESC", conn)
        da.Fill(ds, "T_type")
        With cbo_findselect
            .DataSource = ds.Tables("T_type")

            .ValueMember = "type_id"
            .DisplayMember = "type_name"
        End With
        conn.Close()
        chk_cbofind = "ok"
    End Sub
    Private Sub cbo_findselect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_findselect.SelectedIndexChanged
        If chk_cbofind = "ok" Then
            Call showdata()
        End If
    End Sub
    Private Sub txt_findselect_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_findselect.TextChanged
        Call showdata()
    End Sub
    Sub DGV_add()
        On Error Resume Next
        PTB_product.ImageLocation = Application.StartupPath & "/Images/" & DGVproduct.CurrentRow.Cells("pd_picture").Value.ToString
    End Sub

    Private Sub DGVproduct_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVproduct.CellMouseClick
        Call DGV_add()

    End Sub
    Private Sub btn_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_select.Click
        chk_txtid = "ok"
        product = DGVproduct.CurrentRow.Cells("pd_id").Value.ToString
        Frm_sale.showdata()
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

   
End Class