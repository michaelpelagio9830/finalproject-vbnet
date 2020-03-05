﻿Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Net.Sockets

Namespace Tic_Tac_Toe_Game
    Public Partial Class Game
        Inherits Form

<<<<<<< HEAD
        Public Sub Game(ByVal isHost As Boolean, ByVal Optional ip As String = Nothing)
            InitializeComponent()
=======
        Public Sub New(ByVal isHost As Boolean, ByVal Optional ip As String = Nothing)
            Me.InitializeComponent()
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2
            AddHandler MessageReceiver.DoWork, AddressOf MessageReceiver_DoWork
            CheckForIllegalCrossThreadCalls = False

            If isHost Then
                PlayerChar = "X"c
                OpponentChar = "O"c
<<<<<<< HEAD
                server = New TcpListener(Net.IPAddress.Any, 5732)
=======
                server = New TcpListener(System.Net.IPAddress.Any, 465)
>>>>>>> 2b4ee2a53c80225493f4e2f741a7e3a1d43c1e85
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
<<<<<<< HEAD

            'HORIZONTALS
            If button1.Text Is button2.Text AndAlso button2.Text Is button3.Text AndAlso button3.Text IsNot " " Then
=======
            'Horizontals
            If Me.button1.Text Is Me.button2.Text AndAlso Me.button2.Text Is Me.button3.Text AndAlso Me.button3.Text IsNot "" Then
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2

                If Me.button1.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
<<<<<<< HEAD
            ElseIf button4.Text Is button5.Text AndAlso button5.Text Is button6.Text AndAlso button6.Text IsNot "" Then
=======
            ElseIf Me.button4.Text Is Me.button5.Text AndAlso Me.button5.Text Is Me.button6.Text AndAlso Me.button6.Text IsNot "" Then
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2

                If Me.button4.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
<<<<<<< HEAD
            ElseIf button7.Text Is button8.Text AndAlso button8.Text Is button9.Text AndAlso button9.Text IsNot "" Then
=======
            ElseIf Me.button7.Text Is Me.button8.Text AndAlso Me.button8.Text Is Me.button9.Text AndAlso Me.button9.Text IsNot "" Then
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2

                If Me.button7.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
<<<<<<< HEAD

                'VERTICALS
            ElseIf button1.Text Is button4.Text AndAlso button4.Text Is button7.Text AndAlso button7.Text IsNot "" Then
=======
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2

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
<<<<<<< HEAD
            ElseIf button2.Text Is button5.Text AndAlso button5.Text Is button8.Text AndAlso button8.Text IsNot "" Then
=======
            ElseIf Me.button2.Text Is Me.button5.Text AndAlso Me.button5.Text Is Me.button8.Text AndAlso Me.button8.Text IsNot "" Then
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2

                If Me.button2.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
<<<<<<< HEAD
            ElseIf button3.Text Is button6.Text AndAlso button6.Text Is button9.Text AndAlso button9.Text IsNot "" Then
=======
            ElseIf Me.button3.Text Is Me.button6.Text AndAlso Me.button6.Text Is Me.button9.Text AndAlso Me.button9.Text IsNot "" Then
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2

                If Me.button3.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
<<<<<<< HEAD
            ElseIf button1.Text Is button5.Text AndAlso button5.Text Is button9.Text AndAlso button9.Text IsNot "" Then
=======
            ElseIf Me.button1.Text Is Me.button5.Text AndAlso Me.button5.Text Is Me.button9.Text AndAlso Me.button9.Text IsNot "" Then
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2

                If Me.button1.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True
<<<<<<< HEAD
            ElseIf button3.Text Is button5.Text AndAlso button5.Text Is button7.Text AndAlso button7.Text IsNot "" Then
=======
            ElseIf Me.button3.Text Is Me.button5.Text AndAlso Me.button5.Text Is Me.button7.Text AndAlso Me.button7.Text IsNot "" Then
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2

                If Me.button3.Text(0) = PlayerChar Then
                    Me.label1.Text = "You Won!"
                    MessageBox.Show("You Won!")
                Else
                    Me.label1.Text = "You Lost!"
                    MessageBox.Show("You Lost!")
                End If

                Return True

<<<<<<< HEAD
                'DRAW
            ElseIf button1.Text IsNot "" AndAlso button2.Text IsNot "" AndAlso button3.Text IsNot "" AndAlso button4.Text IsNot "" AndAlso button5.Text IsNot "" AndAlso button6.Text IsNot "" AndAlso button7.Text IsNot "" AndAlso button8.Text IsNot "" AndAlso button9.Text IsNot "" Then
                label1.Text = "It's a draw!"
=======
                'Draw
            ElseIf Me.button1.Text IsNot "" AndAlso Me.button2.Text IsNot "" AndAlso Me.button3.Text IsNot "" AndAlso Me.button4.Text IsNot "" AndAlso Me.button5.Text IsNot "" AndAlso Me.button6.Text IsNot "" AndAlso Me.button7.Text IsNot "" AndAlso Me.button8.Text IsNot "" AndAlso Me.button9.Text IsNot "" Then
                Me.label1.Text = "It's a draw!"
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2
                MessageBox.Show("It's a draw!")
                Return True
            End If

            Return False
        End Function

<<<<<<< HEAD
        Private Sub FreezeBoard() 'To make all buttons unclickable on your turn
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

        Private Sub UnfreezeBoard() 'To make all buttons clickable on your turn
            If button1.Text = "" Then button1.Enabled = True
            If button2.Text = "" Then button2.Enabled = True
            If button3.Text = "" Then button3.Enabled = True
            If button4.Text = "" Then button4.Enabled = True
            If button5.Text = "" Then button5.Enabled = True
            If button6.Text = "" Then button6.Enabled = True
            If button7.Text = "" Then button7.Enabled = True
            If button8.Text = "" Then button8.Enabled = True
            If button9.Text = "" Then button9.Enabled = True
=======
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
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2
        End Sub

        Private Sub ReceiveMove() 'this is where it translates the recieving of the move
            Dim buffer As Byte() = New Byte(0) {}
            sock.Receive(buffer)
<<<<<<< HEAD
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



        Private WithEvents button9 As Button
        Private WithEvents button8 As Button
        Private WithEvents button7 As Button
        Private WithEvents button6 As Button

        Private Sub InitializeComponent()
            Me.button9 = New System.Windows.Forms.Button()
            Me.button8 = New System.Windows.Forms.Button()
            Me.button7 = New System.Windows.Forms.Button()
            Me.button6 = New System.Windows.Forms.Button()
            Me.button5 = New System.Windows.Forms.Button()
            Me.button4 = New System.Windows.Forms.Button()
            Me.button3 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'button9
            '
            Me.button9.Location = New System.Drawing.Point(202, 251)
            Me.button9.Name = "button9"
            Me.button9.Size = New System.Drawing.Size(69, 67)
            Me.button9.TabIndex = 19
            Me.button9.UseVisualStyleBackColor = True
            '
            'button8
            '
            Me.button8.Location = New System.Drawing.Point(134, 251)
            Me.button8.Name = "button8"
            Me.button8.Size = New System.Drawing.Size(69, 67)
            Me.button8.TabIndex = 18
            Me.button8.UseVisualStyleBackColor = True
            '
            'button7
            '
            Me.button7.Location = New System.Drawing.Point(66, 251)
            Me.button7.Name = "button7"
            Me.button7.Size = New System.Drawing.Size(69, 67)
            Me.button7.TabIndex = 17
            Me.button7.UseVisualStyleBackColor = True
            '
            'button6
            '
            Me.button6.Location = New System.Drawing.Point(202, 185)
            Me.button6.Name = "button6"
            Me.button6.Size = New System.Drawing.Size(69, 67)
            Me.button6.TabIndex = 16
            Me.button6.UseVisualStyleBackColor = True
            '
            'button5
            '
            Me.button5.Location = New System.Drawing.Point(134, 185)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(69, 67)
            Me.button5.TabIndex = 15
            Me.button5.UseVisualStyleBackColor = True
            '
            'button4
            '
            Me.button4.Location = New System.Drawing.Point(66, 185)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(69, 67)
            Me.button4.TabIndex = 14
            Me.button4.UseVisualStyleBackColor = True
            '
            'button3
            '
            Me.button3.Location = New System.Drawing.Point(202, 119)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(69, 67)
            Me.button3.TabIndex = 13
            Me.button3.UseVisualStyleBackColor = True
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(134, 119)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(69, 67)
            Me.button2.TabIndex = 12
            Me.button2.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(66, 119)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(69, 67)
            Me.button1.TabIndex = 11
            Me.button1.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(62, 38)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(220, 56)
            Me.label1.TabIndex = 10
            Me.label1.Text = "Your Turn!"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Game
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.ClientSize = New System.Drawing.Size(337, 409)
            Me.Controls.Add(Me.button9)
            Me.Controls.Add(Me.button8)
            Me.Controls.Add(Me.button7)
            Me.Controls.Add(Me.button6)
            Me.Controls.Add(Me.button5)
            Me.Controls.Add(Me.button4)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.Name = "Game"
            Me.Text = "Game"
            Me.ResumeLayout(False)

        End Sub

        Private WithEvents button5 As Button
        Private WithEvents button4 As Button
        Private WithEvents button3 As Button
        Private WithEvents button2 As Button
        Private WithEvents button1 As Button
        Private WithEvents label1 As Label
        Private v As Boolean

        Public Sub New(v As Boolean, text As String)
            Me.v = v
            Me.Text = text
        End Sub

        Public Sub New(v As Boolean)
            Me.v = v
        End Sub

        Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click

=======
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
>>>>>>> ac7f06c067e3979da6ab3259f7fb7a4b9b9183e2
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

<<<<<<< HEAD
        Private Sub Game_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            MessageReceiver.WorkerSupportsCancellation = True
=======
        Private Sub Game_FormClosing_1(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            MessageReceiver.WorkerSupportsCancellation = False
>>>>>>> 2b4ee2a53c80225493f4e2f741a7e3a1d43c1e85
            MessageReceiver.CancelAsync()
            If server IsNot Nothing Then server.Stop()
        End Sub

    End Class
End Namespace
