<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainfall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRainfall))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMonths = New System.Windows.Forms.Label()
        Me.btnRain = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstInches = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitle.Location = New System.Drawing.Point(73, 39)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(333, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Most Rainfall in US - Kauai"
        '
        'lblMonths
        '
        Me.lblMonths.AutoSize = True
        Me.lblMonths.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonths.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblMonths.Location = New System.Drawing.Point(186, 89)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.Size = New System.Drawing.Size(116, 19)
        Me.lblMonths.TabIndex = 34
        Me.lblMonths.Text = "Rainfall Average"
        '
        'btnRain
        '
        Me.btnRain.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRain.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRain.ForeColor = System.Drawing.Color.White
        Me.btnRain.Location = New System.Drawing.Point(171, 125)
        Me.btnRain.Name = "btnRain"
        Me.btnRain.Size = New System.Drawing.Size(144, 35)
        Me.btnRain.TabIndex = 35
        Me.btnRain.Text = "Enter Rainfall"
        Me.btnRain.UseVisualStyleBackColor = False
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblAverage.Location = New System.Drawing.Point(108, 188)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(263, 22)
        Me.lblAverage.TabIndex = 36
        Me.lblAverage.Text = "XXXXXXXXX 00.0 XXXXXXX"
        Me.lblAverage.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lstInches
        '
        Me.lstInches.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInches.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lstInches.FormattingEnabled = True
        Me.lstInches.ItemHeight = 18
        Me.lstInches.Location = New System.Drawing.Point(482, 39)
        Me.lstInches.Name = "lstInches"
        Me.lstInches.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstInches.Size = New System.Drawing.Size(47, 220)
        Me.lstInches.TabIndex = 38
        '
        'frmRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(551, 282)
        Me.Controls.Add(Me.lstInches)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnRain)
        Me.Controls.Add(Me.lblMonths)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmRainfall"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblMonths As Label
    Friend WithEvents btnRain As Button
    Friend WithEvents lblAverage As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lstInches As ListBox
End Class
