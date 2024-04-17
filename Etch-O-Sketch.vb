Option Strict On
Option Explicit On
Public Class EtchOSketchFrom
    'TODO
    '[ ]Draw Sine Wave
    '[ ]Draw Cosine Wave
    '[ ]Draw Tangent Wave
    '[ ]When Clear is pressed the form will shake
    Sub SetDefaults()
        ForegroundColor(Color.Black, True)

    End Sub
    Function ForegroundColor(Optional newColor As Color = Nothing, Optional update As Boolean = False) As Color
        Static currentColor As Color

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

        Dim xIncrement = DrawingPictureBox.Width \ 10
        Dim yIncrement = DrawingPictureBox.Height \ 8

        'vertical lines

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
    Sub MouseDraw(newX As Integer, newY As Integer, draw As Boolean)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForegroundColor())
        Static oldX As Integer, oldY As Integer

        If draw Then
            g.DrawLine(pen, oldX, oldY, newX, newY)
        End If

        oldX = newX
        oldY = newY

        pen.Dispose()
        g.Dispose()
    End Sub
    Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        Me.Text = $"({e.X}, {e.Y}) Button: {e.Button}"
        If e.Button = MouseButtons.Left Then
            MouseDraw(e.X, e.Y, True)
        Else
            MouseDraw(e.X, e.Y, False)
        End If
    End Sub

    Private Sub DrawingPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown
        Me.Text = $"({e.X}, {e.Y}) Button: {e.Button}"
    End Sub
    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click, DrawWaveformsToolStripMenuItem.Click, DrawWaveformsToolStripMenuItem1.Click
        DrawGrid()
        DrawSineWave()
        DrawCosineWave()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click, ClearToolStripMenuItem1.Click
        DrawingPictureBox.Refresh()
        SetDefaults()
    End Sub
    Private Sub ForegroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem1.Click, SelectColorButton.Click, SelectColorToolStripMenuItem.Click

        ForegroundColor(ColorDialog.Color, True)
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ForegroundColor(ColorDialog.Color, True)
        End If
    End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()

    End Sub

    Private Sub SelectColorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem1.Click

    End Sub

End Class
