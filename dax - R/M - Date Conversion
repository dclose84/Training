Table.SplitColumn(#"Changed Type", "DATE_DUE", Splitter.SplitTextByRepeatedLengths(2), {"DATE_DUE.1", "DATE_DUE.2", "DATE_DUE.3"})
Table.TransformColumns(#"Split Column by Position2", {{"DATE_DUE.3", each "20" & _, type text}})
Table.CombineColumns(#"Added Prefix1",{"DATE_DUE.1", "DATE_DUE.2", "DATE_DUE.3"},Combiner.CombineTextByDelimiter("/", QuoteStyle.None),"DATE_DUE")
Table.TransformColumnTypes(#"Merged Columns1",{{"DATE_DUE", type date}})
