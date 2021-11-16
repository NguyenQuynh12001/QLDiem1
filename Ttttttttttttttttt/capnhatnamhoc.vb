Imports System.Data.OleDb
Public Class capnhatnamhoc
    Dim kn As New OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Private Sub capnhatnamhoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
        load_danhsach_nienkhoa()
        danh_sach_PositionChanged(sender, e)
        luu_nk.Enabled = False
        huy_nk.Enabled = False
        luoi_nk.DefaultCellStyle.SelectionBackColor = Color.Yellow
        luoi_nk.DefaultCellStyle.SelectionForeColor = Color.Black
        luoi_nk.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub load_danhsach_nienkhoa()
        Dim sql As String = "select * from NIEN_KHOA"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        luoi_nk.DataSource = dt
        danh_sach = Me.BindingContext(dt)
        luoi_nk.Columns("MA_NK").HeaderText = "Mã Niên Khóa"
        luu_nk.Enabled = False
        huy_nk.Enabled = False
    End Sub
    Private Sub xuat_nienkhoa()
        txtma_nk.Text = danh_sach.Current("MA_NK")
    End Sub
    Private Sub danh_sach_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_nienkhoa()
    End Sub

    Function kiemtra(ByVal ma As String)
        Dim Sql As String = "select MA_NK from NIEN_KHOA where MA_NK='" & ma & "'"
        Dim Comm As New OleDbCommand(Sql, kn)
        Dim reader As OleDbDataReader = Comm.ExecuteReader
        If reader.Read Then
            Return True
        End If
        Return False
    End Function
    Sub them()
        If Trim(txtma_nk.Text) = "" Then
            MsgBox("Xin nhập vào niên khóa!")
            txtma_nk.Focus()
        ElseIf kiemtra(txtma_nk.Text) = True Then
            MsgBox(" Mã niên khóa này đã có!")
            txtma_nk.Clear()
            txtma_nk.Focus()
        Else
            Dim Sql As String = "Insert into NIEN_KHOA values('" & txtma_nk.Text & "')"
            Dim Com As New OleDbCommand(Sql, kn)
            Com.ExecuteNonQuery()
            MsgBox("Niên Khóa đã thêm thành công!", MsgBoxStyle.OkOnly)
            load_danhsach_nienkhoa()
            xuat_nienkhoa()
            them_nk.Enabled = True
            xoa_nk.Enabled = True
            luu_nk.Enabled = False
            huy_nk.Enabled = False
            luoi_nk.Enabled = True
        End If
    End Sub
    Private Sub them_nk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles them_nk.Click
        them_nk.Enabled = False
        xoa_nk.Enabled = False
        luu_nk.Enabled = True
        huy_nk.Enabled = True
        txtma_nk.Text = ""
        txtma_nk.Focus()
        j = 1
    End Sub
    Sub xoa()
        Dim sql As String
        sql = "delete * from NIEN_KHOA where MA_NK = '" & txtma_nk.Text & "'"
        Dim com As New OleDbCommand(sql, kn)
        com.ExecuteNonQuery()
        MsgBox("xóa thành công!", MsgBoxStyle.OkOnly)
        load_danhsach_nienkhoa()
        xuat_nienkhoa()

        them_nk.Enabled = True
        xoa_nk.Enabled = True
        luu_nk.Enabled = False
        huy_nk.Enabled = False
        luoi_nk.Enabled = True
    End Sub
    Dim j As Integer
    Private Sub luu_nk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luu_nk.Click
        If j = 1 Then
            them()
        End If
    End Sub
    Private Sub huy_nk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles huy_nk.Click
        them_nk.Enabled = True
        xoa_nk.Enabled = True
        luu_nk.Enabled = False
        huy_nk.Enabled = False
        xuat_nienkhoa()

        luoi_nk.Enabled = True
    End Sub
    Dim i As Integer
    Private Sub xoa_nk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xoa_nk.Click
        i = MsgBox("Bạn có muốn xóa mẫu tin này?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Lưu ý")
        If i = vbOK Then
            xoa()
        End If
    End Sub

   
End Class
