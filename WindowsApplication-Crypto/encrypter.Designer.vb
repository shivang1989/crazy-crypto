<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class encrypter
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.rtb_cipher_en = New System.Windows.Forms.RichTextBox
        Me.rtb_org_en = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_temp = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Encrypted text is down here."
        '
        'rtb_cipher_en
        '
        Me.rtb_cipher_en.Location = New System.Drawing.Point(12, 257)
        Me.rtb_cipher_en.Name = "rtb_cipher_en"
        Me.rtb_cipher_en.ReadOnly = True
        Me.rtb_cipher_en.Size = New System.Drawing.Size(451, 167)
        Me.rtb_cipher_en.TabIndex = 6
        Me.rtb_cipher_en.Text = ""
        '
        'rtb_org_en
        '
        Me.rtb_org_en.Location = New System.Drawing.Point(12, 58)
        Me.rtb_org_en.Name = "rtb_org_en"
        Me.rtb_org_en.Size = New System.Drawing.Size(451, 149)
        Me.rtb_org_en.TabIndex = 5
        Me.rtb_org_en.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Write The text here."
        '
        'btn_temp
        '
        Me.btn_temp.BackColor = System.Drawing.Color.Transparent
        Me.btn_temp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_temp.Location = New System.Drawing.Point(247, 216)
        Me.btn_temp.Name = "btn_temp"
        Me.btn_temp.Size = New System.Drawing.Size(216, 38)
        Me.btn_temp.TabIndex = 10
        Me.btn_temp.Text = "Encrypt"
        Me.btn_temp.UseVisualStyleBackColor = False
        '
        'encrypter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.btn_temp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtb_cipher_en)
        Me.Controls.Add(Me.rtb_org_en)
        Me.Name = "encrypter"
        Me.Text = "encrypter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rtb_cipher_en As System.Windows.Forms.RichTextBox
    Friend WithEvents rtb_org_en As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_temp As System.Windows.Forms.Button
End Class
