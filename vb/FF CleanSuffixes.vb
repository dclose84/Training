Sub CleanSuffixes()
    Dim dataRange As Range
    Dim cell As Range
    Dim ws As Worksheet
    Dim suffixMap As Variant
    Dim i As Long, r As Long, c As Long
    Dim suffixColIndex As Long
    Dim cellValues As Variant
    Dim suffixValues() As Variant
    Dim cleanedText As String
    Dim foundSuffix As String
    Dim colCount As Long

    Set ws = ActiveSheet
    Set dataRange = Selection

    ' Define suffix mappings: case-insensitive match, proper-case output
    suffixMap = Array( _
        Array(" sr", "Sr"), _
        Array(" jr", "Jr"), _
        Array(" iv", "IV"), _
        Array(" iii", "III"), _
        Array(" ii", "II") _
    )

    ' Find the "Suffix_Name" column index from row 1
    suffixColIndex = 0
    colCount = ws.Cells(1, ws.Columns.Count).End(xlToLeft).Column
    For i = 1 To colCount
        If LCase(ws.Cells(1, i).Value) = "suffix_name" Then
            suffixColIndex = i
            Exit For
        End If
    Next i

    If suffixColIndex = 0 Then
        MsgBox "No column labeled 'Suffix_Name' found in row 1.", vbExclamation
        Exit Sub
    End If

    ' Load selected cell values into memory
    If dataRange.Cells.Count = 1 Then
        ReDim cellValues(1 To 1, 1 To 1)
        cellValues(1, 1) = dataRange.Value
    Else
        cellValues = dataRange.Value
    End If

    ' Prepare suffix array to match dataRange rows
    ReDim suffixValues(1 To UBound(cellValues, 1), 1 To 1)

    ' Loop and clean
    For r = 1 To UBound(cellValues, 1)
        For c = 1 To UBound(cellValues, 2)
            If Not IsEmpty(cellValues(r, c)) Then
                cleanedText = CStr(cellValues(r, c))
                cleanedText = Replace(cleanedText, ".", "") ' Remove periods

                foundSuffix = ""
                ' Check for suffix (case-insensitive)
                For i = LBound(suffixMap) To UBound(suffixMap)
                    If InStr(1, cleanedText, suffixMap(i)(0), vbTextCompare) > 0 Then
                        cleanedText = Replace(cleanedText, suffixMap(i)(0), "", , , vbTextCompare)
                        foundSuffix = suffixMap(i)(1)
                        Exit For
                    End If
                Next i

                ' Trim and store
                cellValues(r, c) = Trim(cleanedText)
                If foundSuffix <> "" Then suffixValues(r, 1) = foundSuffix
            End If
        Next c
    Next r

    ' Write cleaned values back to selection
    dataRange.Value = cellValues

    ' Write suffix values to Suffix_Name column
    For r = 1 To UBound(cellValues, 1)
        If suffixValues(r, 1) <> "" Then
            ws.Cells(dataRange.Cells(r, 1).Row, suffixColIndex).Value = suffixValues(r, 1)
        End If
    Next r

    MsgBox "Suffixes cleaned and values written to 'Suffix_Name' column.", vbInformation
End Sub


