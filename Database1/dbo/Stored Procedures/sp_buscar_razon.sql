
CREATE proc [dbo].[sp_buscar_razon]
@textobuscar varchar(50)
as
SELECT * FROM domicilio where razon like @textobuscar + '%'
