<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TanLocker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TanLocker))
        Me.ButtonAbout = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtUnBrowse = New System.Windows.Forms.TextBox()
        Me.txtBrowse = New System.Windows.Forms.TextBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonLock = New System.Windows.Forms.Button()
        Me.ButtonUnlock = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonAbout
        '
        Me.ButtonAbout.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAbout.ForeColor = System.Drawing.Color.Black
        Me.ButtonAbout.Location = New System.Drawing.Point(422, 196)
        Me.ButtonAbout.Name = "ButtonAbout"
        Me.ButtonAbout.Size = New System.Drawing.Size(81, 33)
        Me.ButtonAbout.TabIndex = 28
        Me.ButtonAbout.Text = "&About"
        Me.ButtonAbout.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 196)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(404, 33)
        Me.ProgressBar1.TabIndex = 27
        '
        'txtUnBrowse
        '
        Me.txtUnBrowse.Enabled = False
        Me.txtUnBrowse.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnBrowse.Location = New System.Drawing.Point(137, 145)
        Me.txtUnBrowse.Multiline = True
        Me.txtUnBrowse.Name = "txtUnBrowse"
        Me.txtUnBrowse.Size = New System.Drawing.Size(453, 34)
        Me.txtUnBrowse.TabIndex = 26
        '
        'txtBrowse
        '
        Me.txtBrowse.Enabled = False
        Me.txtBrowse.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrowse.Location = New System.Drawing.Point(137, 85)
        Me.txtBrowse.Multiline = True
        Me.txtBrowse.Name = "txtBrowse"
        Me.txtBrowse.Size = New System.Drawing.Size(453, 31)
        Me.txtBrowse.TabIndex = 25
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.ForeColor = System.Drawing.Color.Black
        Me.ButtonExit.Location = New System.Drawing.Point(509, 196)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(81, 33)
        Me.ButtonExit.TabIndex = 24
        Me.ButtonExit.Text = "&EXIT"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(12, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 34)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "&LOCK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "&UNLOCK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonLock
        '
        Me.ButtonLock.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLock.ForeColor = System.Drawing.Color.Black
        Me.ButtonLock.Location = New System.Drawing.Point(918, 33)
        Me.ButtonLock.Name = "ButtonLock"
        Me.ButtonLock.Size = New System.Drawing.Size(104, 34)
        Me.ButtonLock.TabIndex = 31
        Me.ButtonLock.TabStop = False
        Me.ButtonLock.Text = "LOCK"
        Me.ButtonLock.UseVisualStyleBackColor = True
        '
        'ButtonUnlock
        '
        Me.ButtonUnlock.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUnlock.ForeColor = System.Drawing.Color.Black
        Me.ButtonUnlock.Location = New System.Drawing.Point(918, 83)
        Me.ButtonUnlock.Name = "ButtonUnlock"
        Me.ButtonUnlock.Size = New System.Drawing.Size(104, 32)
        Me.ButtonUnlock.TabIndex = 32
        Me.ButtonUnlock.TabStop = False
        Me.ButtonUnlock.Text = "UNLOCK"
        Me.ButtonUnlock.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(36, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(497, 43)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Tanny's Encryption Machine"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(886, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(94, 20)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "1"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(930, 206)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 39)
        Me.Button4.TabIndex = 36
        Me.Button4.TabStop = False
        Me.Button4.Text = "Add Password"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasswordToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PasswordToolStripMenuItem
        '
        Me.PasswordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem})
        Me.PasswordToolStripMenuItem.Name = "PasswordToolStripMenuItem"
        Me.PasswordToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.PasswordToolStripMenuItem.Text = "Password"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(825, 159)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(193, 20)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(825, 206)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 39)
        Me.Button3.TabIndex = 39
        Me.Button3.TabStop = False
        Me.Button3.Text = "load"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TanLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(600, 240)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonLock)
        Me.Controls.Add(Me.ButtonUnlock)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonAbout)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtUnBrowse)
        Me.Controls.Add(Me.txtBrowse)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(616, 279)
        Me.MinimumSize = New System.Drawing.Size(616, 279)
        Me.Name = "TanLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAbout As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtUnBrowse As System.Windows.Forms.TextBox
    Friend WithEvents txtBrowse As System.Windows.Forms.TextBox
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ButtonLock As System.Windows.Forms.Button
    Friend WithEvents ButtonUnlock As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
