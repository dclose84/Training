Sub ClearEmptyStrings()
    Dim originalSheet As Worksheet
    Dim cleanedSheet As Worksheet
    Dim dataRange As Range
    Dim cellValues As Variant
    Dim i As Long, j As Long
    Dim cleanedCount As Long
    Dim firstAddress As String, lastAddress As String
    Dim cellText As String
    Dim baseName As String, newName As String
    Dim suffix As Integer
    Dim rowCount As Long, colCount As Long
    Dim tbl As ListObject

    ' Disable visual/processing overhead
    Application.ScreenUpdating = False
    Application.Calculation = xlCalculationManual
    Application.EnableEvents = False

    On Error GoTo CleanupWithError

    ' Reference active sheet
    Set originalSheet = ActiveSheet

    ' Exit if sheet has no used range
    If WorksheetFunction.CountA(originalSheet.UsedRange) = 0 Then
        MsgBox "The sheet appears to be empty.", vbInformation, "No Action"
        GoTo Cleanup
    End If

    ' Duplicate the sheet
    originalSheet.Copy After:=originalSheet
    Set cleanedSheet = ActiveSheet

    ' Unique sheet name
    baseName = originalSheet.Name & " - Cleaned"
    newName = baseName
    suffix = 1
    Do While SheetExists(newName)
        newName = baseName & " (" & suffix & ")"
        suffix = suffix + 1
        If suffix > 100 Then Err.Raise 9999, , "Too many duplicate sheet names."
    Loop
    cleanedSheet.Name = newName

    ' Get used range
    Set dataRange = cleanedSheet.UsedRange
    rowCount = dataRange.Rows.Count
    colCount = dataRange.Columns.Count

    If rowCount * colCount > 1000000 Then Err.Raise 9999, , "Range too large to safely process."

    ' Load values into memory
    If dataRange.Cells.Count = 1 Then
        ReDim cellValues(1 To 1, 1 To 1)
        cellValues(1, 1) = dataRange.Value
    Else
        cellValues = dataRange.Value
    End If

    cleanedCount = 0

    ' Loop through cells
    For i = 1 To UBound(cellValues, 1)
        For j = 1 To UBound(cellValues, 2)
            If Not IsError(cellValues(i, j)) Then
                If VarType(cellValues(i, j)) = vbString Then
                    cellText = Replace(cellValues(i, j), ChrW(160), " ") ' Remove non-breaking space
                    cellText = Trim(cellText)
                    If cellText = "" Then
                        If cleanedCount = 0 Then firstAddress = dataRange.Cells(i, j).Address
                        lastAddress = dataRange.Cells(i, j).Address
                        cellValues(i, j) = Empty
                        cleanedCount = cleanedCount + 1
                    End If
                End If
            End If
        Next j
    Next i

    ' Write cleaned values back
    If cleanedCount > 0 Then
        dataRange.Value = cellValues
        MsgBox cleanedCount & " cell(s) were cleared on '" & cleanedSheet.Name & "' in range " & firstAddress & " to " & lastAddress, vbInformation, "Success"
    Else
        MsgBox "No cells with empty strings were found on the copied sheet.", vbInformation, "No Action"
    End If

    ' --- NEW: Create a table named "CLEAN" ---
    On Error Resume Next
    For Each tbl In cleanedSheet.ListObjects
        tbl.Unlist ' Remove existing tables
    Next tbl
    On Error GoTo 0

    Set dataRange = cleanedSheet.UsedRange
    Set tbl = cleanedSheet.ListObjects.Add(xlSrcRange, dataRange, , xlYes)
    tbl.Name = "CLEAN"

Cleanup:
    ' Restore settings
    Application.ScreenUpdating = True
    Application.Calculation = xlCalculationAutomatic
    Application.EnableEvents = True
    Exit Sub

CleanupWithError:
    MsgBox "An error occurred: " & Err.Description, vbExclamation, "Error"
    Resume Cleanup
End Sub

Function SheetExists(sheetName As String) As Boolean
    Dim ws As Worksheet
    On Error Resume Next
    Set ws = ThisWorkbook.Sheets(sheetName)
    SheetExists = Not ws Is Nothing
    On Error GoTo 0
End Function

