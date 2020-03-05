Imports System
Imports System.Windows.Forms

Namespace Tic_Tac_Toe_Game
    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim newGame As Tic_Tac_Toe_Game.Game = New Tic_Tac_Toe_Game.Game(False, Me.textBox1.Text)
            Visible = False
            If Not newGame.IsDisposed Then newGame.ShowDialog()
            Visible = True
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim newGame As Tic_Tac_Toe_Game.Game = New Tic_Tac_Toe_Game.Game(True)
            Visible = False
            If Not newGame.IsDisposed Then newGame.ShowDialog()
            Visible = True
        End Sub
    End Class
End Namespace
