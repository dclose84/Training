' Force 17 characters (Part) for data conversion mapper

=A2 & REPT(" ", 17 - LEN(A2))

=LEFT([@PART],17)
=IF([@Len]=20,RIGHT([@PART],3),"   ")
=CONCAT([@[Part_Short]] & REPT(" ", 17 - LEN([@[Part_Short]])),[@[Mod_Rev]])
