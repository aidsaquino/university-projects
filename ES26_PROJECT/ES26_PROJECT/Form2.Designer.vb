<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSER
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
        Me.gboxIN = New System.Windows.Forms.GroupBox()
        Me.gboxV = New System.Windows.Forms.GroupBox()
        Me.rdbVOL1 = New System.Windows.Forms.RadioButton()
        Me.rdbVOL2 = New System.Windows.Forms.RadioButton()
        Me.rdbVOL3 = New System.Windows.Forms.RadioButton()
        Me.lblV = New System.Windows.Forms.Label()
        Me.gboxC = New System.Windows.Forms.GroupBox()
        Me.rdbCAP1 = New System.Windows.Forms.RadioButton()
        Me.rdbCAP2 = New System.Windows.Forms.RadioButton()
        Me.rdbCAP3 = New System.Windows.Forms.RadioButton()
        Me.gboxL = New System.Windows.Forms.GroupBox()
        Me.rdbIND1 = New System.Windows.Forms.RadioButton()
        Me.rdbIND2 = New System.Windows.Forms.RadioButton()
        Me.rdbIND3 = New System.Windows.Forms.RadioButton()
        Me.gboxR = New System.Windows.Forms.GroupBox()
        Me.rdbRES3 = New System.Windows.Forms.RadioButton()
        Me.rdbRES2 = New System.Windows.Forms.RadioButton()
        Me.rdbRES1 = New System.Windows.Forms.RadioButton()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.txtV = New System.Windows.Forms.TextBox()
        Me.lblR = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.btnCOMP = New System.Windows.Forms.Button()
        Me.btnPLOT = New System.Windows.Forms.Button()
        Me.pboxG = New System.Windows.Forms.PictureBox()
        Me.btnCLEAR = New System.Windows.Forms.Button()
        Me.btnMENU = New System.Windows.Forms.Button()
        Me.picDraw = New System.Windows.Forms.PictureBox()
        Me.lblFS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtI = New System.Windows.Forms.TextBox()
        Me.txtBW = New System.Windows.Forms.TextBox()
        Me.txtQS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gboxOUT = New System.Windows.Forms.GroupBox()
        Me.gboxIN.SuspendLayout()
        Me.gboxV.SuspendLayout()
        Me.gboxC.SuspendLayout()
        Me.gboxL.SuspendLayout()
        Me.gboxR.SuspendLayout()
        CType(Me.pboxG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxOUT.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxIN
        '
        Me.gboxIN.Controls.Add(Me.gboxV)
        Me.gboxIN.Controls.Add(Me.lblV)
        Me.gboxIN.Controls.Add(Me.gboxC)
        Me.gboxIN.Controls.Add(Me.gboxL)
        Me.gboxIN.Controls.Add(Me.gboxR)
        Me.gboxIN.Controls.Add(Me.lblC)
        Me.gboxIN.Controls.Add(Me.lblL)
        Me.gboxIN.Controls.Add(Me.txtV)
        Me.gboxIN.Controls.Add(Me.lblR)
        Me.gboxIN.Controls.Add(Me.txtC)
        Me.gboxIN.Controls.Add(Me.txtL)
        Me.gboxIN.Controls.Add(Me.txtR)
        Me.gboxIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxIN.Location = New System.Drawing.Point(12, 12)
        Me.gboxIN.Name = "gboxIN"
        Me.gboxIN.Size = New System.Drawing.Size(309, 169)
        Me.gboxIN.TabIndex = 0
        Me.gboxIN.TabStop = False
        Me.gboxIN.Text = "Input"
        '
        'gboxV
        '
        Me.gboxV.Controls.Add(Me.rdbVOL1)
        Me.gboxV.Controls.Add(Me.rdbVOL2)
        Me.gboxV.Controls.Add(Me.rdbVOL3)
        Me.gboxV.Location = New System.Drawing.Point(113, 123)
        Me.gboxV.Name = "gboxV"
        Me.gboxV.Size = New System.Drawing.Size(188, 34)
        Me.gboxV.TabIndex = 20
        Me.gboxV.TabStop = False
        '
        'rdbVOL1
        '
        Me.rdbVOL1.AutoSize = True
        Me.rdbVOL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbVOL1.Location = New System.Drawing.Point(29, 11)
        Me.rdbVOL1.Name = "rdbVOL1"
        Me.rdbVOL1.Size = New System.Drawing.Size(32, 17)
        Me.rdbVOL1.TabIndex = 17
        Me.rdbVOL1.Text = "V"
        Me.rdbVOL1.UseVisualStyleBackColor = True
        '
        'rdbVOL2
        '
        Me.rdbVOL2.AutoSize = True
        Me.rdbVOL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbVOL2.Location = New System.Drawing.Point(76, 11)
        Me.rdbVOL2.Name = "rdbVOL2"
        Me.rdbVOL2.Size = New System.Drawing.Size(40, 17)
        Me.rdbVOL2.TabIndex = 18
        Me.rdbVOL2.Text = "mV"
        Me.rdbVOL2.UseVisualStyleBackColor = True
        '
        'rdbVOL3
        '
        Me.rdbVOL3.AutoSize = True
        Me.rdbVOL3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbVOL3.Location = New System.Drawing.Point(129, 11)
        Me.rdbVOL3.Name = "rdbVOL3"
        Me.rdbVOL3.Size = New System.Drawing.Size(38, 17)
        Me.rdbVOL3.TabIndex = 19
        Me.rdbVOL3.Text = "μV"
        Me.rdbVOL3.UseVisualStyleBackColor = True
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV.Location = New System.Drawing.Point(8, 136)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(23, 13)
        Me.lblV.TabIndex = 19
        Me.lblV.Text = "V :"
        '
        'gboxC
        '
        Me.gboxC.Controls.Add(Me.rdbCAP1)
        Me.gboxC.Controls.Add(Me.rdbCAP2)
        Me.gboxC.Controls.Add(Me.rdbCAP3)
        Me.gboxC.Location = New System.Drawing.Point(113, 89)
        Me.gboxC.Name = "gboxC"
        Me.gboxC.Size = New System.Drawing.Size(188, 34)
        Me.gboxC.TabIndex = 18
        Me.gboxC.TabStop = False
        '
        'rdbCAP1
        '
        Me.rdbCAP1.AutoSize = True
        Me.rdbCAP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCAP1.Location = New System.Drawing.Point(29, 11)
        Me.rdbCAP1.Name = "rdbCAP1"
        Me.rdbCAP1.Size = New System.Drawing.Size(31, 17)
        Me.rdbCAP1.TabIndex = 17
        Me.rdbCAP1.Text = "F"
        Me.rdbCAP1.UseVisualStyleBackColor = True
        '
        'rdbCAP2
        '
        Me.rdbCAP2.AutoSize = True
        Me.rdbCAP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCAP2.Location = New System.Drawing.Point(76, 11)
        Me.rdbCAP2.Name = "rdbCAP2"
        Me.rdbCAP2.Size = New System.Drawing.Size(39, 17)
        Me.rdbCAP2.TabIndex = 18
        Me.rdbCAP2.Text = "mF"
        Me.rdbCAP2.UseVisualStyleBackColor = True
        '
        'rdbCAP3
        '
        Me.rdbCAP3.AutoSize = True
        Me.rdbCAP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCAP3.Location = New System.Drawing.Point(129, 11)
        Me.rdbCAP3.Name = "rdbCAP3"
        Me.rdbCAP3.Size = New System.Drawing.Size(37, 17)
        Me.rdbCAP3.TabIndex = 19
        Me.rdbCAP3.Text = "μF"
        Me.rdbCAP3.UseVisualStyleBackColor = True
        '
        'gboxL
        '
        Me.gboxL.Controls.Add(Me.rdbIND1)
        Me.gboxL.Controls.Add(Me.rdbIND2)
        Me.gboxL.Controls.Add(Me.rdbIND3)
        Me.gboxL.Location = New System.Drawing.Point(113, 55)
        Me.gboxL.Name = "gboxL"
        Me.gboxL.Size = New System.Drawing.Size(188, 34)
        Me.gboxL.TabIndex = 17
        Me.gboxL.TabStop = False
        '
        'rdbIND1
        '
        Me.rdbIND1.AutoSize = True
        Me.rdbIND1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbIND1.Location = New System.Drawing.Point(28, 11)
        Me.rdbIND1.Name = "rdbIND1"
        Me.rdbIND1.Size = New System.Drawing.Size(33, 17)
        Me.rdbIND1.TabIndex = 14
        Me.rdbIND1.Text = "H"
        Me.rdbIND1.UseVisualStyleBackColor = True
        '
        'rdbIND2
        '
        Me.rdbIND2.AutoSize = True
        Me.rdbIND2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbIND2.Location = New System.Drawing.Point(75, 11)
        Me.rdbIND2.Name = "rdbIND2"
        Me.rdbIND2.Size = New System.Drawing.Size(41, 17)
        Me.rdbIND2.TabIndex = 15
        Me.rdbIND2.Text = "mH"
        Me.rdbIND2.UseVisualStyleBackColor = True
        '
        'rdbIND3
        '
        Me.rdbIND3.AutoSize = True
        Me.rdbIND3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbIND3.Location = New System.Drawing.Point(128, 11)
        Me.rdbIND3.Name = "rdbIND3"
        Me.rdbIND3.Size = New System.Drawing.Size(39, 17)
        Me.rdbIND3.TabIndex = 16
        Me.rdbIND3.Text = "μH"
        Me.rdbIND3.UseVisualStyleBackColor = True
        '
        'gboxR
        '
        Me.gboxR.Controls.Add(Me.rdbRES3)
        Me.gboxR.Controls.Add(Me.rdbRES2)
        Me.gboxR.Controls.Add(Me.rdbRES1)
        Me.gboxR.Location = New System.Drawing.Point(112, 19)
        Me.gboxR.Name = "gboxR"
        Me.gboxR.Size = New System.Drawing.Size(188, 34)
        Me.gboxR.TabIndex = 11
        Me.gboxR.TabStop = False
        '
        'rdbRES3
        '
        Me.rdbRES3.AutoSize = True
        Me.rdbRES3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRES3.Location = New System.Drawing.Point(129, 11)
        Me.rdbRES3.Name = "rdbRES3"
        Me.rdbRES3.Size = New System.Drawing.Size(40, 17)
        Me.rdbRES3.TabIndex = 16
        Me.rdbRES3.Text = "μΩ"
        Me.rdbRES3.UseVisualStyleBackColor = True
        '
        'rdbRES2
        '
        Me.rdbRES2.AutoSize = True
        Me.rdbRES2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRES2.Location = New System.Drawing.Point(76, 11)
        Me.rdbRES2.Name = "rdbRES2"
        Me.rdbRES2.Size = New System.Drawing.Size(42, 17)
        Me.rdbRES2.TabIndex = 15
        Me.rdbRES2.Text = "mΩ"
        Me.rdbRES2.UseVisualStyleBackColor = True
        '
        'rdbRES1
        '
        Me.rdbRES1.AutoSize = True
        Me.rdbRES1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRES1.Location = New System.Drawing.Point(29, 11)
        Me.rdbRES1.Name = "rdbRES1"
        Me.rdbRES1.Size = New System.Drawing.Size(34, 17)
        Me.rdbRES1.TabIndex = 14
        Me.rdbRES1.Text = "Ω"
        Me.rdbRES1.UseVisualStyleBackColor = True
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(8, 102)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(23, 13)
        Me.lblC.TabIndex = 5
        Me.lblC.Text = "C :"
        '
        'lblL
        '
        Me.lblL.AutoSize = True
        Me.lblL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL.Location = New System.Drawing.Point(8, 68)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(22, 13)
        Me.lblL.TabIndex = 4
        Me.lblL.Text = "L :"
        '
        'txtV
        '
        Me.txtV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtV.Location = New System.Drawing.Point(38, 133)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(61, 20)
        Me.txtV.TabIndex = 6
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.Location = New System.Drawing.Point(8, 32)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(24, 13)
        Me.lblR.TabIndex = 3
        Me.lblR.Text = "R :"
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(38, 99)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(61, 20)
        Me.txtC.TabIndex = 3
        '
        'txtL
        '
        Me.txtL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL.Location = New System.Drawing.Point(38, 65)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(61, 20)
        Me.txtL.TabIndex = 2
        '
        'txtR
        '
        Me.txtR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtR.Location = New System.Drawing.Point(38, 29)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(61, 20)
        Me.txtR.TabIndex = 1
        '
        'btnCOMP
        '
        Me.btnCOMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCOMP.Location = New System.Drawing.Point(12, 187)
        Me.btnCOMP.Name = "btnCOMP"
        Me.btnCOMP.Size = New System.Drawing.Size(61, 23)
        Me.btnCOMP.TabIndex = 4
        Me.btnCOMP.Text = "Compute"
        Me.btnCOMP.UseVisualStyleBackColor = False
        '
        'btnPLOT
        '
        Me.btnPLOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPLOT.Location = New System.Drawing.Point(213, 187)
        Me.btnPLOT.Name = "btnPLOT"
        Me.btnPLOT.Size = New System.Drawing.Size(108, 23)
        Me.btnPLOT.TabIndex = 7
        Me.btnPLOT.Text = "Show Graph >>>"
        Me.btnPLOT.UseVisualStyleBackColor = False
        '
        'pboxG
        '
        Me.pboxG.Location = New System.Drawing.Point(327, 12)
        Me.pboxG.Name = "pboxG"
        Me.pboxG.Size = New System.Drawing.Size(329, 351)
        Me.pboxG.TabIndex = 10
        Me.pboxG.TabStop = False
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCLEAR.Location = New System.Drawing.Point(79, 187)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(61, 23)
        Me.btnCLEAR.TabIndex = 5
        Me.btnCLEAR.Text = "Clear"
        Me.btnCLEAR.UseVisualStyleBackColor = False
        '
        'btnMENU
        '
        Me.btnMENU.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMENU.Location = New System.Drawing.Point(146, 187)
        Me.btnMENU.Name = "btnMENU"
        Me.btnMENU.Size = New System.Drawing.Size(61, 23)
        Me.btnMENU.TabIndex = 6
        Me.btnMENU.Text = "Menu"
        Me.btnMENU.UseVisualStyleBackColor = False
        '
        'picDraw
        '
        Me.picDraw.BackColor = System.Drawing.Color.Black
        Me.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDraw.Location = New System.Drawing.Point(327, 12)
        Me.picDraw.Name = "picDraw"
        Me.picDraw.Size = New System.Drawing.Size(329, 351)
        Me.picDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDraw.TabIndex = 11
        Me.picDraw.TabStop = False
        '
        'lblFS
        '
        Me.lblFS.AutoSize = True
        Me.lblFS.Location = New System.Drawing.Point(8, 26)
        Me.lblFS.Name = "lblFS"
        Me.lblFS.Size = New System.Drawing.Size(168, 13)
        Me.lblFS.TabIndex = 0
        Me.lblFS.Text = "The circuit is resonant at f ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Current at Resonance( I ) :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bandwidth (BW):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Quality Factor ( Qs ) :"
        '
        'txtI
        '
        Me.txtI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtI.Location = New System.Drawing.Point(201, 58)
        Me.txtI.Name = "txtI"
        Me.txtI.ReadOnly = True
        Me.txtI.Size = New System.Drawing.Size(51, 20)
        Me.txtI.TabIndex = 5
        '
        'txtBW
        '
        Me.txtBW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBW.Location = New System.Drawing.Point(201, 85)
        Me.txtBW.Name = "txtBW"
        Me.txtBW.ReadOnly = True
        Me.txtBW.Size = New System.Drawing.Size(51, 20)
        Me.txtBW.TabIndex = 7
        '
        'txtQS
        '
        Me.txtQS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQS.Location = New System.Drawing.Point(201, 111)
        Me.txtQS.Name = "txtQS"
        Me.txtQS.ReadOnly = True
        Me.txtQS.Size = New System.Drawing.Size(51, 20)
        Me.txtQS.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(258, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "A"
        '
        'gboxOUT
        '
        Me.gboxOUT.Controls.Add(Me.Label8)
        Me.gboxOUT.Controls.Add(Me.txtQS)
        Me.gboxOUT.Controls.Add(Me.txtBW)
        Me.gboxOUT.Controls.Add(Me.txtI)
        Me.gboxOUT.Controls.Add(Me.Label5)
        Me.gboxOUT.Controls.Add(Me.Label4)
        Me.gboxOUT.Controls.Add(Me.Label2)
        Me.gboxOUT.Controls.Add(Me.lblFS)
        Me.gboxOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxOUT.Location = New System.Drawing.Point(12, 216)
        Me.gboxOUT.Name = "gboxOUT"
        Me.gboxOUT.Size = New System.Drawing.Size(309, 147)
        Me.gboxOUT.TabIndex = 6
        Me.gboxOUT.TabStop = False
        Me.gboxOUT.Text = "Output"
        '
        'frmSER
        '
        Me.AcceptButton = Me.btnCOMP
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 372)
        Me.Controls.Add(Me.picDraw)
        Me.Controls.Add(Me.btnMENU)
        Me.Controls.Add(Me.btnCLEAR)
        Me.Controls.Add(Me.pboxG)
        Me.Controls.Add(Me.btnPLOT)
        Me.Controls.Add(Me.btnCOMP)
        Me.Controls.Add(Me.gboxOUT)
        Me.Controls.Add(Me.gboxIN)
        Me.Name = "frmSER"
        Me.Text = "Series RLC"
        Me.gboxIN.ResumeLayout(False)
        Me.gboxIN.PerformLayout()
        Me.gboxV.ResumeLayout(False)
        Me.gboxV.PerformLayout()
        Me.gboxC.ResumeLayout(False)
        Me.gboxC.PerformLayout()
        Me.gboxL.ResumeLayout(False)
        Me.gboxL.PerformLayout()
        Me.gboxR.ResumeLayout(False)
        Me.gboxR.PerformLayout()
        CType(Me.pboxG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxOUT.ResumeLayout(False)
        Me.gboxOUT.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboxIN As System.Windows.Forms.GroupBox
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblL As System.Windows.Forms.Label
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtL As System.Windows.Forms.TextBox
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents txtV As System.Windows.Forms.TextBox
    Friend WithEvents btnCOMP As System.Windows.Forms.Button
    Friend WithEvents btnPLOT As System.Windows.Forms.Button
    Friend WithEvents pboxG As System.Windows.Forms.PictureBox
    Friend WithEvents rdbCAP3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCAP2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCAP1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIND3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIND2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIND1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents btnMENU As System.Windows.Forms.Button
    Friend WithEvents gboxC As System.Windows.Forms.GroupBox
    Friend WithEvents gboxL As System.Windows.Forms.GroupBox
    Friend WithEvents gboxR As System.Windows.Forms.GroupBox
    Friend WithEvents rdbRES3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRES2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRES1 As System.Windows.Forms.RadioButton
    Friend WithEvents gboxV As System.Windows.Forms.GroupBox
    Friend WithEvents rdbVOL1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbVOL2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbVOL3 As System.Windows.Forms.RadioButton
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents picDraw As System.Windows.Forms.PictureBox
    Friend WithEvents lblFS As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtI As System.Windows.Forms.TextBox
    Friend WithEvents txtBW As System.Windows.Forms.TextBox
    Friend WithEvents txtQS As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gboxOUT As System.Windows.Forms.GroupBox
End Class
