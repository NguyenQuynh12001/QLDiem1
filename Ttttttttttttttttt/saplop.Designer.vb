<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saplop
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
        Me.luu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tenhs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mahs = New System.Windows.Forms.ComboBox()
        Me.nienkhoa = New System.Windows.Forms.ComboBox()
        Me.makhoi = New System.Windows.Forms.ComboBox()
        Me.malop = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.huy = New System.Windows.Forms.Button()
        Me.xoa = New System.Windows.Forms.Button()
        Me.them = New System.Windows.Forms.Button()
        Me.luoixl = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.luoixl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'luu
        '
        Me.luu.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luu.Location = New System.Drawing.Point(225, 33)
        Me.luu.Name = "luu"
        Me.luu.Size = New System.Drawing.Size(95, 28)
        Me.luu.TabIndex = 21
        Me.luu.Text = "Lưu"
        Me.luu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tenhs)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mahs)
        Me.GroupBox1.Controls.Add(Me.nienkhoa)
        Me.GroupBox1.Controls.Add(Me.makhoi)
        Me.GroupBox1.Controls.Add(Me.malop)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 142)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'tenhs
        '
        Me.tenhs.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tenhs.Location = New System.Drawing.Point(485, 43)
        Me.tenhs.Name = "tenhs"
        Me.tenhs.Size = New System.Drawing.Size(202, 27)
        Me.tenhs.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(380, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Tên Học Sinh:"
        '
        'mahs
        '
        Me.mahs.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mahs.FormattingEnabled = True
        Me.mahs.Location = New System.Drawing.Point(202, 44)
        Me.mahs.Name = "mahs"
        Me.mahs.Size = New System.Drawing.Size(150, 27)
        Me.mahs.TabIndex = 21
        '
        'nienkhoa
        '
        Me.nienkhoa.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nienkhoa.FormattingEnabled = True
        Me.nienkhoa.Location = New System.Drawing.Point(560, 86)
        Me.nienkhoa.Name = "nienkhoa"
        Me.nienkhoa.Size = New System.Drawing.Size(127, 27)
        Me.nienkhoa.TabIndex = 9
        '
        'makhoi
        '
        Me.makhoi.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makhoi.FormattingEnabled = True
        Me.makhoi.Location = New System.Drawing.Point(202, 90)
        Me.makhoi.Name = "makhoi"
        Me.makhoi.Size = New System.Drawing.Size(75, 27)
        Me.makhoi.TabIndex = 8
        '
        'malop
        '
        Me.malop.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.malop.FormattingEnabled = True
        Me.malop.Location = New System.Drawing.Point(372, 89)
        Me.malop.Name = "malop"
        Me.malop.Size = New System.Drawing.Size(77, 27)
        Me.malop.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(472, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Niên Khóa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mã Khối:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mã Lớp:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Học Sinh:"
        '
        'huy
        '
        Me.huy.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.huy.Location = New System.Drawing.Point(326, 33)
        Me.huy.Name = "huy"
        Me.huy.Size = New System.Drawing.Size(95, 28)
        Me.huy.TabIndex = 16
        Me.huy.Text = "Hủy"
        Me.huy.UseVisualStyleBackColor = True
        '
        'xoa
        '
        Me.xoa.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xoa.Location = New System.Drawing.Point(124, 33)
        Me.xoa.Name = "xoa"
        Me.xoa.Size = New System.Drawing.Size(95, 28)
        Me.xoa.TabIndex = 14
        Me.xoa.Text = "Xóa"
        Me.xoa.UseVisualStyleBackColor = True
        '
        'them
        '
        Me.them.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.them.Location = New System.Drawing.Point(23, 33)
        Me.them.Name = "them"
        Me.them.Size = New System.Drawing.Size(95, 28)
        Me.them.TabIndex = 12
        Me.them.Text = "Thêm"
        Me.them.UseVisualStyleBackColor = True
        '
        'luoixl
        '
        Me.luoixl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.luoixl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.luoixl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.luoixl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.luoixl.DefaultCellStyle = DataGridViewCellStyle2
        Me.luoixl.Location = New System.Drawing.Point(12, 196)
        Me.luoixl.Name = "luoixl"
        Me.luoixl.ReadOnly = True
        Me.luoixl.Size = New System.Drawing.Size(703, 231)
        Me.luoixl.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.luu)
        Me.GroupBox2.Controls.Add(Me.huy)
        Me.GroupBox2.Controls.Add(Me.xoa)
        Me.GroupBox2.Controls.Add(Me.them)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(111, 424)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 93)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 40)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "XẾP LỚP CHO HỌC SINH"
        '
        'saplop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 515)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.luoixl)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "saplop"
        Me.Text = "saplop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.luoixl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents luu As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tenhs As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mahs As System.Windows.Forms.ComboBox
    Friend WithEvents nienkhoa As System.Windows.Forms.ComboBox
    Friend WithEvents makhoi As System.Windows.Forms.ComboBox
    Friend WithEvents malop As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents huy As System.Windows.Forms.Button
    Friend WithEvents xoa As System.Windows.Forms.Button
    Friend WithEvents them As System.Windows.Forms.Button
    Friend WithEvents luoixl As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
