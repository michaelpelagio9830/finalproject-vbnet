Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Net.Sockets

Namespace Tic_Tac_Toe_Game
    Public Partial Class Game
        Inherits Form

        Public Sub New(ByVal isHost As Boolean, ByVal Optional ip As String = Nothing)
            InitializeComponent()
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
            label1.Text = "Opponent's Turn!"
            ReceiveMove()
            label1.Text = "Your Trun!"
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
            If Equals(button1.Text, button2.Text) AndAlso Equals(button2.Text, button3.Text) AndAlso Not Equals(button3.Text, "") Then

                If button1.Text(0) = PlayerChar Then
                    label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Equals(button4.Text, button5.Text) AndAlso Equals(button5.Text, button6.Text) AndAlso Not Equals(button6.Text, "") Then

                If button4.Text(0) = PlayerChar Then
                    label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Equals(button7.Text, button8.Text) AndAlso Equals(button8.Text, button9.Text) AndAlso Not Equals(button9.Text, "") Then

                If button7.Text(0) = PlayerChar Then
                    label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True

                'Verticals
            ElseIf Equals(button1.Text, button4.Text) AndAlso Equals(button4.Text, button7.Text) AndAlso Not Equals(button7.Text, "") Then

                If button1.Text(0) = PlayerChar Then
                    label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Equals(button2.Text, button5.Text) AndAlso Equals(button5.Text, button8.Text) AndAlso Not Equals(button8.Text, "") Then

                If button2.Text(0) = PlayerChar Then
                    label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Equals(button3.Text, button6.Text) AndAlso Equals(button6.Text, button9.Text) AndAlso Not Equals(button9.Text, "") Then

                If button3.Text(0) = PlayerChar Then
                    label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Equals(button1.Text, button5.Text) AndAlso Equals(button5.Text, button9.Text) AndAlso Not Equals(button9.Text, "") Then

                If button1.Text(0) = PlayerChar Then
                    label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
            ElseIf Equals(button3.Text, button5.Text) AndAlso Equals(button5.Text, button7.Text) AndAlso Not Equals(button7.Text, "") Then

                If button3.Text(0) = PlayerChar Then
                    label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True

                'Draw
            ElseIf Not Equals(button1.Text, "") AndAlso Not Equals(button2.Text, "") AndAlso Not Equals(button3.Text, "") AndAlso Not Equals(button4.Text, "") AndAlso Not Equals(button5.Text, "") AndAlso Not Equals(button6.Text, "") AndAlso Not Equals(button7.Text, "") AndAlso Not Equals(button8.Text, "") AndAlso Not Equals(button9.Text, "") Then
                label1.Text = "It's a draw!"
                MessageBox.Show("It's a draw!")
                Return True
            End If

            Return False
        End Function

        Private Sub FreezeBoard()
            button1.Enabled = False
            button2.Enabled = False
            button3.Enabled = False
            button4.Enabled = False
            button5.Enabled = False
            button6.Enabled = False
            button7.Enabled = False
            button8.Enabled = False
            button9.Enabled = False
        End Sub

        Private Sub UnfreezeBoard()
            If Equals(button1.Text, "") Then button1.Enabled = True
            If Equals(button2.Text, "") Then button2.Enabled = True
            If Equals(button3.Text, "") Then button3.Enabled = True
            If Equals(button4.Text, "") Then button4.Enabled = True
            If Equals(button5.Text, "") Then button5.Enabled = True
            If Equals(button6.Text, "") Then button6.Enabled = True
            If Equals(button7.Text, "") Then button7.Enabled = True
            If Equals(button8.Text, "") Then button8.Enabled = True
            If Equals(button9.Text, "") Then button9.Enabled = True
        End Sub

        Private Sub ReceiveMove()
            Dim buffer As Byte() = New Byte(0) {}
            sock.Receive(buffer)
            If buffer(0) = 1 Then button1.Text = OpponentChar.ToString()
            If buffer(0) = 2 Then button2.Text = OpponentChar.ToString()
            If buffer(0) = 3 Then button3.Text = OpponentChar.ToString()
            If buffer(0) = 4 Then button4.Text = OpponentChar.ToString()
            If buffer(0) = 5 Then button5.Text = OpponentChar.ToString()
            If buffer(0) = 6 Then button6.Text = OpponentChar.ToString()
            If buffer(0) = 7 Then button7.Text = OpponentChar.ToString()
            If buffer(0) = 8 Then button8.Text = OpponentChar.ToString()
            If buffer(0) = 9 Then button9.Text = OpponentChar.ToString()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {1}
            sock.Send(num)
            button1.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {2}
            sock.Send(num)
            button2.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {3}
            sock.Send(num)
            button3.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {4}
            sock.Send(num)
            button4.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {5}
            sock.Send(num)
            button5.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {6}
            sock.Send(num)
            button6.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button7_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {7}
            sock.Send(num)
            button7.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button8_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {8}
            sock.Send(num)
            button8.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub button9_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Byte() = {9}
            sock.Send(num)
            button9.Text = PlayerChar.ToString()
            MessageReceiver.RunWorkerAsync()
        End Sub

        Private Sub Game_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            MessageReceiver.WorkerSupportsCancellation = True
            MessageReceiver.CancelAsync()
            If server IsNot Nothing Then server.Stop()
        End Sub
    End Class
End Namespace
