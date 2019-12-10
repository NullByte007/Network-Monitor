Imports System.IO

Public Class Suspicious_Login_Detection
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Dim p As ProcessStartInfo
        Dim str As String = "/usr/bin/python3"
        p = New ProcessStartInfo(str)

        p.UseShellExecute = False
        p.RedirectStandardOutput = True
        Dim file As String
        file = "_scripts_/DOS-SUSPICIOUS-LOGIN-DETECTION.py"

        p.Arguments = file

        Dim pro As New Process

        pro.StartInfo = p

        pro.Start()

        Dim reader As StreamReader = pro.StandardOutput

        Dim res As String = reader.ReadToEnd

        outputbox.Text = res


        pro.WaitForExit()
        pro.Close()
    End Sub
End Class