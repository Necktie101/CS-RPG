Public Class character
    ' this class is resposnsible for the player characteristics

    'declaring all player attributes
    Private name As String
    Private type As String
    Private level As Byte
    Private xp As Integer
    Private lvlxp As Int16

    'the player stats
    Dim intelligence As Byte
    Dim strength As Byte
    Dim cwight As Integer
    Dim currentWight As Integer

    'miccelaneous player info
    Dim money As Integer
    Dim location As String


    'the constructor
    Public Sub New(pname As String, pclass As String)
        name = pname
        type = pclass
    End Sub

    'gives the player their stats based in what class thy chose to play as
    'is employed once in the entire program when character is created
    Public Sub empPlayer()

        If type = "Merchant" Then
            intelligence = 85
            strength = 70
            cwight = 1000
            currentWight = 0
            level = 0
            money = 1200
            location = "Achenar Harbour"
        ElseIf type = "Knight" Then
            intelligence = 45
            strength = 150
            cwight = 1500
            currentWight = 0
            level = 0
            money = 700
            location = "Galka Outpost"
        ElseIf type = "Mage" Then
            intelligence = 100
            strength = 45
            cwight = 210
            currentWight = 0
            level = 0
            money = 900
            location = "Zanard"
        End If

    End Sub

    'functions that return the info of the player upon request

    Public Function getName()
        Return name
    End Function
    Public Function getClass()
        Return type
    End Function

    'functions that return player stats as set by the program
    Public Function getInt()
        Return intelligence
    End Function
    Public Function getStr()
        Return strength
    End Function
    Public Function getCW()
        Return cwight
    End Function
    Public Function getLvl()
        Return level
    End Function
    Public Function getMoney()
        Return money
    End Function
    Public Function getLocation()
        Return location
    End Function
    Public Function getCurrenWeight()
        Return currentWight
    End Function
    Public Function getxp()
        Return xp
    End Function
    Public Function getlvlxp()
        Return lvlxp
    End Function

    'function that deals with the leveling up of player 
    Public Sub lvlCheck()

        If xp > lvlxp And level >= 1 Then

            level = level + 1
            xp = xp - lvlxp
            lvlxp = level * 70
            currentWight = currentWight + 50

        ElseIf xp > lvlxp And level = 0 Then
            level = level + 1
            xp = xp - lvlxp
            lvlxp = 35
            currentWight = currentWight + 50


        End If

    End Sub

    Public Sub addxp(ByVal ep As Integer)

        xp = xp + ep

    End Sub

    'subroutines that chance internal valuse as the game goes on

    Public Sub addcoin(ByVal cash As Integer)

        money = money + cash

    End Sub

    Public Sub detractcoin(ByVal bill As Integer)

        money = money - bill

    End Sub
    Public Sub setCurrentWeight(ByVal x As Integer)

        currentWight = currentWight + x

    End Sub

    'subroutine responsible for tracking where the player is situated on the map
    Public Sub setLocation(ByVal crntLoc As String)
        location = crntLoc
    End Sub

    'subroutine that set the values of the player stats after the game has been loaded from a save file

    Public Sub loadSave(ByVal nme As String, ByVal typ As String, ByVal lvl As Integer, ByVal gold As Integer, ByVal exp As Integer, ByVal lvlexp As Integer, ByVal int As Integer, ByVal str As Integer, ByVal weightcap As Integer, ByVal weightcarry As Integer, ByVal place As String)

        name = nme
        type = typ
        money = gold
        xp = exp
        level = lvl
        lvlxp = lvlexp
        intelligence = int
        strength = str
        cwight = weightcap
        currentWight = weightcarry
        location = place

    End Sub

End Class
