Imports System.IO
Public Class NetworkScanner
    Private Sub networkscan_Click(sender As Object, e As EventArgs) Handles networkscan.Click
        Dim p As ProcessStartInfo
        Dim str As String = "/usr/bin/python3"
        p = New ProcessStartInfo(str)

        p.UseShellExecute = False
        p.RedirectStandardOutput = True
        Dim file As String
        file = "_scripts_/NETWORK-SCANNER.py"

        p.Arguments = file & " " & ip.Text

        Dim pro As New Process

        pro.StartInfo = p

        pro.Start()

        Dim reader As StreamReader = pro.StandardOutput

        Dim res As String = reader.ReadToEnd

        outputText.Text = res


        pro.WaitForExit()
        pro.Close()
    End Sub
End Class