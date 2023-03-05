create proc sp_buscar_direcc
@textobuscar varchar(50)
as
SELECT * FROM domicilio where direcc like @textobuscar + '%'
