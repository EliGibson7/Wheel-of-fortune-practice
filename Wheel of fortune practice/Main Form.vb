Imports System.Security.Cryptography

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As Integer = CInt(Int((25 * Rnd()) + 1))



        Label1.Text = value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'PictureBox1.Image = My.Resources.chartbase
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As Integer = CInt(Int((25 * Rnd()) + 1))



        Label1.Text = value

        Dim intPic = 0
        MsgBox(value)



        For Spins As Integer = 0 To value
            System.Threading.Thread.Sleep(5000)
            intPic = Spins Mod 25
            If intPic = 0 Then
                PictureBox1.Image = My.Resources.chart1real
            ElseIf intPic = 1 Then
                PictureBox1.Image = My.Resources.chart2
            ElseIf intPic = 2 Then
                PictureBox1.Image = My.Resources.chart3
            ElseIf intPic = 3 Then
                PictureBox1.Image = My.Resources.chart4
            ElseIf intPic = 4 Then
                PictureBox1.Image = My.Resources.chart5
            ElseIf intPic = 5 Then
                PictureBox1.Image = My.Resources.chart6
            ElseIf intPic = 6 Then
                PictureBox1.Image = My.Resources.chart7
            ElseIf intPic = 7 Then
                PictureBox1.Image = My.Resources.chart8
            ElseIf intPic = 8 Then
                PictureBox1.Image = My.Resources.chart9
            ElseIf intPic = 9 Then
                PictureBox1.Image = My.Resources.chart10
            ElseIf intPic = 10 Then
                PictureBox1.Image = My.Resources.chart11
            ElseIf intPic = 11 Then
                PictureBox1.Image = My.Resources.chart12
            ElseIf intPic = 12 Then
                PictureBox1.Image = My.Resources.chart13
            ElseIf intPic = 13 Then
                PictureBox1.Image = My.Resources.chart14
            ElseIf intPic = 14 Then
                PictureBox1.Image = My.Resources.chart15
            ElseIf intPic = 15 Then
                PictureBox1.Image = My.Resources.chart16
            ElseIf intPic = 16 Then
                PictureBox1.Image = My.Resources.chart17
            ElseIf intPic = 17 Then
                PictureBox1.Image = My.Resources.chart18
            ElseIf intPic = 18 Then
                PictureBox1.Image = My.Resources.chart19
            ElseIf intPic = 19 Then
                PictureBox1.Image = My.Resources.chart20
            ElseIf intPic = 20 Then
                PictureBox1.Image = My.Resources.chart21
            ElseIf intPic = 21 Then
                PictureBox1.Image = My.Resources.chart22
            ElseIf intPic = 22 Then
                PictureBox1.Image = My.Resources.chart23
            ElseIf intPic = 23 Then
                PictureBox1.Image = My.Resources.chart24
            ElseIf intPic = 24 Then
                PictureBox1.Image = My.Resources.chart25

            End If
        Next



    End Sub
End Class
