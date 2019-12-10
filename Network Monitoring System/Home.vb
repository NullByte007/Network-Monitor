Public Class Home
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles openportscanner.Click
        Dim frm As New openportscanner
        frm.ShowDialog()

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles vulnerabilityanalysis.Click
        Dim frm1 As New VulnerabiltyAnalysis
        frm1.ShowDialog()



    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles networkscanner.Click
        Dim frm2 As New NetworkScanner
        frm2.ShowDialog()

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles networktrafficanalysis.Click
        Dim frm3 As New NetworkTraffic
        frm3.ShowDialog()

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm4 As New Help
        frm4.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm5 As New About
        frm5.ShowDialog()
    End Sub

    Private Sub activitydetection_Click(sender As Object, e As EventArgs) Handles activitydetection.Click
        Dim frm6 As New login


        frm6.ShowDialog()
    End Sub
End Class
