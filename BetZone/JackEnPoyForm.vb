Imports System.IO
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Public Class JackEnPoyForm
    Public Property tokenInt As Integer
    Public Property token As Integer

    Dim random As New Random
    Dim ran As Integer

    Public Event UserWon(ByVal wonAmount As Integer)
    Public Event UserLost(ByVal lostAmount As Integer)

    Private Sub JackEnPoyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButton(Rock1)
        RoundButton(Paper1)
        RoundButton(Scissors1)

        RoundButton(Rock2)
        RoundButton(Paper2)
        RoundButton(Scissors2)

        RoundButton(ShowBtn)

    End Sub

    Private Sub Player1_Click(sender As Object, e As EventArgs) Handles Rock1.Click, Paper1.Click, Scissors1.Click
        Dim clickedButton As Button = DirectCast(sender, Button)

        Select Case clickedButton.Name
            Case "Rock1"
                PictureBox1.Tag = 0
                PictureBox1.Image = My.Resources.Rock
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            Case "Paper1"
                PictureBox1.Tag = 2
                PictureBox1.Image = My.Resources.Paper
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            Case "Scissors1"
                PictureBox1.Tag = 1
                PictureBox1.Image = My.Resources.Scissors
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End Select

    End Sub


    Private Sub ShowBtn_Click(sender As Object, e As EventArgs) Handles ShowBtn.Click
        Dim betInt As Integer = CInt(Bet.SelectedItem)
        Dim tokenInt1 As Integer
        Integer.TryParse(MainMenu.TokenLbl.Text, tokenInt1)

        If PictureBox1.Image Is Nothing Then
            MsgBox("Make sure to choose either rock, paper, or scissors.")

        ElseIf betInt > tokenInt1 Then
            MsgBox("Insufficient tokens. Please acquire more before proceeding.")

        ElseIf Bet.SelectedItem = Nothing Then
            MsgBox("No bet selected. Please choose one")
        Else
            GameFunction()
        End If

    End Sub

    Public Sub GameFunction()
        Dim PlayerChoice As Integer = CInt(PictureBox1.Tag)
        ran = random.Next(0, 3)
        PictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\JackEnPoyPics\card" & ran & ".jpg")

        If PlayerChoice = ran Then
            MsgBox("It's a tie! Neither side wins this round.")
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
        ElseIf (PlayerChoice = 0 And ran = 1) Or
               (PlayerChoice = 1 And ran = 2) Or
               (PlayerChoice = 2 And ran = 0) Then


            EarnLbl.Text = "Token Won"
            If Integer.TryParse(MainMenu.TokenLbl.Text, token) Then
                Select Case Bet.SelectedIndex
                    Case 0
                        token += 100
                    Case 1
                        token += 200

                    Case 2
                        token += 400

                    Case 3
                        token += 600

                    Case 4
                        token += 800

                    Case 5
                        token += 1000

                    Case 6
                        token += 5000

                End Select
                MainMenu.TokenLbl.Text = token
            End If
            EarnTxt.Text = Bet.SelectedItem
            MsgBox("Congratulations! You've outwitted your opponent with your pick.")

            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
        Else

            EarnLbl.Text = "Token lost"

            If Integer.TryParse(MainMenu.TokenLbl.Text, token) Then
                Select Case Bet.SelectedIndex
                    Case 0
                        token -= 100
                    Case 1
                        token -= 200

                    Case 2
                        token -= 400

                    Case 3
                        token -= 600

                    Case 4
                        token -= 800

                    Case 5
                        token -= 1000

                    Case 6
                        token -= 5000

                End Select
                MainMenu.TokenLbl.Text = token
            End If
            EarnTxt.Text = "-" & Bet.SelectedItem
            MsgBox("Better luck next time! Your opponent's choice prevailed.")

            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing

        End If


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