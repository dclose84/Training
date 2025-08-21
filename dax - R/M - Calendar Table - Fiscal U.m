let
    Source = Excel.CurrentWorkbook(){[Name="START_END"]}[Content],
    StartDate = Number.From(Source[Values] {0}),
    EndDate = Number.From(Source[Values] {1}),
    #"Custom List DateKey" = {StartDate..EndDate},
    #"Converted to Table" = Table.FromList(#"Custom List DateKey", Splitter.SplitByNothing(), null, null, ExtraValues.Error),
    #"Changed Type DATE" = Table.TransformColumnTypes(#"Converted to Table",{{"Column1", type date}}),
    #"Renamed Columns DateKey" = Table.RenameColumns(#"Changed Type DATE",{{"Column1", "DateKey"}}),
    #"Added Custom DateAsInteger" = Table.AddColumn(#"Renamed Columns DateKey", "DateAsInteger", each Date.ToText([DateKey], "yyyyMMdd")),
    #"Added Custom DateTimeKey" = Table.AddColumn(#"Added Custom DateAsInteger", "DateTimeKey", each DateTime.FromText(Text.From([DateKey]))),
    #"Changed Type DATETIME" = Table.TransformColumnTypes(#"Added Custom DateTimeKey",{{"DateTimeKey", type datetime}}),
    #"Added Index DateID" = Table.AddIndexColumn(#"Changed Type DATETIME", "DateID", 1, 1, Int64.Type),
    #"Added Custom WeekID" = Table.AddColumn(#"Added Index DateID", "WeekID", each Number.RoundDown(([DateID] - 1) / 7) + 1, Int64.Type),
    #"Added Custom MonthID" = Table.AddColumn(#"Added Custom WeekID", "MonthID", each Number.RoundDown([DateID]/91)*3 +
(if Number.Mod([DateID],91)=0 then 0
else if Number.Mod([DateID],91)<=28 then 1
else if Number.Mod([DateID],91)<=56 then 2
else 3),Int64.Type),
    #"Added Custom QuarterID" = Table.AddColumn(#"Added Custom MonthID", "QuarterID", each 
    // Fiscal Year 2020
    if [DateKey] >= #date(2019, 12, 28) and [DateKey] <= #date(2020, 03, 27) then 1
    else if [DateKey] >= #date(2020, 03, 28) and [DateKey] <= #date(2020, 06, 26) then 2
    else if [DateKey] >= #date(2020, 06, 27) and [DateKey] <= #date(2020, 09, 25) then 3
    else if [DateKey] >= #date(2020, 09, 26) and [DateKey] <= #date(2020, 12, 25) then 4
    // Fiscal Year 2021
    else if [DateKey] >= #date(2020, 12, 26) and [DateKey] <= #date(2021, 03, 26) then 1
    else if [DateKey] >= #date(2021, 03, 27) and [DateKey] <= #date(2021, 06, 25) then 2
    else if [DateKey] >= #date(2021, 06, 26) and [DateKey] <= #date(2021, 09, 24) then 3
    else if [DateKey] >= #date(2021, 09, 25) and [DateKey] <= #date(2021, 12, 31) then 4
    // Fiscal Year 2022
    else if [DateKey] >= #date(2022, 01, 01) and [DateKey] <= #date(2022, 04, 01) then 1
    else if [DateKey] >= #date(2022, 04, 02) and [DateKey] <= #date(2022, 07, 01) then 2
    else if [DateKey] >= #date(2022, 07, 02) and [DateKey] <= #date(2022, 09, 30) then 3
    else if [DateKey] >= #date(2022, 10, 01) and [DateKey] <= #date(2022, 12, 30) then 4
    // Fiscal Year 2023
    else if [DateKey] >= #date(2022, 12, 31) and [DateKey] <= #date(2023, 03, 31) then 1
    else if [DateKey] >= #date(2023, 04, 01) and [DateKey] <= #date(2023, 06, 30) then 2
    else if [DateKey] >= #date(2023, 07, 01) and [DateKey] <= #date(2023, 09, 29) then 3
    else if [DateKey] >= #date(2023, 09, 30) and [DateKey] <= #date(2023, 12, 29) then 4
    // Fiscal Year 2024
    else if [DateKey] >= #date(2023, 12, 30) and [DateKey] <= #date(2024, 03, 29) then 1
    else if [DateKey] >= #date(2024, 03, 30) and [DateKey] <= #date(2024, 06, 28) then 2
    else if [DateKey] >= #date(2024, 06, 29) and [DateKey] <= #date(2024, 09, 27) then 3
    else if [DateKey] >= #date(2024, 09, 28) and [DateKey] <= #date(2024, 12, 27) then 4
    // Fiscal Year 2025
    else if [DateKey] >= #date(2024, 12, 28) and [DateKey] <= #date(2025, 03, 28) then 1
    else if [DateKey] >= #date(2025, 03, 29) and [DateKey] <= #date(2025, 06, 27) then 2
    else if [DateKey] >= #date(2025, 06, 28) and [DateKey] <= #date(2025, 09, 26) then 3
    else if [DateKey] >= #date(2025, 09, 27) and [DateKey] <= #date(2025, 12, 26) then 4
    // Fiscal Year 2026
    else if [DateKey] >= #date(2025, 12, 27) and [DateKey] <= #date(2026, 03, 27) then 1
    else if [DateKey] >= #date(2026, 03, 28) and [DateKey] <= #date(2026, 06, 26) then 2
    else if [DateKey] >= #date(2026, 06, 27) and [DateKey] <= #date(2026, 09, 25) then 3
    else if [DateKey] >= #date(2026, 09, 26) and [DateKey] <= #date(2027, 01, 01) then 4
    // Fiscal Year 2027
    else if [DateKey] >= #date(2027, 01, 02) and [DateKey] <= #date(2027, 04, 02) then 1
    else if [DateKey] >= #date(2027, 04, 03) and [DateKey] <= #date(2027, 07, 02) then 2
    else if [DateKey] >= #date(2027, 07, 03) and [DateKey] <= #date(2027, 10, 01) then 3
    else if [DateKey] >= #date(2027, 10, 02) and [DateKey] <= #date(2027, 12, 31) then 4
    // Fiscal Year 2028
    else if [DateKey] >= #date(2028, 01, 01) and [DateKey] <= #date(2028, 03, 31) then 1
    else if [DateKey] >= #date(2028, 04, 01) and [DateKey] <= #date(2028, 06, 30) then 2
    else if [DateKey] >= #date(2028, 07, 01) and [DateKey] <= #date(2028, 09, 29) then 3
    else if [DateKey] >= #date(2028, 09, 30) and [DateKey] <= #date(2028, 12, 29) then 4
    // Fiscal Year 2029
    else if [DateKey] >= #date(2028, 12, 30) and [DateKey] <= #date(2029, 03, 30) then 1
    else if [DateKey] >= #date(2029, 03, 31) and [DateKey] <= #date(2029, 06, 29) then 2
    else if [DateKey] >= #date(2029, 06, 30) and [DateKey] <= #date(2029, 09, 28) then 3
    else if [DateKey] >= #date(2029, 09, 29) and [DateKey] <= #date(2029, 12, 28) then 4
    // Fiscal Year 2030
    else if [DateKey] >= #date(2029, 12, 29) and [DateKey] <= #date(2030, 03, 29) then 1
    else if [DateKey] >= #date(2030, 03, 30) and [DateKey] <= #date(2030, 06, 28) then 2
    else if [DateKey] >= #date(2030, 06, 29) and [DateKey] <= #date(2030, 09, 27) then 3
    else if [DateKey] >= #date(2030, 09, 28) and [DateKey] <= #date(2030, 12, 27) then 4
// Fiscal Year 2031
    else if [DateKey] >= #date(2030, 12, 28) and [DateKey] <= #date(2031, 03, 28) then 1
    else if [DateKey] >= #date(2031, 03, 29) and [DateKey] <= #date(2031, 06, 27) then 2
    else if [DateKey] >= #date(2031, 06, 28) and [DateKey] <= #date(2031, 09, 26) then 3
    else if [DateKey] >= #date(2031, 09, 27) and [DateKey] <= #date(2031, 12, 26) then 4
else null, Int64.Type),
    #"Added Custom YearID" = Table.AddColumn(#"Added Custom QuarterID", "YearID", each Date.Year([DateKey])),
    #"Added Custom MonthName" = Table.AddColumn(#"Added Custom YearID", "Month Name", each Date.ToText([DateKey], "MMMM")),
    #"Added Custom FiscalYear" = Table.AddColumn(#"Added Custom MonthName", "Fiscal Year", each 
    if [DateKey] >= #date(2019, 12, 28) and [DateKey] <= #date(2020, 12, 25) then 2020
    else if [DateKey] >= #date(2020, 12, 26) and [DateKey] <= #date(2021, 12, 31) then 2021
    else if [DateKey] >= #date(2022, 1, 1) and [DateKey] <= #date(2022, 12, 30) then 2022
    else if [DateKey] >= #date(2022, 12, 31) and [DateKey] <= #date(2023, 12, 29) then 2023
    else if [DateKey] >= #date(2023, 12, 30) and [DateKey] <= #date(2024, 12, 27) then 2024
    else if [DateKey] >= #date(2024, 12, 28) and [DateKey] <= #date(2025, 12, 26) then 2025
    else if [DateKey] >= #date(2025, 12, 27) and [DateKey] <= #date(2027, 1, 1) then 2026
    else if [DateKey] >= #date(2027, 1, 2) and [DateKey] <= #date(2027, 12, 31) then 2027
    else if [DateKey] >= #date(2028, 1, 1) and [DateKey] <= #date(2028, 12, 29) then 2028
    else if [DateKey] >= #date(2028, 12, 30) and [DateKey] <= #date(2029, 12, 28) then 2029
    else if [DateKey] >= #date(2029, 12, 29) and [DateKey] <= #date(2030, 12, 27) then 2030
    else if [DateKey] >= #date(2030, 12, 28) and [DateKey] <= #date(2031, 12, 26) then 2031
    else null, Int64.Type),
    #"Added Custom FiscalQuarter" = Table.AddColumn(#"Added Custom FiscalYear", "Fiscal Quarter", each "Q"&Text.From([QuarterID])),
    #"Added Custom FiscalPeriod" = Table.AddColumn(#"Added Custom FiscalQuarter", "Fiscal Period", each 
    // Fiscal Year 2020
    if [DateKey] >= #date(2019, 12, 28) and [DateKey] <= #date(2020, 01, 24) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2020, 01, 25) and [DateKey] <= #date(2020, 02, 21) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2020, 02, 22) and [DateKey] <= #date(2020, 03, 27) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2020, 03, 28) and [DateKey] <= #date(2020, 04, 24) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2020, 04, 25) and [DateKey] <= #date(2020, 05, 22) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2020, 05, 23) and [DateKey] <= #date(2020, 06, 26) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2020, 06, 27) and [DateKey] <= #date(2020, 07, 24) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2020, 07, 25) and [DateKey] <= #date(2020, 08, 21) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2020, 08, 22) and [DateKey] <= #date(2020, 09, 25) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2020, 09, 26) and [DateKey] <= #date(2020, 10, 23) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2020, 10, 24) and [DateKey] <= #date(2020, 11, 20) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2020, 11, 21) and [DateKey] <= #date(2020, 12, 25) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2021
    else if [DateKey] >= #date(2020, 12, 26) and [DateKey] <= #date(2021, 01, 22) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2021, 01, 23) and [DateKey] <= #date(2021, 02, 19) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2021, 02, 20) and [DateKey] <= #date(2021, 03, 26) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2021, 03, 27) and [DateKey] <= #date(2021, 04, 23) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2021, 04, 24) and [DateKey] <= #date(2021, 05, 21) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2021, 05, 22) and [DateKey] <= #date(2021, 06, 25) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2021, 06, 26) and [DateKey] <= #date(2021, 07, 23) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2021, 07, 24) and [DateKey] <= #date(2021, 08, 20) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2021, 08, 21) and [DateKey] <= #date(2021, 09, 24) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2021, 09, 25) and [DateKey] <= #date(2021, 10, 22) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2021, 10, 23) and [DateKey] <= #date(2021, 11, 19) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2021, 11, 20) and [DateKey] <= #date(2021, 12, 31) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2022
    else if [DateKey] >= #date(2022, 01, 01) and [DateKey] <= #date(2022, 01, 28) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2022, 01, 29) and [DateKey] <= #date(2022, 02, 25) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2022, 02, 26) and [DateKey] <= #date(2022, 04, 01) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2022, 04, 02) and [DateKey] <= #date(2022, 04, 29) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2022, 04, 30) and [DateKey] <= #date(2022, 05, 27) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2022, 05, 28) and [DateKey] <= #date(2022, 07, 01) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2022, 07, 02) and [DateKey] <= #date(2022, 07, 29) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2022, 07, 30) and [DateKey] <= #date(2022, 08, 26) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2022, 08, 27) and [DateKey] <= #date(2022, 09, 30) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2022, 10, 01) and [DateKey] <= #date(2022, 10, 28) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2022, 10, 29) and [DateKey] <= #date(2022, 11, 25) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2022, 11, 26) and [DateKey] <= #date(2022, 12, 30) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2023
    else if [DateKey] >= #date(2022, 12, 31) and [DateKey] <= #date(2023, 01, 27) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2023, 01, 28) and [DateKey] <= #date(2023, 02, 24) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2023, 02, 25) and [DateKey] <= #date(2023, 03, 31) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2023, 04, 01) and [DateKey] <= #date(2023, 04, 28) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2023, 04, 29) and [DateKey] <= #date(2023, 05, 26) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2023, 05, 27) and [DateKey] <= #date(2023, 06, 30) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2023, 07, 01) and [DateKey] <= #date(2023, 07, 28) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2023, 07, 29) and [DateKey] <= #date(2023, 08, 25) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2023, 08, 26) and [DateKey] <= #date(2023, 09, 29) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2023, 09, 30) and [DateKey] <= #date(2023, 10, 27) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2023, 10, 28) and [DateKey] <= #date(2023, 11, 24) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2023, 11, 25) and [DateKey] <= #date(2023, 12, 29) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2024
    else if [DateKey] >= #date(2023, 12, 30) and [DateKey] <= #date(2024, 01, 26) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2024, 01, 27) and [DateKey] <= #date(2024, 02, 23) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2024, 02, 24) and [DateKey] <= #date(2024, 03, 29) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2024, 03, 30) and [DateKey] <= #date(2024, 04, 26) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2024, 04, 27) and [DateKey] <= #date(2024, 05, 24) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2024, 05, 25) and [DateKey] <= #date(2024, 06, 28) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2024, 06, 29) and [DateKey] <= #date(2024, 07, 26) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2024, 07, 27) and [DateKey] <= #date(2024, 08, 23) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2024, 08, 24) and [DateKey] <= #date(2024, 09, 27) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2024, 09, 28) and [DateKey] <= #date(2024, 10, 25) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2024, 10, 26) and [DateKey] <= #date(2024, 11, 22) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2024, 11, 23) and [DateKey] <= #date(2024, 12, 27) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2025
    else if [DateKey] >= #date(2024, 12, 28) and [DateKey] <= #date(2025, 01, 24) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2025, 01, 25) and [DateKey] <= #date(2025, 02, 21) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2025, 02, 22) and [DateKey] <= #date(2025, 03, 28) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2025, 03, 29) and [DateKey] <= #date(2025, 04, 25) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2025, 04, 26) and [DateKey] <= #date(2025, 05, 23) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2025, 05, 24) and [DateKey] <= #date(2025, 06, 27) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2025, 06, 28) and [DateKey] <= #date(2025, 07, 25) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2025, 07, 26) and [DateKey] <= #date(2025, 08, 22) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2025, 08, 23) and [DateKey] <= #date(2025, 09, 26) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2025, 09, 27) and [DateKey] <= #date(2025, 10, 24) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2025, 10, 25) and [DateKey] <= #date(2025, 11, 21) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2025, 11, 22) and [DateKey] <= #date(2025, 12, 26) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2026
    else if [DateKey] >= #date(2025, 12, 27) and [DateKey] <= #date(2026, 01, 23) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2026, 01, 24) and [DateKey] <= #date(2026, 02, 20) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2026, 02, 21) and [DateKey] <= #date(2026, 03, 27) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2026, 03, 28) and [DateKey] <= #date(2026, 04, 24) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2026, 04, 25) and [DateKey] <= #date(2026, 05, 22) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2026, 05, 23) and [DateKey] <= #date(2026, 06, 26) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2026, 06, 27) and [DateKey] <= #date(2026, 07, 24) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2026, 07, 25) and [DateKey] <= #date(2026, 08, 21) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2026, 08, 22) and [DateKey] <= #date(2026, 09, 25) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2026, 09, 26) and [DateKey] <= #date(2026, 10, 23) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2026, 10, 24) and [DateKey] <= #date(2026, 11, 20) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2026, 11, 21) and [DateKey] <= #date(2027, 01, 01) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2027
    else if [DateKey] >= #date(2027, 01, 02) and [DateKey] <= #date(2027, 01, 29) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2027, 01, 30) and [DateKey] <= #date(2027, 02, 26) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2027, 02, 27) and [DateKey] <= #date(2027, 04, 02) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2027, 04, 03) and [DateKey] <= #date(2027, 04, 30) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2027, 05, 01) and [DateKey] <= #date(2027, 05, 28) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2027, 05, 29) and [DateKey] <= #date(2027, 07, 02) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2027, 07, 03) and [DateKey] <= #date(2027, 07, 30) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2027, 07, 31) and [DateKey] <= #date(2027, 08, 27) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2027, 08, 28) and [DateKey] <= #date(2027, 10, 01) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2027, 10, 02) and [DateKey] <= #date(2027, 10, 29) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2027, 10, 30) and [DateKey] <= #date(2027, 11, 26) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2027, 11, 27) and [DateKey] <= #date(2027, 12, 31) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2028
    else if [DateKey] >= #date(2028, 01, 01) and [DateKey] <= #date(2028, 01, 28) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2028, 01, 29) and [DateKey] <= #date(2028, 02, 25) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2028, 02, 26) and [DateKey] <= #date(2028, 03, 31) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2028, 04, 01) and [DateKey] <= #date(2028, 04, 28) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2028, 04, 29) and [DateKey] <= #date(2028, 05, 26) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2028, 05, 27) and [DateKey] <= #date(2028, 06, 30) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2028, 07, 01) and [DateKey] <= #date(2028, 07, 28) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2028, 07, 29) and [DateKey] <= #date(2028, 08, 25) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2028, 08, 26) and [DateKey] <= #date(2028, 09, 29) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2028, 09, 30) and [DateKey] <= #date(2028, 10, 27) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2028, 10, 28) and [DateKey] <= #date(2028, 11, 24) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2028, 11, 25) and [DateKey] <= #date(2028, 12, 29) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2029
    else if [DateKey] >= #date(2028, 12, 30) and [DateKey] <= #date(2029, 01, 26) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2029, 01, 27) and [DateKey] <= #date(2029, 02, 23) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2029, 02, 24) and [DateKey] <= #date(2029, 03, 30) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2029, 03, 31) and [DateKey] <= #date(2029, 04, 27) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2029, 04, 28) and [DateKey] <= #date(2029, 05, 25) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2029, 05, 26) and [DateKey] <= #date(2029, 06, 29) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2029, 06, 30) and [DateKey] <= #date(2029, 07, 27) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2029, 07, 28) and [DateKey] <= #date(2029, 08, 24) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2029, 08, 25) and [DateKey] <= #date(2029, 09, 28) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2029, 09, 29) and [DateKey] <= #date(2029, 10, 26) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2029, 10, 27) and [DateKey] <= #date(2029, 11, 23) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2029, 11, 24) and [DateKey] <= #date(2029, 12, 28) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2030
    else if [DateKey] >= #date(2029, 12, 29) and [DateKey] <= #date(2030, 01, 25) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2030, 01, 26) and [DateKey] <= #date(2030, 02, 22) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2030, 02, 23) and [DateKey] <= #date(2030, 03, 29) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2030, 03, 30) and [DateKey] <= #date(2030, 04, 26) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2030, 04, 27) and [DateKey] <= #date(2030, 05, 24) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2030, 05, 25) and [DateKey] <= #date(2030, 06, 28) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2030, 06, 29) and [DateKey] <= #date(2030, 07, 26) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2030, 07, 27) and [DateKey] <= #date(2030, 08, 23) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2030, 08, 24) and [DateKey] <= #date(2030, 09, 27) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2030, 09, 28) and [DateKey] <= #date(2030, 10, 25) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2030, 10, 26) and [DateKey] <= #date(2030, 11, 22) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2030, 11, 23) and [DateKey] <= #date(2030, 12, 27) then Text.PadStart(Text.From(12), 2, "0")
    // Fiscal Year 2031
    else if [DateKey] >= #date(2030, 12, 28) and [DateKey] <= #date(2031, 01, 24) then Text.PadStart(Text.From(1), 2, "0")
    else if [DateKey] >= #date(2031, 01, 25) and [DateKey] <= #date(2031, 02, 21) then Text.PadStart(Text.From(2), 2, "0")
    else if [DateKey] >= #date(2031, 02, 22) and [DateKey] <= #date(2031, 03, 28) then Text.PadStart(Text.From(3), 2, "0")
    else if [DateKey] >= #date(2031, 03, 29) and [DateKey] <= #date(2031, 04, 25) then Text.PadStart(Text.From(4), 2, "0")
    else if [DateKey] >= #date(2031, 04, 26) and [DateKey] <= #date(2031, 05, 23) then Text.PadStart(Text.From(5), 2, "0")
    else if [DateKey] >= #date(2031, 05, 24) and [DateKey] <= #date(2031, 06, 27) then Text.PadStart(Text.From(6), 2, "0")
    else if [DateKey] >= #date(2031, 06, 28) and [DateKey] <= #date(2031, 07, 25) then Text.PadStart(Text.From(7), 2, "0")
    else if [DateKey] >= #date(2031, 07, 26) and [DateKey] <= #date(2031, 08, 22) then Text.PadStart(Text.From(8), 2, "0")
    else if [DateKey] >= #date(2031, 08, 23) and [DateKey] <= #date(2031, 09, 26) then Text.PadStart(Text.From(9), 2, "0")
    else if [DateKey] >= #date(2031, 09, 27) and [DateKey] <= #date(2031, 10, 24) then Text.PadStart(Text.From(10), 2, "0")
    else if [DateKey] >= #date(2031, 10, 25) and [DateKey] <= #date(2031, 11, 21) then Text.PadStart(Text.From(11), 2, "0")
    else if [DateKey] >= #date(2031, 11, 22) and [DateKey] <= #date(2031, 12, 26) then Text.PadStart(Text.From(12), 2, "0")
else null),
    #"Added Custom FiscalPeriodName" = Table.AddColumn(#"Added Custom FiscalPeriod", "Fiscal Period Name", each 
    if [Fiscal Period] = "01" then "January" 
    else if [Fiscal Period] = "02" then "February" 
    else if [Fiscal Period] = "03" then "March" 
    else if [Fiscal Period] = "04" then "April" 
    else if [Fiscal Period] = "05" then "May" 
    else if [Fiscal Period] = "06" then "June" 
    else if [Fiscal Period] = "07" then "July" 
    else if [Fiscal Period] = "08" then "August" 
    else if [Fiscal Period] = "09" then "September" 
    else if [Fiscal Period] = "10" then "October" 
    else if [Fiscal Period] = "11" then "November" 
    else if [Fiscal Period] = "12" then "December" 
    else "Unknown"),
    #"Added Custom FiscalWeek" = Table.AddColumn(#"Added Custom FiscalPeriodName", "Fiscal Week", each let
    FiscalYearData = {
        [Year = 2020, Start = 1, End = 52],
        [Year = 2021, Start = 53, End = 105],
        [Year = 2022, Start = 106, End = 157],
        [Year = 2023, Start = 158, End = 209],
        [Year = 2024, Start = 210, End = 261],
        [Year = 2025, Start = 262, End = 313],
        [Year = 2026, Start = 314, End = 366],
        [Year = 2027, Start = 367, End = 418],
        [Year = 2028, Start = 419, End = 470],
        [Year = 2029, Start = 471, End = 522],
        [Year = 2030, Start = 523, End = 574],
        [Year = 2031, Start = 575, End = 626]
    },
    WeekID = [WeekID],
    FiscalYear = List.First(List.Select(FiscalYearData, each WeekID >= _[Start] and WeekID <= _[End])),
    FiscalWeek = if FiscalYear = null then null else Text.PadStart(Text.From(WeekID - FiscalYear[Start] + 1), 2, "0")
in
    FiscalWeek),
    #"Added Custom FYQQMM" = Table.AddColumn(#"Added Custom FiscalWeek", "FYQQMM", each Text.From([Fiscal Year])&"-"&Text.From([Fiscal Quarter])&"-P"&Text.From([Fiscal Period])),
    #"Added Custom FYQQ" = Table.AddColumn(#"Added Custom FYQQMM", "FYQQ", each Text.From([Fiscal Year])&"-"&Text.From([Fiscal Quarter])),
    #"Added Custom FYMM" = Table.AddColumn(#"Added Custom FYQQ", "FYMM", each Text.From([Fiscal Year])&"-P"&Text.From([Fiscal Period])),
    #"Added Custom FYWW" = Table.AddColumn(#"Added Custom FYMM", "FYWW", each Text.From([Fiscal Year])&"-W"&Text.From([Fiscal Week])),
    #"Added Custom FiscalPeriodP" = Table.AddColumn(#"Added Custom FYWW", "Fiscal Period P", each "P"&[Fiscal Period]),
    #"Added Custom" = Table.AddColumn(#"Added Custom FiscalPeriodP", "Fiscal Week W", each "W"&[Fiscal Week])
in
    #"Added Custom"
