create proc sp_mostrar_demandado
as
SELECT * FROM  demandado order by id_demandado DESC
