Option Strict On
Public Class DemonSaw
    Public Shared ReadOnly default_chat As Color = Color.FromArgb(&H00, &HD0, &H87)
    Public Shared ReadOnly s_colors() As Color =
        {Color.FromArgb(&HFF, &H00, &HFF, &H00),
        Color.FromArgb(&HFF, &H00, &H00, &HFF),
        Color.FromArgb(&HFF, &HFF, &H00, &H00),
        Color.FromArgb(&HFF, &H01, &HFF, &HFE),
        Color.FromArgb(&HFF, &HFF, &HA6, &HFE),
        Color.FromArgb(&HFF, &HFF, &HDB, &H66),
        Color.FromArgb(&HFF, &H00, &H64, &H01),
        Color.FromArgb(&HFF, &H01, &H00, &H67),
        Color.FromArgb(&HFF, &H95, &H00, &H3A),
        Color.FromArgb(&HFF, &H00, &H7D, &HB5),
        Color.FromArgb(&HFF, &HFF, &H00, &HF6),
        Color.FromArgb(&HFF, &HFF, &HEE, &HE8),
        Color.FromArgb(&HFF, &H77, &H4D, &H00),
        Color.FromArgb(&HFF, &H90, &HFB, &H92),
        Color.FromArgb(&HFF, &H00, &H76, &HFF),
        Color.FromArgb(&HFF, &HD5, &HFF, &H00),
        Color.FromArgb(&HFF, &HFF, &H93, &H7E),
        Color.FromArgb(&HFF, &H6A, &H82, &H6C),
        Color.FromArgb(&HFF, &HFF, &H02, &H9D),
        Color.FromArgb(&HFF, &HFE, &H89, &H00),
        Color.FromArgb(&HFF, &H7A, &H47, &H82),
        Color.FromArgb(&HFF, &H7E, &H2D, &HD2),
        Color.FromArgb(&HFF, &H85, &HA9, &H00),
        Color.FromArgb(&HFF, &HFF, &H00, &H56),
        Color.FromArgb(&HFF, &HA4, &H24, &H00),
        Color.FromArgb(&HFF, &H00, &HAE, &H7E),
        Color.FromArgb(&HFF, &H68, &H3D, &H3B),
        Color.FromArgb(&HFF, &HBD, &HC6, &HFF),
        Color.FromArgb(&HFF, &H26, &H34, &H00),
        Color.FromArgb(&HFF, &HBD, &HD3, &H93),
        Color.FromArgb(&HFF, &H00, &HB9, &H17),
        Color.FromArgb(&HFF, &H9E, &H00, &H8E),
        Color.FromArgb(&HFF, &H00, &H15, &H44),
        Color.FromArgb(&HFF, &HC2, &H8C, &H9F),
        Color.FromArgb(&HFF, &HFF, &H74, &HA3),
        Color.FromArgb(&HFF, &H01, &HD0, &HFF),
        Color.FromArgb(&HFF, &H00, &H47, &H54),
        Color.FromArgb(&HFF, &HE5, &H6F, &HFE),
        Color.FromArgb(&HFF, &H78, &H82, &H31),
        Color.FromArgb(&HFF, &H0E, &H4C, &HA1),
        Color.FromArgb(&HFF, &H91, &HD0, &HCB),
        Color.FromArgb(&HFF, &HBE, &H99, &H70),
        Color.FromArgb(&HFF, &H96, &H8A, &HE8),
        Color.FromArgb(&HFF, &HBB, &H88, &H00),
        Color.FromArgb(&HFF, &H43, &H00, &H2C),
        Color.FromArgb(&HFF, &HDE, &HFF, &H74),
        Color.FromArgb(&HFF, &H00, &HFF, &HC6),
        Color.FromArgb(&HFF, &HFF, &HE5, &H02),
        Color.FromArgb(&HFF, &H62, &H0E, &H00),
        Color.FromArgb(&HFF, &H00, &H8F, &H9C),
        Color.FromArgb(&HFF, &H98, &HFF, &H52),
        Color.FromArgb(&HFF, &H75, &H44, &HB1),
        Color.FromArgb(&HFF, &HB5, &H00, &HFF),
        Color.FromArgb(&HFF, &H00, &HFF, &H78),
        Color.FromArgb(&HFF, &HFF, &H6E, &H41),
        Color.FromArgb(&HFF, &H00, &H5F, &H39),
        Color.FromArgb(&HFF, &H6B, &H68, &H82),
        Color.FromArgb(&HFF, &H5F, &HAD, &H4E),
        Color.FromArgb(&HFF, &HA7, &H57, &H40),
        Color.FromArgb(&HFF, &HA5, &HFF, &HD2),
        Color.FromArgb(&HFF, &HFF, &HB1, &H67),
        Color.FromArgb(&HFF, &H00, &H9B, &HFF),
        Color.FromArgb(&HFF, &HE8, &H5E, &HBE)}

    Public Shared Function GetNameHash(name As String) As Byte
        Dim hash As UInt32 = 0
        Dim data As Byte() = System.Text.Encoding.UTF32.GetBytes(name)
        Dim bdata(data.Length) As UInt32
        For i As Int32 = 0 To data.Length - 1 Step 4
            bdata(i) = BitConverter.ToUInt32(data, i)
        Next
        For Each item As UInt32 In bdata
            If item >= 160 And item <= 8210 Then
                hash += CUInt(item + 1)
            Else
                hash += item
            End If
            Debug.WriteLine(item & " added")
        Next
        hash = CUInt(hash Mod s_colors.Length)
        Debug.WriteLine("hash found as " & hash)
        Return CByte(hash)
    End Function

    Public Shared Function GetDistance(hash As Byte, desired As Byte) As Byte
        If desired > hash Then
            'Debug.WriteLine("Found Offset, D > H")
            Return desired - hash
        Else
            'Debug.WriteLine("Found Offset, D < H")
            Return CByte(s_colors.Length + desired - hash) 'same as above, but to loop back around since there are no negative value characters
        End If
    End Function
End Class
