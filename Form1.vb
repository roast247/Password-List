Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms

Public Class Form1
    Private draggable As Boolean
    Private mouseY As Integer
    Private mouseX As Integer
    Private i As Integer
    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Close()
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingPic_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingPic_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingPic_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseUp
        draggable = False
    End Sub

    Private Sub Startbttn_Click(sender As Object, e As EventArgs) Handles Startbttn.Click
        Me.Timer1.Start()
    End Sub

    Private Sub Stopbttn_Click(sender As Object, e As EventArgs) Handles Stopbttn.Click
        Me.Timer1.Stop()
    End Sub

    Private Sub Savebttn_Click(sender As Object, e As EventArgs) Handles Savebttn.Click
        Dim dialog As New SaveFileDialog With {
                .Filter = "*.txt|*.txt",
                .FileName = "GeneratedPasswords.txt"
            }
        If (dialog.ShowDialog = DialogResult.OK) Then
            File.WriteAllText(dialog.FileName, Me.TextBox2.Text)
            MessageBox.Show("Done")
        End If
    End Sub
    Public Function Generate(ByVal lenght As Integer) As String
        Dim str As String = ""
        Dim str2 As String = "azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN0123456789!@#$%^&*()-_"
        Dim random As New Random
        Dim num As Integer = lenght
        Dim i As Integer = 0
        Do While (i <= num)
            str = (str & Conversions.ToString(str2.Chars(random.Next(0, (str2.Length - 1)))))
            i += 1
        Loop
        Return str
    End Function
    Private Sub start()
        Dim ch As Char
        For Each ch In Me.Generate(0)
            Me.TextBox1.Text = Convert.ToString(Operators.AddObject(Me.TextBox1.Text, (Operators.ConcatenateObject((Me.TextBox2.Text & Me.Generate(Convert.ToInt32(Me.NumericUpDown1.Value))), ChrW(13) & ChrW(10)))))
            Me.i += 1
            Me.Label2.Text = Me.i.ToString
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim kk As New Thread(New ThreadStart(AddressOf Me.start))
        kk.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
End Class