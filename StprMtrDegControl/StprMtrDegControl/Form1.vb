Imports System.Math
Imports Ivi.Visa.Interop
Imports System.Runtime.InteropServices
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Tools.Excel
Imports System.Drawing.Text
Imports System.Threading
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core


Public Class frmMain

    Dim ioMgr As ResourceManager
    Dim DSA815TG As FormattedIO488
    Dim cmdStr, replyStr As String
    Dim xValue, Reply, SectorCounts, CountsPerAngleStep As Integer
    Dim AzAngle, NumberOfSteps, NumberOfAzAngles, AzAngleMeasNo, i, j, LastDataPointRow As Integer
    Dim RotationDirec, CSVDataFileName, ExcelDataFileName, Jog As String
    Dim Direc, XStart, AngStepIncr, MeasStartAngle, MeasStopAngle, R, testA, JogDeg, JogDegr As Single
    Dim ScanRange As Single
    Dim crlf, idn, TCPIPUSB As String
    Dim MeasFreq, Set_DSA815TG_Freq, Amp, InpAtten As String
    Dim oSheet As Excel.Worksheet
    Dim oExcel As Excel.Application
    Dim oBook As Excel.Workbook
    Dim oBooks As Excel.Workbooks

    Private Sub JL_Click(sender As Object, e As EventArgs) Handles JL.Click
        JogDegr = -JogDegr
        JogMotor()
    End Sub

    Private Sub JR_Click(sender As Object, e As EventArgs) Handles JR.Click
        JogMotor()
    End Sub

    Dim Yval, Xval As Double

    Private Sub ReadyJog_Click(sender As Object, e As EventArgs) Handles ReadyJog.Click
        PerformaxSendGetReply("EO=1")
        PerformaxSendGetReply("ABS")
        PerformaxSendGetReply("ACC=3")
        PerformaxSendGetReply("HSPD=10000")
        JogDegr = 10
        If JogDeg = 1 Then
            JogDegr = JogBox.Text
        End If
        JL.Visible = True
        JR.Visible = True
    End Sub

    Dim Pi As Double = 3.141592654
    Dim misValue As Object = System.Reflection.Missing.Value
    Dim xAxis As Excel.Axis
    Dim yaxis As Excel.Axis
    Dim oChart As Excel.Chart
    Dim oSeries As Excel.Series


    Private Sub JogChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles JogChkBox.CheckedChanged
        JogBox.Visible = True
        JogLabel.Visible = True
        JogDeg = 1
    End Sub

    Sub JogMotor()
        Jog = "X" & (JogDegr / 0.005)
        PerformaxSendGetReply("PX=0")
        PerformaxSendGetReply(Jog)
        Threading.Thread.Sleep(500)

        JogDegr = 10
        If JogDeg = 1 Then
            JogDegr = JogBox.Text
        End If
        PerformaxSendGetReply("PX=0")
    End Sub


    '=======================  == BEGIN NOTE == ========================
    '  Note:  Stepper Motor "MicroStepping is set to "360" such that 
    '         72000 counts, pulses, steps, etc. = 360 degree rotation
    '         Providig an angular resolution of 0.005 degree per count.
    '           SCALING:  2 COUNTS per 0.01 Degree of rotation
    '=======================  == END NOTE == ========================

    Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grpMeasParam.Visible = False

        i = 0

    End Sub
    '=======================  ==30== ========================

    Sub rdoTCPIP_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTCPIP.CheckedChanged

        TCPIPUSB = "IP"
        SetUPMotorAndSecAn()
        grpMeasParam.Visible = True

    End Sub
    '=======================  ==30== ========================

    Sub rdoUSB_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUSB.CheckedChanged

        TCPIPUSB = "USB"
        SetUPMotorAndSecAn()
        grpMeasParam.Visible = True

    End Sub
    '=======================  ==30== ========================

    Sub SetUPMotorAndSecAn()

        SetUPSpecAn()
        ' Stop
        InitialMotorSetup()
        Label11.Text = "Waiting"
        Label11.Update()
        ' LoadLastUsedSettings()

    End Sub
    '=======================  ==30== ========================

    Sub InitialMotorSetup()

        PerformaxSendGetReply("EO=0")
        Threading.Thread.Sleep(100)
        cmdStr = "EO=1"
        ' PerformaxSendGetReply uses DLL function fnPerformaxComSendRcv for sending commands and receiving replies
        replyStr = PerformaxSendGetReply(cmdStr)
        Threading.Thread.Sleep(100)   'Wait for Command to complete
        cmdStr = "PX=0"
        cmdStr = "ABS"      'Set Stepper Motor to "Incremental" Mode
        PerformaxSendGetReply(cmdStr)
        Threading.Thread.Sleep(500)   'Wait for Command to complete

        cmdStr = "MM"      'Read Stepper Motor to Mode "Incremental" or "Absolute"
        replyStr = PerformaxSendGetReply(cmdStr)
        Threading.Thread.Sleep(100)   'Wait for Command to complete
        cmdStr = "ACC=3"      'Set Stepper Motor Acceleration
        PerformaxSendGetReply(cmdStr)
        Threading.Thread.Sleep(500)   'Wait for Command to complete

    End Sub
    '=======================  ==30== ========================

    Sub GetMeasParams_Click(sender As Object, e As EventArgs) Handles btnGetMeasParams.Click


        btnBeginMeas.Enabled = False

        MeasFreq = Str(1000000.0 * Val(txtMeasFrequency.Text))
        'Stop
        'Get / Set Scan Sector
        MeasStartAngle = Val(txtMeasStartAngle.Text)
        MeasStopAngle = Val(txtMeasStopAngle.Text)

        'Get / Set Angle Resolution AND Number of pulses / counts per
        '    angle increment
        AngStepIncr = Val(txtAngleResolution.Text)
        ScanRange = Abs(MeasStopAngle - MeasStartAngle)
        SectorCounts = CInt(200 * ScanRange)
        CountsPerAngleStep = CInt(200 * (AngStepIncr))
        NumberOfSteps = ScanRange / AngStepIncr

        'Get / Set Rotation Direction
        Direc = 1
        If chkCounterClockwise.Checked = True Then
            ' chkClockwise.Checked = False
            ' chkClockWise.Update()
            '         RotationDirec = "CCW"
            Direc = -1
        End If

        ' Set Motor Speed
        cmdStr = "HSPD=" & txtSpeed.Text
        PerformaxSendGetReply(cmdStr)
        Threading.Thread.Sleep(500)   'Wait for Command to complete

        btnBeginMeas.Enabled = True

    End Sub
    '=======================  ==30== ========================

    Sub btnBeginMeas_Click(sender As Object, e As EventArgs) Handles btnBeginMeas.Click




        FileOpen(2, "C:\VB2017\" & (TXBN.Text & ".csv"), OpenMode.Output)

        ExcelDataFileName = TXBN.Text
        Dim oSeries As Excel.Series

        oExcel = New Excel.Application
        oBook = oExcel.Workbooks.Add(misValue)
        oSheet = oBook.Sheets("sheet1")

        oExcel.Visible = True
        oBooks = oExcel.Workbooks

        oSheet.Range("J3").Select()
        oBook.ActiveSheet.Shapes.AddChart.Select()
        oBook.ActiveChart.ChartType = Excel.XlChartType.xlXYScatterSmoothNoMarkers


        oBook.ActiveChart.SeriesCollection.NewSeries()

        oBook.SaveAs(Filename:=ExcelDataFileName & ".xlsx")

        CSVDataFileName = ExcelDataFileName & ".csv"
        LastDataPointRow = Abs((Val(txtMeasStartAngle.Text) - Val(txtMeasStopAngle.Text)) / Val(txtAngleResolution.Text))

        oBook.ActiveChart.Legend.Delete()

        oBook.ActiveChart.SeriesCollection(1).XValues = "=Sheet1!$B$2:$B$" & LastDataPointRow
        oBook.ActiveChart.SeriesCollection(1).Values = "=Sheet1!$C$2:$C$" & LastDataPointRow





        yaxis = CType(oBook.ActiveChart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
        xAxis = CType(oBook.ActiveChart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
        xAxis.HasTitle = True
        xAxis.AxisTitle.Text = "Wavelength (nm)"
        yaxis.HasTitle = True
        yaxis.AxisTitle.Text = "Intensity"

        oChart = oBook.ActiveChart

        Label11.Text = "Scanning"
        Label11.Update()

        AzAngleMeasNo = 0

        PerformaxSendGetReply("PX=0")

        'Send Motor to Start Position

        xValue = CInt(200 * MeasStartAngle)
        cmdStr = "X" & xValue
        PerformaxSendGetReply(cmdStr)
        MonitorStepperMotorPosition()

        '    Set Measment Frequency and Turn ON Tracking Generator
        Set_DSA815TG_Freq = "SENS:FREQ:CENT" & MeasFreq
        DSA815TG.WriteString(Set_DSA815TG_Freq)
        Threading.Thread.Sleep(200)   'Wait for Command to complete
        'Set_DSA815TG_Freq = "OUTP:STAT ON"
        'Stop
        DSA815TG.WriteString("OUTP:STAT ON")
        Threading.Thread.Sleep(100)   'Wait for Command to complete

        RFSigAmpl()     ' Get Signal Amplitude for first Angle

        'Position motor to each scan angle and Record Data
        Timer1.Enabled = True

    End Sub
    '=======================  ==30== ========================

    Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        AcquireData()

    End Sub
    '=======================  ==30== ========================

    Sub AcquireData()


        If AzAngleMeasNo < NumberOfSteps - 1 Then

            j = 0

            DSA815TG.WriteString("CALC:MARK1:Y?")
            Threading.Thread.Sleep(100)   'Wait for Command to complete
            Amp = DSA815TG.ReadString()
            txtMeasAmpl.Text = Format(Val(Amp), "#####.00")
            txtMeasAmpl.Update()

            Threading.Thread.Sleep(3000)   'Wait for Command to complete
            xValue = xValue + Direc * CountsPerAngleStep
            cmdStr = "X" & xValue
            PerformaxSendGetReply(cmdStr)
            MonitorStepperMotorPosition()
            'RFSigAmpl()
            AzAngleMeasNo += 1
            DataAnalysis()
        Else
            Timer1.Enabled = False
            Threading.Thread.Sleep(3000)   'Wait for Command to complete

            '    Turn OFF Tracking Generator
            DSA815TG.WriteString("OUTP:STAT OFF")
            Label11.Text = "SCANNING COMPLETE"
            Label11.Update()
            xValue = 0
            cmdStr = "X" & xValue
            PerformaxSendGetReply(cmdStr)
            MonitorStepperMotorPosition()

            DataAnalysis()
            FileClose(1)
        End If



    End Sub
    '=======================  ==30== ========================

    Sub RFSigAmpl()

        MeasFreq = txtMeasFrequency.Text

        'Stop

        Set_DSA815TG_Freq = "CALC:MARK1:X " & Str(MeasFreq) & "MHZ"

        DSA815TG.WriteString(Set_DSA815TG_Freq)
        Threading.Thread.Sleep(200)   'Wait for Command to complete
        DSA815TG.WriteString("CALC:MARK1:Y?")
        Amp = DSA815TG.ReadString()
        'txtMeasAmpl.Text = Amp
        ' txtMeasAmpl.Update()
        ' MkrAmp(j) = Amp
        ' Write(1, Amp)

    End Sub
    '=======================  ==30== ========================

    Sub MonitorStepperMotorPosition()        '----------------------------------------------
        '  Routine to monitor Stepper Motor position while moving to commanded position
        '----------------------------------------------
        txtAzAngle.BackColor = Color.White
        txtAzAngle.Update()
        replyStr = PerformaxSendGetReply("PX")
        Reply = CInt(replyStr)
        While Reply <> xValue
            replyStr = PerformaxSendGetReply("PX")   ' send and get get motor position
            Reply = CInt(replyStr)
            txtAzAngle.Text = Format(0.005 * replyStr, "####.00")
            txtAzAngle.Update()

        End While
        txtAzAngle.Update()
        txtAzAngle.BackColor = Color.Red
        txtAzAngle.Update()

    End Sub
    '=======================  ==30== ========================

    Sub btnFini_Click(sender As Object, e As EventArgs) Handles btnFini.Click

        SaveastUsedVars()

        End

    End Sub
    '=======================  ==30== ========================

    '=======================  ==30== ========================

    Sub SetUPSpecAn()

        crlf = Chr(13) & Chr(10)
        'UnitErrorMsg = "CHECK ""KHz"" or ""MHz"" "
        'EnterFreqErrMsg = "Enter at least one Frequency"
        idn = "                                    "
        ioMgr = New ResourceManager
        DSA815TG = New FormattedIO488
        ' use instrument specific address for Open() parameter – i.e. GPIB0::22
        ' DSA815TG.IO = ioMgr.Open("USB0::0x1AB1::0x0960::DSA8A144001293::0::INSTR")
        'DSA815TG.IO = ioMgr.Open("TCPIP0::rigollan.local::inst0::INSTR")
        '
        'DSA815TG.IO = ioMgr.Open("TCPIP:inst0")
        'DSA815TG.IO = ioMgr.Open("USB0::0x0400::0x09C4::DG1D172301932::0::INSTR")
        ' DSA815TG.IO = ioMgr.Open("GPIB0::17::InStr")


        If TCPIPUSB = "IP" Then
            DSA815TG.IO = ioMgr.Open("TCPIP0::" & txtIPAddress.Text & "::inst0::INSTR")
        End If

        If TCPIPUSB = "USB" Then
            DSA815TG.IO = ioMgr.Open("USB0::0x1AB1::0x0960::DSA8A194401320::0::INSTR")
        End If

        ' DSA815TG.IO = ioMgr.Open("USBInstrument1")
        ' DSA815TG.WriteString("*IDN?")
        ' DSA815TG.IO.Timeout = 10000

        DSA815TG.WriteString("*IDN?")
        DSA815TG.IO.Timeout = 10000

        idn = DSA815TG.ReadString()
        Threading.Thread.Sleep(200)   'Wait for Command to complete
        DSA815TG.WriteString("SYST:PON:TYPE PRES")
        Threading.Thread.Sleep(1000)   'Wait for Command to complete
        DSA815TG.WriteString("SYST:PRES")
        Threading.Thread.Sleep(10000)
        ' Set Spectrum Analtzer Scales

        'Set Frequency Span

        DSA815TG.WriteString("SENS:FREQ:SPAN 0")
        Threading.Thread.Sleep(100)

        'Set Amplitude Parameters

        DSA815TG.WriteString("SENS:POW:RF:GAIN:STAT ON")
        Threading.Thread.Sleep(100)
        DSA815TG.WriteString("SENS:POW:ASC")
        Threading.Thread.Sleep(100)
        '           Set RF Input Attenuation 0 to 30 dB
        If (Val(txtInpAtten.Text >= 0)) And (Val(txtInpAtten.Text <= 30)) Then
            DSA815TG.WriteString("SENS:POW:RF:ATT " & txtInpAtten.Text)
        Else
            DSA815TG.WriteString("SENS:POW:RF:ATT30")
        End If
        Threading.Thread.Sleep(100)

        'Set BandWidth Parameters
        '        Set Resolution Bandwidth
        DSA815TG.WriteString("SENS:BAND:RES 300")
        Threading.Thread.Sleep(100)
        '        Set Resolution Bandwidth
        DSA815TG.WriteString("SENS:BAND:VID 300")
        Threading.Thread.Sleep(100)

        'Set Sweep Parameters
        '        Set Resolution Bandwidth

        DSA815TG.WriteString("SENS:SWE:TIME 0.001")

        'Me.Show()



        ' txtDataFile.Focus()

    End Sub
    '=======================  ==30== ========================

    Sub LoadLastUsedSettings()

        txtMeasFrequency.Text = My.Settings.txtMeasFrequency
        txtInpAtten.Text = My.Settings.txtInpAtten
        txtMeasStartAngle.Text = My.Settings.txtMeasStartAngle
        txtMeasStopAngle.Text = My.Settings.txtMeasStopAngle
        txtAngleResolution.Text = My.Settings.txtAngleResolution
        txtSpeed.Text = My.Settings.txtSpeed
        txtIPAddress.Text = My.Settings.txtIPAddress
    End Sub
    '=======================  ==30== ========================

    Sub SaveastUsedVars()

        My.Settings.txtMeasFrequency = txtMeasFrequency.Text
        My.Settings.txtInpAtten = txtInpAtten.Text
        My.Settings.txtMeasStartAngle = txtMeasStartAngle.Text
        My.Settings.txtMeasStopAngle = txtMeasStopAngle.Text
        My.Settings.txtAngleResolution = txtAngleResolution.Text
        My.Settings.txtSpeed = txtSpeed.Text
        My.Settings.txtIPAddress = txtIPAddress.Text

    End Sub
    '=======================  ==30== ========================


    '=======================  ==30== ========================
    '=======================  ==30== ========================
    '=======================  ==30== ========================
    '=======================  ==30== ========================
    '=======================  ==30== ========================
    '=======================  ==30== ========================
    '=======================  ==30== ========================

    Sub DataAnalysis()
        Pi = 3.14159
        replyStr = PerformaxSendGetReply("PX")
        Reply = CInt(replyStr)
        AzAngle = (0.005 * replyStr)
        'If AzAngle = 0 Then
        '    testA = Abs(Val(Amp))
        '    Stop
        'End If

        'If AzAngle = 90 Then
        '    testA = Abs(Val(Amp))
        '    Stop
        'End If
        i = i + 1
        If i < 2 Then
            oSheet.Range("A" & i).Value = i

            Xval = Cos((Pi / 180) * AzAngle) * Abs(Val(Amp))

            oSheet.Range("B" & i).Value = Xval
            Yval = Sin((Pi / 180) * AzAngle) * Abs(Val(Amp))
            oSheet.Range("C" & i).Value = Yval

            R = Abs(Val(Amp))
            WriteLine(2, i, Xval, Yval)

        ElseIf i >= 2 Then

            oSheet.Range("A" & i).Value = i
            Xval = Cos((Pi / 180) * AzAngle) * (R - Abs(Val(Amp)))

            oSheet.Range("B" & i).Value = Xval
            Yval = Sin((Pi / 180) * AzAngle) * (R - Abs(Val(Amp)))
            oSheet.Range("C" & i).Value = Yval
            WriteLine(2, i, Xval, Yval)

        End If




        'oSheet.Range("A" & i).Value = i

        'Xval = Cos((Pi / 180) * AzAngle) * Abs(Val(Amp))

        'oSheet.Range("B" & i).Value = Xval
        'Yval = Sin((Pi / 180) * AzAngle) * Abs(Val(Amp))
        'oSheet.Range("C" & i).Value = Yval

    End Sub


End Class