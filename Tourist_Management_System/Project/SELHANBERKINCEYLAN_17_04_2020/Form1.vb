Imports System.Net
Imports System.Net.Mail


Public Class Form1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function ClearAll()
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next i
    End Function

    Function NewCity(ByVal CityName As String)
        MessageBox.Show("WELCOME TO " & CityName)
        PictureBox1.ImageLocation = "C:\Images\" & CityName & ".jpg"
    End Function

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

        Dim indexChecked As Integer
        Dim cityNAME As String
        Dim imageLocation As String = "C:\Images\" & cityNAME & ".jpg"

        For Each indexChecked In CheckedListBox1.CheckedIndices
            cityNAME = Convert.ToString(CheckedListBox1.Items(indexChecked))
            NewCity(cityNAME)
            ClearAll()
        Next

    End Sub

    Private Sub ContectUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContectUsToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub AddNewCityToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or PictureBox2.Image Is Nothing Then
            MessageBox.Show("Please, enter all information...")
        Else
            CheckedListBox1.Items.Add(TextBox1.Text)
            PictureBox2.Image.Save("C:\Images\" & ComboBox1.SelectedItem & ".jpg")
            ComboBox1.Items.Remove(ComboBox1.SelectedItem)
            TextBox1.Text = ""
            PictureBox2.Image = Nothing
        End If
    End Sub

    Private Sub DenizliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DenizliToolStripMenuItem.Click
        NewCity("Denizli")
    End Sub

    Private Sub AdanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdanaToolStripMenuItem.Click
        NewCity("Adana")
    End Sub

    Private Sub AnkaraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnkaraToolStripMenuItem.Click
        NewCity("Ankara")
    End Sub

    Private Sub İstanbulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İstanbulToolStripMenuItem.Click
        NewCity("İstanbul")
    End Sub

    Private Sub İzmirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İzmirToolStripMenuItem.Click
        NewCity("İzmir")
    End Sub

    Private Sub MersinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MersinToolStripMenuItem.Click
        NewCity("Mersin")
    End Sub

    Private Sub ZonguldakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZonguldakToolStripMenuItem.Click
        NewCity("Zonguldak")
    End Sub

    Private Sub WithMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithMailToolStripMenuItem.Click
        MessageBox.Show("Our Mail Address: info@tourist.com")
    End Sub

    Private Sub WithMobilePhoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithMobilePhoneToolStripMenuItem.Click
        MessageBox.Show("For Communation: +90 546 243 32 78")
    End Sub

    Private Sub WithSellerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithSellerToolStripMenuItem.Click
        MessageBox.Show("Our Seller Address: Akkonak Mah. Lozan Cad. Ege Sitesi No:84 Bayramyeri/İSTANBUL")
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CitysInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CitysInfoToolStripMenuItem.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
