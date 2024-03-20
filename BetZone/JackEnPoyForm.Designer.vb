<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JackEnPoyForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Rock1 = New System.Windows.Forms.Button()
        Me.Paper1 = New System.Windows.Forms.Button()
        Me.Scissors1 = New System.Windows.Forms.Button()
        Me.Scissors2 = New System.Windows.Forms.Button()
        Me.Paper2 = New System.Windows.Forms.Button()
        Me.Rock2 = New System.Windows.Forms.Button()
        Me.PlaceBetLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ShowBtn = New System.Windows.Forms.Button()
        Me.Bet = New System.Windows.Forms.ComboBox()
        Me.EarnTxt = New System.Windows.Forms.TextBox()
        Me.EarnLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rock1
        '
        Me.Rock1.BackgroundImage = Global.BetZone.My.Resources.Resources.Rock
        Me.Rock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Rock1.Location = New System.Drawing.Point(15, 284)
        Me.Rock1.Name = "Rock1"
        Me.Rock1.Size = New System.Drawing.Size(94, 84)
        Me.Rock1.TabIndex = 0
        Me.Rock1.UseVisualStyleBackColor = True
        '
        'Paper1
        '
        Me.Paper1.BackgroundImage = Global.BetZone.My.Resources.Resources.Paper
        Me.Paper1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Paper1.Location = New System.Drawing.Point(115, 284)
        Me.Paper1.Name = "Paper1"
        Me.Paper1.Size = New System.Drawing.Size(94, 84)
        Me.Paper1.TabIndex = 1
        Me.Paper1.UseVisualStyleBackColor = True
        '
        'Scissors1
        '
        Me.Scissors1.BackgroundImage = Global.BetZone.My.Resources.Resources.Scissors
        Me.Scissors1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Scissors1.Location = New System.Drawing.Point(215, 284)
        Me.Scissors1.Name = "Scissors1"
        Me.Scissors1.Size = New System.Drawing.Size(94, 84)
        Me.Scissors1.TabIndex = 2
        Me.Scissors1.UseVisualStyleBackColor = True
        '
        'Scissors2
        '
        Me.Scissors2.BackgroundImage = Global.BetZone.My.Resources.Resources.Scissors
        Me.Scissors2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Scissors2.Location = New System.Drawing.Point(633, 284)
        Me.Scissors2.Name = "Scissors2"
        Me.Scissors2.Size = New System.Drawing.Size(94, 84)
        Me.Scissors2.TabIndex = 5
        Me.Scissors2.UseVisualStyleBackColor = True
        '
        'Paper2
        '
        Me.Paper2.BackgroundImage = Global.BetZone.My.Resources.Resources.Paper
        Me.Paper2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Paper2.Location = New System.Drawing.Point(533, 284)
        Me.Paper2.Name = "Paper2"
        Me.Paper2.Size = New System.Drawing.Size(94, 84)
        Me.Paper2.TabIndex = 4
        Me.Paper2.UseVisualStyleBackColor = True
        '
        'Rock2
        '
        Me.Rock2.BackgroundImage = Global.BetZone.My.Resources.Resources.Rock
        Me.Rock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Rock2.Location = New System.Drawing.Point(433, 284)
        Me.Rock2.Name = "Rock2"
        Me.Rock2.Size = New System.Drawing.Size(94, 84)
        Me.Rock2.TabIndex = 3
        Me.Rock2.UseVisualStyleBackColor = True
        '
        'PlaceBetLbl
        '
        Me.PlaceBetLbl.AutoSize = True
        Me.PlaceBetLbl.BackColor = System.Drawing.Color.Transparent
        Me.PlaceBetLbl.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceBetLbl.ForeColor = System.Drawing.Color.White
        Me.PlaceBetLbl.Location = New System.Drawing.Point(188, 387)
        Me.PlaceBetLbl.Name = "PlaceBetLbl"
        Me.PlaceBetLbl.Size = New System.Drawing.Size(121, 25)
        Me.PlaceBetLbl.TabIndex = 6
        Me.PlaceBetLbl.Text = "Place Bet"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(83, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 153)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(483, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(164, 153)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'ShowBtn
        '
        Me.ShowBtn.Location = New System.Drawing.Point(319, 427)
        Me.ShowBtn.Name = "ShowBtn"
        Me.ShowBtn.Size = New System.Drawing.Size(107, 38)
        Me.ShowBtn.TabIndex = 10
        Me.ShowBtn.Text = "Show"
        Me.ShowBtn.UseVisualStyleBackColor = True
        '
        'Bet
        '
        Me.Bet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bet.Font = New System.Drawing.Font("Times New Roman", 15.25!, System.Drawing.FontStyle.Bold)
        Me.Bet.FormattingEnabled = True
        Me.Bet.Items.AddRange(New Object() {"100", "200", "400", "600", "800", "1000", "5000"})
        Me.Bet.Location = New System.Drawing.Point(193, 421)
        Me.Bet.Name = "Bet"
        Me.Bet.Size = New System.Drawing.Size(108, 31)
        Me.Bet.TabIndex = 14
        '
        'EarnTxt
        '
        Me.EarnTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.EarnTxt.Location = New System.Drawing.Point(442, 421)
        Me.EarnTxt.Name = "EarnTxt"
        Me.EarnTxt.Size = New System.Drawing.Size(108, 31)
        Me.EarnTxt.TabIndex = 15
        '
        'EarnLbl
        '
        Me.EarnLbl.AutoSize = True
        Me.EarnLbl.BackColor = System.Drawing.Color.Transparent
        Me.EarnLbl.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EarnLbl.ForeColor = System.Drawing.Color.White
        Me.EarnLbl.Location = New System.Drawing.Point(428, 387)
        Me.EarnLbl.Name = "EarnLbl"
        Me.EarnLbl.Size = New System.Drawing.Size(0, 25)
        Me.EarnLbl.TabIndex = 17
        '
        'JackEnPoyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BetZone.My.Resources.Resources.Untitled_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(739, 486)
        Me.Controls.Add(Me.EarnLbl)
        Me.Controls.Add(Me.EarnTxt)
        Me.Controls.Add(Me.Bet)
        Me.Controls.Add(Me.ShowBtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PlaceBetLbl)
        Me.Controls.Add(Me.Scissors2)
        Me.Controls.Add(Me.Paper2)
        Me.Controls.Add(Me.Rock2)
        Me.Controls.Add(Me.Scissors1)
        Me.Controls.Add(Me.Paper1)
        Me.Controls.Add(Me.Rock1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "JackEnPoyForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JackEnPoyForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rock1 As Button
    Friend WithEvents Paper1 As Button
    Friend WithEvents Scissors1 As Button
    Friend WithEvents Scissors2 As Button
    Friend WithEvents Paper2 As Button
    Friend WithEvents Rock2 As Button
    Friend WithEvents PlaceBetLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ShowBtn As Button
    Friend WithEvents Bet As ComboBox
    Friend WithEvents EarnTxt As TextBox
    Friend WithEvents EarnLbl As Label
End Class
