=IF(
    AND
        ([@[Worst known LT]]<>"",
        [@[Worst known LT]]<>0),
        TODAY()+[@[Worst known LT]]+(16*7),
        "")