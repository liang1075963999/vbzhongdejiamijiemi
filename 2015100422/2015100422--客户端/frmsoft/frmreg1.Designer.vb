<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmreg1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreg1))
        Me.zhuche = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtreg = New System.Windows.Forms.TextBox()
        Me.标识码 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'zhuche
        '
        Me.zhuche.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.zhuche.Location = New System.Drawing.Point(214, 234)
        Me.zhuche.Name = "zhuche"
        Me.zhuche.Size = New System.Drawing.Size(75, 23)
        Me.zhuche.TabIndex = 0
        Me.zhuche.Text = "注册"
        Me.zhuche.UseVisualStyleBackColor = False
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(214, 155)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(125, 21)
        Me.txtid.TabIndex = 1
        '
        'txtreg
        '
        Me.txtreg.Location = New System.Drawing.Point(214, 194)
        Me.txtreg.Name = "txtreg"
        Me.txtreg.Size = New System.Drawing.Size(125, 21)
        Me.txtreg.TabIndex = 2
        '
        '标识码
        '
        Me.标识码.AutoSize = True
        Me.标识码.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.标识码.Location = New System.Drawing.Point(158, 158)
        Me.标识码.Name = "标识码"
        Me.标识码.Size = New System.Drawing.Size(41, 12)
        Me.标识码.TabIndex = 3
        Me.标识码.Text = "硬盘号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(158, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "序列号"
        '
        'dt2
        '
        Me.dt2.Enabled = False
        Me.dt2.Location = New System.Drawing.Point(216, 115)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(123, 21)
        Me.dt2.TabIndex = 10
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(174, 115)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(36, 16)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "到"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(214, 88)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(125, 21)
        Me.dt1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(143, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "购买时长："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("宋体", 19.0!)
        Me.Label3.Location = New System.Drawing.Point(165, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "用户注册界面"
        '
        'frmreg1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(521, 318)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dt2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.标识码)
        Me.Controls.Add(Me.txtreg)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.zhuche)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "frmreg1"
        Me.Text = "frmreg1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents zhuche As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtreg As System.Windows.Forms.TextBox
    Friend WithEvents 标识码 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dt2 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents dt1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
