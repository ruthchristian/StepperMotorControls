<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBeginMeas = New System.Windows.Forms.Button()
        Me.btnFini = New System.Windows.Forms.Button()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAzAngle = New System.Windows.Forms.TextBox()
        Me.txtAngleResolution = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkCounterClockwise = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkClockWise = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtMeasStartAngle = New System.Windows.Forms.TextBox()
        Me.txtMeasStopAngle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGetMeasParams = New System.Windows.Forms.Button()
        Me.grpMeasParam = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtInpAtten = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXBN = New System.Windows.Forms.TextBox()
        Me.txtMeasFrequency = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMeasAmpl = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.rdoUSB = New System.Windows.Forms.RadioButton()
        Me.rdoTCPIP = New System.Windows.Forms.RadioButton()
        Me.JL = New System.Windows.Forms.Button()
        Me.JR = New System.Windows.Forms.Button()
        Me.JogChkBox = New System.Windows.Forms.CheckBox()
        Me.JogBox = New System.Windows.Forms.TextBox()
        Me.JogLabel = New System.Windows.Forms.Label()
        Me.ReadyJog = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpMeasParam.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBeginMeas
        '
        Me.btnBeginMeas.Enabled = False
        Me.btnBeginMeas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeginMeas.Location = New System.Drawing.Point(59, 32)
        Me.btnBeginMeas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBeginMeas.Name = "btnBeginMeas"
        Me.btnBeginMeas.Size = New System.Drawing.Size(97, 43)
        Me.btnBeginMeas.TabIndex = 0
        Me.btnBeginMeas.Text = "Meas Data"
        Me.btnBeginMeas.UseVisualStyleBackColor = True
        '
        'btnFini
        '
        Me.btnFini.Location = New System.Drawing.Point(476, 369)
        Me.btnFini.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFini.Name = "btnFini"
        Me.btnFini.Size = New System.Drawing.Size(88, 33)
        Me.btnFini.TabIndex = 1
        Me.btnFini.Text = "Fini"
        Me.btnFini.UseVisualStyleBackColor = True
        '
        'txtSpeed
        '
        Me.txtSpeed.Location = New System.Drawing.Point(106, 54)
        Me.txtSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(76, 20)
        Me.txtSpeed.TabIndex = 2
        Me.txtSpeed.Text = "15000"
        Me.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rotation Speed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Azimuth Angle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Deg"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAzAngle
        '
        Me.txtAzAngle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAzAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAzAngle.Location = New System.Drawing.Point(100, 89)
        Me.txtAzAngle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAzAngle.Name = "txtAzAngle"
        Me.txtAzAngle.Size = New System.Drawing.Size(92, 19)
        Me.txtAzAngle.TabIndex = 7
        Me.txtAzAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAngleResolution
        '
        Me.txtAngleResolution.Location = New System.Drawing.Point(197, 58)
        Me.txtAngleResolution.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAngleResolution.Name = "txtAngleResolution"
        Me.txtAngleResolution.Size = New System.Drawing.Size(44, 20)
        Me.txtAngleResolution.TabIndex = 8
        Me.txtAngleResolution.Text = "45"
        Me.txtAngleResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Angular Resolution (0.01 Deg min)"
        '
        'chkCounterClockwise
        '
        Me.chkCounterClockwise.AutoSize = True
        Me.chkCounterClockwise.Location = New System.Drawing.Point(17, 25)
        Me.chkCounterClockwise.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCounterClockwise.Name = "chkCounterClockwise"
        Me.chkCounterClockwise.Size = New System.Drawing.Size(114, 17)
        Me.chkCounterClockwise.TabIndex = 11
        Me.chkCounterClockwise.Text = "Counter Clockwise"
        Me.chkCounterClockwise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCounterClockwise.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkClockWise)
        Me.GroupBox1.Controls.Add(Me.chkCounterClockwise)
        Me.GroupBox1.Controls.Add(Me.txtSpeed)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 171)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(218, 83)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rotation Direction"
        '
        'chkClockWise
        '
        Me.chkClockWise.AutoSize = True
        Me.chkClockWise.Checked = True
        Me.chkClockWise.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClockWise.Location = New System.Drawing.Point(130, 25)
        Me.chkClockWise.Margin = New System.Windows.Forms.Padding(2)
        Me.chkClockWise.Name = "chkClockWise"
        Me.chkClockWise.Size = New System.Drawing.Size(74, 17)
        Me.chkClockWise.TabIndex = 12
        Me.chkClockWise.Text = "Clockwise"
        Me.chkClockWise.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'txtMeasStartAngle
        '
        Me.txtMeasStartAngle.Location = New System.Drawing.Point(48, 23)
        Me.txtMeasStartAngle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMeasStartAngle.Name = "txtMeasStartAngle"
        Me.txtMeasStartAngle.Size = New System.Drawing.Size(47, 20)
        Me.txtMeasStartAngle.TabIndex = 12
        Me.txtMeasStartAngle.Text = "-180"
        Me.txtMeasStartAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMeasStopAngle
        '
        Me.txtMeasStopAngle.Location = New System.Drawing.Point(170, 28)
        Me.txtMeasStopAngle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMeasStopAngle.Name = "txtMeasStopAngle"
        Me.txtMeasStopAngle.Size = New System.Drawing.Size(47, 20)
        Me.txtMeasStopAngle.TabIndex = 13
        Me.txtMeasStopAngle.Text = "180"
        Me.txtMeasStopAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Stop"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Start"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Deg"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(98, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Deg"
        '
        'btnGetMeasParams
        '
        Me.btnGetMeasParams.AccessibleDescription = "tn"
        Me.btnGetMeasParams.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetMeasParams.Location = New System.Drawing.Point(76, 327)
        Me.btnGetMeasParams.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGetMeasParams.Name = "btnGetMeasParams"
        Me.btnGetMeasParams.Size = New System.Drawing.Size(172, 31)
        Me.btnGetMeasParams.TabIndex = 18
        Me.btnGetMeasParams.Tag = "ryr"
        Me.btnGetMeasParams.Text = "Save Test Paramaters"
        Me.btnGetMeasParams.UseVisualStyleBackColor = True
        '
        'grpMeasParam
        '
        Me.grpMeasParam.Controls.Add(Me.Label18)
        Me.grpMeasParam.Controls.Add(Me.txtInpAtten)
        Me.grpMeasParam.Controls.Add(Me.Label17)
        Me.grpMeasParam.Controls.Add(Me.GroupBox4)
        Me.grpMeasParam.Controls.Add(Me.Label15)
        Me.grpMeasParam.Controls.Add(Me.Label14)
        Me.grpMeasParam.Controls.Add(Me.TXBN)
        Me.grpMeasParam.Controls.Add(Me.txtMeasFrequency)
        Me.grpMeasParam.Controls.Add(Me.Label13)
        Me.grpMeasParam.Controls.Add(Me.Label12)
        Me.grpMeasParam.Controls.Add(Me.btnGetMeasParams)
        Me.grpMeasParam.Controls.Add(Me.GroupBox1)
        Me.grpMeasParam.Location = New System.Drawing.Point(46, 81)
        Me.grpMeasParam.Margin = New System.Windows.Forms.Padding(2)
        Me.grpMeasParam.Name = "grpMeasParam"
        Me.grpMeasParam.Padding = New System.Windows.Forms.Padding(2)
        Me.grpMeasParam.Size = New System.Drawing.Size(341, 369)
        Me.grpMeasParam.TabIndex = 19
        Me.grpMeasParam.TabStop = False
        Me.grpMeasParam.Text = "Measurement Parameters"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(286, 32)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "dB"
        '
        'txtInpAtten
        '
        Me.txtInpAtten.Location = New System.Drawing.Point(249, 30)
        Me.txtInpAtten.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInpAtten.Name = "txtInpAtten"
        Me.txtInpAtten.Size = New System.Drawing.Size(34, 20)
        Me.txtInpAtten.TabIndex = 26
        Me.txtInpAtten.Text = "30"
        Me.txtInpAtten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(188, 32)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Input Atten"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtMeasStartAngle)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtMeasStopAngle)
        Me.GroupBox4.Controls.Add(Me.txtAngleResolution)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 72)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(265, 83)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Meas Angle Range"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 296)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(327, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Note: An index No will be added in front of a File extension of ""csv""."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 258)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Recorded Data File Name"
        '
        'TXBN
        '
        Me.TXBN.Location = New System.Drawing.Point(17, 275)
        Me.TXBN.Margin = New System.Windows.Forms.Padding(2)
        Me.TXBN.Name = "TXBN"
        Me.TXBN.Size = New System.Drawing.Size(317, 20)
        Me.TXBN.TabIndex = 24
        '
        'txtMeasFrequency
        '
        Me.txtMeasFrequency.Location = New System.Drawing.Point(76, 30)
        Me.txtMeasFrequency.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMeasFrequency.Name = "txtMeasFrequency"
        Me.txtMeasFrequency.Size = New System.Drawing.Size(61, 20)
        Me.txtMeasFrequency.TabIndex = 24
        Me.txtMeasFrequency.Text = "1000"
        Me.txtMeasFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(140, 32)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "MHz"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 32)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Frequency"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(56, 129)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 17)
        Me.Label11.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMeasAmpl)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.btnBeginMeas)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtAzAngle)
        Me.GroupBox3.Location = New System.Drawing.Point(416, 92)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(238, 217)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recored Data"
        '
        'txtMeasAmpl
        '
        Me.txtMeasAmpl.Location = New System.Drawing.Point(100, 170)
        Me.txtMeasAmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMeasAmpl.Name = "txtMeasAmpl"
        Me.txtMeasAmpl.Size = New System.Drawing.Size(56, 20)
        Me.txtMeasAmpl.TabIndex = 24
        Me.txtMeasAmpl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(29, 173)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Pattern Ampl"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtIPAddress)
        Me.GroupBox5.Controls.Add(Me.rdoUSB)
        Me.GroupBox5.Controls.Add(Me.rdoTCPIP)
        Me.GroupBox5.Location = New System.Drawing.Point(46, 18)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(341, 45)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select Spec An - PC  Interface"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(156, 24)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Prog Spec An IP"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(242, 21)
        Me.txtIPAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(90, 20)
        Me.txtIPAddress.TabIndex = 2
        Me.txtIPAddress.Text = "169.254.234.83"
        Me.txtIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdoUSB
        '
        Me.rdoUSB.AutoSize = True
        Me.rdoUSB.Location = New System.Drawing.Point(93, 22)
        Me.rdoUSB.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoUSB.Name = "rdoUSB"
        Me.rdoUSB.Size = New System.Drawing.Size(47, 17)
        Me.rdoUSB.TabIndex = 1
        Me.rdoUSB.TabStop = True
        Me.rdoUSB.Text = "USB"
        Me.rdoUSB.UseVisualStyleBackColor = True
        '
        'rdoTCPIP
        '
        Me.rdoTCPIP.AutoSize = True
        Me.rdoTCPIP.Location = New System.Drawing.Point(20, 22)
        Me.rdoTCPIP.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoTCPIP.Name = "rdoTCPIP"
        Me.rdoTCPIP.Size = New System.Drawing.Size(56, 17)
        Me.rdoTCPIP.TabIndex = 0
        Me.rdoTCPIP.TabStop = True
        Me.rdoTCPIP.Text = "TCPIP"
        Me.rdoTCPIP.UseVisualStyleBackColor = True
        '
        'JL
        '
        Me.JL.Location = New System.Drawing.Point(760, 3)
        Me.JL.Name = "JL"
        Me.JL.Size = New System.Drawing.Size(75, 23)
        Me.JL.TabIndex = 28
        Me.JL.Text = "Jog Left"
        Me.JL.UseVisualStyleBackColor = True
        Me.JL.Visible = False
        '
        'JR
        '
        Me.JR.Location = New System.Drawing.Point(760, 40)
        Me.JR.Name = "JR"
        Me.JR.Size = New System.Drawing.Size(75, 23)
        Me.JR.TabIndex = 29
        Me.JR.Text = "Jog Right"
        Me.JR.UseVisualStyleBackColor = True
        Me.JR.Visible = False
        '
        'JogChkBox
        '
        Me.JogChkBox.AutoSize = True
        Me.JogChkBox.Location = New System.Drawing.Point(541, 6)
        Me.JogChkBox.Name = "JogChkBox"
        Me.JogChkBox.Size = New System.Drawing.Size(113, 17)
        Me.JogChkBox.TabIndex = 30
        Me.JogChkBox.Text = "Input Jog Degrees"
        Me.JogChkBox.UseVisualStyleBackColor = True
        '
        'JogBox
        '
        Me.JogBox.Location = New System.Drawing.Point(554, 43)
        Me.JogBox.Name = "JogBox"
        Me.JogBox.Size = New System.Drawing.Size(100, 20)
        Me.JogBox.TabIndex = 31
        Me.JogBox.Visible = False
        '
        'JogLabel
        '
        Me.JogLabel.AutoSize = True
        Me.JogLabel.Location = New System.Drawing.Point(572, 66)
        Me.JogLabel.Name = "JogLabel"
        Me.JogLabel.Size = New System.Drawing.Size(67, 13)
        Me.JogLabel.TabIndex = 32
        Me.JogLabel.Text = "Jog Degrees"
        Me.JogLabel.Visible = False
        '
        'ReadyJog
        '
        Me.ReadyJog.Location = New System.Drawing.Point(665, 2)
        Me.ReadyJog.Name = "ReadyJog"
        Me.ReadyJog.Size = New System.Drawing.Size(75, 23)
        Me.ReadyJog.TabIndex = 33
        Me.ReadyJog.Text = "Ready Jog"
        Me.ReadyJog.UseCompatibleTextRendering = True
        Me.ReadyJog.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 460)
        Me.Controls.Add(Me.ReadyJog)
        Me.Controls.Add(Me.JogLabel)
        Me.Controls.Add(Me.JogBox)
        Me.Controls.Add(Me.JogChkBox)
        Me.Controls.Add(Me.JR)
        Me.Controls.Add(Me.JL)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpMeasParam)
        Me.Controls.Add(Me.btnFini)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpMeasParam.ResumeLayout(False)
        Me.grpMeasParam.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBeginMeas As Button
    Friend WithEvents btnFini As Button
    Friend WithEvents txtSpeed As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAzAngle As TextBox
    Friend WithEvents txtAngleResolution As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkCounterClockwise As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtMeasStartAngle As TextBox
    Friend WithEvents txtMeasStopAngle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRS As TextBox
    Friend WithEvents txtXVal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGetMeasParams As Button
    Friend WithEvents grpMeasParam As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMeasFrequency As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TXBN As TextBox
    Friend WithEvents txtMeasAmpl As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtInpAtten As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkClockWise As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rdoUSB As RadioButton
    Friend WithEvents rdoTCPIP As RadioButton
    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents JL As Button
    Friend WithEvents JR As Button
    Friend WithEvents JogChkBox As CheckBox
    Friend WithEvents JogBox As TextBox
    Friend WithEvents JogLabel As Label
    Friend WithEvents ReadyJog As Button
End Class
