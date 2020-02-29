
Public Class Form1
    Dim a As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim gallery(4) As String
        gallery = New String() {"F:\UDAIPUR\IMG_20191220_050124.jpg", "F:\UDAIPUR\IMG_20191220_050131.jpg", "F:\UDAIPUR\IMG_20191220_064200.jpg", "F:\UDAIPUR\IMG_20191220_064203.jpg"}
        Dim strfilename As String = gallery(0)
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
        Dim gallery(4) As String
        gallery = New String() {"F:\UDAIPUR\IMG_20191220_050124.jpg", "F:\UDAIPUR\IMG_20191220_050131.jpg", "F:\UDAIPUR\IMG_20191220_064200.jpg", "F:\UDAIPUR\IMG_20191220_064203.jpg"}
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
