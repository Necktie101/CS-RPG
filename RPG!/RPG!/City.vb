Public Class City

    'this form allows the player to interact with the market and creates a more immersive in doing so.

    Private Sub ext_btn_Click(sender As Object, e As EventArgs) Handles ext_btn.Click

        Me.Close()

    End Sub

    Private Sub mrkt_btn_Click(sender As Object, e As EventArgs) Handles mrkt_btn.Click
        Market.Show()
    End Sub
End Class