Imports hesap
Imports System.Data.OleDb '2
Imports Microsoft.Office.Interop '3

Public Class Form1
    Function textbox_bos_kontrolu()
        Dim kontrol As Integer = 0
        For Each item As Control In Me.Controls
            If TypeOf item Is TextBox Then
                If item.Text = "" Then
                    kontrol = 1
                End If
            End If
        Next
        Return kontrol
    End Function

    Private Sub Dll_Uygula()
        Dim Dll As New hesap.Hesapla
        Dim hammadde_maliyeti As Single = Dll.UrunHammaddeMaliyeti(CInt(TextBox2.Text), Val(TextBox3.Text), CInt(TextBox4.Text), Val(TextBox5.Text))
        Dim makine_maliyeti As Single = Dll.UrunMakineMaliyeti(Val(TextBox7.Text), CInt(TextBox8.Text), Val(TextBox9.Text), CInt(TextBox10.Text), Val(TextBox11.Text))
        Dim iscilik_maaliyeti As Single = Dll.UrunİscilikMaliyeti(Val(TextBox13.Text), CInt(TextBox14.Text), Val(TextBox15.Text), CInt(TextBox16.Text))
        Dim yonetim_maliyeti As Single = Dll.UrunYonetimMaliyeti(Val(TextBox18.Text), CInt(TextBox19.Text))
        Dim toplam_maliyet As Single = Dll.UrunToplamMaliyeti()

        TextBox6.Text = hammadde_maliyeti.ToString()
        TextBox12.Text = makine_maliyeti.ToString()
        TextBox17.Text = iscilik_maaliyeti.ToString()
        TextBox20.Text = yonetim_maliyeti.ToString()
        TextBox21.Text = toplam_maliyet.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If textbox_bos_kontrolu() = 0 Then
            Dll_Uygula()
        Else
            MsgBox("Alanları boş bırakmayınız.")
        End If
    End Sub

    Private Sub temizle()
        Dim sil As Control
        For Each sil In Me.Controls
            If TypeName(sil) = "TextBox" Then
                sil.Text = ""
            End If
        Next sil
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        temizle()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox19.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox20.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    Private Sub TextBox21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox21.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And e.KeyChar <> "."
    End Sub

    '2///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Dim baglanti As New OleDbConnection("Provider=microsoft.jet.oledb.4.0;Data Source=" + Application.StartupPath + "/MaliyetHesaplama.mdb")
    Dim cmd As New OleDbCommand

    Private Sub listele()
        Dim adapter As New OleDbDataAdapter("Select * From maliyet", baglanti)
        Dim tablo As New DataTable()
        adapter.Fill(tablo)
        BindingSource1.DataSource = tablo
        DataGridView1.DataSource = BindingSource1
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        TextBox7.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        TextBox8.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        TextBox9.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        TextBox10.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        TextBox11.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        TextBox12.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        TextBox13.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
        TextBox14.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
        TextBox15.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString()
        TextBox16.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString()
        TextBox17.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString()
        TextBox18.Text = DataGridView1.CurrentRow.Cells(17).Value.ToString()
        TextBox19.Text = DataGridView1.CurrentRow.Cells(18).Value.ToString()
        TextBox20.Text = DataGridView1.CurrentRow.Cells(19).Value.ToString()
        TextBox21.Text = DataGridView1.CurrentRow.Cells(20).Value.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()

        TextBox6.Enabled = False
        TextBox12.Enabled = False
        TextBox17.Enabled = False
        TextBox20.Enabled = False
        TextBox21.Enabled = False

        TextBox6.Text = "0.00"
        TextBox12.Text = "0.00"
        TextBox17.Text = "0.00"
        TextBox20.Text = "0.00"
        TextBox21.Text = "0.00"
    End Sub

    Private Function kayit_id_kontrol(ByVal id As String)
        baglanti.Open()
        Dim sorgu As New OleDbCommand("Select count(*) from maliyet where kayit_id=" + id + "", baglanti)
        Dim adet As Integer = sorgu.ExecuteScalar()
        baglanti.Close()
        Return adet
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If textbox_bos_kontrolu() = 0 Then
            If MessageBox.Show("Insert işlemine devam edilsin mi?", "UYARI", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If kayit_id_kontrol(TextBox1.Text) = 0 Then
                    baglanti.Open()
                    'cmd = New OleDbCommand("insert into maliyet (kayit_id,birinci_hammaddenin_grami,birinci_hammaddenin_kilogram_fiyati,ikinci_hammaddenin_grami,ikinci_hammaddenin_kilogram_fiyati,URUNUN_HAMMADDE_MALIYETI,makine_saatlik_maaliyeti,bir_urunun_islenme_suresi,aylik_bakim_maliyeti,aylik_ortalama_calisma_saati,makinenin_saatlik_harcadigi_enerji_maaliyeti,URUNUN_MAKINE_MALIYETI,makinede_calisan_personelin_bir_urun_icin_harcadigi_sure,giydirilmis_saat_ucreti_makine,montajda_calisan_personelin_bir_urun_icin_harcadigi_sure,giydirilmis_saat_ucreti_montaj,URUNUN_ISCILIK_MALIYETI,direk_olarak_çalışmayanlarin_giydirilmiş_toplam_ucreti,aylik_ortalama_uretim_adedi,URUN_YONETIM_MALIYETI,URUN_TOPLAM_MALIYETI) values (" & CInt(TextBox1.Text) & "," & CInt(TextBox2.Text) & "," & Val(TextBox3.Text) & "," & CInt(TextBox4.Text) & "," & Val(TextBox5.Text) & "," & Val(TextBox6.Text) & "," & Val(TextBox7.Text) & "," & CInt(TextBox8.Text) & "," & Val(TextBox9.Text) & "," & CInt(TextBox10.Text) & "," & Val(TextBox11.Text) & "," & Val(TextBox12.Text) & "," & Val(TextBox13.Text) & "," & CInt(TextBox14.Text) & "," & Val(TextBox15.Text) & "," & CInt(TextBox16.Text) & "," & Val(TextBox17.Text) & "," & Val(TextBox18.Text) & "," & CInt(TextBox19.Text) & "," & Val(TextBox20.Text) & "," & Val(TextBox1.Text) & ")", baglanti)
                    cmd = New OleDbCommand("insert into maliyet (kayit_id,birinci_hammaddenin_grami,birinci_hammaddenin_kilogram_fiyati,ikinci_hammaddenin_grami,ikinci_hammaddenin_kilogram_fiyati,URUNUN_HAMMADDE_MALIYETI,makine_saatlik_maaliyeti,bir_urunun_islenme_suresi,aylik_bakim_maliyeti,aylik_ortalama_calisma_saati,makinenin_saatlik_harcadigi_enerji_maaliyeti,URUNUN_MAKINE_MALIYETI,makinede_calisan_personelin_bir_urun_icin_harcadigi_sure,giydirilmis_saat_ucreti_makine,montajda_calisan_personelin_bir_urun_icin_harcadigi_sure,giydirilmis_saat_ucreti_montaj,URUNUN_ISCILIK_MALIYETI,direk_olarak_çalışmayanlarin_giydirilmiş_toplam_ucreti,aylik_ortalama_uretim_adedi,URUN_YONETIM_MALIYETI,URUN_TOPLAM_MALIYETI) values (" & Val(TextBox1.Text) & ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + TextBox16.Text + "','" + TextBox17.Text + "','" + TextBox18.Text + "','" + TextBox19.Text + "','" + TextBox20.Text + "','" + TextBox21.Text + "')", baglanti)
                    cmd.ExecuteNonQuery()
                    baglanti.Close()
                    listele()
                    temizle()
                Else
                    MessageBox.Show("Bu kayit id numarası ile daha önce kayıt yapılmış.")
                End If
            Else
                    MessageBox.Show("Insert işlemi iptal edildi.")
            End If
        Else
            MsgBox("Alanları boş bırakmayınız.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If textbox_bos_kontrolu() = 0 Then
            If MessageBox.Show("Delete işlemine devam edilsin mi?", "UYARI", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                baglanti.Open()
                cmd = New OleDbCommand("delete from maliyet where kayit_id=" & Val(TextBox1.Text) & "", baglanti)
                cmd.ExecuteNonQuery()
                baglanti.Close()
                listele()
                temizle()
            Else
                MessageBox.Show("Delete işlemi iptal edildi.")
            End If
        Else
            MsgBox("Alanları boş bırakmayınız.")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If textbox_bos_kontrolu() = 0 Then
            If MessageBox.Show("Update işlemine devam edilsin mi?", "UYARI", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                baglanti.Open()
                Dll_Uygula()
                'cmd = New OleDbCommand("update maliyet set birinci_hammaddenin_grami=" + CInt(TextBox2.Text) + ", birinci_hammaddenin_kilogram_fiyati=" + Val(TextBox3.Text) + ", ikinci_hammaddenin_grami=" + CInt(TextBox4.Text) + ", ikinci_hammaddenin_kilogram_fiyati=" + Val(TextBox5.Text) + ", URUNUN_HAMMADDE_MALIYETI=" + Val(TextBox6.Text) + ", makine_saatlik_maaliyeti=" + Val(TextBox7.Text) + ", bir_urunun_islenme_suresi=" + CInt(TextBox8.Text) + ", aylik_bakim_maliyeti=" + Val(TextBox9.Text) + ", aylik_ortalama_calisma_saati=" + CInt(TextBox10.Text) + ", makinenin_saatlik_harcadigi_enerji_maaliyeti=" + Val(TextBox11.Text) + ", URUNUN_MAKINE_MALIYETI=" + Val(TextBox12.Text) + ", makinede_calisan_personelin_bir_urun_icin_harcadigi_sure=" + Val(TextBox13.Text) + ", giydirilmis_saat_ucreti_makine=" + CInt(TextBox14.Text) + ", montajda_calisan_personelin_bir_urun_icin_harcadigi_sure=" + Val(TextBox15.Text) + ", giydirilmis_saat_ucreti_montaj=" + CInt(TextBox16.Text) + ", URUNUN_ISCILIK_MALIYETI=" + Val(TextBox17.Text) + ", direk_olarak_çalışmayanlarin_giydirilmiş_toplam_ucreti=" + Val(TextBox18.Text) + ", aylik_ortalama_uretim_adedi=" + CInt(TextBox19.Text) + ", URUN_YONETIM_MALIYETI=" + Val(TextBox20.Text) + ", URUN_TOPLAM_MALIYETI=" + Val(TextBox21.Text) + " where kayit_id=" & Val(TextBox1.Text) & "", baglanti)
                cmd = New OleDbCommand("update maliyet set birinci_hammaddenin_grami='" + TextBox2.Text + "', birinci_hammaddenin_kilogram_fiyati='" + TextBox3.Text + "', ikinci_hammaddenin_grami='" + TextBox4.Text + "', ikinci_hammaddenin_kilogram_fiyati='" + TextBox5.Text + "', URUNUN_HAMMADDE_MALIYETI='" + TextBox6.Text + "', makine_saatlik_maaliyeti='" + TextBox7.Text + "', bir_urunun_islenme_suresi='" + TextBox8.Text + "', aylik_bakim_maliyeti='" + TextBox9.Text + "', aylik_ortalama_calisma_saati='" + TextBox10.Text + "', makinenin_saatlik_harcadigi_enerji_maaliyeti='" + TextBox11.Text + "', URUNUN_MAKINE_MALIYETI='" + TextBox12.Text + "', makinede_calisan_personelin_bir_urun_icin_harcadigi_sure='" + TextBox13.Text + "', giydirilmis_saat_ucreti_makine='" + TextBox14.Text + "', montajda_calisan_personelin_bir_urun_icin_harcadigi_sure='" + TextBox15.Text + "', giydirilmis_saat_ucreti_montaj='" + TextBox16.Text + "', URUNUN_ISCILIK_MALIYETI='" + TextBox17.Text + "', direk_olarak_çalışmayanlarin_giydirilmiş_toplam_ucreti='" + TextBox18.Text + "', aylik_ortalama_uretim_adedi='" + TextBox19.Text + "', URUN_YONETIM_MALIYETI='" + TextBox20.Text + "', URUN_TOPLAM_MALIYETI='" + TextBox21.Text + "' where kayit_id=" & Val(TextBox1.Text) & "", baglanti)
                cmd.ExecuteNonQuery()
                baglanti.Close()
                listele()
                temizle()
            Else
                MessageBox.Show("Update işlemi iptal edildi.")
            End If
        Else
            MsgBox("Alanları boş bırakmayınız.")
        End If
    End Sub

    '3////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Dim excel As Excel.Application
    Dim kitap As Excel.Workbook
    Dim sayfa As Excel.Worksheet

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        excel = CreateObject("Excel.Application")
        excel.Visible = True
        kitap = excel.Workbooks.Add
        sayfa = kitap.Worksheets(1)

        sayfa.Cells(1, 1) = Label1.Text
        sayfa.Cells(1, 2) = Label2.Text
        sayfa.Cells(1, 3) = Label3.Text
        sayfa.Cells(1, 4) = Label4.Text
        sayfa.Cells(1, 5) = Label5.Text
        sayfa.Cells(1, 6) = Label6.Text
        sayfa.Cells(1, 7) = Label7.Text
        sayfa.Cells(1, 8) = Label8.Text
        sayfa.Cells(1, 9) = Label9.Text
        sayfa.Cells(1, 10) = Label10.Text
        sayfa.Cells(1, 11) = Label11.Text
        sayfa.Cells(1, 12) = Label12.Text
        sayfa.Cells(1, 13) = Label13.Text
        sayfa.Cells(1, 14) = Label14.Text
        sayfa.Cells(1, 15) = Label15.Text
        sayfa.Cells(1, 16) = Label16.Text
        sayfa.Cells(1, 17) = Label17.Text
        sayfa.Cells(1, 18) = Label18.Text
        sayfa.Cells(1, 19) = Label19.Text
        sayfa.Cells(1, 20) = Label20.Text
        sayfa.Cells(1, 21) = Label21.Text

        For i As Integer = 1 To DataGridView1.Rows.Count() - 1
            For j As Integer = 1 To DataGridView1.Columns.Count()
                sayfa.Cells(i + 1, j) = DataGridView1.Rows(i - 1).Cells(j - 1).Value.ToString()
            Next
        Next

        kitap.SaveAs("C:\Users\elify\OneDrive\Masaüstü\maliyet.xlsx")
        excel.Quit()
    End Sub


    '4////////////////////////////////////////////////////////////////////////////////////////////////////////////


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.ShowDialog()
    End Sub
End Class
