
Public Class decrypter


    Private Sub btn_decrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_decrypt.Click
        Dim I As Integer
        Dim CodedFile As String
        'Try
        'CodedFile = My.Computer.FileSystem.ReadAllText("C:\Users\Jash\Desktop\Stash.txt")
        'CodedFile = My.Computer.FileSystem.ReadAllText(path1)
        CodeKeyArray = My.Computer.FileSystem.ReadAllText(path1)

        'CodeKeyArray = rtb_codedkeyarray.Text

        'For I = 0 To Len(CodeKeyArray) - 1
        '    If CodeKeyArray(I) = Nothing Then
        '        rtb_codedkeyarray.Text &= ""
        '    Else
        '        rtb_codedkeyarray.Text &= CodeKeyArray(I)
        '    End If
        'Next

        CodedFile = Trim(rtb_cipher_de.Text)
        For I = 0 To Len(CodedFile) - 1
            rtb_org_de.Text &= Chr(InStr(CodeKeyArray, CodedFile(I)) - 1)
            'rtb_org_de.Text &= Chr(InStr(CodeKeyArrayTemp, CodedFile(I)) - 1)



        Next
        rtb_cipher_de.Text = ""
        'Catch
        'MsgBox("Something has gone bad, Pls contact Shivang for this problem")
        'End Try

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        flag1 = 1
        Try
            OpenFD1.ShowDialog()
            path1 = OpenFD1.FileName.ToString()
            tb_1.Text = "Your file is selected..Enjoy"
            If flag1 > 0 Then
                btn_decrypt.Enabled = True
            Else
                MsgBox("Paste the code in First TextBox")

            End If
        Catch
            MsgBox("File is not proper")
        End Try
    End Sub

    Private Sub btn_refress_de_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refress_de.Click
        rtb_cipher_de.Text = ""
        rtb_org_de.Text = ""
    End Sub
End Class