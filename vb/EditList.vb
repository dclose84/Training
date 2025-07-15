Sub EditList()
    Dim ws As Worksheet
    Dim tbl As ListObject
    Dim rng As Range
    Dim newSheet As Worksheet
    Dim colHeaders As Variant
    Dim csvHeaders As Variant
    Dim i As Long

    ' Step 1: Rename active sheet to "Working"
    Set ws = ActiveSheet
    ws.Name = "Working"

    ' Step 2: Clear formatting from used range
    Set rng = ws.UsedRange
    With rng
        .Borders.LineStyle = xlNone
        .Interior.ColorIndex = xlColorIndexNone
        .Font.ColorIndex = xlColorIndexAutomatic
        .Font.Bold = False
        .Font.Underline = xlUnderlineStyleNone
    End With

    ' Step 3: Create table and name it "WORKING"
    On Error Resume Next
    Set tbl = ws.ListObjects(1)
    If Not tbl Is Nothing Then tbl.Unlist ' Remove existing table if present
    On Error GoTo 0

    Set rng = ws.UsedRange
    Set tbl = ws.ListObjects.Add(xlSrcRange, rng, , xlYes)
    tbl.Name = "WORKING"

    ' Step 4: Add columns to end of table
    colHeaders = Array( _
        "First_Name_Short", "First_Name", "Middle_Name", "Last_Name", "Suffix_Name", _
        "Greeting", "Gender", "Birth Year", "Birth Month", "Birth Day of Month", _
        "Derived_Email", "CSV_Email", "Union", "Local", "Bargaining_Unit", "Pin_Color", _
        "Union_Local", "Employer", "Employer_Type", "Worker_Type", _
        "Work_Address", "Work_City", "Work_State", "Work_Zip", "Work_County")

    For i = LBound(colHeaders) To UBound(colHeaders)
        tbl.ListColumns.Add
        tbl.HeaderRowRange(1, tbl.ListColumns.Count).Value = colHeaders(i)
    Next i

    ' Step 5: Create "CSV" sheet with defined headers
    Set newSheet = Worksheets.Add(After:=ws)
    newSheet.Name = "CSV"

    csvHeaders = Array("First Name", "Last Name", "Email", "Union")
    For i = LBound(csvHeaders) To UBound(csvHeaders)
        newSheet.Cells(1, i + 1).Value = csvHeaders(i)
    Next i

    ' Step 6: Return to Working sheet
    ws.Activate
End Sub


