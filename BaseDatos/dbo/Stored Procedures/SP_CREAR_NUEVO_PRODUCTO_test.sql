
CREATE PROCEDURE SP_CREAR_NUEVO_PRODUCTO_test
	(
	@Nombre varchar(50) = '',
	@Codigo_Barra int,
	@Cantidad_Producto_Sucursal_A int,
	@Cantidad_Producto_Sucursal_B int,
	@Precio_Unitario int
	)
AS
BEGIN
	Insert into SUCURSALES (Nombre, Codigo_Barra, Cantidad_Producto_Sucursal_A, Cantidad_Producto_Sucursal_B,
	Precio_Unitario) 
	values(@Nombre, @Codigo_Barra, @Cantidad_Producto_Sucursal_A,
	@Cantidad_Producto_Sucursal_B, @Precio_Unitario)
END
