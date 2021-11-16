Imports System.Data.OleDb
Public Class saplop
    Dim kn As New OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Private Sub saplop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
        load_hoc()
        danh_sach_PositionChanged(sender, e)
        load_hocsinh()
        load_lop()
        load_khoi()
        load_nienkhoa()
        xuat_ds()
        luu.Enabled = False
        huy.Enabled = False
        luoixl.DefaultCellStyle.SelectionBackColor = Color.Yellow
        luoixl.DefaultCellStyle.SelectionForeColor = Color.Black
        luoixl.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub danh_sach_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_ds()
    End Sub
    Private Sub load_hoc()
        Dim sql As String = "select DISTINCT hs.MA_HS, hs.HOTEN_HS, (k.MA_KHOI & l.MA_LOP) as TENLOP, l.MA_LOP, k.MA_KHOI, nk.MA_NK FROM HOC_SINH as hs, HOC as hc , KHOI as k, LOP as l, NIEN_KHOA as nk, THUOC as t where(hs.MA_HS = hc.MA_HS And k.MA_KHOI = t.MA_KHOI And l.MA_LOP = t.MA_LOP And nk.MA_NK = t.MA_NK and hc.MA_LOP = t.MA_LOP and hc.Ma_KHOI = t.MA_KHOI and hc.MA_NK = t.MA_NK)"

        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        luoixl.DataSource = dt
        danh_sach = Me.BindingContext(dt)

        danh_sach = Me.BindingContext(dt)
        luoixl.Columns(0).DataPropertyName = "MA_HS"
        luoixl.Columns(1).DataPropertyName = "HOTEN_HS"
        luoixl.Columns(2).DataPropertyName = "TENLOP"
        luoixl.Columns(3).DataPropertyName = "MA_KHOI"
        luoixl.Columns(4).DataPropertyName = "MA_LOP"
        luoixl.Columns(5).DataPropertyName = "MA_NK"
        luoixl.Columns(3).Visible = False
        luoixl.Columns(4).Visible = False

        luoixl.Columns(0).HeaderText = "Mã Học sinh"
        luoixl.Columns(1).HeaderText = "Tên Học Sinh"
        luoixl.Columns(2).HeaderText = "Lớp Học"
        luoixl.Columns(3).HeaderText = "Khối"
        luoixl.Columns(4).HeaderText = "Lớp"
        luoixl.Columns(5).HeaderText = "Năm Học"

        luoixl.Enabled = True
    End Sub
    Private Sub xuat_ds()
        mahs.Text = danh_sach.Current("MA_HS")
        tenhs.Text = danh_sach.Current("HOTEN_HS")
        makhoi.Text = danh_sach.Current("MA_KHOI")
        malop.Text = danh_sach.Current("MA_LOP")
        nienkhoa.Text = danh_sach.Current("MA_NK")
        luu.Enabled = False
        huy.Enabled = False

    End Sub
    Private Sub load_hocsinh()
        Dim sql As String = "select * from HOC_SINH"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        mahs.DataSource = dt
        mahs.DisplayMember = "MA_HS"
        mahs.ValueMember = "MA_HS"
        mahs.SelectedValue = -1
    End Sub
    Private Sub load_lop()
        Dim sql As String = "select * from LOP"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        malop.DataSource = dt
        malop.DisplayMember = "MA_LOP"
        malop.ValueMember = "LOP.MA_LOP"
        malop.SelectedValue = -1
    End Sub
    Private Sub load_khoi()
        Dim sql As String = "select * from KHOI"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        makhoi.DataSource = dt
        makhoi.DisplayMember = "KHOI"
        makhoi.ValueMember = "MA_KHOI"
        makhoi.SelectedValue = -1
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
    Sub them_lophoc()
        If mahs.Text = "" Then
            MsgBox("Chọn Học Sinh !")
            mahs.Focus()
        ElseIf makhoi.Text = "" Then
            MsgBox("Chọn Mã Khối !")
            makhoi.Focus()
        ElseIf malop.Text = "" Then
            MsgBox("Chọn Lớp!")
            malop.Focus()
        ElseIf nienkhoa.Text = "" Then
            MsgBox("Chọn Niên Khóa !")
            nienkhoa.Focus()
            mahs.Text = ""
            malop.Text = ""
            makhoi.Text = ""
            nienkhoa.Text = ""
            makhoi.Focus()
        ElseIf kiemtratrung(mahs.SelectedValue, makhoi.SelectedValue, nienkhoa.SelectedValue) Then
            MsgBox("Học Sinh này đã được sắp trong năm nay!")
            mahs.Text = ""
            makhoi.Text = ""
            malop.Text = ""
            nienkhoa.Text = ""
            mahs.Focus()
        ElseIf kiemtrahs(mahs.SelectedValue, nienkhoa.SelectedValue) Then
            MsgBox("Năm Này học sinh đã có lớp học!")
            mahs.Text = ""
            makhoi.Text = ""
            malop.Text = ""
            nienkhoa.Text = ""
            mahs.Focus()
        ElseIf kiemtrahsrieng(mahs.SelectedValue) Then
            MsgBox("Học sinh này đã có lớp!")
            mahs.Text = ""
            makhoi.Text = ""
            malop.Text = ""
            nienkhoa.Text = ""
            mahs.Focus()
        Else
            Dim Sql As String = "Insert into HOC values('" & mahs.SelectedValue & "','" & makhoi.SelectedValue & "','" & malop.SelectedValue & "','" & nienkhoa.SelectedValue & "')"
            Dim Com As New OleDbCommand(Sql, kn)
            Com.ExecuteNonQuery()
            MsgBox("Sắp lớp đã thành công!", MsgBoxStyle.OkOnly)
            load_hoc()
            them.Enabled = True
            xoa.Enabled = True
            luoixl.Enabled = True
        End If
    End Sub
    Function kiemtratrung(ByVal hs As String, ByVal khoi As String, ByVal nienkhoa As String)
        Dim Sql As String = "select * from HOC where MA_HS='" & hs & "' and MA_KHOI='" & khoi & "'and MA_NK = '" & nienkhoa & "'"
        Dim Comm As New OleDbCommand(Sql, kn)
        Dim reader As OleDbDataReader = Comm.ExecuteReader
        If reader.Read Then
            Return True
        End If
        Return False
    End Function
    Function kiemtrahs(ByVal hs As String, ByVal nienkhoa As String)
        Dim Sql As String = "select * from HOC where MA_HS='" & hs & "' and MA_NK = '" & nienkhoa & "'"
        Dim Comm As New OleDbCommand(Sql, kn)
        Dim reader As OleDbDataReader = Comm.ExecuteReader
        If reader.Read Then
            Return True
        End If
        Return False
    End Function
    Function kiemtrahsrieng(ByVal hs As String)
        Dim Sql As String = "select * from HOC where MA_HS='" & hs & "' "
        Dim Comm As New OleDbCommand(Sql, kn)
        Dim reader As OleDbDataReader = Comm.ExecuteReader
        If reader.Read Then
            Return True
        End If
        Return False
    End Function
    Private Sub them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles them.Click
        luoixl.Enabled = False
        them.Enabled = False
        xoa.Enabled = False
        luu.Enabled = True
        huy.Enabled = True
        luoixl.Enabled = False
    End Sub
    Sub xoa_hslop()
        Dim sql As String
        sql = " delete * from HOC where MA_HS = '" & mahs.SelectedValue & "' and MA_KHOI = '" & makhoi.SelectedValue & "' and MA_LOP ='" & malop.SelectedValue & "' and MA_NK = '" & nienkhoa.SelectedValue & "'"
        Dim com As New OleDbCommand(sql, kn)
        com.ExecuteNonQuery()
        MsgBox("Đã xóa!", MsgBoxStyle.OkOnly)
        luoixl.Enabled = True
        load_hoc()
        xuat_ds()
        them.Enabled = True
        xoa.Enabled = True
    End Sub
    Dim i As Integer
    Private Sub xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xoa.Click
        i = MsgBox("Bạn có muốn xóa mẫu tin này?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Lưu ý")
        If i = vbOK Then
            xoa_hslop()
        End If
    End Sub
    Private Sub huy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles huy.Click
        them.Enabled = True
        xoa.Enabled = True
        luu.Enabled = False
        huy.Enabled = False
        xuat_ds()
    End Sub
  
    Private Sub luu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luu.Click
        them_lophoc()
    End Sub
End Class