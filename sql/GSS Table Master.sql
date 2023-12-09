-- FINDING OUT WHICH TABLES ARE IN A MULTI-REC TABLE; https://docs.gss-service.com/data-conversion-upload-tables/ > FIND MASTER FILE NAME
select * from "X$File" where Xf$loc like '%RCMST%'