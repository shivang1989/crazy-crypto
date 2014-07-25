<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class decrypter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(decrypter))
        Me.btn_decrypt = New System.Windows.Forms.Button
        Me.rtb_org_de = New System.Windows.Forms.RichTextBox
        Me.rtb_cipher_de = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.tb_1 = New System.Windows.Forms.TextBox
        Me.OpenFD1 = New System.Windows.Forms.OpenFileDialog
        Me.btn_refress_de = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_decrypt
        '
        Me.btn_decrypt.Enabled = False
        Me.btn_decrypt.Location = New System.Drawing.Point(211, 191)
        Me.btn_decrypt.Name = "btn_decrypt"
        Me.btn_decrypt.Size = New System.Drawing.Size(98, 36)
        Me.btn_decrypt.TabIndex = 11
        Me.btn_decrypt.Text = "Decrypt"
        Me.btn_decrypt.UseVisualStyleBackColor = True
        '
        'rtb_org_de
        '
        Me.rtb_org_de.Enabled = False
        Me.rtb_org_de.Location = New System.Drawing.Point(28, 243)
        Me.rtb_org_de.Name = "rtb_org_de"
        Me.rtb_org_de.Size = New System.Drawing.Size(333, 153)
        Me.rtb_org_de.TabIndex = 10
        Me.rtb_org_de.Text = ""
        '
        'rtb_cipher_de
        '
        Me.rtb_cipher_de.Location = New System.Drawing.Point(28, 31)
        Me.rtb_cipher_de.Name = "rtb_cipher_de"
        Me.rtb_cipher_de.Size = New System.Drawing.Size(618, 149)
        Me.rtb_cipher_de.TabIndex = 9
        Me.rtb_cipher_de.Text = ""
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(447, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 129)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "1:-"
        '
        'tb_1
        '
        Me.tb_1.Enabled = False
        Me.tb_1.Location = New System.Drawing.Point(447, 349)
        Me.tb_1.Name = "tb_1"
        Me.tb_1.Size = New System.Drawing.Size(153, 20)
        Me.tb_1.TabIndex = 16
        '
        'OpenFD1
        '
        Me.OpenFD1.FileName = "OpenFileDialog1"
        '
        'btn_refress_de
        '
        Me.btn_refress_de.Location = New System.Drawing.Point(42, 191)
        Me.btn_refress_de.Name = "btn_refress_de"
        Me.btn_refress_de.Size = New System.Drawing.Size(98, 36)
        Me.btn_refress_de.TabIndex = 17
        Me.btn_refress_de.Text = "Refress"
        Me.btn_refress_de.UseVisualStyleBackColor = True
        '
        'decrypter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 411)
        Me.Controls.Add(Me.btn_refress_de)
        Me.Controls.Add(Me.tb_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_decrypt)
        Me.Controls.Add(Me.rtb_org_de)
        Me.Controls.Add(Me.rtb_cipher_de)
        Me.Name = "decrypter"
        Me.Text = "decrypter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_decrypt As System.Windows.Forms.Button
    Friend WithEvents rtb_org_de As System.Windows.Forms.RichTextBox
    Friend WithEvents rtb_cipher_de As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFD1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_refress_de As System.Windows.Forms.Button
End Class
