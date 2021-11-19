USE [BdFiles]
GO
/****** Object:  StoredProcedure [dbo].[Cliente_SS]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Existe_Cliente]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Apuntes_I]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Archivo_I]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Archivo_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Carpeta_I]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Carpeta_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Casos_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Cliente_I]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Cliente_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Str_Cliente_S]
    @IdEmpresa		int 
AS
select IdCliente as Codigo,DniCliente,IdEmpresa,NombreCliente as Nombre,ApellidoCliente as Apellido,CelularCliente as Celular,CorreoCliente as Correo,PaisCliente from Cliente
GO
/****** Object:  StoredProcedure [dbo].[Str_Cliente_S1]    Script Date: 19/11/2021 12:45:19 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[Str_Cliente_S1]
    @IdEmpresa		int 
AS
select IdCliente as Codigo ,DniCliente as Dni,IdEmpresa,NombreCliente as Nombre,ApellidoCliente as Apellido,CelularCliente as Celular,CorreoCliente as Correo,PaisCliente from Cliente
GO
/****** Object:  StoredProcedure [dbo].[Str_Cliente_SS]    Script Date: 19/11/2021 12:45:19 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Str_Cliente_SS]
    @IdEmpresa		int 
AS
select DniCliente as Dni,NombreCliente as Nombre,ApellidoCliente as Apellido,CelularCliente as Celular,DireccionCliente,PaisCliente from Cliente
GO
/****** Object:  StoredProcedure [dbo].[Str_Cliente_U]    Script Date: 19/11/2021 12:45:19 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Str_Cliente_U]
@IdEmpresa		 INT ,
@DniCliente  varchar(100),
@Nombre varchar(100),
@Apellido varchar(100),
@Celular varchar(100),
@Direccion varchar(100),
@Correo varchar(100)

as
update Cliente
set NombreCliente =@Nombre,
ApellidoCliente =@Apellido,
CelularCliente=@Celular,
DireccionCliente=@Direccion,
CorreoCliente=@Correo


where IdEmpresa=@IdEmpresa and DniCliente=@DniCliente
GO
/****** Object:  StoredProcedure [dbo].[Str_Conciliacion_I]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Conciliacion_II]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Conciliacion_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Conciliacion_U]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_ConciliacionCliente_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_DocumentosConciliacion_I]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_DocumentosConciliacion_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_DocumentosConciliacionCliente_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_DocumentosMaterias_I]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Materia_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_Materias_I]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_prueba]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Str_TodosDocumentos_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[StrApuntes_S]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[StrApuntes_SS]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[TotalCasos]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
/****** Object:  StoredProcedure [dbo].[TotalClientes]    Script Date: 19/11/2021 12:45:19 a.m. ******/
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
