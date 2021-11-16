Imports System.Data.OleDb

Public Class indsdiemtbmon
    Dim kn As New OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Dim dvgGiaoVien As New DataView
    Private Sub indsdiemtbmon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim frm As New capnhaphocsinh
        frm.Show()
        frm.Hide()
        ketnoi(kn)
        load_ds()
        load_hocky()
        load_nienkhoa()
    End Sub
    Private Sub load_ds()
        Dim sql As String = "select MA_HS, HOTEN_HS,TEN_MON, STT_HK, MA_NK, TONGDIEM from DIEM_TB_MONHOC"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        luoi.DataSource = dt
        danh_sach = Me.BindingContext(dt)

        luoi.Columns(0).DataPropertyName = "MA_HS"
        luoi.Columns(1).DataPropertyName = "HOTEN_HS"
        luoi.Columns(2).DataPropertyName = "TEN_MON"
        luoi.Columns(3).DataPropertyName = "STT_HK"
        luoi.Columns(4).DataPropertyName = "MA_NK"
        luoi.Columns(5).DataPropertyName = "TONGDIEM"
        luoi.Columns(0).HeaderText = "Mã Học Sinh"
        luoi.Columns(1).HeaderText = "Tên Học Sinh"
        luoi.Columns(2).HeaderText = "Môn Học"
        luoi.Columns(3).HeaderText = "Học Kỳ"
        luoi.Columns(4).HeaderText = "Niên Khóa"
        luoi.Columns(5).HeaderText = "Điểm"


        luoi.Columns(5).DefaultCellStyle.Format = "N2"
    End Sub
    Private Sub tim_kiem()
        If Trim(hocsinh.Text) = "" Then
            MsgBox("Xin Nhập Mã Học Sinh theo đúng mẫu!")
            hocsinh.Focus()
        ElseIf Len(Trim(hocsinh.Text)) > 7 Or Len(Trim(hocsinh.Text)) < 7 Then
            MsgBox("Bạn phải nhập đúng mã học sinh!")
            hocsinh.Clear()
            hocsinh.Focus()

        ElseIf Trim(hocky.Text) = "" Then
            MsgBox("Xin chọn học kỳ!")
            hocky.Focus()

        ElseIf Trim(nienkhoa.Text) = "" Then
            MsgBox("Xin niên khóa!")
            nienkhoa.Focus()
        End If

        If Trim(hocsinh.Text) <> "" And Trim(hocky.Text) <> "" And Trim(nienkhoa.Text) <> "" Then
            Dim sql As String = "select MA_HS, HOTEN_HS,TEN_MON, STT_HK, MA_NK, TONGDIEM from DIEM_TB_MONHOC where MA_HS = '" & Trim(hocsinh.Text) & "' and STT_HK = '" & Trim(hocky.Text) & "' and MA_NK = '" & Trim(nienkhoa.Text) & "'"
            Dim da As New OleDbDataAdapter(sql, kn)
            Dim dt As New DataTable
            da.Fill(dt)
            luoi.DataSource = dt
            danh_sach = Me.BindingContext(dt)
        End If
    End Sub
    Private Sub load_hocky()
        Dim sql As String = "select * from HOC_KY"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        hocky.DataSource = dt
        hocky.DisplayMember = "STT_HK"
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tim_kiem()

    End Sub

End Class