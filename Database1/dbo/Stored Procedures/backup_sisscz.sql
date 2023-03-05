create proc backup_sisscz
as
BACKUP DATABASE [DBSisSara]
TO DISK =N'C:\sisscz\backup.sisscz.bak'
WITH DESCRIPTION=N'Respaldo Sistema de registros',
NOFORMAT,
INIT,
NAME=N'DBSisSara',
SKIP,
NOREWIND,
NOUNLOAD,
STATS=10,
CHECKSUM
