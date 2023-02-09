VBA - Kyle Pew Project 4 (functions)

Public Sub AutomateTotalSUM()
' find last cell for automating macros
    Dim lastCell As String
    Dim ws As Worksheet
    
    ' create the loop to automate
    For Each ws In Worksheets
        Worksheets(ws.Name).Select
        
        Range("F2").Select
        
        ' this finds the last cell with values (similar to ctl+down)
        Selection.End(xlDown).Select
        
        ' this records the location of the last cell
            ' false, false changes from absolute reference to relative reference
        lastCell = ActiveCell.Address(False, False)
        
        ' move 1 cell down
        ActiveCell.Offset(1, 0).Select
        
        ' to call the variable, "& VAR &"
        ActiveCell.Value = "=sum(F2:" & lastCell & ")"
    Next ws
End Sub
