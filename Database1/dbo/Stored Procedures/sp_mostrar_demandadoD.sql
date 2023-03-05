create proc sp_mostrar_demandadoD
@fk_id_demandado int
as
SElECT * FROM demandado where id_demandado=@fk_id_demandado
