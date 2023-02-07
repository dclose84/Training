VBA - Kyle Pew Project 2 (loops)


Sub InsertHeaders()
'
' InsertHeaders Macro
' Inserts a new row and adds the list headers.
'

'
    Rows("1:1").Select
    Calculate
    Rows("1:1").Select
    Selection.Insert Shift:=xlDown
    Range("A1").Select
    ActiveCell.FormulaR1C1 = "Division"
    Range("B1").Select
    ActiveCell.FormulaR1C1 = "Category"
    Range("C1").Select
    ActiveCell.FormulaR1C1 = "Jan"
    Range("D1").Select
    ActiveCell.FormulaR1C1 = "Feb"
    Range("E1").Select
    ActiveCell.FormulaR1C1 = "Mar"
    Range("F1").Select
    ActiveCell.FormulaR1C1 = "Total"
    Range("A2").Select
End Sub


Sub FormatHeaders()
'
' FormatHeaders Macro
' Formats list headers and list content.
'

'
    Range("A1:F1").Select
    Selection.Font.Bold = True
    Selection.Font.Size = 12
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 15773696
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Range("C2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Range(Selection, Selection.End(xlToRight)).Select
    Selection.Style = "Currency"
    Columns("B:F").Select
    Columns("B:F").EntireColumn.AutoFit
End Sub
