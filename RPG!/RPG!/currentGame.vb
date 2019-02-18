Module currentGame

    'declares the player object
    Public player As character

    'subroutine responsible for creating and giving the player their stats
    Sub playerCreate(ByVal pnme As String, ByVal standing As String)

        Dim nme As String
        Dim cls As String
        nme = pnme
        cls = standing

        'creates the player object and calls the assignment method
        player = New character(nme, cls)
        player.empPlayer()


    End Sub

End Module

