Public Class frmRPS

    Dim myhand, opp As Integer
    Dim x As Single
    Private Sub frmRPS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load 'initial state

        pic1.Image = Nothing
        pic2.Image = Nothing
        lblVS.Text = "V"
        lblResult.Text = "Fight!"

    End Sub

    Private Sub btnRock_Click(sender As System.Object, e As System.EventArgs) Handles btnRock.Click

        myhand = 1
        x = Rnd()
        opp = (x * 10) Mod 3

        pic1.Image = btnRock.BackgroundImage

        Select Case True
            Case opp = 0
                pic2.Image = btnScissors.BackgroundImage
            Case opp = 1
                pic2.Image = btnRock.BackgroundImage
            Case opp = 2
                pic2.Image = btnPaper.BackgroundImage
        End Select

        Select Case True
            Case myhand = opp
                lblVS.Text = "="
                Dim ans As MsgBoxResult
                ans = MsgBox("It's a Draw! Try Again?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "The Decision")

                If ans = MsgBoxResult.Yes Then
                    pic1.Image = Nothing
                    pic2.Image = Nothing
                    lblVS.Text = "V"

                ElseIf ans = MsgBoxResult.No Then
                    Me.Hide()
                    frmRLC.Show()
                End If

            Case myhand > opp
                lblVS.Text = ">"
                Dim ans As MsgBoxResult
                ans = MsgBox("You Win! Try Again?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "The Decision")

                If ans = MsgBoxResult.Yes Then
                    pic1.Image = Nothing
                    pic2.Image = Nothing
                    lblVS.Text = "V"

                ElseIf ans = MsgBoxResult.No Then
                    Me.Hide()
                    frmRLC.Show()
                End If

            Case myhand < opp
                lblVS.Text = "<"
                Dim ans As MsgBoxResult
                ans = MsgBox("You Lose! Try Again?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "The Decision")

                If ans = MsgBoxResult.Yes Then
                    pic1.Image = Nothing
                    pic2.Image = Nothing
                    lblVS.Text = "V"

                ElseIf ans = MsgBoxResult.No Then
                    Me.Hide()
                    frmRLC.Show()
                End If

        End Select
    End Sub

    Private Sub btnPaper_Click(sender As System.Object, e As System.EventArgs) Handles btnPaper.Click
        myhand = 1
        x = Rnd()
        opp = (x * 10) Mod 3

        pic1.Image = btnPaper.BackgroundImage

        Select Case True
            Case opp = 0
                pic2.Image = btnRock.BackgroundImage
            Case opp = 1
                pic2.Image = btnPaper.BackgroundImage
            Case opp = 2
                pic2.Image = btnScissors.BackgroundImage
        End Select

        Select Case True
            Case myhand = opp
                lblVS.Text = "="
                Dim ans As MsgBoxResult
                ans = MsgBox("It's a Draw! Try Again?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "The Decision")

                If ans = MsgBoxResult.Yes Then
                    pic1.Image = Nothing
                    pic2.Image = Nothing
                    lblVS.Text = "V"

                ElseIf ans = MsgBoxResult.No Then
                    Me.Hide()
                    frmRLC.Show()
                End If

            Case myhand > opp
                lblVS.Text = ">"
                Dim ans As MsgBoxResult
                ans = MsgBox("You Win! Try Again?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "The Decision")

                If ans = MsgBoxResult.Yes Then
                    pic1.Image = Nothing
                    pic2.Image = Nothing
                    lblVS.Text = "V"

                ElseIf ans = MsgBoxResult.No Then
                    Me.Hide()
                    frmRLC.Show()
                End If

            Case myhand < opp
                lblVS.Text = "<"
                Dim ans As MsgBoxResult
                ans = MsgBox("You Lose! Try Again?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "The Decision")

                If ans = MsgBoxResult.Yes Then
                    pic1.Image = Nothing
                    pic2.Image = Nothing
                    lblVS.Text = "V"

                ElseIf ans = MsgBoxResult.No Then
                    Me.Hide()
                    frmRLC.Show()
                End If

        End Select
    End Sub

    Private Sub btnScissors_Click(sender As System.Object, e As System.EventArgs) Handles btnScissors.Click
        myhand = 1
        x = Rnd()
        opp = (x * 10) Mod 3

        pic1.Image = btnScissors.BackgroundImage

        Select Case True
            Case opp = 0
                pic2.Image = btnPaper.BackgroundImage
            Case opp = 1
                pic2.Image = btnScissors.BackgroundImage
            Case opp = 2
                pic2.Image = btnRock.BackgroundImage
        End Select

        Select Case True
            Case myhand = opp
                lblVS.Text = "="
                Dim ans As MsgBoxResult
                ans = MsgBox("It's a Draw! Try Again?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "The Decision")

                If ans = MsgBoxResult.Yes Then
                    pic1.Image = Nothing
                    pic2.Image = Nothing
                    lblVS.Text = "V"

                ElseIf ans = MsgBoxResult.No Then
                    Me.Hide()
                    frmRLC.Show()
                End If

            Case myhand > opp
                lblVS.Text = ">"
                Dim ans As MsgBoxResult
                ans = MsgBox("You Win! Try Again?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "The Decision")

                If ans = MsgBoxResult.Yes Then
                    pic1.Image = Nothing
                    pic2.Image = Nothing
                    lblVS.Text = "V"

                ElseIf ans = MsgBoxResult.No Then
                    Me.Hide()
                    frmRLC.Show()
                End If

            Case myhand < opp
                lblVS.Text = "<"
                Dim ans As MsgBoxResult
                ans = MsgBox("You Lose! Try Again?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "The Decision")

                If ans = MsgBoxResult.Yes Then
                    pic1.Image = Nothing
                    pic2.Image = Nothing
                    lblVS.Text = "V"

                ElseIf ans = MsgBoxResult.No Then
                    Me.Hide()
                    frmRLC.Show()
                End If

        End Select
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        Me.Hide()
        frmRLC.Show()
    End Sub
End Class