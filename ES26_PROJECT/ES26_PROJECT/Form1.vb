Public Class frmRLC

    Private Sub frmRLC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnRPS.Click
        Me.Hide()
        frmRPS.Show()
    End Sub

    Private Sub btnSER_Click(sender As System.Object, e As System.EventArgs) Handles btnSER.Click
        Me.Hide()
        frmSER.Show()
    End Sub

    Private Sub btnPAR_Click(sender As System.Object, e As System.EventArgs) Handles btnPAR.Click
        Me.Hide()
        frmPAR.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show(vbTab & "This project aims to compute for the resonant frequency (fs)," & vbCrLf & " current (I), voltage (V), total Impedance (Zt), and quality factor (Qs) using " & vbCrLf & "the values of the Resistor (R), Inductor (L) and the Capacitor (C) supplied " & vbCrLf & "by the user. It also aims to graph the behavior of both the inductor and the capacitor.", "The RLC Analyzer")
    End Sub

End Class
