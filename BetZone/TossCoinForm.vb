Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlTypes
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports System.Security.Policy

Public Class TossCoinForm

    Dim ran As New Random()
    Dim compcoin As Integer
    Dim tickCount As Integer


    Dim token As Integer
    Private Sub TossCoinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(Button1)
    End Sub
    Private Sub combobox1_selectedindexchanged(sender As Object, e As EventArgs) Handles CoinBet.SelectedIndexChanged
        Select Case CoinBet.SelectedIndex
            Case 0
                pb1.Image = My.Resources.coin0
            Case 1
                pb1.Image = My.Resources.coin1
        End Select
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CoinBet.SelectedItem = Nothing Then
            MsgBox("Please select if Head or Tail First")
        ElseIf bet.SelectedItem = Nothing Then
            MsgBox("Please select bet")
        Else
            If Integer.TryParse(MainMenu.TokenLbl.Text, token) Then
                If Bet.SelectedItem > token Then
                    MessageBox.Show("Insufficient amount, Please Top up to the menu")
                Else
                    tickCount = 0
                    Timer1.Enabled = True
                End If
            End If
        End If
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


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        compcoin = ran.Next(0, 2)
        pb2.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory, "TossCoinPics", "coin" & compcoin & ".png"))


        tickCount += 1

        If tickCount < 20 Then

        Else
            Timer1.Enabled = False
            Dim userChoice As Integer = CoinBet.SelectedIndex

            If userChoice = compcoin Then
                MsgBox("You Won")
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
                    MainMenu.TokenLbl.Text = token.ToString()
                End If
            Else
                MsgBox("You lose")
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
                    MainMenu.TokenLbl.Text = token.ToString()
                End If

            End If

        End If
    End Sub
End Class