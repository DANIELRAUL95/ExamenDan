CREATE TABLE [dbo].[Productos] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [Descripcion]     VARCHAR (50)    NOT NULL,
    [Codigo_Barra]    INT             NOT NULL,
    [Precio_Unitario] DECIMAL (16, 2) NOT NULL,
    CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

