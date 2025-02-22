<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.govde_metni = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mail_turu = New System.Windows.Forms.ComboBox()
        Me.sifre = New System.Windows.Forms.TextBox()
        Me.konu = New System.Windows.Forms.TextBox()
        Me.gonderici_maili = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(79, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 29)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Gövde Metni:"
        '
        'govde_metni
        '
        Me.govde_metni.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.govde_metni.Location = New System.Drawing.Point(273, 312)
        Me.govde_metni.Name = "govde_metni"
        Me.govde_metni.Size = New System.Drawing.Size(381, 100)
        Me.govde_metni.TabIndex = 24
        Me.govde_metni.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 29)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Mail türü:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 29)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Şifre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 29)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Konu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 29)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Alıcı mailleri:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Gönderici maili:"
        '
        'mail_turu
        '
        Me.mail_turu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mail_turu.FormattingEnabled = True
        Me.mail_turu.Location = New System.Drawing.Point(273, 268)
        Me.mail_turu.Name = "mail_turu"
        Me.mail_turu.Size = New System.Drawing.Size(381, 37)
        Me.mail_turu.TabIndex = 18
        '
        'sifre
        '
        Me.sifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sifre.Location = New System.Drawing.Point(273, 228)
        Me.sifre.Name = "sifre"
        Me.sifre.Size = New System.Drawing.Size(381, 34)
        Me.sifre.TabIndex = 17
        '
        'konu
        '
        Me.konu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.konu.Location = New System.Drawing.Point(273, 190)
        Me.konu.Name = "konu"
        Me.konu.Size = New System.Drawing.Size(381, 34)
        Me.konu.TabIndex = 16
        '
        'gonderici_maili
        '
        Me.gonderici_maili.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gonderici_maili.Location = New System.Drawing.Point(273, 36)
        Me.gonderici_maili.Name = "gonderici_maili"
        Me.gonderici_maili.Size = New System.Drawing.Size(381, 34)
        Me.gonderici_maili.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(381, 65)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "GÖNDER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(273, 76)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(303, 106)
        Me.CheckedListBox1.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(582, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 106)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Yönetici maili ekle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 561)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.govde_metni)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mail_turu)
        Me.Controls.Add(Me.sifre)
        Me.Controls.Add(Me.konu)
        Me.Controls.Add(Me.gonderici_maili)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents govde_metni As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mail_turu As ComboBox
    Friend WithEvents sifre As TextBox
    Friend WithEvents konu As TextBox
    Friend WithEvents gonderici_maili As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button2 As Button
End Class
