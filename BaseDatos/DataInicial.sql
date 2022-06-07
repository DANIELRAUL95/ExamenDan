
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220606183719_PrimeraMigracion', N'5.0.17')
GO
INSERT [dbo].[Inventarios] ([ProductoId], [SucursalId], [Existencia]) VALUES (1, 1, 50)
GO
INSERT [dbo].[Inventarios] ([ProductoId], [SucursalId], [Existencia]) VALUES (1, 2, 8)
GO
INSERT [dbo].[Inventarios] ([ProductoId], [SucursalId], [Existencia]) VALUES (2, 1, 10)
GO
INSERT [dbo].[Inventarios] ([ProductoId], [SucursalId], [Existencia]) VALUES (2, 2, 4)
GO
INSERT [dbo].[Inventarios] ([ProductoId], [SucursalId], [Existencia]) VALUES (3, 1, 1)
GO
INSERT [dbo].[Inventarios] ([ProductoId], [SucursalId], [Existencia]) VALUES (3, 2, 2)
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([Id], [Descripcion], [Codigo_Barra], [Precio_Unitario]) VALUES (1, N'Cafe_legal', 100010, CAST(7.00 AS Decimal(16, 2)))
GO
INSERT [dbo].[Productos] ([Id], [Descripcion], [Codigo_Barra], [Precio_Unitario]) VALUES (2, N'Chocolate_Abuelita', 100011, CAST(15.00 AS Decimal(16, 2)))
GO
INSERT [dbo].[Productos] ([Id], [Descripcion], [Codigo_Barra], [Precio_Unitario]) VALUES (3, N'Bonafina', 100012, CAST(12.00 AS Decimal(16, 2)))
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 
GO
INSERT [dbo].[Sucursal] ([Id], [Nombre]) VALUES (1, N'SucursalA')
GO
INSERT [dbo].[Sucursal] ([Id], [Nombre]) VALUES (2, N'SucursalB')
GO
SET IDENTITY_INSERT [dbo].[Sucursal] OFF