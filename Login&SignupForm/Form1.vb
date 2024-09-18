Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializePlaceholder()
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub InitializePlaceholder()
        usernametextbox.Text = "Enter username"
        passwordtextbox.Text = "Enter password"
        passwordtextbox.PasswordChar = ""
        usernametextbox.ForeColor = Color.Gray
        passwordtextbox.ForeColor = Color.Gray
        Me.ActiveControl = wallpaper
    End Sub
    Private Sub usernametextbox_Enter(sender As Object, e As EventArgs) Handles usernametextbox.Enter
        If usernametextbox.Text = "Enter username" Then
            usernametextbox.Text = ""
            usernametextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub usernametextbox_Leave(sender As Object, e As EventArgs) Handles usernametextbox.Leave
        If usernametextbox.Text = String.Empty Then
            usernametextbox.Text = "Enter username"
            usernametextbox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub passwordtextbox_Enter(sender As Object, e As EventArgs) Handles passwordtextbox.Enter
        If passwordtextbox.Text = "Enter password" Then
            passwordtextbox.Text = ""
            passwordtextbox.PasswordChar = "*"
            passwordtextbox.ForeColor = Color.Black
            showpasslogo.Visible = True
        End If
        If passwordtextbox.PasswordChar = "" Then
            showpasslogo.Visible = False
            hidepasslogo.Visible = True
        End If
        hideit.Visible = False
    End Sub

    Private Sub passwordtextbox_Leave(sender As Object, e As EventArgs) Handles passwordtextbox.Leave
        If passwordtextbox.Text = String.Empty Then
            passwordtextbox.Text = "Enter password"
            passwordtextbox.PasswordChar = ""
            passwordtextbox.ForeColor = Color.Gray
        End If
        If passwordtextbox.Text = "Enter password" Then
            hideit.Visible = True
        End If
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub wallpaper_Click(sender As Object, e As EventArgs) Handles wallpaper.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub showpasslogo_Click(sender As Object, e As EventArgs) Handles showpasslogo.Click
        showpasslogo.Visible = False
        hidepasslogo.Visible = True
        passwordtextbox.PasswordChar = ""
    End Sub

    Private Sub hidepasslogo_Click(sender As Object, e As EventArgs) Handles hidepasslogo.Click
        showpasslogo.Visible = True
        hidepasslogo.Visible = False
        passwordtextbox.PasswordChar = "*"
    End Sub

    Private Sub showpasslogo_MouseHover(sender As Object, e As EventArgs) Handles showpasslogo.MouseHover
        showpasslogo.Size = New Size(22, 23)
    End Sub

    Private Sub showpasslogo_MouseLeave(sender As Object, e As EventArgs) Handles showpasslogo.MouseLeave
        showpasslogo.Size = New Size(20, 21)
    End Sub

    Private Sub hidepasslogo_MouseHover(sender As Object, e As EventArgs) Handles hidepasslogo.MouseHover
        hidepasslogo.Size = New Size(22, 23)
    End Sub

    Private Sub hidepasslogo_MouseLeave(sender As Object, e As EventArgs) Handles hidepasslogo.MouseLeave
        hidepasslogo.Size = New Size(20, 21)
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim connectionstring As String = "Data Source=192.168.1.69;Initial Catalog=LOGIN;User ID=SA;Password=MyStrongPass123;"
        Dim eusername As String = usernametextbox.Text
        Dim epassword As String = passwordtextbox.Text
        Try
            Using connection As New SqlConnection(connectionstring)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", eusername)
                    command.Parameters.AddWithValue("@password", epassword)
                    Dim count As Integer = CInt(command.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Login successful!" & vbCrLf & "Username : " & eusername)
                    Else
                        MessageBox.Show("Invalid username or password." & vbCrLf & "               Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub forgetpasslabel_MouseHover(sender As Object, e As EventArgs) Handles forgetpasslabel.MouseHover
        forgetpasslabel.ForeColor = Color.FromArgb(16, 40, 161)
    End Sub

    Private Sub forgetpasslabel_MouseLeave(sender As Object, e As EventArgs) Handles forgetpasslabel.MouseLeave
        forgetpasslabel.ForeColor = Color.FromArgb(69, 128, 230)
    End Sub

    Private Sub signuplabel_MouseHover(sender As Object, e As EventArgs) Handles signuplabel.MouseHover
        signuplabel.ForeColor = Color.FromArgb(16, 40, 161)
    End Sub

    Private Sub signuplabel_MouseLeave(sender As Object, e As EventArgs) Handles signuplabel.MouseLeave
        signuplabel.ForeColor = Color.FromArgb(69, 128, 230)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

End Class
