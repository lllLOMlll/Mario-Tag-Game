Imports System.Runtime.Intrinsics.Arm

Public Class MarioGame
    Inherits Form

    Private Mario, Luigi, Boo As Characters
    Private MarioLosses As Integer = 0
    Private LuigiLosses As Integer = 0
    Private movement() As String = {"left", "right", "up", "down"}
    Private WithEvents GameTimer As New Timer()
    Shared borderWidth As Integer = 5
    Private gameOver As Boolean = False



    Public Sub New()
        ' Initialize components
        InitializeComponent()

        ' Initialize characters
        InitializeCharacters()

        ' Configure Timer
        ConfigureTimer()
    End Sub

    Private Sub InitializeCharacters()
        ' Initialize characters with images, sizes, and starting positions
        Mario = New Characters("Mario", New Point(30, 100), New Size(30, 30), My.Resources.mario)
        Luigi = New Characters("Luigi", New Point(30, 200), New Size(30, 30), My.Resources.luigi)
        Boo = New Characters("Boo", New Point(450, 150), New Size(30, 30), My.Resources.boo)

        ' Add characters to the Panel
        Panel1.Controls.Add(Mario)
        Panel1.Controls.Add(Luigi)
        Panel1.Controls.Add(Boo)

        ' Set the location relative to the Panel
        Mario.Location = New Point(30, 100)
        Luigi.Location = New Point(30, 200)
        Boo.Location = New Point(450, 150)
    End Sub


    Private Sub ConfigureTimer()
        Timer1.Interval = 200 ' Set the timer interval (in milliseconds)
        AddHandler Timer1.Tick, AddressOf GameTick
    End Sub

    Private Sub GameTick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Because I dont want the tick to continue if it's game over
        ' I had a problem. 2 looses instead of 1
        If gameOver Then Return
        Randomize()
        Dim r As Integer

        ' Adjust the boundary limits to be within the Panel and account for the border
        Dim borderWidth As Integer = 5
        Dim boundaryX As Integer = Panel1.Width - Mario.Width
        Dim boundaryY As Integer = Panel1.Height - Mario.Height

        r = CInt(Math.Floor(Rnd() * movement.Length))
        Boo.MoveCharacter(movement(r), boundaryX, boundaryY)

        r = CInt(Math.Floor(Rnd() * movement.Length))
        Mario.MoveCharacter(movement(r), boundaryX, boundaryY)

        r = CInt(Math.Floor(Rnd() * movement.Length))
        Luigi.MoveCharacter(movement(r), boundaryX, boundaryY)

        CheckCollisions()
    End Sub


    Private Sub CheckCollisions()
        If Boo.Bounds.IntersectsWith(Mario.Bounds) Then
            Timer1.Stop()
            gameOver = True
            MarioLosses += 1
            Label_Mario_Losses.Text = MarioLosses
            MsgBox("Mario loses!", MsgBoxStyle.Information, "Game Over")
            Return
        End If

        If Boo.Bounds.IntersectsWith(Luigi.Bounds) Then
            Timer1.Stop()
            gameOver = True
            LuigiLosses += 1
            Label_Luigi_Losses.Text = LuigiLosses
            MsgBox("Luigi loses!", MsgBoxStyle.Information, "Game Over")
            Return
        End If
    End Sub



    ' Start Game Button
    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        Timer1.Start()
    End Sub

    ' Stop Game Button
    Private Sub Button_Stop_Click(sender As Object, e As EventArgs) Handles Button_Stop.Click
        Timer1.Stop()
    End Sub

    ' New Game Button
    Private Sub Button_New_Game_Click(sender As Object, e As EventArgs) Handles Button_New_Game.Click
        'Reset the game over boolean
        gameOver = False
        'Clear the panel
        Panel1.Controls.Clear()
        'Add new characters
        InitializeCharacters()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim borderWidth As Integer = 5
        Dim borderColor As Color = Color.Red

        ' Create a pen with the desired border color and width
        Using borderPen As New Pen(borderColor, borderWidth)
            ' Adjust the rectangle to fit the border inside the panel
            Dim rect As New Rectangle(0, 0, Panel1.Width - borderWidth, Panel1.Height - borderWidth)

            ' Draw the rectangle border
            e.Graphics.DrawRectangle(borderPen, rect)
        End Using
    End Sub


    ' Characters class provided by your teacher

    Public Class Characters : Inherits Label
        Dim position As Point
        'constructor
        Public Sub New(ByVal name As String, ByVal location As Point, ByVal size As Size, ByVal face As Image)
            Me.Name = name
            Me.Size = size
            Me.Location = location
            Me.position = location
            Me.BackgroundImage = face
        End Sub
        ''' <summary>
        ''' get boundry and direction to change position (in form, location changes 
        ''' </summary>
        ''' <param name="direction"></param>
        ''' <param name="boundryX"></param>
        ''' <param name="boundryY"></param>
        Public Sub MoveCharacter(ByVal direction, ByVal boundaryX, ByVal boundaryY)
            Me.position = Me.Location ' Current position

            ' Calculate new position based on the direction
            Select Case direction
                Case "right"
                    If Me.position.X + Me.Size.Width + borderWidth <= boundaryX Then
                        Me.position.X += Me.Size.Width
                    End If
                Case "left"
                    If Me.position.X - Me.Size.Width >= borderWidth Then
                        Me.position.X -= Me.Size.Width
                    End If
                Case "up"
                    If Me.position.Y - Me.Size.Height >= borderWidth Then
                        Me.position.Y -= Me.Size.Height
                    End If
                Case "down"
                    If Me.position.Y + Me.Size.Height + borderWidth <= boundaryY Then
                        Me.position.Y += Me.Size.Height
                    End If
            End Select

            ' Update the location only if it's within the boundaries
            Me.Location = Me.position
        End Sub




    End Class

End Class


