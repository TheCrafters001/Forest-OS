﻿Public Class Setup_Page3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        My.Settings.Save()
        Me.Close()
    End Sub
End Class