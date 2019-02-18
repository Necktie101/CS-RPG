
Imports Excel = Microsoft.Office.Interop.Excel ' needed later


Public Class map

    'robbed and win are neccesary when the robbery attempt event is trigered
    Dim robbed As Boolean = False
    Dim win As Boolean

    ' list of towns on the map
    Dim towns() As String = {"Vluetrok", "Achenar Harbour", "Zanard", "Galka Outpost", "Wrata City", "Jeah Outpost", "Falgo", "Xasas", "Varphis Outpost", "Ucland Mines", "Blezrorez", "Qredoz", "Eshaka Markets"}
    Dim i As Integer = 0
    Dim encumbred As Boolean = False 'used when checking if player has too many goods and he cannot carry them



    Private Sub map_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'starts the timer which makes sure all the player info is updated regullarly
        Chronos_tmr.Start()

        'adds the towns to the list of possible destinations
        For i = 0 To towns.Length - 1
            slctDest_list.Items.Add(towns(i))
        Next



    End Sub

    Private Sub go_btn_Click(sender As Object, e As EventArgs) Handles go_btn.Click

        'when pressing the button to travel somewhere the game will check if the player is encumbered or not
        'if not encumbered the player will travel to selected destination
        If encumbred = False Then
            player.setLocation(slctDest_list.SelectedItem)
            crntLocation_lbl.Text = "Current Location: " & slctDest_list.SelectedItem
        ElseIf encumbred = True Then
            MessageBox.Show("You are carrying too much weight! Lighten your load before departing.")
        End If

        robberycheck() 'tells the program if the theft attepmt will happen

        'deals with the adtermath of the robbery ccheck
        If robbed = True Then

            'generates ensmies
            enemygen()

            'if player wins then gives money and experience
            If win = True Then

                Dim bonus As Byte = 50

                player.addcoin(100)
                player.addxp(bonus)

            Else

                'deals with a player loss
                'if player loses the program empties the player inventory and detracts some money from the player

                Dim invapp As New Excel.Application
                Dim invxls As Excel.Workbook = invapp.Workbooks.Open("G:\CS RPG\RPG!\extras\backpack.xlsx")
                Dim invsheet As Excel.Worksheet = invxls.Worksheets("inventorySheet")

                player.detractcoin(200)

                Dim r As Integer = 2
                Dim c As Integer = 1
                Dim rcount As Integer = invsheet.UsedRange.Rows.Count
                Dim ccount As Integer = invsheet.UsedRange.Columns.Count

                For r = 2 To rcount 'deals with the emptying of the inventory

                    For c = 1 To ccount

                        invsheet.Cells.Range(r, c).Delete()

                    Next

                Next

                'saves the new inventory
                If invxls.Saved = False Then

                    invxls.Save()

                End If

                'commands that deal with the closure of excel and the memory clean up

                invxls.Close()
                invapp.Quit()

                releaseObject(invapp)
                releaseObject(invxls)
                releaseObject(invsheet)

            End If

        End If

    End Sub

    'shows the city form if player clicks on it
    Private Sub twnEnt_btn_Click(sender As Object, e As EventArgs) Handles twnEnt_btn.Click
        City.Show()
    End Sub


    'checks if player encounters thiefs
    Private Sub robberycheck()

        'this is handeled by generating a random number
        Dim chance As Integer

        Randomize()
        chance = CInt(10 * Rnd() + 1)


        'the chance of being robbed is  1/10 as the event will trigger true only if the random value is 5
        If chance = 5 Then

            robbed = True

        Else

            robbed = False

        End If

    End Sub

    'generating enemies for the player to fight
    Private Sub enemygen()

        'the enemy's level is randomly generate
        Dim level As Integer

        Randomize()
        level = player.getLvl + CInt(10 * Rnd() + 1)

        'this is passed on to the encounter procedure
        encounter(level)

    End Sub

    'the procedure that deals with the cobat
    Private Sub encounter(ByVal level As Integer)

        ' values needed in combat
        Dim difference As Byte 'diffference between player level and enemy level
        Dim savethrow As Integer 'used to calculate win probability


        difference = level - player.getLvl 'setting the difference

        ' only kicks in if enemy is higher level than the player
        If difference > 0 And difference <= 5 Then


            Randomize()
            savethrow = CInt(10 * Rnd() + 1)

            'when the level difference is smaller than 5 the player has a 50% chance of sinning the encounter
            If savethrow <= 5 Then

                win = True

            Else

                win = False

            End If

        ElseIf difference > 5 And difference <= 10 Then

            Randomize()
            savethrow = CInt(10 * Rnd() + 1)

            'if the difference is bigger than that he onl has a 40% chance at winning
            If savethrow >= 6 Then

                win = True

            Else

                win = False

            End If

        Else

            win = True

        End If

    End Sub

    'used to empty memory of unwanted packground procesess
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    'it updates every sprite every tick as well as checking if the player is encoumbered or not
    Private Sub Chronos_tmr_Tick(sender As Object, e As EventArgs) Handles Chronos_tmr.Tick

        'player stats
        pname.Text = player.getName
        pstat.Text = player.getClass
        intValue_lbl.Text = player.getInt
        strValue_lbl.Text = player.getStr
        cwghtValue_lbl.Text = player.getCW
        lvlValue_lbl.Text = player.getLvl
        moneyValue_lbl.Text = player.getMoney
        crntLocation_lbl.Text = "Current Location: " & player.getLocation

        player.lvlCheck() 'chechs if player has leveld up

        'encumbered check
        If player.getCW > player.getCurrenWeight Then
            encumbred = False
        ElseIf player.getCW < player.getCurrenWeight Then
            encumbred = True
        End If

    End Sub

    'exit button 
    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        Application.Exit()
    End Sub

    'save game button
    'wrotes every player attribute to a text file
    Private Sub saveGame_btn_Click(sender As Object, e As EventArgs) Handles saveGame_btn.Click

        Dim save As System.IO.StreamWriter

        save = My.Computer.FileSystem.OpenTextFileWriter("G:\CS RPG\RPG!\extras\playerstats.txt", False)
        save.Write(player.getName & "'" & player.getClass & "'" & player.getLvl & "'" & player.getMoney & "'" & player.getxp & "'" & player.getlvlxp & "'" & player.getInt & "'" & player.getStr & "'" & player.getCW & "'" & player.getCurrenWeight & "'" & player.getLocation)
        save.Close()

    End Sub
End Class
