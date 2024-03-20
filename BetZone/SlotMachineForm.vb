Imports System.Data.SqlTypes
Imports System.IO
Imports System.Security.Policy
Imports System.Threading

Public Class SlotMachineForm

    Dim addjackpot As Integer
    Dim randomcard As New Random()
    Dim ran As Integer
    Dim TickOut As Integer


    Dim ran1 As Integer
    Dim ran2 As Integer
    Dim ran3 As Integer

    Dim token As Integer
    Private Sub SlotMachineForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(SpinBtn)
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

    Private Sub SpinBtn_Click(sender As Object, e As EventArgs) Handles SpinBtn.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        TickOut = 0
        If Integer.TryParse(MainMenu.TokenLbl.Text, token) Then
            token -= 25
            MainMenu.TokenLbl.Text = token.ToString()
        End If
    End Sub


    Private Function ImageEquals(image1 As Image, image2 As Image) As Boolean

        If image1 Is Nothing AndAlso image2 Is Nothing Then
            Return True
        ElseIf image1 IsNot Nothing AndAlso image2 IsNot Nothing Then

            Using ms1 As New MemoryStream(), ms2 As New MemoryStream()
                image1.Save(ms1, image1.RawFormat)
                image2.Save(ms2, image2.RawFormat)
                Return ms1.ToArray().SequenceEqual(ms2.ToArray())
            End Using
        End If

        Return False
    End Function
    Private Function IsJackpot(image1 As Image, image2 As Image, image3 As Image) As Boolean

        Dim jackpotImage As Image = My.Resources.card0
        Return ImageEquals(image1, jackpotImage) AndAlso ImageEquals(image2, jackpotImage) AndAlso ImageEquals(image3, jackpotImage)
    End Function

    Private Sub CheckWinningCombination()

        Dim image1 As Image = pb1.Image
        Dim image2 As Image = pb2.Image
        Dim image3 As Image = pb3.Image


        If IsJackpot(image1, image2, image3) Then
            MsgBox("Jackpot! You win" & lbljackpot.Text & "pesos!")
            token += CInt(lbljackpot.Text)
            lbljackpot.Text = 10000
        ElseIf ImageEquals(image1, image2) AndAlso ImageEquals(image2, image3) Then
            MsgBox("You win 100 pesos!")
            token += 100

        ElseIf ImageEquals(image1, image2) Or ImageEquals(image2, image3) Or ImageEquals(image1, image3) Or ImageEquals(image2, image1) Then

            MsgBox("You win 50 pesos!")
            token += 50
        Else
            MsgBox("Sorry, you lose")
            addjackpot += 25
            lbljackpot.Text = (Integer.Parse(lbljackpot.Text) + addjackpot).ToString()
        End If
        MainMenu.TokenLbl.Text = token.ToString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ran1 = randomcard.Next(0, 6) Mod 9
        TickOut += 1

        If TickOut < 50 Then
            pb1.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory, "SlotMachine", "card" & ran1 & ".png"))
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ran2 = randomcard.Next(0, 6) Mod 9
        TickOut += 1

        If TickOut < 70 Then
            pb2.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory, "SlotMachine", "card" & ran2 & ".png"))
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ran3 = randomcard.Next(0, 6) Mod 9
        TickOut += 1

        If TickOut < 90 Then
            pb3.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory, "SlotMachine", "card" & ran3 & ".png"))
        Else
            Timer3.Enabled = False
            CheckWinningCombination()
        End If
    End Sub
End Class