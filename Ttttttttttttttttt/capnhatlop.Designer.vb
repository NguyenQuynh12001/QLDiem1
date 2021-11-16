<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capnhatlop
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.huy = New System.Windows.Forms.Button()
        Me.luu = New System.Windows.Forms.Button()
        Me.xoa = New System.Windows.Forms.Button()
        Me.sua = New System.Windows.Forms.Button()
        Me.them = New System.Windows.Forms.Button()
        Me.ten_lop = New System.Windows.Forms.TextBox()
        Me.ma_lop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.luoi_lop = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.diengiai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.luoi_lop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'huy
        '
        Me.huy.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.huy.ForeColor = System.Drawing.Color.Blue
        Me.huy.Location = New System.Drawing.Point(419, 28)
        Me.huy.Name = "huy"
        Me.huy.Size = New System.Drawing.Size(95, 28)
        Me.huy.TabIndex = 14
        Me.huy.Text = "Hủy"
        Me.huy.UseVisualStyleBackColor = True
        '
        'luu
        '
        Me.luu.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luu.ForeColor = System.Drawing.Color.Blue
        Me.luu.Location = New System.Drawing.Point(322, 28)
        Me.luu.Name = "luu"
        Me.luu.Size = New System.Drawing.Size(95, 28)
        Me.luu.TabIndex = 13
        Me.luu.Text = "Lưu"
        Me.luu.UseVisualStyleBackColor = True
        '
        'xoa
        '
        Me.xoa.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xoa.ForeColor = System.Drawing.Color.Blue
        Me.xoa.Location = New System.Drawing.Point(224, 28)
        Me.xoa.Name = "xoa"
        Me.xoa.Size = New System.Drawing.Size(95, 28)
        Me.xoa.TabIndex = 12
        Me.xoa.Text = "Xóa"
        Me.xoa.UseVisualStyleBackColor = True
        '
        'sua
        '
        Me.sua.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sua.ForeColor = System.Drawing.Color.Blue
        Me.sua.Location = New System.Drawing.Point(127, 28)
        Me.sua.Name = "sua"
        Me.sua.Size = New System.Drawing.Size(95, 28)
        Me.sua.TabIndex = 11
        Me.sua.Text = "Sửa"
        Me.sua.UseVisualStyleBackColor = True
        '
        'them
        '
        Me.them.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.them.ForeColor = System.Drawing.Color.Blue
        Me.them.Location = New System.Drawing.Point(26, 28)
        Me.them.Name = "them"
        Me.them.Size = New System.Drawing.Size(95, 28)
        Me.them.TabIndex = 10
        Me.them.Text = "Thêm"
        Me.them.UseVisualStyleBackColor = True
        '
        'ten_lop
        '
        Me.ten_lop.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ten_lop.Location = New System.Drawing.Point(322, 42)
        Me.ten_lop.Name = "ten_lop"
        Me.ten_lop.Size = New System.Drawing.Size(169, 27)
        Me.ten_lop.TabIndex = 4
        '
        'ma_lop
        '
        Me.ma_lop.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ma_lop.Location = New System.Drawing.Point(123, 42)
        Me.ma_lop.Name = "ma_lop"
        Me.ma_lop.Size = New System.Drawing.Size(119, 27)
        Me.ma_lop.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Lớp:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Lớp:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.huy)
        Me.GroupBox2.Controls.Add(Me.luu)
        Me.GroupBox2.Controls.Add(Me.xoa)
        Me.GroupBox2.Controls.Add(Me.sua)
        Me.GroupBox2.Controls.Add(Me.them)
        Me.GroupBox2.Location = New System.Drawing.Point(65, 434)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 73)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'luoi_lop
        '
        Me.luoi_lop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.luoi_lop.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.luoi_lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.luoi_lop.DefaultCellStyle = DataGridViewCellStyle2
        Me.luoi_lop.Location = New System.Drawing.Point(65, 258)
        Me.luoi_lop.Name = "luoi_lop"
        Me.luoi_lop.ReadOnly = True
        Me.luoi_lop.Size = New System.Drawing.Size(547, 170)
        Me.luoi_lop.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, -45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 40)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "CẬP NHẬT LỚP HỌC"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.diengiai)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ten_lop)
        Me.GroupBox1.Controls.Add(Me.ma_lop)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(65, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 149)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin lớp học"
        '
        'diengiai
        '
        Me.diengiai.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diengiai.Location = New System.Drawing.Point(123, 90)
        Me.diengiai.Name = "diengiai"
        Me.diengiai.Size = New System.Drawing.Size(368, 27)
        Me.diengiai.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Diễn Giải:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Candara", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(229, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 40)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "CẬP NHẬT LỚP"
        '
        'capnhatlop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(682, 519)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.luoi_lop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "capnhatlop"
        Me.Text = "capnhatlop"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.luoi_lop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents huy As System.Windows.Forms.Button
    Friend WithEvents luu As System.Windows.Forms.Button
    Friend WithEvents xoa As System.Windows.Forms.Button
    Friend WithEvents sua As System.Windows.Forms.Button
    Friend WithEvents them As System.Windows.Forms.Button
    Friend WithEvents ten_lop As System.Windows.Forms.TextBox
    Friend WithEvents ma_lop As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents luoi_lop As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents diengiai As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
