Imports System.Data.OleDb
Public Class capnhaphocsinh
    Dim kn As New OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Dim dsHocSinh As New DataView
    Private Sub capnhaphocsinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
        load_danhsach_hocsinh()
        danh_sach_PositionChanged(sender, e)
        luu.Enabled = False
        huy.Enabled = False
        luoi_hs.DefaultCellStyle.SelectionBackColor = Color.Yellow
        luoi_hs.DefaultCellStyle.SelectionForeColor = Color.Black
        luoi_hs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub load_danhsach_hocsinh()
        Dim sql As String = "select * from HOC_SINH"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        luoi_hs.DataSource = dt
        danh_sach = Me.BindingContext(dt)
        luoi_hs.Columns("MA_HS").HeaderText = "Mã HS"
        luoi_hs.Columns("HOTEN_HS").HeaderText = "Tên Học Sinh"
        luoi_hs.Columns("NGAYSINH").HeaderText = "Ngày Sinh"
        luoi_hs.Columns("DIACHI_HS").HeaderText = "Địa Chỉ"
        luoi_hs.Columns("DANTOC").HeaderText = "Dân Tộc"
        luoi_hs.Columns("DIENTHOAI").HeaderText = "Điện Thoại"
        luoi_hs.Columns("DOITUONG").HeaderText = "Đối Tượng"
        
        luoi_hs.Columns("GIOITINH_HS").HeaderText = "Giới Tính"
    End Sub
    Private Sub xuat_hocsinh()
        ma_hs.Text = danh_sach.Current("MA_HS")
        ten_hs.Text = danh_sach.Current("HOTEN_HS")
        ngaysinh_hs.Text = danh_sach.Current("NGAYSINH")
        diachi_hs.Text = danh_sach.Current("DIACHI_HS")
        dienthoai.Text = danh_sach.Current("DIENTHOAI")
     
        dantoc.Text = danh_sach.Current("DANTOC")
        doituong.Text = danh_sach.Current("DOITUONG")
        cbnam.Checked = danh_sach.Current("GIOITINH_HS")
        cbnu.Checked = Not cbnam.Checked
    End Sub
    Private Sub danh_sach_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_hocsinh()
    End Sub

    Sub them_hocsinh()
        If Trim(ten_hs.Text) = "" Then
            MsgBox("Nhập tên học sinh !")
            ten_hs.Focus()
        ElseIf ngaysinh_hs.Text = "" Then
            MsgBox("Nhập năm sinh học sinh !")
            ngaysinh_hs.Focus()
        ElseIf (Year(Now()) - Year(CDate(ngaysinh_hs.Text)) < 15) Then
            MsgBox("Tuổi học sinh phải lớn hơn 15!", MsgBoxStyle.Exclamation, "Lưu ý")
            ngaysinh_hs.Focus()
        ElseIf Trim(diachi_hs.Text) = "" Then
            MsgBox("Nhập địa chỉ học sinh !")
            diachi_hs.Focus()
        ElseIf cbnam.Checked = True And cbnu.Checked = True Then
            MsgBox("Bạn không thể chọn 2 giới tính được!")
        ElseIf cbnam.Checked = False And cbnu.Checked = False Then
            MsgBox("Bạn không thể không chọn Giới Tính được!")
        ElseIf Trim(dienthoai.Text) <> "" And Len(Trim(dienthoai.Text)) <> 10 Then
            MsgBox("Số điện thoại phải là 10 số !")
            dienthoai.Focus()
        ElseIf Trim(dantoc.Text) = "" Then
            MsgBox("Nhập vào dân tộc !")
            dantoc.Focus()
        ElseIf Trim(doituong.Text) = "" Then
            MsgBox("Nhập vào đối tượng !")
            doituong.Focus()
        Else
            Dim Sql As String = "Insert into HOC_SINH values('" & ma_hs.Text & "','" & ten_hs.Text & "','" & ngaysinh_hs.Text & "','" & If(cbnam.Checked = True, -1, 0) & "','" & diachi_hs.Text & "','" & dantoc.Text & "','" & dienthoai.Text & "','" & doituong.Text & "')"
            Dim Com As New OleDbCommand(Sql, kn)
            Com.ExecuteNonQuery()
            MsgBox("Thêm thành công!", MsgBoxStyle.OkOnly)
            load_danhsach_hocsinh()
            xuat_hocsinh()

            them.Enabled = True
            sua.Enabled = True
            xoa.Enabled = True
            luu.Enabled = False
            huy.Enabled = False
            luoi_hs.Enabled = True

        End If
    End Sub
    Public Sub MaHS_Auto()
        Dim Com As New OleDbCommand
        Com.Connection = kn
        Com.CommandText = "select max(right(Ma_HS,5)) from HOC_SINH"
        ma_hs.Text = "HV" & CInt(Com.ExecuteScalar + 1)
        If Com.ExecuteScalar < 9 Then
            ma_hs.Text = "HV0000" & CInt(Com.ExecuteScalar + 1)
        ElseIf Com.ExecuteScalar < 99 Then
            ma_hs.Text = "HV000" & CInt(Com.ExecuteScalar + 1)
        ElseIf Com.ExecuteScalar < 999 Then
            ma_hs.Text = "HV00" & CInt(Com.ExecuteScalar + 1)
        ElseIf Com.ExecuteScalar < 9999 Then
            ma_hs.Text = "HV0" & CInt(Com.ExecuteScalar + 1)
        ElseIf Com.ExecuteScalar < 99999 Then
            ma_hs.Text = "HV" & CInt(Com.ExecuteScalar + 1)
        Else : MessageBox.Show("Mã học sinh không đúng!")
        End If
    End Sub
    Dim j As Integer
    Private Sub them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles them.Click
        them.Enabled = False
        sua.Enabled = False
        xoa.Enabled = False

        luu.Enabled = True
        huy.Enabled = True
        ten_hs.Text = ""
        ngaysinh_hs.Text = ""
        dienthoai.Text = ""
        diachi_hs.Text = ""
        dantoc.Text = ""
        doituong.Text = ""
        ma_hs.ReadOnly = True
        ten_hs.Focus()
        ngaysinh_hs.Enabled = True
        dienthoai.Enabled = True
        diachi_hs.Enabled = True
        ngaysinh_hs.Enabled = True
        cbnam.Enabled = True
        cbnu.Enabled = True
        dantoc.Enabled = True
        doituong.Enabled = True
        MaHS_Auto()
        luoi_hs.Enabled = False
        j = 1
    End Sub
    Sub sua_hocsinh()
        If Trim(ten_hs.Text) = "" Then
            MsgBox("Nhập tên của học sinh !")
            ten_hs.Focus()
        ElseIf ngaysinh_hs.Text = "" Then
            MsgBox("Nhập năm sinh của học sinh !")
            ngaysinh_hs.Focus()
        ElseIf (Year(Now()) - Year(CDate(ngaysinh_hs.Text)) < 14) Then
            MsgBox("Tuổi của học sinh phải lớn hơn 14 !", MsgBoxStyle.Exclamation, "Lưu ý")
            ngaysinh_hs.Focus()
        ElseIf cbnam.Checked = True And cbnu.Checked = True Then
            MsgBox("Bạn không thể chọn 2 giới tính được!")
        ElseIf cbnam.Checked = False And cbnu.Checked = False Then
            MsgBox("Bạn không thể không chọn Giới Tính được!")
        ElseIf Trim(diachi_hs.Text) = "" Then
            MsgBox("Nhập địa chỉ của học sinh !")
            diachi_hs.Focus()
        ElseIf Trim(dienthoai.Text) <> "" And Len(Trim(dienthoai.Text)) <> 10 Then
            MsgBox("Số điện thoại không hợp lệ !")
            dienthoai.Focus()
        ElseIf Trim(dantoc.Text) = "" Then
            MsgBox("Nhập dân tộc của học sinh !")
            dantoc.Focus()
        ElseIf Trim(doituong.Text) = "" Then
            MsgBox("Nhập diện đối tượng của học sinh !")
            doituong.Focus()
        Else
            Dim sql As String
            sql = "Update HOC_SINH set MA_HS='" & ma_hs.Text & "',HOTEN_HS = '" & ten_hs.Text & "',NGAYSINH = '" & ngaysinh_hs.Text & "', GIOITINH_HS = '" & If(cbnam.Checked = True, -1, 0) & "', DIACHI_HS='" & diachi_hs.Text & "',DIENTHOAI='" & Trim(dienthoai.Text) & "',DOITUONG='" & doituong.Text & "',DANTOC='" & dantoc.Text & "' where MA_HS =  '" & Trim(ma_hs.Text) & "'"
            Dim com As New OleDbCommand(sql, kn)
            com.ExecuteNonQuery()
            MsgBox("Sửa thành công!", MsgBoxStyle.OkOnly)
            load_danhsach_hocsinh()
            xuat_hocsinh()
            them.Enabled = True
            sua.Enabled = True
            xoa.Enabled = True
            luu.Enabled = False
            huy.Enabled = False
            luoi_hs.Enabled = True
        End If
    End Sub
    Private Sub sua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sua.Click
        them.Enabled = False
        sua.Enabled = False
        xoa.Enabled = True
        luu.Enabled = True
        huy.Enabled = True
        ten_hs.Enabled = True
        ma_hs.ReadOnly = True
        ten_hs.ReadOnly = False
        ngaysinh_hs.Enabled = True
        cbnam.Enabled = True
        cbnu.Enabled = True
        dienthoai.ReadOnly = False
        diachi_hs.ReadOnly = False
        dantoc.ReadOnly = False
        doituong.ReadOnly = False
        luoi_hs.Enabled = False
        j = 2
    End Sub
    Sub xoa_hoc_vien()
        Dim sql As String
        sql = " delete * from HOC_SINH where MA_HS = '" & ma_hs.Text & "'"
        Dim com As New OleDbCommand(sql, kn)
        com.ExecuteNonQuery()
        MsgBox("xóa thành công!", MsgBoxStyle.OkOnly)
        load_danhsach_hocsinh()
        xuat_hocsinh()
        them.Enabled = True
        sua.Enabled = True
        xoa.Enabled = True
        luu.Enabled = False
        huy.Enabled = False
        luoi_hs.Enabled = True
    End Sub
    Dim i As Integer
    Private Sub xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xoa.Click
        i = MsgBox("Bạn có muốn xóa mẫu tin này?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Lưu ý")
        If i = vbOK Then
            xoa_hoc_vien()
        End If
    End Sub
    Private Sub luu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luu.Click
        If j = 1 Then
            them_hocsinh()
        Else
            sua_hocsinh()
        End If
    End Sub
    Private Sub huy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles huy.Click
        them.Enabled = True
        sua.Enabled = True
        xoa.Enabled = True
        luu.Enabled = False
        huy.Enabled = False
        load_danhsach_hocsinh()
        xuat_hocsinh()
        luoi_hs.Enabled = True
    End Sub
  

End Class
