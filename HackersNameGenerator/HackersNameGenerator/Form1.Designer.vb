<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(12, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(290, 29)
        Me.TextBox1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Gem (63M)", "Blade (BL4D3)", "Grace (6R4C3)", "Archangel (4RCH4N63L)", "Twist (7W157)", "Pierce (P13RC3)", "Whiz (WH1Z)", "Daydream (D4YDR34M)", "Azure (4ZUR3)", "Quake (QU4K3)", "Storm (570RM)", "Knot (KN07)", "Dexter (D3X73R)", "Trinity (7R1N17Y)", "Nemesis (N3M3515)", "Splinter (5PL1N73R)", "Surprise (5URPR153)", "Alakazam (4L4K4Z4M)", "Moonshine (M00N5H1N3)", "Paragon (P4R460N)", "Indie (1ND13)", "Specter (5P3C73R)", "Serenity (53R3N17Y)", "Prima Donna (PR1M4 D0NN4)", "Comet (C0M37)", "Phantasm (PH4N745M)", "Silver (51LV3R)", "Crypto (CRYP70)", "Pride (PR1D3)", "Craze (CR4Z3)", "Void (V01D)", "Rogue (R06U3)", "Cipher (C1PH3R)", "Nobody (N0B0DY)", "Trail (7R41L)", "Oblivion (0BL1V10N)", "Parody (P4R0DY)", "Shade (5H4D3)", "Flinch (FL1NCH)", "Limbo (L1MB0)", "Witcher (W17CH3R)", "Bliss (BL155)", "Charm (CH4RM)", "Behemoth (B3H3M07H)", "Bullseye (BULL53Y3)", "Zigzag (Z16Z46)", "Ecstasy (3C5745Y)", "Charade (CH4R4D3)", "Maestro (M4357R0)", "Viper (V1P3R)", "Impossible (1MP0551BL3)", "Proxy (PR0XY)", "Neurosis (N3UR0515)", "Reaper (R34P3R)", "Enigma (3N16M4)", "Sloth (5L07H)", "Nix (N1X)", "Avatar (4V474R)", "Flash (FL45H)", "Habit (H4B17)", "Shark (5H4RK)", "Trixy (7R1XY)", "Rune (RUN3)", "Phoenix (PH03N1X)", "Doppelganger (D0PP3L64N63R)", "Essence (3553NC3)", "Vacuum (V4CUUM)", "Trust (7RU57)", "Quirk (QU1RK)", "Grimace (6R1M4C3)", "Vestige (V357163)", "Nest (N357)", "Rebus (R3BU5)", "Riddle (R1DDL3)", "Bishop (B15H0P)", "Mascot (M45C07)", "Mime (M1M3)", "Combo (C0MB0)", "Matriarch (M47R14RCH)", "Wyvern (WYV3RN)", "Omega (0M364)", "Griffin (6R1FF1N)", "Alpha (4LPH4)", "Scepter (5C3P73R)", "Aberration (4B3RR4710N)", "Claw (CL4W)", "Ant (4N7)", "Oracle (0R4CL3)", "Veil (V31L)", "Alien (4L13N)", "Prophecy (PR0PH3CY)", "Mermaid (M3RM41D)", "Memento (M3M3N70)", "Trix (7R1X)", "Webster (W3B573R)", "Kiss (K155)", "Doc (D0C)", "Tinge (71N63)", "Zero (Z3R0)", "Legacy (L364CY)", "Answer (4N5W3R)", "Phobia (PH0B14)", "Mongoose (M0N60053)", "Zion (Z10N)", "Owl (0WL)", "Epitome (3P170M3)", "Blank (BL4NK)", "Smog (5M06)", "Gloom (6L00M)", "Swan (5W4N)", "Reverse (R3V3R53)", "Rapture (R4P7UR3)", "Nightmare (N16H7M4R3)", "Fata Morgana (F474 M0R64N4)", "Dread (DR34D)", "Boggle (B066L3)", "Shadow (5H4D0W)", "Kid (K1D)", "Wraith (WR417H)", "Blazer (BL4Z3R)", "Quad (QU4D)", "Umbra (UMBR4)", "Mania (M4N14)", "Marshall (M4R5H4LL)", "Voodoo (V00D00)", "Plague (PL46U3)", "Savant (54V4N7)", "Chase (CH453)", "Conjurer (C0NJUR3R)", "Ray (R4Y)", "Oddity (0DD17Y)", "Streak (57R34K)", "Spook (5P00K)", "Fiend (F13ND)", "Myth (MY7H)", "Diablo (D14BL0)", "Obsidian (0B51D14N)", "Chaos (CH405)", "Burn (BURN)", "Torpedo (70RP3D0)", "Phantom (PH4N70M)", "Guru (6URU)", "Dante (D4N73)", "Memory (M3M0RY)", "Stalker (574LK3R)", "Bolt (B0L7)", "Talisman (74L15M4N)", "Monkey (M0NK3Y)", "Crotchet (CR07CH37)", "Bullet (BULL37)", "Drake (DR4K3)", "Juju (JUJU)", "Grin (6R1N)", "Aspect (45P3C7)", "Sunshine (5UN5H1N3)", "Prankster (PR4NK573R)", "Angler (4N6L3R)", "Grim (6R1M)", "Haze (H4Z3)", "Nova (N0V4)", "Saber (54B3R)", "Nemo (N3M0)", "Phase (PH453)", "Ace (4C3)", "Ibis (1B15)", "Fury (FURY)", "Shepherd (5H3PH3RD)", "Quicksilvefr (QU1CK51LV3R)", "Mothership (M07H3R5H1P)", "Particle (P4R71CL3)", "Acid (4C1D)", "Acid BuRn", "Crash OveRide", "rE-BoOt", "AlPha KiLLer", "Ceaser", "God", "Virus", "Plague", "De Frag", "MrX", "Mr.AlienX", "Yorkox", "Zero Cool", "Rax0_Rend", "Toxic", "Anonymous_77", "Unknown", "CryptedData", "TRACE", "Mr.trojan", "Ghost", "Root", "Hacker G", "MANNY", "John Doe", "Luk453 (Lukase)", "Retile", "Clown", "CYB9R", "Guest 666", "Malware", "Trojan horse", "Proto type", "Dark eyez", "Entidode", "Speedy", "Anacrypt", "Acid burner", "Code x", "Neon", "Predator", "Cyber injector", "Potatiom", "Olsun", "ModG", "Maximux", "Minimod", "Softcore", "Mega crash", "Dekow", "Actordo", "Lotindo", "Manimoto", "Master of disaster", "Diablo", "Dr den", "Dr zaven", "Childo boom", "Luke", "Lazer beam", "Mak", "Ola mega", "Glitch please", "Glitcher", "Phisher"})
        Me.ListBox1.Location = New System.Drawing.Point(537, 56)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(188, 199)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(52, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "H4ck3r N4m3"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(105, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Copy Name"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Lime
        Me.LinkLabel1.Location = New System.Drawing.Point(159, 154)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(232, 24)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Creator: @LinuxOfCode"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(308, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 39)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "About Me"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Lime
        Me.LinkLabel2.Location = New System.Drawing.Point(8, 154)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(131, 24)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Visit Our Site"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Color_of_the_Linux_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(308, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(196, 97)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 40)
        Me.Button4.TabIndex = 10
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(403, 190)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(419, 229)
        Me.MinimumSize = New System.Drawing.Size(419, 229)
        Me.Name = "Form1"
        Me.Text = "H 4 C K 3 R $    |\| /\ |\/| 3    6 3 |\| 3 R 4 T 0 R"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
