Imports System.Data.OleDb
Imports System.IO
Public Class fromchinh
    Dim kn As OleDbConnection
    Private Sub fromchinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
        Me.IsMdiContainer = True

        dangxuat.Enabled = False
        mn_capnhat.Enabled = False
        mn_quanly.Enabled = False
        mn_kq.Enabled = False
        mn_baocao.Enabled = False
        Dim frm As New dangnhap
        frm.Show()

    End Sub
    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
    Private Sub ThoátToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles thoat.Click
        Me.Close()
    End Sub
    Private Sub dangnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dangnhap.Click
        Dim frm As New dangnhap
        frm.Show()
    End Sub

    ' Menu Cập Nhật Thông Tin
   
    Private Sub cnhocsinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnhocsinh.Click
        Dim frm As New capnhaphocsinh
        frm.Show()
    End Sub
    Private Sub cnlop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnlop.Click
        Dim frm As New capnhatlop
        frm.Show()
    End Sub
    Private Sub CậpNhậtNămHọcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New capnhatnamhoc()
        frm.Show()
    End Sub
    Private Sub cngiaovien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cngiaovien.Click
        Dim frm As New capnhatgiaovien
        frm.Show()
    End Sub

    Private Sub xeplop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xeplop.Click
        Dim frm As New saplop
        frm.Show()
    End Sub

    Private Sub QuảnLýGiáoViênDạyHọcChoLớpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qldaylop.Click
        Dim frm As New daylop
        frm.Show()
    End Sub

    Private Sub cndiemthi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cndiemthi.Click
        Dim frm As New capnhatdiemthi
        frm.Show()
    End Sub
    Private Sub cnhanhkiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnhanhkiem.Click
        Dim frm As New CNthemhanhkiemhocsinh
        frm.Show()
    End Sub
    Private Sub suahanhkiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New capnhathanhkiem
        frm.Show()
    End Sub



    Private Sub indsgiaovien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New capnhatgiaovien
        frm.Show()
    End Sub
 
    Private Sub indsdiemtbmon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles indsdiemtbmon.Click
        Dim frm As New indsdiemtbmon
        frm.Show()
    End Sub


    Private Sub doc_tt()
    End Sub


    Private Sub cnnienkhoa_Click(sender As Object, e As EventArgs) Handles cnnienkhoa.Click

        Dim frm As New capnhatnamhoc()
        frm.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class