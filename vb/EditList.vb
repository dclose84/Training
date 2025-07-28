Sub EditList()
    Dim ws As Worksheet
    Dim tbl As ListObject
    Dim rng As Range
    Dim colHeaders As Variant
    Dim i As Long
    Dim colMap As Object
    Dim colName As String

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
        .WrapText = False
        .Font.Name = "Calibri"
        .Font.Size = 11
    End With

    ' Auto-fit columns and rows
    rng.Columns.AutoFit
    rng.Rows.AutoFit

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
        "Greeting", "Birth Year", "Birth Month", "Birth Day of Month", "Gender", _
        "Supplied_Email", "Derived_Email", "Union", "Local", "Bargaining_Unit", "Pin_Color", _
        "Employer", "Employer_Type", "Worker_Type", _
        "Work_Address", "Work_City", "Work_State", "Work_Zip", "Work_County")

    For i = LBound(colHeaders) To UBound(colHeaders)
        tbl.ListColumns.Add
        tbl.HeaderRowRange(1, tbl.ListColumns.Count).Value = colHeaders(i)
    Next i

    ' Step 5: Insert formulas into specific columns
    Set colMap = CreateObject("Scripting.Dictionary")

    colMap.Add "Gender", "=XLOOKUP([@Greeting],'Basic Tables.xlsm'!GENDER[Name],'Basic Tables.xlsm'!GENDER[Gender],"""")"
    colMap.Add "Last_Name", "=PROPER([@[Last Name]])"
    colMap.Add "First_Name_Short", "=PROPER(IF(ISNUMBER(FIND("" "", [@[First Name]])), MID([@[First Name]], FIND("" "", [@[First Name]]) + 1, LEN([@[First Name]]) - FIND("" "", [@[First Name]])), """"))"
    colMap.Add "First_Name", "=PROPER(LEFT([@[First Name]], FIND("" "", [@[First Name]] & "" "") - 1))"
    colMap.Add "Middle_Name", "=PROPER(IFS(AND([@[First_Name_Short]]="""", [@[Middle]]=""""), """",[@[First_Name_Short]]="""", [@[Middle]], AND([@[First_Name_Short]]<>"""", [@[Middle]]=""""), [@[First_Name_Short]], AND([@[First_Name_Short]]<>"""", [@[Middle]]<>""""), CONCAT([@[First_Name_Short]],"" "",[@[Middle]])))"

    For Each colName In colMap.Keys
        On Error Resume Next
        If Not tbl.ListColumns(colName) Is Nothing Then
            If Not tbl.ListColumns(colName).DataBodyRange Is Nothing Then
                tbl.ListColumns(colName).DataBodyRange.Formula = colMap(colName)
            End If
        End If
        On Error GoTo 0
    Next colName

    ' Step 6: Return to Working sheet
    ws.Activate
End Sub
