<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotMachineForm
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SpinBtn = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbljackpot = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BetZone.My.Resources.Resources.Slot_Machine_PNG_Picture
        Me.PictureBox1.Location = New System.Drawing.Point(174, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(736, 542)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SpinBtn
        '
        Me.SpinBtn.Location = New System.Drawing.Point(416, 635)
        Me.SpinBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SpinBtn.Name = "SpinBtn"
        Me.SpinBtn.Size = New System.Drawing.Size(160, 58)
        Me.SpinBtn.TabIndex = 16
        Me.SpinBtn.Text = "Spin"
        Me.SpinBtn.UseVisualStyleBackColor = True
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Transparent
        Me.pb1.Location = New System.Drawing.Point(218, 304)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(171, 183)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 18
        Me.pb1.TabStop = False
        '
        'pb2
        '
        Me.pb2.BackColor = System.Drawing.Color.Transparent
        Me.pb2.Location = New System.Drawing.Point(416, 304)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(171, 183)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2.TabIndex = 19
        Me.pb2.TabStop = False
        '
        'pb3
        '
        Me.pb3.BackColor = System.Drawing.Color.Transparent
        Me.pb3.Location = New System.Drawing.Point(616, 304)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(171, 183)
        Me.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb3.TabIndex = 20
        Me.pb3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(383, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 32)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Jackpot"
        '
        'lbljackpot
        '
        Me.lbljackpot.BackColor = System.Drawing.Color.Transparent
        Me.lbljackpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljackpot.ForeColor = System.Drawing.SystemColors.Control
        Me.lbljackpot.Location = New System.Drawing.Point(508, 259)
        Me.lbljackpot.Name = "lbljackpot"
        Me.lbljackpot.Size = New System.Drawing.Size(118, 29)
        Me.lbljackpot.TabIndex = 22
        Me.lbljackpot.Text = "10000"
        Me.lbljackpot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'SlotMachineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BetZone.My.Resources.Resources.JackEnPoyBg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1108, 748)
        Me.Controls.Add(Me.lbljackpot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.SpinBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SlotMachineForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SlotMachineForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SpinBtn As Button
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents pb3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbljackpot As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
