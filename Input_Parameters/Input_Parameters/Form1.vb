'import IO libraries
Imports System.IO
Imports System.Text

Public Class InputParameters
    Dim random As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set the maximum value of min shapes to be 1 less than max shapes, so that there isn't any possibility of having min. greater than max.
        nudMinShapes.Maximum = nudMaxShapes.Value - 1
        'set the minimum value of max shapes to be 1 more than min shapes, so that there isn't any possibility of having max. less than min.
        nudMaxShapes.Minimum = nudMinShapes.Value + 1
    End Sub

    Private Sub colourselector1_Click(sender As Object, e As EventArgs) Handles colourselector1.Click
        'when clicked, show colour selction dialog
        ColDialog.ShowDialog()
        'set background colour to the colour that was selected
        colourselector1.BackColor = ColDialog.Color
    End Sub

    Private Sub colourselector2_Click(sender As Object, e As EventArgs) Handles colourselector2.Click
        'when clicked, show colour selction dialog
        ColDialog.ShowDialog()
        'set background colour to the colour that was selected
        colourselector2.BackColor = ColDialog.Color
    End Sub
    Private Sub colourselector3_Click(sender As Object, e As EventArgs) Handles colourselector3.Click
        'when clicked, show colour selction dialog
        ColDialog.ShowDialog()
        'set background colour to the colour that was selected
        colourselector3.BackColor = ColDialog.Color
    End Sub
    Private Sub colourselector4_Click(sender As Object, e As EventArgs) Handles colourselector4.Click
        'when clicked, show colour selction dialog
        ColDialog.ShowDialog()
        'set background colour to the colour that was selected
        colourselector4.BackColor = ColDialog.Color
    End Sub

    Private Sub colourselector5_Click(sender As Object, e As EventArgs) Handles colourselector5.Click
        'when clicked, show colour selction dialog
        ColDialog.ShowDialog()
        'set background colour to the colour that was selected
        colourselector5.BackColor = ColDialog.Color
    End Sub

    Private Sub nudMaxShapes_ValueChanged(sender As Object, e As EventArgs) Handles nudMaxShapes.ValueChanged
        'set the maximum value of min shapes to be 1 less than max shapes, so that there isn't any possibility of having min. greater than max.
        nudMinShapes.Maximum = nudMaxShapes.Value - 1
    End Sub

    Private Sub nudMinShapes_ValueChanged(sender As Object, e As EventArgs) Handles nudMinShapes.ValueChanged
        'set the minimum value of max shapes to be 1 more than min shapes, so that there isn't any possibility of having max. less than min.
        nudMaxShapes.Minimum = nudMinShapes.Value + 1
    End Sub

    Private Sub btnRandomise_Click(sender As Object, e As EventArgs) Handles btnRandomise.Click
        'randomise all inputs
        'randomise colours
        Dim max, min, gridS, repC As Integer
        Dim rnd As New Random
        For i As Integer = 1 To 5
            'make a virtual colourselector (button) to change the propertiesof the colourselecotrs on the form
            Dim clr As Button
            'set the virtual radiobutton name to colourselector1
            clr = Controls("colourselector" & i)
            'rad changes the text for rb1 to the value in the <name> element
            clr.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
            'iterate through all colourselectors
        Next
        'randomise max and min shape boxes
        'get random values
        max = 6 + rnd.Next(10)
        min = 5 + rnd.Next(max - 5)
        'set minimums and maximums so that no conflicts occur when setting values of NUDs
        nudMaxShapes.Minimum = min + 1
        nudMinShapes.Maximum = max - 1
        'set NUD values
        nudMaxShapes.Value = max
        nudMinShapes.Value = min
        'randomise grid size
        gridS = 8 + rnd.Next(5)
        nudGS.Value = gridS
        'randomise repetition configuration
        repC = rnd.Next(3)
        Select Case repC
            Case 0
                rbn1.Checked = True
            Case 1
                rbn2.Checked = True
            Case 2
                rbn4.Checked = True
        End Select
    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'create output file which contains all parameters set by user
        'create array for color data as string
        Dim cx(5) As String
        For i As Integer = 1 To 5
            Dim clr As Button
            'create proxy for colourselector to read RGB infomation
            clr = Controls("colourselector" & i)
            'create new strings to hold RBG values (0-255) as strings 
            Dim r, g, b As String
            'format the strings such that they have 3 digits
            r = String.Format("{0:000}", clr.BackColor.R)
            g = String.Format("{0:000}", clr.BackColor.G)
            b = String.Format("{0:000}", clr.BackColor.B)
            'set the value of the array entry to be thr RGB values, seperated by commas 
            cx(i) = r & "," & g & "," & b
        Next
        'create array for other data as string 
        Dim vx(4) As String
        'put data into array with correct formatting
        For i As Integer = 0 To 3
            Select Case i
                Case 0
                    vx(i) = String.Format("{0:00}", nudMaxShapes.Value)
                Case 1
                    vx(i) = String.Format("{0:00}", nudMinShapes.Value)
                Case 2
                    vx(i) = String.Format("{0:00}", nudGS.Value)
                Case 3
                    If rbn1.Checked = True Then
                        vx(i) = 1
                    ElseIf rbn2.Checked = True Then
                        vx(i) = 2
                    ElseIf rbn4.Checked = True Then
                        vx(i) = 4
                    End If
            End Select
        Next
        'establish file writer
        Using outputFile As New IO.StreamWriter("data.txt")
            'loop through colour data array and output it to the text file
            For i As Integer = 1 To 5
                outputFile.WriteLine(cx(i))
            Next
            'loop through other data array and output it to the text file
            For i As Integer = 0 To 4
                outputFile.WriteLine(vx(i))
            Next
        End Using
        Dim s As String
        s = "..\..\..\..\Pattern_Generator_v6\application.windows64\Pattern_Generator_open.bat"
        's = "C:\Users\lyo0007\Desktop\School\2018\SoftDev\SAT\PART_B\Pattern_Generator_v5\application.windows64\Pattern_Generator_v5.exe"
        's = "C:/Users/lyo0007/Desktop/School/2018/SoftDev/SAT/PART_B/Pattern_Generator_v5/application.windows64/Pattern_Generator_v5.exe"
        Process.Start(s)
        'Shell(s, AppWinStyle.NormalFocus) < testing 
    End Sub
End Class


'Shell(s, AppWinStyle.NormalFocus)
