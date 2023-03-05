create proc sp_mostrar_domicilios
as
SELECT * FROM  domicilio order by id_domicilio DESC
