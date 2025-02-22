Public Class Hesapla
    Dim hammadde_maliyeti, makine_maliyeti, iscilik_maaliyeti, yonetim_maliyeti, toplam_maliyet As Single

    Function UrunHammaddeMaliyeti(ByVal hammadde_grami_bir As Integer, ByVal hammadde_fiyati_bir As Single, ByVal hammadde_grami_iki As Integer, ByVal hammadde_fiyati_iki As Single)
        hammadde_maliyeti = (hammadde_grami_bir / 1000) * hammadde_fiyati_bir + (hammadde_grami_iki / 1000) * hammadde_fiyati_iki
        Return hammadde_maliyeti
    End Function

    Function UrunMakineMaliyeti(ByVal mak_saatlik_mal As Single, ByVal bir_urun_isl_suresi As Integer, ByVal aylik_bakim_mal As Single, ByVal aylik_cal_saati As Integer, ByVal enerji_maaliyeti As Single)
        makine_maliyeti = (mak_saatlik_mal * (bir_urun_isl_suresi / 60)) + (aylik_bakim_mal / aylik_cal_saati) + enerji_maaliyeti
        Return makine_maliyeti
    End Function

    Function Urun›scilikMaliyeti(ByVal makinede_calisan_isci_urun_isl_saati As Single, ByVal giydirilmis_saat_ucreti_makine As Integer, ByVal montajda_calisan_isci_urun_isl_saati As Single, ByVal giydirilmis_saat_ucreti_montaj As Integer)
        iscilik_maaliyeti = giydirilmis_saat_ucreti_makine * (makinede_calisan_isci_urun_isl_saati / 60) + giydirilmis_saat_ucreti_montaj * (montajda_calisan_isci_urun_isl_saati / 60)
        Return iscilik_maaliyeti
    End Function

    Function UrunYonetimMaliyeti(ByVal yonetim_giydirilmis_top_ucret As Single, ByVal ort_uretim_adedi As Integer)
        yonetim_maliyeti = yonetim_giydirilmis_top_ucret / ort_uretim_adedi
        Return yonetim_maliyeti
    End Function

    Function UrunToplamMaliyeti()
        toplam_maliyet = hammadde_maliyeti + makine_maliyeti + iscilik_maaliyeti + yonetim_maliyeti
        Return toplam_maliyet
    End Function
End Class
