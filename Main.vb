Public Class Main
    Friend c_index As Int32 = -1
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        previewpicturebox.BackColor = DemonSaw.default_chat
    End Sub

    Private Sub previewpicturebox_Click(sender As Object, e As EventArgs) Handles previewpicturebox.Click
        PickColor.ShowDialog()
    End Sub

    Private Sub generatebutton_Click(sender As Object, e As EventArgs) Handles generatebutton.Click
        If c_index = -1 And usernametextbox.Text.Replace(" ", "") = String.Empty Then
            MessageBox.Show("Please Choose A Color and Enter Your Username Before Continuing!", "Error", MessageBoxButtons.OK)
        ElseIf c_index = -1 Then
            MessageBox.Show("Please Choose A Color Before Continuing!", "Error", MessageBoxButtons.OK)
        ElseIf usernametextbox.Text.Replace(" ", "") = String.Empty Then
            MessageBox.Show("Please Enter Your Username Before Continuing!", "Error", MessageBoxButtons.OK)
        Else
            Clipboard.SetText(GenerateNewName())
            MessageBox.Show("New Name Generated and Copied to Clipboard", "Success", MessageBoxButtons.OK)
        End If
    End Sub

    Private Function GenerateNewName() As String
        Dim fn As String = usernametextbox.Text
        Dim offset As Byte = DemonSaw.GetDistance(DemonSaw.GetNameHash(usernametextbox.Text), c_index)
        While offset <> 0
            For c As Int32 = 31 To 1 Step -1
                If c > offset Then
                    Continue For
                Else
                    offset -= c
                    fn = fn & Chr(c)
                    Exit For
                End If
            Next
        End While
        Return fn
    End Function
End Class