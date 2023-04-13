=IF
    (ISTEXT
        (SEARCH("AZ",A3)), "UPPRO USA", 
IF
    (ISTEXT
        (SEARCH("OR",A3)), "UPPRO USA", 
IF
    (ISTEXT
        (SEARCH("IS",A3)), "UPPRO ISRAEL", 
IF
    (ISTEXT
        (SEARCH("IR",A3)), "UPPRO IRELAND",""))))