Imports System.Management
Public Class frmreg1
    Dim regkey As Microsoft.Win32.RegistryKey
    Dim strkey As String = "Software\\ycu\\jkx"
    Dim jm As New Class1
    Dim mima As String
    Dim Str As String
    Dim EDes, msgtxt As String
    Dim cpu As String
    Private Sub frmreg1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Wmi As New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_Processor")
        Dim Uint32 As String
        For Each WmiObj As ManagementObject In Wmi.Get
            Uint32 = WmiObj("ProcessorId")
        Next
        If Uint32 <> "" Then
            cpu = Uint32.ToString
            txtid.Text = cpu
        End If

        Dim s As String
        If Me.CheckBox1.Checked Then
            s = Format(Me.dt1.Value, "yyyy-MM-dd 00:00:00") & "," & Format(Me.dt2.Value, "yyyy-MM-dd 23:59:59")
        Else
            s = Format(Me.dt1.Value, "yyyy-MM-dd 00:00:00") & "," & Format(Me.dt2.Value, "2099-MM-dd 23:59:59")
        End If
        Str = txtid.Text
        Str &= "," & s
        EDes = jm.EncryptDes(Str, "12345678", "abcdefgh")

        regkey = My.Computer.Registry.CurrentUser.OpenSubKey(strkey, True)
        If regkey Is Nothing Then
            regkey = My.Computer.Registry.CurrentUser.CreateSubKey(strkey)
        Else
            If regkey.GetValue("zhanghu") <> "" Then

                frmlogin.Show()
                Me.Close()

            End If
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles zhuche.Click
        Try
            Dim s As String
            If Me.CheckBox1.Checked Then
                s = Format(Me.dt1.Value, "yyyy-MM-dd 00:00:00") & "," & Format(Me.dt2.Value, "yyyy-MM-dd 23:59:59")
            Else
                s = Format(Me.dt1.Value, "yyyy-MM-dd 00:00:00") & "," & Format(Me.dt2.Value, "2099-MM-dd 23:59:59")
            End If
            Str = txtid.Text
            Str &= "," & s
            EDes = jm.EncryptDes(Str, "12345678", "abcdefgh")

            If txtreg.Text Is "" Then
                MsgBox("不能为空")
            ElseIf txtreg.Text.Length <> 88 Then
                MsgBox("无效的序列号")
            Else
                If mima = EDes Then
                    regkey.SetValue("zhanghu", mima)
                    MsgBox("注册成功")
                    frmlogin.Show()
                    Me.Close()
                ElseIf mima <> EDes Then
                    MsgBox("序列号不正确")
                End If
            End If
        Catch ex As Exception
            MsgBox("注册失败" & ex.Message)
        End Try
    End Sub

    Private Sub txtreg_TextChanged(sender As Object, e As EventArgs) Handles txtreg.TextChanged
        mima = txtreg.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.dt2.Enabled = Me.CheckBox1.Checked
    End Sub
End Class