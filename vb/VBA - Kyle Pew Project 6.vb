VBA - Kyle Pew Project 6 (user forms)

Sub LoopYearlyReport()
    Dim ws As Worksheet
    Dim firstTime As Boolean
    
    firstTime = True
    
    For Each ws In Worksheets
        Worksheets(ws.Name).Select
        
        If ws.Name <> "YEARLY REPORT" And ActiveSheet.Range("A1").Value <> "" Then
        
            InsertHeaders
            FormatHeaders
            AutomateTotalSUM
            
            ' select current data
            Range("A2").Select
            Range(Selection, Selection.End(xlDown)).Select
            Range(Selection, Selection.End(xlToRight)).Select
            
            ' copy data
            Selection.Copy
            
            ' select yearly report
            Worksheets("YEARLY REPORT").Select
            
            ' paste data
            Range("A30000").Select
            Selection.End(xlUp).Select
            
                If firstTime <> True Then
                    ActiveCell.Offset(1, 0).Select
                Else
                    firstTime = False
                End If
            
            ActiveSheet.Paste
            
        End If
    ' move to the next sheet in the loop
    Next ws
    
    Worksheets("YEARLY REPORT").Select
    InsertHeaders
    FormatHeaders
    AutomateTotalSUM
    
End Sub

Public Sub AutomateTotalSUM()
    Dim lastCell As String
    Dim ws As Worksheet

    'For Each ws In Worksheets
        'Worksheets(ws.Name).Select
        
        Range("F2").Select
        
        Selection.End(xlDown).Select
        
        lastCell = ActiveCell.Address(False, False)
        
        ActiveCell.Offset(1, 0).Select
        
        ActiveCell.Value = "=sum(F2:" & lastCell & ")"
    'Next ws
End Sub

Sub InsertHeaders()
'
' InsertHeaders Macro
' Inserts a new row and add the list headers
'

'
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
' Formats list headers and list content
'

'
    Range("A1:F1").Select
    Selection.Font.Bold = True
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .ThemeColor = xlThemeColorAccent1
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    Selection.Borders(xlEdgeLeft).LineStyle = xlNone
    Selection.Borders(xlEdgeTop).LineStyle = xlNone
    With Selection.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlMedium
    End With
    Selection.Borders(xlEdgeRight).LineStyle = xlNone
    Selection.Borders(xlInsideVertical).LineStyle = xlNone
    Selection.Borders(xlInsideHorizontal).LineStyle = xlNone
    Selection.Font.Size = 12
    Range("C2").Select
    Range(Selection, Selection.End(xlDown)).Select
    Range(Selection, Selection.End(xlToRight)).Select
    Selection.Style = "Currency"
    Columns("B:F").Select
    Columns("B:F").EntireColumn.AutoFit
    Range("A2").Select
End Sub


' Forms section

Private Sub btnAddWorksheet_Click()
    ' variable for the tryAgain logic below
    Dim tryAgain As Integer
 
    ' if the user leaves the box empty go to the error handler section
    On Error GoTo errHandler
    
    Worksheets.Add before:=Worksheets(1)
    
    ActiveSheet.Name = InputBox("Please enter a new worksheet name")
    
    ' if no error skip the errHandler
    Exit Sub
    
 ' error handler section
errHandler:
    ' prompt the user to try again
    tryAgain = MsgBox("Invalid Worksheet Name", vbYesNo)
    
    ' if the user picked yes
    If tryAgain = 6 Then
        're-run the procedure
        btnAddWorksheet_Click
    Else
        ' turn off the alert of deleting the worksheet if the user selects no
        Application.DisplayAlerts = False
        
        ' delete the invalid worksheet
        ActiveSheet.Delete
    End If
End Sub

Private Sub btnRunReport_Click()
    LoopYearlyReport
End Sub

Private Sub cboWhichSheet_Change()
    Worksheets(Me.cboWhichSheet.Value).Select
End Sub

Private Sub UserForm_Click()
    MsgBox ("Hello World!")
End Sub

Private Sub UserForm_Initialize()
   Dim i As Integer
   
   i = 1
   
   Do While i <= Worksheets.Count
        Me.cboWhichSheet.AddItem Worksheets(i).Name
        
        i = i + 1
   Loop
End Sub
