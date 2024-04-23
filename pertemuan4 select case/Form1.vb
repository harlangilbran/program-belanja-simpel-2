Public Class Form1
    ' Deklarasikan Variable untuk menampung Harga Hosting dan Harga Domain
    Dim HargaHosting, HargaDomain As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ListHosting_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListHosting.SelectedIndexChanged
        ' Penggunaan Statemen Select Case
        Select Case ListHosting.Text
            Case "ENTRY"
                HargaHosting = 15000
                THargaHosting.Text = "Rp. " & Format(HargaHosting, "#,#.##")
            Case "SMALL"
                HargaHosting = 17900
                THargaHosting.Text = "Rp. " & Format(HargaHosting, "#,#.##")
            Case "MEDIUM"
                HargaHosting = 29900
                THargaHosting.Text = "Rp. " & Format(HargaHosting, "#,#.##")
            Case "LARGE"
                HargaHosting = 49900
                THargaHosting.Text = "Rp. " & Format(HargaHosting, "#,#.##")

        End Select
    End Sub

    Private Sub ListDomain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDomain.SelectedIndexChanged
        ' Penggunaan Statemen Select Case
        Select Case ListDomain.Text
            Case ".COM"
                HargaDomain = 129900
                THargaDomain.Text = "Rp. " & Format(HargaDomain, "#,#.##")
            Case ".ID"
                HargaDomain = 21900
                THargaDomain.Text = "Rp. " & Format(HargaDomain, "#,#.##")
            Case ".ORG"
                HargaDomain = 105000
                THargaDomain.Text = "Rp. " & Format(HargaDomain, "#,#.##")
            Case ".SCH"
                HargaDomain = 50000
                THargaDomain.Text = "Rp. " & Format(HargaDomain, "#,#.##")
            Case ".AC.ID"
                HargaDomain = 65000
                THargaDomain.Text = "Rp. " & Format(HargaDomain, "#,#.##")
        End Select

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil Fungsi untuk Menhilangkan Inputan Domain
        HideDomain()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Kondisi jika CheckBox1 di check tampilkan pilihan Domain
            ShowDomain()
        Else
            ' Kondisi jika CheckBox1 di uncheck Hilangkan pilihan Domain
            HideDomain()
        End If
    End Sub
    ' Fungsi Untuk menghilangkan Inputan Domain
    Sub HideDomain()
        ListDomain.Visible = False
        THargaDomain.Visible = False
    End Sub
    ' Fungsi Untuk Menampilkan Inputan Domain
    Sub ShowDomain()
        ListDomain.Visible = True
        THargaDomain.Visible = True
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        ' Deklarasi Variable untuk Masa Aktif dan Jumlah Bayar
        Dim JmlMasaAktif, JumlahBayar As Integer

        ' Isi Nilai Variable JmlMasaAktif dengan inputan Masa Aktif
        JmlMasaAktif = TMasaAktif.Text
        ' Isi Nilai Variable Jumlah Bayar
        JumlahBayar = HargaHosting + HargaDomain * JmlMasaAktif
        ' Tampilkan Jumlah Bayar
        TJumlahBayar.Text = "Rp. " & Format(JumlahBayar, "#,#.##")
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        ' Tutup Form3
        End

    End Sub

    Private Sub Form2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class

