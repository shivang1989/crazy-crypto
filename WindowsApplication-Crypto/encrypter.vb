Public Class encrypter
    Dim len_str As Integer
    Dim ch As Char

    Private Function Stash(ByVal InChar As Char) As Char
        If CodeKeyArray(Asc(InChar)) = Nothing Then
            ' MsgBox("Inside stash()")
            Dim StashChar As Char
            Randomize()
            Do
                StashChar = Chr(CInt(255 * Rnd()))
            Loop Until InStr(CStr(CodeKeyArray), StashChar) = 0
            CodeKeyArray(Asc(InChar)) = StashChar
            Return StashChar
        Else
            Return CodeKeyArray(Asc(InChar))
        End If
    End Function



    Private Sub btn_temp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_temp.Click


        Dim str As String = rtb_org_en.Text

        Dim chArr() As Char = str.ToCharArray

        For i = 0 To str.Length - 1
            ch = chArr(i)
            rtb_cipher_en.Text &= Stash(ch)
        Next

        My.Computer.FileSystem.WriteAllText("D:\cipher.txt", rtb_cipher_en.Text, False)
        My.Computer.FileSystem.WriteAllText("D:\gps.txt", CodeKeyArray, False)

        





    End Sub


    
End Class