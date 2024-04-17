Option Strict On
Option Explicit On
Public Class EtchOSketchFrom
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

End Class
