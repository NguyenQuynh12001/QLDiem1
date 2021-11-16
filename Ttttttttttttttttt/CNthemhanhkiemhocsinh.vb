Imports System.Data.OleDb
Public Class CNthemhanhkiemhocsinh
    Dim kn As New OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Private Sub CNthemhanhkiemhocsinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
        load_danhsach()
        danh_sach_PositionChanged(sender, e)
        load_hocsinh()
        load_nienkhoa()
        load_hanhkiem()
        luu.Enabled = False
        huy.Enabled = False
        xuat_ds()

        luoi.DefaultCellStyle.SelectionBackColor = Color.Yellow
        luoi.DefaultCellStyle.SelectionForeColor = Color.Black
        luoi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub load_danhsach()
        Dim sql As String = "select Distinct hs.MA_HS, hs.HOTEN_HS, nk.MA_NK, hkiem.HANHKIEM FROM HOC_SINH as hs, HANH_KIEM as hkiem, NIEN_KHOA as nk where hkiem.MA_NK = nk.MA_NK and hs.MA_HS = hkiem.MA_HS"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        luoi.DataSource = dt
        danh_sach = Me.BindingContext(dt)

        luoi.Columns(0).DataPropertyName = "MA_HS"
        luoi.Columns(1).DataPropertyName = "HOTEN_HS"
        luoi.Columns(2).DataPropertyName = "MA_NK"
        luoi.Columns(3).DataPropertyName = "HANHKIEM"

        luoi.Columns(0).HeaderText = "Mã Học Sinh"
        luoi.Columns(1).HeaderText = "Tên Học Sinh"
        luoi.Columns(2).HeaderText = "Niên Khóa"
        luoi.Columns(3).HeaderText = "Hạnh Kiểm"


    End Sub

    Private Sub xuat_ds()
        mahs.Text = danh_sach.Current("MA_HS")
        nienkhoa.Text = danh_sach.Current("MA_NK")
        hanhkiem.Text = danh_sach.Current("HANHKIEM")
    End Sub
    Private Sub danh_sach_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_ds()
    End Sub
    Private Sub load_hocsinh()
        Dim sql As String = "select * from HOC_SINH"
        Dim da As New OleDbDataAdapter(Sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        mahs.DataSource = dt
        mahs.DisplayMember = "MA_HS"
        mahs.ValueMember = "HOC_SINH.MA_HS"
        mahs.SelectedValue = -1
    End Sub
    Private Sub load_nienkhoa()
        Dim sql As String = "select * from NIEN_KHOA"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        nienkhoa.DataSource = dt
        nienkhoa.DisplayMember = "MA_NK"
        nienkhoa.ValueMember = "NIEN_KHOA.MA_NK"
        nienkhoa.SelectedValue = -1
    End Sub
    Private Sub load_hanhkiem()
        Dim sql As String = "select * from HANH_KIEM"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        hanhkiem.Text = danh_sach.Current("HANHKIEM")
    End Sub
    Sub them_diem()
        If mahs.Text = "" Then
            MsgBox("Xin Chọn Mã Học Sinh!")
            mahs.Focus()
        ElseIf kiemtrachung(mahs.SelectedValue) Then
            MsgBox("Bạn đã chọn học sinh đã có hạnh kiểm!")
            mahs.Text = ""
            mahs.Focus()
        ElseIf Trim(nienkhoa.Text) = "" Then
            MsgBox("Xin Chọn Niên Khóa !")
            nienkhoa.Focus()
        Else
            Dim Sql As String = "Insert into HANH_KIEM(MA_HS, MA_NK, HANHKIEM) values('" & mahs.SelectedValue & "','" & nienkhoa.SelectedValue & "', '" & hanhkiem.Text & "')"
            Dim Com As New OleDbCommand(Sql, kn)
            Com.ExecuteNonQuery()
            MsgBox("Đã Thêm Điểm Thành Công", MsgBoxStyle.OkOnly)
            load_danhsach()
            them.Enabled = True
            xoa.Enabled = True
            luu.Enabled = False
            huy.Enabled = False

            hanhkiem.Enabled = False

            luoi.Enabled = True
        End If
    End Sub
    Function kiemtrachung(ByVal hs As String)
        Dim Sql As String = "select * from HANH_KIEM where MA_HS ='" & hs & "'"
        Dim Comm As New OleDbCommand(Sql, kn)
        Dim reader As OleDbDataReader = Comm.ExecuteReader
        If reader.Read Then
            Return True
        End If
        Return False
    End Function
    Private Sub them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles them.Click

        hanhkiem.Enabled = True
        luoi.Enabled = False

        them.Enabled = False
        xoa.Enabled = False
        luu.Enabled = True
        huy.Enabled = True
        mahs.SelectedIndex = -1
        mahs.Focus()
    End Sub
    Private Sub luu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luu.Click
        them_diem()
    End Sub
    Private Sub huy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles huy.Click
        them.Enabled = True
        xoa.Enabled = True
        luu.Enabled = False
        huy.Enabled = False
        load_danhsach()
        xuat_ds()
        danh_sach_PositionChanged(sender, e)

        luoi.Enabled = True

        hanhkiem.Enabled = False
    End Sub
    Sub xoa_diemthi()
        Dim sql As String
        sql = " delete * from HANH_KIEM where  MA_HS = '" & mahs.SelectedValue & "' and MA_NK = '" & nienkhoa.SelectedValue & "'"
        Dim com As New OleDbCommand(sql, kn)
        com.ExecuteNonQuery()
        MsgBox("Đã xóa!", MsgBoxStyle.OkOnly)
        load_danhsach()

        luoi.Enabled = True
        them.Enabled = True
        xoa.Enabled = True
        xuat_ds()
    End Sub
    Dim i As Integer
    Private Sub xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xoa.Click
        i = MsgBox("Bạn có muốn xóa mẫu tin này?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Lưu ý")
        If i = vbOK Then
            xoa_diemthi()
        End If
    End Sub
 
End Class