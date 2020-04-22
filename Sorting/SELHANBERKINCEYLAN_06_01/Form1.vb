Public Class Form1
    Dim integerArray(6) As Integer
    Dim Controller As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Controller = True
        ComboBox1.Items.Clear()
        For i = 0 To 6
            createNumber(i)
        Next
    End Sub

    Function createNumber(ByVal index As Integer)
        Randomize()

        Dim myNumber As Integer = Rnd() * 100
        If Not ComboBox1.Items.Contains(myNumber) Then
            integerArray(index) = myNumber
            ComboBox1.Items.Add(integerArray(index))
        Else
            createNumber(index)
        End If
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Controller = True Then
            ComboBox2.Items.Clear()
            SortFunction(integerArray)
        Else
            MsgBox("You must create number, firstly.", MsgBoxStyle.Critical, "HATA")
        End If

    End Sub

    'Boubble Sort Algorithm'
    Function SortFunction(ByVal Array() As Integer)
        Dim iTemp As Integer
        For iPass = 1 To 6
            For i = 0 To 5
                If Array(i) > Array(i + 1) Then
                    iTemp = Array(i)
                    Array(i) = Array(i + 1)
                    Array(i + 1) = iTemp
                End If
            Next i
        Next iPass

        For k = 0 To 6
            ComboBox2.Items.Add(Array(k))
        Next
    End Function

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Controller = True Then
            ComboBox3.Items.Clear()
            insertionSort(integerArray, integerArray.Length)
            Dim i As Integer
            For i = 0 To integerArray.Length - 1
                ComboBox3.Items.Add(integerArray(i))
            Next
        Else
            MsgBox("You must create number, firstly.", MsgBoxStyle.Critical, "HATA")
        End If
    End Sub

    'Instertion Sort Algorithm'
    Sub insertionSort(ByVal dataset() As Integer, ByVal n As Integer)
        Dim i, j As Integer

        For i = 1 To n - 1 Step 1
            Dim pick_item As Integer = dataset(i)
            Dim inserted As Integer = 0
            j = i - 1
            While (j >= 0 And inserted <> 1)
                If (pick_item < dataset(j)) Then
                    dataset(j + 1) = dataset(j)
                    j -= 1
                    dataset(j + 1) = pick_item
                Else : inserted = 1
                End If
            End While
        Next
    End Sub

    'Gnome Sort Algorithm'
    Sub GnomeSort(ByRef data As Integer())
        Dim i As Integer = 1
        While i < data.Length
            If data(i - 1) <= data(i) Then
                i += 1
            Else
                Dim tmp As Integer = data(i)
                data(i) = data(i - 1)
                data(i - 1) = tmp
                i -= 1
                If i = 0 Then
                    i = 1
                End If
            End If
        End While

        For k = 0 To 6
            ComboBox4.Items.Add(data(k))
        Next

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Controller = True Then
            ComboBox4.Items.Clear()
            GnomeSort(integerArray)
        Else
            MsgBox("You must create number, firstly.", MsgBoxStyle.Critical, "HATA")
        End If
    End Sub
End Class
