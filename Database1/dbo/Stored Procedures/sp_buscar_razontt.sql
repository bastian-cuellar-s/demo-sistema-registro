CREATE proc [dbo].[sp_buscar_razontt]
@textobuscar varchar(50)
as
SELECT dbo.demandado.nombre, dbo.demandado.rut, dbo.domicilio.direcc, dbo.domicilio.razon, dbo.demandado.representante
FROM     dbo.demandado INNER JOIN
                  dbo.domicilio ON dbo.demandado.id_demandado = dbo.domicilio.fk_id_demandado
				  where razon like @textobuscar + '%'
