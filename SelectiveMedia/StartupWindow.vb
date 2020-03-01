Public Class StartupWindow
	Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
		With Form1
			.Opacity = 0
			.Show()
		End With

	End Sub
End Class