let
    Source = SharePoint.Files("https://hisoregon.sharepoint.com/sites/HISDataAnalytics/", [ApiVersion = 15]),
    #"UCT Fiscal Calendar 2020-2031 xlsx_https://hisoregon sharepoint com/sites/HISDataAnalytics/Shared Documents/Business Intelligence/Excel Workbooks/" = Source{[Name="UCT Fiscal Calendar 2020-2031.xlsx",#"Folder Path"="https://hisoregon.sharepoint.com/sites/HISDataAnalytics/Shared Documents/Business Intelligence/Excel Workbooks/"]}[Content],
    #"Imported Excel Workbook" = Excel.Workbook(#"UCT Fiscal Calendar 2020-2031 xlsx_https://hisoregon sharepoint com/sites/HISDataAnalytics/Shared Documents/Business Intelligence/Excel Workbooks/"),
    CALENDAR_Table = #"Imported Excel Workbook"{[Item="CALENDAR",Kind="Table"]}[Data]
in
    CALENDAR_Table
