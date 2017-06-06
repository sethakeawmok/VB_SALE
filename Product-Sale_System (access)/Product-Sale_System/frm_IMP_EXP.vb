Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class frm_IMP_EXP

    Private Sub frm_IMP_EXP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call condb()
        Call showdata()
    End Sub
    Sub showdata()
        Dim row As Integer
        conn.Close()
        conn.Open()

        strSQl = "SELECT T_products.*,T_type.type_name,T_unit.unit_name FROM (T_products LEFT JOIN T_type ON T_products.type_id=T_type.type_id) LEFT JOIN T_unit ON T_products.unit_id=T_unit.unit_id WHERE T_products.DEL_FLAG = 'N'  ORDER BY DATE_CREATE desc,pd_id_auto DESC"

        mycmd = New OleDbCommand(strSQl, conn)
        myreader = mycmd.ExecuteReader

        DGV_product.Rows.Clear()
        While myreader.Read
            With DGV_product
                .Rows.Add()
                .Rows(row).Cells("pd_id").Value = myreader("pd_id")
                .Rows(row).Cells("pd_name").Value = myreader("pd_name")
                .Rows(row).Cells("pd_brand").Value = myreader("pd_brand") 
                .Rows(row).Cells("type_name").Value = myreader("type_name")
                .Rows(row).Cells("pd_price").Value = Format(myreader("pd_price"), "#,##0.00")
                .Rows(row).Cells("pd_stock").Value = myreader("pd_stock")
                .Rows(row).Cells("unit_id").Value = myreader("unit_id")
                .Rows(row).Cells("unit_name").Value = myreader("unit_name")
                .Rows(row).Cells("DATE_CREATE").Value = myreader("DATE_CREATE")
                convers_dt_TH(myreader("DATE_CREATE"))
                .Rows(row).Cells("pd_picture").Value = myreader("pd_picture")
            End With
            row += 1

        End While
        conn.Close()
       
    End Sub
    Sub convers_dt_TH(dt As String)

        '        Dim number As Integer = 8
        '        Select Case number
        '            Case 1 To 5
        '                Debug.WriteLine("Between 1 and 5, inclusive")
        '                ' The following is the only Case clause that evaluates to True.
        '            Case 6, 7, 8
        '                Debug.WriteLine("Between 6 and 8, inclusive")
        '            Case 9 To 10
        '                Debug.WriteLine("Equal to 9 or 10")
        '            Case Else
        '                Debug.WriteLine("Not between 1 and 10, inclusive")
        '        End Select



        '        ALTER function [dbo].[dateTH2](@date datetime)
        '        returns varchar(50)
        'as
        '        begin()
        '	return  convert(varchar(2),day(@date))+ 
        '			case convert(varchar(2),month(@date)) 
        '				when '1' then ' มกราคม '
        '				when '2' then ' กุมภาพันธ์ '
        '				when '3' then ' มีนาคม '
        '				when '4' then ' เมษายน '
        '				when '5' then ' พฤษภาคม '
        '				when '6' then ' มิถุนายน '
        '				when '7' then ' กรกฎาคม '
        '				when '8' then ' สิงหาคม '
        '				when '9' then ' กันยายน ' 
        '				when '10' then ' ตุลาคม '
        '				when '11' then ' พฤศจิกายน '
        '				when '12' then ' ธันวาคม '
        '			end + convert(varchar(4),case when year(@date) > 2500 then year(@date) else year(@date)+543 end)
        '        End
    End Sub
End Class