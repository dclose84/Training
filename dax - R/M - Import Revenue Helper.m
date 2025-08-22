let
    Source = SharePoint.Files("https://hisoregon.sharepoint.com/sites/HISDataAnalytics/", [ApiVersion = 15]),
    #"Revenue Helper xlsx_https://hisoregon sharepoint com/sites/HISDataAnalytics/Shared Documents/Business Intelligence/Excel Workbooks/" = Source{[Name="Revenue Helper.xlsx",#"Folder Path"="https://hisoregon.sharepoint.com/sites/HISDataAnalytics/Shared Documents/Business Intelligence/Excel Workbooks/"]}[Content],
    #"Imported Excel Workbook" = Excel.Workbook(#"Revenue Helper xlsx_https://hisoregon sharepoint com/sites/HISDataAnalytics/Shared Documents/Business Intelligence/Excel Workbooks/"),
    RevClass_Table = #"Imported Excel Workbook"{[Item="RevClass",Kind="Table"]}[Data]
in
    RevClass_Table
