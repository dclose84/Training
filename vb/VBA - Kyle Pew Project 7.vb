VBA - Kyle Pew Project 6 (Importing Data from Text Files)

Public Sub ImportTextFile()
    Dim TextFile As Workbook
    ' () denotes an array
    Dim OpenFiles() As Variant
    Dim i As Integer
    
    OpenFiles = GetFiles()
    
    ' this prevents the screen flicker associated with open/closing files, and is turned back on at the end
    Application.ScreenUpdating = False
    
    ' create the loop
    For i = 1 To Application.CountA(OpenFiles)
    
        ' set makes this an excel object
        Set TextFile = Workbooks.Open(OpenFiles(i))
        
        ' Copy the newly created workbook of the import into the existing original workbook
        TextFile.Sheets(1).Range("A1").CurrentRegion.Copy
        ' demo was saying Workbooks(1), but since PERSONAL worksheet exists, that is Workbooks(1), had to change to Workbooks(2)
        Workbooks(2).Activate
        Workbooks(2).Worksheets.Add
        ActiveSheet.Paste
        ' rename the newly created sheet
        ActiveSheet.Name = TextFile.Name
        
        ' clear the clipboard error
        Application.CutCopyMode = False
        
        ' close out the text file that was created
        TextFile.Close
    Next i
    
    Application.ScreenUpdating = True
End Sub

Public Function GetFiles() As Variant
    ' This creates the previous OpenFiles sub procedure as a function so this is reuseable
     GetFiles = Application.GetOpenFilename(Title:="Select File(s) to Import", MultiSelect:=True)
End Function
