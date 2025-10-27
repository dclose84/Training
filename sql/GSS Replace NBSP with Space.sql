--Searching for non-breaking space characters (CHAR(160))
--Replacing them with regular space characters (CHAR(32))
UPDATE "QUOTE_LINES"
SET PART = REPLACE(PART, CHAR(160), CHAR(32))
WHERE RECORD_TYPE = 'L';
