Imports System.Data.OleDb
Public Class lock

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim inp1 As String
            inp1 = TextBox1.Text
            Dim con As New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\db.mdb")
            Dim cmd As OleDbCommand = New OleDbCommand( _
                       "SELECT * FROM user_master WHERE password = '" & _
                        inp1 & "' ", con)
            con.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            ' If the record can be queried, it means passing verification, then open another form.   
            If (sdr.Read() = True) Then
                Me.Hide()
                TextBox1.Text = ""
                TanLocker.ButtonLock.PerformClick()
            Else
                MessageBox.Show("Invalid password!")
                TextBox1.Text = ""
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            TextBox1.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub lock_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub
End Class