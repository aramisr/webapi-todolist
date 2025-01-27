USE [db-todo]
GO
/****** Object:  Table [dbo].[TodoLists]    Script Date: 7/17/2024 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TodoLists](
	[id] [uniqueidentifier] NOT NULL,
	[taskName] [nvarchar](max) NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[dateCreation] [datetime2](7) NULL,
	[dateEnd] [datetime2](7) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[TodoLists] ([id], [taskName], [status], [dateCreation], [dateEnd]) VALUES (N'6a7c1c9a-072c-4953-a71c-707bd2561723', N'Pagar recibos', N'Finalizada', CAST(N'2024-07-09T21:56:43.4108484' AS DateTime2), CAST(N'2024-07-11T03:59:49.9522080' AS DateTime2))
INSERT [dbo].[TodoLists] ([id], [taskName], [status], [dateCreation], [dateEnd]) VALUES (N'ee8e1bdb-e9c7-4745-89ae-ffe68e0f432d', N'Realizar diligencia al banco', N'En progreso', CAST(N'2024-07-10T21:10:44.5770809' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TodoLists] ([id], [taskName], [status], [dateCreation], [dateEnd]) VALUES (N'f6b3a346-7797-4b58-982d-d5b8aa0d56d5', N'Sacar a pasear al perro', N'En progreso', CAST(N'2024-07-10T21:11:36.6767020' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TodoLists] ([id], [taskName], [status], [dateCreation], [dateEnd]) VALUES (N'bbad94ff-a4e3-4ee7-a2d1-0f3b616fc576', N'Estudiar para mi examen de algebra', N'En progreso', CAST(N'2024-07-10T21:12:47.1202862' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TodoLists] ([id], [taskName], [status], [dateCreation], [dateEnd]) VALUES (N'fc60f615-ed48-4a58-969d-d1ac47bd8880', N'Comprar vitaminas', N'En progreso', CAST(N'2024-07-16T21:21:58.4830324' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
