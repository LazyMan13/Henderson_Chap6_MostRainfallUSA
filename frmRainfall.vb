Public Class frmRainfall
    Private Sub btnRain_Click(sender As Object, e As EventArgs) Handles btnRain.Click
        Dim strRain As String
        Dim decRain As Decimal
        Dim decTotal As Decimal = 0D
        Dim decAvg As Decimal
        Dim intMaxNum As Integer = 12
        Dim intNum As Integer = 1
        Dim strInBoxMsg As String = "Enter the Rainfall for month #"
        Dim strInBoxTitle As String = "Average Rainfall"
        Dim strBoxMsg As String = "Enter the Rainfall for month #"
        Dim strNonNumErrMsg As String = "Error: Enter a number only"
        Dim strNegNumErrMsg As String = "Error: Enter a positive number"

        strRain = InputBox(strInBoxMsg & intNum, strInBoxTitle)

        Do Until intNum > intMaxNum Or
                  strRain = ""

            If IsNumeric(strRain) Then
                decRain = Convert.ToDecimal(strRain)

                If decRain > 0 Then
                    lstInches.Items.Add(decRain)
                    decTotal += decRain
                    intNum += 1
                    strInBoxMsg = strBoxMsg
                Else
                    strInBoxMsg = strNegNumErrMsg
                End If
            Else
                strInBoxMsg = strNonNumErrMsg
            End If
            If intNum <= intMaxNum Then
                strRain = InputBox(strInBoxMsg & intNum, strInBoxTitle)
            End If
        Loop

        lblAverage.Visible = True

        If intNum > 1 Then
            decRain += decTotal
            decAvg = decRain / intNum
            lblAverage.Text = "Average Rainfall a Month is " & decAvg.ToString() & " inches"
        Else
            lblAverage.Text = "No Rain value entered"
        End If

        btnRain.Enabled = False

    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstInches.Items.Clear()
        lblAverage.Visible = False
        btnRain.Enabled = True

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

End Class