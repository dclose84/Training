Sub dfFormat()
'
' dfFormat Macro
' Format the Daily Flash Export
'

'
    Cells.Select
    Cells.EntireColumn.AutoFit
    Cells.EntireRow.AutoFit
    
    Sheets("Sheet1").Select
        Sheets("Sheet1").Name = "BOOKING"
            Sheets.Add After:=ActiveSheet
    
    Sheets("Sheet2").Select
        Sheets("Sheet2").Name = "SALES"
            Sheets.Add After:=ActiveSheet
    
    Sheets("Sheet3").Select
        Sheets("Sheet3").Name = "QUOTE"
            Sheets.Add After:=ActiveSheet
    
    Sheets("Sheet4").Select
        Sheets("Sheet4").Name = "INVOICING"
            Sheets.Add After:=ActiveSheet
    
    Sheets("Sheet5").Select
        Sheets("Sheet5").Name = "VALUES"
        
    ' add values to be filled out
    ActiveCell.FormulaR1C1 = "1110"
        Range("A2").Select
    ActiveCell.FormulaR1C1 = "2010"
        Range("A3").Select
    ActiveCell.FormulaR1C1 = "2015"
        Range("A4").Select
    ActiveCell.FormulaR1C1 = "Values"
        Range("A5").Select
    Sheets("SALES").Select
End Sub

