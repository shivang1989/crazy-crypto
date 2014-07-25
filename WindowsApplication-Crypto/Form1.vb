Public Class Form1

    Private Sub btn_moveon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_moveon.Click
        If rb_encrypt.Checked = True Then
            encrypter.Show()
        End If

        If rb_decrypt.Checked = True Then
            decrypter.Show()
        End If

        If (rb_decrypt.Checked = False And rb_encrypt.Checked = False) Then
            MsgBox("Select any one option")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tb_id.Text = "crypto" And tb_pwd.Text = "jash" Then
            tb_id.Visible = False
            tb_pwd.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Button1.Visible = False

            Label1.Visible = True
            rb_decrypt.Visible = True
            rb_encrypt.Visible = True
            btn_moveon.Visible = True

        Else
            MsgBox("Acess denied")
            tb_id.Text = ""
            tb_pwd.Text = ""
        End If
    End Sub

   
End Class
