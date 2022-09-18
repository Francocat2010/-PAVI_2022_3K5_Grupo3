CREATE DATABASE [ProyectoTPI]

USE [ProyectoTPI]
CREATE TABLE Barrios (
	cod_barrio [int] NOT NULL,
	nombre_barrio [varchar] (50) NULL,
	cod_ciudad [int],
	CONSTRAINT cod_barrio_pk PRIMARY KEY (cod_barrio)
)

SET IDENTITY_INSERT [Usuarios] ON 
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Clientes (
	id_cliente [int] IDENTITY(1,1) NOT NULL,
	nombre_razon_social [varchar] (100) NULL,
	calle [varchar] (50) NULL,
	nro [int] NOT NULL,
	piso [int] NOT NULL,
	cod_barrio [int] NULL,
	CONSTRAINT clientes_id_pk PRIMARY KEY (id_cliente),
	CONSTRAINT barrios_fk FOREIGN KEY (cod_barrio) REFERENCES Barrios (cod_barrio)
)

CREATE TABLE Llamadas(
	cod_nacional_emisor [int],
	cod_area_emisor [int],
	nro_telefono_emisor [int],
	fecha_hora_inicio [int],
	duracion [int],
	cod_nacional_receptor [int],
	cod_area_receptor [int],
	nro_telefono_receptor [int],
	cod_tipo_comunicacion [int],
	cod_banda_horaria [int],
	CONSTRAINT llamada_fk PRIMARY KEY(cod_nacional_emisor,cod_area_emisor,nro_telefono_emisor,fecha_hora_inicio)
)

SET IDENTITY_INSERT [Usuarios] ON 
GO
CREATE TABLE [Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
	CONSTRAINT [PK_Usuarios] PRIMARY KEY (id_usuario)
)

 CREATE TABLE Telefonos(
	cod_nacional [int],
	cod_area [int],
	num_telefono [int],
	num_cliente [int],
	CONSTRAINT telefono_pk PRIMARY KEY (cod_nacional,cod_area,num_telefono),
	CONSTRAINT telefono_fk FOREIGN KEY (num_cliente) REFERENCES Clientes (id_cliente)
)


CREATE TABLE Servicios(
	cod_servicios [int],
	descripcion [varchar](100),
	costo_mensual [money],
	CONSTRAINT servicio_pk PRIMARY KEY (cod_servicios),
)

CREATE TABLE Servicios_contratados(
	cod_nacional [int],
	cod_area [int],
	num_telefono [int],
	cod_servicio [int],
	fecha_desde [date],
	fecha_hasta [date],
	CONSTRAINT servicio_contratado_pk PRIMARY KEY (cod_nacional,cod_area,num_telefono,cod_servicio,fecha_desde),
	CONSTRAINT servicio_contratado_telefonofk FOREIGN KEY (cod_nacional,cod_area,num_telefono) REFERENCES Telefonos (cod_nacional,cod_area,num_telefono),
	CONSTRAINT sercios_contratado_fk FOREIGN KEY (cod_servicio) REFERENCES Servicios(cod_servicios)
)