-- Fix AR Customers Open > Over Ships
UPDATE CUST_FORM_INFO 
SET NO_OVER_SHP_QTY = 1 
WHERE REC = 6;

-- Fix Date_Due from incorrect 01/01/1900 date
UPDATE ORDER_HIST_LINE
SET DATE_DUE = DATE_SHIPPED
WHERE ORDER_NO = '0638501' or ORDER_NO = '0639033'

-- Correct missing INV_History and PO_History (for part Swap to 01)
SELECT * FROM "GSS_SWAP_REF" 
WHERE file_name IN ('LHIST@@@','PHIST@@@') AND TYPE = 'I'

-- Change all reorder qty to 0
UPDATE "INVENTORY_MSTR" 
SET QTY_REORDER = '0' 
WHERE LOCATION = '02'

-- Delete all parts from LOC 02 (after removing from master table, FIXPART8/NF from 1Shot to do the subsequent)
DELETE FROM INVENTORY_MSTR
WHERE LOCATION = '02'
	
DELETE FROM INVENTORY_MST2
WHERE LOCATION = '02'
	
DELETE FROM INVENTORY_MST3
WHERE LOCATION = '02'
	
SELECT * FROM "INVENTORY_COST"
WHERE LOCN = '02'
	
DELETE FROM INVENTORY_COST
WHERE LOCN = '02'
	
-- To clear up Manufacture to job/stock in locations other than 01
--(Tristan's) Delete "INVENTORY_MSTR" where source_code = 'F' and loc <> '01'
	
DELETE FROM INVENTORY_MSTR
WHERE SOURCE_CODE = 'M' AND LOC <> '01'
	
DELETE FROM INVENTORY_MSTR
WHERE SOURCE_CODE = 'F' AND LOC <> '01'
	