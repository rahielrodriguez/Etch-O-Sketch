<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchOSketchFrom
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
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.TopMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.XTrackBar = New System.Windows.Forms.TrackBar()
        Me.YTrackBar = New System.Windows.Forms.TrackBar()
        Me.XLabel = New System.Windows.Forms.Label()
        Me.YLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PotsRadioButton = New System.Windows.Forms.RadioButton()
        Me.SlidersRadioButton = New System.Windows.Forms.RadioButton()
        Me.PortComboBox = New System.Windows.Forms.ComboBox()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TopMenu.SuspendLayout()
        CType(Me.XTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.SystemColors.Window
        Me.DrawingPictureBox.ContextMenuStrip = Me.ContextMenu
        Me.DrawingPictureBox.Location = New System.Drawing.Point(0, 31)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(966, 268)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        Me.ToolTip.SetToolTip(Me.DrawingPictureBox, "Displays a Sine Wave, Cosine Wave and a Tangent Wave if Draw Waveforms Button is " &
        "presses. Also by presing the left button of your mouse or mousepad you can draw " &
        "along the Picture Box.")
        '
        'ContextMenu
        '
        Me.ContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ContextMenu.Name = "ContextMenuStrip"
        Me.ContextMenu.Size = New System.Drawing.Size(111, 76)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ComButton)
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.SelectColorButton)
        Me.GroupBox1.Controls.Add(Me.DrawWaveformsButton)
        Me.GroupBox1.Location = New System.Drawing.Point(485, 338)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 201)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ComButton
        '
        Me.ComButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ComButton.Location = New System.Drawing.Point(312, 21)
        Me.ComButton.Name = "ComButton"
        Me.ComButton.Size = New System.Drawing.Size(147, 71)
        Me.ComButton.TabIndex = 4
        Me.ComButton.Text = "Co&m"
        Me.ToolTip.SetToolTip(Me.ComButton, "Closes the program")
        Me.ComButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(159, 108)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(147, 71)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Closes the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(159, 21)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(147, 71)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip.SetToolTip(Me.ClearButton, "Clears all the picture box")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(6, 108)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(147, 71)
        Me.SelectColorButton.TabIndex = 1
        Me.SelectColorButton.Text = "&Select Color"
        Me.ToolTip.SetToolTip(Me.SelectColorButton, "By pressing this button a color selector will be displayed in order to change the" &
        " color of the drawing")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(6, 21)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(147, 71)
        Me.DrawWaveformsButton.TabIndex = 0
        Me.DrawWaveformsButton.Text = "&Draw Waveforms"
        Me.ToolTip.SetToolTip(Me.DrawWaveformsButton, "By pressing this button a Sine Wave, a Cosine Wave and a Tangent Wave will be dis" &
        "played along the picture box")
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'TopMenu
        '
        Me.TopMenu.ContextMenuStrip = Me.ContextMenu
        Me.TopMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.EditToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.TopMenu.Location = New System.Drawing.Point(0, 0)
        Me.TopMenu.Name = "TopMenu"
        Me.TopMenu.Size = New System.Drawing.Size(966, 28)
        Me.TopMenu.TabIndex = 3
        Me.TopMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem1, Me.DrawWaveformsToolStripMenuItem1, Me.ClearToolStripMenuItem1})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'SelectColorToolStripMenuItem1
        '
        Me.SelectColorToolStripMenuItem1.Name = "SelectColorToolStripMenuItem1"
        Me.SelectColorToolStripMenuItem1.Size = New System.Drawing.Size(205, 26)
        Me.SelectColorToolStripMenuItem1.Text = "Select Color"
        '
        'DrawWaveformsToolStripMenuItem1
        '
        Me.DrawWaveformsToolStripMenuItem1.Name = "DrawWaveformsToolStripMenuItem1"
        Me.DrawWaveformsToolStripMenuItem1.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsToolStripMenuItem1.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(205, 26)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'XTrackBar
        '
        Me.XTrackBar.Location = New System.Drawing.Point(6, 30)
        Me.XTrackBar.Name = "XTrackBar"
        Me.XTrackBar.Size = New System.Drawing.Size(300, 56)
        Me.XTrackBar.TabIndex = 4
        '
        'YTrackBar
        '
        Me.YTrackBar.Location = New System.Drawing.Point(12, 122)
        Me.YTrackBar.Name = "YTrackBar"
        Me.YTrackBar.Size = New System.Drawing.Size(300, 56)
        Me.YTrackBar.TabIndex = 5
        '
        'XLabel
        '
        Me.XLabel.AutoSize = True
        Me.XLabel.Location = New System.Drawing.Point(12, 15)
        Me.XLabel.Name = "XLabel"
        Me.XLabel.Size = New System.Drawing.Size(53, 16)
        Me.XLabel.TabIndex = 6
        Me.XLabel.Text = "X Slider"
        '
        'YLabel
        '
        Me.YLabel.AutoSize = True
        Me.YLabel.Location = New System.Drawing.Point(12, 91)
        Me.YLabel.Name = "YLabel"
        Me.YLabel.Size = New System.Drawing.Size(54, 16)
        Me.YLabel.TabIndex = 7
        Me.YLabel.Text = "Y Slider"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.XTrackBar)
        Me.GroupBox2.Controls.Add(Me.YTrackBar)
        Me.GroupBox2.Controls.Add(Me.YLabel)
        Me.GroupBox2.Controls.Add(Me.XLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 194)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'PotsRadioButton
        '
        Me.PotsRadioButton.AutoSize = True
        Me.PotsRadioButton.Location = New System.Drawing.Point(6, 59)
        Me.PotsRadioButton.Name = "PotsRadioButton"
        Me.PotsRadioButton.Size = New System.Drawing.Size(118, 20)
        Me.PotsRadioButton.TabIndex = 11
        Me.PotsRadioButton.Text = "Potentiometers"
        Me.PotsRadioButton.UseVisualStyleBackColor = True
        '
        'SlidersRadioButton
        '
        Me.SlidersRadioButton.AutoSize = True
        Me.SlidersRadioButton.Checked = True
        Me.SlidersRadioButton.Location = New System.Drawing.Point(6, 33)
        Me.SlidersRadioButton.Name = "SlidersRadioButton"
        Me.SlidersRadioButton.Size = New System.Drawing.Size(70, 20)
        Me.SlidersRadioButton.TabIndex = 10
        Me.SlidersRadioButton.TabStop = True
        Me.SlidersRadioButton.Text = "Sliders"
        Me.SlidersRadioButton.UseVisualStyleBackColor = True
        '
        'PortComboBox
        '
        Me.PortComboBox.FormattingEnabled = True
        Me.PortComboBox.Location = New System.Drawing.Point(12, 305)
        Me.PortComboBox.Name = "PortComboBox"
        Me.PortComboBox.Size = New System.Drawing.Size(300, 24)
        Me.PortComboBox.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SlidersRadioButton)
        Me.GroupBox3.Controls.Add(Me.PotsRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(336, 437)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(131, 100)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'EtchOSketchFrom
        '
        Me.AcceptButton = Me.DrawWaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(966, 549)
        Me.ContextMenuStrip = Me.ContextMenu
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PortComboBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TopMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.MainMenuStrip = Me.TopMenu
        Me.Name = "EtchOSketchFrom"
        Me.Text = "Etch-O-Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TopMenu.ResumeLayout(False)
        Me.TopMenu.PerformLayout()
        CType(Me.XTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents ContextMenu As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TopMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents XTrackBar As TrackBar
    Friend WithEvents YTrackBar As TrackBar
    Friend WithEvents XLabel As Label
    Friend WithEvents YLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PortComboBox As ComboBox
    Friend WithEvents PotsRadioButton As RadioButton
    Friend WithEvents SlidersRadioButton As RadioButton
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents ComButton As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
