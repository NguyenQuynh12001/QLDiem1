Imports System.Data.OleDb
Public Class dangnhap
    Dim kn As OleDbConnection
    Private Sub dangnhap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
    End Sub
    Function kiemtra(ByVal user As String, ByVal passw As String)
        Dim Sql As String = "select * from TAI_KHOAN where NGUOI_DUNG='" & user & "' and MAT_KHAU='" & passw & "'"
        Dim Com As New OleDbCommand(Sql, kn)
        Dim reader As OleDbDataReader = Com.ExecuteReader
        If reader.Read Then
            Return True
        End If
        Return False
    End Function
    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        If username.Text = "" Then
            MsgBox("Bạn chưa nhập username !", MsgBoxStyle.Information)
            username.Focus()
        ElseIf password.Text = "" Then
            MsgBox("Bạn chưa nhập password !", MsgBoxStyle.Information)
            password.Focus()
        ElseIf kiemtra(username.Text, password.Text) = True Then
            fromchinh.mn_hethong.Enabled = True
            fromchinh.mn_capnhat.Enabled = True
            fromchinh.mn_quanly.Enabled = True
            fromchinh.mn_kq.Enabled = True
            fromchinh.mn_baocao.Enabled = True
            ' fromchinh.mn_giupdo.Enabled = True
            fromchinh.dangnhap.Enabled = False
            Me.Close()
        Else
            MsgBox("Sai username hoặc password! Vui lòng nhập lại!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            username.Text = ""
            password.Text = ""
            username.Focus()
        End If
    End Sub
    Private Sub close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles thoat.Click
        Me.Close()
    End Sub

End Class