Option Strict On
Option Explicit On
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Threading.Thread
Imports System.Windows.Forms.ComponentModel.Com2Interop
Imports System.Runtime.InteropServices

'Rahiel Rodriguez
'RCET 0265
'Spring 2024
'Updated Etch-O-Sketch
'https://github.com/rahielrodriguez/Etch-O-Sketch.git

Public Class EtchOSketchFrom
    Sub SetDefaults()
        'Sets Initial Color of mouse drawing as black color.
        ForegroundColor(Color.Black, True)
        'Sets Track Bars to draw all across the picture box
        XTrackBar.Maximum = DrawingPictureBox.Width
        YTrackBar.Maximum = DrawingPictureBox.Height
        'Sets Values of the Track Bar Values to 0
        XTrackBar.Value = 0
        YTrackBar.Value = 0
        MouseRadioButton.Checked = True

    End Sub
    Function ForegroundColor(Optional newColor As Color = Nothing, Optional update As Boolean = False) As Color
        Static currentColor As Color
        'Allows to update the color selected to draw
        If update Then
            currentColor = newColor
        End If

        Return currentColor

    End Function
    Sub DrawGrid() Handles DrawingPictureBox.DoubleClick
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)

        Const TOP = 0%, LEFT = 0%
        Dim Bottom As Integer = DrawingPictureBox.Height
        Dim Right As Integer = DrawingPictureBox.Width
        'Sets a scale for the grids
        Dim xIncrement = DrawingPictureBox.Width \ 10
        Dim yIncrement = DrawingPictureBox.Height \ 8

        'vertical lines
        'Apply Scales
        For x = xIncrement To Right - xIncrement Step xIncrement
            g.DrawLine(pen, x, TOP, x, Bottom)
        Next

        For y = yIncrement To Bottom - yIncrement Step yIncrement
            g.DrawLine(pen, LEFT, y, Right, y)
        Next

        pen.Dispose()
        g.Dispose()
    End Sub
    Sub DrawSineWave()

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Red)

        'Set width at 360
        Dim xMax As Single = 360
        'calculate the x scale factor
        Dim xScale As Single = DrawingPictureBox.Width / xMax
        'Set height to 100 for scale
        Dim yMax As Single = 100
        'calculate the y scale factor and make up positive y
        Dim yScale As Single = CSng(DrawingPictureBox.Height / 2) / yMax * -1

        Dim oldX#, oldY#, newX#, newY#
        Dim angle#

        'apply the scaling settings 
        g.ScaleTransform(xScale, yScale)

        'set the origin of the waveform at the middle of y
        g.TranslateTransform(0, yMax * -1)

        For newX = 0 To 360
            'convert current X from degrees to radians
            angle = (Math.PI / 180) * newX
            'find current y 
            newY = (yMax - 10) * Math.Sin(angle)
            'draw current line segment
            g.DrawLine(pen, CInt(oldX), CInt(oldY), CInt(newX), CInt(newY))
            'store values for start of next line segment
            oldX = newX
            oldY = newY
        Next

        pen.Dispose()
        g.Dispose()
    End Sub
    Sub DrawCosineWave()

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Blue)

        'Set width at 360
        Dim xMax As Single = 360
        'calculate the x scale factor
        Dim xScale As Single = DrawingPictureBox.Width / xMax
        'Set height to 100 for scale
        Dim yMax As Single = 100
        'calculate the y scale factor and make up positive y
        Dim yScale As Single = CSng(DrawingPictureBox.Height / 2) / yMax * -1

        Dim oldX#, oldY#, newX#, newY#
        Dim angle#

        'apply the scale 
        g.ScaleTransform(xScale, yScale)

        'set the origin to the y middle of the picture box
        g.TranslateTransform(0, yMax * -1)

        For newX = 0 To 360
            'convert current X from degrees to radians
            angle = (Math.PI / 180) * newX
            'find current y 
            newY = (yMax - 10) * Math.Cos(angle)
            'draw current line segment
            g.DrawLine(pen, CInt(oldX), CInt(oldY), CInt(newX), CInt(newY))
            'store values for start of next line segment
            oldX = newX
            oldY = newY
        Next

        pen.Dispose()
        g.Dispose()
    End Sub
    Sub DrawTangentWave()

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Green)

        'Set width at 360
        Dim xMax As Single = 360
        'calculate the x scale factor
        Dim xScale As Single = DrawingPictureBox.Width / xMax
        'Set height to 100 for scale
        Dim yMax As Single = 100
        'calculate the y scale factor and make up positive y
        Dim yScale As Single = CSng(DrawingPictureBox.Height / 2) / yMax * -1

        Dim oldX#, oldY#, newX#, newY#
        Dim angle#

        'apply the scale 
        g.ScaleTransform(xScale, yScale)

        'set the origin to the y middle of the picture box
        g.TranslateTransform(0, yMax * -1)

        For newX = 0 To 360
            'convert current X from degrees to radians
            angle = (Math.PI / 180) * newX
            'find current y 
            newY = (yMax - 10) * Math.Tan(angle)
            'draw current line segment
            'If it cannot draw something from the waveform, skip and continue operation to eliminate errors.
            Try
                g.DrawLine(pen, CInt(oldX), CInt(oldY), CInt(newX), CInt(newY))
            Catch ex As Exception
            End Try
            'store values for start of next line segment
            oldX = newX
            oldY = newY
        Next

        pen.Dispose()
        g.Dispose()
    End Sub
    Sub Qy_ReadAnalogInPutA1()
        Dim data(0) As Byte
        'Send command to QY Board
        data(0) = &B1010001
        SerialPort.Write(data, 0, 1)

    End Sub

    Sub Qy_ReadAnalogInPutA2()
        Dim data(0) As Byte
        'Send command to QY Board
        data(0) = &B1010010
        SerialPort.Write(data, 0, 1)

    End Sub

    Sub GetSettings()
        Dim data(0) As Byte
        'Send command to QY Board
        data(0) = &B11110000
        SerialPort.Write(data, 0, 1)

    End Sub

    Sub SerialConnect(portName As String)
        SerialPort.Close()
        SerialPort.PortName = portName
        SerialPort.BaudRate = 9600
        SerialPort.Open()

    End Sub

    Sub GetPorts()
        'add all available ports to the port combobox
        PortComboBox.Items.Clear()
        For Each s As String In SerialPort.GetPortNames()
            PortComboBox.Items.Add($"{s}")
        Next

        PortComboBox.SelectedIndex = 0
    End Sub
    Sub Draw_QYBoard()
        'TODO
        '[x] Add AInput2 reading to control x
        '[x] Use AI2 to control x
        '[x] Draw X and Y using the analog inputs

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForegroundColor)

        'calculate the x scale factor
        Dim xScale As Single = CSng(DrawingPictureBox.Width) / 255

        'calculate the y scale factor and make up positive y
        Dim yScale As Single = CSng(DrawingPictureBox.Height) / (255 * -1)
        Dim newX#, newY#
        Static oldX#, oldY#

        'Get Analog Input 1 Value
        Qy_ReadAnalogInPutA1()

        'Get Analog Input 2 Value
        Qy_ReadAnalogInPutA2()

        'Wait to receive data
        Sleep(5)

        Console.WriteLine(SerialPort.BytesToRead)
        Dim data(SerialPort.BytesToRead) As Byte
        SerialPort.Read(data, 0, SerialPort.BytesToRead)

        'Display Analog 1 Data on the console
        Console.WriteLine($"High: {Hex(data(0))} | Jelly Beans: {data(0)}")
        'Display Analog 2 Data on the console
        Console.WriteLine($"High: {Hex(data(2))} | Jelly Beans: {data(2)}")

        newX = CDbl(data(2))
        newY = CDbl(data(0))

        'apply the scale 
        g.ScaleTransform(xScale, yScale)

        g.TranslateTransform(0, 255 * -1)

        Try
            g.DrawLine(pen, CInt(oldX), CInt(oldY), CInt(newX), CInt(newY))
        Catch ex As Exception
        End Try
        'Console.Write($"{newX} , {newY}")
        'store values for start of next line segment
        oldX = newX
        oldY = newY

        pen.Dispose()
        g.Dispose()

    End Sub
    Sub MouseDraw(newX As Integer, newY As Integer, draw As Boolean)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForegroundColor())
        Static oldX As Integer, oldY As Integer

        'Alows to draw along the picture box
        If draw Then
                g.DrawLine(pen, oldX, oldY, newX, newY)
            End If

            'Store calues for start of next line segment
            oldX = newX
        oldY = newY

        pen.Dispose()
        g.Dispose()
    End Sub
    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        Me.Text = $"({e.X}, {e.Y}) Button: {e.Button}"
        'Allows to draw and follow mouse movement.
        If MouseRadioButton.Checked Then
            If e.Button = MouseButtons.Left Then
                MouseDraw(e.X, e.Y, True)
            Else
                MouseDraw(e.X, e.Y, False)
            End If

        End If

    End Sub
    Private Sub DrawingPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown
        'Allows to draw only if left button of the mouse is being pressed

        Me.Text = $"({e.X}, {e.Y}) Button: {e.Button}"

    End Sub


    Private Sub TrackBarX_Scroll(sender As Object, e As EventArgs) Handles XTrackBar.Scroll, YTrackBar.Scroll
        ' Draw when either TrackBar changes
        Dim xPosition As Integer = XTrackBar.Value
        Dim yPosition As Integer = YTrackBar.Value
        TrackBarDraw(xPosition, yPosition)
    End Sub

    Sub TrackBarDraw(newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForegroundColor())
        Static oldX As Integer, oldY As Integer

        ' Draw a line as TrackBars move
        g.DrawLine(pen, oldX, oldY, newX, newY)

        ' Store current values for the next line segment
        oldX = newX
        oldY = newY

        pen.Dispose()
        g.Dispose()
    End Sub
    Sub ShakeWhenClear()
        Dim shakeCount As Integer = 0
        'If clear is pressed, it will move the form for certain amount of times.
        If shakeCount >= 500 Then
            shakeCount = 0
        End If
        Do Until shakeCount = 500
            Me.Left -= 20
            Me.Left += 20
            shakeCount += 1
        Loop
    End Sub
    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click, DrawWaveformsToolStripMenuItem.Click, DrawWaveformsToolStripMenuItem1.Click
        DrawingPictureBox.Refresh()
        DrawGrid()
        DrawSineWave()
        DrawCosineWave()
        DrawTangentWave()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click, ClearToolStripMenuItem1.Click
        ShakeWhenClear()
        DrawingPictureBox.Refresh()
        SetDefaults()
    End Sub
    Private Sub ForegroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem1.Click, SelectColorButton.Click, SelectColorToolStripMenuItem.Click

        'Allows to display the color dialog and change the color for drawing.
        ForegroundColor(ColorDialog.Color, True)
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ForegroundColor(ColorDialog.Color, True)
        End If
    End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()

    End Sub

    Private Sub SlidersRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SlidersRadioButton.CheckedChanged
        DrawingPictureBox.Refresh()
        'SerialPort.Close()
        XTrackBar.Enabled = True
        YTrackBar.Enabled = True
        Timer.Stop()
    End Sub

    Private Sub PotsRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PotsRadioButton.CheckedChanged
        DrawingPictureBox.Refresh()
        XTrackBar.Enabled = False
        YTrackBar.Enabled = False
        Timer.Start()

    End Sub
    Private Sub MouseRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MouseRadioButton.CheckedChanged
        DrawingPictureBox.Refresh()
        XTrackBar.Enabled = False
        YTrackBar.Enabled = False
        Timer.Stop()
    End Sub

    Private Sub ComButton_Click(sender As Object, e As EventArgs) Handles ComButton.Click, ComToolStripMenuItem.Click, ComToolStripMenuItem1.Click
        GetPorts()
    End Sub

    Private Sub PortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PortComboBox.SelectedIndexChanged
        SerialConnect($"{PortComboBox.SelectedItem}")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Draw_QYBoard()

    End Sub
End Class
