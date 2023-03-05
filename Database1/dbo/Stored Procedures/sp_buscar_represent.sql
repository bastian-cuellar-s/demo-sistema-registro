create proc sp_buscar_represent
@textobuscar varchar(50)
as
SELECT * FROM demandado where representante like @textobuscar + '%'
