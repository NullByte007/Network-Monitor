Imports System.IO

Public Class NetworkTraffic
    Private Sub networktrafficscan_Click(sender As Object, e As EventArgs) Handles networktrafficscan.Click
        Dim p As ProcessStartInfo
        Dim str As String = "/usr/bin/python3"
        p = New ProcessStartInfo(str)

        p.UseShellExecute = False
        p.RedirectStandardOutput = True
        Dim file As String
        file = "_scripts_/NETWORK-TRAFFIC_ANALYSIS.py"
        p.Arguments = file & " " & filter.Text & " " & interfacecombobox.Text

        Dim pro As New Process

        pro.StartInfo = p

        pro.Start()

        Dim reader As StreamReader = pro.StandardOutput

        Dim res As String = reader.ReadToEnd

        outputText.Text = res


        pro.WaitForExit()
        pro.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filter.SelectedIndexChanged

    End Sub
End Class