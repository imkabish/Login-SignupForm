﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.signuplabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.forgetpasslabel = New System.Windows.Forms.Label()
        Me.passwordtextbox = New System.Windows.Forms.TextBox()
        Me.usernametextbox = New System.Windows.Forms.TextBox()
        Me.hideit = New System.Windows.Forms.PictureBox()
        Me.showpasslogo = New System.Windows.Forms.PictureBox()
        Me.hidepasslogo = New System.Windows.Forms.PictureBox()
        Me.passwordlogo = New System.Windows.Forms.PictureBox()
        Me.usernamelogo = New System.Windows.Forms.PictureBox()
        Me.wallpaper = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.hideit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showpasslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidepasslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernamelogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wallpaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginbtn.FlatAppearance.BorderSize = 0
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(637, 346)
        Me.loginbtn.Margin = New System.Windows.Forms.Padding(0)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(152, 32)
        Me.loginbtn.TabIndex = 56
        Me.loginbtn.TabStop = False
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'signuplabel
        '
        Me.signuplabel.AutoSize = True
        Me.signuplabel.BackColor = System.Drawing.Color.Transparent
        Me.signuplabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signuplabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signuplabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.signuplabel.Location = New System.Drawing.Point(719, 484)
        Me.signuplabel.Name = "signuplabel"
        Me.signuplabel.Size = New System.Drawing.Size(60, 18)
        Me.signuplabel.TabIndex = 55
        Me.signuplabel.Text = "Sign Up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(574, 486)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 16)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Don’t have an account?"
        '
        'forgetpasslabel
        '
        Me.forgetpasslabel.AutoSize = True
        Me.forgetpasslabel.BackColor = System.Drawing.Color.Transparent
        Me.forgetpasslabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.forgetpasslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgetpasslabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.forgetpasslabel.Location = New System.Drawing.Point(655, 395)
        Me.forgetpasslabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.forgetpasslabel.Name = "forgetpasslabel"
        Me.forgetpasslabel.Size = New System.Drawing.Size(116, 16)
        Me.forgetpasslabel.TabIndex = 53
        Me.forgetpasslabel.Text = "Forget Password?"
        '
        'passwordtextbox
        '
        Me.passwordtextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtextbox.Location = New System.Drawing.Point(619, 259)
        Me.passwordtextbox.Multiline = True
        Me.passwordtextbox.Name = "passwordtextbox"
        Me.passwordtextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtextbox.Size = New System.Drawing.Size(185, 28)
        Me.passwordtextbox.TabIndex = 52
        '
        'usernametextbox
        '
        Me.usernametextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametextbox.Location = New System.Drawing.Point(619, 176)
        Me.usernametextbox.Multiline = True
        Me.usernametextbox.Name = "usernametextbox"
        Me.usernametextbox.Size = New System.Drawing.Size(185, 28)
        Me.usernametextbox.TabIndex = 49
        '
        'hideit
        '
        Me.hideit.BackColor = System.Drawing.Color.White
        Me.hideit.Image = CType(resources.GetObject("hideit.Image"), System.Drawing.Image)
        Me.hideit.Location = New System.Drawing.Point(779, 262)
        Me.hideit.Margin = New System.Windows.Forms.Padding(2)
        Me.hideit.Name = "hideit"
        Me.hideit.Size = New System.Drawing.Size(20, 21)
        Me.hideit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hideit.TabIndex = 59
        Me.hideit.TabStop = False
        '
        'showpasslogo
        '
        Me.showpasslogo.BackColor = System.Drawing.Color.White
        Me.showpasslogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showpasslogo.Image = CType(resources.GetObject("showpasslogo.Image"), System.Drawing.Image)
        Me.showpasslogo.Location = New System.Drawing.Point(779, 262)
        Me.showpasslogo.Margin = New System.Windows.Forms.Padding(2)
        Me.showpasslogo.Name = "showpasslogo"
        Me.showpasslogo.Size = New System.Drawing.Size(20, 21)
        Me.showpasslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showpasslogo.TabIndex = 58
        Me.showpasslogo.TabStop = False
        Me.showpasslogo.Visible = False
        '
        'hidepasslogo
        '
        Me.hidepasslogo.BackColor = System.Drawing.Color.White
        Me.hidepasslogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hidepasslogo.Image = CType(resources.GetObject("hidepasslogo.Image"), System.Drawing.Image)
        Me.hidepasslogo.Location = New System.Drawing.Point(779, 262)
        Me.hidepasslogo.Margin = New System.Windows.Forms.Padding(2)
        Me.hidepasslogo.Name = "hidepasslogo"
        Me.hidepasslogo.Size = New System.Drawing.Size(20, 21)
        Me.hidepasslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidepasslogo.TabIndex = 57
        Me.hidepasslogo.TabStop = False
        Me.hidepasslogo.Visible = False
        '
        'passwordlogo
        '
        Me.passwordlogo.BackColor = System.Drawing.Color.Transparent
        Me.passwordlogo.Image = CType(resources.GetObject("passwordlogo.Image"), System.Drawing.Image)
        Me.passwordlogo.Location = New System.Drawing.Point(563, 253)
        Me.passwordlogo.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordlogo.Name = "passwordlogo"
        Me.passwordlogo.Size = New System.Drawing.Size(35, 36)
        Me.passwordlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passwordlogo.TabIndex = 51
        Me.passwordlogo.TabStop = False
        '
        'usernamelogo
        '
        Me.usernamelogo.BackColor = System.Drawing.Color.Transparent
        Me.usernamelogo.Image = CType(resources.GetObject("usernamelogo.Image"), System.Drawing.Image)
        Me.usernamelogo.Location = New System.Drawing.Point(563, 170)
        Me.usernamelogo.Margin = New System.Windows.Forms.Padding(2)
        Me.usernamelogo.Name = "usernamelogo"
        Me.usernamelogo.Size = New System.Drawing.Size(35, 36)
        Me.usernamelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usernamelogo.TabIndex = 50
        Me.usernamelogo.TabStop = False
        '
        'wallpaper
        '
        Me.wallpaper.BackColor = System.Drawing.Color.Transparent
        Me.wallpaper.Image = CType(resources.GetObject("wallpaper.Image"), System.Drawing.Image)
        Me.wallpaper.Location = New System.Drawing.Point(-9, 30)
        Me.wallpaper.Margin = New System.Windows.Forms.Padding(2)
        Me.wallpaper.Name = "wallpaper"
        Me.wallpaper.Size = New System.Drawing.Size(575, 526)
        Me.wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wallpaper.TabIndex = 48
        Me.wallpaper.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "00:00:00"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login_SignupForm.My.Resources.Resources.time
        Me.PictureBox1.Location = New System.Drawing.Point(13, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Login_SignupForm.My.Resources.Resources.LF8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(837, 587)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hideit)
        Me.Controls.Add(Me.showpasslogo)
        Me.Controls.Add(Me.hidepasslogo)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.signuplabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.forgetpasslabel)
        Me.Controls.Add(Me.passwordtextbox)
        Me.Controls.Add(Me.passwordlogo)
        Me.Controls.Add(Me.usernamelogo)
        Me.Controls.Add(Me.usernametextbox)
        Me.Controls.Add(Me.wallpaper)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.hideit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showpasslogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidepasslogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernamelogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wallpaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents signuplabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents forgetpasslabel As Label
    Friend WithEvents passwordtextbox As TextBox
    Friend WithEvents passwordlogo As PictureBox
    Friend WithEvents usernamelogo As PictureBox
    Friend WithEvents usernametextbox As TextBox
    Friend WithEvents wallpaper As PictureBox
    Friend WithEvents hidepasslogo As PictureBox
    Friend WithEvents showpasslogo As PictureBox
    Friend WithEvents hideit As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
