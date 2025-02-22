Imports System.Net.Mail

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mail_turu.Items.Add("Hotmail")
        mail_turu.Items.Add("Gmail")
        sifre.PasswordChar = "*"
        CheckedListBox1.Items.Add("elifyalvac0000@hotmail.com")
        CheckedListBox1.Items.Add("bayanx07@gmail.com")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckedListBox1.Items.Add(Interaction.InputBox("Yönetim kurulu üyesinin e-mail adresini giriniz."))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim e_mail As New MailMessage()
        Try
            e_mail.From = New MailAddress(gonderici_maili.Text)
            Dim i As Byte
            For i = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemChecked(i) = True Then
                    e_mail.To.Add(CheckedListBox1.Items(i))
                End If
            Next
            e_mail.Subject = konu.Text
            e_mail.Body = govde_metni.Text
            e_mail.Attachments.Add(New Attachment("C:\Users\elify\OneDrive\Masaüstü\maliyet.xlsx"))
            If mail_turu.SelectedIndex = 0 Then
                Dim Smtp As New SmtpClient("smtp.live.com")
                Smtp.EnableSsl = True
                Smtp.Port = 587
                Smtp.Credentials = New Net.NetworkCredential(gonderici_maili.Text, sifre.Text)
                Smtp.Send(e_mail)
            Else
                Dim Smtp As New SmtpClient("smtp.gmail.com")
                Smtp.EnableSsl = False
                Smtp.Port = 587
                Smtp.Credentials = New Net.NetworkCredential(gonderici_maili.Text, sifre.Text)
                Smtp.Send(e_mail)
            End If
            MsgBox("Mesajlarınız İletildi")
        Catch ex As Exception
            MsgBox("HATA. Alanların boş bırakmayınız ve doğru doldurunuz.")
        End Try
    End Sub
End Class