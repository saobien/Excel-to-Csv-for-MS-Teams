<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BT_CHONTEP = New System.Windows.Forms.Button()
        Me.BT_CHUYEN = New System.Windows.Forms.Button()
        Me.BT_THOAT = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dlgFolderSelect = New System.Windows.Forms.FolderBrowserDialog()
        Me.BT_LUU = New System.Windows.Forms.Button()
        Me.TXT_LUU = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TXT_DUOITK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CHUCDANH = New System.Windows.Forms.TextBox()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(762, 307)
        Me.DataGridView1.TabIndex = 7
        '
        'BT_CHONTEP
        '
        Me.BT_CHONTEP.BackColor = System.Drawing.Color.DarkOrange
        Me.BT_CHONTEP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CHONTEP.ForeColor = System.Drawing.Color.Black
        Me.BT_CHONTEP.Location = New System.Drawing.Point(792, 79)
        Me.BT_CHONTEP.Name = "BT_CHONTEP"
        Me.BT_CHONTEP.Size = New System.Drawing.Size(104, 36)
        Me.BT_CHONTEP.TabIndex = 4
        Me.BT_CHONTEP.Text = "Chọn tệp"
        Me.BT_CHONTEP.UseVisualStyleBackColor = False
        '
        'BT_CHUYEN
        '
        Me.BT_CHUYEN.BackColor = System.Drawing.Color.DarkOrange
        Me.BT_CHUYEN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CHUYEN.ForeColor = System.Drawing.Color.Black
        Me.BT_CHUYEN.Location = New System.Drawing.Point(792, 144)
        Me.BT_CHUYEN.Name = "BT_CHUYEN"
        Me.BT_CHUYEN.Size = New System.Drawing.Size(104, 36)
        Me.BT_CHUYEN.TabIndex = 5
        Me.BT_CHUYEN.Text = "Chuyển"
        Me.BT_CHUYEN.UseVisualStyleBackColor = False
        '
        'BT_THOAT
        '
        Me.BT_THOAT.BackColor = System.Drawing.Color.DarkOrange
        Me.BT_THOAT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_THOAT.ForeColor = System.Drawing.Color.Black
        Me.BT_THOAT.Location = New System.Drawing.Point(790, 283)
        Me.BT_THOAT.Name = "BT_THOAT"
        Me.BT_THOAT.Size = New System.Drawing.Size(104, 36)
        Me.BT_THOAT.TabIndex = 0
        Me.BT_THOAT.Text = "Thoát"
        Me.BT_THOAT.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BT_LUU
        '
        Me.BT_LUU.BackColor = System.Drawing.Color.DarkOrange
        Me.BT_LUU.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LUU.ForeColor = System.Drawing.Color.Black
        Me.BT_LUU.Location = New System.Drawing.Point(792, 12)
        Me.BT_LUU.Name = "BT_LUU"
        Me.BT_LUU.Size = New System.Drawing.Size(104, 36)
        Me.BT_LUU.TabIndex = 3
        Me.BT_LUU.Text = "Vị trí lưu"
        Me.BT_LUU.UseVisualStyleBackColor = False
        '
        'TXT_LUU
        '
        Me.TXT_LUU.Location = New System.Drawing.Point(790, 238)
        Me.TXT_LUU.Name = "TXT_LUU"
        Me.TXT_LUU.Size = New System.Drawing.Size(104, 20)
        Me.TXT_LUU.TabIndex = 9
        Me.TXT_LUU.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProgressBar1.Location = New System.Drawing.Point(-4, 359)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(912, 10)
        Me.ProgressBar1.TabIndex = 6
        '
        'TXT_DUOITK
        '
        Me.TXT_DUOITK.Location = New System.Drawing.Point(400, 325)
        Me.TXT_DUOITK.Name = "TXT_DUOITK"
        Me.TXT_DUOITK.Size = New System.Drawing.Size(158, 20)
        Me.TXT_DUOITK.TabIndex = 1
        Me.TXT_DUOITK.Text = "@vanhien.edu.vn"
        Me.TXT_DUOITK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nhập phần đuôi tài khoản:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(579, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nhập chức danh:"
        '
        'TXT_CHUCDANH
        '
        Me.TXT_CHUCDANH.Location = New System.Drawing.Point(684, 325)
        Me.TXT_CHUCDANH.Name = "TXT_CHUCDANH"
        Me.TXT_CHUCDANH.Size = New System.Drawing.Size(90, 20)
        Me.TXT_CHUCDANH.TabIndex = 2
        Me.TXT_CHUCDANH.Text = "Học sinh"
        Me.TXT_CHUCDANH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(137, 328)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(90, 20)
        Me.TXT_ID.TabIndex = 11
        Me.TXT_ID.Text = "vh21"
        Me.TXT_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nhập mã tài khoản:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(908, 367)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CHUCDANH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_DUOITK)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TXT_LUU)
        Me.Controls.Add(Me.BT_LUU)
        Me.Controls.Add(Me.BT_THOAT)
        Me.Controls.Add(Me.BT_CHUYEN)
        Me.Controls.Add(Me.BT_CHONTEP)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Excel to CSV for MS Team                                                Code by: " & _
    "Trần Quốc Minh_Giáo viên Trường THPT Văn Hiến, TP Long Khánh, Tỉnh Đồng Nai"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BT_CHONTEP As System.Windows.Forms.Button
    Friend WithEvents BT_CHUYEN As System.Windows.Forms.Button
    Friend WithEvents BT_THOAT As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgFolderSelect As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BT_LUU As System.Windows.Forms.Button
    Friend WithEvents TXT_LUU As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TXT_DUOITK As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_CHUCDANH As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
