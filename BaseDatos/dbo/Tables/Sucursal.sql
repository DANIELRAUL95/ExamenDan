CREATE TABLE [dbo].[Sucursal] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Nombre] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED ([Id] ASC)
);

