Imports System.Data.OleDb
Public Class daylop
    Dim kn As New OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Private Sub daylop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
        load_daylop()
        danh_sach_PositionChanged(sender, e)
        load_nienkhoa()
        load_lop()
        load_khoi()
        load_monhoc()
        load_chuyenmon()
        load_gv()
        luu.Enabled = False
        huy.Enabled = False
        luoi.DefaultCellStyle.SelectionBackColor = Color.Yellow
        luoi.DefaultCellStyle.SelectionForeColor = Color.Black
        luoi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub danh_sach_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged

    End Sub
    Private Sub load_daylop()
        Dim sql As String = "select DISTINCT gv.MA_GV, gv.HOTEN_GV, cm.TEN_CM, mh.TEN_MON, k.MA_KHOI & l.MA_LOP as TENLOP, nk.MA_NK, k.MA_KHOI, l.MA_LOP from GIAO_VIEN as gv, DAY_LOP as dl, MON_HOC as mh, THUOC as t, LOP as l, KHOI as k, NIEN_KHOA as nk, CHUYEN_MON2 as cm2, CHUYEN_MON as cm Where gv.MA_GV = cm2.MA_GV and cm2.MA_CM = cm.MA_CM and gv.MA_GV = dl.MA_GV and dl.MA_MON = mh.MA_MON and t.MA_LOP = l.MA_LOP and t.MA_KHOI = k.MA_KHOI and dl.MA_NK = t.MA_NK and t.MA_LOP = dl.MA_LOP and t.MA_KHOI = dl.MA_KHOI and nk.MA_NK = t.MA_NK"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        luoi.DataSource = dt
        danh_sach = Me.BindingContext(dt)

        luoi.Columns(0).DataPropertyName = "MA_GV"
        luoi.Columns(1).DataPropertyName = "HOTEN_GV"
        luoi.Columns(2).DataPropertyName = "TEN_CM"
        luoi.Columns(3).DataPropertyName = "TEN_MON"
        luoi.Columns(4).DataPropertyName = "TENLOP"
        luoi.Columns(5).DataPropertyName = "MA_NK"
        luoi.Columns(6).DataPropertyName = "MA_KHOI"
        luoi.Columns(7).DataPropertyName = "MA_LOP"
        luoi.Columns(6).Visible = False
        luoi.Columns(7).Visible = False

        luoi.Columns(0).HeaderText = "Mã Giáo Viên"
        luoi.Columns(1).HeaderText = "Tên Giáo Viên"
        luoi.Columns(2).HeaderText = "Có Chuyên Môn"
        luoi.Columns(3).HeaderText = "Dạy Môn"
        luoi.Columns(4).HeaderText = "Lớp"
        luoi.Columns(5).HeaderText = "Niên Khóa"
        luoi.Columns(6).HeaderText = "Khối"
        luoi.Columns(7).HeaderText = "Lớp"

        luoi.Enabled = True
    End Sub
    Private Sub load_gv()
        Dim sql As String = "select * from GIAO_VIEN"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        magv.DataSource = dt
        magv.DisplayMember = "MA_GV"
        magv.ValueMember = "MA_GV"
        magv.SelectedValue = -1
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
    Private Sub load_lop()
        Dim sql As String = "select * from LOP"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        malop.DataSource = dt
        malop.DisplayMember = "MA_LOP"
        malop.ValueMember = "MA_LOP"
        malop.SelectedValue = -1
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
    Private Sub load_monhoc()
        Dim sql As String = "select * from MON_HOC"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        monhoc.DataSource = dt
        monhoc.DisplayMember = "TEN_MON"
        monhoc.ValueMember = "MON_HOC.MA_MON"
        monhoc.SelectedValue = -1
    End Sub
    Private Sub load_chuyenmon()
        Dim sql As String = "select * from CHUYEN_MON"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        chuyenmon.DataSource = dt
        chuyenmon.DisplayMember = "TEN_CM"
        chuyenmon.ValueMember = "MON_HOC.MA_CM"
        chuyenmon.SelectedValue = -1
    End Sub

    Sub kt()
    End Sub
    Sub them_daylop()
        If magv.Text = "" Then
            MsgBox("Xin chọn Giáo Viên!")
            magv.Focus()
        ElseIf chuyenmon.Text = "" Then
            MsgBox("Xin chọn chuyên môn!")
            chuyenmon.Focus()
        ElseIf kiemtrac(magv.SelectedValue, chuyenmon.SelectedValue) = True Then
            MsgBox("Giáo viên không đúng chuyên môn!")
            magv.Focus()
        End If

        If kiemtrac(magv.SelectedValue, chuyenmon.SelectedValue) = False Then
            If monhoc.Text = "" Then
                MsgBox("Xin chọn tên môn!")
                monhoc.Focus()
            ElseIf makhoi.Text = "" Then
                MsgBox("Xin chọn Khối!")
                makhoi.Focus()
            ElseIf malop.Text = "" Then
                MsgBox("Xin chọn Lớp!")
                malop.Focus()
            ElseIf nienkhoa.Text = "" Then
                MsgBox("Xin chọn Niên Khóa !")
                nienkhoa.Focus()
                magv.Text = ""
                malop.Text = ""
                makhoi.Text = ""
                monhoc.Text = ""
                nienkhoa.Text = ""
                makhoi.Focus()
            ElseIf kiemtrachung(magv.SelectedValue, monhoc.SelectedValue, makhoi.SelectedValue, malop.SelectedValue, nienkhoa.SelectedValue) Then
                MsgBox("Giáo Viên này đã được sắp dạy lớp này rồi!")
                magv.Text = ""
                makhoi.Text = ""
                malop.Text = ""
                monhoc.Text = ""
                nienkhoa.Text = ""
                magv.Focus()
            Else
                Dim Sql As String = "Insert into DAY_LOP values('" & magv.SelectedValue & "','" & monhoc.SelectedValue & "','" & makhoi.SelectedValue & "','" & malop.SelectedValue & "','" & nienkhoa.SelectedValue & "')"
                Dim Com As New OleDbCommand(Sql, kn)
                Com.ExecuteNonQuery()
                MsgBox("Lớp đã được thêm!", MsgBoxStyle.OkOnly)
                load_daylop()
                them.Enabled = True
                xoa.Enabled = True
                luoi.Enabled = True
            End If
        End If

    End Sub
    Function kiemtrachung(ByVal gv As String, ByVal mon As String, ByVal khoi As String, ByVal lop As String, ByVal nienkhoa As String)
        Dim Sql As String = "select * from DAY_LOP where MA_GV='" & gv & "' and MA_MON ='" & mon & "' and MA_KHOI='" & khoi & "'and MA_LOP='" & lop & "'and MA_NK = '" & nienkhoa & "'"
        Dim Comm As New OleDbCommand(Sql, kn)
        Dim reader As OleDbDataReader = Comm.ExecuteReader
        If reader.Read Then
            Return True
        End If
        Return False
    End Function
    Function kiemtrac(ByVal gv As String, ByVal cm As String)
        Dim Sql As String = "select * from CHUYEN_MON2 where MA_GV = '" & gv & "' and MA_CM <> '" & cm & "'"
        Dim Comm As New OleDbCommand(Sql, kn)
        Dim reader As OleDbDataReader = Comm.ExecuteReader
        If reader.Read Then
            Return True
        End If
        Return False
    End Function
    Private Sub them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles them.Click
        luoi.Enabled = False
        them.Enabled = False
        xoa.Enabled = False
        luu.Enabled = True
        huy.Enabled = True
        luoi.Enabled = False
    End Sub
    Private Sub luu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luu.Click
        them_daylop()
    End Sub
    Private Sub huy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles huy.Click
        them.Enabled = True
        xoa.Enabled = True
        luu.Enabled = False
        huy.Enabled = False
        load_daylop()
    End Sub
    Sub xoa_hslop()
        Dim sql As String
        sql = " delete * from DAY_LOP where MA_GV = '" & magv.SelectedValue & "' and MA_MON = '" & monhoc.SelectedValue & "' and MA_KHOI = '" & makhoi.SelectedValue & "' and MA_LOP ='" & malop.SelectedValue & "' and MA_NK = '" & nienkhoa.SelectedValue & "' "
        Dim com As New OleDbCommand(sql, kn)
        com.ExecuteNonQuery()
        MsgBox("Đã xóa!", MsgBoxStyle.OkOnly)
        luoi.Enabled = True
        load_daylop()
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
    
End Class