Imports System.Data.OleDb
Public Class capnhatdiemthi
    Dim kn As New OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Private Sub capnhatdiemthi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
        load_danhsach()
        load_hocsinh()
        load_monhoc()
        load_hocky()
        load_nienkhoa()
        load_diem()
        xuat_ds()
        luu.Enabled = False
        huy.Enabled = False

        luoidt.DefaultCellStyle.SelectionBackColor = Color.Yellow
        luoidt.DefaultCellStyle.SelectionForeColor = Color.Black
        luoidt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub load_danhsach()
        Dim sql As String = "select hs.MA_HS, hs.HOTEN_HS, m.TEN_MON, hk.TEN_HK, nk.MA_NK, cdt.DIEM FROM HOC_SINH as hs, CO_DIEM_THI as cdt, HOC_KY as hk, NIEN_KHOA as nk, MON_HOC as m where  nk.MA_NK = cdt.MA_NK and hk.STT_HK = cdt.STT_HK and hs.MA_HS = cdt.MA_HS and m.MA_MON = cdt.MA_MON"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        luoidt.DataSource = dt
        danh_sach = Me.BindingContext(dt)

        luoidt.Columns(0).DataPropertyName = "MA_HS"
        luoidt.Columns(1).DataPropertyName = "HOTEN_HS"
        luoidt.Columns(2).DataPropertyName = "TEN_MON"
        luoidt.Columns(3).DataPropertyName = "TEN_HK"
        luoidt.Columns(4).DataPropertyName = "MA_NK"
        luoidt.Columns(5).DataPropertyName = "DIEM"

        luoidt.Columns(0).HeaderText = "Mã Học Sinh"
        luoidt.Columns(1).HeaderText = "Tên Học Sinh"
        luoidt.Columns(2).HeaderText = "Môn Học"
        luoidt.Columns(3).HeaderText = "Học Kỳ"
        luoidt.Columns(4).HeaderText = "Niên Khóa"
        luoidt.Columns(5).HeaderText = "Điểm"

    End Sub

    Private Sub load_hocsinh()
        Dim sql As String = "select * from HOC_SINH"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        mahs.DataSource = dt
        mahs.DisplayMember = "MA_HS"
        mahs.ValueMember = "HOC_SINH.MA_HS"
        mahs.SelectedValue = -1
    End Sub
    Private Sub load_monhoc()
        Dim sql As String = "select * from MON_HOC"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        tenmon.DataSource = dt
        tenmon.DisplayMember = "TEN_MON"
        tenmon.ValueMember = "MON_HOC.MA_MON"
        tenmon.SelectedValue = -1
    End Sub
    Private Sub load_hocky()
        Dim sql As String = "select * from HOC_KY"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        hocky.DataSource = dt
        hocky.DisplayMember = "TEN_HK"
        hocky.ValueMember = "HOC_KY.STT_HK"
        hocky.SelectedValue = -1
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
    Private Sub load_diem()
        Dim sql As String = "select * from CO_DIEM_THI"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        diem.Text = danh_sach.Current("DIEM")
        nienkhoa.DataSource = dt
    End Sub
    Private Sub xuat_ds()
        mahs.Text = danh_sach.Current("MA_HS")
        tenhs.Text = danh_sach.Current("HOTEN_HS")
        tenmon.Text = danh_sach.Current("TEN_MON")
        hocky.Text = danh_sach.Current("TEN_HK")
        nienkhoa.Text = danh_sach.Current("MA_NK")
        diem.Text = danh_sach.Current("DIEM")
    End Sub
    Private Sub danh_sach_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_ds()
    End Sub
    Sub them_diem()
        If mahs.Text = "" Then
            MsgBox("Chọn Mã Học Sinh!")
            mahs.Focus()
        ElseIf tenmon.Text = "" Then
            MsgBox("Chọn Tên Môn!")
            tenmon.Focus()
        ElseIf hocky.Text = "" Then
            MsgBox("Chọn Học Kỳ!")
            hocky.Focus()
        ElseIf Trim(nienkhoa.Text) = "" Then
            MsgBox("Chọn Niên Khóa !")
            nienkhoa.Focus()
        ElseIf kiemtra(mahs.SelectedValue, tenmon.SelectedValue, hocky.SelectedValue, nienkhoa.SelectedValue) = True Then
            MsgBox("Học Sinh Này Đã Được Thêm Vào Học Kỳ và Năm này rồi!")
            diem.Enabled = True
            mahs.Text = ""
            tenmon.Text = ""
            hocky.Text = ""
            nienkhoa.Text = ""
            diem.Text = ""
            tenmon.Text = ""
            mahs.Focus()
        Else
            Dim Sql As String = "Insert into CO_DIEM_THI(MA_HS, MA_MON, STT_HK, MA_NK, DIEM) values('" & mahs.SelectedValue & "','" & tenmon.SelectedValue & "', '" & hocky.SelectedValue & "', '" & nienkhoa.SelectedValue & "', '" & diem.Text & "')"
            Dim Com As New OleDbCommand(Sql, kn)
            Com.ExecuteNonQuery()
            MsgBox("Đã Thêm Điểm Thành Công", MsgBoxStyle.OkOnly)
            load_danhsach()
            them.Enabled = True
            xoa.Enabled = True
            luu.Enabled = False
            huy.Enabled = False

            diem.Enabled = False
            luoidt.Enabled = True
        End If
    End Sub
    Function kiemtra(ByVal hs As String, ByVal mon As String, ByVal hk As String, ByVal nienkhoa As String)
        Dim Sql As String = "select MA_HS, MA_MON, STT_HK, MA_NK from CO_DIEM_THI where MA_HS ='" & hs & "'and MA_MON = '" & mon & "' and STT_HK='" & hk & "' and  MA_NK='" & nienkhoa & "'"
        Dim Comm As New OleDbCommand(Sql, kn)
        Dim reader As OleDbDataReader = Comm.ExecuteReader
        If reader.Read Then
            Return True
        End If
        Return False
    End Function
    Private Sub them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles them.Click

        diem.Enabled = True
        luoidt.Enabled = False
        them.Enabled = False
        xoa.Enabled = False
        luu.Enabled = True
        huy.Enabled = True
        mahs.SelectedIndex = -1
        tenmon.SelectedIndex = -1
        mahs.Focus()
        diem.Clear()
    End Sub
    Sub sua_diem()
        Dim sql As String
        sql = "Update CO_DIEM_THI set DIEM = '" & diem.Text & "' where MA_HS ='" & Trim(mahs.SelectedValue) & "' and MA_MON = '" & tenmon.SelectedValue & "' and STT_HK = '" & hocky.SelectedValue & "' and MA_NK = '" & nienkhoa.SelectedValue & "'"

        Dim com As New OleDbCommand(sql, kn)
        com.ExecuteNonQuery()
        MsgBox("Sửa thành công!", MsgBoxStyle.OkOnly)
        load_danhsach()
        xuat_ds()
        them.Enabled = True
        xoa.Enabled = True
        luu.Enabled = False
        huy.Enabled = False
        luoidt.Enabled = True
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

        luoidt.Enabled = True
        diem.Enabled = False
    End Sub
    Sub xoa_diemthi()
        Dim sql As String
        sql = " delete * from CO_DIEM_THI where  MA_HS = '" & mahs.SelectedValue & "' and MA_MON = '" & tenmon.SelectedValue & "' and STT_HK = '" & hocky.SelectedValue & "' and MA_NK = '" & nienkhoa.SelectedValue & "'"
        Dim com As New OleDbCommand(sql, kn)
        com.ExecuteNonQuery()
        MsgBox("Đã xóa!", MsgBoxStyle.OkOnly)
        load_danhsach()
        luoidt.Enabled = True
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
  
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles diem.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) Or Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Chỉ được nhập số !")
            e.Handled = True
        Else
            Dim giatri As Integer
            If giatri > 10 Then
                MessageBox.Show("Nhập điểm phải nhỏ hơn 10!")
                e.Handled = True
            End If
        End If

    End Sub

End Class