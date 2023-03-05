create proc sp_editar_demandadoR
@id_demandado int,
@nombre varchar(50),
@rut varchar(15),
@represent varchar(50)
as
UPDATE demandado SET nombre=@nombre, rut=@rut, representante=@represent 
where id_demandado=@id_demandado
