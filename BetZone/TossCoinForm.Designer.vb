<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TossCoinForm
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
        Me.components = New System.ComponentModel.Container()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.Bet = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CoinBet = New System.Windows.Forms.ComboBox()
        Me.PlaceBetLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb2
        '
        Me.pb2.BackColor = System.Drawing.Color.Transparent
        Me.pb2.Location = New System.Drawing.Point(580, 246)
        Me.pb2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(262, 225)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2.TabIndex = 0
        Me.pb2.TabStop = False
        '
        'Bet
        '
        Me.Bet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bet.FormattingEnabled = True
        Me.Bet.Items.AddRange(New Object() {"100", "200", "400", "600", "800", "1000", "5000"})
        Me.Bet.Location = New System.Drawing.Point(264, 205)
        Me.Bet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bet.Name = "Bet"
        Me.Bet.Size = New System.Drawing.Size(180, 34)
        Me.Bet.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 518)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 68)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Toss"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'CoinBet
        '
        Me.CoinBet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoinBet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoinBet.FormattingEnabled = True
        Me.CoinBet.Items.AddRange(New Object() {"Head ", "Tail"})
        Me.CoinBet.Location = New System.Drawing.Point(264, 335)
        Me.CoinBet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CoinBet.Name = "CoinBet"
        Me.CoinBet.Size = New System.Drawing.Size(180, 34)
        Me.CoinBet.TabIndex = 4
        '
        'PlaceBetLbl
        '
        Me.PlaceBetLbl.AutoSize = True
        Me.PlaceBetLbl.BackColor = System.Drawing.Color.Transparent
        Me.PlaceBetLbl.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceBetLbl.ForeColor = System.Drawing.Color.White
        Me.PlaceBetLbl.Location = New System.Drawing.Point(264, 162)
        Me.PlaceBetLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlaceBetLbl.Name = "PlaceBetLbl"
        Me.PlaceBetLbl.Size = New System.Drawing.Size(183, 38)
        Me.PlaceBetLbl.TabIndex = 7
        Me.PlaceBetLbl.Text = "Place Bet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(192, 275)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Chooose your Bet"
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Transparent
        Me.pb1.Location = New System.Drawing.Point(284, 379)
        Me.pb1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(140, 129)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 9
        Me.pb1.TabStop = False
        '
        'TossCoinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BetZone.My.Resources.Resources.JackEnPoyBg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1108, 748)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlaceBetLbl)
        Me.Controls.Add(Me.CoinBet)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bet)
        Me.Controls.Add(Me.pb2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TossCoinForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TossCoinForm"
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb2 As PictureBox
    Friend WithEvents Bet As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CoinBet As ComboBox
    Friend WithEvents PlaceBetLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pb1 As PictureBox
End Class
