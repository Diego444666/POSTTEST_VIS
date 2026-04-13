Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilStatistik()
    End Sub

    Private Sub TampilStatistik()
        Dim dt As DataTable = GetAllNilai()

        lblTotal.Text = dt.Rows.Count.ToString()

        Dim total As Integer = 0
        Dim tertinggi As Integer = 0
        Dim terendah As Integer = 100

        For Each row As DataRow In dt.Rows
            Dim n As Integer = Convert.ToInt32(row("nilai"))

            total += n

            If n > tertinggi Then
                tertinggi = n
            End If

            If n < terendah Then
                terendah = n
            End If
        Next

        ' CEK biar tidak error bagi 0
        If dt.Rows.Count > 0 Then
            lblRata.Text = Math.Round(CDbl(total) / CDbl(dt.Rows.Count), 1).ToString()
        Else
            lblRata.Text = "0"
        End If

        lblTertinggi.Text = tertinggi.ToString()
        lblTerendah.Text = terendah.ToString()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

End Class