CREATE PROCEDURE SP_Editar_Datos_test
(	
    @ID  int = 0,
	@Nombre varchar(50) = '',
	@Codigo_Barra int,
	@Cantidad_Producto_Sucursal_A int,
	@Cantidad_Producto_Sucursal_B int,
	@Precio_Unitario int
	)
AS
BEGIN
	UPDATE SUCURSALES SET Nombre = @Nombre, Codigo_Barra= @Codigo_Barra, Cantidad_Producto_Sucursal_A = @Cantidad_Producto_Sucursal_A,
	Cantidad_Producto_Sucursal_B = @Cantidad_Producto_Sucursal_B, Precio_Unitario = @Precio_Unitario
	where ID = @ID
END
