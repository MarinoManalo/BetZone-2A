Imports System
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundForm(Me)

        RoundButton(StartBtn)
        RoundButtonExit(ExitBtn)

        RoundButtonTop(XBtn)
        RoundButtonTop(MinimizeBtn)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.BackColor = Color.FromArgb(165, 255, 255, 255)
    End Sub

    Private Sub XBtn_Click(sender As Object, e As EventArgs) Handles XBtn.Click
        CloseButton(XBtn)
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        CloseButton(ExitBtn)
    End Sub
    Private Sub MinimizeBtn_Click(sender As Object, e As EventArgs) Handles MinimizeBtn.Click
        MinimizeButton(MinimizeBtn)
    End Sub


    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        Dim MoneyForm As New AddMoneyForm
        MoneyForm.Show()
        Me.Hide()
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
    Private Sub RoundButtonExit(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(139, 0, 0)
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 15)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btn.Region = New Region(Raduis)
    End Sub
    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(54, 69, 79)
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 15)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btn.Region = New Region(Raduis)
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


End Class
