Public Class rpg

    Private Sub newGame_btn_Click(sender As Object, e As EventArgs) Handles newGame_btn.Click

        charCreate.Show() ' shows the character create menu
        Me.Hide() ' hides the main menu. If I closed it the entire app would stop running

    End Sub

    'series of instruction for when loading a savegame

    Private Sub ldGame_btn_Click(sender As Object, e As EventArgs) Handles ldGame_btn.Click

        ' save game data is saved on a text file
        Dim load As System.IO.StreamReader

        load = My.Computer.FileSystem.OpenTextFileReader("G:\CS RPG\RPG!\extras\playerstats.txt")
        Dim progressload As String = load.ReadToEnd
        load.Close()
        Dim split() As String = progressload.Split(New Char() {"'"})

        currentGame.playerCreate(split(0), split(1))

        player.loadSave(split(0).ToString, split(1).ToString, split(2), CInt(split(3)), CInt(split(4)), CInt(split(5)), CInt(split(6)), CInt(split(7)), CInt(split(8)), CInt(split(9)), split(10).ToString)
        map.Show()
        Me.Hide()


    End Sub

    'quits game when clicked

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        Application.Exit()
    End Sub



End Class

