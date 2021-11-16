<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capnhatgiaovien
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.huy = New System.Windows.Forms.Button()
        Me.luu = New System.Windows.Forms.Button()
        Me.xoa = New System.Windows.Forms.Button()
        Me.sua = New System.Windows.Forms.Button()
        Me.them = New System.Windows.Forms.Button()
        Me.luoigv = New System.Windows.Forms.DataGridView()
        Me.tbdienthoai_gv = New System.Windows.Forms.TextBox()
        Me.tbdiachi_gv = New System.Windows.Forms.TextBox()
        Me.tbten_gv = New System.Windows.Forms.TextBox()
        Me.tbma_gv = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.luoigv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.huy)
        Me.GroupBox1.Controls.Add(Me.luu)
        Me.GroupBox1.Controls.Add(Me.xoa)
        Me.GroupBox1.Controls.Add(Me.sua)
        Me.GroupBox1.Controls.Add(Me.them)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 406)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(732, 80)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'huy
        '
        Me.huy.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.huy.Location = New System.Drawing.Point(472, 24)
        Me.huy.Name = "huy"
        Me.huy.Size = New System.Drawing.Size(95, 30)
        Me.huy.TabIndex = 19
        Me.huy.Text = "Hủy"
        Me.huy.UseVisualStyleBackColor = True
        '
        'luu
        '
        Me.luu.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luu.Location = New System.Drawing.Point(371, 24)
        Me.luu.Name = "luu"
        Me.luu.Size = New System.Drawing.Size(95, 30)
        Me.luu.TabIndex = 18
        Me.luu.Text = "Lưu"
        Me.luu.UseVisualStyleBackColor = True
        '
        'xoa
        '
        Me.xoa.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xoa.Location = New System.Drawing.Point(270, 24)
        Me.xoa.Name = "xoa"
        Me.xoa.Size = New System.Drawing.Size(95, 30)
        Me.xoa.TabIndex = 17
        Me.xoa.Text = "Xóa"
        Me.xoa.UseVisualStyleBackColor = True
        '
        'sua
        '
        Me.sua.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sua.Location = New System.Drawing.Point(169, 24)
        Me.sua.Name = "sua"
        Me.sua.Size = New System.Drawing.Size(95, 30)
        Me.sua.TabIndex = 16
        Me.sua.Text = "Sửa"
        Me.sua.UseVisualStyleBackColor = True
        '
        'them
        '
        Me.them.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.them.Location = New System.Drawing.Point(68, 24)
        Me.them.Name = "them"
        Me.them.Size = New System.Drawing.Size(95, 30)
        Me.them.TabIndex = 15
        Me.them.Text = "Thêm"
        Me.them.UseVisualStyleBackColor = True
        '
        'luoigv
        '
        Me.luoigv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.luoigv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.luoigv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.luoigv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.luoigv.DefaultCellStyle = DataGridViewCellStyle2
        Me.luoigv.Location = New System.Drawing.Point(12, 191)
        Me.luoigv.Name = "luoigv"
        Me.luoigv.ReadOnly = True
        Me.luoigv.Size = New System.Drawing.Size(732, 209)
        Me.luoigv.TabIndex = 35
        '
        'tbdienthoai_gv
        '
        Me.tbdienthoai_gv.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbdienthoai_gv.Location = New System.Drawing.Point(499, 134)
        Me.tbdienthoai_gv.Name = "tbdienthoai_gv"
        Me.tbdienthoai_gv.Size = New System.Drawing.Size(245, 27)
        Me.tbdienthoai_gv.TabIndex = 34
        '
        'tbdiachi_gv
        '
        Me.tbdiachi_gv.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbdiachi_gv.Location = New System.Drawing.Point(497, 91)
        Me.tbdiachi_gv.Name = "tbdiachi_gv"
        Me.tbdiachi_gv.Size = New System.Drawing.Size(247, 27)
        Me.tbdiachi_gv.TabIndex = 33
        '
        'tbten_gv
        '
        Me.tbten_gv.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbten_gv.Location = New System.Drawing.Point(497, 47)
        Me.tbten_gv.Name = "tbten_gv"
        Me.tbten_gv.Size = New System.Drawing.Size(247, 27)
        Me.tbten_gv.TabIndex = 32
        '
        'tbma_gv
        '
        Me.tbma_gv.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbma_gv.Location = New System.Drawing.Point(497, 12)
        Me.tbma_gv.Name = "tbma_gv"
        Me.tbma_gv.Size = New System.Drawing.Size(247, 27)
        Me.tbma_gv.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(366, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Điện Thoại:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(366, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Địa Chỉ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(366, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Tên Giáo Viên:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(366, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Mã Giáo Viên:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, -79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 40)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "CẬP NHẬT GIÁO VIÊN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Candara", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(317, 40)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "CẬP NHẬT GIÁO VIÊN"
        '
        'capnhatgiaovien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(760, 494)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.luoigv)
        Me.Controls.Add(Me.tbdienthoai_gv)
        Me.Controls.Add(Me.tbdiachi_gv)
        Me.Controls.Add(Me.tbten_gv)
        Me.Controls.Add(Me.tbma_gv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "capnhatgiaovien"
        Me.Text = "capnhatgiaovien"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.luoigv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents huy As System.Windows.Forms.Button
    Friend WithEvents luu As System.Windows.Forms.Button
    Friend WithEvents xoa As System.Windows.Forms.Button
    Friend WithEvents sua As System.Windows.Forms.Button
    Friend WithEvents them As System.Windows.Forms.Button
    Friend WithEvents luoigv As System.Windows.Forms.DataGridView
    Friend WithEvents tbdienthoai_gv As System.Windows.Forms.TextBox
    Friend WithEvents tbdiachi_gv As System.Windows.Forms.TextBox
    Friend WithEvents tbten_gv As System.Windows.Forms.TextBox
    Friend WithEvents tbma_gv As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
