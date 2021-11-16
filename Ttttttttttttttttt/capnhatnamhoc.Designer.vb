<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capnhatnamhoc
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
        Me.huy_nk = New System.Windows.Forms.Button()
        Me.luu_nk = New System.Windows.Forms.Button()
        Me.xoa_nk = New System.Windows.Forms.Button()
        Me.them_nk = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtma_nk = New System.Windows.Forms.TextBox()
        Me.luoi_nk = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.luoi_nk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'huy_nk
        '
        Me.huy_nk.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.huy_nk.ForeColor = System.Drawing.Color.Blue
        Me.huy_nk.Location = New System.Drawing.Point(319, 49)
        Me.huy_nk.Name = "huy_nk"
        Me.huy_nk.Size = New System.Drawing.Size(95, 28)
        Me.huy_nk.TabIndex = 29
        Me.huy_nk.Text = "Hủy"
        Me.huy_nk.UseVisualStyleBackColor = True
        '
        'luu_nk
        '
        Me.luu_nk.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luu_nk.ForeColor = System.Drawing.Color.Blue
        Me.luu_nk.Location = New System.Drawing.Point(219, 49)
        Me.luu_nk.Name = "luu_nk"
        Me.luu_nk.Size = New System.Drawing.Size(95, 28)
        Me.luu_nk.TabIndex = 28
        Me.luu_nk.Text = "Lưu"
        Me.luu_nk.UseVisualStyleBackColor = True
        '
        'xoa_nk
        '
        Me.xoa_nk.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xoa_nk.ForeColor = System.Drawing.Color.Blue
        Me.xoa_nk.Location = New System.Drawing.Point(120, 49)
        Me.xoa_nk.Name = "xoa_nk"
        Me.xoa_nk.Size = New System.Drawing.Size(94, 28)
        Me.xoa_nk.TabIndex = 27
        Me.xoa_nk.Text = "Xóa"
        Me.xoa_nk.UseVisualStyleBackColor = True
        '
        'them_nk
        '
        Me.them_nk.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.them_nk.ForeColor = System.Drawing.Color.Blue
        Me.them_nk.Location = New System.Drawing.Point(21, 49)
        Me.them_nk.Name = "them_nk"
        Me.them_nk.Size = New System.Drawing.Size(94, 28)
        Me.them_nk.TabIndex = 25
        Me.them_nk.Text = "Thêm"
        Me.them_nk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.huy_nk)
        Me.GroupBox1.Controls.Add(Me.luu_nk)
        Me.GroupBox1.Controls.Add(Me.xoa_nk)
        Me.GroupBox1.Controls.Add(Me.them_nk)
        Me.GroupBox1.Location = New System.Drawing.Point(136, 353)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 88)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'txtma_nk
        '
        Me.txtma_nk.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtma_nk.Location = New System.Drawing.Point(259, 146)
        Me.txtma_nk.Name = "txtma_nk"
        Me.txtma_nk.Size = New System.Drawing.Size(218, 27)
        Me.txtma_nk.TabIndex = 35
        '
        'luoi_nk
        '
        Me.luoi_nk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.luoi_nk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.luoi_nk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.luoi_nk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.luoi_nk.DefaultCellStyle = DataGridViewCellStyle2
        Me.luoi_nk.Location = New System.Drawing.Point(136, 199)
        Me.luoi_nk.Name = "luoi_nk"
        Me.luoi_nk.ReadOnly = True
        Me.luoi_nk.Size = New System.Drawing.Size(434, 138)
        Me.luoi_nk.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(160, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Niên Khóa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 40)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "CẬP NHẬT NIÊN KHÓA"
        '
        'capnhatnamhoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(706, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtma_nk)
        Me.Controls.Add(Me.luoi_nk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "capnhatnamhoc"
        Me.Text = "capnhatnamhoc"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.luoi_nk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents huy_nk As System.Windows.Forms.Button
    Friend WithEvents luu_nk As System.Windows.Forms.Button
    Friend WithEvents xoa_nk As System.Windows.Forms.Button
    Friend WithEvents them_nk As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtma_nk As System.Windows.Forms.TextBox
    Friend WithEvents luoi_nk As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
