CREATE TABLE [dbo].[Inventarios] (
    [ProductoId] INT NOT NULL,
    [SucursalId] INT NOT NULL,
    [Existencia] INT NOT NULL,
    CONSTRAINT [PK_Inventarios] PRIMARY KEY CLUSTERED ([ProductoId] ASC, [SucursalId] ASC),
    CONSTRAINT [FK_Inventarios_Productos_ProductoId] FOREIGN KEY ([ProductoId]) REFERENCES [dbo].[Productos] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Inventarios_Sucursal_SucursalId] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursal] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Inventarios_SucursalId]
    ON [dbo].[Inventarios]([SucursalId] ASC);

