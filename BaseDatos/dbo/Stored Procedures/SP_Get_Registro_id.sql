-- Author:		<Author,,Daniel Delgado>
-- Create date: <Create 5/06/2022,,>
-- Descripcion: Sp para trar un id 

CREATE PROCEDURE SP_Get_Registro_id
(	
    @ID  int = 0
	
	)
AS
BEGIN
	SELECT * FROM SUCURSALES WHERE ID = @ID
END
