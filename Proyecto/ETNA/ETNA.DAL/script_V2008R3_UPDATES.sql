/*
===============================================================================================
AQUI ESTARAN LAS ACTUALIZACIONES A LA BD INTEGRADA
Considerar al momento de colocar lo siguiente:
Fecha, Autor, Rol-Modulo del grupo al que pertenece, Modulo Afectado.

Author: Paul Taboada
Modulo: Post-Venta
===============================================================================================
Example:
*/

/*
Fecha : 04 de Julio del 2015
Autor: Paul Taboada Casas
Rol: DBA PostVenta
Modulo: Seguridad
*/
ALTER TABLE TB_SE_Roles
ADD RoleDescription VARCHAR(300) DEFAULT NULL
GO

/*
Fecha : 04/07/2015
Autor: Paul Taboada Casas
Rol: DBA PostVenta
Modulo: PostVenta
*/

CREATE PROCEDURE GetPaginasRowNumber
   @NUM_PAGINA   INT
   ,@TAM_PAGINA   INT
   ,@NRO_FACTURA VARCHAR(30)
AS
   SET NOCOUNT ON;
   SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; 
   WITH DRV_TBL AS 
   (
      SELECT 
         ROW_NUMBER() OVER (ORDER BY fd.FacturaDetalleId DESC) AS rownum
         ,fd.*
         /*,f.NroFactura,c.Apellidos,c.Nombres,p.Id,p.Nombre,p.PrecioListaVenta,p.Estado*/
      FROM TB_VT_FacturaDetalles AS fd
      INNER JOIN TB_VT_Facturas AS f ON f.FacturaId = fd.FacturaId
      WHERE f.NumeroFact LIKE '%'+@NRO_FACTURA+'%' and f.EstadoFacturacion<>'A'
      /*INNER JOIN Clientes AS c ON c.Codigo = f.Cliente_Codigo
      INNER JOIN Productos AS p ON p.Id = fd.Producto_Id*/
   )
   SELECT * FROM DRV_TBL
   WHERE ROWNUM BETWEEN (@NUM_PAGINA*@TAM_PAGINA)-@TAM_PAGINA+1 AND (@NUM_PAGINA*@TAM_PAGINA)
GO

/*
Fecha : 04/07/2015
Autor: Paul Taboada Casas
Rol: DBA PostVenta
Modulo: Recursos Humanos
*/

ALTER TABLE TB_RH_Empleados
ALTER COLUMN GrupoVentaId INT NULL
GO

/*
Fecha : 04/07/2015
Autor: Paul Taboada Casas
Rol: DBA PostVenta
Modulo: PARA TODOS
*/


/*IMPORTANTE : HACER SIEMPRE CONCIDIR EL USERID con EMPLEADOID, de esa forma se nos simplifica esa parte de la programación*/

INSERT [dbo].[TB_SE_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) 
VALUES (1, CAST(0x0000A4620119316B AS DateTime), NULL, 1, NULL, 0, N'AIFI3+cfcxEdq+WHP8sIaQhFlWuXIugpzI0Ydd2kC51UyFuN1ZMyT4czvIrKcp0XgQ==', CAST(0x0000A4620119316B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[TB_SE_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) 
VALUES (2, CAST(0x0000A4620119316B AS DateTime), NULL, 1, NULL, 0, N'AKGufSA/XPH8iKxL3Wc2VLSBkCh1/M7tPEiftGE9hUtUXSQx2xy5xPJ9Y+FwTBhDVA==', CAST(0x0000A4620119316B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[TB_SE_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) 
VALUES (3, CAST(0x0000A4620119316B AS DateTime), NULL, 1, NULL, 0, N'AKGufSA/XPH8iKxL3Wc2VLSBkCh1/M7tPEiftGE9hUtUXSQx2xy5xPJ9Y+FwTBhDVA==', CAST(0x0000A4620119316B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[TB_SE_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) 
VALUES (4, CAST(0x0000A4620119316B AS DateTime), NULL, 1, NULL, 0, N'AKGufSA/XPH8iKxL3Wc2VLSBkCh1/M7tPEiftGE9hUtUXSQx2xy5xPJ9Y+FwTBhDVA==', CAST(0x0000A4620119316B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[TB_SE_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) 
VALUES (5, CAST(0x0000A4620119316B AS DateTime), NULL, 1, NULL, 0, N'AKGufSA/XPH8iKxL3Wc2VLSBkCh1/M7tPEiftGE9hUtUXSQx2xy5xPJ9Y+FwTBhDVA==', CAST(0x0000A4620119316B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[TB_SE_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) 
VALUES (6, CAST(0x0000A4620119316B AS DateTime), NULL, 1, NULL, 0, N'AKGufSA/XPH8iKxL3Wc2VLSBkCh1/M7tPEiftGE9hUtUXSQx2xy5xPJ9Y+FwTBhDVA==', CAST(0x0000A4620119316B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[TB_SE_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) 
VALUES (7, CAST(0x0000A4620119316B AS DateTime), NULL, 1, NULL, 0, N'AKGufSA/XPH8iKxL3Wc2VLSBkCh1/M7tPEiftGE9hUtUXSQx2xy5xPJ9Y+FwTBhDVA==', CAST(0x0000A4620119316B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[TB_SE_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) 
VALUES (8, CAST(0x0000A4620119316B AS DateTime), NULL, 1, NULL, 0, N'AKGufSA/XPH8iKxL3Wc2VLSBkCh1/M7tPEiftGE9hUtUXSQx2xy5xPJ9Y+FwTBhDVA==', CAST(0x0000A4620119316B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[TB_SE_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) 
VALUES (9, CAST(0x0000A4620119316B AS DateTime), NULL, 1, NULL, 0, N'AKGufSA/XPH8iKxL3Wc2VLSBkCh1/M7tPEiftGE9hUtUXSQx2xy5xPJ9Y+FwTBhDVA==', CAST(0x0000A4620119316B AS DateTime), N'', NULL, NULL)
INSERT [dbo].[TB_SE_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) 
VALUES (10, CAST(0x0000A4620119316B AS DateTime), NULL, 1, NULL, 0, N'AKGufSA/XPH8iKxL3Wc2VLSBkCh1/M7tPEiftGE9hUtUXSQx2xy5xPJ9Y+FwTBhDVA==', CAST(0x0000A4620119316B AS DateTime), N'', NULL, NULL)


INSERT INTO TB_SE_UserProfile (UserName) VALUES ('DVALDIVIA');
INSERT INTO TB_SE_UserProfile (UserName) VALUES ('MDELALCAZAR');
INSERT INTO TB_SE_UserProfile (UserName) VALUES ('JMOSCOSO'); /* Usuario: JMOSCOSO, Password: password */
INSERT INTO TB_SE_UserProfile (UserName) VALUES ('LMUNDACA');
INSERT INTO TB_SE_UserProfile (UserName) VALUES ('MFLORES');
INSERT INTO TB_SE_UserProfile (UserName) VALUES ('AAGUIRRE');
INSERT INTO TB_SE_UserProfile (UserName) VALUES ('MGUZMAN');
INSERT INTO TB_SE_UserProfile (UserName) VALUES ('LCORCIO');
INSERT INTO TB_SE_UserProfile (UserName) VALUES ('MIBERICO');
INSERT INTO TB_SE_UserProfile (UserName) VALUES ('CROJAS');

INSERT INTO TB_RH_Empleados (Nombres, Apellidos, Direccion, Cargo, UserId, Activo) 
VALUES ('DIEGO MARTIN','VALDIVIA PEREZ','PRIMAVERA 1212','ASISTENTE ALMACEN',2, 1);
INSERT INTO TB_RH_Empleados (Nombres, Apellidos, Direccion, Cargo, UserId, Activo) 
VALUES ('MIGUEL EDUARDO','DEL ALCAZAR ALVAREZ','PRIMERA JUNTA 127','ASISTENTE ALMACEN',1, 1);
INSERT INTO TB_RH_Empleados (Nombres, Apellidos, Direccion, Cargo, UserId, Activo) 
VALUES ('JOAN','MOSCOSO','AV. PERU 222','ASISTENTE ALMACEN',3, 1);
INSERT INTO TB_RH_Empleados (Nombres, Apellidos, Direccion, Cargo, UserId, Activo) 
VALUES ('LESLIE','MUNDACA','LA VICTORIA 333','ASISTENTE ALMACEN',4, 1);
INSERT INTO TB_RH_Empleados (Nombres, Apellidos, Direccion, Cargo, UserId, Activo) 
VALUES ('MIGUEL','FLOREZ','BOLIVIA 332','ASISTENTE ALMACEN',5, 1);
INSERT INTO TB_RH_Empleados (Nombres, Apellidos, Direccion, Cargo, UserId, Activo) 
VALUES ('ALBERTO','AGUIRRE','LA MOLINA 456','ASISTENTE ALMACEN',6, 1);
INSERT INTO TB_RH_Empleados (Nombres, Apellidos, Direccion, Cargo, UserId, Activo) 
VALUES ('MIGUEL','GUZMAN','SAN JUAN MIRAFLORES 444','ASISTENTE ALMACEN',7, 1);
INSERT INTO TB_RH_Empleados (Nombres, Apellidos, Direccion, Cargo, UserId, Activo) 
VALUES ('LUIS','CORCIO','FUNESTA 2223','ASISTENTE ALMACEN',8, 1);
INSERT INTO TB_RH_Empleados (Nombres, Apellidos, Direccion, Cargo, UserId, Activo) 
VALUES ('MARTIN','IBERICO','RECUAY 223','ASISTENTE ALMACEN',9, 1);
INSERT INTO TB_RH_Empleados (Nombres, Apellidos, Direccion, Cargo, UserId, Activo) 
VALUES ('CAROLINA','ROJAS','ALCANFORES 233','ASISTENTE ALMACEN',10, 1);

ALTER TABLE TB_AL_Productos
ALTER COLUMN CodigoProducto VARCHAR(10) NULL
GO

/* Productos disponibles para ETNA */
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-U1R', 'BATERIA U1R','','',10,20, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-NS40', 'BATERIA NS40','','',20,30, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-N4051', 'BATERIA N4051','','',30,40, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-NS60', 'BATERIA NS60','','',40,50, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-L18', 'BATERIA L18','','',50,60, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-L1', 'BATERIA L1','','',70,80, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-42', 'BATERIA 42','','',80,90, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-40R', 'BATERIA 40R','','',90,100, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-026', 'BATERIA 026','','',100,110, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-D26', 'BATERIA D26','','',110,120, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-D31', 'BATERIA D31','','',120,130, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-31A', 'BATERIA 31A','','',130,140, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-31T', 'BATERIA 31T','','',140,150, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-N200', 'BATERIA N200','','',150,160, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-N200 PRO', 'BATERIA N200 PRO','','',160,170, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('B-4Y', 'BATERIA 4Y','','',170,180, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('P-AH2O', 'AGUA DESTILADA','','',180,190, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('P-VOL', 'VOLTIMETRO','','',190,200, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('P-ALT', 'ALTERNADOR','','',200,250, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('P-PLO', 'PLOMO','','',10,20, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('P-MAL', 'MALLA METALICA','','',20,30, 1);
INSERT INTO TB_AL_Productos (CodigoProducto, Nombre, DescripcionCorta,DescripcionLarga, PrecioListaCompra, PrecioListaVenta, Estado)
VALUES ('P-ANI', 'ANIONES','','',30,40, 1);

/** SCCRIPT DE INSERCION -- Modulo Encuesta POSTVENTA **/
INSERT INTO TB_PV_TiposPlantilla (Descripcion) VALUES ('Ventas');
INSERT INTO TB_PV_TiposPlantilla (Descripcion) VALUES ('Reclamos');
INSERT INTO TB_PV_TiposPlantilla (Descripcion) VALUES ('Garantias');

INSERT INTO TB_PV_Plantillas (Descripcion, Estado, TipoPlantillaId) VALUES ('Proceso de Venta', 'A', 1);
INSERT INTO TB_PV_Plantillas (Descripcion, Estado, TipoPlantillaId) VALUES ('Calidad Producto', 'A', 2);
INSERT INTO TB_PV_Plantillas (Descripcion, Estado, TipoPlantillaId) VALUES ('Atención Reclamos', 'A', 3);
INSERT INTO TB_PV_Plantillas (Descripcion, Estado, TipoPlantillaId) VALUES ('Calidad Atención Reclamo', 'A', 3);

INSERT INTO TB_PV_PlantillasDetalle (CodigoPregunta, DescripcionPregunta, Respuesta1, Respuesta2, Respuesta3, Respuesta4, Respuesta5, PlantillaId) 
VALUES ('TEMP01-PR01', '¿que mejoras darias en servicio de ventas?', 'atencion personalizada al cliente', 'mejor analisis de evaluacion de ventas mensuales', 'aumento de porcentaje en comision', '', '', 1);
INSERT INTO TB_PV_PlantillasDetalle (CodigoPregunta, DescripcionPregunta, Respuesta1, Respuesta2, Respuesta3, Respuesta4, Respuesta5, PlantillaId)
VALUES ('TEMP01-PR02', '¿que motivacion necesita para realizar mas ventas?', 'bonificaciones en vacaciones', 'aumento de sueldo por mayoria de contratos ejecutados', 'ascensos de puestos', 'reconocimientos certificados en venta con historial en la hoja de vida', 'aumento de 15 dias de vacaciones', 1);

ALTER TABLE TB_VT_Clientes
DROP COLUMN Nombre
GO

ALTER TABLE TB_VT_Clientes
DROP CONSTRAINT FK_Clientes_Direccion
GO

ALTER TABLE TB_VT_Clientes
DROP COLUMN DireccionPrincipalId
GO

INSERT INTO TB_VT_Clientes (ClienteId, TipoTerceroId, Direccion, DocIdentidad, ApellidoPaterno, ApellidoMaterno, PrimerNombre, SegundoNombre, Email, RazonSocial, TipoDocIdentidadId, Activo, LineaCredito, ModalidadCreditoId, DiasCredito, TipoMedioDePagoId, CreditoContado, CategoriaClienteId, LineaCreditoActiva, CodigoPais, Telefono, Observaciones) 
VALUES (1, 1, 'Av. General Juan Antonio Prezet 1995', '98765432','Ponce', 'Pozo', 'Erika', 'Mellisa', 'malozaponce@gmail.com', 'DIGEMID - Ministerio de Salud', 1, 1, 0, 1, 0, 1, 1, 1, 0, 'es', '985578456', '');
INSERT INTO TB_VT_Clientes (ClienteId, TipoTerceroId, Direccion, DocIdentidad, ApellidoPaterno, ApellidoMaterno, PrimerNombre, SegundoNombre, Email, RazonSocial, TipoDocIdentidadId, Activo, LineaCredito, ModalidadCreditoId, DiasCredito, TipoMedioDePagoId, CreditoContado, CategoriaClienteId, LineaCreditoActiva, CodigoPais, Telefono, Observaciones) 
VALUES (2, 1, 'Av. El Polo 332','67389832','Ramos', 'Huatuco', 'Victor', 'Manuel', 'pilon@gmail.com', 'MAQUINARIAS SA', 1, 1, 0, 1, 0, 1, 1, 1, 0, 'es', '985578456', '');
INSERT INTO TB_VT_Clientes (ClienteId, TipoTerceroId, Direccion, DocIdentidad, ApellidoPaterno, ApellidoMaterno, PrimerNombre, SegundoNombre, Email, RazonSocial, TipoDocIdentidadId, Activo, LineaCredito, ModalidadCreditoId, DiasCredito, TipoMedioDePagoId, CreditoContado, CategoriaClienteId, LineaCreditoActiva, CodigoPais, Telefono, Observaciones) 
VALUES (3, 1, 'Av. Arequipa Crd. 7 - El gallinero','72638233','Calderon', 'De la Barca', 'Omar', 'Patuzo', 'paddi@gmail.com', 'Gamarra Shopping Center SAC', 1, 1, 0, 1, 0, 1, 1, 1, 0, 'es', '985578456', '');
INSERT INTO TB_VT_Clientes (ClienteId, TipoTerceroId, Direccion, DocIdentidad, ApellidoPaterno, ApellidoMaterno, PrimerNombre, SegundoNombre, Email, RazonSocial, TipoDocIdentidadId, Activo, LineaCredito, ModalidadCreditoId, DiasCredito, TipoMedioDePagoId, CreditoContado, CategoriaClienteId, LineaCreditoActiva, CodigoPais, Telefono, Observaciones) 
VALUES (4, 1, 'Psj. Acari 433 Alt. Cdr. 4 Av. Morales Duarez','97389832','Taboada', 'Casas','Paul', 'Carlos','pacharly@gmail.com', 'Linkedin S.R.L', 1, 1, 0, 1, 0, 1, 1, 1, 0, 'es', '985578456', '');
INSERT INTO TB_VT_Clientes (ClienteId, TipoTerceroId, Direccion, DocIdentidad, ApellidoPaterno, ApellidoMaterno, PrimerNombre, SegundoNombre, Email, RazonSocial, TipoDocIdentidadId, Activo, LineaCredito, ModalidadCreditoId, DiasCredito, TipoMedioDePagoId, CreditoContado, CategoriaClienteId, LineaCreditoActiva, CodigoPais, Telefono, Observaciones) 
VALUES (5, 1, 'Av. Universitaria Cdr. 45 Dpto. 566','52638233','Luna', 'Vigo', 'Ivan', 'Braulio', 'ivan@gmail.com', 'MAQUINARIAS SA', 1, 1, 0, 1, 0, 1, 1, 1, 0, 'es', '985578456', '');