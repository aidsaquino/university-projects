<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRLC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRLC))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSER = New System.Windows.Forms.Button()
        Me.btnPAR = New System.Windows.Forms.Button()
        Me.btnRPS = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(10, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please choose a type of Circuit:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'btnSER
        '
        Me.btnSER.BackgroundImage = CType(resources.GetObject("btnSER.BackgroundImage"), System.Drawing.Image)
        Me.btnSER.Image = CType(resources.GetObject("btnSER.Image"), System.Drawing.Image)
        Me.btnSER.Location = New System.Drawing.Point(70, 78)
        Me.btnSER.Name = "btnSER"
        Me.btnSER.Size = New System.Drawing.Size(138, 63)
        Me.btnSER.TabIndex = 2
        Me.btnSER.Text = "Series"
        Me.btnSER.UseVisualStyleBackColor = True
        '
        'btnPAR
        '
        Me.btnPAR.BackgroundImage = CType(resources.GetObject("btnPAR.BackgroundImage"), System.Drawing.Image)
        Me.btnPAR.Image = CType(resources.GetObject("btnPAR.Image"), System.Drawing.Image)
        Me.btnPAR.Location = New System.Drawing.Point(70, 147)
        Me.btnPAR.Name = "btnPAR"
        Me.btnPAR.Size = New System.Drawing.Size(138, 63)
        Me.btnPAR.TabIndex = 3
        Me.btnPAR.Text = "Parallel"
        Me.btnPAR.UseVisualStyleBackColor = True
        '
        'btnRPS
        '
        Me.btnRPS.BackColor = System.Drawing.Color.White
        Me.btnRPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRPS.Location = New System.Drawing.Point(70, 216)
        Me.btnRPS.Name = "btnRPS"
        Me.btnRPS.Size = New System.Drawing.Size(138, 23)
        Me.btnRPS.TabIndex = 4
        Me.btnRPS.Text = "Rock-Paper-Scissors"
        Me.btnRPS.UseVisualStyleBackColor = False
        '
        'frmRLC
        '
        Me.AcceptButton = Me.btnSER
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnRPS)
        Me.Controls.Add(Me.btnPAR)
        Me.Controls.Add(Me.btnSER)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRLC"
        Me.Text = "Resonant RLC Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSER As System.Windows.Forms.Button
    Friend WithEvents btnPAR As System.Windows.Forms.Button
    Friend WithEvents btnRPS As System.Windows.Forms.Button

End Class
