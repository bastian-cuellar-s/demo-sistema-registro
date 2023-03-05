create proc sp_editar_domicilio
@id_domicilio int,
@direcc varchar(50),
@razon varchar(15),
@fk_id_demandado int
as
UPDATE domicilio SET direcc=@direcc, razon=@razon where id_domicilio=@id_domicilio and fk_id_demandado=@fk_id_demandado
