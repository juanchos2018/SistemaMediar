USE [BdFiles]
GO
/****** Object:  User [jose]    Script Date: 08/09/2021 03:27:56 p.m. ******/
CREATE USER [jose] FOR LOGIN [jose] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Apuntes]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apuntes](
	[IdApunte] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[Titulo] [varchar](100) NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[FechaRegistro] [date] NULL,
	[Hora] [varchar](100) NULL,
	[Estado] [varchar](10) NULL,
	[Tipo] [varchar](10) NULL,
 CONSTRAINT [PK_Apunte] PRIMARY KEY CLUSTERED 
(
	[IdApunte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Archivo]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Archivo](
	[IdArchivo] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpresa] [int] NULL,
	[IdCarpeta] [bigint] NULL,
	[NombreArchivo] [varchar](100) NULL,
	[Tipo] [varchar](6) NULL,
	[Size] [int] NULL,
	[Estado] [varchar](1) NULL,
	[RutaServidor] [varchar](100) NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_IdArchivos] PRIMARY KEY CLUSTERED 
(
	[IdArchivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Archivos1]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Archivos1](
	[IdArchivo] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [varchar](3) NOT NULL,
	[IdCarpeta] [int] NOT NULL,
	[NombreArchivo] [varchar](50) NULL,
	[TipoArchivo] [varchar](50) NULL,
	[RutaFisica] [varchar](50) NULL,
	[RutaServidor] [varchar](50) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_IdArchivo] PRIMARY KEY CLUSTERED 
(
	[IdArchivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carpeta]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carpeta](
	[IdCarpeta] [bigint] IDENTITY(1,1) NOT NULL,
	[NombreCarpeta] [varchar](100) NOT NULL,
	[IdEmpresa] [int] NULL,
	[Fecha] [datetime] NULL,
	[Cantidad] [int] NULL,
	[Estado] [varchar](1) NULL,
 CONSTRAINT [PK_IdCarpeta] PRIMARY KEY CLUSTERED 
(
	[IdCarpeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Casos]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Casos](
	[IdCaso] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Caso] PRIMARY KEY CLUSTERED 
(
	[IdCaso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [bigint] IDENTITY(1,1) NOT NULL,
	[IdEmpresa] [int] NULL,
	[DniCliente] [varchar](100) NOT NULL,
	[NombreCliente] [varchar](100) NOT NULL,
	[ApellidoCliente] [varchar](100) NULL,
	[CelularCliente] [varchar](100) NOT NULL,
	[CorreoCliente] [varchar](100) NULL,
	[DireccionCliente] [varchar](100) NULL,
	[PaisCliente] [varchar](100) NULL,
	[ProvinciaCliente] [varchar](100) NULL,
	[CiudadCliente] [varchar](100) NULL,
	[Estado] [varchar](1) NULL,
 CONSTRAINT [PK_IdCliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conciliacion]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conciliacion](
	[IdConciliacion] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[DniCliente] [varchar](10) NOT NULL,
	[Titulo] [varchar](100) NOT NULL,
	[Materia] [varchar](100) NOT NULL,
	[IdCaso] [int] NULL,
	[Desrcipcioncaso] [varchar](100) NOT NULL,
	[Tarfia] [decimal](18, 2) NOT NULL,
	[FechaCreacion] [datetime] NULL,
	[FechaActualizacion] [datetime] NULL,
	[Estado] [varchar](3) NULL,
 CONSTRAINT [PK_Conciliacion] PRIMARY KEY CLUSTERED 
(
	[IdConciliacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentosConciliacion]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentosConciliacion](
	[IdConciliacion] [int] NULL,
	[dniCliente] [varchar](10) NOT NULL,
	[IdEmpresa] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificaion] [datetime] NULL,
	[TipoArchivo] [varchar](5) NULL,
	[NombreArchivo] [varchar](100) NULL,
	[RutaArchivo] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentosMaterias]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentosMaterias](
	[IdMateriaDocumentoMateria] [int] IDENTITY(1,1) NOT NULL,
	[IdMateria] [int] NULL,
	[IdEmpresa] [int] NOT NULL,
	[NombreDocumento] [varchar](200) NOT NULL,
	[RutaDocumento] [varchar](100) NOT NULL,
	[TipoDocumento] [varchar](10) NOT NULL,
 CONSTRAINT [PK_DocMateria] PRIMARY KEY CLUSTERED 
(
	[IdMateriaDocumentoMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[IdEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[NombreEmpresa] [varchar](100) NULL,
	[TelefonoEmpresa] [varchar](15) NOT NULL,
	[CorreoEmpresa] [varchar](100) NULL,
	[Direccion] [varchar](100) NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MailServer]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MailServer](
	[Smtp] [varchar](50) NULL,
	[Puerto] [varchar](10) NULL,
	[SSL] [bit] NULL,
	[Credencial] [bit] NULL,
	[MasterMail] [varchar](50) NULL,
	[pws] [varchar](50) NULL,
	[CC] [bit] NULL,
	[CCopiaMail] [varchar](50) NULL,
	[Asunto] [varchar](200) NULL,
	[CuerpoMail] [varchar](max) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ftp] [varchar](50) NULL,
	[UserFTp] [varchar](50) NULL,
	[pwsFtp] [varchar](50) NULL,
	[PasiveMode] [bit] NULL,
 CONSTRAINT [PK__MailServ__3213E83F324172E1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[IdMateria] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[NombreMateria] [varchar](100) NOT NULL,
	[idcarpeta] [int] NULL,
 CONSTRAINT [PK_Carpeta] PRIMARY KEY CLUSTERED 
(
	[IdMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perroos]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perroos](
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Apuntes] ON 

INSERT [dbo].[Apuntes] ([IdApunte], [IdEmpresa], [Titulo], [Descripcion], [FechaRegistro], [Hora], [Estado], [Tipo]) VALUES (3, 4, N'Audiencia', N'dsdsd', CAST(N'2021-05-11' AS Date), N'01:06:12 a.m.', N'Activ', N'Audiencia')
INSERT [dbo].[Apuntes] ([IdApunte], [IdEmpresa], [Titulo], [Descripcion], [FechaRegistro], [Hora], [Estado], [Tipo]) VALUES (4, 4, N'Audiencia otro', N'dfdfdf', CAST(N'2021-07-14' AS Date), N'06:06:37 p.m.', N'Activ', N'Reunion')
INSERT [dbo].[Apuntes] ([IdApunte], [IdEmpresa], [Titulo], [Descripcion], [FechaRegistro], [Hora], [Estado], [Tipo]) VALUES (5, 4, N'Audiencia ayer', N'fdfdfdfd', CAST(N'2021-05-25' AS Date), N'01:15:15 a.m.', N'Activ', N'Reunion')
INSERT [dbo].[Apuntes] ([IdApunte], [IdEmpresa], [Titulo], [Descripcion], [FechaRegistro], [Hora], [Estado], [Tipo]) VALUES (6, 4, N'Audiencia nunca', N'fgfgfgf', CAST(N'2021-06-08' AS Date), N'06:40:16 p.m.', N'Activ', N'Reunion')
INSERT [dbo].[Apuntes] ([IdApunte], [IdEmpresa], [Titulo], [Descripcion], [FechaRegistro], [Hora], [Estado], [Tipo]) VALUES (7, 4, N'Audiencia ajj', N'sdfdsfdsfds', CAST(N'2021-06-08' AS Date), N'12:14:58 a.m.', N'Activ', N'Reunion')
INSERT [dbo].[Apuntes] ([IdApunte], [IdEmpresa], [Titulo], [Descripcion], [FechaRegistro], [Hora], [Estado], [Tipo]) VALUES (8, 4, N'Reunion loo', N'descripcion', CAST(N'2021-07-11' AS Date), N'11:54:44 a.m.', N'Activ', N'Reunion')
INSERT [dbo].[Apuntes] ([IdApunte], [IdEmpresa], [Titulo], [Descripcion], [FechaRegistro], [Hora], [Estado], [Tipo]) VALUES (9, 4, N'Reunioin a tomar', N'cdfdffdf', CAST(N'2021-07-12' AS Date), N'12:56:48 p.m.', N'Activ', N'Reunion')
INSERT [dbo].[Apuntes] ([IdApunte], [IdEmpresa], [Titulo], [Descripcion], [FechaRegistro], [Hora], [Estado], [Tipo]) VALUES (10, 4, N'audencia', N'audencia', CAST(N'2021-07-14' AS Date), N'02:00:39 a.m.', N'Activ', N'Audiencia')
SET IDENTITY_INSERT [dbo].[Apuntes] OFF
GO
SET IDENTITY_INSERT [dbo].[Archivo] ON 

INSERT [dbo].[Archivo] ([IdArchivo], [IdEmpresa], [IdCarpeta], [NombreArchivo], [Tipo], [Size], [Estado], [RutaServidor], [FechaRegistro]) VALUES (48, 4, 17, N'SolicitudFamilia.docx', N'.docx', 0, N'1', N'4\17\SolicitudFamilia.docx', NULL)
INSERT [dbo].[Archivo] ([IdArchivo], [IdEmpresa], [IdCarpeta], [NombreArchivo], [Tipo], [Size], [Estado], [RutaServidor], [FechaRegistro]) VALUES (49, 4, 17, N'SOLICITUD audiencia de conciliacion.docx', N'.docx', 0, N'1', N'4\17\SOLICITUD audiencia de conciliacion.docx', NULL)
SET IDENTITY_INSERT [dbo].[Archivo] OFF
GO
SET IDENTITY_INSERT [dbo].[Carpeta] ON 

INSERT [dbo].[Carpeta] ([IdCarpeta], [NombreCarpeta], [IdEmpresa], [Fecha], [Cantidad], [Estado]) VALUES (17, N'Familia', 4, CAST(N'2021-07-12T15:56:06.970' AS DateTime), 0, N'1')
INSERT [dbo].[Carpeta] ([IdCarpeta], [NombreCarpeta], [IdEmpresa], [Fecha], [Cantidad], [Estado]) VALUES (18, N'Civil', 4, CAST(N'2021-07-14T00:53:25.167' AS DateTime), 0, N'1')
INSERT [dbo].[Carpeta] ([IdCarpeta], [NombreCarpeta], [IdEmpresa], [Fecha], [Cantidad], [Estado]) VALUES (19, N'documentos', 4, CAST(N'2021-07-14T01:23:16.250' AS DateTime), 0, N'1')
SET IDENTITY_INSERT [dbo].[Carpeta] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (1, 4, N'45713875', N'Juan carlos', N'panty', N'970780836', N'jcarllosenati@gmail.com', N'los sauces', N'Peru', N'TAcna', N'TAcna', N'1')
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (2, 4, N'45713871', N'Pepep', N'panty', N'970780836', N'jcarllosenati@gmail.com', N'los sauces', N'Peru', N'TAcna', N'TAcna', N'1')
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (3, 4, N'45713873', N'andres', N'panty', N'970780836', N'jcarllosenati@gmail.com', N'los sauces', N'Peru', N'TAcna', N'TAcna', N'1')
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (4, 4, N'45713874', N'jorge', N'panty', N'970780836', N'jcarllosenati@gmail.com', N'los sauces', N'Peru', N'TAcna', N'TAcna', N'1')
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (5, 4, N'45713876', N'maria', N'panty', N'970780836', N'jcarllosenati@gmail.com', N'los sauces', N'Peru', N'TAcna', N'TAcna', N'1')
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (6, 4, N'32323232', N'dasda', N'sdfsdfsd', N'sdfsdfsdf', N'dfsfsd', N'sdfsdfsdf', N'Peru', N'aas', N'Tacna', NULL)
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (7, 4, N'eees', N'esewse', N'sererewr', N'erere', N'erer', N'erere', N'Peru', N'aas', N'Tacna', NULL)
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (8, 4, N'43408280', N'jonh lester', N'salcedo bernabe', N'545454', N'jonsdfsf@gmaill.com', N'asaas', N'Peru', N'aas', N'Tacna', NULL)
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (15, 4, N'121211', N'asaa', N'asasas', N'3435', N'asasa', N'asasasa', N'Peru', N'Tacna', N'Tacna', NULL)
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (16, 4, N'12111', N'asasa', N'asas', N'asas', N'asas', N'asasa', N'Peru', N'Tacna', N'Tacna', NULL)
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (17, 4, N'oiiu44444', N'ghg', N'fgfg', N'34343', N'dfd', N'dfdfdfd', N'Peru', N'Tacna', N'Tacna', NULL)
INSERT [dbo].[Cliente] ([IdCliente], [IdEmpresa], [DniCliente], [NombreCliente], [ApellidoCliente], [CelularCliente], [CorreoCliente], [DireccionCliente], [PaisCliente], [ProvinciaCliente], [CiudadCliente], [Estado]) VALUES (18, 4, N'45713875111', N'dfdf', N'dfdfd', N'2332', N'asas', N'asasa', N'Peru', N'Tacna', N'Tacna', NULL)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Conciliacion] ON 

INSERT [dbo].[Conciliacion] ([IdConciliacion], [IdEmpresa], [DniCliente], [Titulo], [Materia], [IdCaso], [Desrcipcioncaso], [Tarfia], [FechaCreacion], [FechaActualizacion], [Estado]) VALUES (10, 4, N'45713871', N'Caso nuevo', N'Familia', 1, N'SolicitudFamilia.docx', CAST(100.00 AS Decimal(18, 2)), CAST(N'2021-07-13T11:47:44.493' AS DateTime), CAST(N'2021-07-13T11:47:44.493' AS DateTime), N'1')
SET IDENTITY_INSERT [dbo].[Conciliacion] OFF
GO
INSERT [dbo].[DocumentosConciliacion] ([IdConciliacion], [dniCliente], [IdEmpresa], [FechaRegistro], [FechaModificaion], [TipoArchivo], [NombreArchivo], [RutaArchivo]) VALUES (10, N'45713871', 4, CAST(N'2021-07-13T11:47:46.357' AS DateTime), CAST(N'2021-07-13T11:47:46.357' AS DateTime), N'.docx', N'SolicitudFamilia.docx', N'4\45713871\SolicitudFamilia.docx')
GO
SET IDENTITY_INSERT [dbo].[Empresa] ON 

INSERT [dbo].[Empresa] ([IdEmpresa], [NombreEmpresa], [TelefonoEmpresa], [CorreoEmpresa], [Direccion]) VALUES (4, N'Esteban', N'4555', N'correo', N'casa')
SET IDENTITY_INSERT [dbo].[Empresa] OFF
GO
SET IDENTITY_INSERT [dbo].[MailServer] ON 

INSERT [dbo].[MailServer] ([Smtp], [Puerto], [SSL], [Credencial], [MasterMail], [pws], [CC], [CCopiaMail], [Asunto], [CuerpoMail], [id], [Ftp], [UserFTp], [pwsFtp], [PasiveMode]) VALUES (N'smtp.gmail.com', N'587', 1, 0, N'jcarlossenati@gmail.com', N'Universidad2020', 0, N'CentroConciliacion', N'Envio Docuemeto', N'1', 1, N'ftp://ftp.comercial-carolina.com', N'Centro Conciliacion', N'20449266448ab@', 1)
SET IDENTITY_INSERT [dbo].[MailServer] OFF
GO
ALTER TABLE [dbo].[MailServer] ADD  DEFAULT ((0)) FOR [PasiveMode]
GO
ALTER TABLE [dbo].[Apuntes]  WITH CHECK ADD FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[Archivo]  WITH CHECK ADD  CONSTRAINT [FK_IdCarpetaAr] FOREIGN KEY([IdCarpeta])
REFERENCES [dbo].[Carpeta] ([IdCarpeta])
GO
ALTER TABLE [dbo].[Archivo] CHECK CONSTRAINT [FK_IdCarpetaAr]
GO
ALTER TABLE [dbo].[Archivo]  WITH CHECK ADD  CONSTRAINT [FK_IdEmpresaArchivo] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[Archivo] CHECK CONSTRAINT [FK_IdEmpresaArchivo]
GO
ALTER TABLE [dbo].[Carpeta]  WITH CHECK ADD  CONSTRAINT [FK_IdEmpresaCarpeta] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[Carpeta] CHECK CONSTRAINT [FK_IdEmpresaCarpeta]
GO
ALTER TABLE [dbo].[Casos]  WITH CHECK ADD FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([IdMateria])
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_IdEmpresaCliente] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_IdEmpresaCliente]
GO
ALTER TABLE [dbo].[Conciliacion]  WITH CHECK ADD FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[DocumentosConciliacion]  WITH CHECK ADD FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[DocumentosConciliacion]  WITH CHECK ADD FOREIGN KEY([IdConciliacion])
REFERENCES [dbo].[Conciliacion] ([IdConciliacion])
GO
ALTER TABLE [dbo].[DocumentosMaterias]  WITH CHECK ADD FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([IdMateria])
GO
ALTER TABLE [dbo].[Materias]  WITH CHECK ADD FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
/****** Object:  StoredProcedure [dbo].[Cliente_SS]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[Cliente_SS]
    @Dnicliente		varchar(10)
	
AS

select * from Cliente
where DniCliente =@Dnicliente 
GO
/****** Object:  StoredProcedure [dbo].[Existe_Cliente]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[Existe_Cliente]
    @Dnicliente varchar(18),
@Resultado int output
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN
       DECLARE @nreg int;
	DECLARE @sw int;
       SELECT @nreg=count(*) FROM   [dbo].[Cliente] 
	WHERE  ([DniCliente] = @Dnicliente OR @Dnicliente IS NULL) 
       IF(@nreg=0)
	SET @sw=0
	ELSE
	SET @sw=1
SELECT @Resultado=@sw
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[Str_Apuntes_I]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Str_Apuntes_I]
	@IdEmpresa		 INT ,
	@Titulo	 varchar(100) ,
	@Descripcion  varchar(100) ,	
	@FechaRegistro datetime,
	@Hora varchar(50),
	@Estado varchar(5),
	@Tipo varchar(10)
	as 
	begin 
	insert into Apuntes (IdEmpresa,Titulo,Descripcion,FechaRegistro,Hora,Estado,Tipo)
	values              (@IdEmpresa,@Titulo,@Descripcion,@FechaRegistro,@Hora,@Estado,@Tipo)
	end
GO
/****** Object:  StoredProcedure [dbo].[Str_Archivo_I]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Str_Archivo_I] 
    @IdCarpeta int,
    @IdEmpresa int,
    @NombreArchivo varchar(100),
	@Tipo varchar(6),
    @Size int,
	@Estado varchar(1),
	@RutaServidor varchar(100),
	@FechaRegistro datetime
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  	
	BEGIN TRAN	
	INSERT INTO [dbo].[Archivo] (IdCarpeta,IdEmpresa,NombreArchivo,Tipo,Size,Estado,RutaServidor,FechaRegistro)	
	values( @IdCarpeta,@IdEmpresa, @NombreArchivo,@Tipo,@Size,@Estado,@RutaServidor,@FechaRegistro)
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[Str_Archivo_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Str_Archivo_S]
    @IdEmpresa		int ,
	@IdCarpeta int
AS
select * from Archivo
where IdEmpresa=@IdEmpresa and IdCarpeta =@IdCarpeta
GO
/****** Object:  StoredProcedure [dbo].[Str_Carpeta_I]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[Str_Carpeta_I] 
    @NombreCarpeta varchar(100),
    @IdEmpresa int,
    @Fecha datetime,
	@Cantidad int,
	@Estado varchar(1)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  	
	BEGIN TRAN	
	INSERT INTO [dbo].[Carpeta] (NombreCarpeta,IdEmpresa,Fecha,Cantidad,Estado)	
	values( @NombreCarpeta,@IdEmpresa, @Fecha,@Cantidad,@Estado)
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[Str_Carpeta_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Str_Carpeta_S]
    @IdEmpresa		int 
AS
select * from Carpeta
where IdEmpresa= @IdEmpresa	

GO
/****** Object:  StoredProcedure [dbo].[Str_Casos_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[Str_Casos_S]
    @IdEmpresa		int 	,
	@IdMateria		int 
AS


select * from Casos
where IdEmpresa=@IdEmpresa and IdMateria=@IdMateria
GO
/****** Object:  StoredProcedure [dbo].[Str_Cliente_I]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[Str_Cliente_I] 
    @IdEmpresa			int,
	@DniCliente			varchar(100),	
	@NombreCliente		varchar(100) ,		
	@ApellidoCliente		varchar(100),
	@CelularCliente		varchar(100) ,	
	@CorreoCliente		varchar(100)  ,	
	@DireccionCliente	varchar(100),	
	@PaisCliente			varchar(100)  ,	
	@ProvinciaCliente	varchar(100),	
	@CiudadCliente		varchar(100)  


AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  	
	BEGIN TRAN	
	INSERT INTO [dbo].[Cliente] (
	IdEmpresa		,
	DniCliente		,
	NombreCliente	,
	ApellidoCliente	,
	CelularCliente	,
	CorreoCliente	,
	DireccionCliente,
	PaisCliente		,
	ProvinciaCliente,
	CiudadCliente		)
	values(@IdEmpresa	,		
		   @DniCliente	,		
		   @NombreCliente,		
		   @ApellidoCliente,	
		   @CelularCliente	,	
		   @CorreoCliente	,	
		   @DireccionCliente,	
		   @PaisCliente		,
		   @ProvinciaCliente,	
		   @CiudadCliente		
	)
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[Str_Cliente_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Str_Cliente_S]
    @IdEmpresa		int 
AS
select IdCliente as Codigo,DniCliente,IdEmpresa,NombreCliente as Nombre,ApellidoCliente as Apellido,CelularCliente as Celular,CorreoCliente as Correo,PaisCliente from Cliente
GO
/****** Object:  StoredProcedure [dbo].[Str_Cliente_S1]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[Str_Cliente_S1]
    @IdEmpresa		int 
AS
select IdCliente as Codigo ,DniCliente as Dni,IdEmpresa,NombreCliente as Nombre,ApellidoCliente as Apellido,CelularCliente as Celular,CorreoCliente as Correo,PaisCliente from Cliente
GO
/****** Object:  StoredProcedure [dbo].[Str_Cliente_SS]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[Str_Cliente_SS]
    @IdEmpresa		int 
AS
select DniCliente as Dni,NombreCliente as Nombre,ApellidoCliente as Apellido,CelularCliente as Celular from Cliente
GO
/****** Object:  StoredProcedure [dbo].[Str_Conciliacion_I]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Str_Conciliacion_I]

	@IdEmpresa		 INT ,
	@DniCliente		 varchar(10) ,
	@Titulo  varchar(100) ,	
	@Materia  varchar(100) ,	
	@IdCaso  INT ,
	@Desrcipcioncaso  varchar(100) ,	
	@Tarfia  decimal(18,2) ,
	@FechaCreacion datetime,
	@FechaActualizacion datetime,
	@Estado varchar(3)

	as 
	begin 
	insert into Conciliacion (IdEmpresa,DniCliente,Titulo,Materia,IdCaso,Desrcipcioncaso,Tarfia,FechaCreacion,FechaActualizacion,Estado)
	values                  (@IdEmpresa,@DniCliente,@Titulo,@Materia,@IdCaso,@Desrcipcioncaso,@Tarfia,@FechaCreacion,@FechaActualizacion,@Estado)

	end
GO
/****** Object:  StoredProcedure [dbo].[Str_Conciliacion_II]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Str_Conciliacion_II]
    @IdEmpresa		 INT ,
	@DniCliente		 varchar(10) ,
	@Titulo  varchar(100) ,	
	@Materia  varchar(100) ,	
	@IdCaso  INT ,
	@Desrcipcioncaso  varchar(100) ,	
	@Tarfia  decimal(18,2) ,
	@FechaCreacion datetime,
	@FechaActualizacion datetime,
	@Estado varchar(3),
    @New_MEM_BASIC_ID int OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
   insert into Conciliacion (IdEmpresa,DniCliente,Titulo,Materia,IdCaso,Desrcipcioncaso,Tarfia,FechaCreacion,FechaActualizacion,Estado)
	values                  (@IdEmpresa,@DniCliente,@Titulo,@Materia,@IdCaso,@Desrcipcioncaso,@Tarfia,@FechaCreacion,@FechaActualizacion,@Estado)
	
    SELECT @New_MEM_BASIC_ID = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[Str_Conciliacion_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Str_Conciliacion_S]
    @IdEmpresa		int 	
AS

select con.DniCliente as Dni,con.IdConciliacion, cli.NombreCliente as Nombre,cli.ApellidoCliente as Apellido,cli.CelularCliente as Celular ,cli.CorreoCliente as Correo, con.Materia,con.Desrcipcioncaso,con.FechaCreacion from Conciliacion  as con
inner join Cliente as cli
on cli.DniCliente =con.DniCliente
where  con.IdEmpresa=@IdEmpresa
GO
/****** Object:  StoredProcedure [dbo].[Str_Conciliacion_U]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Str_Conciliacion_U]
@IdEmpresa		 INT ,
@IdConciliacion int,
@Estado varchar(3)
as
update Conciliacion
set Estado =@Estado
where IdEmpresa=@IdEmpresa and IdConciliacion=@IdConciliacion
GO
/****** Object:  StoredProcedure [dbo].[Str_ConciliacionCliente_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Str_ConciliacionCliente_S]
    @IdEmpresa		int ,
	@DniCliente varchar(10)
AS
select Materia,Desrcipcioncaso,FechaCreacion,IdConciliacion from conciliacion
where IdEmpresa=@IdEmpresa and DniCliente =@DniCliente
GO
/****** Object:  StoredProcedure [dbo].[Str_DocumentosConciliacion_I]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Str_DocumentosConciliacion_I]
	@IdConciliacion		 INT ,
	@dniCliente		 varchar(10) ,
	@IdEmpresa  varchar(100) ,	
	@FechaRegistro  datetime ,	
	@FechaModificaion  datetime ,
	@TipoArchivo  varchar(5) ,	
	@NombreArchivo  varchar(100) ,
	@RutaArchivo varchar(100)
	
	as 
	begin 
	insert into DocumentosConciliacion (IdConciliacion,dniCliente,IdEmpresa,FechaRegistro,FechaModificaion,TipoArchivo,NombreArchivo,RutaArchivo)
	values                  (@IdConciliacion,@dniCliente,@IdEmpresa,@FechaRegistro,@FechaModificaion,@TipoArchivo,@NombreArchivo,@RutaArchivo)
	end

GO
/****** Object:  StoredProcedure [dbo].[Str_DocumentosConciliacion_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	
CREATE PROC [dbo].[Str_DocumentosConciliacion_S]
    @IdEmpresa		int, 
	@idConciliacion int
AS

select * from DocumentosConciliacion
where IdEmpresa =@IdEmpresa and IdConciliacion =@idConciliacion
GO
/****** Object:  StoredProcedure [dbo].[Str_DocumentosConciliacionCliente_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[Str_DocumentosConciliacionCliente_S]
    @IdEmpresa		int ,
	@DniCliente varchar(10),
	@IdConcliacion int
AS
select * from DocumentosConciliacion
where IdEmpresa=@IdEmpresa and DniCliente =@DniCliente and IdConciliacion =@IdConcliacion
GO
/****** Object:  StoredProcedure [dbo].[Str_DocumentosMaterias_I]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Str_DocumentosMaterias_I]
	@IdMateria int,
	@IdEmpresa		 INT ,
	@NombreDocumento   varCHAR(200) ,	
	@RutaDocumento    varCHAR(100),
	@TipoDocumento    varCHAR(10) 	   

	as 
	begin 
	insert into DocumentosMaterias (IdMateria,IdEmpresa,NombreDocumento,RutaDocumento,TipoDocumento   )
	values              (@IdMateria,@IdEmpresa,@NombreDocumento,@RutaDocumento,@TipoDocumento )
	end
	   
GO
/****** Object:  StoredProcedure [dbo].[Str_Materia_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[Str_Materia_S]
    @IdEmpresa		int 	
AS

select * from Materias
where IdEmpresa=@IdEmpresa
GO
/****** Object:  StoredProcedure [dbo].[Str_Materias_I]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Str_Materias_I]
	@IdEmpresa		 INT ,
	@NombreMateria  varchar(100) ,	
	@idcarpeta int	
	as 
	begin 
	insert into Materias (IdEmpresa,NombreMateria,idcarpeta)
	values              (@IdEmpresa,@NombreMateria,@idcarpeta)
	end
GO
/****** Object:  StoredProcedure [dbo].[Str_prueba]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[Str_prueba]
    @IdEmpresa		int 	
AS

select (con.DniCliente + CHAR(13) + CHAR(10) +cli.NombreCliente) as datos ,cli.ApellidoCliente,cli.CelularCliente,cli.CorreoCliente, con.Materia,con.Desrcipcioncaso,con.FechaCreacion from Conciliacion  as con
inner join Cliente as cli
on con.DniCliente=cli.DniCliente
where  con.IdEmpresa=@IdEmpresa
GO
/****** Object:  StoredProcedure [dbo].[Str_TodosDocumentos_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Str_TodosDocumentos_S]
    @IdEmpresa		int	
AS

select ar.IdEmpresa,ar.IdArchivo, ar.IdCarpeta,car.NombreCarpeta,ar.NombreArchivo,ar.Tipo,ar.RutaServidor,ar.FechaRegistro from Archivo as ar
inner join Carpeta as car
on ar.IdCarpeta=car.IdCarpeta
where ar.IdEmpresa= @IdEmpresa

GO
/****** Object:  StoredProcedure [dbo].[StrApuntes_S]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[StrApuntes_S]
    @IdEmpresa		int,
	@fecha datetime
	
AS

select Hora,Titulo as Dia from Apuntes
where IdEmpresa =@IdEmpresa and FechaRegistro =@fecha
GO
/****** Object:  StoredProcedure [dbo].[StrApuntes_SS]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[StrApuntes_SS]
    @IdEmpresa		int
	
AS

select * from Apuntes
where IdEmpresa =@IdEmpresa 
GO
/****** Object:  StoredProcedure [dbo].[TotalCasos]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TotalCasos]
@idempresa int 
as 
begin 
select count(*) as cantidad  from Conciliacion where IdEmpresa=@idempresa
end
GO
/****** Object:  StoredProcedure [dbo].[TotalClientes]    Script Date: 08/09/2021 03:27:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TotalClientes]
@idempresa int 
as 
begin 
select count(*) as cantidad  from Cliente where IdEmpresa=@idempresa

end
GO
