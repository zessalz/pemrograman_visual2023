﻿Public Class Form1
    Private Function HitungVol(jari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = Math.PI * jari ^ 2 * tinggi
        Return volume
    End Function

    Private Function HitungLP(jari As Integer, tinggi As Integer) As Integer
        Dim luasPermukaan As Integer
        luasPermukaan = 2 * Math.PI * jari * (jari + tinggi)
        Return luasPermukaan
    End Function

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, tinggi, volume, luasPermukaan As Integer

        jari = Val(txtJari.Text)
        tinggi = Val(txtTinggi.Text)

        volume = HitungVol(jari, tinggi)
        luasPermukaan = HitungLP(jari, tinggi)

        txtVolume.Text = Str(volume)
        txtLuasPermukaan.Text = Str(luasPermukaan)

    End Sub

End Class