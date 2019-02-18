Public Class charCreate


    'creating the player clsses to be passed on to other forms
    Dim cls() As String = {"Merchant", "Mage", "Knight"}
    Dim x As Byte = 0

    'allows user to return to menu
    Private Sub ccMenu_btn_Click(sender As Object, e As EventArgs) Handles ccMenu_btn.Click
        Me.Close()
        rpg.Show()
    End Sub

    'allows user to go forward and start playing the game
    Private Sub ccPlay_btn_Click(sender As Object, e As EventArgs) Handles ccPlay_btn.Click

        'assigns the imputs to two variables which are then passed on to the core module of the game as to save the data and create the player
        Dim pnme As String = chrName_txt.Text
        Dim standing As String = clsSelect_list.SelectedItem

        playerCreate(pnme, standing)

        map.Show()
        Me.Close()

    End Sub

    'displays the classes from which the player can choose
    Private Sub charCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        clsSelect_list.BeginUpdate()

        For x = 0 To 2
            clsSelect_list.Items.Add(cls(x))
        Next

        clsSelect_list.EndUpdate()

    End Sub


End Class