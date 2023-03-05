create proc sp_insertar_demandado
@id_demandado int output,
@nombre varchar(50),
@rut varchar(15)
as
INSERT INTO demandado (nombre,rut) values (@nombre,@rut)
