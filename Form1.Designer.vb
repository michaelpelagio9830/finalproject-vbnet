Namespace Tic_Tac_Toe_Game
    Partial Class Form1
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
            groupBox1 = New Windows.Forms.GroupBox()
            label1 = New Windows.Forms.Label()
            textBox1 = New Windows.Forms.TextBox()
            button1 = New Windows.Forms.Button()
            button2 = New Windows.Forms.Button()
            groupBox1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(button1)
            groupBox1.Controls.Add(textBox1)
            groupBox1.Controls.Add(label1)
            groupBox1.Location = New Drawing.Point(16, 17)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(335, 80)
            groupBox1.TabIndex = 0
            groupBox1.TabStop = False
            groupBox1.Text = "Connect To Game"
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(20, 38)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(24, 17)
            label1.TabIndex = 0
            label1.Text = "IP:"
            ' 
            ' textBox1
            ' 
            textBox1.Location = New Drawing.Point(50, 35)
            textBox1.Name = "textBox1"
            textBox1.Size = New Drawing.Size(184, 22)
            textBox1.TabIndex = 1
            ' 
            ' button1
            ' 
            button1.Location = New Drawing.Point(240, 35)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(75, 23)
            button1.TabIndex = 2
            button1.Text = "Connect"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf Me.button1_Click)
            ' 
            ' button2
            ' 
            button2.Location = New Drawing.Point(16, 103)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(335, 38)
            button2.TabIndex = 3
            button2.Text = "Host Game"
            button2.UseVisualStyleBackColor = True
            AddHandler button2.Click, New EventHandler(AddressOf Me.button2_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New Drawing.Size(366, 158)
            Me.Controls.Add(button2)
            Me.Controls.Add(groupBox1)
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.Text = "Tic Tac Toe Game"
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            Me.ResumeLayout(False)
        End Sub


#End Region

        Private groupBox1 As Windows.Forms.GroupBox
        Private button1 As Windows.Forms.Button
        Private textBox1 As Windows.Forms.TextBox
        Private label1 As Windows.Forms.Label
        Private button2 As Windows.Forms.Button
    End Class
End Namespace
