Imports System.IO

Public Class Form1
    Dim rnd As New Random
    Dim rn As Stack

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        'TextBox1.Text = ListBox1.Items(rnd.Next(236))
        TextBox1.Text = ListBox1.FindString("lol")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Generate Name First! Lol", MsgBoxStyle.OkOnly, "Empty Name")
        Else
            Clipboard.SetText(TextBox1.Text)
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("I'm Tanny...The Developer Bitch" & vbCrLf & "I'm Blogger, Youtuber! Follow Us" & vbCrLf & "Share This Application With Your Friends", MsgBoxStyle.OkOnly, "H4CK3R Nam3 63N3RAT0R")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.instagram.com/linuxoffcode")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://linuxoffcode.blogspot.com/")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Lol! Tell Me How To Speak Blank Name", MsgBoxStyle.OkOnly, "Empty Name")
        Else
            CreateObject("sapi.spvoice").speak(TextBox1.Text)
        End If
    End Sub
End Class
