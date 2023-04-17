Public Class Form1
    Private _intSizeofArray As Integer = 11
    Private _strSavings(_intSizeofArray) As String
    Private _decBill(_intSizeofArray) As Decimal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDisplay.Visible = False
        'read the savings on txt file
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer
        lblSaving.Text = ""
        lblAverage.Text = ""
        lblMax.Text = ""
        'code to verify the text file exists then read libe by line til end
        If IO.File.Exists("C:\Users\trank\OneDrive\Documents\savings.txt") = True Then
            objReader = IO.File.OpenText("C:\Users\trank\OneDrive\Documents\savings.txt")
            Do While objReader.Peek <> -1
                _strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1
            Loop
            'remember this. "CLOSE"
            objReader.Close()
            For intFill = 0 To (_strSavings.Length - 1)
                cboMonths.Items.Add(_strSavings(intFill))
            Next
        Else
            MsgBox("The file does not exist", , "Error")
            Close()
        End If
    End Sub

    Private Sub cboMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonths.SelectedIndexChanged
        'Display th saving for each month
        Dim intSelectedCityIndex As Integer
        intSelectedCityIndex = cboMonths.SelectedIndex
        lblSaving.Text = "The electric savings for " & _strSavings(intSelectedCityIndex) & " is $" & _decBill(intSelectedCityIndex).ToString()
        btnDisplay.Visible = True
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Display the average monthly saving and Max value
        ComputeAverage()
        ComputeMax()
    End Sub
    Private Sub ComputeAverage()
        Dim intCountYears As Integer
        Dim intYears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverage As Decimal = 0D
        For Each intCountYear In _decBill
            decTotalBill += _decBill(intYears)
            intYears += 1
        Next
        decAverage = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblAverage.Text = "The Average monthly savings " & decAverage.ToString("C2")
    End Sub
    Private Sub ComputeMax()
        Dim intMonth As Integer
        Dim intLagerSavingValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strYearValue As String = ""
        For Each intMonth In _decBill
            intLagerSavingValue = Math.Max(intLagerSavingValue, intMonth)
            If (intMonth >= intLagerSavingValue) Then
                strYearValue = _strSavings(intIndexValue)

            End If
            intIndexValue += 1
        Next
        lblMax.Text = strYearValue & " has the most significant monthly savings"
    End Sub
End Class
