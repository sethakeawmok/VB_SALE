Imports System.Data
Imports System.Data.OleDb

Imports System.Globalization
Module Mconnect
    Public conn As New OleDbConnection
    Public mycmd As New OleDbCommand
    Public myreader As OleDbDataReader
    Public strSQl As String

    Dim ct_en As CultureInfo = New System.Globalization.CultureInfo("en-US")
    Dim ct_th As CultureInfo = New System.Globalization.CultureInfo("th-TH")

    Public Sub condb()
        Dim str As String
        str = "provider=Microsoft.ACE.OLEDB.12.0;DATA source=" & Application.StartupPath & "\ProductManeger_db.accdb;"
        Try
            conn.ConnectionString = str
            'MsgBox("เชื่อมต่อข้อมูลสำเร็จ")
        Catch ex As Exception
            MsgBox("เชื่อมต่อข้อมูลไม่สำเร็จ")
        End Try
    End Sub


    ''Login
    Public fname, status, admin, licenses As String
    ''เก็บค่าสินค้าที่ขาย
    Public product, chk_txtid As String
    ''เช็คเมนู
    Public chk_tsmsaleD As String

    Public dtn_EN As String = DateTime.Parse(DateTime.Now.ToString(), ct_th).ToString("yyyy-MM-dd", ct_en)




End Module
