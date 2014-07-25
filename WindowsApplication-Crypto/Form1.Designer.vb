<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.rb_decrypt = New System.Windows.Forms.RadioButton
        Me.rb_encrypt = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_moveon = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.tb_id = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_pwd = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 44)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "$-Crypto-$"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rb_decrypt
        '
        Me.rb_decrypt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rb_decrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rb_decrypt.Location = New System.Drawing.Point(34, 135)
        Me.rb_decrypt.Name = "rb_decrypt"
        Me.rb_decrypt.Size = New System.Drawing.Size(183, 19)
        Me.rb_decrypt.TabIndex = 8
        Me.rb_decrypt.TabStop = True
        Me.rb_decrypt.Text = "Decrypt Text"
        Me.rb_decrypt.UseVisualStyleBackColor = False
        Me.rb_decrypt.Visible = False
        '
        'rb_encrypt
        '
        Me.rb_encrypt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rb_encrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rb_encrypt.Location = New System.Drawing.Point(33, 103)
        Me.rb_encrypt.Name = "rb_encrypt"
        Me.rb_encrypt.Size = New System.Drawing.Size(182, 19)
        Me.rb_encrypt.TabIndex = 7
        Me.rb_encrypt.TabStop = True
        Me.rb_encrypt.Text = "Encrypt Text"
        Me.rb_encrypt.UseVisualStyleBackColor = False
        Me.rb_encrypt.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(43, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select Any One From Below"
        Me.Label1.Visible = False
        '
        'btn_moveon
        '
        Me.btn_moveon.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_moveon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_moveon.Location = New System.Drawing.Point(39, 191)
        Me.btn_moveon.Name = "btn_moveon"
        Me.btn_moveon.Size = New System.Drawing.Size(165, 47)
        Me.btn_moveon.TabIndex = 9
        Me.btn_moveon.Text = "Move On"
        Me.btn_moveon.UseVisualStyleBackColor = False
        Me.btn_moveon.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "O.K"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_id
        '
        Me.tb_id.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_id.Location = New System.Drawing.Point(103, 111)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(100, 22)
        Me.tb_id.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(64, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_pwd
        '
        Me.tb_pwd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tb_pwd.Location = New System.Drawing.Point(103, 164)
        Me.tb_pwd.Name = "tb_pwd"
        Me.tb_pwd.Size = New System.Drawing.Size(100, 22)
        Me.tb_pwd.TabIndex = 2
        Me.tb_pwd.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(51, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "PWD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(280, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 256)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Crypto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 44)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "$-Crypto-$"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(0, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 212)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Crypto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(305, 300)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_pwd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rb_decrypt)
        Me.Controls.Add(Me.rb_encrypt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_moveon)
        Me.Name = "Form1"
        Me.Text = "Crypto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rb_decrypt As System.Windows.Forms.RadioButton
    Friend WithEvents rb_encrypt As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_moveon As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tb_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_pwd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
