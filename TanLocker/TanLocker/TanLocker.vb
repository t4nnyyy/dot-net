Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class TanLocker
    Public status As String
    Private arr As String() = New String(5) {}
    Public sapi As Object
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Public myconnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub TanLocker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        status = ""
        arr(0) = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(1) = ".{21EC2020-3AEA-1069-A2DD-08002B30309D}"
        arr(2) = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(3) = ".{645FF040-5081-101B-9F08-00AA002F954E}"
        arr(4) = ".{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(5) = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}"

        sapi = CreateObject("sapi.spvoice").speak("Welcome To Tanny's Encryption Machine")


        Dim con As New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\db.mdb")
        con.Open()
        Dim str As String
        str = "SELECT * FROM user_master WHERE uid= '" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox1.Text = dr("uid").ToString
            TextBox2.Text = dr("password").ToString
        End While
        con.Close()


    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        sapi = CreateObject("sapi.spvoice").speak("Thanks For Using Me")
        Me.Close()
    End Sub

    Private Sub ButtonAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbout.Click
        MsgBox("This Software Is Copyright To Tanveer Developers, Copying This Software Is Illegal Cause Of Copyright Laws!! Developer: Tanveer Ali")
    End Sub

    Private Sub ButtonUnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUnlock.Click
        status = arr(1)

        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim d As DirectoryInfo = New DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            Dim selectedpath As String = d.Parent.FullName + d.Name

            ProgressBar1.Value = 40
            ProgressBar1.Value = 100
            sapi = CreateObject("sapi.spvoice").speak("Folder Unlocked Successfully")
            If FolderBrowserDialog1.SelectedPath.LastIndexOf(".{") = -1 Then
                If (Not d.Root.Equals(d.Parent.FullName)) Then
                    d.MoveTo(d.Parent.FullName & "\" & d.Name & status)
                Else
                    d.MoveTo(d.Parent.FullName + d.Name & status)

                End If

                txtUnBrowse.Text = FolderBrowserDialog1.SelectedPath
                ProgressBar1.Value = 100
                ProgressBar1.Value = 100
            Else
                status = getstatus(status)
                d.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))
                txtUnBrowse.Text = FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf("."))
            End If
        End If
    End Sub

    Private Sub ButtonLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLock.Click
        status = arr(0)

        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim d As DirectoryInfo = New DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            Dim selectedpath As String = d.Parent.FullName + d.Name

            ProgressBar1.Value = 40

            If FolderBrowserDialog1.SelectedPath.LastIndexOf(".{") = -1 Then
                If (Not d.Root.Equals(d.Parent.FullName)) Then
                    d.MoveTo(d.Parent.FullName & "\" & d.Name & status)
                Else
                    d.MoveTo(d.Parent.FullName + d.Name & status)
                End If

                txtBrowse.Text = FolderBrowserDialog1.SelectedPath
                ProgressBar1.Value = 75
                ProgressBar1.Value = 100
                sapi = CreateObject("sapi.spvoice").speak("Folder Locked Successfully")
            Else
                status = getstatus(status)
                d.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))
                txtBrowse.Text = FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf("."))
            End If
        End If
    End Sub

    Private Function getstatus(ByVal stat As String) As String
        For i As Integer = 0 To 5
            If stat.LastIndexOf(arr(i)) <> -1 Then
                stat = stat.Substring(stat.LastIndexOf("."))
            End If
        Next i
        Return stat
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lock.Show()
        lock.TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        unlock.Show()
        unlock.TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim con As New OleDbConnection
        Dim com As New OleDbCommand
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db.mdb")
        com = New OleDbCommand("INSERT INTO user_master VALUES(@uid,@password)", con)
        con.Open()
        com.Parameters.AddWithValue("@uid", TextBox1.Text)
        com.Parameters.AddWithValue("@password", InputBox("Enter New Password"))
        com.ExecuteNonQuery()
        MsgBox("Password Changed Successfully")
        con.Close()
        Button3.PerformClick()


    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim con As New OleDbConnection
        Dim com As New OleDbCommand
        Dim inpp As Integer
        inpp = InputBox("Enter Old Password")
        If inpp <> TextBox2.Text Then
            MsgBox("Incorrect Old Password")
        Else

            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db.mdb")
            com = New OleDbCommand("DELETE password FROM user_master WHERE uid= @uid", con)
            con.Open()
            com.Parameters.AddWithValue("@uid", TextBox1.Text)
            com.ExecuteNonQuery()
            con.Close()
            Button4.PerformClick()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This Software Is Copyright To Tanveer Developers, Copying This Software Is Illegal Cause Of Copyright Laws!! Developer: Tanveer Ali")
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\db.mdb")
        con.Open()
        Dim str As String
        str = "SELECT * FROM user_master WHERE uid= '" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox1.Text = dr("uid").ToString
            TextBox2.Text = dr("password").ToString
        End While
        con.Close()

    End Sub
End Class
