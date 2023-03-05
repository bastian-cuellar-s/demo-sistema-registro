create proc sp_editar_demandado
@id_demandado int,
@nombre varchar(50),
@rut varchar(15)
as
UPDATE demandado SET nombre=@nombre, rut=@rut where id_demandado=@id_demandado
