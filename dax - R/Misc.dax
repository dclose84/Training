// ORDER_HIST_LINE, categorize lines by type to extract PROGRESS
if [LINE_TYPE] = "P" then "PROGRESS"
else if [LINE_TYPE] = "S" then "STANDARD"
else if [LINE_TYPE] = "F" then "FREIGHT"
else null


= Table.SelectRows(#"Added Custom PART_LOC", each ([CODE_TRANSACTION] = "A10" or [CODE_TRANSACTION] = "A50" or [CODE_TRANSACTION] = "P16" or [CODE_TRANSACTION] = "O35" or [CODE_TRANSACTION] = "P10" or [CODE_TRANSACTION] = "J55" or [CODE_TRANSACTION] = "J52"))

O35 - Invoicing transactions (- INV)
P10 - PO receipts (+ INV)
J55 - Issue Material (- INV)/(+ WIP)
J52 - WIP to Inv (- WIP)/(+ INV)
A10 - Blind receipt to Inventory (+INV)
A50 - Blind issues from Inventory (-INV)
P16 - Physical Inventory Adjustment (+/- INV)
Sort by PL, graph it over time
