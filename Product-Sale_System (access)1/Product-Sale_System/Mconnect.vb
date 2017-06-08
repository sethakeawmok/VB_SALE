Imports System.Data
Imports System.Data.OleDb

Module Mconnect
    Public conn As New OleDbConnection
    Public mycmd As New OleDbCommand
    Public myreader As OleDbDataReader
    Public strSQl As String
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





End Module
