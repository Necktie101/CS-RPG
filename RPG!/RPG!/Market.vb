
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Market

    'getting basic market data from spreadsheet

    Dim marketapp As New Excel.Application
    Dim marketxls As Excel.Workbook = marketapp.Workbooks.Open("G:\CS RPG\RPG!\extras\marketData.xlsx")
    Dim marketsheet As Excel.Worksheet = marketxls.Worksheets("marketDataSheet")
    Dim marketRange As Excel.Range = marketsheet.UsedRange
    Dim marketCellArray As System.Array = marketRange.Value


    'opening the player inventory that is kept on a spreadsheet

    Dim inventoryapp As New Excel.Application
    Dim inventoryxls As Excel.Workbook = inventoryapp.Workbooks.Open("G:\CS RPG\RPG!\extras\backpack.xlsx")
    Dim inventorysheet As Excel.Worksheet = inventoryxls.Worksheets("inventorySheet")
    Dim inventoryrange As Excel.Range = inventorysheet.UsedRange
    Dim inventoryCellArray As System.Array = inventoryrange.Value



    'separate variables

    Dim sprice As UInt16
    Dim prices As UInt16
    Dim amount As Byte
    Dim quantity As Byte

    Private Sub Market_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'displays the contents of the player inventory 

        Dim y As Integer = 2
        Dim rowcount As Integer = inventorysheet.UsedRange.Rows.Count

        For y = 2 To rowcount

            If inventorysheet.Cells(y, 1).value = "" Then

                backpack_list.Items.Add("NULL")

            Else

                backpack_list.Items.Add(inventoryCellArray(y, 1))

            End If

        Next

        'getting other necessary info

        correntMarket_lbl.Text = "Market Location: " & player.getLocation

        'adding the commodities to specific locations on the map

        If player.getLocation = "Varphis Outpost" Or player.getLocation = "Jeah Outpost" Or player.getLocation = "Galka Outpost" Then

            goodsSelector_cmbx.Items.Add(marketCellArray(2, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(7, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(8, 1))

        End If

        If player.getLocation = "Xasas" Or player.getLocation = "Qredoz" Then

            goodsSelector_cmbx.Items.Add(marketCellArray(9, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(13, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(2, 1))

        End If

        If player.getLocation = "Zanard" Or player.getLocation = "Wrata City" Or player.getLocation = "Falgo" Or player.getLocation = "Blezrorez" Then

            goodsSelector_cmbx.Items.Add(marketCellArray(2, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(4, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(7, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(10, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(13, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(14, 1))

        End If

        If player.getLocation = "Vluetrok" Or player.getLocation = "Achenar Harbour" Or player.getLocation = "Eshaka Markets" Then
            Dim x As Byte = 2

            For x = 2 To 14
                goodsSelector_cmbx.Items.Add(marketCellArray(x, 1))
            Next

        End If

        If player.getLocation = "Ucland Mines" Then

            goodsSelector_cmbx.Items.Add(marketCellArray(4, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(5, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(11, 1))
            goodsSelector_cmbx.Items.Add(marketCellArray(12, 1))

        End If
    End Sub


    'confirming the item requested and showing status of market regarding to it

    Private Sub select_btn_Click(sender As Object, e As EventArgs) Handles select_btn.Click




        Dim r As Integer = 2

        For r = 2 To marketsheet.UsedRange.Rows.Count

            If marketsheet.Cells(r, 1).value = goodsSelector_cmbx.SelectedItem Then

                prices = CInt(marketCellArray(r, 2) + Int(10 * Rnd() + 1))
                price_lbl.Text = "Buy Price: " & prices
                amount = CInt(marketCellArray(r, 5) + Int(10 * Rnd() + 1))
                amount_lbl.Text = "Quantiity Available: " & amount

            End If

        Next

        Dim s As Integer = 2
        Dim rcount As Integer = inventorysheet.UsedRange.Rows.Count

        For s = 2 To rcount

            If inventorysheet.Cells(s, 1).value = backpack_list.SelectedItem Then

                amount = CInt(inventoryCellArray(s, 2))
                amount_lbl.Text = "Quantity Available: " & amount



                Dim row As Integer = 2
                Dim raw As Integer = 2
                Dim smart As UInt16 = player.getInt / 4

                For raw = 2 To inventorysheet.UsedRange.Rows.Count

                    If backpack_list.SelectedItem = inventorysheet.Cells(raw, 1).value Then
                        Exit For
                    End If

                Next

                For row = 2 To marketsheet.UsedRange.Rows.Count

                        If backpack_list.SelectedItem = marketsheet.Cells(row, 1).value Then

                            sprice = smart + CInt(marketCellArray(row, 3)) + Int(10 * Rnd(0 + 1))
                            sPrice_lbl.Text = "Sale Price: " & sprice
                            amount = CInt(inventoryCellArray(raw, 2))
                            amount_lbl.Text = "Quantity Available: " & amount

                        End If

                    Next

                End If

        Next


    End Sub

    'what the program does when the player requests to leave the market

    Private Sub return_btn_Click(sender As Object, e As EventArgs) Handles return_btn.Click
        savfile()

        marketxls.Close(SaveChanges:=False)
        inventoryxls.Close()

        releaseObject(marketapp)
        releaseObject(marketxls)
        releaseObject(marketsheet)
        releaseObject(marketRange)
        releaseObject(marketCellArray)

        releaseObject(inventoryapp)
        releaseObject(inventoryxls)
        releaseObject(inventorysheet)
        releaseObject(inventoryrange)
        releaseObject(inventoryCellArray)
        Me.Close()

    End Sub

    'player buying caommodities

    Private Sub buy_btn_Click(sender As Object, e As EventArgs) Handles buy_btn.Click

        'assigning the bought item to the next empty cell in spreadseeh
        Dim nextEmpty As Byte = inventorysheet.UsedRange.Rows.Count + 1
        Dim x As Integer = 2

        For x = 2 To marketsheet.UsedRange.Rows.Count

            If marketsheet.Cells(x, 1).value = goodsSelector_cmbx.SelectedItem Then

                Exit For

            End If
        Next


        inventorysheet.Cells(nextEmpty, 1).value = goodsSelector_cmbx.SelectedItem.ToString
        inventorysheet.Cells(nextEmpty, 2).value = qSelector_bx.Text.ToString
        inventorysheet.Cells(nextEmpty, 3).value = marketCellArray(x, 4)

        'calculates the total weight the player is carying
        Dim totalweight As UInt16 = CInt(qSelector_bx.Text * marketCellArray(x, 4))

        player.setCurrentWeight(totalweight) 'sets this to the object


        Dim deduction As UInt16 = CInt(inventorysheet.Cells(nextEmpty, 2).value) * prices 'deducts available pool of money from player after buying cargo

        player.detractcoin(deduction) 'adjusts the total money in player object

    End Sub

    'deals with the selling of items
    Private Sub sell_btn_Click(sender As Object, e As EventArgs) Handles sell_btn.Click

        'loads up data from inventory to be sold
        Dim row As Byte

        For row = 2 To inventorysheet.UsedRange.Rows.Count
            If backpack_list.SelectedItem = inventorysheet.Cells(row, 1).value Then
                Exit For
            End If
        Next

        Dim bonus As UInt16 = 18 * CInt(qSelector_bx.Text) 'calculates experience gained for each sold item

        'deals with the different ways a player can sell: everything or part of stock
        If qSelector_bx.Text = inventorysheet.Cells(row, 2).value Then

            Dim col As Byte = 1

            For col = 1 To inventoryrange.Columns.Count

                inventorysheet.Cells(row, col).value = "" 'measure showing that in that slot there is nothing howver the list carries on
                player.addxp(bonus)

                Dim profit As UInt16 = CInt(qSelector_bx.Text) * sprice + player.getInt / 4 'calculates profit

                player.addcoin(profit) 'adds profit to purse (player object)

            Next

        ElseIf qSelector_bx.Text < inventorysheet.Cells(row, 2).value Then

            inventorysheet.Cells(row, 2).value = CInt(inventorysheet.Cells(row, 2).value) - CInt(qSelector_bx.Text)

            Dim profit As UInt16 = CInt(qSelector_bx.Text) * sprice + player.getInt / 4

            player.addcoin(profit)



            player.addxp(bonus)

        Else

            MessageBox.Show("You don't any left") 'notifiest the player when ther is nothing left


        End If



    End Sub

    Sub savfile() 'saves data to inventory sheet

        If inventoryxls.Saved = False Then

            inventoryxls.Save()

        End If

    End Sub

    'clears local memory

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

End Class