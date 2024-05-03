Public Class frm2Dplatformer
    Dim moveSpeed As Integer = 10
    Dim isJumping As Boolean
    Dim score As Integer
    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Start()
            Case Keys.Left
                TmrLeft.Start()
            Case Keys.Up
                TmrUp.Start()
                isJumping = True
        End Select
    End Sub
    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        PicPlayer.Left += moveSpeed
    End Sub
    Private Sub frm2Dplatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Stop()
            Case Keys.Left
                TmrLeft.Stop()
            Case Keys.Up
                TmrUp.Stop()
                isJumping = False
        End Select
    End Sub
    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        PicPlayer.Left -= moveSpeed
    End Sub
    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles TmrUp.Tick
        PicPlayer.Top -= moveSpeed
    End Sub
    Private Sub frm2Dplatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrGameLogic.Start()
    End Sub
    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles TmrGameLogic.Tick
        If PicPlayer.Bounds.IntersectsWith(PicGround.Bounds) Then
            TmrGravity.Stop()
        Else
            If isJumping = False Then
                TmrGravity.Start()
            End If
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        TmrGravity.Stop()
                    End If
                End If
            End If
            If TypeOf b Is PictureBox Then
                If b.Tag = "restart" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        PicPlayer.Location = PictureBox16.Location
                        PictureBox6.Visible = True
                        PictureBox7.Visible = True
                        PictureBox8.Visible = True
                        PictureBox9.Visible = True
                        PictureBox10.Visible = True
                        PictureBox11.Visible = True
                        PictureBox12.Visible = True
                        PictureBox14.Visible = True
                        ProgressBar1.Value -= 25
                        score = 0
                        ScoreLabel.Text = score
                    End If
                End If
            End If
            If TypeOf b Is PictureBox Then
                If b.Tag = "collectable" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) And b.Visible = True Then
                        b.Visible = False
                        score += 1
                        ScoreLabel.Text = score
                        ScoreLabel.Visible = True
                    End If
                End If
            End If
        Next
        If score = 8 Then
            Label3.Visible = True
            ResetB.Visible = True
            moveSpeed = 0
        End If
        If ProgressBar1.Value = 0 Then
            Label2.Visible = True
            ResetB.Visible = True
            moveSpeed = 0
        End If
    End Sub
    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles TmrGravity.Tick
        PicPlayer.Top += moveSpeed
    End Sub

    Private Sub ResetB_Click(sender As Object, e As EventArgs) Handles ResetB.Click
        ProgressBar1.Value = 100
        ResetB.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        moveSpeed = 10
        PicPlayer.Location = PictureBox16.Location
        score = 0
        ScoreLabel.Text = score
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = True
        PictureBox9.Visible = True
        PictureBox10.Visible = True
        PictureBox11.Visible = True
        PictureBox12.Visible = True
        PictureBox14.Visible = True
    End Sub
End Class