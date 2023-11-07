-- Ashwin's Part Swap Project, 2023-09-16

-- Correct missing INV_History and PO_History (for part Swap to 01)
SELECT * FROM GSS_SWAP_REF
WHERE file_name IN ('LHIST@@@','PHIST@@@') AND TYPE = 'I'

-- Long Query written by Ashwin
Select part,location from Inventory_mstr where part + location in 
(Select old + old_loc from GSS_inventory_lookup);
Select * from GSS_INVENTORY_LOOKUP where old + old_loc in (select Part + location from INVENTORY_MSTR);
delete from GSS_INVENTORY_LOOKUP;
update GSS_INVENTORY_LOOKUP set update_order = 1;

Select Part,Location from inventory_mstr where location  = '' and part + location not in(Select Old + Old_loc from GSS_INVENTORY_LOOKUP);


insert into GSS_INVENTORY_LOOKUP (Select Part as OLD,Location as OLD_LOC,Part as NEW,'01' as NEW_LOC,'1' as UPDATE_ORDER from INVENTORY_MSTR where LOCATION = '')

