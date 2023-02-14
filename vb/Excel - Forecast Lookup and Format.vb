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
    ' If there is still more formatting needed, copy and paste more of the below in
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
    ActiveCell.FormulaR1C1 = "Quantitiy"
    Range("I1").Select
    ActiveCell.FormulaR1C1 = "Consumed"
    Range("J1").Select
    ActiveCell.FormulaR1C1 = "Forecast Catalog"
    Range("K1").Select
    ActiveCell.FormulaR1C1 = "Price"
    Range("L1").Select
    ActiveCell.FormulaR1C1 = "PL"
    Range("K2").Select
    
    ' Add a row of the desired xlookup formulas to reference the inventory dashboard
    ActiveCell.Formula2R1C1 = _
        "=XLOOKUP(TRIM(RC[-9]),TRIM('INV EXT STATUS DASH'!R2C1:R999999C1),'INV EXT STATUS DASH'!R2C22:R999999C22,0)"
    Range("L2").Select
    ActiveCell.Formula2R1C1 = _
        "=XLOOKUP(TRIM(RC[-10]),TRIM('INV EXT STATUS DASH'!R2C1:R999999C1),'INV EXT STATUS DASH'!R2C8:R999999C8,0)"
    
    ' After the repeating headers have been removed, this will format the existing range
    Range("A1").Select
    Cells.Select
    Cells.EntireColumn.AutoFit
    Cells.EntireRow.AutoFit
    Range("A1").Select
End Sub
