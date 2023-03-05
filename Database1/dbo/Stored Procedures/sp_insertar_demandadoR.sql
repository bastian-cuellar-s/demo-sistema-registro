create proc sp_insertar_demandadoR
@id_demandado int output,
@nombre varchar(50),
@rut varchar(15),
@represent varchar(50)
as
INSERT INTO demandado (nombre,rut,representante) values (@nombre,@rut,@represent)
