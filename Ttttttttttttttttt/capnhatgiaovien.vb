Imports System.Data.OleDb
Public Class capnhatgiaovien
    Dim kn As New OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Private Sub capnhatgiaovien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
        load_danhsach()
        danh_sach_PositionChanged(sender, e)
        luu.Enabled = False
        huy.Enabled = False
        luoigv.DefaultCellStyle.SelectionBackColor = Color.Yellow
        luoigv.DefaultCellStyle.SelectionForeColor = Color.Black
        luoigv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub danh_sach_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_ds_giao_vien()
    End Sub
    Private Sub load_danhsach()
        Dim sql As String = "select * from GIAO_VIEN"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        luoigv.DataSource = dt
        danh_sach = Me.BindingContext(dt)
        luoigv.Columns("MA_GV").HeaderText = "Mã GV"
        luoigv.Columns("HOTEN_GV").HeaderText = "Tên Giáo Viên"
        luoigv.Columns("DIACHI_GV").HeaderText = "Địa Chỉ"
        luoigv.Columns("DIENTHOAI_GV").HeaderText = "Điện Thoại GV"

        luoigv.Columns("HOTEN_GV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        luoigv.Columns("DIACHI_GV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        luoigv.Columns(0).Width = 80
        luoigv.Columns(3).Width = 130
        luu.Enabled = False
        huy.Enabled = False
        luoigv.ReadOnly = True
    End Sub
    Private Sub xuat_ds_giao_vien()
        tbma_gv.Text = danh_sach.Current("MA_GV")
        tbten_gv.Text = danh_sach.Current("HOTEN_GV")
        tbdiachi_gv.Text = danh_sach.Current("DIACHI_GV")
        tbdienthoai_gv.Text = danh_sach.Current("DIENTHOAI_GV")
    End Sub
    Sub them_giaovien()
        If Trim(tbten_gv.Text) = "" Then
            MsgBox("Nhập tên giáo viên !")
            tbten_gv.Focus()
        ElseIf Trim(tbdiachi_gv.Text) = "" Then
            MsgBox("Nhập địa chỉ giáo viên !")
            tbdiachi_gv.Focus()
        ElseIf Trim(tbdienthoai_gv.Text) <> "" And Len(Trim(tbdienthoai_gv.Text)) <> 10 Then
            MsgBox("Số điện thoại không hợp lệ!")
            tbdienthoai_gv.Focus()
        Else
            Dim Sql As String = "Insert into GIAO_VIEN  values('" & tbma_gv.Text & "','" & tbten_gv.Text & "','" & tbdiachi_gv.Text & "','" & Trim(tbdienthoai_gv.Text) & "')"
            Dim com As New OleDbCommand(Sql, kn)
            com.ExecuteNonQuery()
            MsgBox("Thêm thành công!", MsgBoxStyle.OkOnly)
            load_danhsach()
            xuat_ds_giao_vien()
            them.Enabled = True
            sua.Enabled = True
            xoa.Enabled = True
            luu.Enabled = False
            huy.Enabled = False
            luoigv.Enabled = True
        End If
    End Sub
    Public Sub MaGV_Auto()
        Dim com As New OleDbCommand
        com.Connection = kn
        com.CommandText = "select max(right(Ma_GV,3)) from GIAO_VIEN"
        tbma_gv.Text = "GV" & CInt(com.ExecuteScalar + 1)
        If com.ExecuteScalar < 9 Then
            tbma_gv.Text = "GV00" & CInt(com.ExecuteScalar + 1)
        ElseIf com.ExecuteScalar < 99 Then
            tbma_gv.Text = "GV0" & CInt(com.ExecuteScalar + 1)
        ElseIf com.ExecuteScalar < 999 Then
            tbma_gv.Text = "GV" & CInt(com.ExecuteScalar + 1)
        Else : MessageBox.Show("Mã giáo viên không hợp lệ!")
        End If
    End Sub
    Sub sua_giaovien()
        If Trim(tbten_gv.Text) = "" Then
            MsgBox("Nhập tên giáo viên !")
            tbten_gv.Focus()
        ElseIf Trim(tbdiachi_gv.Text) = "" Then
            MsgBox("Nhập địa chỉ giáo viên !")
            tbdiachi_gv.Focus()
        ElseIf Trim(tbdienthoai_gv.Text) <> "" And Len(Trim(tbdienthoai_gv.Text)) <> 10 Then
            MsgBox("Số điện thoại không hợp lệ !")
            tbdienthoai_gv.Focus()
        Else
            Dim sql As String
            sql = "Update GIAO_VIEN set MA_GV='" & Trim(tbma_gv.Text) & "', HOTEN_GV = '" & Trim(tbten_gv.Text) & "',DIACHI_GV='" & Trim(tbdiachi_gv.Text) & "',DIENTHOAI_GV='" & Trim(tbdienthoai_gv.Text) & "' where MA_GV =  '" & Trim(tbma_gv.Text) & "'"
            Dim com As New OleDbCommand(sql, kn)
            com.ExecuteNonQuery()
            MsgBox("Sửa thành công!", MsgBoxStyle.OkOnly)
            load_danhsach()
            xuat_ds_giao_vien()
            them.Enabled = True
            sua.Enabled = True
            xoa.Enabled = True
            luoigv.Enabled = True
        End If
    End Sub
    Sub xoa_giaovien()
        Dim sql As String
        sql = " delete * from GIAO_VIEN where MA_GV = '" & tbma_gv.Text & "'"
        Dim com As New OleDbCommand(sql, kn)
        com.ExecuteNonQuery()
        MsgBox("xóa thành công!", MsgBoxStyle.OkOnly)
        load_danhsach()
        xuat_ds_giao_vien()
        them.Enabled = True
        sua.Enabled = True
        luoigv.Enabled = True
    End Sub
    Dim j As Integer
    Private Sub btthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles them.Click
        them.Enabled = False
        sua.Enabled = False
        xoa.Enabled = False
        luu.Enabled = True
        huy.Enabled = True

        tbten_gv.Text = ""
        tbdienthoai_gv.Text = ""
        tbdiachi_gv.Text = ""
        tbma_gv.ReadOnly = True
        tbten_gv.Focus()
        MaGV_Auto()
        luoigv.Enabled = False
        j = 1
    End Sub
    Private Sub btsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sua.Click
        them.Enabled = False
        sua.Enabled = False
        xoa.Enabled = True
        luu.Enabled = True
        huy.Enabled = True
        tbma_gv.ReadOnly = True
        tbten_gv.Focus()
        luoigv.Enabled = False
        j = 2
    End Sub
    Dim i As Integer
    Private Sub btxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xoa.Click
        i = MsgBox("Bạn có muốn xóa mẫu tin này?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Lưu ý")
        If i = vbOK Then
            xoa_giaovien()
        End If
    End Sub

    Private Sub btluu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luu.Click
        If j = 1 Then
            them_giaovien()
        Else
            sua_giaovien()
        End If
    End Sub
    Private Sub bthuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles huy.Click
        them.Enabled = True
        sua.Enabled = True
        xoa.Enabled = True
        luu.Enabled = False
        huy.Enabled = False
        load_danhsach()
        xuat_ds_giao_vien()

        luoigv.Enabled = True

    End Sub

End Class
