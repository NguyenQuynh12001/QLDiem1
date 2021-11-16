Imports System.Data.OleDb
Public Class capnhatlop
    Dim kn As New OleDbConnection
    Private WithEvents danh_sach As BindingManagerBase
    Dim dsLop As New DataView
    Private Sub capnhatlop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ketnoi(kn)
        load_danhsach_lop()
        danh_sach_PositionChanged(sender, e)
        luu.Enabled = False
        huy.Enabled = False
        luoi_lop.DefaultCellStyle.SelectionBackColor = Color.Yellow
        luoi_lop.DefaultCellStyle.SelectionForeColor = Color.Black
        luoi_lop.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub danh_sach_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat_ds_lop()
    End Sub
    Private Sub load_danhsach_lop()
        Dim sql As String = "select * from LOP"
        Dim da As New OleDbDataAdapter(sql, kn)
        Dim dt As New DataTable
        da.Fill(dt)
        luoi_lop.DataSource = dt
        danh_sach = Me.BindingContext(dt)
        luoi_lop.Columns("MA_LOP").HeaderText = "Mã Lớp"
        luoi_lop.Columns("TEN_LOP").HeaderText = "Tên Lớp"
        luoi_lop.Columns("DIEN_GIAI").HeaderText = "Diễn Giải"
        luu.Enabled = False
        huy.Enabled = False
    End Sub
    Private Sub xuat_ds_lop()
        ma_lop.Text = danh_sach.Current("MA_LOP")
        ten_lop.Text = danh_sach.Current("TEN_LOP")
        diengiai.Text = danh_sach.Current("DIEN_GIAI")
    End Sub
    Function kiemtra(ByVal ma As String)
        Dim Sql As String = "select MA_LOP from LOP where MA_LOP='" & ma & "'"
        Dim Comm As New OleDbCommand(Sql, kn)
        Dim reader As OleDbDataReader = Comm.ExecuteReader
        If reader.Read Then
            Return True
        End If
        Return False
    End Function
    Sub them_lop()
        If Trim(ma_lop.Text) = "" Then
            MsgBox("Xin nhập vào niên khóa!")
            ma_lop.Focus()
        ElseIf Len(ma_lop.Text) > 1 Then
            MsgBox("Mã Lớp chỉ được nhập một ký tự!")
            ma_lop.Clear()
            ma_lop.Focus()
        ElseIf kiemtra(ma_lop.Text) = True Then
            MsgBox(" Mã niên khóa này đã có!")
            ma_lop.Clear()
            ma_lop.Focus()
        ElseIf ten_lop.Text = "" Then
            MsgBox(" Xin nhập tên lớp vào")
            ten_lop.Focus()
        ElseIf diengiai.Text = "" Then
            MsgBox(" Xin nhập diễn giải vào")
            diengiai.Focus()
        Else
            Dim Sql As String = "Insert into LOP values('" & ma_lop.Text & "', '" & ten_lop.Text & "', '" & diengiai.Text & "')"
            Dim Com As New OleDbCommand(Sql, kn)
            Com.ExecuteNonQuery()
            MsgBox("Thêm thành công!", MsgBoxStyle.OkOnly)
            load_danhsach_lop()
            xuat_ds_lop()
            them.Enabled = True
            xoa.Enabled = True
            sua.Enabled = True
            luu.Enabled = False
            huy.Enabled = False
            luoi_lop.Enabled = True

        End If
    End Sub
    Dim j As Integer
    Private Sub them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles them.Click
        them.Enabled = False
        xoa.Enabled = False
        sua.Enabled = False
        luu.Enabled = True
        huy.Enabled = True
        ma_lop.Text = ""
        ten_lop.Text = ""
        diengiai.Text = ""
        ma_lop.Focus()

        j = 1
    End Sub
    Sub xoa_lop()
        Dim sql As String
        sql = "delete * from LOP where MA_LOP = '" & ma_lop.Text & "'"
        Dim com As New OleDbCommand(sql, kn)
        com.ExecuteNonQuery()
        MsgBox("xóa thành công!", MsgBoxStyle.OkOnly)
        load_danhsach_lop()
        xuat_ds_lop()
        them.Enabled = True
        xoa.Enabled = True
        luu.Enabled = False
        huy.Enabled = False
        luoi_lop.Enabled = True

    End Sub
    Dim i As Integer
    Private Sub xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xoa.Click
        i = MsgBox("Bạn có muốn xóa mẫu tin này?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Lưu ý")
        If i = vbOK Then
            xoa_lop()
        End If
    End Sub
    Sub sua_lop()
        If Trim(ten_lop.Text) = "" Then
            MsgBox("Nhập tên của lớp !")
            ten_lop.Focus()
        Else
            Dim sql As String
            sql = "Update LOP set TEN_LOP = '" & ten_lop.Text & "', DIEN_GIAI = '" & diengiai.Text & "' where MA_LOP =  '" & ma_lop.Text & "'"
            Dim com As New OleDbCommand(sql, kn)
            com.ExecuteNonQuery()
            MsgBox("Sửa thành công!", MsgBoxStyle.OkOnly)
            load_danhsach_lop()
            xuat_ds_lop()
            them.Enabled = True
            sua.Enabled = True
            xoa.Enabled = True
            luu.Enabled = False
            huy.Enabled = False
            luoi_lop.Enabled = True

        End If
    End Sub
    Private Sub sua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sua.Click
        them.Enabled = False
        sua.Enabled = False
        xoa.Enabled = False
        luu.Enabled = True
        huy.Enabled = True
        ten_lop.Enabled = True
        diengiai.Enabled = True
        ma_lop.ReadOnly = True
        ten_lop.ReadOnly = False
        diengiai.ReadOnly = False
        luoi_lop.Enabled = False

        j = 2
    End Sub
    Private Sub luu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luu.Click
        If j = 1 Then
            them_lop()
        Else
            sua_lop()
        End If
    End Sub
    Private Sub huy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles huy.Click
        them.Enabled = True
        sua.Enabled = True
        xoa.Enabled = True
        luu.Enabled = False
        huy.Enabled = False
        load_danhsach_lop()
        xuat_ds_lop()
        luoi_lop.Enabled = False
        ma_lop.ReadOnly = True
        ten_lop.ReadOnly = True
        diengiai.ReadOnly = True

    End Sub
  
End Class