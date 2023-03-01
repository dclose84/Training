VBA - Kyle Pew Project 6 (user forms)

Private Sub btnAddWorksheet_Click()
    Worksheets.Add before:=Worksheets(1)
    
    ActiveSheet.Name = InputBox("Please enter a new worksheet name")
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