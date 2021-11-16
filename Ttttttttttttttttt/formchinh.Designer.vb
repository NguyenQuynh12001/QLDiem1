<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromchinh
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fromchinh))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mn_hethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.dangnhap = New System.Windows.Forms.ToolStripMenuItem()
        Me.dangxuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.thoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_capnhat = New System.Windows.Forms.ToolStripMenuItem()
        Me.cnhocsinh = New System.Windows.Forms.ToolStripMenuItem()
        Me.cnnienkhoa = New System.Windows.Forms.ToolStripMenuItem()
        Me.cnlop = New System.Windows.Forms.ToolStripMenuItem()
        Me.cngiaovien = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_quanly = New System.Windows.Forms.ToolStripMenuItem()
        Me.xeplop = New System.Windows.Forms.ToolStripMenuItem()
        Me.qldaylop = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_kq = New System.Windows.Forms.ToolStripMenuItem()
        Me.cndiemthi = New System.Windows.Forms.ToolStripMenuItem()
        Me.cnhanhkiem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_baocao = New System.Windows.Forms.ToolStripMenuItem()
        Me.indsdiemtbmon = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mn_hethong, Me.mn_capnhat, Me.mn_quanly, Me.mn_kq, Me.mn_baocao})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(743, 32)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mn_hethong
        '
        Me.mn_hethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dangnhap, Me.dangxuat, Me.thoat})
        Me.mn_hethong.ForeColor = System.Drawing.Color.Blue
        Me.mn_hethong.Name = "mn_hethong"
        Me.mn_hethong.Size = New System.Drawing.Size(88, 24)
        Me.mn_hethong.Text = "Hệ Thống"
        '
        'dangnhap
        '
        Me.dangnhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dangnhap.Image = CType(resources.GetObject("dangnhap.Image"), System.Drawing.Image)
        Me.dangnhap.Name = "dangnhap"
        Me.dangnhap.Size = New System.Drawing.Size(168, 26)
        Me.dangnhap.Text = "Đăng Nhập"
        '
        'dangxuat
        '
        Me.dangxuat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dangxuat.Image = CType(resources.GetObject("dangxuat.Image"), System.Drawing.Image)
        Me.dangxuat.Name = "dangxuat"
        Me.dangxuat.Size = New System.Drawing.Size(168, 26)
        Me.dangxuat.Text = "Đăng Xuất"
        '
        'thoat
        '
        Me.thoat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.thoat.Image = CType(resources.GetObject("thoat.Image"), System.Drawing.Image)
        Me.thoat.Name = "thoat"
        Me.thoat.Size = New System.Drawing.Size(168, 26)
        Me.thoat.Text = "Thoát"
        '
        'mn_capnhat
        '
        Me.mn_capnhat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cnhocsinh, Me.cnnienkhoa, Me.cnlop, Me.cngiaovien})
        Me.mn_capnhat.ForeColor = System.Drawing.Color.Blue
        Me.mn_capnhat.Name = "mn_capnhat"
        Me.mn_capnhat.Size = New System.Drawing.Size(159, 24)
        Me.mn_capnhat.Text = "Cập Nhập Thông Tin"
        '
        'cnhocsinh
        '
        Me.cnhocsinh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cnhocsinh.Image = CType(resources.GetObject("cnhocsinh.Image"), System.Drawing.Image)
        Me.cnhocsinh.Name = "cnhocsinh"
        Me.cnhocsinh.Size = New System.Drawing.Size(227, 26)
        Me.cnhocsinh.Text = "Cập Nhật Học Sinh"
        '
        'cnnienkhoa
        '
        Me.cnnienkhoa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cnnienkhoa.Image = CType(resources.GetObject("cnnienkhoa.Image"), System.Drawing.Image)
        Me.cnnienkhoa.Name = "cnnienkhoa"
        Me.cnnienkhoa.Size = New System.Drawing.Size(227, 26)
        Me.cnnienkhoa.Text = "Cập Nhật Niên Khóa"
        '
        'cnlop
        '
        Me.cnlop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cnlop.Image = CType(resources.GetObject("cnlop.Image"), System.Drawing.Image)
        Me.cnlop.Name = "cnlop"
        Me.cnlop.Size = New System.Drawing.Size(227, 26)
        Me.cnlop.Text = "Cập Nhật Lớp Học"
        '
        'cngiaovien
        '
        Me.cngiaovien.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cngiaovien.Image = CType(resources.GetObject("cngiaovien.Image"), System.Drawing.Image)
        Me.cngiaovien.Name = "cngiaovien"
        Me.cngiaovien.Size = New System.Drawing.Size(227, 26)
        Me.cngiaovien.Text = "Cập Nhật Giáo Viên"
        '
        'mn_quanly
        '
        Me.mn_quanly.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.xeplop, Me.qldaylop})
        Me.mn_quanly.ForeColor = System.Drawing.Color.Blue
        Me.mn_quanly.Name = "mn_quanly"
        Me.mn_quanly.Size = New System.Drawing.Size(79, 24)
        Me.mn_quanly.Text = "Quản Lý "
        '
        'xeplop
        '
        Me.xeplop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xeplop.Image = CType(resources.GetObject("xeplop.Image"), System.Drawing.Image)
        Me.xeplop.Name = "xeplop"
        Me.xeplop.Size = New System.Drawing.Size(306, 26)
        Me.xeplop.Text = "Xếp Lớp Cho Học Sinh"
        '
        'qldaylop
        '
        Me.qldaylop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.qldaylop.Image = CType(resources.GetObject("qldaylop.Image"), System.Drawing.Image)
        Me.qldaylop.Name = "qldaylop"
        Me.qldaylop.Size = New System.Drawing.Size(306, 26)
        Me.qldaylop.Text = "Xếp Giáo Viên Dạy Học Cho Lớp"
        '
        'mn_kq
        '
        Me.mn_kq.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cndiemthi, Me.cnhanhkiem})
        Me.mn_kq.ForeColor = System.Drawing.Color.Blue
        Me.mn_kq.Name = "mn_kq"
        Me.mn_kq.Size = New System.Drawing.Size(192, 24)
        Me.mn_kq.Text = "Cập Nhật Điểm - Kết Quả"
        '
        'cndiemthi
        '
        Me.cndiemthi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cndiemthi.Image = CType(resources.GetObject("cndiemthi.Image"), System.Drawing.Image)
        Me.cndiemthi.Name = "cndiemthi"
        Me.cndiemthi.Size = New System.Drawing.Size(231, 26)
        Me.cndiemthi.Text = "Cập Nhật Điểm Thi"
        '
        'cnhanhkiem
        '
        Me.cnhanhkiem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cnhanhkiem.Image = CType(resources.GetObject("cnhanhkiem.Image"), System.Drawing.Image)
        Me.cnhanhkiem.Name = "cnhanhkiem"
        Me.cnhanhkiem.Size = New System.Drawing.Size(231, 26)
        Me.cnhanhkiem.Text = "Cập Nhật Hạnh Kiểm"
        '
        'mn_baocao
        '
        Me.mn_baocao.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.indsdiemtbmon})
        Me.mn_baocao.ForeColor = System.Drawing.Color.Blue
        Me.mn_baocao.Name = "mn_baocao"
        Me.mn_baocao.Size = New System.Drawing.Size(84, 24)
        Me.mn_baocao.Text = "Tìm kiếm"
        '
        'indsdiemtbmon
        '
        Me.indsdiemtbmon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.indsdiemtbmon.Image = CType(resources.GetObject("indsdiemtbmon.Image"), System.Drawing.Image)
        Me.indsdiemtbmon.Name = "indsdiemtbmon"
        Me.indsdiemtbmon.Size = New System.Drawing.Size(257, 26)
        Me.indsdiemtbmon.Text = "Danh Sách Điểm TB Môn"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(64, 129)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(599, 327)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(80, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(569, 51)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "QUẢN LÍ ĐIỂM HỌC SINH THPT"
        '
        'fromchinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(743, 502)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fromchinh"
        Me.Text = "formchinh"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mn_hethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dangnhap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dangxuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents thoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn_capnhat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cnhocsinh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cnlop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cngiaovien As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn_kq As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cndiemthi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cnhanhkiem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cnnienkhoa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn_baocao As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents indsdiemtbmon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn_quanly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xeplop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents qldaylop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
