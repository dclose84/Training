VBA - Kyle Pew Project 6 (Importing Data from Text Files)

Public Sub ImportTextFile()
    Dim TextFile As Workbook
    ' () denotes an array
    Dim OpenFiles() As Variant
    
    OpenFiles = Application.GetOpenFilename(Title:="Select File(s) to Import", MultiSelect:=True)
    
    ' set makes this an excel object
    Set TextFile = Workbooks.Open(OpenFiles(1))
    
    ' Copy the newly created workbook of the import into the existing original workbook
    TextFile.Sheets(1).Range("A1").CurrentRegion.Copy
    ' demo was saying Workbooks(1), but since PERSONAL worksheet exists, that is Workbooks(1), had to change to Workbooks(2)
    Workbooks(2).Activate
    ActiveSheet.Paste
    
    ' close out the text file that was created
    TextFile.Close
    
End Sub
