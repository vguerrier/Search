﻿Imports System.Windows.Forms

Public Class Dabout

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        System.Diagnostics.Process.Start("mailto:vincent.guerrier@symphonyretailai.com?subject=Search")

    End Sub

    Private Sub LLBlinkCQ_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LLBlinkCQ.LinkClicked
        System.Diagnostics.Process.Start("https://eyc.sharepoint.com/sites/RS_SCM_RD/All_Documents/Search%20Help.pdf")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
