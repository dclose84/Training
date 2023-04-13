' Current Day
=+MAX(invoicing[Invoice Date])

'Current Quarter
=IF(MONTH(D1)<=3,"Q1-"&RIGHT(YEAR(D1),2),IF(MONTH(D1)<=6,"Q2-"&RIGHT(YEAR(D1),2),IF(MONTH(D1)<=9,"Q3-"&RIGHT(YEAR(D1),2),"Q4-"&RIGHT(YEAR(D1),2))))

