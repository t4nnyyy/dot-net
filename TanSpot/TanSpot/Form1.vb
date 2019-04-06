Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateObject("sapi.spvoice").speak("Welcome To Tanny's Hotspot Machine")
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Then
                MsgBox("Hotspot Name Can't Be Empty", MsgBoxStyle.Critical)
            ElseIf TextBox1.TextLength > 15 Then
                MsgBox("Hotspot Name Can't Be Greater Than 15+ Characters", MsgBoxStyle.Information)
            End If
            If TextBox2.TextLength < 8 Then
                MsgBox("Password Should Be 8+ Characters", MsgBoxStyle.Information)
                TextBox2.Text = ""
                TextBox2.Focus()
            ElseIf TextBox2.TextLength > 10 Then
                MsgBox("Password Should Be Less Then 10 Characters", MsgBoxStyle.Information)
                TextBox2.Text = ""
                TextBox2.Focus()
            Else
                Shell("cmd.exe /c cd c:\Windows\system32")
                Shell("cmd.exe /c netsh wlan set hostednetwork ssid=" + TextBox1.Text)
                Shell("cmd.exe /c netsh wlan set hostednetwork key=" + TextBox2.Text)
                Process.Start("start.exe")
                Me.BackColor = Color.Green
                CreateObject("sapi.spvoice").speak("Hotspot Started Successfully")
            End If
        Catch
            MsgBox("Failed To Establish Hotspot", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CreateObject("sapi.spvoice").speak("Hotspot Stopped")
        Shell("cmd.exe /c netsh wlan stop hostednetwork")
        Me.BackColor = Color.Red
        Me.BackColor = Color.Red
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Create Hotspot With Your Laptop/Computer" & vbCrLf & "This Software Is a Copyright To Tanveer Developers" & vbCrLf & "@Tanveer Ali", MsgBoxStyle.Information)
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub


    Private Sub Form1_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Shell("cmd.exe /c netsh wlan stop hostednetwork")
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CreateObject("sapi.spvoice").speak("Thanks For Using Me")
        End
    End Sub
End Class
