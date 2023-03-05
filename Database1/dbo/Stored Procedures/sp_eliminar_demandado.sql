create proc sp_eliminar_demandado
@id_demandado int
as
DELETE FROM demandado where id_demandado=@id_demandado
