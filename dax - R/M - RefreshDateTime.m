let
    UtcNow = DateTimeZone.FixedUtcNow(),
    Y = Date.Year(DateTimeZone.RemoveZone(UtcNow)),

    SecondSundayInMarch =
        let
            d0 = #date(Y, 3, 1),
            firstSunday = Date.AddDays(d0, Number.Mod(7 - Date.DayOfWeek(d0, Day.Sunday), 7)),
            secondSunday = Date.AddDays(firstSunday, 7)
        in
            secondSunday,

    FirstSundayInNovember =
        let
            d0 = #date(Y, 11, 1),
            firstSunday = Date.AddDays(d0, Number.Mod(7 - Date.DayOfWeek(d0, Day.Sunday), 7))
        in
            firstSunday,

    DstStartUtc = #datetimezone(Y, 3, Date.Day(SecondSundayInMarch), 10, 0, 0, 0, 0),
    DstEndUtc   = #datetimezone(Y, 11, Date.Day(FirstSundayInNovember), 9, 0, 0, 0, 0),

    PacificOffsetHours = if UtcNow >= DstStartUtc and UtcNow < DstEndUtc then -7 else -8,
    PacificNow = DateTimeZone.SwitchZone(UtcNow, PacificOffsetHours),

    T0 = #table(type table [#"Last Refreshed (PT)" = datetimezone], {{PacificNow}}),

    AddLastRefreshedDT =
        Table.AddColumn(
            T0,
            "Last Refreshed (PT datetime)",
            each DateTimeZone.RemoveZone([#"Last Refreshed (PT)"]),
            type datetime
        ),

    AddRefreshDate =
        Table.AddColumn(
            AddLastRefreshedDT,
            "Refresh Date (PT)",
            each Date.From([#"Last Refreshed (PT datetime)"]),
            type date
        ),

    AddRefreshTime =
        Table.AddColumn(
            AddRefreshDate,
            "Refresh Time (PT)",
            each Time.From([#"Last Refreshed (PT datetime)"]),
            type time
        ),

    AddUtc =
        Table.AddColumn(
            AddRefreshTime,
            "Last Refreshed (UTC)",
            each UtcNow,
            type datetimezone
        )
in
    AddUtc
