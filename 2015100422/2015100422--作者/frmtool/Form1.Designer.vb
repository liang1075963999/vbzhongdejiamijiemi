<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.jqm = New System.Windows.Forms.TextBox()
        Me.zcm = New System.Windows.Forms.TextBox()
        Me.scbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'jqm
        '
        Me.jqm.Location = New System.Drawing.Point(162, 174)
        Me.jqm.Name = "jqm"
        Me.jqm.Size = New System.Drawing.Size(125, 21)
        Me.jqm.TabIndex = 0
        '
        'zcm
        '
        Me.zcm.Location = New System.Drawing.Point(162, 219)
        Me.zcm.Name = "zcm"
        Me.zcm.Size = New System.Drawing.Size(125, 21)
        Me.zcm.TabIndex = 1
        '
        'scbutton
        '
        Me.scbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scbutton.Location = New System.Drawing.Point(164, 266)
        Me.scbutton.Name = "scbutton"
        Me.scbutton.Size = New System.Drawing.Size(75, 23)
        Me.scbutton.TabIndex = 2
        Me.scbutton.Text = "生成"
        Me.scbutton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(106, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "硬盘号："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(107, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "注册码："
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(160, 95)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(125, 21)
        Me.dt1.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(120, 131)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(36, 16)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "到"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'dt2
        '
        Me.dt2.Enabled = False
        Me.dt2.Location = New System.Drawing.Point(162, 131)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(123, 21)
        Me.dt2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(94, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "使用时长："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("宋体", 19.0!)
        Me.Label4.Location = New System.Drawing.Point(119, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "注册码生成器"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(412, 340)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scbutton)
        Me.Controls.Add(Me.zcm)
        Me.Controls.Add(Me.jqm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents jqm As System.Windows.Forms.TextBox
    Friend WithEvents zcm As System.Windows.Forms.TextBox
    Friend WithEvents scbutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
