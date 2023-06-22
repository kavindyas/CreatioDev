create or alter view KaviVwContactAgeDays
as
select Id as KaviId, Name as KaviName, BirthDate as KaviBirthDate,
datediff(day, BirthDate, getdate()) as KaviAgeDays
from Contact