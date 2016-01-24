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
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.ibOriginal = New Emgu.CV.UI.ImageBox()
        Me.cbDrawShapesOnOriginalImage = New System.Windows.Forms.CheckBox()
        Me.cbEnableColorFiltering = New System.Windows.Forms.CheckBox()
        Me.lblBlueMin = New System.Windows.Forms.Label()
        Me.lblBlueMax = New System.Windows.Forms.Label()
        Me.lblGreenMin = New System.Windows.Forms.Label()
        Me.lblGreenMax = New System.Windows.Forms.Label()
        Me.lblRedMin = New System.Windows.Forms.Label()
        Me.lblRedMax = New System.Windows.Forms.Label()
        Me.cbShowSteps = New System.Windows.Forms.CheckBox()
        Me.cbUseWebcam = New System.Windows.Forms.CheckBox()
        Me.lblChosenFile = New System.Windows.Forms.Label()
        Me.tbBlueMin = New System.Windows.Forms.TrackBar()
        Me.tbBlueMax = New System.Windows.Forms.TrackBar()
        Me.tbGreenMin = New System.Windows.Forms.TrackBar()
        Me.tbGreenMax = New System.Windows.Forms.TrackBar()
        Me.tbRedMin = New System.Windows.Forms.TrackBar()
        Me.tbRedMax = New System.Windows.Forms.TrackBar()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.tableLayoutPanel.SuspendLayout
        CType(Me.ibOriginal,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbBlueMin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbBlueMax,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbGreenMin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbGreenMax,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbRedMin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbRedMax,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'tableLayoutPanel
        '
        Me.tableLayoutPanel.ColumnCount = 4
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tableLayoutPanel.Controls.Add(Me.btnOpenFile, 0, 0)
        Me.tableLayoutPanel.Controls.Add(Me.ibOriginal, 0, 1)
        Me.tableLayoutPanel.Controls.Add(Me.cbDrawShapesOnOriginalImage, 0, 2)
        Me.tableLayoutPanel.Controls.Add(Me.cbEnableColorFiltering, 0, 3)
        Me.tableLayoutPanel.Controls.Add(Me.lblBlueMin, 0, 4)
        Me.tableLayoutPanel.Controls.Add(Me.lblBlueMax, 0, 5)
        Me.tableLayoutPanel.Controls.Add(Me.lblGreenMin, 0, 6)
        Me.tableLayoutPanel.Controls.Add(Me.lblGreenMax, 0, 7)
        Me.tableLayoutPanel.Controls.Add(Me.lblRedMin, 0, 8)
        Me.tableLayoutPanel.Controls.Add(Me.lblRedMax, 0, 9)
        Me.tableLayoutPanel.Controls.Add(Me.cbShowSteps, 3, 0)
        Me.tableLayoutPanel.Controls.Add(Me.cbUseWebcam, 2, 0)
        Me.tableLayoutPanel.Controls.Add(Me.lblChosenFile, 1, 0)
        Me.tableLayoutPanel.Controls.Add(Me.tbBlueMin, 1, 4)
        Me.tableLayoutPanel.Controls.Add(Me.tbBlueMax, 1, 5)
        Me.tableLayoutPanel.Controls.Add(Me.tbGreenMin, 1, 6)
        Me.tableLayoutPanel.Controls.Add(Me.tbGreenMax, 1, 7)
        Me.tableLayoutPanel.Controls.Add(Me.tbRedMin, 1, 8)
        Me.tableLayoutPanel.Controls.Add(Me.tbRedMax, 1, 9)
        Me.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel.Name = "tableLayoutPanel"
        Me.tableLayoutPanel.RowCount = 10
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel.Size = New System.Drawing.Size(1250, 818)
        Me.tableLayoutPanel.TabIndex = 0
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnOpenFile.AutoSize = true
        Me.btnOpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnOpenFile.Location = New System.Drawing.Point(3, 3)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(174, 35)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Open File"
        Me.btnOpenFile.UseVisualStyleBackColor = true
        '
        'ibOriginal
        '
        Me.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tableLayoutPanel.SetColumnSpan(Me.ibOriginal, 4)
        Me.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ibOriginal.Enabled = false
        Me.ibOriginal.Location = New System.Drawing.Point(3, 44)
        Me.ibOriginal.Name = "ibOriginal"
        Me.ibOriginal.Size = New System.Drawing.Size(1244, 329)
        Me.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ibOriginal.TabIndex = 2
        Me.ibOriginal.TabStop = false
        '
        'cbDrawShapesOnOriginalImage
        '
        Me.cbDrawShapesOnOriginalImage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbDrawShapesOnOriginalImage.AutoSize = true
        Me.cbDrawShapesOnOriginalImage.Checked = true
        Me.cbDrawShapesOnOriginalImage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tableLayoutPanel.SetColumnSpan(Me.cbDrawShapesOnOriginalImage, 3)
        Me.cbDrawShapesOnOriginalImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbDrawShapesOnOriginalImage.Location = New System.Drawing.Point(3, 379)
        Me.cbDrawShapesOnOriginalImage.Name = "cbDrawShapesOnOriginalImage"
        Me.cbDrawShapesOnOriginalImage.Size = New System.Drawing.Size(315, 29)
        Me.cbDrawShapesOnOriginalImage.TabIndex = 5
        Me.cbDrawShapesOnOriginalImage.Text = "Draw Shapes On Original Image"
        Me.cbDrawShapesOnOriginalImage.UseVisualStyleBackColor = true
        '
        'cbEnableColorFiltering
        '
        Me.cbEnableColorFiltering.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbEnableColorFiltering.AutoSize = true
        Me.tableLayoutPanel.SetColumnSpan(Me.cbEnableColorFiltering, 3)
        Me.cbEnableColorFiltering.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbEnableColorFiltering.Location = New System.Drawing.Point(3, 414)
        Me.cbEnableColorFiltering.Name = "cbEnableColorFiltering"
        Me.cbEnableColorFiltering.Size = New System.Drawing.Size(220, 29)
        Me.cbEnableColorFiltering.TabIndex = 6
        Me.cbEnableColorFiltering.Text = "Enable Color Filtering"
        Me.cbEnableColorFiltering.UseVisualStyleBackColor = true
        '
        'lblBlueMin
        '
        Me.lblBlueMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblBlueMin.AutoSize = true
        Me.lblBlueMin.Enabled = false
        Me.lblBlueMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBlueMin.Location = New System.Drawing.Point(3, 459)
        Me.lblBlueMin.Name = "lblBlueMin"
        Me.lblBlueMin.Padding = New System.Windows.Forms.Padding(5)
        Me.lblBlueMin.Size = New System.Drawing.Size(174, 35)
        Me.lblBlueMin.TabIndex = 7
        Me.lblBlueMin.Text = "Blue Min =   0"
        Me.lblBlueMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBlueMax
        '
        Me.lblBlueMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblBlueMax.AutoSize = true
        Me.lblBlueMax.Enabled = false
        Me.lblBlueMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBlueMax.Location = New System.Drawing.Point(3, 521)
        Me.lblBlueMax.Name = "lblBlueMax"
        Me.lblBlueMax.Padding = New System.Windows.Forms.Padding(5)
        Me.lblBlueMax.Size = New System.Drawing.Size(174, 35)
        Me.lblBlueMax.TabIndex = 8
        Me.lblBlueMax.Text = "Blue Max = 255"
        Me.lblBlueMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGreenMin
        '
        Me.lblGreenMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblGreenMin.AutoSize = true
        Me.lblGreenMin.Enabled = false
        Me.lblGreenMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGreenMin.Location = New System.Drawing.Point(3, 583)
        Me.lblGreenMin.Name = "lblGreenMin"
        Me.lblGreenMin.Padding = New System.Windows.Forms.Padding(5)
        Me.lblGreenMin.Size = New System.Drawing.Size(174, 35)
        Me.lblGreenMin.TabIndex = 9
        Me.lblGreenMin.Text = "Green Min =   0"
        Me.lblGreenMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGreenMax
        '
        Me.lblGreenMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblGreenMax.AutoSize = true
        Me.lblGreenMax.Enabled = false
        Me.lblGreenMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGreenMax.Location = New System.Drawing.Point(3, 645)
        Me.lblGreenMax.Name = "lblGreenMax"
        Me.lblGreenMax.Padding = New System.Windows.Forms.Padding(5)
        Me.lblGreenMax.Size = New System.Drawing.Size(174, 35)
        Me.lblGreenMax.TabIndex = 10
        Me.lblGreenMax.Text = "Green Max = 255"
        Me.lblGreenMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRedMin
        '
        Me.lblRedMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblRedMin.AutoSize = true
        Me.lblRedMin.Enabled = false
        Me.lblRedMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRedMin.Location = New System.Drawing.Point(3, 707)
        Me.lblRedMin.Name = "lblRedMin"
        Me.lblRedMin.Padding = New System.Windows.Forms.Padding(5)
        Me.lblRedMin.Size = New System.Drawing.Size(174, 35)
        Me.lblRedMin.TabIndex = 11
        Me.lblRedMin.Text = "Red Min =   0"
        Me.lblRedMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRedMax
        '
        Me.lblRedMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblRedMax.AutoSize = true
        Me.lblRedMax.Enabled = false
        Me.lblRedMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRedMax.Location = New System.Drawing.Point(3, 769)
        Me.lblRedMax.Name = "lblRedMax"
        Me.lblRedMax.Padding = New System.Windows.Forms.Padding(5)
        Me.lblRedMax.Size = New System.Drawing.Size(174, 35)
        Me.lblRedMax.TabIndex = 12
        Me.lblRedMax.Text = "Red Max = 255"
        Me.lblRedMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbShowSteps
        '
        Me.cbShowSteps.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbShowSteps.AutoSize = true
        Me.cbShowSteps.Checked = true
        Me.cbShowSteps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbShowSteps.Location = New System.Drawing.Point(1107, 6)
        Me.cbShowSteps.Name = "cbShowSteps"
        Me.cbShowSteps.Size = New System.Drawing.Size(140, 29)
        Me.cbShowSteps.TabIndex = 2
        Me.cbShowSteps.Text = "Show Steps"
        Me.cbShowSteps.UseVisualStyleBackColor = true
        '
        'cbUseWebcam
        '
        Me.cbUseWebcam.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbUseWebcam.AutoSize = true
        Me.cbUseWebcam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbUseWebcam.Location = New System.Drawing.Point(948, 6)
        Me.cbUseWebcam.Name = "cbUseWebcam"
        Me.cbUseWebcam.Size = New System.Drawing.Size(153, 29)
        Me.cbUseWebcam.TabIndex = 4
        Me.cbUseWebcam.Text = "Use Webcam"
        Me.cbUseWebcam.UseVisualStyleBackColor = true
        '
        'lblChosenFile
        '
        Me.lblChosenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblChosenFile.AutoSize = true
        Me.lblChosenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblChosenFile.Location = New System.Drawing.Point(183, 8)
        Me.lblChosenFile.Name = "lblChosenFile"
        Me.lblChosenFile.Size = New System.Drawing.Size(759, 25)
        Me.lblChosenFile.TabIndex = 13
        Me.lblChosenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbBlueMin
        '
        Me.tableLayoutPanel.SetColumnSpan(Me.tbBlueMin, 3)
        Me.tbBlueMin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbBlueMin.Enabled = false
        Me.tbBlueMin.Location = New System.Drawing.Point(183, 449)
        Me.tbBlueMin.Maximum = 255
        Me.tbBlueMin.Name = "tbBlueMin"
        Me.tbBlueMin.Size = New System.Drawing.Size(1064, 56)
        Me.tbBlueMin.TabIndex = 14
        '
        'tbBlueMax
        '
        Me.tableLayoutPanel.SetColumnSpan(Me.tbBlueMax, 3)
        Me.tbBlueMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbBlueMax.Enabled = false
        Me.tbBlueMax.Location = New System.Drawing.Point(183, 511)
        Me.tbBlueMax.Maximum = 255
        Me.tbBlueMax.Name = "tbBlueMax"
        Me.tbBlueMax.Size = New System.Drawing.Size(1064, 56)
        Me.tbBlueMax.TabIndex = 15
        Me.tbBlueMax.Value = 255
        '
        'tbGreenMin
        '
        Me.tableLayoutPanel.SetColumnSpan(Me.tbGreenMin, 3)
        Me.tbGreenMin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbGreenMin.Enabled = false
        Me.tbGreenMin.Location = New System.Drawing.Point(183, 573)
        Me.tbGreenMin.Maximum = 255
        Me.tbGreenMin.Name = "tbGreenMin"
        Me.tbGreenMin.Size = New System.Drawing.Size(1064, 56)
        Me.tbGreenMin.TabIndex = 16
        '
        'tbGreenMax
        '
        Me.tableLayoutPanel.SetColumnSpan(Me.tbGreenMax, 3)
        Me.tbGreenMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbGreenMax.Enabled = false
        Me.tbGreenMax.Location = New System.Drawing.Point(183, 635)
        Me.tbGreenMax.Maximum = 255
        Me.tbGreenMax.Name = "tbGreenMax"
        Me.tbGreenMax.Size = New System.Drawing.Size(1064, 56)
        Me.tbGreenMax.TabIndex = 17
        Me.tbGreenMax.Value = 255
        '
        'tbRedMin
        '
        Me.tableLayoutPanel.SetColumnSpan(Me.tbRedMin, 3)
        Me.tbRedMin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbRedMin.Enabled = false
        Me.tbRedMin.Location = New System.Drawing.Point(183, 697)
        Me.tbRedMin.Maximum = 255
        Me.tbRedMin.Name = "tbRedMin"
        Me.tbRedMin.Size = New System.Drawing.Size(1064, 56)
        Me.tbRedMin.TabIndex = 18
        '
        'tbRedMax
        '
        Me.tableLayoutPanel.SetColumnSpan(Me.tbRedMax, 3)
        Me.tbRedMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbRedMax.Enabled = false
        Me.tbRedMax.Location = New System.Drawing.Point(183, 759)
        Me.tbRedMax.Maximum = 255
        Me.tbRedMax.Name = "tbRedMax"
        Me.tbRedMax.Size = New System.Drawing.Size(1064, 56)
        Me.tbRedMax.TabIndex = 19
        Me.tbRedMax.Value = 255
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 818)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.tableLayoutPanel.ResumeLayout(false)
        Me.tableLayoutPanel.PerformLayout
        CType(Me.ibOriginal,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbBlueMin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbBlueMax,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbGreenMin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbGreenMax,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbRedMin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbRedMax,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents tableLayoutPanel As TableLayoutPanel
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents cbShowSteps As CheckBox
    Friend WithEvents ibOriginal As Emgu.CV.UI.ImageBox
    Friend WithEvents ofdOpenFile As OpenFileDialog
    Friend WithEvents cbUseWebcam As CheckBox
    Friend WithEvents cbDrawShapesOnOriginalImage As CheckBox
    Friend WithEvents cbEnableColorFiltering As CheckBox
    Friend WithEvents lblBlueMin As Label
    Friend WithEvents lblBlueMax As Label
    Friend WithEvents lblGreenMin As Label
    Friend WithEvents lblGreenMax As Label
    Friend WithEvents lblRedMin As Label
    Friend WithEvents lblRedMax As Label
    Friend WithEvents lblChosenFile As Label
    Friend WithEvents tbBlueMin As TrackBar
    Friend WithEvents tbBlueMax As TrackBar
    Friend WithEvents tbGreenMin As TrackBar
    Friend WithEvents tbGreenMax As TrackBar
    Friend WithEvents tbRedMin As TrackBar
    Friend WithEvents tbRedMax As TrackBar
End Class
