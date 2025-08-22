let
    Source = DateTimeZone.SwitchZone( DateTimeZone.UtcNow(),-7),
    #"Converted to Table" = #table(1, {{Source}}),
    #"Renamed Columns" = Table.RenameColumns(#"Converted to Table",{{"Column1", "Last Refreshed"}}),
    #"Changed Type" = Table.TransformColumnTypes(#"Renamed Columns",{{"Last Refreshed", type datetimezone}})
in
    #"Changed Type"
