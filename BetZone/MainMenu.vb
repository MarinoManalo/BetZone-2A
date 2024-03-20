

Imports System.Security.Cryptography.X509Certificates

Public Class MainMenu

    Public Property tokenInt As Integer

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TokenLbl.Text = AddMoneyForm.totaltoken

        RoundForm(Me)

        RoundButtonTop(XBtn)
        RoundButtonTop(MinimizeBtn)

        RoundButton(SlotMaBtn)
        RoundButton(TossCoBtn)
        RoundButton(JackEnPoyBtn)
        RoundButton(LuckyNineBtn)

        RoundButtonBuyToken(BuyTokenBtn)

        RoundButtonExit(BtnExit)

    End Sub

    Private Sub MinimizeBtn_Click(sender As Object, e As EventArgs) Handles MinimizeBtn.Click
        MinimizeButton(MinimizeBtn)
    End Sub
    Private Sub XBtn_Click(sender As Object, e As EventArgs) Handles XBtn.Click
        CloseButton(XBtn)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        CloseButton(BtnExit)
    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles BuyTokenBtn.Click
        BuyTokenButton(BuyTokenBtn)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint, Panel2.Paint
        Panel1.BackColor = Color.FromArgb(175, 255, 255, 255)

        Panel2.BackColor = Color.FromArgb(175, 255, 255, 255)
    End Sub

    Private Sub SlotMaBtn_Click(sender As Object, e As EventArgs) Handles SlotMaBtn.Click
        SwitchPanel(SlotMachineForm)
    End Sub
    Private Sub TossCoBtn_Click(sender As Object, e As EventArgs) Handles TossCoBtn.Click
        SwitchPanel(TossCoinForm)
    End Sub
    Private Sub JackEnPoyBtn_Click(sender As Object, e As EventArgs) Handles JackEnPoyBtn.Click
        SwitchPanel(JackEnPoyForm)
    End Sub
    Private Sub LuckyNineBtn_Click(sender As Object, e As EventArgs) Handles LuckyNineBtn.Click
        SwitchPanel(LuckyNineForm)
    End Sub

    Sub SwitchPanel(ByVal panel As Form)
        GamePanel.Controls.Clear()
        panel.TopLevel = False
        GamePanel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub MinimizeButton(minimize As Button)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub CloseButton(XBtn As Button)
        Dim ans As DialogResult

        ans = MessageBox.Show("Are you sure you want to exit?",
                        "Exit Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub BuyTokenButton(Buybtn As Button)
        Dim tokenInt2 As Integer
        Integer.TryParse(Me.TokenLbl.Text, tokenInt2)
        If tokenInt2 >= 15000 Then
            MessageBox.Show("You can't purchase more than 15,000 tokens.",
                            "Error")
        Else
            Me.Hide()
            AddMoneyForm.Show()
        End If

    End Sub
    Private Sub RoundButtonExit(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(139, 0, 0)
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 12)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()

        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)

        Raduis.AddLine(10, 0, btn.Width - 20, 0)

        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)

        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Raduis.CloseFigure()

        btn.Region = New Region(Raduis)
    End Sub
    Private Sub RoundButtonBuyToken(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(153, 101, 21)
        btn.ForeColor = Color.Black
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 13)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()

        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)

        Raduis.AddLine(10, 0, btn.Width - 20, 0)

        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)

        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Raduis.CloseFigure()

        btn.Region = New Region(Raduis)
    End Sub

    Private Sub RoundForm(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.Cyan

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub
    Private Sub RoundButtonTop(btnTop As Button)

        btnTop.FlatAppearance.BorderSize = 0
        btnTop.FlatStyle = FlatStyle.Flat
        btnTop.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btnTop.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btnTop.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btnTop.Width, 20, btnTop.Width, btnTop.Height - 10)
        Raduis.AddArc(New Rectangle(btnTop.Width - 25, btnTop.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btnTop.Width - 10, btnTop.Width, 20, btnTop.Height)
        Raduis.AddArc(New Rectangle(0, btnTop.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()
        btnTop.Region = New Region(Raduis)

    End Sub
    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(54, 69, 79)
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 13)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()
        btn.Region = New Region(Raduis)

    End Sub


End Class