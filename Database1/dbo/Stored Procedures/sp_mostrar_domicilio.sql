
create proc sp_mostrar_domicilio
@fk_id_demandado int
as
SElECT * FROM domicilio where fk_id_demandado=@fk_id_demandado
