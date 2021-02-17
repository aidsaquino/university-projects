<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPS))
        Me.btnRock = New System.Windows.Forms.Button()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.lblVS = New System.Windows.Forms.Label()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRock
        '
        Me.btnRock.BackgroundImage = CType(resources.GetObject("btnRock.BackgroundImage"), System.Drawing.Image)
        Me.btnRock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRock.ForeColor = System.Drawing.Color.Purple
        Me.btnRock.Location = New System.Drawing.Point(12, 161)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(70, 70)
        Me.btnRock.TabIndex = 0
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.White
        Me.pic1.Location = New System.Drawing.Point(22, 67)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(70, 70)
        Me.pic1.TabIndex = 3
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.BackColor = System.Drawing.Color.White
        Me.pic2.Location = New System.Drawing.Point(193, 67)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(70, 70)
        Me.pic2.TabIndex = 4
        Me.pic2.TabStop = False
        '
        'lblVS
        '
        Me.lblVS.AutoSize = True
        Me.lblVS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVS.ForeColor = System.Drawing.Color.Black
        Me.lblVS.Location = New System.Drawing.Point(125, 77)
        Me.lblVS.Name = "lblVS"
        Me.lblVS.Size = New System.Drawing.Size(33, 31)
        Me.lblVS.TabIndex = 5
        Me.lblVS.Text = "V"
        '
        'btnPaper
        '
        Me.btnPaper.BackgroundImage = CType(resources.GetObject("btnPaper.BackgroundImage"), System.Drawing.Image)
        Me.btnPaper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaper.ForeColor = System.Drawing.Color.Purple
        Me.btnPaper.Location = New System.Drawing.Point(108, 161)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(70, 70)
        Me.btnPaper.TabIndex = 6
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'btnScissors
        '
        Me.btnScissors.BackgroundImage = CType(resources.GetObject("btnScissors.BackgroundImage"), System.Drawing.Image)
        Me.btnScissors.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScissors.ForeColor = System.Drawing.Color.Purple
        Me.btnScissors.Location = New System.Drawing.Point(202, 161)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(70, 70)
        Me.btnScissors.TabIndex = 7
        Me.btnScissors.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblResult.Location = New System.Drawing.Point(110, 117)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(68, 20)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "FIGHT!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(35, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "YOU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(217, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "AI"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'frmRPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.lblVS)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRPS"
        Me.Text = "Rock-Paper-Scissors"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblVS As System.Windows.Forms.Label
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents btnScissors As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
