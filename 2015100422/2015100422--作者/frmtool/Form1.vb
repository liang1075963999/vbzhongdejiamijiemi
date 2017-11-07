Public Class Form1
    Dim Str As String
    Dim jm As New class1
    Dim EDes, msgtxt As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles scbutton.Click
        Dim s As String

        If Me.CheckBox1.Checked Then
            s = Format(Me.dt1.Value, "yyyy-MM-dd 00:00:00") & "," & Format(Me.dt2.Value, "yyyy-MM-dd 23:59:59")
        Else
            s = Format(Me.dt1.Value, "yyyy-MM-dd 00:00:00") & "," & Format(Me.dt2.Value, "2099-MM-dd 23:59:59")
        End If
        Str = jqm.Text
        Str &= "," & s
        EDes = jm.EncryptDes(Str, "12345678", "abcdefgh")
        Me.zcm.Text = EDes
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.dt2.Enabled = Me.CheckBox1.Checked
    End Sub
End Class
