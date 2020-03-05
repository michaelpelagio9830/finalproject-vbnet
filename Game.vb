Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Net.Sockets

Namespace Tic_Tac_Toe_Game
    Public Partial Class Game
        Inherits Form

        Public Sub New(ByVal isHost As Boolean, ByVal Optional ip As String = Nothing)
            Me.InitializeComponent()
            AddHandler MessageReceiver.DoWork, AddressOf MessageReceiver_DoWork
            CheckForIllegalCrossThreadCalls = False

            If isHost Then
                PlayerChar = "X"c
                OpponentChar = "O"c
                server = New TcpListener(Net.IPAddress.Any, 5732)
                server.Start()
                sock = server.AcceptSocket()
            Else
                PlayerChar = "O"c
                OpponentChar = "X"c

                Try
                    client = New TcpClient(ip, 5732)
                    sock = client.Client
                    MessageReceiver.RunWorkerAsync()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Close()
                End Try
            End If
        End Sub

        Private Sub MessageReceiver_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            If CheckState() Then Return
            FreezeBoard()
            Me.label1.Text = "Opponent's Turn!"
            ReceiveMove()
            Me.label1.Text = "Your Trun!"
            If Not CheckState() Then UnfreezeBoard()
        End Sub

        Private PlayerChar As Char
        Private OpponentChar As Char
        Private sock As Socket
        Private MessageReceiver As BackgroundWorker = New BackgroundWorker()
        Private server As TcpListener = Nothing
        Private client As TcpClient

        Private Function CheckState() As Boolean
            'Horizontals
            If Me.button1.Text Is Me.button2.Text AndAlso Me.button2.Text Is Me.button3.Text AndAlso Me.button3.Text IsNot "" Then

                If Me.button1.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Me.button4.Text Is Me.button5.Text AndAlso Me.button5.Text Is Me.button6.Text AndAlso Me.button6.Text IsNot "" Then

                If Me.button4.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Me.button7.Text Is Me.button8.Text AndAlso Me.button8.Text Is Me.button9.Text AndAlso Me.button9.Text IsNot "" Then

                If Me.button7.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True

                'Verticals
            ElseIf Me.button1.Text Is Me.button4.Text AndAlso Me.button4.Text Is Me.button7.Text AndAlso Me.button7.Text IsNot "" Then

                If Me.button1.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Me.button2.Text Is Me.button5.Text AndAlso Me.button5.Text Is Me.button8.Text AndAlso Me.button8.Text IsNot "" Then

                If Me.button2.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Me.button3.Text Is Me.button6.Text AndAlso Me.button6.Text Is Me.button9.Text AndAlso Me.button9.Text IsNot "" Then

                If Me.button3.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Me.button1.Text Is Me.button5.Text AndAlso Me.button5.Text Is Me.button9.Text AndAlso Me.button9.Text IsNot "" Then

                If Me.button1.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Me.button3.Text Is Me.button5.Text AndAlso Me.button5.Text Is Me.button7.Text AndAlso Me.button7.Text IsNot "" Then

                If Me.button3.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True

                'Draw
            ElseIf Me.button1.Text IsNot "" AndAlso Me.button2.Text IsNot "" AndAlso Me.button3.Text IsNot "" AndAlso Me.button4.Text IsNot "" AndAlso Me.button5.Text IsNot "" AndAlso Me.button6.Text IsNot "" AndAlso Me.button7.Text IsNot "" AndAlso Me.button8.Text IsNot "" AndAlso Me.button9.Text IsNot "" Then
                Me.label1.Text = "It's a draw!"
                MessageBox.Show("It's a draw!")
                Return True
            End If

            Return False
        End Function

        Private Sub FreezeBoard()
            Me.button1.Enabled = False
            Me.button2.Enabled = False
            Me.button3.Enabled = False
            Me.button4.Enabled = False
            Me.button5.Enabled = False
            Me.button6.Enabled = False
            Me.button7.Enabled = False
            Me.button8.Enabled = False
            Me.button9.Enabled = False
        End Sub

        Private Sub UnfreezeBoard()
            If Me.button1.Text Is "" Then Me.button1.Enabled = True
            If Me.button2.Text Is "" Then Me.button2.Enabled = True
            If Me.button3.Text Is "" Then Me.button3.Enabled = True
            If Me.button4.Text Is "" Then Me.button4.Enabled = True
            If Me.button5.Text Is "" Then Me.button5.Enabled = True
            If Me.button6.Text Is "" Then Me.button6.Enabled = True
            If Me.button7.Text Is "" Then Me.button7.Enabled = True
            If Me.button8.Text Is "" Then Me.button8.Enabled = True
            If Me.button9.Text Is "" Then Me.button9.Enabled = True
        End Sub

        Private Sub ReceiveMove()
            Dim buffer As Byte() = New Byte(0) {}
            sock.Receive(buffer)
            If buffer(0) = 1 Then Me.button1.Text = OpponentChar.ToString()
            If buffer(0) = 2 Then Me.button2.Text = OpponentChar.ToString()
            If buffer(0) = 3 Then Me.button3.Text = OpponentChar.ToString()
            If buffer(0) = 4 Then Me.button4.Text = OpponentChar.ToString()
            If buffer(0) = 5 Then Me.button5.Text = OpponentChar.ToString()
            If buffer(0) = 6 Then Me.button6.Text = OpponentChar.ToString()
            If buffer(0) = 7 Then Me.button7.Text = OpponentChar.ToString()
            If buffer(0) = 8 Then Me.button8.Text = OpponentChar.ToString()
            If buffer(0) = 9 Then Me.button9.Text = OpponentChar.ToString()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {1}
            sock.Send(num)
            Me.button1.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {2}
            sock.Send(num)
            Me.button2.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {3}
            sock.Send(num)
            Me.button3.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {4}
            sock.Send(num)
            Me.button4.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {5}
            sock.Send(num)
            Me.button5.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {6}
            sock.Send(num)
            Me.button6.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button7_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {7}
            sock.Send(num)
            Me.button7.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button8_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {8}
            sock.Send(num)
            Me.button8.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button9_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {9}
            sock.Send(num)
            Me.button9.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub Game_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            MessageReceiver.WorkerSupportsCancellation = True
            MessageReceiver.CancelAsync()
            If server IsNot Nothing Then server.Stop()
        End Sub
    End Class
End Namespace
