Public Class Form1

    Dim number1 As Double = vbNull
    Dim number2 As Double = vbNull
    Dim Result As Double
    Dim operationGeneral As Char
    Dim operationEnable As Boolean = False
    Dim operationEqual As Boolean = True
    Dim numberClicked As Boolean = False
    Dim oldOperation As Char

    Function numbers(ByVal number As Integer)
        If numberClicked = True Then
            TextBox1.Text = ""
            numberClicked = False
        End If
        TextBox1.Text = "" & TextBox1.Text & number & ""
        operatorsBoolean(True)
    End Function

    Function operatorsBoolean(ByVal booleanKL As Boolean)
        plusButton.Enabled = booleanKL
        minusButton.Enabled = booleanKL
        multiplactionButton.Enabled = booleanKL
        divisionButton.Enabled = booleanKL
        rootButton.Enabled = booleanKL
        squareButton.Enabled = booleanKL
        percentButton.Enabled = booleanKL
        equalButton.Enabled = booleanKL
    End Function

    Private Sub one_Click(sender As Object, e As EventArgs) Handles one.Click
        numbers(1)
    End Sub

    Private Sub two_Click(sender As Object, e As EventArgs) Handles two.Click
        numbers(2)
    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
        numbers(3)
    End Sub

    Private Sub four_Click(sender As Object, e As EventArgs) Handles four.Click
        numbers(4)
    End Sub

    Private Sub five_Click(sender As Object, e As EventArgs) Handles five.Click
        numbers(5)
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
        numbers(6)
    End Sub

    Private Sub seven_Click(sender As Object, e As EventArgs) Handles seven.Click
        numbers(7)
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
        numbers(8)
    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click
        numbers(9)
    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        numbers(0)
    End Sub

    Private Sub plusminusButton_Click(sender As Object, e As EventArgs) Handles plusminusButton.Click
        If TextBox1.Text.Length = 0 Then
        Else
            TextBox1.Text = TextBox1.Text * -1
        End If
    End Sub

    Private Sub doubleButton_Click(sender As Object, e As EventArgs) Handles doubleButton.Click
        If TextBox1.Text.Length = 0 Then
        Else
            TextBox1.Text = ""
            operationEnable = False
            operationEqual = True
            numberClicked = False
            Label1.Text = ""
            number1 = vbNull
            number2 = vbNull
            operatorsBoolean(True)
        End If
    End Sub

    Function operationButton(ByVal operation As Char)
        operationGeneral = operation
        operatorsBoolean(False)

        If TextBox1.Text.Length = 0 Then
        Else
            If operationEqual = False Then
                equal(oldOperation, number1, TextBox1.Text)
                number1 = TextBox1.Text
                TextBox1.Text = Result & operation
                Label1.Text = Result
                numberClicked = True
                operationEnable = True
            Else
                oldOperation = operation
                operationEqual = False
                operationEnable = True
                number1 = TextBox1.Text
                TextBox1.Text = number1 & operation
                numberClicked = True
                Label1.Text = number1
            End If
        End If
    End Function

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        operationButton("+")
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        operationButton("-")
    End Sub

    Private Sub multiplactionButton_Click(sender As Object, e As EventArgs) Handles multiplactionButton.Click
        operationButton("x")
    End Sub

    Private Sub divisionButton_Click(sender As Object, e As EventArgs) Handles divisionButton.Click
        operationButton("÷")
    End Sub

    Private Sub rootButton_Click(sender As Object, e As EventArgs) Handles rootButton.Click
        If TextBox1.Text.Length = 0 Then
        Else
            TextBox1.Text = Math.Sqrt(TextBox1.Text)
        End If
    End Sub

    Private Sub squareButton_Click(sender As Object, e As EventArgs) Handles squareButton.Click
        If TextBox1.Text.Length = 0 Then
        Else
            Dim number As Double = TextBox1.Text
            TextBox1.Text = Number * Number
        End If
    End Sub

    Private Sub percentButton_Click(sender As Object, e As EventArgs) Handles percentButton.Click
        If TextBox1.Text.Length = 0 Then
        Else
            Dim number As Double = TextBox1.Text
            TextBox1.Text = number / 100
        End If
    End Sub

    Function equal(ByVal operation As Char, ByVal number1 As Double, ByVal number2 As Double)
        Select Case operation
            Case "+"
                Result = number1 + number2
            Case "-"
                Result = number1 - number2
            Case "x"
                Result = number1 * number2
            Case "÷"
                Result = number1 / number2
        End Select
    End Function

    Private Sub equalButton_Click(sender As Object, e As EventArgs) Handles equalButton.Click
        If TextBox1.Text.Length = 0 Or number1 = vbNull Then
        Else
            number2 = TextBox1.Text
            equal(operationGeneral, Label1.Text, number2)
            TextBox1.Text = Result
            number1 = Result
            Label1.Text = number1
            operationEnable = False
            operationEqual = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
