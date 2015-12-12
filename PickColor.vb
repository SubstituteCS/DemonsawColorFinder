Public Class PickColor
    Private Sub pickcolor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        previewcolorpicturebox.BackColor = DemonSaw.default_chat
        For Each item In DemonSaw.s_colors
            Dim ni As New ListViewItem
            ni.Text = "    "
            ni.BackColor = item
            ni.ForeColor = item
            colorslistview.Items.Add(ni)
        Next
    End Sub
    Private Sub colorslistview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles colorslistview.SelectedIndexChanged
        If colorslistview.SelectedItems.Count = 1 Then
            previewcolorpicturebox.BackColor = colorslistview.SelectedItems(0).BackColor
        End If
    End Sub

    Private Sub confirmbutton_Click(sender As Object, e As EventArgs) Handles confirmbutton.Click
        Main.previewpicturebox.BackColor = previewcolorpicturebox.BackColor
        Main.c_index = colorslistview.SelectedItems(0).Index
        Me.Close()
    End Sub

    Private Sub PickColor_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        colorslistview.Clear()
    End Sub
End Class
