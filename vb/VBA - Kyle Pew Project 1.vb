VBA - Kyle Pew Project 1

Public Sub FunWithLogic()
    ' IF logic to determine age
    If ActiveCell.Value >= 90 Then
        MsgBox ("User is 90 or older")
    ElseIf ActiveCell.Value >= 21 Then
        MsgBox ("User is 21 or older")
    Else
        MsgBox ("Not Allowed!")
    End If
End Sub

Public Sub FunWithSelect()
    Select Case ActiveCell.Value
        Case Is > 90
            MsgBox (">90")
        Case 21 To 89
            MsgBox (">21")
        Case Else
            MsgBox ("Not Allowed")
    End Select
End Sub

Public Sub FunWithLoops()
    Dim i As Integer
    i = 1
    
    Do While i <= 10
        FunWithLogic
        
        'this moves the active cell down 1, and over 0 after running
        ActiveCell.Offset(1, 0).Select
        
    
        'increase the variable, i, by 1 each time it loops
        i = i + 1
    Loop
End Sub

Public Sub FunWithLoops()
    Dim i As Integer
    i = 1
    
    Do While ActiveCell.Value <> "" 'i <= 10
        'call the procedure called FunWithLogic
        FunWithLogic
        
        'this moves the active cell down 1, and over 0 after running
        ActiveCell.Offset(1, 0).Select
        
    
        'increase the variable, i, by 1 each time it loops
        i = i + 1
    Loop
End Sub

Public Sub FunWithLoops()
    Dim i As Integer
    i = 1
    
    Dim user As Range
    
    For Each user In Selection
    
    'Do While ActiveCell.Value <> "" 'i <= 10
        'call the procedure called FunWithLogic
        FunWithLogic
        
        'this moves the active cell down 1, and over 0 after running
        ActiveCell.Offset(1, 0).Select
        
    
        'increase the variable, i, by 1 each time it loops
        'i = i + 1
    'Loop
    Next user
End Sub

Public Sub FunWithLoops()
    Dim i As Integer
    'i = 1
    
    'Dim user As Range
    
    For i = 1 To ActiveSheet.UsedRange.Rows.Count - 1
    'For Each user In Selection
    'Do While ActiveCell.Value <> "" 'i <= 10
        'call the procedure called FunWithLogic
        FunWithLogic
        
        'this moves the active cell down 1, and over 0 after running
        ActiveCell.Offset(1, 0).Select
        
    
        'increase the variable, i, by 1 each time it loops
        'i = i + 1
    'Loop
    'Next user
    Next i
End Sub


Public Sub FunWithInputBox()
    ' get input from user
    Dim userInput As String
    
    userInput = InputBox("What is your favorite color?", "Favorite Color")
    
    MsgBox (userInput)
    
End Sub

Public Sub UserSortInput()
    ' get the sort order from the user
    Dim sortOrder As Integer
    Dim promptMSG As String
    Dim tryAgain As Integer
    
    'this creates the error check for non integer's
    On Error GoTo errHandler
    
    'vbCrLf is text wrap when used with the amp and underscore
    promptMSG = "How would you like to sort the list?" & vbCrLf & _
    "1 - Sort by Division" & vbCrLf & _
    "2 - Sort by Category" & vbCrLf & _
    "3 - Sort by Total"

    sortOrder = InputBox(promptMSG, "Sort Order")
    
    
    If sortOrder = 1 Then
        DivisionSort
    ElseIf sortOrder = 2 Then
        CategorySort
    ElseIf sortOrder = 3 Then
        TotalSort
    'what if something incorrect is entered?
    Else
errHandler:
        tryAgain = MsgBox("Invalid Value! Try Again?", vbYesNo)
        
        If tryAgain = 6 Then
            UserSortInput
        End If
    End If
End Sub

Public Sub DivisionSort()
    ' sorts the list by the division
    Columns("A:F".Sort key1:=Range("A2")), order1:=xlDescending, Header:=xlYes
End Sub

Public Sub CategorySort()
    ' sorts the list by the division
    Columns("A:F".Sort key1:=Range("B2")), order1:=xlDescending, Header:=xlYes
End Sub

Public Sub TotalSort()
    ' sorts the list by the division
    Columns("A:F".Sort key1:=Range("F2")), order1:=xlDescending, Header:=xlYes
End Sub
