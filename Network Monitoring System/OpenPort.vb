Imports System.IO
Imports System.DateTime
Public Class openportscanner
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles scan.Click
        Dim p As ProcessStartInfo
        Dim str As String = "/usr/bin/python3"
        p = New ProcessStartInfo(str)

        p.UseShellExecute = False
        p.RedirectStandardOutput = True
        Dim file As String
        file = "_scripts_/PORT_SCANNER.py"

        Dim arg As String

        If localhost.Checked Then
            arg = "127.0.0.1"
        Else
            arg = ip.Text
        End If
        portbox.Text = "1024"
        p.Arguments = file & " " & arg & " " & portbox.Text

        Dim pro As New Process

        pro.StartInfo = p

        pro.Start()

        Dim reader As StreamReader = pro.StandardOutput

        Dim res As String = reader.ReadToEnd

        outputText.Text = res


        pro.WaitForExit()
        pro.Close()


    End Sub

    Private Sub localhost_CheckedChanged(sender As Object, e As EventArgs) Handles localhost.CheckedChanged
        If localhost.Checked Then
            ip.Enabled = False
        Else
            ip.Enabled = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub portbox_TextChanged(sender As Object, e As EventArgs) Handles portbox.TextChanged

    End Sub
End Class