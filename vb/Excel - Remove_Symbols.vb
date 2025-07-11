Sub Remove_Symbols()
    Dim symbols As Variant
    Dim replacements As Variant
    Dim dataRange As Range
    Dim cellValues As Variant
    Dim i As Long, r As Long, c As Long
    Dim tempVal As String

    ' Improve performance
    Application.ScreenUpdating = False
    Application.Calculation = xlCalculationManual
    Application.EnableEvents = False

    ' Define symbols and replacements
    symbols = Array(".", ",", "&", "'", "-", "/", "(", ")", """", "\", "@", "#", "+", "*", ":", ";", "?", "!", "%", _
                    ChrW(&H2010), ChrW(&H2012), ChrW(&H2013), ChrW(&H2014), ChrW(&H2212), _
                    ChrW(&H2018), ChrW(&H2019), ChrW(&H201C), ChrW(&H201D), "_", " Iv", " Iii", " Ii")
                    
    replacements = Array("", "", "and", "", " ", " ", "", "", "", "", "", "", "", "", "", "", "", "", "", _
                         " ", " ", " ", " ", " ", "", "", "", "", " ", " IV", " III", " II")

    ' Work with the selection
    Set dataRange = Selection
    If dataRange.Cells.Count = 1 Then
        cellValues = Array(Array(dataRange.Value))
    Else
        cellValues = dataRange.Value
    End If

    ' Loop through cells and clean data
    For r = 1 To UBound(cellValues, 1)
        For c = 1 To UBound(cellValues, 2)
            If Not IsEmpty(cellValues(r, c)) Then
                tempVal = CStr(cellValues(r, c))
                For i = LBound(symbols) To UBound(symbols)
                    tempVal = Replace(tempVal, symbols(i), replacements(i))
                Next i
                ' Replace multiple spaces with single space
                Do While InStr(tempVal, "  ") > 0
                    tempVal = Replace(tempVal, "  ", " ")
                Loop
                cellValues(r, c) = Trim(tempVal)
            End If
        Next c
    Next r

    ' Write cleaned data back at once
    dataRange.Value = cellValues

    ' Restore settings
    Application.ScreenUpdating = True
    Application.Calculation = xlCalculationAutomatic
    Application.EnableEvents = True

    MsgBox "Symbols removed and data cleaned successfully.", vbInformation, "Cleanup Complete"
End Sub


