create proc sp_insertar_domicilio
@id_domicilio int output,
@direcc varchar(200),
@razon varchar(100),
@fk_id_demandado int
as
INSERT INTO domicilio(direcc,razon,fk_id_demandado) values (@direcc,@razon,@fk_id_demandado)
