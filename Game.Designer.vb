Namespace Tic_Tac_Toe_Game
    Partial Class Game
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing


        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub


#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            label1 = New Windows.Forms.Label()
            button1 = New Windows.Forms.Button()
            button2 = New Windows.Forms.Button()
            button3 = New Windows.Forms.Button()
            button4 = New Windows.Forms.Button()
            button5 = New Windows.Forms.Button()
            button6 = New Windows.Forms.Button()
            button7 = New Windows.Forms.Button()
            button8 = New Windows.Forms.Button()
            button9 = New Windows.Forms.Button()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
            label1.Location = New Drawing.Point(12, 9)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(202, 45)
            label1.TabIndex = 0
            label1.Text = "Your Turn!"
            label1.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' button1
            ' 
            button1.Location = New Drawing.Point(14, 57)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(62, 60)
            button1.TabIndex = 1
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' button2
            ' 
            button2.Location = New Drawing.Point(82, 57)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(62, 60)
            button2.TabIndex = 2
            button2.UseVisualStyleBackColor = True
            AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
            ' 
            ' button3
            ' 
            button3.Location = New Drawing.Point(150, 57)
            button3.Name = "button3"
            button3.Size = New Drawing.Size(62, 60)
            button3.TabIndex = 3
            button3.UseVisualStyleBackColor = True
            AddHandler button3.Click, New EventHandler(AddressOf button3_Click)
            ' 
            ' button4
            ' 
            button4.Location = New Drawing.Point(14, 123)
            button4.Name = "button4"
            button4.Size = New Drawing.Size(62, 60)
            button4.TabIndex = 4
            button4.UseVisualStyleBackColor = True
            AddHandler button4.Click, New EventHandler(AddressOf button4_Click)
            ' 
            ' button5
            ' 
            button5.Location = New Drawing.Point(82, 123)
            button5.Name = "button5"
            button5.Size = New Drawing.Size(62, 60)
            button5.TabIndex = 5
            button5.UseVisualStyleBackColor = True
            AddHandler button5.Click, New EventHandler(AddressOf button5_Click)
            ' 
            ' button6
            ' 
            button6.Location = New Drawing.Point(150, 123)
            button6.Name = "button6"
            button6.Size = New Drawing.Size(62, 60)
            button6.TabIndex = 6
            button6.UseVisualStyleBackColor = True
            AddHandler button6.Click, New EventHandler(AddressOf button6_Click)
            ' 
            ' button7
            ' 
            button7.Location = New Drawing.Point(14, 189)
            button7.Name = "button7"
            button7.Size = New Drawing.Size(62, 60)
            button7.TabIndex = 7
            button7.UseVisualStyleBackColor = True
            AddHandler button7.Click, New EventHandler(AddressOf button7_Click)
            ' 
            ' button8
            ' 
            button8.Location = New Drawing.Point(82, 189)
            button8.Name = "button8"
            button8.Size = New Drawing.Size(62, 60)
            button8.TabIndex = 8
            button8.UseVisualStyleBackColor = True
            AddHandler button8.Click, New EventHandler(AddressOf button8_Click)
            ' 
            ' button9
            ' 
            button9.Location = New Drawing.Point(150, 189)
            button9.Name = "button9"
            button9.Size = New Drawing.Size(62, 60)
            button9.TabIndex = 9
            button9.UseVisualStyleBackColor = True
            AddHandler button9.Click, New EventHandler(AddressOf button9_Click)
            ' 
            ' Game
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(226, 266)
            Controls.Add(button9)
            Controls.Add(button8)
            Controls.Add(button7)
            Controls.Add(button6)
            Controls.Add(button5)
            Controls.Add(button4)
            Controls.Add(button3)
            Controls.Add(button2)
            Controls.Add(button1)
            Controls.Add(label1)
            FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            MaximizeBox = False
            MinimizeBox = False
            Name = "Game"
            Text = "Game"
            AddHandler FormClosing, New Windows.Forms.FormClosingEventHandler(AddressOf Game_FormClosing)
            ResumeLayout(False)
        End Sub


#End Region

        Private label1 As Windows.Forms.Label
        Private button1 As Windows.Forms.Button
        Private button2 As Windows.Forms.Button
        Private button3 As Windows.Forms.Button
        Private button4 As Windows.Forms.Button
        Private button5 As Windows.Forms.Button
        Private button6 As Windows.Forms.Button
        Private button7 As Windows.Forms.Button
        Private button8 As Windows.Forms.Button
        Private button9 As Windows.Forms.Button
    End Class
End Namespace
