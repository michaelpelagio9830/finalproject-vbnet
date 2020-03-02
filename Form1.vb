Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace TicTac
    Partial Public Class Form1
        Inherits Form

        Public Sub Form1()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)

            Dim newGame As Game = New Game(False, textBox1.Text)
            Visible = False
            If Not newGame.IsDisposed Then newGame.ShowDialog()
            Visible = True

        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)

            Dim newGame As Game = New Game(True)
            Visible = False
            If Not newGame.IsDisposed Then newGame.ShowDialog()
            Visible = True

        End Sub

        Private WithEvents textBox1 As TextBox
        Private WithEvents groupBox1 As GroupBox
        Private WithEvents button1 As Button
        Private WithEvents label1 As Label
        Private WithEvents button2 As Button

        Private Sub InitializeComponent()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.button2 = New System.Windows.Forms.Button()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(47, 43)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(288, 22)
            Me.textBox1.TabIndex = 1
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.button1)
            Me.groupBox1.Controls.Add(Me.textBox1)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(57, 70)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(335, 112)
            Me.groupBox1.TabIndex = 4
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Connect To Game"
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(128, 71)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Connect"
            Me.button1.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(14, 43)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(27, 17)
            Me.label1.TabIndex = 0
            Me.label1.Text = "IP:"
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(57, 188)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(335, 38)
            Me.button2.TabIndex = 5
            Me.button2.Text = "Host Game"
            Me.button2.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.ClientSize = New System.Drawing.Size(460, 293)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.button2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click

        End Sub
    End Class
End Namespace
