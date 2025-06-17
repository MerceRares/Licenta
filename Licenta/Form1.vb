Public Class S
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height

            End If
            If score > 10 And score < 20 Then
                speed = 5
            End If
            If score > 20 And score < 30 Then
                speed = 6
            End If
            If score > 30 Then
                speed = 7
            End If
            Speed_Text.Text = "Viteza: " & speed
        Next
        If (Car.Bounds.IntersectsWith(EnemyCar1.Bounds)) Then
            gameOver()
        End If
        If (Car.Bounds.IntersectsWith(EnemyCar2.Bounds)) Then
            gameOver()
        End If
        If (Car.Bounds.IntersectsWith(EnemyCar3.Bounds)) Then
            gameOver()
        End If
    End Sub
    Private Sub gameOver()

        End_Text.Visible = True
        RoadMover.Stop()
        EnemyMover1.Stop()
        EnemyMover2.Stop()
        EnemyMover3.Stop()


    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            Right_mover.Start()
        End If
        If e.KeyCode = Keys.Left Then
            Left_mover.Start()
        End If
    End Sub

    Private Sub Right_mover_Tick(sender As Object, e As EventArgs) Handles Right_mover.Tick
        Car.Left += 5
    End Sub

    Private Sub Left_mover_Tick(sender As Object, e As EventArgs) Handles Left_mover.Tick
        Car.Left -= 5
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Right_mover.Stop()
        Left_mover.Stop()

    End Sub

    Private Sub EnemyMover1_Tick(sender As Object, e As EventArgs) Handles EnemyMover1.Tick
        EnemyCar1.Top += speed / 2
        If EnemyCar1.Top >= Me.Height Then
            score += 1
            Score_Text.Text = "Scor:" & score
            EnemyCar1.Top = -(CInt(Math.Ceiling(Rnd() * 335)) + EnemyCar1.Height)
            EnemyCar1.Left = CInt(Math.Ceiling(Rnd() * 100)) + 0
        End If
    End Sub

    Private Sub EnemyMover2_Tick(sender As Object, e As EventArgs) Handles EnemyMover2.Tick
        EnemyCar2.Top += 3

        If EnemyCar2.Top >= Me.Height Then
            score += 1
            Score_Text.Text = "Scor:" & score
            EnemyCar2.Top = -(CInt(Math.Ceiling(Rnd() * 335)) + EnemyCar2.Height)
            EnemyCar2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 150
        End If
    End Sub

    Private Sub EnemyMover3_Tick(sender As Object, e As EventArgs) Handles EnemyMover3.Tick
        EnemyCar3.Top += speed * 3 / 2
        If EnemyCar3.Top >= Me.Height Then
            score += 1
            Score_Text.Text = "Scor:" & score
            EnemyCar3.Top = -(CInt(Math.Ceiling(Rnd() * 335)) + EnemyCar3.Height)
            EnemyCar3.Left = CInt(Math.Ceiling(Rnd() * 35)) + 250
        End If
    End Sub

End Class
