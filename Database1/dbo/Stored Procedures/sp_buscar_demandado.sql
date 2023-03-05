
create proc sp_buscar_demandado
@textobuscar varchar(50)
as
SELECT * FROM demandado where nombre like @textobuscar + '%'
