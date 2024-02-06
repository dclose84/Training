-- Convert date stored in yymmdd into a readable format
MakeDateTime(
 ToInt(
  Concat('20',Substring([DATE_COMPLETED], 0, 2))),
 ToInt(
  Substring([DATE_COMPLETED], 2, 2)),
 ToInt(
  Substring([DATE_COMPLETED], 4, 2)))
