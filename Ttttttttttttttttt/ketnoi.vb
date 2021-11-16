Imports System.Data.OleDb
Module ket_noi
    Public Sub ketnoi(ByRef kn As OleDbConnection)
        Dim cns As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\..\..\data\QLHocBa.mdb"
        Try
            kn = New OleDbConnection(cns)
            kn.Open()
        Catch ex As Exception
            MessageBox.Show("khong the ket noi")
        End Try

    End Sub
End Module
