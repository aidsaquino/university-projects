Public Class frmPAR

    Dim R, Ri, Rp, L, C, V As Double
    Dim fs, fm, fp, f1, f2, I, Qs, BW As Double
    Dim blnPlot As Boolean
    Dim intXOrigin, intYOrigin As Integer

    Private Sub rdbRES_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdbRES1.CheckedChanged, rdbRES2.CheckedChanged, rdbRES3.CheckedChanged

        gboxR.BackColor = Color.Empty

    End Sub
    Private Sub rdbRi_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdbRi1.CheckedChanged, rdbRi2.CheckedChanged, rdbRi3.CheckedChanged

        gboxRi.BackColor = Color.Empty

    End Sub
    Private Sub rdbIND_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdbIND1.CheckedChanged, rdbIND2.CheckedChanged, rdbIND3.CheckedChanged

        gboxL.BackColor = Color.Empty

    End Sub
    Private Sub rdbCAP_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdbCAP1.CheckedChanged, rdbCAP2.CheckedChanged, rdbCAP3.CheckedChanged

        gboxC.BackColor = Color.Empty

    End Sub
    Private Sub rdbVOL_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdbVOL1.CheckedChanged, rdbVOL2.CheckedChanged, rdbVOL3.CheckedChanged

        gboxV.BackColor = Color.Empty

    End Sub

    Private Sub btnMENU_Click(sender As System.Object, e As System.EventArgs) 'option to return to menu
        Me.Hide()
        frmRLC.Show()
    End Sub

    Private Sub btnCLEAR_Click(sender As System.Object, e As System.EventArgs) Handles btnCLEAR.Click

        txtR.Clear() 'clears all the textboxes
        txtRi.Clear()
        txtL.Clear()
        txtC.Clear()
        txtV.Clear()
        txtI.Clear()
        txtQS.Clear()
        txtBW.Clear()

        lblFS.Text = "The circuit is ideally resonant at f =" 'restores labels into default
        lblFP.Text = "The circuit is actually resonant at f ="
        lblFM.Text = "The circuit has Zmax at f ="

        rdbRES1.Checked = False 'unchecks the rdbs
        rdbRES2.Checked = False
        rdbRES3.Checked = False

        rdbRi1.Checked = False
        rdbRi2.Checked = False
        rdbRi3.Checked = False

        rdbIND1.Checked = False
        rdbIND2.Checked = False
        rdbIND3.Checked = False

        rdbCAP1.Checked = False
        rdbCAP2.Checked = False
        rdbCAP3.Checked = False

        rdbVOL1.Checked = False
        rdbVOL2.Checked = False
        rdbVOL3.Checked = False

        txtR.Focus()

        blnPlot = False
        picDraw.Refresh()

    End Sub

    Private Sub btnCOMP_Click(sender As System.Object, e As System.EventArgs) Handles btnCOMP.Click
        Try
            If IsNumeric(txtR.Text) Then    'checks whether R is numeric or not
                If IsNumeric(txtRi.Text) Then   'checks whether Ri is numeric or not
                    If IsNumeric(txtL.Text) Then    'checks whether L is numeric or not
                        If IsNumeric(txtC.Text) Then    'checks whether C is numeric or not
                            If IsNumeric(txtV.Text) Then    'checks whether V is numeric or not

                                Select Case True                'declaring variable R
                                    Case rdbRES1.Checked
                                        R = txtR.Text
                                    Case rdbRES2.Checked
                                        R = (txtR.Text) * (10 ^ (-3))
                                    Case rdbRES3.Checked
                                        R = (txtR.Text) * (10 ^ (-6))
                                    Case Else
                                        MessageBox.Show("Please select a unit for the resistance.", "Error")
                                        gboxR.BackColor = Color.Yellow
                                End Select

                                Select Case True                'declaring variable Ri
                                    Case rdbRi1.Checked
                                        Ri = txtRi.Text
                                    Case rdbRi2.Checked
                                        Ri = (txtRi.Text) * (10 ^ (-3))
                                    Case rdbRi3.Checked
                                        Ri = (txtRi.Text) * (10 ^ (-6))
                                    Case Else
                                        MessageBox.Show("Please select a unit for the internal resistance.", "Error")
                                        gboxRi.BackColor = Color.Yellow
                                End Select

                                Select Case True            'declaring variable L
                                    Case rdbIND1.Checked
                                        L = txtL.Text
                                    Case rdbIND2.Checked
                                        L = (txtL.Text) * (10 ^ (-3))
                                    Case rdbIND3.Checked
                                        L = (txtL.Text) * (10 ^ (-6))
                                    Case Else
                                        MessageBox.Show("Please select a unit for the inductance.", "Error")
                                        gboxL.BackColor = Color.Yellow  'highlights the groupbox if nothing is checked
                                End Select

                                Select Case True            'declaring variable C
                                    Case rdbCAP1.Checked
                                        C = txtC.Text
                                    Case rdbCAP2.Checked
                                        C = (txtC.Text) * (10 ^ (-3))
                                    Case rdbCAP3.Checked
                                        C = (txtC.Text) * (10 ^ (-6))
                                    Case Else
                                        MessageBox.Show("Please select a unit for the capacitance.", "Error")
                                        gboxC.BackColor = Color.Yellow
                                End Select

                                Select Case True            'declaring variable V
                                    Case rdbVOL1.Checked
                                        V = txtV.Text
                                    Case rdbVOL2.Checked
                                        V = (txtV.Text) * (10 ^ (-3))
                                    Case rdbVOL3.Checked
                                        V = (txtV.Text) * (10 ^ (-6))
                                    Case Else
                                        MessageBox.Show("Please select a unit for the voltage.", "Error")
                                        gboxV.BackColor = Color.Yellow
                                End Select

                                fs = 1 / (2 * (Math.PI) * Math.Sqrt(L * C))
                                fp = fs * Math.Sqrt(1 - (Ri ^ 2) * (C / L))
                                fm = fs * Math.Sqrt(1 - ((Ri ^ 2) / 4) * (C / L))
                                Rp = ((Ri ^ 2) + ((1 / (2 * Math.PI * fs * C)) ^ 2)) / Ri

                                I = V / (R + Rp)
                                Qs = (R + Rp) / (1 / (2 * Math.PI * fs * C))
                                f2 = (1 / (2 * Math.PI)) * (((R + Rp) / 2 * L) + (1 / 2) * Math.Sqrt((((R + Rp) / L) ^ 2) + (4 / (L * C))))
                                f1 = (1 / (2 * Math.PI)) * (-1 * ((R + Rp) / 2 * L) + (1 / 2) * Math.Sqrt((((R + Rp) / L) ^ 2) + (4 / (L * C))))
                                BW = f2 - f1


                                lblFS.Text = "The circuit is ideally resonant at f =" & Math.Round(fs, 4) & " kHz"
                                lblFP.Text = "The circuit is actually resonant at f =" & Math.Round(fp, 4) & " kHz"
                                lblFM.Text = "The circuit has Zmax at f =" & Math.Round(fm, 4) & " kHz"
                                txtI.Text = Math.Round(I, 4)
                                txtQS.Text = Math.Round(Qs, 4)
                                txtBW.Text = Math.Round(BW, 4)


                            Else
                                MessageBox.Show("Please input a valid data for your voltage.", "Invalid Input")
                                txtV.Clear()
                                txtV.Focus()
                            End If

                        Else
                            MessageBox.Show("Please input a valid data for your capacitance.", "Invalid Input")
                            txtC.Clear()
                            txtC.Focus()
                        End If

                    Else
                        MessageBox.Show("Please input a valid data for your inductance.", "Invalid Input")
                        txtL.Clear()
                        txtL.Focus()
                    End If

                Else
                    MessageBox.Show("Please input a valid data for your internal resistance.", "Invalid Input")
                    txtRi.Clear()
                    txtRi.Focus()
                End If
            Else
                MessageBox.Show("Please input a valid data for your resistance.", "Invalid Input")
                txtR.Clear()
                txtR.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnPLOT.Click
        Try

            If btnPLOT.Text = "Show Graph >>>" Then 'shows or hides the graph, for convinience and added appeal
                Me.Width = 684
                blnPlot = True
                picDraw.Refresh()
                btnPLOT.Text = "Hide Graph <<<"

            ElseIf btnPLOT.Text = "Hide Graph <<<" Then
                Me.Width = 343
                blnPlot = False
                picDraw.Refresh()
                btnPLOT.Text = "Show Graph >>>"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DrawAxes(ByVal g As Graphics)

        intXOrigin = picDraw.Width \ 10 'assigns the x-origin at the tenth of the Width
        intYOrigin = picDraw.Height * (9 / 10) 'assigns the y-originat the upper tenth of PicDraw Height

        Dim myfont As New Font("Arial", 8, FontStyle.Regular)
        g.Clear(Color.Black)
        g.DrawLine(Pens.Gray, 0, intYOrigin, picDraw.Width, intYOrigin) 'draw x-axis
        g.DrawLine(Pens.Gray, intXOrigin, 0, intXOrigin, picDraw.Height) 'draw y-axis
        g.DrawString("(0, 0)", myfont, Brushes.Gray, intXOrigin, intYOrigin) 'add label to origin
        g.DrawString("graph of the function" & vbNewLine & "Xc = 1/2πfC", myfont, Brushes.Goldenrod, intXOrigin, 0)
        g.DrawString("graph of the function" & vbNewLine & "Xl = 2πfL", myfont, Brushes.DarkTurquoise, intXOrigin, 25)
    End Sub
    Private Sub PicDraw_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles picDraw.Paint
        Dim gPaint As Graphics = e.Graphics 'creates the graphics object
        Try
            Select Case True
                Case blnPlot
                    Call DrawAxes(gPaint) 'draw axes
                    Dim sngStep As Single = 0.05 'drawing interval
                    Dim sngY, sngY2 As Single

                    For sngX As Single = 0 To (picDraw.Width * (9 / 10)) Step sngStep
                        If sngX = 0 Then
                            sngY = 0
                            sngY2 = 0
                        Else
                            sngY = 2 * Math.PI * sngX * L
                            sngY2 = 1 / (2 * Math.PI * sngX * C)

                            gPaint.DrawRectangle(Pens.DarkTurquoise, intXOrigin + sngX, intYOrigin - sngY, 1, 1)
                            gPaint.DrawRectangle(Pens.Goldenrod, intXOrigin + sngX, intYOrigin - sngY2, 1, 1)

                        End If
                    Next

                Case Else
                    gPaint.Clear(Color.Black) 'clearing of all graphics
                    Call DrawAxes(gPaint) 'drawing of axes
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnMENU_Click_1(sender As System.Object, e As System.EventArgs) Handles btnMENU.Click
        Me.Hide()
        frmRLC.Show()
    End Sub
End Class