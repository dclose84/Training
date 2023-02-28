Sub dfFormat()
'
' dfFormat Macro
' Format the Daily Flash Export
'

    ' Clean up Booking worksheet
    Cells.Select
    Cells.EntireColumn.AutoFit
    Cells.EntireRow.AutoFit
    
    Sheets("Sheet1").Select
        Sheets("Sheet1").Name = "BOOKINGS"
            Sheets.Add After:=ActiveSheet
    
    ' Add and rename new worksheets
    Sheets("Sheet1").Select
        Sheets("Sheet1").Name = "OPEN ORDERS"
            Sheets.Add After:=ActiveSheet
    
    Sheets("Sheet2").Select
        Sheets("Sheet2").Name = "QUOTES"
            Sheets.Add After:=ActiveSheet
    
    Sheets("Sheet3").Select
        Sheets("Sheet3").Name = "INVOICING"
            Sheets.Add After:=ActiveSheet
    
    Sheets("Sheet4").Select
        Sheets("Sheet4").Name = "VALUES"
            Sheets.Add After:=ActiveSheet
        
    Sheets("Sheet5").Select
        Sheets("Sheet5").Name = "INV EXT STATUS"
            Sheets.Add After:=ActiveSheet
        
    Sheets("Sheet6").Select
        Sheets("Sheet6").Name = "FORECAST SUMMARY"
            Sheets.Add After:=ActiveSheet
        
    Sheets("Sheet7").Select
        Sheets("Sheet7").Name = "DAILY FLASH FORECAST"
        
    ' Add values to be filled out
    Sheets("VALUES").Select
    ActiveCell.FormulaR1C1 = "1110 (D)"
        Range("A2").Select
    ActiveCell.FormulaR1C1 = "2010 (Q)"
        Range("A3").Select
    ActiveCell.FormulaR1C1 = "2015 (R)"
        Range("A4").Select
    ActiveCell.FormulaR1C1 = "Values (P)"
        Range("A6").Select
    ActiveCell.FormulaR1C1 = "Alterna (I)"
        Range("A7").Select
    ActiveCell.Formula2R1C1 = "Karina - Invoicing/Sales"
        Range("A8").Select
    ActiveCell.Formula2R1C1 = "First Republic (J/K)"
        Range("A9").Select
    ActiveCell.Formula2R1C1 = "Key Bank (L/M)"
        Range("A10").Select
        
    ' Format column sizing/spacing
    Range("A1").Select
    Cells.Select
    Cells.EntireColumn.AutoFit
    Columns("B:B").ColumnWidth = 16
    Cells.EntireRow.AutoFit
    Range("B1").Select



End Sub