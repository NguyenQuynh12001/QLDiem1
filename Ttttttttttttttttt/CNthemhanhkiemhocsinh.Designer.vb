<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CNthemhanhkiemhocsinh
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.huy = New System.Windows.Forms.Button()
        Me.luu = New System.Windows.Forms.Button()
        Me.xoa = New System.Windows.Forms.Button()
        Me.them = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.hanhkiem = New System.Windows.Forms.TextBox()
        Me.nienkhoa = New System.Windows.Forms.ComboBox()
        Me.mahs = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hóci = New System.Windows.Forms.Label()
        Me.luoi = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.luoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.huy)
        Me.GroupBox2.Controls.Add(Me.luu)
        Me.GroupBox2.Controls.Add(Me.xoa)
        Me.GroupBox2.Controls.Add(Me.them)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 429)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 71)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'huy
        '
        Me.huy.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.huy.ForeColor = System.Drawing.Color.Blue
        Me.huy.Location = New System.Drawing.Point(320, 19)
        Me.huy.Name = "huy"
        Me.huy.Size = New System.Drawing.Size(78, 28)
        Me.huy.TabIndex = 16
        Me.huy.Text = "Hủy"
        Me.huy.UseVisualStyleBackColor = True
        '
        'luu
        '
        Me.luu.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luu.ForeColor = System.Drawing.Color.Blue
        Me.luu.Location = New System.Drawing.Point(219, 19)
        Me.luu.Name = "luu"
        Me.luu.Size = New System.Drawing.Size(78, 28)
        Me.luu.TabIndex = 15
        Me.luu.Text = "Lưu"
        Me.luu.UseVisualStyleBackColor = True
        '
        'xoa
        '
        Me.xoa.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xoa.ForeColor = System.Drawing.Color.Blue
        Me.xoa.Location = New System.Drawing.Point(118, 19)
        Me.xoa.Name = "xoa"
        Me.xoa.Size = New System.Drawing.Size(78, 28)
        Me.xoa.TabIndex = 14
        Me.xoa.Text = "Xóa"
        Me.xoa.UseVisualStyleBackColor = True
        '
        'them
        '
        Me.them.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.them.ForeColor = System.Drawing.Color.Blue
        Me.them.Location = New System.Drawing.Point(17, 19)
        Me.them.Name = "them"
        Me.them.Size = New System.Drawing.Size(78, 28)
        Me.them.TabIndex = 13
        Me.them.Text = "Thêm"
        Me.them.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.hanhkiem)
        Me.GroupBox1.Controls.Add(Me.nienkhoa)
        Me.GroupBox1.Controls.Add(Me.mahs)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.hóci)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(21, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(790, 84)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thêm hạnh kiểm"
        '
        'hanhkiem
        '
        Me.hanhkiem.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hanhkiem.Location = New System.Drawing.Point(619, 34)
        Me.hanhkiem.Name = "hanhkiem"
        Me.hanhkiem.Size = New System.Drawing.Size(143, 27)
        Me.hanhkiem.TabIndex = 6
        '
        'nienkhoa
        '
        Me.nienkhoa.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nienkhoa.FormattingEnabled = True
        Me.nienkhoa.Location = New System.Drawing.Point(368, 35)
        Me.nienkhoa.Name = "nienkhoa"
        Me.nienkhoa.Size = New System.Drawing.Size(119, 27)
        Me.nienkhoa.TabIndex = 5
        '
        'mahs
        '
        Me.mahs.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mahs.FormattingEnabled = True
        Me.mahs.Location = New System.Drawing.Point(106, 34)
        Me.mahs.Name = "mahs"
        Me.mahs.Size = New System.Drawing.Size(135, 27)
        Me.mahs.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(528, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hạnh Kiểm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(280, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Niên Khóa:"
        '
        'hóci
        '
        Me.hóci.AutoSize = True
        Me.hóci.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hóci.ForeColor = System.Drawing.Color.Red
        Me.hóci.Location = New System.Drawing.Point(13, 42)
        Me.hóci.Name = "hóci"
        Me.hóci.Size = New System.Drawing.Size(97, 19)
        Me.hóci.TabIndex = 1
        Me.hóci.Text = "Mã Học Sinh:"
        '
        'luoi
        '
        Me.luoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.luoi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.luoi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.luoi.DefaultCellStyle = DataGridViewCellStyle2
        Me.luoi.Location = New System.Drawing.Point(21, 197)
        Me.luoi.Name = "luoi"
        Me.luoi.ReadOnly = True
        Me.luoi.Size = New System.Drawing.Size(790, 213)
        Me.luoi.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 40)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "THÊM HẠNH KIỂM HỌC SINH"
        '
        'CNthemhanhkiemhocsinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(823, 529)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.luoi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CNthemhanhkiemhocsinh"
        Me.Text = "CNthemhanhkiemhocsinh"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.luoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents huy As System.Windows.Forms.Button
    Friend WithEvents luu As System.Windows.Forms.Button
    Friend WithEvents xoa As System.Windows.Forms.Button
    Friend WithEvents them As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents hanhkiem As System.Windows.Forms.TextBox
    Friend WithEvents nienkhoa As System.Windows.Forms.ComboBox
    Friend WithEvents mahs As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents hóci As System.Windows.Forms.Label
    Friend WithEvents luoi As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
