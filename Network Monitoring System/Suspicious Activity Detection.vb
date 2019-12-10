Imports System.IO
Public Class login
    Private Sub detection_Click(sender As Object, e As EventArgs) Handles detection.Click
        Dim frm As New Dos_Acticity_Detection
        frm.Show()
    End Sub

    Private Sub sla_Click(sender As Object, e As EventArgs) Handles sla.Click
        Dim frm1 As New Suspicious_Login_Detection
        frm1.ShowDialog()
    End Sub
End Class