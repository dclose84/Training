let
    // Get start/end from your named table
    Source = Excel.CurrentWorkbook(){[Name="START_END"]}[Content],
    StartDate = Number.From(Source[Values]{0}),
    EndDate = Number.From(Source[Values]{1}),

    // Generate list of dates
    DateList = {StartDate..EndDate},
    DateTable = Table.FromList(DateList, Splitter.SplitByNothing(), {"DateKey"}),
    ChangedType = Table.TransformColumnTypes(DateTable, {{"DateKey", type date}}),

    // Add standard columns
    AddDateAsInteger = Table.AddColumn(ChangedType, "DateAsInteger", each Date.ToText([DateKey], "yyyyMMdd"), type text),
    AddDateTimeKey = Table.AddColumn(AddDateAsInteger, "DateTimeKey", each DateTime.From([DateKey]), type datetime),
    AddDateID = Table.AddIndexColumn(AddDateTimeKey, "DateID", 1, 1, Int64.Type),
    AddYear = Table.AddColumn(AddDateID, "Year", each Date.Year([DateKey]), Int64.Type),
    AddMonthNum = Table.AddColumn(AddYear, "Month", each Date.Month([DateKey]), Int64.Type),
    AddMonthName = Table.AddColumn(AddMonthNum, "MonthName", each Date.ToText([DateKey], "MMMM"), type text),
    AddQuarterNum = Table.AddColumn(AddMonthName, "Quarter", each Date.QuarterOfYear([DateKey]), Int64.Type),
    AddQuarterName = Table.AddColumn(AddQuarterNum, "QuarterName", each "Q" & Text.From([Quarter]), type text),
    AddWeekOfYear = Table.AddColumn(AddQuarterName, "WeekOfYear", each Date.WeekOfYear([DateKey]), Int64.Type),
    AddDay = Table.AddColumn(AddWeekOfYear, "Day", each Date.Day([DateKey]), Int64.Type),
    AddDayOfWeek = Table.AddColumn(AddDay, "DayOfWeek", each Date.DayOfWeek([DateKey]), Int64.Type),
    AddDayOfWeekName = Table.AddColumn(AddDayOfWeek, "DayOfWeekName", each Date.ToText([DateKey], "dddd"), type text),
    AddIsWeekend = Table.AddColumn(AddDayOfWeekName, "IsWeekend", each if Date.DayOfWeek([DateKey], Day.Monday) >= 5 then true else false, type logical)
in
    AddIsWeekend
