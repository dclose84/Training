Sub FormatForecastReport()
'
' FormatForecastReport Macro
' Format the Forecast Report as it is exported out of GSS.
'

'
    ' This will remove the forecast ID and the top forecast date
    Columns("B:B").Select
    Application.CutCopyMode = False
    Selection.Delete Shift:=xlToLeft
    Rows("1:1").Select
    Selection.Delete Shift:=xlUp
    Range("A3").Select
    ActiveCell.Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    
    ' This will remove all of the excessive headers from the raw export
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp
    ActiveCell.Offset(1, 0).Rows("1:2").EntireRow.Select
    Selection.Delete Shift:=xlUp

    ' This will rename the columns and add the formula for the Xlookup to pull price data from inventory estended status dashboard
    Range("A1").Select
    ActiveCell.FormulaR1C1 = "Customer"
    Range("B1").Select
    ActiveCell.FormulaR1C1 = "Part"
    Range("D1").Select
    ActiveCell.FormulaR1C1 = "Description"
    Range("E1").Select
    ActiveCell.FormulaR1C1 = "Forecast Source"
    Range("F1").Select
    ActiveCell.FormulaR1C1 = "Initial Date"
    Range("G1").Select
    ActiveCell.FormulaR1C1 = "Date"
    Range("H1").Select
    ActiveCell.FormulaR1C1 = "Quantity"
    Range("I1").Select
    ActiveCell.FormulaR1C1 = "Consumed"
    Range("J1").Select
    ActiveCell.FormulaR1C1 = "Forecast Catalog"
    Range("K1").Select
    ActiveCell.FormulaR1C1 = "PL"
    Range("L1").Select
    ActiveCell.FormulaR1C1 = "Unit Price"
    Range("M1").Select
    ActiveCell.FormulaR1C1 = "Extension"
    
         ' Turn range into table
    Range("A1").Select
    Range(Selection, Selection.End(xlToRight)).Select
    Range(Selection, Selection.End(xlDown)).Select
    ActiveSheet.ListObjects.Add(xlSrcRange, Range("$A$1:$M$999"), , xlYes).Name = _
        "Forecast_Summary"
    
    ' After the repeating headers have been removed, this will format the existing range
    Range("A1").Select
    Cells.Select
    Cells.EntireColumn.AutoFit
    Cells.EntireRow.AutoFit
    Range("A1").Select
    
    ' Remove empty rows
    Range("A2").Select
    Selection.End(xlDown).Select
    ActiveCell.Offset(1, 0).Select
    Range(Selection, Selection.End(xlToRight)).Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.EntireRow.Delete
    
    ' Add formulas
    Range("K2").Select
    ActiveCell.Formula2R1C1 = _
        "=XLOOKUP(TRIM([@Part]),TRIM(Inv_Ext_Status[Part]),Inv_Ext_Status[PL],FIX PL)"
    Range("L2").Select
    ActiveCell.Formula2R1C1 = _
        "=XLOOKUP(TRIM([@Part]),TRIM(Inv_Ext_Status[Part]),Inv_Ext_Status[Price],0)"
    Range("M2").Select
    ActiveCell.FormulaR1C1 = _
        "=IFERROR([@Quantity]*[@[Unit Price]],0)"
    
    ' Conditional format to highlight blanks (0's)
    Range("L2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Range("Forecast_Summary[[Unit Price]:[Extension]]").Select
    Selection.FormatConditions.Add Type:=xlCellValue, Operator:=xlEqual, _
        Formula1:="=0"
    Selection.FormatConditions(Selection.FormatConditions.Count).SetFirstPriority
    With Selection.FormatConditions(1).Font
        .Color = -16383844
        .TintAndShade = 0
    End With
    With Selection.FormatConditions(1).Interior
        .PatternColorIndex = xlAutomatic
        .Color = 13551615
        .TintAndShade = 0
    End With
    Selection.FormatConditions(1).StopIfTrue = False
    
    '
    ' This is the part to paste in forecast summary into Daily Flash Tab
    '
    
    ' Paste in Customer #
    Range("A2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.Copy
    Sheets("DAILY FLASH").Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    
    ' Paste in Description
    Sheets("FORECAST SUMMARY").Select
    Range("D2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Application.CutCopyMode = False
    Selection.Copy
    Sheets("DAILY FLASH").Select
    Range("C2").Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    
    ' Paste in Part
    Sheets("FORECAST SUMMARY").Select
    Range("B2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Application.CutCopyMode = False
    Selection.Copy
    Sheets("DAILY FLASH").Select
    Range("D2").Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    
    ' Paste in BO Qty
    Sheets("FORECAST SUMMARY").Select
    Range("H2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Application.CutCopyMode = False
    Selection.Copy
    Sheets("DAILY FLASH").Select
    Range("K2").Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    
    ' Paste in Extension $
    Sheets("FORECAST SUMMARY").Select
    Range("M2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Application.CutCopyMode = False
    Selection.Copy
    Sheets("DAILY FLASH").Select
    Range("L2").Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    
    ' Paste in Unit Price $
    Sheets("FORECAST SUMMARY").Select
    Range("L2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Application.CutCopyMode = False
    Selection.Copy
    Sheets("DAILY FLASH").Select
    Range("M2").Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    
    ' Paste in PL
    Sheets("FORECAST SUMMARY").Select
    Range("K2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Application.CutCopyMode = False
    Selection.Copy
    Sheets("DAILY FLASH").Select
    Range("P2").Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    
    ' Paste in Ship Date
    Sheets("FORECAST SUMMARY").Select
    Range("F2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Application.CutCopyMode = False
    Selection.Copy
    Sheets("DAILY FLASH").Select
    Range("Y2").Select
    ActiveSheet.Paste
    
    ' Add FORECAST to comments column
    Range("AB2").Select
    Application.CutCopyMode = False
    ActiveCell.FormulaR1C1 = "FORECAST"
    Range("AB2").Select
    Selection.AutoFill Destination:=Range("Daily_Flash_Open_Orders[Comments]")
    Range("Daily_Flash_Open_Orders[Comments]").Select
    
    ' Select entire table to be ready to paste into [Daily Flash 'Open Orders'] tab
    Sheets("FORECAST SUMMARY").Select
    Range("A1").Select
    
    Sheets("DAILY FLASH").Select
    Range("A2").Select
    Range("A2:AB2").Select
    Range(Selection, Selection.End(xlDown)).Select
    
    ' Tada!
End Sub


