Public Class Main
    Friend c_index As Int32 = -1
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        previewpicturebox.BackColor = DemonSaw.default_chat
        Clipboard.SetText(System.Text.Encoding.UTF32.GetString({255, 255, 255, 255}))
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
        Dim offset As Byte = DemonSaw.GetDistance(DemonSaw.GetNameHash(usernametextbox.Text), c_index)
        Dim data As New List(Of Byte)
        data.AddRange(System.Text.Encoding.UTF32.GetBytes(usernametextbox.Text))
        While offset <> 0
            For c As Int32 = 31 To 1 Step -1
                If c >= 9 And c <= 13 Then
                    Continue For
                End If
                If c > offset Then
                    Continue For
                End If
                offset -= c
                data.AddRange(BitConverter.GetBytes(c))
                Debug.WriteLine("Found offset ctrlchar: " & c & ", offset = " & offset)
                Exit For
            Next
        End While
        Return System.Text.Encoding.UTF32.GetString(data.ToArray)
    End Function
End Class