create proc sp_eliminar_domicilio
@id_domicilio int
as
DELETE FROM domicilio where id_domicilio=@id_domicilio
