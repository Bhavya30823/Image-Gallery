
Imports System.IO
Imports System.Drawing.Imaging

Public Class Form1
    Dim no_images As Integer = 0

    Dim directoryName As String
    Dim a As Integer = 0S
    Dim files() As String
    Dim extension As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loading_button.Click
        Dim gallery() As String
        directoryName = "C:\Users\ASUS\Pictures\Screenshots"
        gallery = Directory.GetFiles(directoryName)
        For Each file As String In gallery

            extension = Path.GetExtension(file)

            If (extension = ".jpg" Or extension = ".jpeg" Or extension = ".png" Or extension = ".gif" Or extension = ".ico") Then
                ReDim Preserve files(no_images)
                files(no_images) = file
                no_images += 1
            End If
        Next
        If (no_images = 0) Then
            MessageBox.Show("There are no image files in this directory")
            Exit Sub
        End If
        Dim strfilename As String = files(0)
        Dim bhavya As Image
        bhavya = Image.FromFile(strfilename)
        SHOW.Image = bhavya

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles next_image.Click
        a = a + 1
        If a = no_images Then
            MessageBox.Show("khatam")
            a = a - 1

        End If

        Dim strfilename As String = files(a)
        Dim bhavya As Image
        bhavya = Image.FromFile(strfilename)
        SHOW.Image = bhavya


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles previous_button.Click

        If a = 0 Then
            MessageBox.Show("you are on the 1st picture")
            a = a + 1
        End If
        a = a - 1
        Dim strfilename As String = files(a)
        Dim bhavya As Image
        bhavya = Image.FromFile(strfilename)
        SHOW.Image = bhavya

    End Sub
End Class
