Public Class MainForm

    Private Sub btClients_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New ClientsForm()
        frm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New AccountsForm()
        frm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New ServicesForm()
        frm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New SubscriptionForm()
        frm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New IncidentsForm()
        frm.Show()
    End Sub

End Class
