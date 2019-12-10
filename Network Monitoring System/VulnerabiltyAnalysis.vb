Imports System.IO
Public Class VulnerabiltyAnalysis
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles ip.TextChanged

    End Sub

    Private Sub vulnerabilityscan_Click(sender As Object, e As EventArgs) Handles vulnerabilityscan.Click
        Dim p As ProcessStartInfo
        Dim str As String = "/usr/bin/python3"
        p = New ProcessStartInfo(str)

        p.UseShellExecute = False
        p.RedirectStandardOutput = True
        Dim arg As String
        Dim file As String
        file = "_scripts_/VULNERABILITY-SCANNER.py"
        If localhost.Checked Then
            arg = "127.0.0.1"
        Else
            arg = ip.Text
        End If

        p.Arguments = file & " " & arg

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
End Class