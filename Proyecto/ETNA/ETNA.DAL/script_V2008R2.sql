USE [INTEGRADO]
GO
/****** Object:  Table [dbo].[TB_VT_Zona]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_VT_Zona](
	[ZonaId] [nchar](10) NULL,
	[Codigo] [nchar](10) NULL,
	[Descripción] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_VT_Telefono]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_Telefono](
	[TelefonoId] [int] NOT NULL,
	[ClienteId] [int] NOT NULL,
	[NumeroTelefono] [varchar](20) NOT NULL,
	[TipoTelefono] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[TelefonoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_VT_Monedas]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_Monedas](
	[MonedaId] [int] NULL,
	[Descripcion] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_VT_ListaPrecios]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_ListaPrecios](
	[ListaPrecioId] [int] NOT NULL,
	[Codigo] [nchar](10) NULL,
	[Descripción] [varchar](50) NULL,
	[Sucursal] [nchar](10) NULL,
	[RestringuirZona] [bit] NULL,
	[RestringuirGrupoVentas] [bit] NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_ListaPrecios] PRIMARY KEY CLUSTERED 
(
	[ListaPrecioId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_SE_UserProfile]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SE_UserProfile](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](56) NOT NULL,
 CONSTRAINT [PK_UserProfile] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_SE_Roles]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SE_Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_SE_OAuthMembership]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SE_OAuthMembership](
	[Provider] [nvarchar](30) NOT NULL,
	[ProviderUserId] [nvarchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_OAuthMembership] PRIMARY KEY CLUSTERED 
(
	[Provider] ASC,
	[ProviderUserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_SE_Membership]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SE_Membership](
	[UserId] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[ConfirmationToken] [nvarchar](128) NULL,
	[IsConfirmed] [bit] NULL,
	[LastPasswordFailureDate] [datetime] NULL,
	[PasswordFailuresSinceLastSuccess] [int] NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[PasswordChangedDate] [datetime] NULL,
	[PasswordSalt] [nvarchar](128) NOT NULL,
	[PasswordVerificationToken] [nvarchar](128) NULL,
	[PasswordVerificationTokenExpirationDate] [datetime] NULL,
 CONSTRAINT [PK_Membership] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_RH_Empleados]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_RH_Empleados](
	[EmpleadoId] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](max) NOT NULL,
	[Apellidos] [nvarchar](max) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[Cargo] [nvarchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
	[GrupoVentaId] [int] NOT NULL,
	[DocIdentidad] [varchar](20) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[EmpleadoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_VT_GrupoVenta]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_GrupoVenta](
	[GrupoVentaId] [int] NOT NULL,
	[Codigo] [nchar](10) NOT NULL,
	[Descripción] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PV_TiposPlantilla]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PV_TiposPlantilla](
	[TipoPlantillaId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TiposPlantilla] PRIMARY KEY CLUSTERED 
(
	[TipoPlantillaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_VT_Direccion]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_Direccion](
	[DireccionId] [int] NOT NULL,
	[ClienteId] [int] NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[DireccionPrincipal] [bit] NOT NULL,
 CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED 
(
	[DireccionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_VT_Categoria]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_Categoria](
	[CategoriaId] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_CategoriaCliente] PRIMARY KEY CLUSTERED 
(
	[CategoriaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY],
 CONSTRAINT [Descripcion_CategoriaCliente] UNIQUE NONCLUSTERED 
(
	[Descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_TipoLotes]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TipoLotes](
	[TipoLoteId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TipoLotes] PRIMARY KEY CLUSTERED 
(
	[TipoLoteId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_VT_Contacto]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_Contacto](
	[ContactoId] [varchar](20) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Cargo] [varchar](50) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Email] [varchar](250) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[FechaCumpleaños] [datetime] NOT NULL,
 CONSTRAINT [PK_Contacto] PRIMARY KEY CLUSTERED 
(
	[ContactoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_EX_SolicitudAtencion]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_EX_SolicitudAtencion](
	[CodigoSolAtencion] [int] NOT NULL,
	[Responsable] [varchar](50) NOT NULL,
	[FechaRegistro] [date] NULL,
	[FechaReservaEspacio] [date] NOT NULL,
	[FechaDespacho] [date] NOT NULL,
	[Estado] [char](10) NOT NULL,
	[Observaciones] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SolicitudAtencion] PRIMARY KEY CLUSTERED 
(
	[CodigoSolAtencion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PR_SolicitudProduccionDet]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_PR_SolicitudProduccionDet](
	[SolicitudProdDetId] [char](3) NULL,
	[FechaIni] [datetime] NULL,
	[FechaFin] [datetime] NULL,
	[CodRecurso] [char](3) NULL,
	[CantRecurso] [int] NULL,
	[CantProgSol] [int] NULL,
	[CantDispSol] [int] NULL,
	[ObsSol] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PR_SolicitudProduccion]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_PR_SolicitudProduccion](
	[SolicitudProdId] [char](5) NULL,
	[PlanId] [char](5) NULL,
	[FecSol] [datetime] NULL,
	[Descripcion] [varchar](500) NULL,
	[CantPersonal] [int] NULL,
	[CantInsumos] [int] NULL,
	[CantMaquinaria] [int] NULL,
	[ResponsableId] [char](7) NULL,
	[SupervisorId] [char](7) NULL,
	[SolicitanteId] [char](7) NULL,
	[Glosa] [varchar](100) NULL,
	[EstadoSol] [char](1) NULL,
	[ObsSol] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PR_Personal]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_PR_Personal](
	[PersonalId] [char](3) NULL,
	[Nombres] [varchar](20) NULL,
	[Cargo] [varchar](50) NULL,
	[Disponibilidad] [char](1) NULL,
	[Comentarios] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PR_OrdenTrabajo]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TB_PR_OrdenTrabajo](
	[OrdenId] [int] IDENTITY(1,1) NOT NULL,
	[LoteId] [int] NULL,
	[AreaTrabajo] [varchar](100) NULL,
	[FecIniciOrden] [datetime] NULL,
	[FecFinalOrden] [datetime] NULL,
	[RecursoId] [char](3) NULL,
	[DescRecurso] [varchar](100) NULL,
	[CantRecursoDisp] [int] NULL,
	[GlosaOrd] [varchar](100) NULL,
	[EstOrden] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PR_MatrizAreasTrabajo]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TB_PR_MatrizAreasTrabajo](
	[RecursoId] [char](3) NULL,
	[AreaTrabajo] [char](3) NULL,
	[DescripcionArea] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PR_Maquinaria]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_PR_Maquinaria](
	[MaqId] [char](3) NULL,
	[Descripcion] [varchar](100) NULL,
	[StockDispMaquina] [int] NULL,
	[StockResMaquina] [int] NULL,
	[Observacion] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PR_LoteFabricacion]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TB_PR_LoteFabricacion](
	[LoteId] [int] IDENTITY(1,1) NOT NULL,
	[SolId] [char](5) NULL,
	[CodigoProducto] [varchar](4) NULL,
	[CantInsumos] [int] NULL,
	[CantMaquina] [int] NULL,
	[CantPersonal] [int] NULL,
	[FecSol] [datetime] NULL,
	[FecInicial] [datetime] NULL,
	[FecFinal] [datetime] NULL,
	[SolicitanteId] [char](7) NULL,
	[EstLote] [int] NULL,
	[GlosaOrd] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PR_Insumo]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_PR_Insumo](
	[InsumoId] [char](3) NULL,
	[Descripcion] [varchar](100) NULL,
	[StockDispInsumo] [int] NULL,
	[StockResInsumo] [int] NULL,
	[Observacion] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_ModalidadCredito]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_ModalidadCredito](
	[ModalidadCreditoId] [int] NOT NULL,
	[Codigo] [varchar](20) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[DiasCredito] [int] NOT NULL,
 CONSTRAINT [PK_ModalidadCredito] PRIMARY KEY CLUSTERED 
(
	[ModalidadCreditoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY],
 CONSTRAINT [Codigo_ModalidadCredito] UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_MA_Pais]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_MA_Pais](
	[CodigoPais] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[CodigoPais] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PV_Plantillas]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PV_Plantillas](
	[PlantillaId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[TipoPlantillaId] [int] NOT NULL,
 CONSTRAINT [PK_Plantillas] PRIMARY KEY CLUSTERED 
(
	[PlantillaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PV_ProgramacionesEncuesta]    Script Date: 07/01/2015 23:07:56 ******/
/*SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PV_ProgramacionesEncuesta](
	[ProgramacionesEncuestaId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ProgramacionesEncuesta] PRIMARY KEY CLUSTERED 
(
	[ProgramacionesEncuestaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO*/
/****** Object:  Table [dbo].[TB_AL_Almacenes]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AL_Almacenes](
	[AlmacenId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[Tipo] [int] NOT NULL,
	[AreaEnM2] [int] NOT NULL,
 CONSTRAINT [PK_Almacenes] PRIMARY KEY CLUSTERED 
(
	[AlmacenId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_CA_TipoPrueba]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TB_CA_TipoPrueba](
	[IdTipoPrueba] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionTipoPrueba] [varchar](45) NOT NULL,
	[CodigoTipoPrueba] [varchar](45) NOT NULL,
 CONSTRAINT [PK_TB_TipoPrueba] PRIMARY KEY CLUSTERED 
(
	[CodigoTipoPrueba] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_CA_PlanCalidad]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_CA_PlanCalidad](
	[IDPlanCalidad] [int] IDENTITY(1,1) NOT NULL,
	[FchPlanCalidad] [date] NULL,
	[IdEspecialista] [int] NULL,
 CONSTRAINT [PK_TB_PlanCalidad] PRIMARY KEY CLUSTERED 
(
	[IDPlanCalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_CA_OrdenCalidad]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TB_CA_OrdenCalidad](
	[IdOrdenCalidad] [int] IDENTITY(1,1) NOT NULL,
	[FchOrdenCalidad] [date] NULL,
	[NumeroHoras] [int] NULL,
	[EstadoOrdenCalidad] [varchar](45) NULL,
	[IDDetallePlanCalidad] [int] NULL,
	[IDSolicitud] [int] NULL,
 CONSTRAINT [PK_TB_OrdenCalidad] PRIMARY KEY CLUSTERED 
(
	[IdOrdenCalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_CA_IngenieriaProducto]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TB_CA_IngenieriaProducto](
	[IDIngenieriaProducto] [int] IDENTITY(1,1) NOT NULL,
	[codigoIngenieriaProducto] [varchar](45) NULL,
	[valorPermitido] [float] NULL,
	[UnidadMedida] [varchar](45) NULL,
	[PoMuestra] [decimal](18, 0) NULL,
	[Codigo_Producto] [int] NULL,
	[IdTipoPrueba] [int] NULL,
 CONSTRAINT [PK_TB_IngenieriaProducto] PRIMARY KEY CLUSTERED 
(
	[IDIngenieriaProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_CA_EspecialistaCalendario]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TB_CA_EspecialistaCalendario](
	[IdEspecialistaCalendario] [int] IDENTITY(1,1) NOT NULL,
	[FchInicio] [date] NULL,
	[FchFin] [date] NULL,
	[EstadoEspecialistaCalendario] [varchar](45) NULL,
	[IDEspecialista] [int] NULL,
 CONSTRAINT [PK_TB_EspecialistaCalendario] PRIMARY KEY CLUSTERED 
(
	[IdEspecialistaCalendario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_CA_Especialista]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TB_CA_Especialista](
	[IdEspecialista] [int] IDENTITY(1,1) NOT NULL,
	[NombreEspecialista] [varchar](45) NULL,
	[ApellidosEspecialista] [varchar](45) NULL,
	[CodigoEspecialista] [varchar](45) NULL,
	[Especialidad] [varchar](45) NULL,
 CONSTRAINT [PK_TB_Especialista] PRIMARY KEY CLUSTERED 
(
	[IdEspecialista] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_CA_DetallePlanCalidad]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_CA_DetallePlanCalidad](
	[IDDetallePlanCalidad] [int] IDENTITY(1,1) NOT NULL,
	[IDPlanCalidad] [int] NULL,
	[FchEjecucion] [datetime] NULL,
	[IdEspecialistaCalendario] [int] NULL,
	[IdLote] [int] NULL,
 CONSTRAINT [PK_TB_DetallePlanCalidad] PRIMARY KEY CLUSTERED 
(
	[IDDetallePlanCalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_CA_DetalleOrdenCalidad]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TB_CA_DetalleOrdenCalidad](
	[IdDetalleOrdenCalidad] [int] IDENTITY(1,1) NOT NULL,
	[REDetalleOrdenCalidad] [varchar](45) NULL,
	[ESDetalleOrdenCalidad] [varchar](45) NULL,
	[IDOrdenCalidad] [int] NULL,
	[IDIngenieriaProducto] [int] NULL,
 CONSTRAINT [PK_TB_DetalleOrdenCalidad] PRIMARY KEY CLUSTERED 
(
	[IdDetalleOrdenCalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_AL_Productos]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_AL_Productos](
	[ProductoId] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProducto] [varchar](4) NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[DescripcionCorta] [nvarchar](max) NOT NULL,
	[DescripcionLarga] [nvarchar](max) NOT NULL,
	[Unidad] [varchar](10) NULL,
	[PrecioListaCompra] [float] NOT NULL,
	[PrecioListaVenta] [float] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ProductoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_AL_DocumentosReferenciaGuiaSalida]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AL_DocumentosReferenciaGuiaSalida](
	[GuiaSalidaId] [int] NOT NULL,
 CONSTRAINT [PK_DocumentosReferencia_GuiaSalida] PRIMARY KEY CLUSTERED 
(
	[GuiaSalidaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_EX_DocumentoSIICEX]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_EX_DocumentoSIICEX](
	[CodigoDocSiicex] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_DocumentoSIICEX] PRIMARY KEY CLUSTERED 
(
	[CodigoDocSiicex] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_EX_DocumentoExportacion]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_EX_DocumentoExportacion](
	[CodigoDocExport] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[FechaRegistro] [date] NULL,
 CONSTRAINT [PK_DocumentoExportacion] PRIMARY KEY CLUSTERED 
(
	[CodigoDocExport] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_EX_DetalleDocExportacion]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_EX_DetalleDocExportacion](
	[CodigoDocExport] [int] NOT NULL,
	[FechaPublicacion] [date] NULL,
	[FechaExpiracion] [date] NULL,
	[Version] [char](10) NOT NULL,
	[Estado] [char](10) NULL,
	[DocumentoAdjunto] [float] NULL,
	[CodigoDocSiicex] [int] NOT NULL,
 CONSTRAINT [PK_DetalleDocExportacion] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[CodigoDocExport] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_CronogramaEmbarque]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_CronogramaEmbarque](
	[Codigo] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[FechaEmbarque] [date] NULL,
	[Cantidad] [numeric](18, 0) NOT NULL,
	[CodigoSolAtencion] [int] NULL,
 CONSTRAINT [PK_CronogramaEmbarque] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_CronogramaDespacho]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_CronogramaDespacho](
	[Codigo] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[FechaDespacho] [date] NULL,
	[Cantidad] [numeric](18, 0) NULL,
	[CodigoSolAtencion] [int] NULL,
 CONSTRAINT [PK_CronogramaDespacho] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_Contrato]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_Contrato](
	[ContratoId] [int] NOT NULL,
	[FechaContrato] [date] NULL,
	[Moneda] [char](10) NULL,
	[Observaciones] [varchar](50) NULL,
	[DocumentoAdjunto] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[CodigoSolAtencion] [int] NULL,
 CONSTRAINT [PK_Contrato] PRIMARY KEY CLUSTERED 
(
	[ContratoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_AL_SolicitudesEntrada]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AL_SolicitudesEntrada](
	[SolicitudEntradaId] [int] IDENTITY(1,1) NOT NULL,
	[FechaElaboracion] [datetime] NOT NULL,
	[TipoEntrada] [int] NOT NULL,
	[Estado] [int] NOT NULL,
	[EmpleadoId] [int] NOT NULL,
 CONSTRAINT [PK_SolicitudesEntrada] PRIMARY KEY CLUSTERED 
(
	[SolicitudEntradaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_AL_ReservaStock]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_AL_ReservaStock](
	[Codigo] [int] NULL,
	[FechaVigencia] [date] NULL,
	[Tipo] [char](10) NULL,
	[Cantidad] [int] NULL,
	[CantidadReservada] [int] NULL,
	[CodigoSolAtencion] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_AL_DocumentosReferencia]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AL_DocumentosReferencia](
	[DocumentoReferenciaId] [int] IDENTITY(1,1) NOT NULL,
	[IdentificadorDocumento] [nvarchar](max) NOT NULL,
	[FechaElaboracion] [datetime] NOT NULL,
	[Observaciones] [nvarchar](max) NULL,
	[AlmacenId] [int] NOT NULL,
	[EmpleadoId] [int] NOT NULL,
 CONSTRAINT [PK_DocumentosReferencia] PRIMARY KEY CLUSTERED 
(
	[DocumentoReferenciaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PV_Programaciones]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PV_Programaciones](
	[ProgramacionId] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProgramacion] [nvarchar](max) NOT NULL,
	[Periodicidad] [nvarchar](max) NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFin] [datetime] NOT NULL,
	[PorcentajeEncuestados] [float] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[DiasVigencia] [smallint] NOT NULL,
	[PlantillaId] [int] NOT NULL,
 CONSTRAINT [PK_Programaciones] PRIMARY KEY CLUSTERED 
(
	[ProgramacionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PV_PlantillasDetalle]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PV_PlantillasDetalle](
	[PlantillaDetalleId] [int] IDENTITY(1,1) NOT NULL,
	[CodigoPregunta] [nvarchar](max) NOT NULL,
	[DescripcionPregunta] [nvarchar](max) NOT NULL,
	[Respuesta1] [nvarchar](max) NOT NULL,
	[Respuesta2] [nvarchar](max) NOT NULL,
	[Respuesta3] [nvarchar](max) NOT NULL,
	[Respuesta4] [nvarchar](max) NOT NULL,
	[Respuesta5] [nvarchar](max) NOT NULL,
	[PlantillaId] [int] NOT NULL,
 CONSTRAINT [PK_PlantillasDetalle] PRIMARY KEY CLUSTERED 
(
	[PlantillaDetalleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PV_InformesResultado]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PV_InformesResultado](
	[InformeResultadoId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[FechaElaboracion] [nvarchar](max) NOT NULL,
	[FechaTabIni] [nvarchar](max) NOT NULL,
	[FechaTabFin] [nvarchar](max) NOT NULL,
	[DetalleAnalisis] [nvarchar](max) NOT NULL,
	[ElaboradoPorId] [int] NOT NULL,
	[PlantillaId] [int] NOT NULL,
 CONSTRAINT [PK_InformesResultado] PRIMARY KEY CLUSTERED 
(
	[InformeResultadoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_EX_PackingList]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_EX_PackingList](
	[CodigoPickingList] [int] NOT NULL,
	[NroBulto] [int] NULL,
	[Contenido] [varchar](50) NULL,
	[Dimensiones] [int] NULL,
	[Peso] [numeric](18, 2) NULL,
	[VolumenTotal] [numeric](18, 2) NULL,
	[PesoTotal] [numeric](18, 2) NULL,
	[PesoBrutoTotal] [numeric](18, 2) NULL,
	[CodigoSolAtencion] [int] NULL,
 CONSTRAINT [PK_PackingList] PRIMARY KEY CLUSTERED 
(
	[CodigoPickingList] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_EX_IATA]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_EX_IATA](
	[CodigoIata] [char](10) NOT NULL,
	[CodigoPais] [int] NOT NULL,
	[DescripcionIata] [varchar](50) NULL,
 CONSTRAINT [PK_IATA] PRIMARY KEY CLUSTERED 
(
	[CodigoIata] ASC,
	[CodigoPais] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_Lotes]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Lotes](
	[LoteId] [int] IDENTITY(1,1) NOT NULL,
	[NroLote] [nvarchar](max) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[TipoLoteId] [int] NOT NULL,
 CONSTRAINT [PK_Lotes] PRIMARY KEY CLUSTERED 
(
	[LoteId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_VT_Clientes]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_Clientes](
	[ClienteId] [int] NOT NULL,
	[TipoTerceroId] [int] NOT NULL,
	[Nombre] [nchar](100) NOT NULL,
	[ApellidoPaterno] [nchar](50) NOT NULL,
	[ApellidoMaterno] [nchar](50) NOT NULL,
	[PrimerNombre] [nchar](50) NOT NULL,
	[SegundoNombre] [nchar](50) NOT NULL,
	[RazonSocial] [varchar](50) NOT NULL,
	[TipoDocIdentidadId] [int] NOT NULL,
	[Ruc] [int] NULL,
	[DocIdentidad] [varchar](20) NOT NULL,
	[Activo] [bit] NOT NULL,
	[DireccionPrincipalId] [int] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[LineaCredito] [decimal](18, 4) NOT NULL,
	[ModalidadCreditoId] [int] NOT NULL,
	[DiasCredito] [int] NOT NULL,
	[TipoMedioDePagoId] [int] NOT NULL,
	[CreditoContado] [bit] NOT NULL,
	[CategoriaClienteId] [int] NOT NULL,
	[LineaCreditoActiva] [bit] NOT NULL,
	[Email] [nchar](40) NULL,
	[Codigo] [nchar](10) NULL,
	[CodigoPais] [char](10) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Observaciones] [varchar](100) NOT NULL,
	[Usuario] [char](10) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_SE_UsersInRoles]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SE_UsersInRoles](
	[RoleId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_UsersInRoles] PRIMARY KEY NONCLUSTERED 
(
	[RoleId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_AL_EmpleadoAlmacen]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AL_EmpleadoAlmacen](
	[EmpleadoId] [int] NOT NULL,
	[AlmacenId] [int] NOT NULL,
 CONSTRAINT [PK_EmpleadoAlmacen] PRIMARY KEY NONCLUSTERED 
(
	[EmpleadoId] ASC,
	[AlmacenId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_VT_ListaPrecioDetalle]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_VT_ListaPrecioDetalle](
	[ListaPrecioId] [int] NULL,
	[CostoVenta] [decimal](18, 0) NULL,
	[Margen] [decimal](18, 0) NULL,
	[Utilidad] [decimal](18, 0) NULL,
	[Precio] [decimal](18, 0) NULL,
	[Recargo] [decimal](18, 0) NULL,
	[Descuento] [decimal](18, 0) NULL,
	[Porcentaje] [decimal](18, 0) NULL,
	[Vigencia] [bit] NULL,
	[FechaDesde] [date] NULL,
	[FechaHasta] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_VT_Pedido]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_Pedido](
	[PedidoId] [int] NOT NULL,
	[ClienteId] [int] NOT NULL,
	[FechaEmision] [datetime] NOT NULL,
	[FechaEntrega] [datetime] NOT NULL,
	[ModalidadCreditoId] [int] NOT NULL,
	[FechaPago] [datetime] NOT NULL,
	[Credito] [bit] NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[EmpleadoId] [int] NOT NULL,
	[Observacion] [varchar](30) NOT NULL,
	[PrecioIncluyeImpuesto] [bit] NOT NULL,
	[EstadoFacturacion] [varchar](20) NOT NULL,
	[DireccionEntrega] [varchar](100) NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[PedidoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_Requerimiento]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_Requerimiento](
	[CodigoReq] [int] NOT NULL,
	[Destino] [varchar](50) NOT NULL,
	[IATA] [varchar](50) NOT NULL,
	[FechaRegistro] [date] NOT NULL,
	[FechaEsperada] [date] NOT NULL,
	[PrecioAprox] [money] NOT NULL,
	[Estado] [char](10) NOT NULL,
	[Observaciones] [varchar](50) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[CodigoPais] [int] NULL,
 CONSTRAINT [PK_Requerimiento] PRIMARY KEY CLUSTERED 
(
	[CodigoReq] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_EX_PackingListDetalle]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_EX_PackingListDetalle](
	[CodigoPickingList] [int] NULL,
	[Descripcion] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_EX_FormatoDocumento]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_EX_FormatoDocumento](
	[CodigoFormato] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[FechaRegistro] [date] NULL,
	[FormatoDocumento] [varchar](50) NULL,
	[CodigoPickingList] [int] NULL,
 CONSTRAINT [PK_Table_CodigoFormato] PRIMARY KEY CLUSTERED 
(
	[CodigoFormato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PV_Encuestas]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PV_Encuestas](
	[EncuestaId] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaRespuesta] [datetime] NOT NULL,
	[Titulo] [nvarchar](max) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[ProgramacionId] [int] NOT NULL,
 CONSTRAINT [PK_Encuestas] PRIMARY KEY CLUSTERED 
(
	[EncuestaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_AL_DetalleSolicitudEntrada]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AL_DetalleSolicitudEntrada](
	[ProductoId] [int] NOT NULL,
	[SolicitudEntradaId] [int] NOT NULL,
	[Cantidad] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DetalleSolicitudEntrada] PRIMARY KEY CLUSTERED 
(
	[ProductoId] ASC,
	[SolicitudEntradaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_AL_DocumentosReferenciaGuiaEntrada]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AL_DocumentosReferenciaGuiaEntrada](
	[GuiaEntradaId] [int] NOT NULL,
	[SolicitudEntradaId] [int] NOT NULL,
 CONSTRAINT [PK_DocumentosReferencia_GuiaEntrada] PRIMARY KEY CLUSTERED 
(
	[GuiaEntradaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_AL_DocumentosReferenciaAjusteInventario]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AL_DocumentosReferenciaAjusteInventario](
	[Estado] [int] NOT NULL,
	[DocumentoReferenciaId] [int] NOT NULL,
 CONSTRAINT [PK_DocumentosReferencia_AjusteInventario] PRIMARY KEY CLUSTERED 
(
	[DocumentoReferenciaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_AL_Kardex]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AL_Kardex](
	[KardexId] [int] IDENTITY(1,1) NOT NULL,
	[TipoMovimiento] [int] NOT NULL,
	[Cantidad] [nvarchar](max) NOT NULL,
	[ValorUnitario] [float] NOT NULL,
	[DocumentoReferenciaId] [int] NOT NULL,
	[AlmacenId] [int] NOT NULL,
	[ProductoId] [int] NOT NULL,
 CONSTRAINT [PK_Kardex] PRIMARY KEY CLUSTERED 
(
	[KardexId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_DetalleRequerimiento]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_DetalleRequerimiento](
	[CodigoReq] [int] NULL,
	[Cantidad] [int] NOT NULL,
	[CIF] [money] NULL,
	[FOB] [money] NULL,
	[CodigoDocExport] [int] NULL,
	[CodigoSolAtencion] [int] NULL,
	[ProductoId] [int] NULL,
	[CodigoDocSiicex] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PV_PlantillaDetalleEncuesta]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PV_PlantillaDetalleEncuesta](
	[PlantillaDetalleId] [int] NOT NULL,
	[EncuestaId] [int] NOT NULL,
 CONSTRAINT [PK_PlantillaDetalleEncuesta] PRIMARY KEY NONCLUSTERED 
(
	[PlantillaDetalleId] ASC,
	[EncuestaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_VT_DetallePedido]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_DetallePedido](
	[PedidoId] [int] NOT NULL,
	[ProductoId] [int] NULL,
	[Cantidad] [decimal](10, 2) NULL,
	[Total] [decimal](10, 2) NULL,
	[Observacion] [varchar](100) NULL,
	[DetallePedidoId] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_VT_Facturas]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_Facturas](
	[FacturaId] [int] NOT NULL,
	[NumeroFact] [int] NULL,
	[ClienteId] [int] NOT NULL,
	[FechaEmision] [datetime] NOT NULL,
	[FechaEntrega] [datetime] NOT NULL,
	[ModalidadCreditoId] [int] NOT NULL,
	[FechaPago] [datetime] NOT NULL,
	[Credito] [bit] NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[EmpleadoId] [int] NOT NULL,
	[Observacion] [varchar](30) NOT NULL,
	[ValorVenta] [float] NOT NULL,
	[PrecioIncluyeImpuesto] [bit] NOT NULL,
	[EstadoFacturacion] [varchar](20) NOT NULL,
	[DireccionEntrega] [varchar](50) NOT NULL,
	[Subtotal] [numeric](18, 2) NULL,
	[MontoIGV] [numeric](18, 2) NULL,
	[Total] [numeric](18, 2) NULL,
	[Observaciones] [varchar](50) NULL,
	[FechaRegistro] [date] NULL,
	[FechaVencimiento] [date] NULL,
	[CodigoSolAtencion] [int] NULL,
	[CodigoReq] [int] NULL,
	[CodigoFormato] [int] NULL,
 CONSTRAINT [PK_ComprobanteVenta] PRIMARY KEY CLUSTERED 
(
	[FacturaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_VT_FacturaDetalles]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_VT_FacturaDetalles](
	[FacturaDetalleId] [int] NOT NULL,
	[FacturaId] [int] NOT NULL,
	[ProductoId] [int] NULL,
	[Cantidad] [decimal](10, 2) NULL,
	[Valortotal] [decimal](10, 2) NULL,
	[Observacion] [varchar](100) NULL,
	[CodigoReq] [int] NULL,
 CONSTRAINT [PK_FacturaDetalles_1] PRIMARY KEY CLUSTERED 
(
	[FacturaDetalleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_PV_Reclamos]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PV_Reclamos](
	[ReclamoId] [int] IDENTITY(1,1) NOT NULL,
	[CodigoReclamo] [nvarchar](max) NOT NULL,
	[FechaHoraReclamo] [date] NOT NULL,
	[Motivo] [nvarchar](max) NOT NULL,
	[Detalle] [nvarchar](max) NOT NULL,
	[Observaciones] [nvarchar](max) NULL,
	[FechaRespuesta] [datetime] NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[RegistradoPorId] [int] NOT NULL,
	[FacturaDetalleId] [int] NOT NULL,
 CONSTRAINT [PK_Reclamos] PRIMARY KEY CLUSTERED 
(
	[ReclamoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PV_InformesReclamo]    Script Date: 07/01/2015 23:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PV_InformesReclamo](
	[InformeReclamoId] [int] IDENTITY(1,1) NOT NULL,
	[CodigoInforme] [nvarchar](max) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[DetalleInforme] [nvarchar](max) NOT NULL,
	[FechaAprobacion] [datetime] NOT NULL,
	[FechaElaboracion] [datetime] NOT NULL,
	[ObservacionAprobador] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[ReclamoId] [int] NOT NULL,
	[ElaboradoPorId] [int] NOT NULL,
	[AprobadoPorId] [int] NULL,
 CONSTRAINT [PK_InformesReclamo] PRIMARY KEY CLUSTERED 
(
	[InformeReclamoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_ProductoSolicitudEntradaProducto]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_DetalleSolicitudEntrada]  WITH CHECK ADD  CONSTRAINT [FK_ProductoSolicitudEntradaProducto] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[TB_AL_Productos] ([ProductoId])
GO
ALTER TABLE [dbo].[TB_AL_DetalleSolicitudEntrada] CHECK CONSTRAINT [FK_ProductoSolicitudEntradaProducto]
GO
/****** Object:  ForeignKey [FK_SolicitudEntradaSolicitudEntradaProducto]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_DetalleSolicitudEntrada]  WITH CHECK ADD  CONSTRAINT [FK_SolicitudEntradaSolicitudEntradaProducto] FOREIGN KEY([SolicitudEntradaId])
REFERENCES [dbo].[TB_AL_SolicitudesEntrada] ([SolicitudEntradaId])
GO
ALTER TABLE [dbo].[TB_AL_DetalleSolicitudEntrada] CHECK CONSTRAINT [FK_SolicitudEntradaSolicitudEntradaProducto]
GO
/****** Object:  ForeignKey [FK_DocumentoReferenciaAlmacen]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_DocumentosReferencia]  WITH CHECK ADD  CONSTRAINT [FK_DocumentoReferenciaAlmacen] FOREIGN KEY([AlmacenId])
REFERENCES [dbo].[TB_AL_Almacenes] ([AlmacenId])
GO
ALTER TABLE [dbo].[TB_AL_DocumentosReferencia] CHECK CONSTRAINT [FK_DocumentoReferenciaAlmacen]
GO
/****** Object:  ForeignKey [FK_EmpleadoDocumentoReferencia]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_DocumentosReferencia]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoDocumentoReferencia] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[TB_RH_Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[TB_AL_DocumentosReferencia] CHECK CONSTRAINT [FK_EmpleadoDocumentoReferencia]
GO
/****** Object:  ForeignKey [FK_EmpleadosUserProfile]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_RH_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadosUserProfile] FOREIGN KEY([UserId])
REFERENCES [dbo].[TB_SE_UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[TB_RH_Empleados] CHECK CONSTRAINT [FK_EmpleadosUserProfile]
GO
/****** Object:  ForeignKey [FK_AjusteInventario_inherits_DocumentoReferencia]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_DocumentosReferenciaAjusteInventario]  WITH CHECK ADD  CONSTRAINT [FK_AjusteInventario_inherits_DocumentoReferencia] FOREIGN KEY([DocumentoReferenciaId])
REFERENCES [dbo].[TB_AL_DocumentosReferencia] ([DocumentoReferenciaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TB_AL_DocumentosReferenciaAjusteInventario] CHECK CONSTRAINT [FK_AjusteInventario_inherits_DocumentoReferencia]
GO
/****** Object:  ForeignKey [FK_GuiaEntradaSolicitudEntrada]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_DocumentosReferenciaGuiaEntrada]  WITH CHECK ADD  CONSTRAINT [FK_GuiaEntradaSolicitudEntrada] FOREIGN KEY([SolicitudEntradaId])
REFERENCES [dbo].[TB_AL_SolicitudesEntrada] ([SolicitudEntradaId])
GO
ALTER TABLE [dbo].[TB_AL_DocumentosReferenciaGuiaEntrada] CHECK CONSTRAINT [FK_GuiaEntradaSolicitudEntrada]
GO
/****** Object:  ForeignKey [FK_EmpleadoAlmacen_Almacen]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_EmpleadoAlmacen]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoAlmacen_Almacen] FOREIGN KEY([AlmacenId])
REFERENCES [dbo].[TB_AL_Almacenes] ([AlmacenId])
GO
ALTER TABLE [dbo].[TB_AL_EmpleadoAlmacen] CHECK CONSTRAINT [FK_EmpleadoAlmacen_Almacen]
GO
/****** Object:  ForeignKey [FK_EmpleadoAlmacen_Empleado]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_EmpleadoAlmacen]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoAlmacen_Empleado] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[TB_RH_Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[TB_AL_EmpleadoAlmacen] CHECK CONSTRAINT [FK_EmpleadoAlmacen_Empleado]
GO
/****** Object:  ForeignKey [FK_AlmacenKardex]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_Kardex]  WITH CHECK ADD  CONSTRAINT [FK_AlmacenKardex] FOREIGN KEY([AlmacenId])
REFERENCES [dbo].[TB_AL_Almacenes] ([AlmacenId])
GO
ALTER TABLE [dbo].[TB_AL_Kardex] CHECK CONSTRAINT [FK_AlmacenKardex]
GO
/****** Object:  ForeignKey [FK_DocumentoReferenciaKardex]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_Kardex]  WITH CHECK ADD  CONSTRAINT [FK_DocumentoReferenciaKardex] FOREIGN KEY([DocumentoReferenciaId])
REFERENCES [dbo].[TB_AL_DocumentosReferencia] ([DocumentoReferenciaId])
GO
ALTER TABLE [dbo].[TB_AL_Kardex] CHECK CONSTRAINT [FK_DocumentoReferenciaKardex]
GO
/****** Object:  ForeignKey [FK_ProductoKardex]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_Kardex]  WITH CHECK ADD  CONSTRAINT [FK_ProductoKardex] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[TB_AL_Productos] ([ProductoId])
GO
ALTER TABLE [dbo].[TB_AL_Kardex] CHECK CONSTRAINT [FK_ProductoKardex]
GO
/****** Object:  ForeignKey [FK_ReservaStock_SolicitudAtencion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_ReservaStock]  WITH CHECK ADD  CONSTRAINT [FK_ReservaStock_SolicitudAtencion] FOREIGN KEY([CodigoSolAtencion])
REFERENCES [dbo].[TB_EX_SolicitudAtencion] ([CodigoSolAtencion])
GO
ALTER TABLE [dbo].[TB_AL_ReservaStock] CHECK CONSTRAINT [FK_ReservaStock_SolicitudAtencion]
GO
/****** Object:  ForeignKey [FK_EmpleadoSolicitudEntrada]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_AL_SolicitudesEntrada]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoSolicitudEntrada] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[TB_RH_Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[TB_AL_SolicitudesEntrada] CHECK CONSTRAINT [FK_EmpleadoSolicitudEntrada]
GO
/****** Object:  ForeignKey [FK_Contrato_SolicitudAtencion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_Contrato]  WITH CHECK ADD  CONSTRAINT [FK_Contrato_SolicitudAtencion] FOREIGN KEY([CodigoSolAtencion])
REFERENCES [dbo].[TB_EX_SolicitudAtencion] ([CodigoSolAtencion])
GO
ALTER TABLE [dbo].[TB_Contrato] CHECK CONSTRAINT [FK_Contrato_SolicitudAtencion]
GO
/****** Object:  ForeignKey [FK_CronogramaDespacho_SolicitudAtencion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_CronogramaDespacho]  WITH CHECK ADD  CONSTRAINT [FK_CronogramaDespacho_SolicitudAtencion] FOREIGN KEY([CodigoSolAtencion])
REFERENCES [dbo].[TB_EX_SolicitudAtencion] ([CodigoSolAtencion])
GO
ALTER TABLE [dbo].[TB_CronogramaDespacho] CHECK CONSTRAINT [FK_CronogramaDespacho_SolicitudAtencion]
GO
/****** Object:  ForeignKey [FK_CronogramaEmbarque_SolixitudAtencion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_CronogramaEmbarque]  WITH CHECK ADD  CONSTRAINT [FK_CronogramaEmbarque_SolixitudAtencion] FOREIGN KEY([CodigoSolAtencion])
REFERENCES [dbo].[TB_EX_SolicitudAtencion] ([CodigoSolAtencion])
GO
ALTER TABLE [dbo].[TB_CronogramaEmbarque] CHECK CONSTRAINT [FK_CronogramaEmbarque_SolixitudAtencion]
GO
/****** Object:  ForeignKey [FK_DetalleRequerimiento_DocumentoExportacion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_DetalleRequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_DetalleRequerimiento_DocumentoExportacion] FOREIGN KEY([CodigoDocExport])
REFERENCES [dbo].[TB_EX_DocumentoExportacion] ([CodigoDocExport])
GO
ALTER TABLE [dbo].[TB_DetalleRequerimiento] CHECK CONSTRAINT [FK_DetalleRequerimiento_DocumentoExportacion]
GO
/****** Object:  ForeignKey [FK_DetalleRequerimiento_DocumentoSIICEX]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_DetalleRequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_DetalleRequerimiento_DocumentoSIICEX] FOREIGN KEY([CodigoDocSiicex])
REFERENCES [dbo].[TB_EX_DocumentoSIICEX] ([CodigoDocSiicex])
GO
ALTER TABLE [dbo].[TB_DetalleRequerimiento] CHECK CONSTRAINT [FK_DetalleRequerimiento_DocumentoSIICEX]
GO
/****** Object:  ForeignKey [FK_DetalleRequerimiento_Productos]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_DetalleRequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_DetalleRequerimiento_Productos] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[TB_AL_Productos] ([ProductoId])
GO
ALTER TABLE [dbo].[TB_DetalleRequerimiento] CHECK CONSTRAINT [FK_DetalleRequerimiento_Productos]
GO
/****** Object:  ForeignKey [FK_DetalleRequerimiento_Requerimiento]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_DetalleRequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_DetalleRequerimiento_Requerimiento] FOREIGN KEY([CodigoReq])
REFERENCES [dbo].[TB_Requerimiento] ([CodigoReq])
GO
ALTER TABLE [dbo].[TB_DetalleRequerimiento] CHECK CONSTRAINT [FK_DetalleRequerimiento_Requerimiento]
GO
/****** Object:  ForeignKey [FK_DetalleRequerimiento_SolicitudAtencion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_DetalleRequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_DetalleRequerimiento_SolicitudAtencion] FOREIGN KEY([CodigoSolAtencion])
REFERENCES [dbo].[TB_EX_SolicitudAtencion] ([CodigoSolAtencion])
GO
ALTER TABLE [dbo].[TB_DetalleRequerimiento] CHECK CONSTRAINT [FK_DetalleRequerimiento_SolicitudAtencion]
GO
/****** Object:  ForeignKey [FK_DetalleDocExportacion_DocumentoExportacion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_EX_DetalleDocExportacion]  WITH CHECK ADD  CONSTRAINT [FK_DetalleDocExportacion_DocumentoExportacion] FOREIGN KEY([CodigoDocExport])
REFERENCES [dbo].[TB_EX_DocumentoExportacion] ([CodigoDocExport])
GO
ALTER TABLE [dbo].[TB_EX_DetalleDocExportacion] CHECK CONSTRAINT [FK_DetalleDocExportacion_DocumentoExportacion]
GO
/****** Object:  ForeignKey [FK_DetalleDocExportacion_DocumentoSIICEX]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_EX_DetalleDocExportacion]  WITH CHECK ADD  CONSTRAINT [FK_DetalleDocExportacion_DocumentoSIICEX] FOREIGN KEY([CodigoDocSiicex])
REFERENCES [dbo].[TB_EX_DocumentoSIICEX] ([CodigoDocSiicex])
GO
ALTER TABLE [dbo].[TB_EX_DetalleDocExportacion] CHECK CONSTRAINT [FK_DetalleDocExportacion_DocumentoSIICEX]
GO
/****** Object:  ForeignKey [FK_FormatoDocumento_PackingList]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_EX_FormatoDocumento]  WITH CHECK ADD  CONSTRAINT [FK_FormatoDocumento_PackingList] FOREIGN KEY([CodigoPickingList])
REFERENCES [dbo].[TB_EX_PackingList] ([CodigoPickingList])
GO
ALTER TABLE [dbo].[TB_EX_FormatoDocumento] CHECK CONSTRAINT [FK_FormatoDocumento_PackingList]
GO
/****** Object:  ForeignKey [FK_IATA_Pais]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_EX_IATA]  WITH CHECK ADD  CONSTRAINT [FK_IATA_Pais] FOREIGN KEY([CodigoPais])
REFERENCES [dbo].[TB_MA_Pais] ([CodigoPais])
GO
ALTER TABLE [dbo].[TB_EX_IATA] CHECK CONSTRAINT [FK_IATA_Pais]
GO
/****** Object:  ForeignKey [FK_PackingList_SolicitudAtencion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_EX_PackingList]  WITH CHECK ADD  CONSTRAINT [FK_PackingList_SolicitudAtencion] FOREIGN KEY([CodigoSolAtencion])
REFERENCES [dbo].[TB_EX_SolicitudAtencion] ([CodigoSolAtencion])
GO
ALTER TABLE [dbo].[TB_EX_PackingList] CHECK CONSTRAINT [FK_PackingList_SolicitudAtencion]
GO
/****** Object:  ForeignKey [FK_PackingListDetalle_PackingList]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_EX_PackingListDetalle]  WITH CHECK ADD  CONSTRAINT [FK_PackingListDetalle_PackingList] FOREIGN KEY([CodigoPickingList])
REFERENCES [dbo].[TB_EX_PackingList] ([CodigoPickingList])
GO
ALTER TABLE [dbo].[TB_EX_PackingListDetalle] CHECK CONSTRAINT [FK_PackingListDetalle_PackingList]
GO
/****** Object:  ForeignKey [FK_LoteTipoLote]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_Lotes]  WITH CHECK ADD  CONSTRAINT [FK_LoteTipoLote] FOREIGN KEY([TipoLoteId])
REFERENCES [dbo].[TB_TipoLotes] ([TipoLoteId])
GO
ALTER TABLE [dbo].[TB_Lotes] CHECK CONSTRAINT [FK_LoteTipoLote]
GO
/****** Object:  ForeignKey [FK_EncuestaProgramacion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_Encuestas]  WITH CHECK ADD  CONSTRAINT [FK_EncuestaProgramacion] FOREIGN KEY([ProgramacionId])
REFERENCES [dbo].[TB_PV_Programaciones] ([ProgramacionId])
GO
ALTER TABLE [dbo].[TB_PV_Encuestas] CHECK CONSTRAINT [FK_EncuestaProgramacion]
GO
/****** Object:  ForeignKey [FK_Encuestas_Clientes]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_Encuestas]  WITH CHECK ADD  CONSTRAINT [FK_Encuestas_Clientes] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[TB_VT_Clientes] ([ClienteId])
GO
ALTER TABLE [dbo].[TB_PV_Encuestas] CHECK CONSTRAINT [FK_Encuestas_Clientes]
GO
/****** Object:  ForeignKey [FK_EmpleadoInformeReclamoAprobadoPor]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_InformesReclamo]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoInformeReclamoAprobadoPor] FOREIGN KEY([AprobadoPorId])
REFERENCES [dbo].[TB_RH_Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[TB_PV_InformesReclamo] CHECK CONSTRAINT [FK_EmpleadoInformeReclamoAprobadoPor]
GO
/****** Object:  ForeignKey [FK_EmpleadoInformeReclamoElaboradoPor]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_InformesReclamo]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoInformeReclamoElaboradoPor] FOREIGN KEY([ElaboradoPorId])
REFERENCES [dbo].[TB_RH_Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[TB_PV_InformesReclamo] CHECK CONSTRAINT [FK_EmpleadoInformeReclamoElaboradoPor]
GO
/****** Object:  ForeignKey [FK_ReclamoInformeReclamo]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_InformesReclamo]  WITH CHECK ADD  CONSTRAINT [FK_ReclamoInformeReclamo] FOREIGN KEY([ReclamoId])
REFERENCES [dbo].[TB_PV_Reclamos] ([ReclamoId])
GO
ALTER TABLE [dbo].[TB_PV_InformesReclamo] CHECK CONSTRAINT [FK_ReclamoInformeReclamo]
GO
/****** Object:  ForeignKey [FK_InformeResultadoEmpleado]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_InformesResultado]  WITH CHECK ADD  CONSTRAINT [FK_InformeResultadoEmpleado] FOREIGN KEY([ElaboradoPorId])
REFERENCES [dbo].[TB_RH_Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[TB_PV_InformesResultado] CHECK CONSTRAINT [FK_InformeResultadoEmpleado]
GO
/****** Object:  ForeignKey [FK_PlantillaTiposPlantilla]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_Plantillas]  WITH CHECK ADD  CONSTRAINT [FK_PlantillaTiposPlantilla] FOREIGN KEY([TipoPlantillaId])
REFERENCES [dbo].[TB_PV_TiposPlantilla] ([TipoPlantillaId])
GO
ALTER TABLE [dbo].[TB_PV_Plantillas] CHECK CONSTRAINT [FK_PlantillaTiposPlantilla]
GO
/****** Object:  ForeignKey [FK_PlantillaInformeResultado]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_InformesResultado]  WITH CHECK ADD  CONSTRAINT [FK_PlantillaInformeResultado] FOREIGN KEY([PlantillaId])
REFERENCES [dbo].[TB_PV_Plantillas] ([PlantillaId])
GO
ALTER TABLE [dbo].[TB_PV_InformesResultado] CHECK CONSTRAINT [FK_PlantillaInformeResultado]
GO
/****** Object:  ForeignKey [FK_PlantillaDetalleEncuesta_Encuesta]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_PlantillaDetalleEncuesta]  WITH CHECK ADD  CONSTRAINT [FK_PlantillaDetalleEncuesta_Encuesta] FOREIGN KEY([EncuestaId])
REFERENCES [dbo].[TB_PV_Encuestas] ([EncuestaId])
GO
ALTER TABLE [dbo].[TB_PV_PlantillaDetalleEncuesta] CHECK CONSTRAINT [FK_PlantillaDetalleEncuesta_Encuesta]
GO
/****** Object:  ForeignKey [FK_PlantillaDetalleEncuesta_PlantillaDetalle]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_PlantillaDetalleEncuesta]  WITH CHECK ADD  CONSTRAINT [FK_PlantillaDetalleEncuesta_PlantillaDetalle] FOREIGN KEY([PlantillaDetalleId])
REFERENCES [dbo].[TB_PV_PlantillasDetalle] ([PlantillaDetalleId])
GO
ALTER TABLE [dbo].[TB_PV_PlantillaDetalleEncuesta] CHECK CONSTRAINT [FK_PlantillaDetalleEncuesta_PlantillaDetalle]
GO
/****** Object:  ForeignKey [FK_PlantillaDetallePlantilla]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_PlantillasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_PlantillaDetallePlantilla] FOREIGN KEY([PlantillaId])
REFERENCES [dbo].[TB_PV_Plantillas] ([PlantillaId])
GO
ALTER TABLE [dbo].[TB_PV_PlantillasDetalle] CHECK CONSTRAINT [FK_PlantillaDetallePlantilla]
GO
/****** Object:  ForeignKey [FK_ProgramacionPlantilla]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_Programaciones]  WITH CHECK ADD  CONSTRAINT [FK_ProgramacionPlantilla] FOREIGN KEY([PlantillaId])
REFERENCES [dbo].[TB_PV_Plantillas] ([PlantillaId])
GO
ALTER TABLE [dbo].[TB_PV_Programaciones] CHECK CONSTRAINT [FK_ProgramacionPlantilla]
GO
/****** Object:  ForeignKey [FK_EmpleadoReclamoResgistradoPor]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_Reclamos]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoReclamoResgistradoPor] FOREIGN KEY([RegistradoPorId])
REFERENCES [dbo].[TB_RH_Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[TB_PV_Reclamos] CHECK CONSTRAINT [FK_EmpleadoReclamoResgistradoPor]
GO
/****** Object:  ForeignKey [FK_Reclamos_FacturaDetalles]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_PV_Reclamos]  WITH CHECK ADD  CONSTRAINT [FK_Reclamos_FacturaDetalles] FOREIGN KEY([FacturaDetalleId])
REFERENCES [dbo].[TB_VT_FacturaDetalles] ([FacturaDetalleId])
GO
ALTER TABLE [dbo].[TB_PV_Reclamos] CHECK CONSTRAINT [FK_Reclamos_FacturaDetalles]
GO
/****** Object:  ForeignKey [FK_Requerimiento_Clientes]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_Requerimiento_Clientes] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[TB_VT_Clientes] ([ClienteId])
GO
ALTER TABLE [dbo].[TB_Requerimiento] CHECK CONSTRAINT [FK_Requerimiento_Clientes]
GO
/****** Object:  ForeignKey [FK_Requerimiento_Pais]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_Requerimiento_Pais] FOREIGN KEY([CodigoPais])
REFERENCES [dbo].[TB_MA_Pais] ([CodigoPais])
GO
ALTER TABLE [dbo].[TB_Requerimiento] CHECK CONSTRAINT [FK_Requerimiento_Pais]
GO
/****** Object:  ForeignKey [FK_UsersInRoles_Roles]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_SE_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UsersInRoles_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[TB_SE_Roles] ([RoleId])
GO
ALTER TABLE [dbo].[TB_SE_UsersInRoles] CHECK CONSTRAINT [FK_UsersInRoles_Roles]
GO
/****** Object:  ForeignKey [FK_UsersInRoles_UserProfile]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_SE_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UsersInRoles_UserProfile] FOREIGN KEY([UserId])
REFERENCES [dbo].[TB_SE_UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[TB_SE_UsersInRoles] CHECK CONSTRAINT [FK_UsersInRoles_UserProfile]
GO
/****** Object:  ForeignKey [FK_Clientes_Direccion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Direccion] FOREIGN KEY([DireccionPrincipalId])
REFERENCES [dbo].[TB_VT_Direccion] ([DireccionId])
GO
ALTER TABLE [dbo].[TB_VT_Clientes] CHECK CONSTRAINT [FK_Clientes_Direccion]
GO
/****** Object:  ForeignKey [FK_detallepedido_Pedido]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_detallepedido_Pedido] FOREIGN KEY([PedidoId])
REFERENCES [dbo].[TB_VT_Pedido] ([PedidoId])
GO
ALTER TABLE [dbo].[TB_VT_DetallePedido] CHECK CONSTRAINT [FK_detallepedido_Pedido]
GO
/****** Object:  ForeignKey [FK_detallepedido_Productos]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_detallepedido_Productos] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[TB_AL_Productos] ([ProductoId])
GO
ALTER TABLE [dbo].[TB_VT_DetallePedido] CHECK CONSTRAINT [FK_detallepedido_Productos]
GO
/****** Object:  ForeignKey [FK_FacturaDetalles_Facturas]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_FacturaDetalles]  WITH CHECK ADD  CONSTRAINT [FK_FacturaDetalles_Facturas] FOREIGN KEY([FacturaId])
REFERENCES [dbo].[TB_VT_Facturas] ([FacturaId])
GO
ALTER TABLE [dbo].[TB_VT_FacturaDetalles] CHECK CONSTRAINT [FK_FacturaDetalles_Facturas]
GO
/****** Object:  ForeignKey [FK_FacturaDetalles_Productos]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_FacturaDetalles]  WITH CHECK ADD  CONSTRAINT [FK_FacturaDetalles_Productos] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[TB_AL_Productos] ([ProductoId])
GO
ALTER TABLE [dbo].[TB_VT_FacturaDetalles] CHECK CONSTRAINT [FK_FacturaDetalles_Productos]
GO
/****** Object:  ForeignKey [FK_Facturas_Clientes]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[TB_VT_Clientes] ([ClienteId])
GO
ALTER TABLE [dbo].[TB_VT_Facturas] CHECK CONSTRAINT [FK_Facturas_Clientes]
GO
/****** Object:  ForeignKey [FK_Facturas_Empleados]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Empleados] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[TB_RH_Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[TB_VT_Facturas] CHECK CONSTRAINT [FK_Facturas_Empleados]
GO
/****** Object:  ForeignKey [FK_Facturas_ModalidadCredito]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_ModalidadCredito] FOREIGN KEY([ModalidadCreditoId])
REFERENCES [dbo].[TB_ModalidadCredito] ([ModalidadCreditoId])
GO
ALTER TABLE [dbo].[TB_VT_Facturas] CHECK CONSTRAINT [FK_Facturas_ModalidadCredito]
GO
/****** Object:  ForeignKey [FK_Facturas_Requerimiento]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Requerimiento] FOREIGN KEY([CodigoReq])
REFERENCES [dbo].[TB_Requerimiento] ([CodigoReq])
GO
ALTER TABLE [dbo].[TB_VT_Facturas] CHECK CONSTRAINT [FK_Facturas_Requerimiento]
GO
/****** Object:  ForeignKey [FK_Facturas_SolicitudAtencion]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_SolicitudAtencion] FOREIGN KEY([CodigoSolAtencion])
REFERENCES [dbo].[TB_EX_SolicitudAtencion] ([CodigoSolAtencion])
GO
ALTER TABLE [dbo].[TB_VT_Facturas] CHECK CONSTRAINT [FK_Facturas_SolicitudAtencion]
GO
/****** Object:  ForeignKey [FK_ListaPrecio_detalle_ListaPrecios]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_ListaPrecioDetalle]  WITH CHECK ADD  CONSTRAINT [FK_ListaPrecio_detalle_ListaPrecios] FOREIGN KEY([ListaPrecioId])
REFERENCES [dbo].[TB_VT_ListaPrecios] ([ListaPrecioId])
GO
ALTER TABLE [dbo].[TB_VT_ListaPrecioDetalle] CHECK CONSTRAINT [FK_ListaPrecio_detalle_ListaPrecios]
GO
/****** Object:  ForeignKey [FK_Pedido_Empleados]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Empleados] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[TB_RH_Empleados] ([EmpleadoId])
GO
ALTER TABLE [dbo].[TB_VT_Pedido] CHECK CONSTRAINT [FK_Pedido_Empleados]
GO
/****** Object:  ForeignKey [FK_TB_VT_Pedido_TB_VT_Clientes]    Script Date: 07/01/2015 23:07:56 ******/
ALTER TABLE [dbo].[TB_VT_Pedido]  WITH CHECK ADD  CONSTRAINT [FK_TB_VT_Pedido_TB_VT_Clientes] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[TB_VT_Clientes] ([ClienteId])
GO
ALTER TABLE [dbo].[TB_VT_Pedido] CHECK CONSTRAINT [FK_TB_VT_Pedido_TB_VT_Clientes]
GO
