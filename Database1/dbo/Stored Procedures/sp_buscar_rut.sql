create proc sp_buscar_rut
@textobuscar varchar(50)
as
SELECT * FROM demandado where rut like @textobuscar + '%'