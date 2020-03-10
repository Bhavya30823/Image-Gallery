
Imports System.IO
Imports System.Drawing.Imaging

Public Class Form1
    Dim no_images As Integer = 0
    Dim a As Integer = 0
    Dim directoryName As String

    Dim files() As String
    Dim extension As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = a + 1
        If a = 4 Then
            MessageBox.Show("khatam")
            End
        End If
        directoryName = "C:\Users\ASUS\Pictures\Screenshots.txt"
        gallery = Directory.GetFiles(directoryName)
        Dim strfilename As String = gallery(a)
        Dim bhavya As Image
        bhavya = Image.FromFile(strfilename)
        SHOW.Image = bhavya


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim gallery(4) As String
        gallery = New String() {"F:\UDAIPUR\IMG_20191220_050124.jpg", "F:\UDAIPUR\IMG_20191220_050131.jpg", "F:\UDAIPUR\IMG_20191220_064200.jpg", "F:\UDAIPUR\IMG_20191220_064203.jpg"}
        If a = 0 Then
            MessageBox.Show("you are on the 1st picture")
            a = a + 1
        End If
        a = a - 1
        Dim strfilename As String = gallery(a)
        Dim bhavya As Image
        bhavya = Image.FromFile(strfilename)
        SHOW.Image = bhavya

    End Sub
End Class
