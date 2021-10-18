<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputParameters
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
        Me.lblColourSelect = New System.Windows.Forms.Label()
        Me.colourselector1 = New System.Windows.Forms.Button()
        Me.colourselector2 = New System.Windows.Forms.Button()
        Me.colourselector3 = New System.Windows.Forms.Button()
        Me.colourselector4 = New System.Windows.Forms.Button()
        Me.colourselector5 = New System.Windows.Forms.Button()
        Me.nudMaxShapes = New System.Windows.Forms.NumericUpDown()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.nudMinShapes = New System.Windows.Forms.NumericUpDown()
        Me.lblGS = New System.Windows.Forms.Label()
        Me.nudGS = New System.Windows.Forms.NumericUpDown()
        Me.lblRC = New System.Windows.Forms.Label()
        Me.rbn1 = New System.Windows.Forms.RadioButton()
        Me.rbn2 = New System.Windows.Forms.RadioButton()
        Me.rbn4 = New System.Windows.Forms.RadioButton()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnRandomise = New System.Windows.Forms.Button()
        Me.ColDialog = New System.Windows.Forms.ColorDialog()
        CType(Me.nudMaxShapes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinShapes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblColourSelect
        '
        Me.lblColourSelect.AutoSize = True
        Me.lblColourSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblColourSelect.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColourSelect.ForeColor = System.Drawing.Color.Snow
        Me.lblColourSelect.Location = New System.Drawing.Point(218, 23)
        Me.lblColourSelect.Name = "lblColourSelect"
        Me.lblColourSelect.Size = New System.Drawing.Size(114, 21)
        Me.lblColourSelect.TabIndex = 0
        Me.lblColourSelect.Text = "Colour Palette"
        '
        'colourselector1
        '
        Me.colourselector1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.colourselector1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.colourselector1.FlatAppearance.BorderSize = 3
        Me.colourselector1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colourselector1.Location = New System.Drawing.Point(156, 62)
        Me.colourselector1.Name = "colourselector1"
        Me.colourselector1.Size = New System.Drawing.Size(38, 38)
        Me.colourselector1.TabIndex = 1
        Me.colourselector1.UseVisualStyleBackColor = False
        '
        'colourselector2
        '
        Me.colourselector2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.colourselector2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.colourselector2.FlatAppearance.BorderSize = 3
        Me.colourselector2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colourselector2.Location = New System.Drawing.Point(208, 62)
        Me.colourselector2.Name = "colourselector2"
        Me.colourselector2.Size = New System.Drawing.Size(38, 38)
        Me.colourselector2.TabIndex = 2
        Me.colourselector2.UseVisualStyleBackColor = False
        '
        'colourselector3
        '
        Me.colourselector3.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.colourselector3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.colourselector3.FlatAppearance.BorderSize = 3
        Me.colourselector3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colourselector3.Location = New System.Drawing.Point(260, 62)
        Me.colourselector3.Name = "colourselector3"
        Me.colourselector3.Size = New System.Drawing.Size(38, 38)
        Me.colourselector3.TabIndex = 3
        Me.colourselector3.UseVisualStyleBackColor = False
        '
        'colourselector4
        '
        Me.colourselector4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.colourselector4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.colourselector4.FlatAppearance.BorderSize = 3
        Me.colourselector4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colourselector4.Location = New System.Drawing.Point(312, 62)
        Me.colourselector4.Name = "colourselector4"
        Me.colourselector4.Size = New System.Drawing.Size(38, 38)
        Me.colourselector4.TabIndex = 4
        Me.colourselector4.UseVisualStyleBackColor = False
        '
        'colourselector5
        '
        Me.colourselector5.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.colourselector5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.colourselector5.FlatAppearance.BorderSize = 3
        Me.colourselector5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colourselector5.Location = New System.Drawing.Point(364, 62)
        Me.colourselector5.Name = "colourselector5"
        Me.colourselector5.Size = New System.Drawing.Size(38, 38)
        Me.colourselector5.TabIndex = 5
        Me.colourselector5.UseVisualStyleBackColor = False
        '
        'nudMaxShapes
        '
        Me.nudMaxShapes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nudMaxShapes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMaxShapes.Location = New System.Drawing.Point(155, 136)
        Me.nudMaxShapes.Margin = New System.Windows.Forms.Padding(1)
        Me.nudMaxShapes.Maximum = New Decimal(New Integer() {35, 0, 0, 0})
        Me.nudMaxShapes.Name = "nudMaxShapes"
        Me.nudMaxShapes.Size = New System.Drawing.Size(42, 21)
        Me.nudMaxShapes.TabIndex = 6
        Me.nudMaxShapes.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMax.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.ForeColor = System.Drawing.Color.Snow
        Me.lblMax.Location = New System.Drawing.Point(46, 136)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(105, 21)
        Me.lblMax.TabIndex = 0
        Me.lblMax.Text = "Max. Shapes:"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMin.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.Color.Snow
        Me.lblMin.Location = New System.Drawing.Point(214, 136)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(102, 21)
        Me.lblMin.TabIndex = 0
        Me.lblMin.Text = "Min. Shapes:"
        '
        'nudMinShapes
        '
        Me.nudMinShapes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nudMinShapes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMinShapes.Location = New System.Drawing.Point(321, 136)
        Me.nudMinShapes.Margin = New System.Windows.Forms.Padding(1)
        Me.nudMinShapes.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudMinShapes.Name = "nudMinShapes"
        Me.nudMinShapes.Size = New System.Drawing.Size(42, 21)
        Me.nudMinShapes.TabIndex = 7
        Me.nudMinShapes.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblGS
        '
        Me.lblGS.AutoSize = True
        Me.lblGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGS.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGS.ForeColor = System.Drawing.Color.Snow
        Me.lblGS.Location = New System.Drawing.Point(380, 136)
        Me.lblGS.Name = "lblGS"
        Me.lblGS.Size = New System.Drawing.Size(78, 21)
        Me.lblGS.TabIndex = 0
        Me.lblGS.Text = "Grid Size:"
        '
        'nudGS
        '
        Me.nudGS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nudGS.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudGS.Location = New System.Drawing.Point(462, 136)
        Me.nudGS.Margin = New System.Windows.Forms.Padding(1)
        Me.nudGS.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudGS.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nudGS.Name = "nudGS"
        Me.nudGS.Size = New System.Drawing.Size(42, 21)
        Me.nudGS.TabIndex = 8
        Me.nudGS.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'lblRC
        '
        Me.lblRC.AutoSize = True
        Me.lblRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRC.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRC.ForeColor = System.Drawing.Color.Snow
        Me.lblRC.Location = New System.Drawing.Point(88, 194)
        Me.lblRC.Name = "lblRC"
        Me.lblRC.Size = New System.Drawing.Size(196, 21)
        Me.lblRC.TabIndex = 0
        Me.lblRC.Text = "Repetition Configuration:"
        '
        'rbn1
        '
        Me.rbn1.AutoSize = True
        Me.rbn1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbn1.ForeColor = System.Drawing.Color.White
        Me.rbn1.Location = New System.Drawing.Point(300, 193)
        Me.rbn1.Name = "rbn1"
        Me.rbn1.Size = New System.Drawing.Size(41, 24)
        Me.rbn1.TabIndex = 9
        Me.rbn1.Text = "1x"
        Me.rbn1.UseVisualStyleBackColor = True
        '
        'rbn2
        '
        Me.rbn2.AutoSize = True
        Me.rbn2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbn2.ForeColor = System.Drawing.Color.White
        Me.rbn2.Location = New System.Drawing.Point(355, 193)
        Me.rbn2.Name = "rbn2"
        Me.rbn2.Size = New System.Drawing.Size(43, 24)
        Me.rbn2.TabIndex = 10
        Me.rbn2.Text = "2x"
        Me.rbn2.UseVisualStyleBackColor = True
        '
        'rbn4
        '
        Me.rbn4.AutoSize = True
        Me.rbn4.Checked = True
        Me.rbn4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbn4.ForeColor = System.Drawing.Color.White
        Me.rbn4.Location = New System.Drawing.Point(413, 193)
        Me.rbn4.Name = "rbn4"
        Me.rbn4.Size = New System.Drawing.Size(44, 24)
        Me.rbn4.TabIndex = 11
        Me.rbn4.TabStop = True
        Me.rbn4.Text = "4x"
        Me.rbn4.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGenerate.FlatAppearance.BorderSize = 3
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(302, 267)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(1)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.btnGenerate.Size = New System.Drawing.Size(162, 50)
        Me.btnGenerate.TabIndex = 14
        Me.btnGenerate.Text = "GENERATE"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnRandomise
        '
        Me.btnRandomise.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRandomise.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRandomise.FlatAppearance.BorderSize = 3
        Me.btnRandomise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRandomise.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandomise.Location = New System.Drawing.Point(91, 267)
        Me.btnRandomise.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRandomise.Name = "btnRandomise"
        Me.btnRandomise.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.btnRandomise.Size = New System.Drawing.Size(162, 50)
        Me.btnRandomise.TabIndex = 12
        Me.btnRandomise.Text = "RANDOMISE"
        Me.btnRandomise.UseVisualStyleBackColor = False
        '
        'InputParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(558, 347)
        Me.Controls.Add(Me.btnRandomise)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.rbn4)
        Me.Controls.Add(Me.rbn2)
        Me.Controls.Add(Me.rbn1)
        Me.Controls.Add(Me.nudGS)
        Me.Controls.Add(Me.nudMinShapes)
        Me.Controls.Add(Me.nudMaxShapes)
        Me.Controls.Add(Me.colourselector5)
        Me.Controls.Add(Me.colourselector4)
        Me.Controls.Add(Me.colourselector3)
        Me.Controls.Add(Me.colourselector2)
        Me.Controls.Add(Me.colourselector1)
        Me.Controls.Add(Me.lblGS)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblRC)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblColourSelect)
        Me.Name = "InputParameters"
        Me.Text = "Pattern Generation - Input Data"
        CType(Me.nudMaxShapes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinShapes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColourSelect As System.Windows.Forms.Label
    Friend WithEvents colourselector1 As System.Windows.Forms.Button
    Friend WithEvents colourselector2 As System.Windows.Forms.Button
    Friend WithEvents colourselector3 As System.Windows.Forms.Button
    Friend WithEvents colourselector4 As System.Windows.Forms.Button
    Friend WithEvents colourselector5 As System.Windows.Forms.Button
    Friend WithEvents nudMaxShapes As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents nudMinShapes As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGS As System.Windows.Forms.Label
    Friend WithEvents nudGS As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRC As System.Windows.Forms.Label
    Friend WithEvents rbn1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbn2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbn4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnRandomise As System.Windows.Forms.Button
    Friend WithEvents ColDialog As System.Windows.Forms.ColorDialog

End Class
