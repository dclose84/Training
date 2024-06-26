-- Saved queries for routine DB maintenance

-- QUERY FOR INVALID COUNTRY_SHIP VALUES
SELECT * FROM "ORDER_HIST_LINE"
--CUSTOMER, ADDRESS_1_SHIP, ADDRESS_2_SHIP, STATE_SHIP, COUNTRY_SHIP from "ORDER_SHIP_TO"
WHERE (COUNTRY_SHIP = 'USA' AND STATE_SHIP NOT IN ('AL', 'AK', 'AZ', 'AR', 'CA', 'CO', 'CT', 'DC', 'DE', 'FL', 'GA', 'HI', 'ID', 'IL', 'IN', 'IA', 'KS', 'KY', 'LA', 'ME', 'MD', 'MA', 'MI', 'MN', 'MS', 'MO', 'MT', 'NE', 'NV', 'NH', 'NJ', 'NM', 'NY', 'NC', 'ND', 'OH', 'OK', 'OR', 'PA', 'RI', 'SC', 'SD', 'TN', 'TX', 'UT', 'VT', 'VA', 'WA', 'WV', 'WI', 'WY'))
OR COUNTRY_SHIP = ''
OR COUNTRY_SHIP = 'HIR'
OR COUNTRY_SHIP = 'US'
OR COUNTRY_SHIP = 'IE'
ORDER BY CUSTOMER ASC;

--UPDATE "ORDER_HIST_LINE"
--SET COUNTRY_SHIP = 'USA'
--WHERE COUNTRY_SHIP = 'US';


-- QUERY TO SEE MOST RECENT TRANSACTIONS FOR BLANK SORT CODE (INDUSTRY IE. SEMICONDUCTOR)
SELECT *
FROM "CUSTOMER_SALES"
WHERE REC = '2'
  AND C_SORT_1 = ''
ORDER BY CONCAT(SUBSTRING(DATE_LAST_SALE, 5, 2), SUBSTRING(DATE_LAST_SALE, 1, 4)) DESC


-- QUERY TO VIEW OPEN ORDERS WITH INVALID COUNTRY_SHIP
SELECT ORDER_NO, COUNTRY_SHIP FROM "ORDER_SHIP_TO"
--SELECT * FROM "ORDER_SHIP_TO"
WHERE (RECORD_NO = '  C' OR RECORD_NO = '  B') 
AND (COUNTRY_SHIP = '' OR COUNTRY_SHIP = 'HIR' OR COUNTRY_SHIP = 'US' OR (RECORD_NO = '  C' AND COUNTRY_SHIP = 'USA' AND STATE_SHIP NOT IN ('AL', 'AK', 'AZ', 'AR', 'CA', 'CO', 'CT', 'DC', 'DE', 'FL', 'GA', 'HI', 'ID', 'IL', 'IN', 'IA', 'KS', 'KY', 'LA', 'ME', 'MD', 'MA', 'MI', 'MN', 'MS', 'MO', 'MT', 'NE', 'NV', 'NH', 'NJ', 'NM', 'NY', 'NC', 'ND', 'OH', 'OK', 'OR', 'PA', 'RI', 'SC', 'SD', 'TN', 'TX', 'UT', 'VT', 'VA', 'WA', 'WV', 'WI', 'WY')))
ORDER BY ORDER_NO ASC;

UPDATE "ORDER_SHIP_TO"
SET COUNTRY_SHIP = 'USA'
WHERE COUNTRY_SHIP = 'US';

SELECT ORDER_NO, CUSTOMER_PO FROM "ORDER_HEADER"
--SELECT * FROM "ORDER_HEADER"
WHERE CUSTOMER = 'H12349' 
AND RECORD_TYPE IN ('A', 'B', 'C')
AND ORDER_NO IN ('0642927' , '0643010' , '0643049')
;

-- QUERY FOR PARTS REQUIRING INSPECTION (INVENTORY_MST2 CONTAINS REQUIRES_INSP, BUT DOES NOT HAVE PRODUCT_LINE)
SELECT
    IM.PART,
    IM.LOCATION,
    IM.DESCRIPTION,
    IM.FLAG_INACTIVE,
    IM.PRODUCT_LINE,
    IM2.REQUIRES_INSP
FROM
    INVENTORY_MSTR IM
JOIN
    INVENTORY_MST2 IM2
ON
    IM.PART = IM2.PART
    AND IM.LOCATION = IM2.LOCATION
ORDER BY IM.PART ASC;

-- UPDATES REQUIRES_INSP TO 'Y' BASED ON PRODUCT_LINE
UPDATE INVENTORY_MST2
SET REQUIRES_INSP = 'Y'
FROM INVENTORY_MST2 IM2
JOIN INVENTORY_MSTR IM
ON IM2.PART = IM.PART
   AND IM2.LOCATION = IM.LOCATION
WHERE IM.PRODUCT_LINE = '09';

select * from "CUSTOMER_MASTER" where REC = '1' and customer = 'A11100'
order by CUSTOMER ASC;

-- =CONCAT("UPDATE CUSTOMER_MASTER SET SALESPERSON = '",[@[Updated S/P]],"' WHERE (CUSTOMER = '",[@CUSTOMER],"' AND REC = '1');")
-- UPDATE CUSTOMER_MASTER SET SALESPERSON = 'JG' WHERE (CUSTOMER = 'A11100' AND REC = '1');

-- QUERY FOR INVALID COUNTRY_SHIP VALUES
SELECT * FROM "ORDER_HIST_LINE"
--SELECT ORDER, CUSTOMER, ADDRESS1_SHIP, ADDRESS2_SHIP, STATE_SHIP, COUNTRY_SHIP, CUSTOMER_PO from "ORDER_HIST_LINE"
WHERE (COUNTRY_SHIP = 'USA' AND STATE_SHIP NOT IN ('AL', 'AK', 'AZ', 'AR', 'CA', 'CO', 'CT', 'DC', 'DE', 'FL', 'GA', 'HI', 'ID', 'IL', 'IN', 'IA', 'KS', 'KY', 'LA', 'ME', 'MD', 'MA', 'MI', 'MN', 'MS', 'MO', 'MT', 'NE', 'NV', 'NH', 'NJ', 'NM', 'NY', 'NC', 'ND', 'OH', 'OK', 'OR', 'PA', 'RI', 'SC', 'SD', 'TN', 'TX', 'UT', 'VT', 'VA', 'WA', 'WV', 'WI', 'WY'))
OR COUNTRY_SHIP = ''
OR COUNTRY_SHIP = 'HIR'
OR COUNTRY_SHIP = 'US'
OR COUNTRY_SHIP = 'IE'
ORDER BY CUSTOMER ASC;

-- UPPRO S = IRELAND, UPPRO L = ISRAEL
UPDATE "ORDER_HIST_LINE"
SET COUNTRY_SHIP = 'USA'
WHERE COUNTRY_SHIP = 'US';

UPDATE "ORDER_HIST_LINE"
SET COUNTRY_SHIP = 'USA'
WHERE COUNTRY_SHIP = '' 
AND STATE_SHIP IN ('AL', 'AK', 'AZ', 'AR', 'CA', 'CO', 'CT', 'DC', 'DE', 'FL', 'GA', 'HI', 'ID', 'IL', 'IN', 'IA', 'KS', 'KY', 'LA', 'ME', 'MD', 'MA', 'MI', 'MN', 'MS', 'MO', 'MT', 'NE', 'NV', 'NH', 'NJ', 'NM', 'NY', 'NC', 'ND', 'OH', 'OK', 'OR', 'PA', 'RI', 'SC', 'SD', 'TN', 'TX', 'UT', 'VT', 'VA', 'WA', 'WV', 'WI', 'WY');
