Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeading.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        lblHeading.AutoSize = False
        lblHeading.Text = "Internet Speed Test Survey"
        lblHeading.Size = New System.Drawing.Size(325, 39)
        lblHeading.TextAlign = ContentAlignment.TopCenter
        lblHeading.BackColor = System.Drawing.Color.White
        lblHeading.ForeColor = System.Drawing.Color.Black

        btnInternetSpeed.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        btnInternetSpeed.AutoSize = False
        btnInternetSpeed.Text = "Enter Internet Speed"
        btnInternetSpeed.Size = New System.Drawing.Size(195, 40)
        btnInternetSpeed.TextAlign = ContentAlignment.MiddleCenter
        btnInternetSpeed.BackColor = System.Drawing.Color.DarkKhaki
        btnInternetSpeed.ForeColor = System.Drawing.Color.Black

        lbxInput.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        lbxInput.Text = ""
        lbxInput.Size = New System.Drawing.Size(74, 160)

        lblAvgSpeed.AutoSize = False
        lblAvgSpeed.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        lblAvgSpeed.Text = "XXXXXXXXXXXX 0000"
        lblAvgSpeed.TextAlign = ContentAlignment.TopCenter
        lblAvgSpeed.Size = New System.Drawing.Size(282, 35)
        lblAvgSpeed.BackColor = System.Drawing.Color.Transparent
        lblAvgSpeed.ForeColor = System.Drawing.Color.Black
        lblAvgSpeed.Visible = False


    End Sub

    Private Sub btnInternetSpeed_Click(sender As Object, e As EventArgs) Handles btnInternetSpeed.Click

        Dim strInternetSpeed As String
        Dim decSpeed As Decimal
        Dim decSpeedSum As Decimal
        Dim decAvgSpeed As Decimal = 0D

        Dim strlbxMsg As String = "Please, enter the number of Mbps of your home Internet speed user #"
        Dim strlbxTitle As String = "Internet Speed"
        Dim strNonNumericErrMsg As String = "Error: Please, enter the speed of your home Internet connection."
        Dim strNegErrMsg As String = "Error: Please, enter a valid speed."


        Dim intMax As Integer = 10
        Dim intEntries As Integer = 1

        strInternetSpeed = InputBox(strlbxMsg & intEntries, strlbxTitle)

        Do Until intEntries > intMax Or strInternetSpeed = ""
            If IsNumeric(strInternetSpeed) Then
                strlbxMsg = "Please, enter the number of Mbps of your home Internet speed user #"
                decSpeed = Convert.ToDecimal(strInternetSpeed)
                If decSpeed > 0 Then
                    lbxInput.Items.Add(decSpeed)
                    decSpeedSum += decSpeed
                    intEntries += 1
                    strlbxMsg = strlbxMsg
                Else
                    strlbxMsg = strNegErrMsg
                End If
            Else
                strlbxMsg = strNonNumericErrMsg
            End If

            If intEntries <= intMax Then
                strInternetSpeed = InputBox(strlbxMsg & intEntries, strlbxTitle)
            End If
        Loop

        lblAvgSpeed.Visible = True
        If intEntries > 1 Then
            decAvgSpeed = decSpeedSum / (intEntries - 1)
            lblAvgSpeed.Text = "Average Internet Speed: " & decAvgSpeed.ToString("F2") & " Mbps "
        Else
            lblAvgSpeed.Text = "No Speed Values Entered"
        End If

        btnInternetSpeed.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbxInput.Items.Clear()
        lblAvgSpeed.Text = ""
        btnInternetSpeed.Enabled = True
    End Sub
End Class
