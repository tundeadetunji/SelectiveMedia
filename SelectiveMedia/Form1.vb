Imports System.IO
Imports General_Module.FormatWindow
Public Class Form1
#Region "Declarations"
	Private Const SPI_SETDESKWALLPAPER As Integer = &H14

	Private Const SPIF_UPDATEINIFILE As Integer = &H1

	Private Const SPIF_SENDWININICHANGE As Integer = &H2

	Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer


#End Region


#Region "theme"
	Private Sub GreenTheme_Click(sender As Object, e As EventArgs) Handles GreenTheme.Click, TurqoiseTheme.Click, BrownTheme.Click, YellowTheme.Click, VelvetTheme.Click, PurpleTheme.Click, WhiteTheme.Click
		Dim mark_ As ToolStripMenuItem = sender
		o.MarkTheme(mark_.Text, GreenTheme, TurqoiseTheme, VelvetTheme, PurpleTheme, WhiteTheme, BrownTheme, YellowTheme, Me)
		o.FormatMe(Me, OutTimer, LeftBorder, RightBorder, TopBorder, BottomBorder, TopLine, BottomLine, DialogTitle, EmptyButton, MinimizeButton, CloseButton, HelpButton, MenuStrip, SystemCloseButton, SystemCloseButton, TitleBar, FooterBar, MaximizeButton, False, False, True, True, o.theme, Feedback, TimeTimer, TimeLabel)
	End Sub

	Private Sub ThemeSelectBackground_Click(sender As Object, e As EventArgs) Handles ThemeSelectBackground.Click
		o.DialogBackground(Me)
	End Sub

	Private Sub ThemeClearBackground_Click(sender As Object, e As EventArgs) Handles ThemeClearBackground.Click
		o.ClearDialogBackground(Me)
	End Sub
#End Region

#Region "Other Functions"
	Public Sub GetSettings_()
		Try
			Me.Settings_TableAdapter.GetSetting_(Me.Settings_DataSet.SettingN)
		Catch
		End Try
	End Sub
	Public Sub GetFileCount()
		Try
			Me.FileCountTableAdapter.FileCount(Me.FileCountDataSet.FileCount)
		Catch ex As Exception
		End Try
	End Sub

	Public Function FileCounter() As Integer
		Try
			Me.FileTableAdapter.FileCounter(Me.FileDataSet.Dialog)
			Me.FileBindingSource.MoveLast()
			Return Val(FileCounterAValue.Text)
		Catch ex As Exception
		End Try
	End Function
	Public Function FileCounterB() As Integer
		Try
			Me.BTableAdapter.FileCounter(Me.BDataSet.SettingB)
			Me.BBindingSource.MoveLast()
			Return Val(FileCounterBValue.Text)
		Catch ex As Exception
		End Try
	End Function
	Public Function FileCounterC() As Integer
		Try
			Me.CTableAdapter.FileCounter(Me.CDataSet.SettingC)
			Me.CBindingSource.MoveLast()
			Return Val(FileCounterCValue.Text)
		Catch ex As Exception
		End Try
	End Function
	Public Function FileCounterE() As Integer
		Try
			Me.ETableAdapter.FileCounter(Me.EDataSet.SettingE)
			Me.EBindingSource.MoveLast()
			Return Val(FileCounterEValue.Text)
		Catch ex As Exception
		End Try
	End Function
#End Region

	Dim wf As Integer = 0
	Dim n As Boolean, d As Boolean

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Visible = False
		Me.Opacity = 0
		InTimer.Enabled = False
		ConnectString()

		GetSettings_()
		BeginDate.Value = Date.Parse(GetBTime())
		EndDate.Value = Date.Parse(GetETime())

		set_player_.Text = ReadText(player_)
		Dim the_player As String = WhichPlayer()
		With cPlayer
			With .Items
				.Clear()
				If the_player.ToLower <> "vlc" And the_player <> "wmplayer" And the_player.Trim.Length > 1 Then
					.Add(the_player)
				End If
				If .Contains("vlc") = False Then
					.Add("vlc")
				End If
				If .Contains("wmplayer") = False Then
					.Add("wmplayer")
				End If
				If .Contains("Choose") = False Then .Add("Choose...")
			End With
			.Text = the_player
			.Visible = False
		End With

		'dialog
		o.MarkTheme(o.theme, GreenTheme, TurqoiseTheme, VelvetTheme, PurpleTheme, WhiteTheme, BrownTheme, YellowTheme, Me)
		o.FormatMe(Me, OutTimer, LeftBorder, RightBorder, TopBorder, BottomBorder, TopLine, BottomLine, DialogTitle, EmptyButton, MinimizeButton, CloseButton, HelpButton, MenuStrip, SystemCloseButton, SystemCloseButton, TitleBar, FooterBar, MaximizeButton, False, False, True, True, o.theme, Feedback, TimeTimer, TimeLabel)

		'begin

		If tAdult.Text = "" Or My.Computer.FileSystem.DirectoryExists(tAdult.Text) = False Or tFilm.Text = "" Or My.Computer.FileSystem.DirectoryExists(tFilm.Text) = False Or tCartoon.Text = "" Or My.Computer.FileSystem.DirectoryExists(tCartoon.Text) = False Or tWallpaperRegular.Text = "" Or My.Computer.FileSystem.DirectoryExists(tWallpaperRegular.Text) = False Then
			InTimer.Enabled = True
		ElseIf tAdult.Text <> "" And My.Computer.FileSystem.DirectoryExists(tAdult.Text) = True And tFilm.Text <> "" And My.Computer.FileSystem.DirectoryExists(tFilm.Text) = True And tCartoon.Text <> "" And My.Computer.FileSystem.DirectoryExists(tCartoon.Text) = True And tWallpaperRegular.Text <> "" And My.Computer.FileSystem.DirectoryExists(tWallpaperRegular.Text) = True Then
			GetFiles_(L1, SettingA.Text, L2, SettingB.Text, L3, SettingC.Text, L5, SettingE.Text)
			GetFileCount()
			RecordFileCount(FileCountA.Text, FileCountB.Text, FileCountC.Text, FileCountE.Text)

			If Date.Parse(Now.ToShortTimeString) >= Date.Parse(BeginDate.Value.ToShortTimeString) And Date.Parse(Now.ToShortTimeString) <= Date.Parse(EndDate.Value.ToShortTimeString) Then
				DayWTimer.Enabled = True
			Else
				NWTimer.Enabled = True
			End If

			MediaTimer.Enabled = True
		End If

	End Sub

	Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles tAdult.DoubleClick
		tAdult.Text = GetFolder(sender)
	End Sub

	Private Sub TextBox2_DoubleClick(sender As Object, e As EventArgs) Handles tFilm.DoubleClick
		tFilm.Text = GetFolder(sender)
	End Sub

	Private Sub TextBox3_DoubleClick(sender As Object, e As EventArgs) Handles tCartoon.DoubleClick
		tCartoon.Text = GetFolder(sender)
	End Sub

	Private Sub StartMedia() '(sender As Object, e As EventArgs) Handles Button1.Click

		'which folder
		'if hour is between 0 and 6:30 then pick from a
		'if hour is between 6:31 and 11.59 then pick from b and c
		'pick file

		If Date.Parse(Now.ToShortTimeString) >= Date.Parse(BeginDate.Value.ToShortTimeString) And Date.Parse(Now.ToShortTimeString) <= Date.Parse(EndDate.Value.ToShortTimeString) Then
			WriteFileCounter("a", WhichFileA(L1))
			Try
				Process.Start(L1.Items.Item(FileCounter()))
			Catch ex As Exception
			End Try
		Else
			folder_counter_.Text = WhichFolder()
			Select Case Integer.Parse(folder_counter_.Text)
				Case 1
					WriteFileCounter("b", WhichFileB(L2))
					Try
						Process.Start(L2.Items.Item(FileCounterB()))
					Catch ex As Exception
					End Try
				Case 2
					WriteFileCounter("c", WhichFileC(L3))
					Try
						Process.Start(L3.Items.Item(FileCounterC()))
					Catch ex As Exception
					End Try
			End Select
		End If
		'pick time
		time_counter_.Text = WhichTime(time_counter_)
		With MediaTimer
			Select Case time_counter_.Text
				Case 1
					.Interval = 1000 * 20 * 60
				Case 2
					.Interval = 1000 * 10 * 60
				Case 3
					.Interval = 1000 * 5 * 60
			End Select
		End With
2:


	End Sub

#Region "Main"

	Private Sub PrepDay()
		WTimer.Enabled = True

		Try
			PickWallpaper("d")
		Catch ex As Exception
		End Try
	End Sub

	Private Sub PrepNight()
		WTimer.Enabled = False
		Try
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Widgets\Picture Frame.widget")
		Catch ex As Exception
		End Try
		Try
			PickWallpaper("n")
		Catch ex As Exception
		End Try

	End Sub

	Private Sub PickWallpaper(t_ As String)
		'		Try
		Select Case t_.ToLower
			Case "d"
				If Random_(1, 11) < 5 Then
					WriteFileCounter("e", WhichFileE(L5))
					SetWallpaper(L5.Items.Item(FileCounterE()))
					WriteText(theme_, "False")
				Else
					If ReadText(theme_).ToLower = "true" Then
					Else
						WriteText(theme_, "True")
						Try
							Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Microsoft\Windows\Themes\dtheme.theme")
						Catch ex As Exception
							WriteFileCounter("e", WhichFileE(L5))
							SetWallpaper(L5.Items.Item(FileCounterE()))
						End Try
					End If
				End If
			Case "n"
				Try
					Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Microsoft\Windows\Themes\theme.theme")
				Catch ex As Exception
				End Try
		End Select
	End Sub
	Public Function WhichFolder() As Integer
		Dim which_folder
2:
		which_folder = Random_(1, 3)
		If which_folder <> folder_counter_.Text Then
			Return which_folder
		Else
			GoTo 2
		End If

	End Function
	Private Function FileAlreadyA(file_counter__ As Integer, l As ListBox) As Boolean
		'if count of items in table = count of items in l, then initialize table (have recorded every index)
		If Me.ACountTableAdapter.Count_() = l.Items.Count Then InitializeDatabase("a")
		'
		FileAlreadyA = Me.FileCounterATableAdapter.Count_FileCounter(file_counter__) < 1
	End Function
	Public Function WhichFileA(l As ListBox) As Integer
		Dim which_file
2:
		which_file = Random_(0, l.Items.Count)
		If FileAlreadyA(which_file, l) Then
			Return which_file
		Else
			GoTo 2
		End If

	End Function

	Private Function FileAlreadyB(file_counter__ As Integer, l As ListBox) As Boolean
		'if count of items in table = count of items in l, then initialize table (have recorded every index)
		If Me.BCountTableAdapter.Count_() = l.Items.Count Then InitializeDatabase("b")
		'
		FileAlreadyB = Me.FileCounterBTableAdapter.Count_FileCounter(file_counter__) < 1
	End Function

	Public Function WhichFileB(l As ListBox) As Integer
		Dim which_file
2:
		which_file = Random_(0, l.Items.Count)
		If FileAlreadyB(which_file, l) Then
			Return which_file
		Else
			GoTo 2
		End If

	End Function


	Private Function FileAlreadyC(file_counter__ As Integer, l As ListBox) As Boolean
		'if count of items in table = count of items in l, then initialize table (have recorded every index)
		If Me.CCountTableAdapter.Count_() = l.Items.Count Then InitializeDatabase("c")
		'
		FileAlreadyC = Me.FileCounterCTableAdapter.Count_FileCounter(file_counter__) < 1
	End Function

	Public Function WhichFileC(l As ListBox) As Integer
		Dim which_file
2:
		which_file = Random_(0, l.Items.Count)
		If FileAlreadyC(which_file, l) Then
			Return which_file
		Else
			GoTo 2
		End If

	End Function
	Private Function FileAlreadyE(file_counter__ As Integer, l As ListBox) As Boolean
		'if count of items in table = count of items in l, then initialize table (have recorded every index)
		If Me.ECountTableAdapter.Count_() = l.Items.Count Then InitializeDatabase("e")
		'
		FileAlreadyE = Me.FileCounterETableAdapter.Count_FileCounter(file_counter__) < 1
	End Function
	Public Function WhichFileE(l As ListBox) As Integer
		Dim which_file
2:
		which_file = Random_(0, l.Items.Count)
		If FileAlreadyE(which_file, l) Then
			Return which_file
		Else
			GoTo 2
		End If

	End Function

	Public Function WhichTime(time_counter As TextBox) As Integer
		Dim wf
2:
		wf = Random_(1, 4)
		If wf <> time_counter.Text Then
			Return wf
		ElseIf wf = time_counter.Text Then
			GoTo 2
		End If

	End Function

	Public Function PlayerIsOn() As Boolean
		Return AppIsOn(cPlayer.Text)

	End Function

	Friend Sub SetWallpaper(ByVal img As String)

		Dim imageLocation As String

		imageLocation = img

		Try

			SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imageLocation, SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)

		Catch Ex As Exception
		End Try

	End Sub

	Private Sub TextBox4_DoubleClick(sender As Object, e As EventArgs) Handles tWallpaperAdult.DoubleClick
		tWallpaperAdult.Text = GetFolder(sender)
	End Sub

	Private Sub WTimer_Tick(sender As Object, e As EventArgs) Handles DayWTimer.Tick
		If Date.Parse(Now.ToShortTimeString) >= Date.Parse(BeginDate.Value.ToShortTimeString) And Date.Parse(Now.ToShortTimeString) <= Date.Parse(EndDate.Value.ToShortTimeString) Then
			DayWTimer.Enabled = False
			PrepNight() 'do stuff to happen during interval
			NWTimer.Enabled = True 'listen for end of interval; at that point, timer takes over
		Else
		End If

	End Sub

	Private Sub NWTimer_Tick(sender As Object, e As EventArgs) Handles NWTimer.Tick
		If Date.Parse(Now.ToShortTimeString) >= Date.Parse(BeginDate.Value.ToShortTimeString) And Date.Parse(Now.ToShortTimeString) <= Date.Parse(EndDate.Value.ToShortTimeString) Then
		Else
			NWTimer.Enabled = False
			PrepDay() 'do stuff to happen outside interval
			DayWTimer.Enabled = True 'listen for begining of interval; at that point, timer takes over
		End If

	End Sub

	'CLEAR
	Private Sub TextBox5_DoubleClick(sender As Object, e As EventArgs) Handles tWallpaperRegular.DoubleClick
		tWallpaperRegular.Text = GetFolder(sender)
	End Sub

	Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click

		With Me
			.Opacity = 0
			.InTimer.Enabled = True
		End With
	End Sub

	'CLEAR
	Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
		OutTimer.Enabled = True
	End Sub

	Private Sub InTimer_Tick(sender As Object, e As EventArgs) Handles InTimer.Tick
		Me.Visible = True
		If Me.Opacity >= 1 Then
			InTimer.Enabled = False
			Exit Sub
		End If
		Me.Opacity += 0.2
	End Sub

	Private Sub WTimer_Tick_1(sender As Object, e As EventArgs) Handles WTimer.Tick
		WTimer.Enabled = False
		'		KillProcess("YahooWidgetEngine")
	End Sub

	Private Sub MediaTimer_Tick(sender As Object, e As EventArgs) Handles MediaTimer.Tick
		If PlayerIsOn() Then
			MediaTimer.Interval = 120000
			Exit Sub
		End If
		StartMedia()

	End Sub

	Private Sub SettingA_TextChanged(sender As Object, e As EventArgs) Handles SettingA.TextChanged
		tAdult.Text = SettingA.Text
	End Sub

	Private Sub SettingB_TextChanged(sender As Object, e As EventArgs) Handles SettingB.TextChanged
		tFilm.Text = SettingB.Text
	End Sub
	Private Sub SettingC_TextChanged(sender As Object, e As EventArgs) Handles SettingC.TextChanged
		tCartoon.Text = SettingC.Text
	End Sub

	Private Sub SettingD_TextChanged(sender As Object, e As EventArgs) Handles SettingD.TextChanged
		tWallpaperAdult.Text = SettingD.Text
	End Sub

	Private Sub OutTimer_Tick(sender As Object, e As EventArgs) Handles OutTimer.Tick
		If Me.Opacity <= 0 Then
			Me.Visible = False
			OutTimer.Enabled = False

			BeginDate.Visible = False
			EndDate.Visible = False
			cPlayer.Visible = False

			SaveDateValues(BeginDate.Value.ToShortTimeString, EndDate.Value.ToShortTimeString)
			ThisPlayer(set_player_.Text)
			If tAdult.Text <> "" And My.Computer.FileSystem.DirectoryExists(tAdult.Text) And tFilm.Text <> "" And My.Computer.FileSystem.DirectoryExists(tFilm.Text) And tCartoon.Text <> "" And My.Computer.FileSystem.DirectoryExists(tCartoon.Text) And tWallpaperRegular.Text <> "" And My.Computer.FileSystem.DirectoryExists(tWallpaperRegular.Text) = True Then
				Try
					SaveSetting_(tAdult.Text.Trim, tFilm.Text.Trim, tCartoon.Text.Trim, tWallpaperAdult.Text.Trim, tWallpaperRegular.Text.Trim)
				Catch x As Exception
				End Try
				GetSettings_()
				GetFiles_(L1, SettingA.Text, L2, SettingB.Text, L3, SettingC.Text, L5, SettingE.Text)
				GetFileCount()
				RecordFileCount(FileCountA.Text, FileCountB.Text, FileCountC.Text, FileCountE.Text)

				If Date.Parse(Now.ToShortTimeString) >= Date.Parse(BeginDate.Value.ToShortTimeString) And Date.Parse(Now.ToShortTimeString) <= Date.Parse(EndDate.Value.ToShortTimeString) Then
					DayWTimer.Enabled = True
				Else
					NWTimer.Enabled = True
				End If
				MediaTimer.Enabled = True
			End If
		End If
		Me.Opacity -= 0.2
	End Sub
	Private Sub SettingE_TextChanged(sender As Object, e As EventArgs) Handles SettingE.TextChanged
		tWallpaperAdult.Text = SettingE.Text
	End Sub

	Private Sub SettingF_TextChanged(sender As Object, e As EventArgs) Handles SettingF.TextChanged
		tWallpaperRegular.Text = SettingF.Text

	End Sub

	Private Sub cPlayer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cPlayer.SelectedIndexChanged
		Dim c As ComboBox = sender
		Select Case c.Text.ToLower
			Case "choose..."
				Dim value_ As Array = GetFileAndExtension("exec")
				If value_(0) = True And value_(1).ToString.Length > 0 Then
					Dim a As String = value_(1)
					c.Items.Add(Path.GetFileNameWithoutExtension(a))
					c.Text = Path.GetFileNameWithoutExtension(a)
					set_player_.Text = a
				End If
			Case "vlc"
				set_player_.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\VideoLAN\VLC\VLC.EXE"
			Case "wmplayer"
				set_player_.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\Windows Media Player\wmplayer.EXE"
		End Select
	End Sub

	Private Sub tAdult_TextChanged(sender As Object, e As EventArgs) Handles tAdult.TextChanged

	End Sub

	Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
		If EndDate.Visible = True Then
			BeginDate.Visible = False
			EndDate.Visible = False
			cPlayer.Visible = False
			Exit Sub
		End If

		BeginDate.Visible = True
		EndDate.Visible = True
		cPlayer.Visible = True
	End Sub


#End Region

End Class
