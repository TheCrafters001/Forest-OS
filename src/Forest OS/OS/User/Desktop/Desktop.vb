﻿Imports ForestOSUtilities

Public Class Desktop
    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub ExitToWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToWindowsToolStripMenuItem.Click

    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        Shutdown.Show()
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub FileExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileExplorerToolStripMenuItem.Click
        Explorer.Show()
    End Sub

    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        Run.Show()
    End Sub
End Class