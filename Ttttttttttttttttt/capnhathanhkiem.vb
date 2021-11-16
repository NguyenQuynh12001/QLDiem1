Imports System.Data.OleDb
Public Class capnhathanhkiem
    Dim kn As New OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Dim da As New OleDbDataAdapter, dt As New DataTable, bs As New BindingSource, cb As OleDbCommandBuilder
    Private Sub capnhathanhkiem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
        load_khoi()
        load_lop()
        nienkhoa_load()
    End Sub
    Private Sub nienkhoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nienkhoa.SelectedIndexChanged
        Dim sql As String = "select DISTINCT hs.MA_HS, hs.HOTEN_HS, hk.MA_NK, hk.HANHKIEM FROM LOP as l,KHOI as k,NIEN_KHOA as nk, THUOC as t, HOC as h, HOC_SINH as hs, HANH_KIEM as hk Where t.MA_LOP=l.MA_LOP and t.MA_KHOI=k.MA_KHOI and t.MA_NK=nk.MA_NK and h.MA_HS=hs.MA_HS and t.MA_KHOI=h.MA_KHOI and t.MA_LOP=h.MA_LOP and t.MA_NK=h.MA_NK and hs.MA_HS= hk.MA_HS and h.MA_KHOI = '" & Trim(khoi.Text) & "' and h.MA_LOP = '" & Trim(lop.Text) & "' and h.MA_NK = '" & Trim(nienkhoa.Text) & "'"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        luoi.DataSource = dt
        danh_sach = Me.BindingContext(dt)

        luoi.Columns(0).DataPropertyName = "MA_HS"
        luoi.Columns(1).DataPropertyName = "HOTEN_HS"
        luoi.Columns(2).DataPropertyName = "MA_NK"
        luoi.Columns(3).DataPropertyName = "HANHKIEM"

        luoi.Columns(0).HeaderText = "Mã HS"
        luoi.Columns(1).HeaderText = "Họ Tên Học Sinh"
        luoi.Columns(2).HeaderText = "NIên Khóa"
        luoi.Columns(3).HeaderText = "Hạnh Kiểm"

        luoi.Enabled = False

        luoi.Columns(0).ReadOnly = True
        luoi.Columns(1).ReadOnly = True
        luoi.Columns(2).ReadOnly = True
    End Sub
    Private Sub load_lop()
        Dim sql As String = "select * from LOP"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        lop.DataSource = dt
        lop.DisplayMember = "MA_LOP"
        lop.ValueMember = "LOP.MA_LOP"
        lop.SelectedValue = -1
    End Sub
    Private Sub load_khoi()
        Dim sql As String = "select * from KHOI"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        khoi.DataSource = dt
        khoi.DisplayMember = "KHOI"
        khoi.ValueMember = "MA_KHOI"
        khoi.SelectedValue = -1
    End Sub
    Private Sub nienkhoa_load()
        Dim sql As String = "select * From NIEN_KHOA"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        nienkhoa.DataSource = dt
        nienkhoa.DisplayMember = "MA_NK"
        nienkhoa.ValueMember = "NIEN_KHOA.MA_NK"
        nienkhoa.SelectedValue = -1
    End Sub
    Sub ds_hanhkiem()
        Dim sql As String = "select DISTINCT hs.MA_HS, hs.HOTEN_HS, hk.MA_NK, hk.HANHKIEM FROM LOP as l,KHOI as k,NIEN_KHOA as nk, THUOC as t, HOC as h, HOC_SINH as hs, HANH_KIEM as hk Where t.MA_LOP=l.MA_LOP and t.MA_KHOI=k.MA_KHOI and t.MA_NK=nk.MA_NK and h.MA_HS=hs.MA_HS and t.MA_KHOI=h.MA_KHOI and t.MA_LOP=h.MA_LOP and t.MA_NK=h.MA_NK and hs.MA_HS= hk.MA_HS and h.MA_KHOI = '" & Trim(khoi.Text) & "' and h.MA_LOP = '" & Trim(lop.Text) & "' and h.MA_NK = '" & Trim(nienkhoa.Text) & "'"
        dt = New DataTable
        da = New OleDbDataAdapter(sql, kn)
        da.Fill(dt)
        luoi.AutoGenerateColumns = False
        luoi.DataSource = dt
        dt.Dispose()
        da.Dispose()
    End Sub
    Private Sub sua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sua.Click
        ds_hanhkiem()
        If khoi.Text = "" Then
            MsgBox("Xin chọn khối!")
        ElseIf lop.Text = "" Then
            MsgBox("Xin chọn lớp!")
        ElseIf nienkhoa.Text = "" Then
            MsgBox("Xin chọn Niên Khóa!")
        Else
            luoi.Enabled = True
            luu.Enabled = True
            luoi.AllowUserToAddRows = False
            luoi.AllowUserToDeleteRows = False
        End If
    End Sub
    Private Sub luu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luu.Click
        Dim sql As String = "select * from HANH_KIEM"
        da = New OleDbDataAdapter(sql, kn)
        da.Fill(dt)
        cb = New OleDbCommandBuilder(da)
        da.Update(dt)
        dt.AcceptChanges()
        dt.Clear()
        dt.Dispose()
        da.Dispose()
        ds_hanhkiem()
        luoi.Enabled = False
    End Sub

End Class