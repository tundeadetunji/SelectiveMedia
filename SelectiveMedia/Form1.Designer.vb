<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.PicturePath = New System.Windows.Forms.TextBox()
		Me.Feedback = New System.Windows.Forms.TextBox()
		Me.TimeTimer = New System.Windows.Forms.Timer(Me.components)
		Me.HelpButton = New System.Windows.Forms.PictureBox()
		Me.CloseButton = New System.Windows.Forms.Label()
		Me.MinimizeButton = New System.Windows.Forms.Label()
		Me.SystemCloseButton = New System.Windows.Forms.Button()
		Me.DialogTitle = New System.Windows.Forms.Label()
		Me.BottomLine = New System.Windows.Forms.PictureBox()
		Me.TopLine = New System.Windows.Forms.PictureBox()
		Me.BottomBorder = New System.Windows.Forms.PictureBox()
		Me.RightBorder = New System.Windows.Forms.PictureBox()
		Me.LeftBorder = New System.Windows.Forms.PictureBox()
		Me.TopBorder = New System.Windows.Forms.PictureBox()
		Me.TimeLabel = New System.Windows.Forms.Label()
		Me.EmptyButton = New System.Windows.Forms.Button()
		Me.tAdult = New System.Windows.Forms.TextBox()
		Me.tFilm = New System.Windows.Forms.TextBox()
		Me.tCartoon = New System.Windows.Forms.TextBox()
		Me.L1 = New System.Windows.Forms.ListBox()
		Me.L2 = New System.Windows.Forms.ListBox()
		Me.L3 = New System.Windows.Forms.ListBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.folder_counter_ = New System.Windows.Forms.TextBox()
		Me.file_counter_ = New System.Windows.Forms.TextBox()
		Me.EndDate = New System.Windows.Forms.DateTimePicker()
		Me.BeginDate = New System.Windows.Forms.DateTimePicker()
		Me.time_counter_ = New System.Windows.Forms.TextBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.tWallpaperAdult = New System.Windows.Forms.TextBox()
		Me.tWallpaperRegular = New System.Windows.Forms.TextBox()
		Me.DayWTimer = New System.Windows.Forms.Timer(Me.components)
		Me.NWTimer = New System.Windows.Forms.Timer(Me.components)
		Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OutTimer = New System.Windows.Forms.Timer(Me.components)
		Me.L4 = New System.Windows.Forms.ListBox()
		Me.InTimer = New System.Windows.Forms.Timer(Me.components)
		Me.WTimer = New System.Windows.Forms.Timer(Me.components)
		Me.MediaTimer = New System.Windows.Forms.Timer(Me.components)
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.RecordSerialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.FileDataSet = New SelectiveMedia.FileDataSet()
		Me.FileCounterAValue = New System.Windows.Forms.TextBox()
		Me.FileCounterBValue = New System.Windows.Forms.TextBox()
		Me.BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.BDataSet = New SelectiveMedia.FileDataSet()
		Me.FileCounterCValue = New System.Windows.Forms.TextBox()
		Me.CBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.CDataSet = New SelectiveMedia.FileDataSet()
		Me.SettingA = New System.Windows.Forms.TextBox()
		Me.Settings_DataSet = New SelectiveMedia.FileDataSet()
		Me.SettingB = New System.Windows.Forms.TextBox()
		Me.SettingC = New System.Windows.Forms.TextBox()
		Me.SettingD = New System.Windows.Forms.TextBox()
		Me.FileCountA = New System.Windows.Forms.TextBox()
		Me.FileCountDataSet = New SelectiveMedia.FileDataSet()
		Me.FileCountB = New System.Windows.Forms.TextBox()
		Me.FileCountC = New System.Windows.Forms.TextBox()
		Me.SoFarA = New System.Windows.Forms.TextBox()
		Me.SoFarDataSet = New SelectiveMedia.FileDataSet()
		Me.SoFarB = New System.Windows.Forms.TextBox()
		Me.SoFarC = New System.Windows.Forms.TextBox()
		Me.SettingE = New System.Windows.Forms.TextBox()
		Me.SettingF = New System.Windows.Forms.TextBox()
		Me.L5 = New System.Windows.Forms.ListBox()
		Me.FileCountD = New System.Windows.Forms.TextBox()
		Me.FileCountE = New System.Windows.Forms.TextBox()
		Me.SoFarD = New System.Windows.Forms.TextBox()
		Me.SoFarE = New System.Windows.Forms.TextBox()
		Me.FileCounterEValue = New System.Windows.Forms.TextBox()
		Me.EBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.EDataSet = New SelectiveMedia.FileDataSet()
		Me.FolderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.FolderDataSet = New SelectiveMedia.FileDataSet()
		Me.FileTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.DialogTableAdapter()
		Me.FolderTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.DialogTableAdapter()
		Me.FolderCounterTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.DialogTableAdapter()
		Me.FileCounterATableAdapter = New SelectiveMedia.FileDataSetTableAdapters.DialogTableAdapter()
		Me.WhereFolderTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.DialogTableAdapter()
		Me.WhereFileTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.DialogTableAdapter()
		Me.Settings_TableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SettingNTableAdapter()
		Me.FileCountTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.FileCountTableAdapter()
		Me.BTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SettingBTableAdapter()
		Me.CTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SettingCTableAdapter()
		Me.SoFarTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SoFarTableAdapter()
		Me.FileCounterBTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SettingBTableAdapter()
		Me.FileCounterCTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SettingCTableAdapter()
		Me.FileCounterETableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SettingETableAdapter()
		Me.ETableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SettingETableAdapter()
		Me.ACountTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.DialogTableAdapter()
		Me.BCountTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SettingBTableAdapter()
		Me.CCountTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SettingCTableAdapter()
		Me.ECountTableAdapter = New SelectiveMedia.FileDataSetTableAdapters.SettingETableAdapter()
		Me.cPlayer = New System.Windows.Forms.ComboBox()
		Me.set_player_ = New System.Windows.Forms.TextBox()
		Me.MenuStrip = New System.Windows.Forms.MenuStrip()
		Me.TasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripSeparator()
		Me.CheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripSeparator()
		Me.UserToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripSeparator()
		Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripSeparator()
		Me.NewEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
		Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripSeparator()
		Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator()
		Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EnglishLanguage = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.FrenchLanguage = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ThaiLanguage = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.YorubaLanguage = New System.Windows.Forms.ToolStripMenuItem()
		Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ClassicThemes = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
		Me.LavenderThemes = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
		Me.NightThemes = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
		Me.RoseThemes = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
		Me.StandardThemes = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ApplicationFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MessagePromptOnly = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
		Me.MessagePromptWithVoice = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
		Me.VoiceOnly = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
		Me.DefaultActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
		Me.GreenTheme = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.TurqoiseTheme = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.VelvetTheme = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
		Me.PurpleTheme = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
		Me.WhiteTheme = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
		Me.BrownTheme = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
		Me.YellowTheme = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
		Me.ThemeBackground = New System.Windows.Forms.ToolStripMenuItem()
		Me.ThemeSelectBackground = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripSeparator()
		Me.ThemeClearBackground = New System.Windows.Forms.ToolStripMenuItem()
		Me.MaximizeButton = New System.Windows.Forms.Label()
		Me.TitleBar = New System.Windows.Forms.PictureBox()
		Me.FooterBar = New System.Windows.Forms.PictureBox()
		CType(Me.HelpButton, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BottomLine, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TopLine, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BottomBorder, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RightBorder, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LeftBorder, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TopBorder, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ContextMenuStrip1.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FileDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Settings_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FileCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SoFarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FolderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FolderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip.SuspendLayout()
		CType(Me.TitleBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FooterBar, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PicturePath
		'
		Me.PicturePath.Location = New System.Drawing.Point(622, 112)
		Me.PicturePath.Name = "PicturePath"
		Me.PicturePath.Size = New System.Drawing.Size(100, 26)
		Me.PicturePath.TabIndex = 14587
		Me.PicturePath.TabStop = False
		'
		'Feedback
		'
		Me.Feedback.Location = New System.Drawing.Point(764, 165)
		Me.Feedback.Multiline = True
		Me.Feedback.Name = "Feedback"
		Me.Feedback.ReadOnly = True
		Me.Feedback.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.Feedback.Size = New System.Drawing.Size(204, 52)
		Me.Feedback.TabIndex = 14584
		Me.Feedback.TabStop = False
		'
		'TimeTimer
		'
		Me.TimeTimer.Interval = 1000
		'
		'HelpButton
		'
		Me.HelpButton.BackColor = System.Drawing.Color.Transparent
		Me.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.HelpButton.Location = New System.Drawing.Point(554, 176)
		Me.HelpButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.HelpButton.Name = "HelpButton"
		Me.HelpButton.Size = New System.Drawing.Size(30, 31)
		Me.HelpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.HelpButton.TabIndex = 14583
		Me.HelpButton.TabStop = False
		'
		'CloseButton
		'
		Me.CloseButton.AutoSize = True
		Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CloseButton.Location = New System.Drawing.Point(641, 151)
		Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.CloseButton.Name = "CloseButton"
		Me.CloseButton.Size = New System.Drawing.Size(21, 20)
		Me.CloseButton.TabIndex = 14582
		Me.CloseButton.Tag = ""
		Me.CloseButton.Text = "X"
		'
		'MinimizeButton
		'
		Me.MinimizeButton.AutoSize = True
		Me.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.MinimizeButton.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MinimizeButton.Location = New System.Drawing.Point(581, 136)
		Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MinimizeButton.Name = "MinimizeButton"
		Me.MinimizeButton.Size = New System.Drawing.Size(18, 21)
		Me.MinimizeButton.TabIndex = 14581
		Me.MinimizeButton.Text = "_"
		'
		'SystemCloseButton
		'
		Me.SystemCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.SystemCloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SystemCloseButton.Location = New System.Drawing.Point(746, 367)
		Me.SystemCloseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.SystemCloseButton.Name = "SystemCloseButton"
		Me.SystemCloseButton.Size = New System.Drawing.Size(112, 40)
		Me.SystemCloseButton.TabIndex = 14580
		Me.SystemCloseButton.TabStop = False
		Me.SystemCloseButton.Text = "Commit"
		Me.SystemCloseButton.UseVisualStyleBackColor = True
		'
		'DialogTitle
		'
		Me.DialogTitle.AutoSize = True
		Me.DialogTitle.Cursor = System.Windows.Forms.Cursors.Hand
		Me.DialogTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DialogTitle.Location = New System.Drawing.Point(478, 151)
		Me.DialogTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.DialogTitle.Name = "DialogTitle"
		Me.DialogTitle.Size = New System.Drawing.Size(0, 20)
		Me.DialogTitle.TabIndex = 14579
		'
		'BottomLine
		'
		Me.BottomLine.BackColor = System.Drawing.Color.Black
		Me.BottomLine.Location = New System.Drawing.Point(545, 260)
		Me.BottomLine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BottomLine.Name = "BottomLine"
		Me.BottomLine.Size = New System.Drawing.Size(795, 2)
		Me.BottomLine.TabIndex = 14578
		Me.BottomLine.TabStop = False
		'
		'TopLine
		'
		Me.TopLine.BackColor = System.Drawing.Color.Black
		Me.TopLine.Location = New System.Drawing.Point(540, 241)
		Me.TopLine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TopLine.Name = "TopLine"
		Me.TopLine.Size = New System.Drawing.Size(795, 2)
		Me.TopLine.TabIndex = 14577
		Me.TopLine.TabStop = False
		'
		'BottomBorder
		'
		Me.BottomBorder.Location = New System.Drawing.Point(554, 291)
		Me.BottomBorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.BottomBorder.Name = "BottomBorder"
		Me.BottomBorder.Size = New System.Drawing.Size(118, 20)
		Me.BottomBorder.TabIndex = 14576
		Me.BottomBorder.TabStop = False
		'
		'RightBorder
		'
		Me.RightBorder.Location = New System.Drawing.Point(554, 367)
		Me.RightBorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.RightBorder.Name = "RightBorder"
		Me.RightBorder.Size = New System.Drawing.Size(118, 20)
		Me.RightBorder.TabIndex = 14574
		Me.RightBorder.TabStop = False
		'
		'LeftBorder
		'
		Me.LeftBorder.Location = New System.Drawing.Point(554, 321)
		Me.LeftBorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.LeftBorder.Name = "LeftBorder"
		Me.LeftBorder.Size = New System.Drawing.Size(118, 20)
		Me.LeftBorder.TabIndex = 14573
		Me.LeftBorder.TabStop = False
		'
		'TopBorder
		'
		Me.TopBorder.Location = New System.Drawing.Point(554, 337)
		Me.TopBorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TopBorder.Name = "TopBorder"
		Me.TopBorder.Size = New System.Drawing.Size(118, 20)
		Me.TopBorder.TabIndex = 14575
		Me.TopBorder.TabStop = False
		'
		'TimeLabel
		'
		Me.TimeLabel.AutoSize = True
		Me.TimeLabel.Location = New System.Drawing.Point(510, 210)
		Me.TimeLabel.Name = "TimeLabel"
		Me.TimeLabel.Size = New System.Drawing.Size(0, 20)
		Me.TimeLabel.TabIndex = 14586
		'
		'EmptyButton
		'
		Me.EmptyButton.Location = New System.Drawing.Point(783, 306)
		Me.EmptyButton.Name = "EmptyButton"
		Me.EmptyButton.Size = New System.Drawing.Size(75, 23)
		Me.EmptyButton.TabIndex = 14588
		Me.EmptyButton.Text = "Button1"
		Me.EmptyButton.UseVisualStyleBackColor = True
		'
		'tAdult
		'
		Me.tAdult.Location = New System.Drawing.Point(14, 63)
		Me.tAdult.Name = "tAdult"
		Me.tAdult.Size = New System.Drawing.Size(406, 26)
		Me.tAdult.TabIndex = 14589
		'
		'tFilm
		'
		Me.tFilm.Location = New System.Drawing.Point(14, 95)
		Me.tFilm.Name = "tFilm"
		Me.tFilm.Size = New System.Drawing.Size(406, 26)
		Me.tFilm.TabIndex = 14590
		'
		'tCartoon
		'
		Me.tCartoon.Location = New System.Drawing.Point(14, 127)
		Me.tCartoon.Name = "tCartoon"
		Me.tCartoon.Size = New System.Drawing.Size(406, 26)
		Me.tCartoon.TabIndex = 14591
		'
		'L1
		'
		Me.L1.FormattingEnabled = True
		Me.L1.ItemHeight = 20
		Me.L1.Location = New System.Drawing.Point(462, 549)
		Me.L1.Name = "L1"
		Me.L1.Size = New System.Drawing.Size(122, 104)
		Me.L1.Sorted = True
		Me.L1.TabIndex = 14592
		'
		'L2
		'
		Me.L2.FormattingEnabled = True
		Me.L2.ItemHeight = 20
		Me.L2.Location = New System.Drawing.Point(460, 461)
		Me.L2.Name = "L2"
		Me.L2.ScrollAlwaysVisible = True
		Me.L2.Size = New System.Drawing.Size(78, 84)
		Me.L2.Sorted = True
		Me.L2.TabIndex = 14593
		'
		'L3
		'
		Me.L3.FormattingEnabled = True
		Me.L3.ItemHeight = 20
		Me.L3.Location = New System.Drawing.Point(462, 569)
		Me.L3.Name = "L3"
		Me.L3.Size = New System.Drawing.Size(122, 84)
		Me.L3.Sorted = True
		Me.L3.TabIndex = 14594
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(702, 300)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 41)
		Me.Button1.TabIndex = 14595
		Me.Button1.Text = "1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'folder_counter_
		'
		Me.folder_counter_.Location = New System.Drawing.Point(483, 425)
		Me.folder_counter_.Name = "folder_counter_"
		Me.folder_counter_.Size = New System.Drawing.Size(100, 26)
		Me.folder_counter_.TabIndex = 14596
		Me.folder_counter_.Text = "1"
		'
		'file_counter_
		'
		Me.file_counter_.Location = New System.Drawing.Point(610, 563)
		Me.file_counter_.Name = "file_counter_"
		Me.file_counter_.Size = New System.Drawing.Size(100, 26)
		Me.file_counter_.TabIndex = 14597
		Me.file_counter_.Text = "0"
		'
		'EndDate
		'
		Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.EndDate.Location = New System.Drawing.Point(14, 288)
		Me.EndDate.Name = "EndDate"
		Me.EndDate.Size = New System.Drawing.Size(200, 26)
		Me.EndDate.TabIndex = 14598
		Me.EndDate.Value = New Date(2018, 12, 31, 6, 0, 0, 0)
		Me.EndDate.Visible = False
		'
		'BeginDate
		'
		Me.BeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.BeginDate.Location = New System.Drawing.Point(14, 256)
		Me.BeginDate.Name = "BeginDate"
		Me.BeginDate.Size = New System.Drawing.Size(200, 26)
		Me.BeginDate.TabIndex = 14599
		Me.BeginDate.Value = New Date(2018, 12, 31, 0, 0, 0, 0)
		Me.BeginDate.Visible = False
		'
		'time_counter_
		'
		Me.time_counter_.Location = New System.Drawing.Point(638, 563)
		Me.time_counter_.Name = "time_counter_"
		Me.time_counter_.Size = New System.Drawing.Size(100, 26)
		Me.time_counter_.TabIndex = 14600
		Me.time_counter_.Text = "1"
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(585, 415)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 54)
		Me.Button2.TabIndex = 14601
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'tWallpaperAdult
		'
		Me.tWallpaperAdult.Location = New System.Drawing.Point(14, 159)
		Me.tWallpaperAdult.Name = "tWallpaperAdult"
		Me.tWallpaperAdult.Size = New System.Drawing.Size(406, 26)
		Me.tWallpaperAdult.TabIndex = 14602
		Me.tWallpaperAdult.Visible = False
		'
		'tWallpaperRegular
		'
		Me.tWallpaperRegular.Location = New System.Drawing.Point(14, 191)
		Me.tWallpaperRegular.Name = "tWallpaperRegular"
		Me.tWallpaperRegular.Size = New System.Drawing.Size(406, 26)
		Me.tWallpaperRegular.TabIndex = 14592
		'
		'DayWTimer
		'
		Me.DayWTimer.Interval = 1000
		'
		'NWTimer
		'
		Me.NWTimer.Interval = 1000
		'
		'NotifyIcon1
		'
		Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
		Me.NotifyIcon1.Text = "Media"
		Me.NotifyIcon1.Visible = True
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(119, 28)
		'
		'ShowToolStripMenuItem
		'
		Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
		Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
		Me.ShowToolStripMenuItem.Text = "Show"
		'
		'OutTimer
		'
		'
		'L4
		'
		Me.L4.FormattingEnabled = True
		Me.L4.ItemHeight = 20
		Me.L4.Location = New System.Drawing.Point(462, 549)
		Me.L4.Name = "L4"
		Me.L4.Size = New System.Drawing.Size(132, 84)
		Me.L4.Sorted = True
		Me.L4.TabIndex = 14604
		'
		'InTimer
		'
		'
		'WTimer
		'
		Me.WTimer.Interval = 1000
		'
		'MediaTimer
		'
		Me.MediaTimer.Interval = 1000
		'
		'DataGridView1
		'
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordSerialDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.FileBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(688, 415)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(170, 118)
		Me.DataGridView1.TabIndex = 14605
		'
		'RecordSerialDataGridViewTextBoxColumn
		'
		Me.RecordSerialDataGridViewTextBoxColumn.DataPropertyName = "RecordSerial"
		Me.RecordSerialDataGridViewTextBoxColumn.HeaderText = "RecordSerial"
		Me.RecordSerialDataGridViewTextBoxColumn.Name = "RecordSerialDataGridViewTextBoxColumn"
		'
		'FileBindingSource
		'
		Me.FileBindingSource.DataMember = "Dialog"
		Me.FileBindingSource.DataSource = Me.FileDataSet
		'
		'FileDataSet
		'
		Me.FileDataSet.DataSetName = "FileDataSet"
		Me.FileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'FileCounterAValue
		'
		Me.FileCounterAValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileBindingSource, "FileCounterA", True))
		Me.FileCounterAValue.Location = New System.Drawing.Point(483, 425)
		Me.FileCounterAValue.Name = "FileCounterAValue"
		Me.FileCounterAValue.Size = New System.Drawing.Size(100, 26)
		Me.FileCounterAValue.TabIndex = 14606
		'
		'FileCounterBValue
		'
		Me.FileCounterBValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BBindingSource, "FileCounterA", True))
		Me.FileCounterBValue.Location = New System.Drawing.Point(447, 393)
		Me.FileCounterBValue.Name = "FileCounterBValue"
		Me.FileCounterBValue.Size = New System.Drawing.Size(100, 26)
		Me.FileCounterBValue.TabIndex = 14609
		'
		'BBindingSource
		'
		Me.BBindingSource.DataMember = "SettingB"
		Me.BBindingSource.DataSource = Me.BDataSet
		'
		'BDataSet
		'
		Me.BDataSet.DataSetName = "FileDataSet"
		Me.BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'FileCounterCValue
		'
		Me.FileCounterCValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "FileCounterA", True))
		Me.FileCounterCValue.Location = New System.Drawing.Point(455, 401)
		Me.FileCounterCValue.Name = "FileCounterCValue"
		Me.FileCounterCValue.Size = New System.Drawing.Size(100, 26)
		Me.FileCounterCValue.TabIndex = 14610
		'
		'CBindingSource
		'
		Me.CBindingSource.DataMember = "SettingC"
		Me.CBindingSource.DataSource = Me.CDataSet
		'
		'CDataSet
		'
		Me.CDataSet.DataSetName = "FileDataSet"
		Me.CDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'SettingA
		'
		Me.SettingA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Settings_DataSet, "SettingN.A", True))
		Me.SettingA.Location = New System.Drawing.Point(463, 409)
		Me.SettingA.Name = "SettingA"
		Me.SettingA.Size = New System.Drawing.Size(100, 26)
		Me.SettingA.TabIndex = 14611
		'
		'Settings_DataSet
		'
		Me.Settings_DataSet.DataSetName = "FileDataSet"
		Me.Settings_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'SettingB
		'
		Me.SettingB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Settings_DataSet, "SettingN.F", True))
		Me.SettingB.Location = New System.Drawing.Point(471, 417)
		Me.SettingB.Name = "SettingB"
		Me.SettingB.Size = New System.Drawing.Size(100, 26)
		Me.SettingB.TabIndex = 14612
		'
		'SettingC
		'
		Me.SettingC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Settings_DataSet, "SettingN.C", True))
		Me.SettingC.Location = New System.Drawing.Point(479, 425)
		Me.SettingC.Name = "SettingC"
		Me.SettingC.Size = New System.Drawing.Size(100, 26)
		Me.SettingC.TabIndex = 14613
		'
		'SettingD
		'
		Me.SettingD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Settings_DataSet, "SettingN.WA", True))
		Me.SettingD.Location = New System.Drawing.Point(487, 433)
		Me.SettingD.Name = "SettingD"
		Me.SettingD.Size = New System.Drawing.Size(100, 26)
		Me.SettingD.TabIndex = 14614
		'
		'FileCountA
		'
		Me.FileCountA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileCountDataSet, "FileCount.FileCountA", True))
		Me.FileCountA.Location = New System.Drawing.Point(495, 441)
		Me.FileCountA.Name = "FileCountA"
		Me.FileCountA.Size = New System.Drawing.Size(100, 26)
		Me.FileCountA.TabIndex = 14615
		'
		'FileCountDataSet
		'
		Me.FileCountDataSet.DataSetName = "FileDataSet"
		Me.FileCountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'FileCountB
		'
		Me.FileCountB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileCountDataSet, "FileCount.FileCountB", True))
		Me.FileCountB.Location = New System.Drawing.Point(503, 449)
		Me.FileCountB.Name = "FileCountB"
		Me.FileCountB.Size = New System.Drawing.Size(100, 26)
		Me.FileCountB.TabIndex = 14616
		'
		'FileCountC
		'
		Me.FileCountC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileCountDataSet, "FileCount.FileCountC", True))
		Me.FileCountC.Location = New System.Drawing.Point(511, 457)
		Me.FileCountC.Name = "FileCountC"
		Me.FileCountC.Size = New System.Drawing.Size(100, 26)
		Me.FileCountC.TabIndex = 14617
		'
		'SoFarA
		'
		Me.SoFarA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoFarDataSet, "SoFar.A", True))
		Me.SoFarA.Location = New System.Drawing.Point(519, 465)
		Me.SoFarA.Name = "SoFarA"
		Me.SoFarA.Size = New System.Drawing.Size(100, 26)
		Me.SoFarA.TabIndex = 14618
		'
		'SoFarDataSet
		'
		Me.SoFarDataSet.DataSetName = "FileDataSet"
		Me.SoFarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'SoFarB
		'
		Me.SoFarB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoFarDataSet, "SoFar.F", True))
		Me.SoFarB.Location = New System.Drawing.Point(527, 473)
		Me.SoFarB.Name = "SoFarB"
		Me.SoFarB.Size = New System.Drawing.Size(100, 26)
		Me.SoFarB.TabIndex = 14619
		'
		'SoFarC
		'
		Me.SoFarC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoFarDataSet, "SoFar.C", True))
		Me.SoFarC.Location = New System.Drawing.Point(535, 481)
		Me.SoFarC.Name = "SoFarC"
		Me.SoFarC.Size = New System.Drawing.Size(100, 26)
		Me.SoFarC.TabIndex = 14620
		'
		'SettingE
		'
		Me.SettingE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Settings_DataSet, "SettingN.WF", True))
		Me.SettingE.Location = New System.Drawing.Point(469, 601)
		Me.SettingE.Name = "SettingE"
		Me.SettingE.Size = New System.Drawing.Size(100, 26)
		Me.SettingE.TabIndex = 14621
		'
		'SettingF
		'
		Me.SettingF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Settings_DataSet, "SettingN.WF", True))
		Me.SettingF.Location = New System.Drawing.Point(469, 601)
		Me.SettingF.Name = "SettingF"
		Me.SettingF.Size = New System.Drawing.Size(100, 26)
		Me.SettingF.TabIndex = 14622
		'
		'L5
		'
		Me.L5.FormattingEnabled = True
		Me.L5.ItemHeight = 20
		Me.L5.Location = New System.Drawing.Point(462, 549)
		Me.L5.Name = "L5"
		Me.L5.Size = New System.Drawing.Size(132, 84)
		Me.L5.Sorted = True
		Me.L5.TabIndex = 14623
		'
		'FileCountD
		'
		Me.FileCountD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileCountDataSet, "FileCount.FileCountD", True))
		Me.FileCountD.Location = New System.Drawing.Point(511, 457)
		Me.FileCountD.Name = "FileCountD"
		Me.FileCountD.Size = New System.Drawing.Size(100, 26)
		Me.FileCountD.TabIndex = 14624
		'
		'FileCountE
		'
		Me.FileCountE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FileCountDataSet, "FileCount.FileCountE", True))
		Me.FileCountE.Location = New System.Drawing.Point(511, 457)
		Me.FileCountE.Name = "FileCountE"
		Me.FileCountE.Size = New System.Drawing.Size(100, 26)
		Me.FileCountE.TabIndex = 14625
		'
		'SoFarD
		'
		Me.SoFarD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoFarDataSet, "SoFar.WA", True))
		Me.SoFarD.Location = New System.Drawing.Point(535, 481)
		Me.SoFarD.Name = "SoFarD"
		Me.SoFarD.Size = New System.Drawing.Size(100, 26)
		Me.SoFarD.TabIndex = 14626
		'
		'SoFarE
		'
		Me.SoFarE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoFarDataSet, "SoFar.WF", True))
		Me.SoFarE.Location = New System.Drawing.Point(535, 481)
		Me.SoFarE.Name = "SoFarE"
		Me.SoFarE.Size = New System.Drawing.Size(100, 26)
		Me.SoFarE.TabIndex = 14627
		'
		'FileCounterEValue
		'
		Me.FileCounterEValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EBindingSource, "FileCounterA", True))
		Me.FileCounterEValue.Location = New System.Drawing.Point(455, 401)
		Me.FileCounterEValue.Name = "FileCounterEValue"
		Me.FileCounterEValue.Size = New System.Drawing.Size(100, 26)
		Me.FileCounterEValue.TabIndex = 14628
		'
		'EBindingSource
		'
		Me.EBindingSource.DataMember = "SettingE"
		Me.EBindingSource.DataSource = Me.EDataSet
		'
		'EDataSet
		'
		Me.EDataSet.DataSetName = "FileDataSet"
		Me.EDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'FolderBindingSource
		'
		Me.FolderBindingSource.DataMember = "Dialog"
		Me.FolderBindingSource.DataSource = Me.FolderDataSet
		'
		'FolderDataSet
		'
		Me.FolderDataSet.DataSetName = "FileDataSet"
		Me.FolderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'FileTableAdapter
		'
		Me.FileTableAdapter.ClearBeforeFill = True
		'
		'FolderTableAdapter
		'
		Me.FolderTableAdapter.ClearBeforeFill = True
		'
		'FolderCounterTableAdapter
		'
		Me.FolderCounterTableAdapter.ClearBeforeFill = True
		'
		'FileCounterATableAdapter
		'
		Me.FileCounterATableAdapter.ClearBeforeFill = True
		'
		'WhereFolderTableAdapter
		'
		Me.WhereFolderTableAdapter.ClearBeforeFill = True
		'
		'WhereFileTableAdapter
		'
		Me.WhereFileTableAdapter.ClearBeforeFill = True
		'
		'Settings_TableAdapter
		'
		Me.Settings_TableAdapter.ClearBeforeFill = True
		'
		'FileCountTableAdapter
		'
		Me.FileCountTableAdapter.ClearBeforeFill = True
		'
		'BTableAdapter
		'
		Me.BTableAdapter.ClearBeforeFill = True
		'
		'CTableAdapter
		'
		Me.CTableAdapter.ClearBeforeFill = True
		'
		'SoFarTableAdapter
		'
		Me.SoFarTableAdapter.ClearBeforeFill = True
		'
		'FileCounterBTableAdapter
		'
		Me.FileCounterBTableAdapter.ClearBeforeFill = True
		'
		'FileCounterCTableAdapter
		'
		Me.FileCounterCTableAdapter.ClearBeforeFill = True
		'
		'FileCounterETableAdapter
		'
		Me.FileCounterETableAdapter.ClearBeforeFill = True
		'
		'ETableAdapter
		'
		Me.ETableAdapter.ClearBeforeFill = True
		'
		'ACountTableAdapter
		'
		Me.ACountTableAdapter.ClearBeforeFill = True
		'
		'BCountTableAdapter
		'
		Me.BCountTableAdapter.ClearBeforeFill = True
		'
		'CCountTableAdapter
		'
		Me.CCountTableAdapter.ClearBeforeFill = True
		'
		'ECountTableAdapter
		'
		Me.ECountTableAdapter.ClearBeforeFill = True
		'
		'cPlayer
		'
		Me.cPlayer.FormattingEnabled = True
		Me.cPlayer.Location = New System.Drawing.Point(12, 320)
		Me.cPlayer.Name = "cPlayer"
		Me.cPlayer.Size = New System.Drawing.Size(202, 28)
		Me.cPlayer.TabIndex = 14629
		Me.cPlayer.Tag = "f"
		Me.cPlayer.Visible = False
		'
		'set_player_
		'
		Me.set_player_.Location = New System.Drawing.Point(462, 509)
		Me.set_player_.Name = "set_player_"
		Me.set_player_.Size = New System.Drawing.Size(100, 26)
		Me.set_player_.TabIndex = 14630
		'
		'MenuStrip
		'
		Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.None
		Me.MenuStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TasksToolStripMenuItem, Me.LanguageToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem13})
		Me.MenuStrip.Location = New System.Drawing.Point(600, 301)
		Me.MenuStrip.Name = "MenuStrip"
		Me.MenuStrip.Size = New System.Drawing.Size(234, 28)
		Me.MenuStrip.TabIndex = 16761
		Me.MenuStrip.Text = "MenuStrip1"
		'
		'TasksToolStripMenuItem
		'
		Me.TasksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem14, Me.UserToolStripMenuItem1, Me.ToolStripMenuItem18, Me.NewEntryToolStripMenuItem, Me.ToolStripMenuItem12, Me.OpenToolStripMenuItem, Me.ToolStripMenuItem16, Me.LogOutToolStripMenuItem, Me.ToolStripMenuItem20, Me.CloseToolStripMenuItem})
		Me.TasksToolStripMenuItem.Name = "TasksToolStripMenuItem"
		Me.TasksToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
		Me.TasksToolStripMenuItem.Text = "Tasks"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem15, Me.CheckToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'NewToolStripMenuItem
		'
		Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
		Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
		Me.NewToolStripMenuItem.Text = "Load"
		'
		'ToolStripMenuItem15
		'
		Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
		Me.ToolStripMenuItem15.Size = New System.Drawing.Size(120, 6)
		'
		'CheckToolStripMenuItem
		'
		Me.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem"
		Me.CheckToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
		Me.CheckToolStripMenuItem.Text = "Check"
		'
		'ToolStripMenuItem14
		'
		Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
		Me.ToolStripMenuItem14.Size = New System.Drawing.Size(168, 6)
		'
		'UserToolStripMenuItem1
		'
		Me.UserToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.ToolStripMenuItem19, Me.NewToolStripMenuItem1})
		Me.UserToolStripMenuItem1.Name = "UserToolStripMenuItem1"
		Me.UserToolStripMenuItem1.Size = New System.Drawing.Size(171, 24)
		Me.UserToolStripMenuItem1.Text = "User"
		'
		'UpdateToolStripMenuItem
		'
		Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
		Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
		Me.UpdateToolStripMenuItem.Text = "Update"
		'
		'ToolStripMenuItem19
		'
		Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
		Me.ToolStripMenuItem19.Size = New System.Drawing.Size(128, 6)
		'
		'NewToolStripMenuItem1
		'
		Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
		Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(131, 24)
		Me.NewToolStripMenuItem1.Text = "New"
		'
		'ToolStripMenuItem18
		'
		Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
		Me.ToolStripMenuItem18.Size = New System.Drawing.Size(168, 6)
		'
		'NewEntryToolStripMenuItem
		'
		Me.NewEntryToolStripMenuItem.Name = "NewEntryToolStripMenuItem"
		Me.NewEntryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.NewEntryToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
		Me.NewEntryToolStripMenuItem.Text = "New"
		'
		'ToolStripMenuItem12
		'
		Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
		Me.ToolStripMenuItem12.Size = New System.Drawing.Size(168, 6)
		'
		'OpenToolStripMenuItem
		'
		Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
		Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
		Me.OpenToolStripMenuItem.Text = "Open"
		'
		'ToolStripMenuItem16
		'
		Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
		Me.ToolStripMenuItem16.Size = New System.Drawing.Size(168, 6)
		'
		'LogOutToolStripMenuItem
		'
		Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
		Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
		Me.LogOutToolStripMenuItem.Text = "Log Out"
		'
		'ToolStripMenuItem20
		'
		Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
		Me.ToolStripMenuItem20.Size = New System.Drawing.Size(168, 6)
		'
		'CloseToolStripMenuItem
		'
		Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
		Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
		Me.CloseToolStripMenuItem.Text = "Close"
		'
		'LanguageToolStripMenuItem
		'
		Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishLanguage, Me.ToolStripSeparator1, Me.FrenchLanguage, Me.ToolStripSeparator2, Me.ThaiLanguage, Me.ToolStripSeparator3, Me.YorubaLanguage})
		Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
		Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
		Me.LanguageToolStripMenuItem.Text = "Language"
		'
		'EnglishLanguage
		'
		Me.EnglishLanguage.Name = "EnglishLanguage"
		Me.EnglishLanguage.Size = New System.Drawing.Size(134, 24)
		Me.EnglishLanguage.Text = "English"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
		'
		'FrenchLanguage
		'
		Me.FrenchLanguage.Name = "FrenchLanguage"
		Me.FrenchLanguage.Size = New System.Drawing.Size(134, 24)
		Me.FrenchLanguage.Text = "français"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(131, 6)
		'
		'ThaiLanguage
		'
		Me.ThaiLanguage.Name = "ThaiLanguage"
		Me.ThaiLanguage.Size = New System.Drawing.Size(134, 24)
		Me.ThaiLanguage.Text = "ไทย"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(131, 6)
		'
		'YorubaLanguage
		'
		Me.YorubaLanguage.Name = "YorubaLanguage"
		Me.YorubaLanguage.Size = New System.Drawing.Size(134, 24)
		Me.YorubaLanguage.Text = "Yorùbá"
		'
		'SettingsToolStripMenuItem
		'
		Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemeToolStripMenuItem, Me.ToolStripMenuItem1, Me.ApplicationFeedbackToolStripMenuItem, Me.ToolStripMenuItem11, Me.DefaultActionsToolStripMenuItem})
		Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
		Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
		Me.SettingsToolStripMenuItem.Text = "Settings"
		Me.SettingsToolStripMenuItem.Visible = False
		'
		'ThemeToolStripMenuItem
		'
		Me.ThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassicThemes, Me.ToolStripMenuItem2, Me.LavenderThemes, Me.ToolStripMenuItem3, Me.NightThemes, Me.ToolStripMenuItem4, Me.RoseThemes, Me.ToolStripMenuItem5, Me.StandardThemes})
		Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
		Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
		Me.ThemeToolStripMenuItem.Text = "Theme"
		'
		'ClassicThemes
		'
		Me.ClassicThemes.Name = "ClassicThemes"
		Me.ClassicThemes.Size = New System.Drawing.Size(144, 24)
		Me.ClassicThemes.Text = "Classic"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(141, 6)
		'
		'LavenderThemes
		'
		Me.LavenderThemes.Name = "LavenderThemes"
		Me.LavenderThemes.Size = New System.Drawing.Size(144, 24)
		Me.LavenderThemes.Text = "Lavender"
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(141, 6)
		'
		'NightThemes
		'
		Me.NightThemes.Name = "NightThemes"
		Me.NightThemes.Size = New System.Drawing.Size(144, 24)
		Me.NightThemes.Text = "Night"
		'
		'ToolStripMenuItem4
		'
		Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
		Me.ToolStripMenuItem4.Size = New System.Drawing.Size(141, 6)
		'
		'RoseThemes
		'
		Me.RoseThemes.Name = "RoseThemes"
		Me.RoseThemes.Size = New System.Drawing.Size(144, 24)
		Me.RoseThemes.Text = "Rose"
		'
		'ToolStripMenuItem5
		'
		Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
		Me.ToolStripMenuItem5.Size = New System.Drawing.Size(141, 6)
		'
		'StandardThemes
		'
		Me.StandardThemes.Name = "StandardThemes"
		Me.StandardThemes.Size = New System.Drawing.Size(144, 24)
		Me.StandardThemes.Text = "Standard"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(228, 6)
		'
		'ApplicationFeedbackToolStripMenuItem
		'
		Me.ApplicationFeedbackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessagePromptOnly, Me.ToolStripMenuItem6, Me.MessagePromptWithVoice, Me.ToolStripMenuItem7, Me.VoiceOnly})
		Me.ApplicationFeedbackToolStripMenuItem.Name = "ApplicationFeedbackToolStripMenuItem"
		Me.ApplicationFeedbackToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
		Me.ApplicationFeedbackToolStripMenuItem.Text = "Application Feedback"
		'
		'MessagePromptOnly
		'
		Me.MessagePromptOnly.Name = "MessagePromptOnly"
		Me.MessagePromptOnly.Size = New System.Drawing.Size(278, 24)
		Me.MessagePromptOnly.Text = "Message Prompt Only"
		'
		'ToolStripMenuItem6
		'
		Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
		Me.ToolStripMenuItem6.Size = New System.Drawing.Size(275, 6)
		'
		'MessagePromptWithVoice
		'
		Me.MessagePromptWithVoice.Name = "MessagePromptWithVoice"
		Me.MessagePromptWithVoice.Size = New System.Drawing.Size(278, 24)
		Me.MessagePromptWithVoice.Text = "Message Prompt With Voice"
		'
		'ToolStripMenuItem7
		'
		Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
		Me.ToolStripMenuItem7.Size = New System.Drawing.Size(275, 6)
		'
		'VoiceOnly
		'
		Me.VoiceOnly.Name = "VoiceOnly"
		Me.VoiceOnly.Size = New System.Drawing.Size(278, 24)
		Me.VoiceOnly.Text = "Voice Only"
		'
		'ToolStripMenuItem11
		'
		Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
		Me.ToolStripMenuItem11.Size = New System.Drawing.Size(228, 6)
		'
		'DefaultActionsToolStripMenuItem
		'
		Me.DefaultActionsToolStripMenuItem.Name = "DefaultActionsToolStripMenuItem"
		Me.DefaultActionsToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
		Me.DefaultActionsToolStripMenuItem.Text = "Default Actions"
		'
		'ToolStripMenuItem13
		'
		Me.ToolStripMenuItem13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreenTheme, Me.ToolStripSeparator5, Me.TurqoiseTheme, Me.ToolStripSeparator6, Me.VelvetTheme, Me.ToolStripSeparator7, Me.PurpleTheme, Me.ToolStripSeparator8, Me.WhiteTheme, Me.ToolStripMenuItem8, Me.BrownTheme, Me.ToolStripMenuItem9, Me.YellowTheme, Me.ToolStripMenuItem10, Me.ThemeBackground})
		Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
		Me.ToolStripMenuItem13.Size = New System.Drawing.Size(70, 24)
		Me.ToolStripMenuItem13.Text = "Theme"
		'
		'GreenTheme
		'
		Me.GreenTheme.Name = "GreenTheme"
		Me.GreenTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
			Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
		Me.GreenTheme.Size = New System.Drawing.Size(260, 24)
		Me.GreenTheme.Text = "Green"
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(257, 6)
		'
		'TurqoiseTheme
		'
		Me.TurqoiseTheme.Name = "TurqoiseTheme"
		Me.TurqoiseTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
			Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
		Me.TurqoiseTheme.Size = New System.Drawing.Size(260, 24)
		Me.TurqoiseTheme.Text = "Turqoise"
		'
		'ToolStripSeparator6
		'
		Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
		Me.ToolStripSeparator6.Size = New System.Drawing.Size(257, 6)
		'
		'VelvetTheme
		'
		Me.VelvetTheme.Name = "VelvetTheme"
		Me.VelvetTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
			Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
		Me.VelvetTheme.Size = New System.Drawing.Size(260, 24)
		Me.VelvetTheme.Text = "Velvet"
		'
		'ToolStripSeparator7
		'
		Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
		Me.ToolStripSeparator7.Size = New System.Drawing.Size(257, 6)
		'
		'PurpleTheme
		'
		Me.PurpleTheme.Name = "PurpleTheme"
		Me.PurpleTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
			Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
		Me.PurpleTheme.Size = New System.Drawing.Size(260, 24)
		Me.PurpleTheme.Text = "Purple"
		'
		'ToolStripSeparator8
		'
		Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
		Me.ToolStripSeparator8.Size = New System.Drawing.Size(257, 6)
		'
		'WhiteTheme
		'
		Me.WhiteTheme.Name = "WhiteTheme"
		Me.WhiteTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
			Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
		Me.WhiteTheme.Size = New System.Drawing.Size(260, 24)
		Me.WhiteTheme.Text = "White"
		'
		'ToolStripMenuItem8
		'
		Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
		Me.ToolStripMenuItem8.Size = New System.Drawing.Size(257, 6)
		'
		'BrownTheme
		'
		Me.BrownTheme.Name = "BrownTheme"
		Me.BrownTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
			Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
		Me.BrownTheme.Size = New System.Drawing.Size(260, 24)
		Me.BrownTheme.Text = "Brown"
		'
		'ToolStripMenuItem9
		'
		Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
		Me.ToolStripMenuItem9.Size = New System.Drawing.Size(257, 6)
		'
		'YellowTheme
		'
		Me.YellowTheme.Name = "YellowTheme"
		Me.YellowTheme.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
			Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
		Me.YellowTheme.Size = New System.Drawing.Size(260, 24)
		Me.YellowTheme.Text = "Yellow"
		'
		'ToolStripMenuItem10
		'
		Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
		Me.ToolStripMenuItem10.Size = New System.Drawing.Size(257, 6)
		'
		'ThemeBackground
		'
		Me.ThemeBackground.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemeSelectBackground, Me.ToolStripMenuItem17, Me.ThemeClearBackground})
		Me.ThemeBackground.Name = "ThemeBackground"
		Me.ThemeBackground.Size = New System.Drawing.Size(260, 24)
		Me.ThemeBackground.Text = "Background"
		'
		'ThemeSelectBackground
		'
		Me.ThemeSelectBackground.Name = "ThemeSelectBackground"
		Me.ThemeSelectBackground.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
			Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.ThemeSelectBackground.Size = New System.Drawing.Size(246, 24)
		Me.ThemeSelectBackground.Text = "Select"
		'
		'ToolStripMenuItem17
		'
		Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
		Me.ToolStripMenuItem17.Size = New System.Drawing.Size(243, 6)
		'
		'ThemeClearBackground
		'
		Me.ThemeClearBackground.Name = "ThemeClearBackground"
		Me.ThemeClearBackground.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
			Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.ThemeClearBackground.Size = New System.Drawing.Size(246, 24)
		Me.ThemeClearBackground.Text = "Clear"
		'
		'MaximizeButton
		'
		Me.MaximizeButton.AutoSize = True
		Me.MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand
		Me.MaximizeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MaximizeButton.Location = New System.Drawing.Point(450, 323)
		Me.MaximizeButton.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MaximizeButton.Name = "MaximizeButton"
		Me.MaximizeButton.Size = New System.Drawing.Size(22, 20)
		Me.MaximizeButton.TabIndex = 16762
		Me.MaximizeButton.Text = "O"
		'
		'TitleBar
		'
		Me.TitleBar.Location = New System.Drawing.Point(459, 294)
		Me.TitleBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TitleBar.Name = "TitleBar"
		Me.TitleBar.Size = New System.Drawing.Size(11, 20)
		Me.TitleBar.TabIndex = 16763
		Me.TitleBar.TabStop = False
		'
		'FooterBar
		'
		Me.FooterBar.Location = New System.Drawing.Point(459, 294)
		Me.FooterBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.FooterBar.Name = "FooterBar"
		Me.FooterBar.Size = New System.Drawing.Size(11, 20)
		Me.FooterBar.TabIndex = 16764
		Me.FooterBar.TabStop = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(434, 630)
		Me.Controls.Add(Me.FooterBar)
		Me.Controls.Add(Me.TitleBar)
		Me.Controls.Add(Me.MaximizeButton)
		Me.Controls.Add(Me.MenuStrip)
		Me.Controls.Add(Me.set_player_)
		Me.Controls.Add(Me.cPlayer)
		Me.Controls.Add(Me.FileCounterEValue)
		Me.Controls.Add(Me.SoFarE)
		Me.Controls.Add(Me.SoFarD)
		Me.Controls.Add(Me.FileCountE)
		Me.Controls.Add(Me.FileCountD)
		Me.Controls.Add(Me.L5)
		Me.Controls.Add(Me.SettingF)
		Me.Controls.Add(Me.SettingE)
		Me.Controls.Add(Me.SoFarC)
		Me.Controls.Add(Me.SoFarB)
		Me.Controls.Add(Me.SoFarA)
		Me.Controls.Add(Me.FileCountC)
		Me.Controls.Add(Me.FileCountB)
		Me.Controls.Add(Me.FileCountA)
		Me.Controls.Add(Me.SettingD)
		Me.Controls.Add(Me.SettingC)
		Me.Controls.Add(Me.SettingB)
		Me.Controls.Add(Me.SettingA)
		Me.Controls.Add(Me.FileCounterCValue)
		Me.Controls.Add(Me.FileCounterBValue)
		Me.Controls.Add(Me.FileCounterAValue)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.L4)
		Me.Controls.Add(Me.tWallpaperRegular)
		Me.Controls.Add(Me.tWallpaperAdult)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.time_counter_)
		Me.Controls.Add(Me.BeginDate)
		Me.Controls.Add(Me.EndDate)
		Me.Controls.Add(Me.file_counter_)
		Me.Controls.Add(Me.folder_counter_)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.L3)
		Me.Controls.Add(Me.L2)
		Me.Controls.Add(Me.L1)
		Me.Controls.Add(Me.tCartoon)
		Me.Controls.Add(Me.tFilm)
		Me.Controls.Add(Me.tAdult)
		Me.Controls.Add(Me.EmptyButton)
		Me.Controls.Add(Me.PicturePath)
		Me.Controls.Add(Me.Feedback)
		Me.Controls.Add(Me.HelpButton)
		Me.Controls.Add(Me.CloseButton)
		Me.Controls.Add(Me.MinimizeButton)
		Me.Controls.Add(Me.SystemCloseButton)
		Me.Controls.Add(Me.DialogTitle)
		Me.Controls.Add(Me.BottomLine)
		Me.Controls.Add(Me.TopLine)
		Me.Controls.Add(Me.BottomBorder)
		Me.Controls.Add(Me.RightBorder)
		Me.Controls.Add(Me.LeftBorder)
		Me.Controls.Add(Me.TopBorder)
		Me.Controls.Add(Me.TimeLabel)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MinimumSize = New System.Drawing.Size(434, 630)
		Me.Name = "Form1"
		Me.Opacity = 0R
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Settings"
		CType(Me.HelpButton, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BottomLine, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TopLine, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BottomBorder, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RightBorder, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LeftBorder, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TopBorder, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ContextMenuStrip1.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FileDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Settings_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FileCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SoFarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FolderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FolderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip.ResumeLayout(False)
		Me.MenuStrip.PerformLayout()
		CType(Me.TitleBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FooterBar, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents PicturePath As TextBox
	Friend WithEvents Feedback As TextBox
	Friend WithEvents TimeTimer As Timer
	Friend WithEvents HelpButton As PictureBox
	Friend WithEvents CloseButton As Label
	Friend WithEvents MinimizeButton As Label
	Friend WithEvents SystemCloseButton As Button
	Friend WithEvents DialogTitle As Label
	Friend WithEvents BottomLine As PictureBox
	Friend WithEvents TopLine As PictureBox
	Friend WithEvents BottomBorder As PictureBox
	Friend WithEvents RightBorder As PictureBox
	Friend WithEvents LeftBorder As PictureBox
	Friend WithEvents TopBorder As PictureBox
	Friend WithEvents TimeLabel As Label
	Friend WithEvents EmptyButton As Button
	Friend WithEvents tAdult As TextBox
	Friend WithEvents tFilm As TextBox
	Friend WithEvents tCartoon As TextBox
	Friend WithEvents L1 As ListBox
	Friend WithEvents L2 As ListBox
	Friend WithEvents L3 As ListBox
	Friend WithEvents Button1 As Button
	Friend WithEvents folder_counter_ As TextBox
	Friend WithEvents file_counter_ As TextBox
	Friend WithEvents EndDate As DateTimePicker
	Friend WithEvents BeginDate As DateTimePicker
	Friend WithEvents time_counter_ As TextBox
	Friend WithEvents Button2 As Button
	Friend WithEvents tWallpaperAdult As TextBox
	Friend WithEvents tWallpaperRegular As TextBox
	Friend WithEvents DayWTimer As Timer
	Friend WithEvents NWTimer As Timer
	Friend WithEvents NotifyIcon1 As NotifyIcon
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OutTimer As Timer
	Friend WithEvents L4 As ListBox
	Friend WithEvents InTimer As Timer
	Friend WithEvents WTimer As Timer
	Friend WithEvents MediaTimer As Timer
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents FileDataSet As FileDataSet
	Friend WithEvents FileBindingSource As BindingSource
	Friend WithEvents FileTableAdapter As FileDataSetTableAdapters.DialogTableAdapter
	Friend WithEvents RecordSerialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents FileCounterAValue As TextBox
	Friend WithEvents FolderDataSet As FileDataSet
	Friend WithEvents FolderTableAdapter As FileDataSetTableAdapters.DialogTableAdapter
	Friend WithEvents FolderBindingSource As BindingSource
	Friend WithEvents FolderCounterTableAdapter As FileDataSetTableAdapters.DialogTableAdapter
	Friend WithEvents FileCounterATableAdapter As FileDataSetTableAdapters.DialogTableAdapter
	Friend WithEvents WhereFolderTableAdapter As FileDataSetTableAdapters.DialogTableAdapter
	Friend WithEvents WhereFileTableAdapter As FileDataSetTableAdapters.DialogTableAdapter
	Friend WithEvents Settings_DataSet As FileDataSet
	Friend WithEvents Settings_TableAdapter As FileDataSetTableAdapters.SettingNTableAdapter
	Friend WithEvents FileCountDataSet As FileDataSet
	Friend WithEvents FileCountTableAdapter As FileDataSetTableAdapters.FileCountTableAdapter
	Friend WithEvents BDataSet As FileDataSet
	Friend WithEvents BTableAdapter As FileDataSetTableAdapters.SettingBTableAdapter
	Friend WithEvents BBindingSource As BindingSource
	Friend WithEvents FileCounterBValue As TextBox
	Friend WithEvents CTableAdapter As FileDataSetTableAdapters.SettingCTableAdapter
	Friend WithEvents CDataSet As FileDataSet
	Friend WithEvents CBindingSource As BindingSource
	Friend WithEvents FileCounterCValue As TextBox
	Friend WithEvents SettingA As TextBox
	Friend WithEvents SettingB As TextBox
	Friend WithEvents SettingC As TextBox
	Friend WithEvents SettingD As TextBox
	Friend WithEvents FileCountA As TextBox
	Friend WithEvents FileCountB As TextBox
	Friend WithEvents FileCountC As TextBox
	Friend WithEvents SoFarTableAdapter As FileDataSetTableAdapters.SoFarTableAdapter
	Friend WithEvents SoFarDataSet As FileDataSet
	Friend WithEvents SoFarA As TextBox
	Friend WithEvents SoFarB As TextBox
	Friend WithEvents SoFarC As TextBox
	Friend WithEvents FileCounterBTableAdapter As FileDataSetTableAdapters.SettingBTableAdapter
	Friend WithEvents FileCounterCTableAdapter As FileDataSetTableAdapters.SettingCTableAdapter
	Friend WithEvents SettingE As TextBox
	Friend WithEvents SettingF As TextBox
	Friend WithEvents L5 As ListBox
	Friend WithEvents FileCountD As TextBox
	Friend WithEvents FileCountE As TextBox
	Friend WithEvents SoFarD As TextBox
	Friend WithEvents SoFarE As TextBox
	Friend WithEvents FileCounterETableAdapter As FileDataSetTableAdapters.SettingETableAdapter
	Friend WithEvents ETableAdapter As FileDataSetTableAdapters.SettingETableAdapter
	Friend WithEvents EDataSet As FileDataSet
	Friend WithEvents EBindingSource As BindingSource
	Friend WithEvents FileCounterEValue As TextBox
	Friend WithEvents ACountTableAdapter As FileDataSetTableAdapters.DialogTableAdapter
	Friend WithEvents BCountTableAdapter As FileDataSetTableAdapters.SettingBTableAdapter
	Friend WithEvents CCountTableAdapter As FileDataSetTableAdapters.SettingCTableAdapter
	Friend WithEvents ECountTableAdapter As FileDataSetTableAdapters.SettingETableAdapter
	Friend WithEvents cPlayer As ComboBox
	Friend WithEvents set_player_ As TextBox
	Friend WithEvents MenuStrip As MenuStrip
	Friend WithEvents TasksToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem15 As ToolStripSeparator
	Friend WithEvents CheckToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem14 As ToolStripSeparator
	Friend WithEvents UserToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem19 As ToolStripSeparator
	Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem18 As ToolStripSeparator
	Friend WithEvents NewEntryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem12 As ToolStripSeparator
	Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem16 As ToolStripSeparator
	Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem20 As ToolStripSeparator
	Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LanguageToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EnglishLanguage As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents FrenchLanguage As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ThaiLanguage As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
	Friend WithEvents YorubaLanguage As ToolStripMenuItem
	Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ClassicThemes As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
	Friend WithEvents LavenderThemes As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
	Friend WithEvents NightThemes As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
	Friend WithEvents RoseThemes As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
	Friend WithEvents StandardThemes As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
	Friend WithEvents ApplicationFeedbackToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MessagePromptOnly As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
	Friend WithEvents MessagePromptWithVoice As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
	Friend WithEvents VoiceOnly As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem11 As ToolStripSeparator
	Friend WithEvents DefaultActionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
	Friend WithEvents GreenTheme As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
	Friend WithEvents TurqoiseTheme As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
	Friend WithEvents VelvetTheme As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
	Friend WithEvents PurpleTheme As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
	Friend WithEvents WhiteTheme As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
	Friend WithEvents BrownTheme As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem9 As ToolStripSeparator
	Friend WithEvents YellowTheme As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem10 As ToolStripSeparator
	Friend WithEvents ThemeBackground As ToolStripMenuItem
	Friend WithEvents ThemeSelectBackground As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem17 As ToolStripSeparator
	Friend WithEvents ThemeClearBackground As ToolStripMenuItem
	Friend WithEvents MaximizeButton As Label
	Friend WithEvents TitleBar As PictureBox
	Friend WithEvents FooterBar As PictureBox
End Class
