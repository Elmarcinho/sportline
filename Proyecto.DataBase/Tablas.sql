create database dbGimnasioSportLine
go
use dbGimnasioSportLine
go

create table Sucursal(
	IdSucursal bigint primary key not null,
	NombreSucursal varchar(90),
	Direccion varchar(90),
	Telefono varchar (20)
)
go

create table Ciudad(
	IdCiudad bigint primary key not null,
	NombreCiudad varchar (60)
)
go

create table Zona(
	IdZona bigint primary key not null,
	NombreZona varchar (90),
	IdCiudad bigint foreign key references Ciudad(IdCiudad)
)
go

create table Persona(
	IdPersona bigint primary key  not null,
	NombrePersona varchar(90) not null,
	ApellidoPaterno varchar(90) not null,
	ApellidoMaterno varchar(90),
	DocumentoIdentidad bigint unique not null,
	FechaNacimiento date,
	Sexo Char not null,
	Telefono varchar(20),
	CorreoElectronico varchar(60),
	Direccion varchar(90),
	Foto image,
	IdZona bigint foreign key references Zona(IdZona),
	IdSucursal bigint foreign key references Sucursal(IdSucursal)
)
go

Create table Cliente(
	IdPersona bigint primary key references Persona(IdPersona)not null,
	Nit bigint,
	Peso float,
	Estatura float
)
go

create table Empleado(
	IdPersona bigint primary key references Persona(IdPersona) not null,
	FechaIngreso date,
	EstadoEmpleado int check (EstadoEmpleado=0 or EstadoEmpleado=1)not null
)
go

create table Rol(
	IdRol bigint primary key  not null,
	NombreRol varchar (60)not null,
	Descripcion varchar (110),
	EstadoRol int check (EstadoRol=0 or EstadoRol=1)not null
)
go

create table Usuario(
	IdUsuario bigint primary key  not null,
	NombreUsuario varchar(90) unique not null,
	Contraseña varchar(130) not null,
	IdPersona bigint unique not null,
	EstadoUsuario int check (EstadoUsuario=0 or EstadoUsuario=1),
	foreign key(IdPersona) references Persona(IdPersona),
	IdRol bigint references Rol(IdRol)
)
go

create table Permiso(
	IdPermiso bigint primary key  not null,
	NombrePermiso varchar (60) not null,
	EstadoPermiso int check (EstadoPermiso=0 or EstadoPermiso=1)not null
)
go

create table RolPermiso(
	IdRol bigint references Rol(IdRol)not null,
	IdPermiso bigint references Permiso(IdPermiso)not null,
	constraint FKRolPermiso primary key (IdRol,IdPermiso),
	EstadoRolPermiso int check(EstadoRolPermiso=0 or EstadoRolPermiso=1)not null
)
go

create table Plazo(
	IdPlazo bigint primary key not null,
	NombrePlazo varchar(90)not null,
	Numerodias int not null
)
go

create table Categoria(
	IdCategoria bigint primary key not null,
	NombreCategoria varchar (90) not null,
	EstadoCategoria int check (EstadoCategoria=0 or EstadoCategoria=1)not null
)
go

create table Producto(
	IdProducto bigint primary key not null,
	NombreProducto varchar (90)not null,
	DescripcionProducto varchar(90),
	Stock int not null,
	IdCategoria bigint foreign key references Categoria(IdCategoria),
	EstadoProducto int check (EstadoProducto=0 or EstadoProducto=1)not null
)
go

create table Servicio(
	IdServicio bigint primary key not null,
	NombreServicio varchar (90)not null,
	Descripcion varchar(90),
	HoraInicio time,
	HoraFin time,
	RangoDia varchar(20),
	EstadoServicio int check (EstadoServicio=0 or EstadoServicio=1)not null
)
go

create table Precio(
	IdPrecio bigint primary key not null,
	PrecioCompra float,
	PrecioVenta float,
	PrecioDiario float,
	PrecioQuincenal float,
	PrecioMensual float,
	FechaInicial date not null,
	FechaFinal date,
	IdProducto bigint foreign key references Producto(IdProducto),
	IdServicio bigint foreign key references Servicio(IdServicio),
	EstadoPrecio int check (EstadoPrecio=0 or EstadoPrecio=1)
)
go

create table Descuento(
	IdDescuento bigint primary key not null,
	NombreDescuento varchar(90)not null,
	Monto float not null,
	EstadoDescuento int check (EstadoDescuento=0 or EstadoDescuento=1)
)
go

create table TipoSolicitud(
	IdTipoSolicitud bigint primary key  not null,
	NombreTipoSolicitud varchar(90)
)
go

create table Solicitud(
	IdSolicitud bigint primary key not null,
	FechaSolicitud date not null,
	FechaIngreso date,
	FechaCulminacion date,
	EstadoSolicitud int check (EstadoSolicitud=1 or EstadoSolicitud=2 or EstadoSolicitud=3)not null,
	TipoPago int check (TipoPago=1 or TipoPago=2),
	IdCliente bigint foreign key references Persona(IdPersona),
	IdEmpleado bigint foreign key references Persona(IdPersona),
	IdTipoSolicitud bigint foreign key references TipoSolicitud(IdTipoSolicitud),
	IdPlazo bigint foreign key references Plazo(IdPlazo),
	IdDescuento bigint foreign key references Descuento(IdDescuento),
	IdUsuario bigint foreign key references Usuario(IdUsuario)
)
go

create table DetalleSolicitud(
	IdSolicitud bigint references Solicitud(IdSolicitud),
	IdPrecio bigint references Precio(IdPrecio),
	constraint FKSolicitudPrecio primary key (IdSolicitud,IdPrecio),
	Cantidad int not null,
)
go

create table Pago(
	IdPago bigint primary key identity not null,
	FechaPago date,
	Descuento float,
	Cantidad int,
	Monto float,
	EstadoPago int check (EstadoPago=0 or EstadoPago=1)not null,
	IdSolicitud bigint,
	IdPrecio bigint,
	constraint FKDetalleSolicitud foreign key (IdSolicitud,IdPrecio) references DetalleSolicitud(IdSolicitud,IdPrecio)
)
go

create table Factura(
	IdFactura bigint primary key not null,
	NombreCliente varchar (200),
	Nit bigint,
	FechaFactura datetime not null,
	CodigoAutorizacion bigint not null,
	CodigoControl varchar(14)not null,
	FechaLimiteEmision date not null,
	CodigoQR image not null,
	Monto float not null,
	IdSolicitud bigint foreign key references Solicitud(IdSolicitud),
	IdPago bigint foreign key references Pago(IdPago)
)
go

create table Asistencia(
	IdAsistencia bigint primary key not null,
	FechaAsistencia datetime,
	FechaRenovacion datetime,
	Valor int,
	IdSolicitud bigint foreign key references Solicitud(IdSolicitud)
)
go

create table Turno(
	IdTurno bigint primary key not null,
	NombreTurno varchar (50)not null
)
go

Create table Horario(
	IdHorario bigint primary key not null,
	HoraInicio time,
	HoraFin time,
	RangoDia varchar(20),
	IdServicio bigint foreign key references Servicio(IdServicio),
	IdEmpleado bigint foreign key references Empleado(IdPersona),
	IdCliente bigint foreign key references Persona(IdPersona),
	IdSolicitud bigint foreign key references Solicitud(IdSolicitud),
	IdTurno bigint foreign key references Turno(IdTurno)
)
go

create table Credito(
	IdCredito bigint primary key identity not null,
	FechaCredito date not null,
	FechaPlazo date not null,
	Monto float not null,
	IdSolicitud bigint foreign key references Solicitud(IdSolicitud)
)
go

create table Cuota(
	IdCuota bigint primary key identity not null,
	MontoCuota float not null,
	FechaPago date not null,
	IdCredito bigint foreign key references Credito(IdCredito)
)
go

create table BitacoraLogin(
	IdBitLogin bigint primary key not null,
	NombreEmpleado varchar(90),
	NombreUsuario varchar (60),
	FechaIngreso date,
	HoraIngreso time,
	HoraSalida time
)
go
create table BitacoraSolicitudVenta(
	IdBitSol bigint primary key identity not null,
	NombreOperacion	varchar(90),
	FechaOperacion datetime,
	IdSolicitud bigint,
	NombreUsuario varchar(60)
)
go

create table SolicitudCompra(
	IdSolicitudCompra bigint primary key not null,
	FechaCompra date,
	IdUsuario bigint foreign key references Usuario(IdUsuario)
)
go

create table DetalleSolicitudCompra(
	IdSolicitudCompra bigint references SolicitudCompra(IdSolicitudCompra),
	IdPrecio bigint references Precio(IdPrecio),
	constraint FKSolicitudCompraPrecio primary key (IdSolicitudCompra,IdPrecio),
	Cantidad int not null
)
go
create table Año(
IdAño bigint primary key identity not null,
NombreAño varchar(20),
)
create table Mes(
IdMes bigint primary key identity not null,
NombreMes varchar(20),
)

-----INSERTAR DATOS-------
insert into Ciudad values (1,'Santa Cruz')
insert into Zona values(1,'Centro',1)
insert into Zona values(2,'Este',1)
insert into Zona values(3,'Norte',1)
insert into Zona values(4,'NorEste',1)
insert into Zona values(5,'NorOeste',1)
insert into Zona values(6,'Oeste',1)
insert into Zona values(7,'Sur',1)
insert into Zona values(8,'SurEste',1)
insert into Zona values(9,'SurOeste',1)
insert into Sucursal values(1,'Sucursal Principal','Av. Virgen de Cotoca','3-463232')
insert into Persona values(1,'Elmar','Rodas','Banegas',8965698,'25/08/1989','M','72176275','Elmar@gmail.com','BARRIO 3 DE MAYO',null,1,1)
insert into Persona values(2,'Cliente','Particular','',0,null,'M','','','',null,1,1)
insert into Empleado values (1,'01/01/2019',1)
insert into Cliente values(2,null,null,null)
insert into Rol values (1,'ADMINISTRADOR','TIENE ACCESO A TODO',1)
insert into Permiso values(1,'Registrar Cliente',1)
insert into Permiso values(2,'Modificar Cliente',1)
insert into Permiso values(3,'Registrar Empleado',1)
insert into Permiso values(4,'Modificar Empleado',1)
insert into Permiso values(5,'Registrar  Venta',1)
insert into Permiso values(6,'Anular Venta',1)
insert into Permiso values(7,'Registrar Producto',1)
insert into Permiso values(8,'Modificar Producto',1)
insert into Permiso values(9,'Dar Alta/Baja Producto',1)
insert into Permiso values(10,'Registrar Categoria',1)
insert into Permiso values(11,'Modificar Categoria',1)
insert into Permiso values(12,'Dar Alta/Baja Categoria',1)
insert into Permiso values(13,'Registrar  Compra',1)
insert into Permiso values(14,'Modificar Compra',1)
insert into Permiso values(15,'Anular Compra',1)
insert into Permiso values(16,'Registrar Servicio',1)
insert into Permiso values(17,'Modificar Servicio',1)
insert into Permiso values(18,'Registrar Usuario',1)
insert into Permiso values(19,'Moficar Usuario',1)
insert into Permiso values(20,'Registrar Rol',1)
insert into Permiso values(21,'Modificar Rol',1)
insert into Permiso values(22,'Dar Alta/Baja Rol',1)
insert into Permiso values(23,'Registrar  Pago',1)
insert into Permiso values(24,'Registrar  Asistencia',1)
insert into Permiso values(25,'Ver Reportes',1)
insert into Permiso values(26,'Ver Informes Estadísticos',1)
insert into Permiso values (27,'Configuracion',1)
insert into usuario values(1,'ADMIN','1f65de70c267e45c5038888cf2c093a6d1386f0c86d0cdd6d18591b3bc542c8636f139c9fb3f71f3f34f550260303192f01d95f18268437a09c2b2eb9f319558',1,1,1)
insert into RolPermiso values(1,1,1)
insert into RolPermiso values(1,2,1)
insert into RolPermiso values(1,3,1)
insert into RolPermiso values(1,4,1)
insert into RolPermiso values(1,5,1)
insert into RolPermiso values(1,6,1)
insert into RolPermiso values(1,7,1)
insert into RolPermiso values(1,8,1)
insert into RolPermiso values(1,9,1)
insert into RolPermiso values(1,10,1)
insert into RolPermiso values(1,11,1)
insert into RolPermiso values(1,12,1)
insert into RolPermiso values(1,13,1)
insert into RolPermiso values(1,14,1)
insert into RolPermiso values(1,15,1)
insert into RolPermiso values(1,16,1)
insert into RolPermiso values(1,17,1)
insert into RolPermiso values(1,18,1)
insert into RolPermiso values(1,19,1)
insert into RolPermiso values(1,20,1)
insert into RolPermiso values(1,21,1)
insert into RolPermiso values(1,22,1)
insert into RolPermiso values(1,23,1)
insert into RolPermiso values(1,24,1)
insert into RolPermiso values(1,25,1)
insert into RolPermiso values(1,26,1)
insert into RolPermiso values(1,27,1)
insert into TipoSolicitud values(1,'Solicitud de Producto')
insert into TipoSolicitud values(2,'Solicitud de Servicio')
insert into Categoria values(0,'--- Seleccionar ---',1)
insert into Descuento values(0,'--- Seleccionar ---',0,1)
insert into Descuento values(1,'Por Cumpleaños',50,1)
insert into Descuento values(2,'Por Pago Adelantado',50,1)
insert into Descuento values(3,'Por Inscribirse en grupo',20,1)
insert into Plazo values(0,'--- Seleccionar ---',0)
insert into Plazo values(1,'Diario',1)
insert into Plazo values(2,'Quincenal',13)
insert into Plazo values(3,'Mensual',26)
insert into Turno values(1,'Mañana')
insert into Turno values(2,'Tarde')
insert into Turno values(3,'Noche')
insert into Año values(2019)
insert into Año values(2020)
insert into Año values(2021)
insert into Año values(2022)
insert into Mes values('Enero')
insert into Mes values('Febrero')
insert into Mes values('Marzo')
insert into Mes values('Abril')
insert into Mes values('Mayo')
insert into Mes values('Junio')
insert into Mes values('Julio')
insert into Mes values('Agosto')
insert into Mes values('Septiembre')
insert into Mes values('Octubre')
insert into Mes values('Noviembre')
insert into Mes values('Diciembre')
-----CONSULTAS---------
 select * from Persona p inner join Empleado e on p.IdPersona=e.IdPersona
 select * from Turno
 select * from Plazo
 select * from Servicio
 select * from Usuario
 select * from Producto
 select * from Solicitud
 select * from Precio
 select * from Descuento
 select * from VProductoActivo
 insert into RolPermiso values(2,20,1)
select * from TipoSolicitud
update Descuento set Monto=70 where IdDescuento=3
delete from Persona where IdPersona=0
delete from RolPermiso where IdRol=2 and IdPermiso=36
drop table Horario
drop table BitacoraCliente -- elimina tabla
 go

--------------------------Vistas--------------------------------------------------------
create View VClientes
as
select p.IdPersona as Código,(p.NombrePersona+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno)as NombreCliente,
	p.NombrePersona,p.ApellidoPaterno,p.ApellidoMaterno,p.DocumentoIdentidad as CédulaIdentidad,p.Telefono as Teléfono,p.Sexo,
	p.FechaNacimiento,p.CorreoElectronico,p.Foto,cli.Peso,cli.Estatura,p.direccion,z.NombreZona as Zona,
	c.NombreCiudad as Ciudad,s.NombreSucursal as Sucursal
	from Persona p 
	inner join Cliente cli on p.IdPersona=cli.IdPersona
	inner join Sucursal s on p.IdSucursal=s.IdSucursal
	inner join Zona z on p.IdZona=z.IdZona
	inner join Ciudad c on z.IdCiudad=c.IdCiudad 
go

create View VEmpleados
as
select p.IdPersona as Código,(p.NombrePersona+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno)as NombreEmpleado,
	p.NombrePersona,p.ApellidoPaterno,p.ApellidoMaterno,p.DocumentoIdentidad as CédulaIdentidad,p.Telefono as Teléfono,p.Sexo,
	p.FechaNacimiento,e.FechaIngreso,p.Foto ,p.direccion as Dirección,z.NombreZona as Zona,
	c.NombreCiudad,s.NombreSucursal 
	from Persona p 
	inner join Empleado e on p.IdPersona=e.IdPersona
	inner join Sucursal s on p.IdSucursal=s.IdSucursal
	inner join Zona z on p.IdZona=z.IdZona
	inner join Ciudad c on z.IdCiudad=c.IdCiudad 
go

create View VClienteGeneral
as
select p.IdPersona as Código,(p.NombrePersona+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno)as NombreCliente,
	p.NombrePersona,p.ApellidoPaterno,p.ApellidoMaterno,p.DocumentoIdentidad as CédulaIdentidad,p.Telefono as Teléfono,p.Sexo,
	p.FechaNacimiento,p.Foto,p.direccion,z.NombreZona as Zona,
	c.NombreCiudad as Ciudad,s.NombreSucursal as Sucursal
	from Persona p 
	inner join Sucursal s on p.IdSucursal=s.IdSucursal
	inner join Zona z on p.IdZona=z.IdZona
	inner join Ciudad c on z.IdCiudad=c.IdCiudad
go

create View VEmpleadosActivoSinUser
as
select p.IdPersona as Código,(p.NombrePersona+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno)as NombreEmpleado,p.DocumentoIdentidad as CedulaIdentidad,
	p.Telefono as Teléfono,p.Sexo,p.FechaNacimiento,e.FechaIngreso,p.Foto ,p.direccion as Dirección,z.NombreZona as Zona,c.NombreCiudad,s.NombreSucursal
	from Persona p 
	left join  Usuario u on p.IdPersona=u.IdPersona
	inner join Empleado e on p.IdPersona=e.IdPersona
	inner join Sucursal s on p.IdSucursal=s.IdSucursal
	inner join Zona z on p.IdZona=z.IdZona
	inner join Ciudad c on z.IdCiudad=c.IdCiudad 
	where e.EstadoEmpleado=1 and u.IdUsuario is null
go

create View VUsuario
as
select p.IdPersona as Código,(p.NombrePersona+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno)as NombreEmpleado,
	u.IdUsuario,u.NombreUsuario as Usuario,u.Contraseña,r.NombreRol,'Activo' as Estado,s.NombreSucursal,c.NombreCiudad  
	from Persona p 
	inner join Empleado e on p.IdPersona=e.IdPersona
	inner join Sucursal s on p.IdSucursal=s.IdSucursal
	inner join Zona z on p.IdZona=z.IdZona
	inner join Ciudad c on z.IdCiudad=c.IdCiudad 
	inner join Usuario u on p.IdPersona=u.IdPersona
	inner join Rol r on u.IdRol=r.IdRol
	where u.EstadoUsuario=1
union
select p.IdPersona as Código,(p.NombrePersona+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno)as NombreEmpleado,
	u.IdUsuario,u.NombreUsuario as Usuario,u.Contraseña,r.NombreRol,'Inactivo' as Estado,s.NombreSucursal,c.NombreCiudad  
	from Persona p 
	inner join Empleado e on p.IdPersona=e.IdPersona
	inner join Sucursal s on p.IdSucursal=s.IdSucursal
	inner join Zona z on p.IdZona=z.IdZona
	inner join Ciudad c on z.IdCiudad=c.IdCiudad 
	inner join Usuario u on p.IdPersona=u.IdPersona
	inner join Rol r on u.IdRol=r.IdRol
	where u.EstadoUsuario=0
go

create View VUsuarioActivo
as
select p.IdPersona as Código,(p.NombrePersona+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno)as NombreEmpleado,
	u.IdUsuario,u.NombreUsuario as Usuario,u.Contraseña,r.NombreRol,s.NombreSucursal,c.NombreCiudad  
	from Persona p 
	inner join Empleado e on p.IdPersona=e.IdPersona
	inner join Sucursal s on p.IdSucursal=s.IdSucursal
	inner join Zona z on p.IdZona=z.IdZona
	inner join Ciudad c on z.IdCiudad=c.IdCiudad 
	inner join Usuario u on p.IdPersona=u.IdPersona
	inner join Rol r on u.IdRol=r.IdRol
	where u.EstadoUsuario=1
go

create view VRol
as
select Rol.IdRol,Rol.NombreRol,ROL.Descripcion,'Activo' as Estado from Rol where EstadoRol=1
go

create view VProducto
as
select pro.IdProducto,pro.NombreProducto,pro.DescripcionProducto,pre.IdPrecio,pre.PrecioCompra,pre.PrecioVenta,pro.Stock,cat.IdCategoria,
	cat.NombreCategoria,(case when pro.EstadoProducto=1 then 'Activo' else 'Inactivo' end)as Estado
	from Producto pro
	inner join Precio pre on pro.IdProducto=pre.IdProducto
	inner join Categoria cat on pro.IdCategoria=cat.IdCategoria
	where pre.EstadoPrecio=1
go

create view VServicioActivo
as
select ser.IdServicio,ser.NombreServicio,ser.Descripcion as Descripción,pre.IdPrecio,pre.PrecioDiario,pre.PrecioQuincenal,pre.PrecioMensual,ser.EstadoServicio,
	ser.HoraInicio,ser.HoraFin,ser.RangoDia
	from Servicio ser
	inner join Precio pre on ser.IdServicio=pre.IdServicio
	where ser.EstadoServicio=1 and pre.EstadoPrecio=1
go

create view VUsuarioRolPermisos
as
select su.NombreSucursal,p.IdPersona,(p.NombrePersona+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno) as NombreEmpleado,p.Foto,u.IdUsuario, u.NombreUsuario, u.Contraseña, 
	r.IdRol, r.NombreRol, rp.IdPermiso, pe.NombrePermiso,rp.EstadoRolPermiso from Persona p 
	inner join Usuario u on p.IdPersona=u.IdPersona
	inner join Rol r on u.IdRol=r.IdRol
	inner join RolPermiso rp on r.IdRol=rp.IdRol
	inner join Permiso pe on rp.IdPermiso=pe.IdPermiso
	inner join Sucursal su on p.IdSucursal=su.IdSucursal
go
  
create view VCategoria
as
select cat.IdCategoria,cat.NombreCategoria,(case when cat.EstadoCategoria=1 then 'Activo' else 'Inactivo' end)as Estado from Categoria cat 
go

create view VDescuento
as
select d.IdDescuento,d.NombreDescuento,d.Monto,(case when d.EstadoDescuento=1 then 'Activo' else 'Inactivo' end)as Estado from Descuento d 
go

create view VPermiso
as
select Permiso.IdPermiso,Permiso.NombrePermiso,'Activo' as Estado from Permiso where EstadoPermiso=1
go

Create view VRolPermiso
as
select rp.IdRol,r.NombreRol,rp.IdPermiso,pe.NombrePermiso,rp.EstadoRolPermiso as Estado from Rol r
	inner join RolPermiso rp on r.IdRol=rp.IdRol
	inner join Permiso pe on rp.IdPermiso=pe.IdPermiso
go

create view VSolicitudServicio
as
select so.IdSolicitud,so.IdCliente,so.FechaSolicitud,(case when so.EstadoSolicitud=3 then 'Entregado' else (case when so.EstadoSolicitud=2 then 'Anulado' else 'Pendiente' end) end )as Estado,
	(case when so.IdPlazo=1 then sum(pre.PrecioDiario*ds.Cantidad) else (case when so.IdPlazo=2 then sum(pre.PrecioQuincenal*ds.Cantidad) else sum(pre.PrecioMensual*ds.Cantidad) end) end )as MontoTotal,
	(case when so.TipoPago=1 then 'Contado' else 'Crédito' end)as TipoPago,'Servicio' as TipoSolicitud,u.NombreUsuario as Usuario,
	so.IdDescuento   
	from Solicitud so
	inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
	inner join Precio pre on ds.IdPrecio=pre.IdPrecio
	inner join Usuario u on so.IdUsuario=u.IdUsuario
	where so.IdTipoSolicitud=2
	group by so.IdSolicitud,so.IdCliente,so.FechaSolicitud,so.EstadoSolicitud,so.TipoPago,u.NombreUsuario,so.IdPlazo,so.IdDescuento  
go

create view VSolicitudProducto
as
select so.IdSolicitud,so.IdCliente,so.FechaSolicitud,(case when so.EstadoSolicitud=3 then 'Entregado' else (case when so.EstadoSolicitud=2 then 'Anulado' else 'Pendiente' end) end )as Estado,
	sum(ds.Cantidad*pre.PrecioVenta) as MontoTotal,(case when so.TipoPago=1 then 'Contado' else 'Crédito' end)as TipoPago,'Producto' as TipoSolicitud,u.NombreUsuario as Usuario,so.IdDescuento 
	from Solicitud so
	inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
	inner join Precio pre on ds.IdPrecio=pre.IdPrecio
	inner join Usuario u on so.IdUsuario=u.IdUsuario
	where so.IdTipoSolicitud=1
	group by so.IdSolicitud,so.IdCliente,so.FechaSolicitud,so.EstadoSolicitud,so.TipoPago,u.NombreUsuario,so.IdDescuento    
go

create view VSolicitudGeneral
as
select * from VSolicitudProducto 
union 
select * from VSolicitudServicio
go

create view VClienteSolicitudGeneral
as
select vs.IdSolicitud as CodVenta,vc.Código as CodCliente, vc.NombreCliente,vc.CédulaIdentidad,vs.FechaSolicitud,
	vs.Estado,vs.TipoSolicitud,vs.TipoPago,vs.Usuario,vs.MontoTotal as SubTotal,d.Monto as MontoDescuento,(case when vs.IdDescuento = 0 then vs.MontoTotal else sum(vs.MontoTotal-d.Monto) end)as MontoTotal
from VClienteGeneral vc 
inner join VSolicitudGeneral vs on vc.Código=vs.IdCliente
inner join Descuento d on vs.IdDescuento=d.IdDescuento
group by vs.IdSolicitud,vc.Código, vc.NombreCliente,vc.CédulaIdentidad,vs.FechaSolicitud,vs.Estado,vs.TipoSolicitud,vs.TipoPago,vs.Usuario,vs.MontoTotal,vs.IdDescuento,d.Monto
go

create view VSolicitudProductoGeneral
as
select so.IdSolicitud,so.IdCliente,so.FechaSolicitud,(case when so.EstadoSolicitud=3 then 'Entregado' else (case when so.EstadoSolicitud=2 then 'Anulado' else 'Pendiente' end) end )as Estado,
	sum(ds.Cantidad*pre.PrecioVenta) as SubTotal,(case when so.TipoPago=1 then 'Contado' else 'Crédito' end)as TipoPago,'Producto' as TipoSolicitud,u.NombreUsuario as Usuario,de.Monto as Descuento 
	from Solicitud so
	inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
	inner join Precio pre on ds.IdPrecio=pre.IdPrecio
	inner join Usuario u on so.IdUsuario=u.IdUsuario
	inner join Descuento de on so.IdDescuento=de.IdDescuento
	where so.IdTipoSolicitud=1 and so.EstadoSolicitud=3
	group by so.IdSolicitud,so.IdCliente,so.FechaSolicitud,so.EstadoSolicitud,so.TipoPago,u.NombreUsuario,de.Monto    
go

create view VSolicitudServicioPago
as
select so.IdSolicitud,so.IdCliente,pa.FechaPago as FechaSolicitud,'Entregado'as Estado,
	sum(Pa.Monto)as SubTotal,'Contado'as TipoPago,'Servicio' as TipoSolicitud,u.NombreUsuario as Usuario,
	sum(pa.Descuento) as Descuento  
	from Solicitud so
	inner join Pago Pa on so.IdSolicitud=pa.IdSolicitud
	inner join Usuario u on so.IdUsuario=u.IdUsuario
	where so.IdTipoSolicitud=2 and so.EstadoSolicitud =3
	group by so.IdSolicitud,so.IdCliente,pa.FechaPago,u.NombreUsuario  
go

create view VSolicitudServicioCredito
as
select so.IdSolicitud,so.IdCliente,cre.FechaCredito as FechaSolicitud,'Entregado'as Estado,
	sum(cre.Monto)as SubTotal,'Crédito'as TipoPago,'Servicio' as TipoSolicitud,u.NombreUsuario as Usuario,
	'0'as Descuento   
	from Solicitud so
	inner join Credito cre on so.IdSolicitud=cre.IdSolicitud
	inner join Usuario u on so.IdUsuario=u.IdUsuario
	where so.IdTipoSolicitud=2 and so.EstadoSolicitud=3
	group by so.IdSolicitud,so.IdCliente,cre.FechaCredito,so.EstadoSolicitud,so.TipoPago,u.NombreUsuario   
go

create view VSolicitudGeneralConsolidado
as
select * from VSolicitudProductoGeneral vsp
union 
select * from VSolicitudServicioPago
union
select * from VSolicitudServicioCredito
go

create view VClienteSolicitudGeneralConsolidado
as
select vs.IdSolicitud as CodVenta,vc.Código as CodCliente, vc.NombreCliente,vc.CédulaIdentidad,vs.FechaSolicitud,MONTH(vs.FechaSolicitud)as IdMes,
	DATENAME(MONTH,(vs.FechaSolicitud))as MesSolicitud,YEAR(vs.FechaSolicitud)as AñoSolicitud,
	vs.Estado,vs.TipoSolicitud,vs.TipoPago,vs.Usuario,vs.SubTotal,vs.Descuento as MontoDescuento, sum(vs.SubTotal)as MontoTotal
	from VClienteGeneral vc 
	inner join VSolicitudGeneralConsolidado vs on vc.Código=vs.IdCliente
group by vs.IdSolicitud,vc.Código, vc.NombreCliente,vc.CédulaIdentidad,vs.FechaSolicitud,vs.Estado,vs.TipoSolicitud,vs.TipoPago,vs.Usuario,vs.SubTotal,vs.Descuento
go

create view VDetalleSolicitudProducto
as
select so.IdSolicitud,pro.IdProducto,pro.NombreProducto,pro.DescripcionProducto,pre.IdPrecio,pre.PrecioVenta,ds.Cantidad,pro.Stock, sum(ds.Cantidad*pre.PrecioVenta) as Total 
	from Solicitud so
	inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
	inner join Precio pre on ds.IdPrecio=pre.IdPrecio
	inner join Producto pro on pre.IdProducto=pro.IdProducto
	group by so.IdSolicitud,pro.IdProducto,pro.NombreProducto,pro.DescripcionProducto,pre.IdPrecio,pre.PrecioVenta,ds.Cantidad,pro.Stock
go

create view VDetalleSolicitudServicio
as
select so.IdSolicitud,ser.IdServicio,ser.NombreServicio,ser.Descripcion,so.IdPlazo,pre.IdPrecio,pre.PrecioDiario,pre.PrecioQuincenal,pre.PrecioMensual,ds.Cantidad, 
(case when so.IdPlazo=1 then sum(pre.PrecioDiario*ds.Cantidad) else (case when so.IdPlazo=2 then sum(pre.PrecioQuincenal*ds.Cantidad) else sum(pre.PrecioMensual*ds.Cantidad) end) end )as SubTotal
	from Solicitud so
	inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
	inner join Precio pre on ds.IdPrecio=pre.IdPrecio
	inner join Servicio ser on pre.IdServicio=ser.IdServicio
	group by so.IdSolicitud,ser.IdServicio,ser.NombreServicio,ser.Descripcion,so.IdPlazo,pre.IdPrecio,pre.PrecioDiario,pre.PrecioQuincenal,pre.PrecioMensual,ds.Cantidad
go

create view VDetalleSolicitudServicioPago
as
select so.IdSolicitud,pa.IdPago,ser.IdServicio,ser.NombreServicio,ser.Descripcion,so.IdPlazo,pre.IdPrecio,pre.PrecioDiario,pre.PrecioQuincenal,pre.PrecioMensual,pa.Cantidad, 
(case when so.IdPlazo=1 then sum(pre.PrecioDiario*pa.Cantidad) else (case when so.IdPlazo=2 then sum(pre.PrecioQuincenal*pa.Cantidad) else sum(pre.PrecioMensual*pa.Cantidad) end) end )as SubTotal,
	pa.Descuento as MontoDescuento
	from Solicitud so
	inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
	inner join Precio pre on ds.IdPrecio=pre.IdPrecio
	inner join Servicio ser on pre.IdServicio=ser.IdServicio
	inner join Pago pa on ds.IdSolicitud=pa.IdSolicitud and ds.IdPrecio=pa.IdPrecio
	where pa.EstadoPago=1
	group by so.IdSolicitud,pa.IdPago,ser.IdServicio,ser.NombreServicio,ser.Descripcion,so.IdPlazo,pre.IdPrecio,pre.PrecioDiario,pre.PrecioQuincenal,pre.PrecioMensual,pa.Cantidad,pa.Descuento
go

create view VFacturaGeneral
as
select vc.CodVenta as IdSolicitud,f.IdFactura,f.CodigoAutorizacion,f.FechaFactura,vc.NombreCliente,vc.CédulaIdentidad as Carnet,
f.CodigoControl,convert(date,f.FechaLimiteEmision)as FechaLimiteEmision,cast(f.CodigoQR as varbinary(max))as QR,vc.TipoPago,vds.NombreServicio,
(case when vds.IdPlazo=1 then vds.PrecioDiario else (case when vds.IdPlazo=2 then PrecioQuincenal else (case when vds.IdPlazo=3 then PrecioMensual end) end)end)as PrecioVenta,
vds.Cantidad,vds.SubTotal,vc.MontoDescuento,vc.Usuario
from VClienteSolicitudGeneral vc
inner join VDetalleSolicitudServicio vds on vc.CodVenta=vds.IdSolicitud
inner join Factura f on vc.CodVenta=f.IdSolicitud and f.IdPago is null
union
select vc.CodVenta as IdSolicitud,f.IdFactura,f.CodigoAutorizacion,f.FechaFactura,vc.NombreCliente,vc.CédulaIdentidad as Carnet,
f.CodigoControl,convert(date,f.FechaLimiteEmision)as FechaLimiteEmision,cast(f.CodigoQR as varbinary(max))as QR,vc.TipoPago,vds.NombreProducto,
vds.PrecioVenta,vds.Cantidad,vds.Total as SubTotal,vc.MontoDescuento,vc.Usuario
from VClienteSolicitudGeneral vc
inner join VDetalleSolicitudProducto vds on vc.CodVenta=vds.IdSolicitud
inner join Factura f on vc.CodVenta=f.IdSolicitud
union
select vc.CodVenta as IdSolicitud,f.IdFactura,f.CodigoAutorizacion,f.FechaFactura,vc.NombreCliente,vc.CédulaIdentidad as Carnet,
f.CodigoControl,convert(date,f.FechaLimiteEmision)as FechaLimiteEmision,cast(f.CodigoQR as varbinary(max))as QR,'Contado',vds.NombreServicio,
(case when vds.IdPlazo=1 then vds.PrecioDiario else (case when vds.IdPlazo=2 then PrecioQuincenal else (case when vds.IdPlazo=3 then PrecioMensual end) end)end)as PrecioVenta,
vds.Cantidad,vds.SubTotal,vds.MontoDescuento,vc.Usuario
from VClienteSolicitudGeneral vc
inner join VDetalleSolicitudServicioPago vds on vc.CodVenta=vds.IdSolicitud
inner join Factura f on vds.IdSolicitud=f.IdSolicitud and f.IdPago=vds.IdPago
go

create view VCuotaTotal
as
select IdCredito, sum(MontoCuota) as MontoCuota  from Cuota
group by IdCredito 
go

create view VClienteCreditoGeneral
as
select vs.IdSolicitud as CodVenta,cre.IdCredito as CodCrédito,vc.Código as CodCliente, vc.NombreCliente,vc.CédulaIdentidad,cre.FechaCredito,
cre.FechaPlazo,cre.Monto as MontoCrédito,vcu.MontoCuota,(cre.Monto-vcu.MontoCuota)as Saldo
from VClienteGeneral vc 
inner join VSolicitudGeneral vs on vc.Código=vs.IdCliente
inner join Credito cre on vs.IdSolicitud=cre.IdSolicitud
inner join VCuotaTotal vcu on cre.IdCredito=vcu.IdCredito
where (cre.Monto-vcu.MontoCuota)!=0 and vs.Estado='Entregado'
union
select vs.IdSolicitud as CodVenta,cre.IdCredito as CodCrédito, vc.Código as CodCliente,vc.NombreCliente,vc.CédulaIdentidad,cre.FechaCredito,
cre.FechaPlazo,cre.Monto as MontoCrédito,vcu.MontoCuota,cre.Monto as Saldo
from VClienteGeneral vc 
inner join VSolicitudGeneral vs on vc.Código=vs.IdCliente
inner join Credito cre on vs.IdSolicitud=cre.IdSolicitud
left join Cuota vcu on cre.IdCredito=vcu.IdCredito
where vcu.IdCuota is null and vs.Estado='Entregado'
go

create view VClienteDetalleCredito
as
select vc.CodVenta,vc.CodCrédito,vc.CodCliente,vc.NombreCliente,vc.CédulaIdentidad,vc.FechaCredito,vdp.NombreProducto,vdp.PrecioVenta,vdp.Cantidad,vdp.Total 
from VClienteCreditoGeneral vc 
inner join VDetalleSolicitudProducto vdp on vc.CodVenta=vdp.IdSolicitud 
union
select vc.CodVenta,vc.CodCrédito,vc.CodCliente,vc.NombreCliente,vc.CédulaIdentidad,vc.FechaCredito,vds.NombreServicio,
(case when vds.IdPlazo=1 then vds.PrecioDiario else (case when vds.IdPlazo=2 then PrecioQuincenal else (case when vds.IdPlazo=3 then PrecioMensual end) end)end)as PrecioVenta,
vds.Cantidad,vds.SubTotal as Total
from VClienteCreditoGeneral vc 
inner join VDetalleSolicitudServicio vds on vc.CodVenta=vds.IdSolicitud 
go

create view VClienteSolicitudServicioPlanes
as
select so.IdSolicitud,vc.Código,vc.NombreCliente,vc.CédulaIdentidad,so.FechaSolicitud,
	(case when so.IdPlazo=3 then 'Mensual' else (case when so.IdPlazo=2 then 'Quincenal' else 'Diario' end) end )as Planes
	from VClienteGeneral vc
	inner join Solicitud so on vc.Código=so.IdCliente
	where so.IdTipoSolicitud=2 and so.EstadoSolicitud=3
go

create view VClienteServicio
as
select so.IdSolicitud,so.IdPlazo,vc.CédulaIdentidad,ser.IdServicio,ser.NombreServicio,pre.IdPrecio,
(case when so.IdPlazo=3 then pre.PrecioMensual else (case when so.IdPlazo=2 then pre.PrecioQuincenal else pre.PrecioDiario end) end )as Precio
	from VClienteGeneral vc
	inner join Solicitud so on vc.Código=so.IdCliente
	inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
	inner join Precio pre on ds.IdPrecio=pre.IdPrecio
	inner join Servicio ser on pre.IdServicio=ser.IdServicio
	where so.EstadoSolicitud=3
go

create view VClientePagoServicio
as
select so.IdSolicitud,pa.IdPago,pa.FechaPago,ser.NombreServicio,
	(case when so.IdPlazo=3 then pre.PrecioMensual else (case when so.IdPlazo=2 then pre.PrecioQuincenal else pre.PrecioDiario end) end )as Precio,pa.Cantidad,
	(case when so.IdPlazo=3 then sum(pre.PrecioMensual*pa.Cantidad) else (case when so.IdPlazo=2 then sum(pre.PrecioQuincenal*pa.Cantidad) else sum(pre.PrecioDiario*pa.Cantidad) end) end )as SubTotal,
	pa.Descuento,pa.Monto as MontoPago 
	from VClienteGeneral vc
	inner join Solicitud so on vc.Código=so.IdCliente
	inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
	inner join Precio pre on ds.IdPrecio=pre.IdPrecio
	inner join Servicio ser on pre.IdServicio=ser.IdServicio
	inner join Pago pa on ds.IdSolicitud=pa.IdSolicitud and ds.IdPrecio=pa.IdPrecio
	group by so.IdSolicitud,pa.IdPago,pa.FechaPago,ser.NombreServicio,so.IdPlazo,pre.PrecioMensual,pre.PrecioQuincenal,pre.PrecioDiario,pa.Cantidad,pa.Descuento,pa.Monto 
go

create view VClienteAsistencia
as
select so.IdSolicitud,vc.NombreCliente,vc.CédulaIdentidad,vc.Foto,asis.IdAsistencia,asis.FechaAsistencia,
asis.FechaRenovacion,asis.Valor
	from VClienteGeneral vc
	inner join Solicitud so on vc.Código=so.IdCliente
	inner join Asistencia asis on so.IdSolicitud=asis.IdSolicitud
	where so.IdTipoSolicitud=2
go

create view VIngresoGeneral
as
	select vcg.TipoSolicitud,vcg.CodVenta as IdSolicitud,vcg.NombreCliente,vcg.FechaSolicitud as Fecha,vcg.MontoTotal as Monto 
	from VClienteSolicitudGeneral vcg
	where Estado='Entregado' and TipoSolicitud='Producto'and TipoPago='Contado'
union
	select (case when so.IdTipoSolicitud=1 then 'Producto' else 'Servicio' end)as TipoSolicitud,so.IdSolicitud,vc.NombreCliente,cu.FechaPago as Fecha,sum(cu.MontoCuota) as Monto 
	from VClienteGeneral vc
	inner join Solicitud so  on vc.Código=so.IdCliente
	inner join Credito cre on so.IdSolicitud=cre.IdSolicitud
	inner join Cuota cu on cre.IdCredito=cu.IdCredito
	where so.EstadoSolicitud=3 
	group by so.IdTipoSolicitud,so.IdSolicitud,vc.NombreCliente,cu.FechaPago
union
	select  (case when so.IdTipoSolicitud=1 then 'Producto' else 'Servicio' end)as TipoSolicitud,so.IdSolicitud,vc.Nombrecliente,pa.FechaPago as Fecha,sum(pa.Monto) as Monto 
	from VClienteGeneral vc
	inner join Solicitud so  on vc.Código=so.IdCliente
	inner join Pago pa on so.IdSolicitud=pa.IdSolicitud
	where so.EstadoSolicitud=3 
	group by so.IdTipoSolicitud,so.IdSolicitud,vc.NombreCliente,pa.FechaPago
go

create view VIngresoGeneralConsolidado
as
select vc.TipoSolicitud,vc.IdSolicitud,vc.NombreCliente,vc.Fecha,sum(vc.Monto)as Monto from VIngresoGeneral vc
group by vc.TipoSolicitud,vc.IdSolicitud,vc.NombreCliente,vc.Fecha
go

create view VProductoInventarioDiario
as
select so.FechaSolicitud,ca.NombreCategoria,pro.IdProducto,pro.NombreProducto,sum(ds.Cantidad) as CantidadVendida, pro.Stock from solicitud so 
inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
inner join Precio pre on ds.IdPrecio=pre.IdPrecio
inner join Producto pro on pre.IdProducto=pro.IdProducto
inner join Categoria ca on pro.IdCategoria=ca.IdCategoria
where so.EstadoSolicitud=3
group by so.FechaSolicitud,ca.NombreCategoria,pro.IdProducto,pro.NombreProducto,pro.Stock
go

create view VCumpleañerosFoto
as
select vcg.Código,vcg.NombreCliente,vcg.CédulaIdentidad,vcg.FechaNacimiento,
day(vcg.FechaNacimiento)as Dia,DATENAME(MONTH,(vcg.FechaNacimiento))as Mes,vcg.Foto 
from vclientegeneral vcg where MONTH(vcg.FechaNacimiento)=MONTH(GETDATE())
go

create view VCumpleañerosGral
as
select vcg.Código,vcg.NombreCliente,vcg.CédulaIdentidad,vcg.FechaNacimiento,
day(vcg.FechaNacimiento)as Dia,DATENAME(MONTH,(vcg.FechaNacimiento))as Mes 
from vclientegeneral vcg 
inner join Solicitud so on vcg.Código=so.IdCliente
inner join Pago pa on so.IdSolicitud=pa.IdSolicitud
left join Credito cre on so.IdSolicitud=cre.IdSolicitud
where (MONTH(vcg.FechaNacimiento)=MONTH(GETDATE()) and DATEDIFF(DAY,pa.FechaPago,GETDATE())<=90) or (MONTH(vcg.FechaNacimiento)=MONTH(GETDATE()) and DATEDIFF(DAY,cre.FechaCredito,GETDATE())<=90)
group by vcg.Código,vcg.NombreCliente,vcg.CédulaIdentidad,vcg.FechaNacimiento
go

create view VCumpleañeros
as
select vcu.Código,vcu.NombreCliente,vcu.CédulaIdentidad,vcu.FechaNacimiento,vcu.Dia,vcu.Mes,vcuf.Foto 
from VCumpleañerosGral vcu 
inner join VCumpleañerosFoto vcuf on vcu.Código=vcuf.Código
go

create view VClienteSolicitudDiario
as
select so.IdSolicitud,vcg.Código,vcg.NombreCliente,vcg.CédulaIdentidad,pa.FechaPago as FechaSolicitud,
	vdsp.NombreServicio,sum(Pa.Monto)as Total
	from VClienteGeneral vcg
	inner join Solicitud so on vcg.Código=so.IdCliente
	inner join VDetalleSolicitudServicioPago vdsp on so.IdSolicitud=vdsp.IdSolicitud
	inner join Pago Pa on so.IdSolicitud=pa.IdSolicitud
	where so.IdTipoSolicitud=2 and so.EstadoSolicitud =3 and so.TipoPago=1 and so.IdPlazo=1
	group by so.IdSolicitud,vcg.Código,vcg.NombreCliente,vcg.CédulaIdentidad,pa.FechaPago,vdsp.NombreServicio
go 

create view VHorarioServicioEstadoPlan
as
select ho.IdHorario,ho.HoraInicio,ho.HoraFin,ho.RangoDia,ho.IdServicio,ho.IdEmpleado,ho.IdCliente,ho.IdSolicitud,
ho.IdTurno,tu.NombreTurno,se.NombreServicio,'Vigente'as EstadoPlan
 from Horario ho
inner join Solicitud so on ho.IdSolicitud=so.IdSolicitud
inner join Pago pa on so.IdSolicitud=pa.IdSolicitud
inner join Turno tu on ho.IdTurno=tu.IdTurno
inner join Servicio se on ho.IdServicio=se.IdServicio
where DATEDIFF(DAY,pa.FechaPago,GETDATE())<=90 
group by ho.IdHorario,ho.HoraInicio,ho.HoraFin,ho.RangoDia,ho.IdServicio,ho.IdEmpleado,ho.IdEmpleado,ho.IdCliente,ho.IdSolicitud,ho.IdTurno,tu.NombreTurno,se.NombreServicio
union
select ho.IdHorario,ho.HoraInicio,ho.HoraFin,ho.RangoDia,ho.IdServicio,ho.IdEmpleado,ho.IdCliente,ho.IdSolicitud,
ho.IdTurno,tu.NombreTurno,se.NombreServicio,'Vigente'as EstadoPlan
 from Horario ho
inner join Solicitud so on ho.IdSolicitud=so.IdSolicitud
inner join Credito cre on so.IdSolicitud=cre.IdSolicitud
inner join Turno tu on ho.IdTurno=tu.IdTurno
inner join Servicio se on ho.IdServicio=se.IdServicio
where DATEDIFF(DAY,cre.FechaCredito,GETDATE())<=90 
group by ho.IdHorario,ho.HoraInicio,ho.HoraFin,ho.RangoDia,ho.IdServicio,ho.IdEmpleado,ho.IdEmpleado,ho.IdCliente,ho.IdSolicitud,ho.IdTurno,tu.NombreTurno,se.NombreServicio
union
select ho.IdHorario,ho.HoraInicio,ho.HoraFin,ho.RangoDia,ho.IdServicio,ho.IdEmpleado,ho.IdCliente,ho.IdSolicitud,
ho.IdTurno,tu.NombreTurno,se.NombreServicio,'Vencido'as EstadoPlan
 from Horario ho
inner join Solicitud so on ho.IdSolicitud=so.IdSolicitud
inner join Pago pa on so.IdSolicitud=pa.IdSolicitud
inner join Turno tu on ho.IdTurno=tu.IdTurno
inner join Servicio se on ho.IdServicio=se.IdServicio
where DATEDIFF(DAY,pa.FechaPago,GETDATE())>90 
group by ho.IdHorario,ho.HoraInicio,ho.HoraFin,ho.RangoDia,ho.IdServicio,ho.IdEmpleado,ho.IdEmpleado,ho.IdCliente,ho.IdSolicitud,ho.IdTurno,tu.NombreTurno,se.NombreServicio
union
select ho.IdHorario,ho.HoraInicio,ho.HoraFin,ho.RangoDia,ho.IdServicio,ho.IdEmpleado,ho.IdCliente,ho.IdSolicitud,
ho.IdTurno,tu.NombreTurno,se.NombreServicio,'Vencido'as EstadoPlan
 from Horario ho
inner join Solicitud so on ho.IdSolicitud=so.IdSolicitud
inner join Credito cre on so.IdSolicitud=cre.IdSolicitud
inner join Turno tu on ho.IdTurno=tu.IdTurno
inner join Servicio se on ho.IdServicio=se.IdServicio
where DATEDIFF(DAY,cre.FechaCredito,GETDATE())>90 
group by ho.IdHorario,ho.HoraInicio,ho.HoraFin,ho.RangoDia,ho.IdServicio,ho.IdEmpleado,ho.IdEmpleado,ho.IdCliente,ho.IdSolicitud,ho.IdTurno,tu.NombreTurno,se.NombreServicio
go

create view VDetalleSolicitudProductoServicio
as
select so.IdSolicitud,ser.IdServicio,ser.NombreServicio,ser.Descripcion,so.IdPlazo,
(case when so.IdPlazo=1 then pre.PrecioDiario else (case when so.IdPlazo=2 then pre.PrecioQuincenal else pre.PrecioMensual end) end )as PrecioVenta,ds.Cantidad, 
(case when so.IdPlazo=1 then sum(pre.PrecioDiario*ds.Cantidad) else (case when so.IdPlazo=2 then sum(pre.PrecioQuincenal*ds.Cantidad) else sum(pre.PrecioMensual*ds.Cantidad) end) end )as SubTotal
	from Solicitud so
	inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
	inner join Precio pre on ds.IdPrecio=pre.IdPrecio
	inner join Servicio ser on pre.IdServicio=ser.IdServicio
	group by so.IdSolicitud,ser.IdServicio,ser.NombreServicio,ser.Descripcion,so.IdPlazo,pre.PrecioDiario,pre.PrecioQuincenal,pre.PrecioMensual,ds.Cantidad
union
select so.IdSolicitud,pro.IdProducto,pro.NombreProducto,pro.DescripcionProducto,'',pre.PrecioVenta,ds.Cantidad, sum(ds.Cantidad*pre.PrecioVenta) as Total 
	from Solicitud so
	inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
	inner join Precio pre on ds.IdPrecio=pre.IdPrecio
	inner join Producto pro on pre.IdProducto=pro.IdProducto
	group by so.IdSolicitud,pro.IdProducto,pro.NombreProducto,pro.DescripcionProducto,pre.PrecioVenta,ds.Cantidad
go

create view VClienteSolicitudDetalleGeneral
as
select vcli.NombreCliente,FechaSolicitud,vds.IdSolicitud,vds.IdServicio,vds.NombreServicio,
vds.Descripcion,(vds.NombreServicio+' / '+vds.Descripcion)as Descripciones,vds.PrecioVenta,vds.Cantidad,vds.SubTotal,d.Monto
 from VDetalleSolicitudProductoServicio vds
inner join Solicitud so on vds.IdSolicitud=so.IdSolicitud
inner join VClienteGeneral vcli on so.IdCliente=vcli.Código
inner join Descuento d on so.IdDescuento=d.IdDescuento
go

create view VSolicitudGeneralAño
as
select a.IdAño,a.NombreAño
	from VClienteSolicitudGeneralConsolidado vs
	inner join Año a on vs.AñoSolicitud=a.NombreAño
group by a.IdAño,a.NombreAño
go

create view VSolicitudGeneralMes
as
select m.IdMes,m.NombreMes,vs.AñoSolicitud
	from VClienteSolicitudGeneralConsolidado vs
	inner join Mes m on vs.IdMes=m.IdMes
group by m.IdMes,m.NombreMes,vs.AñoSolicitud
go
--create view VReporteFacturaLiteral
--as
--SELECT *,(select dbo.CantidadConLetra(vs.MontoTotal)) as Literal FROM VReporteFactura vs
--go


--------------------------------Procedimiento Almacenado-----------------------------------------------
create proc spReporteFactura
@IdVenta int
as
select so.IdSolicitud,so.FechaSolicitud,(per.NombrePersona+' '+per.ApellidoPaterno+' '+per.ApellidoMaterno)as NombreCliente,
per.DocumentoIdentidad as Nit,per.Direccion,pro.NombreProducto,pre.NombrePrecio,ds.Cantidad,sum(pre.NombrePrecio*ds.Cantidad) as MontoTotal
from Persona per
inner join Cliente cli on per.IdPersona=cli.IdPersona
inner join Solicitud so on cli.IdPersona=so.IdCliente
inner join DetalleSolicitud ds on so.IdSolicitud=ds.IdSolicitud
inner join Precio pre on ds.IdPrecio=pre.IdPrecio
inner join Producto pro on pre.IdProducto=pro.IdProducto
where so.IdSolicitud=@IdVenta
group by so.IdSolicitud,so.FechaSolicitud,(per.NombrePersona+' '+per.ApellidoPaterno+' '+per.ApellidoMaterno),
per.DocumentoIdentidad,per.Direccion,pro.NombreProducto,pre.NombrePrecio,ds.Cantidad
go

create procedure sp_VerificarPersonaExiste
@cedula as int
as
declare @existe int

	if exists(select * from Persona where DocumentoIdentidad=@cedula)
		set @existe = 1
	else 
		set @existe = 0

select @existe
go


drop procedure spReporteFactura --Eliminar prodecedimiento
execute spReporteFactura 1
go
---------------------------------Trigger para ActualizarStock al insertarVenta-----------------------------------
CREATE TRIGGER tg_detalleSolicitudVenta_insert ON DetalleSolicitud FOR INSERT
AS
BEGIN
	DECLARE @stock INT
	DECLARE @cantidad INT
	DECLARE @PrecioVenta int
	SELECT @stock = pro.Stock ,@cantidad = ds.cantidad , @PrecioVenta=pre.PrecioVenta FROM Producto  pro  
		inner join  Precio pre on pro.IdProducto=pre.IdProducto 
		inner join INSERTED ds ON ds.IdPrecio = pre.IdPrecio
	  IF(@PrecioVenta!=0)
	  BEGIN
		  IF (@cantidad<=@stock)
		  BEGIN
			UPDATE pro SET pro.Stock = pro.Stock - ds.Cantidad
			 FROM Producto pro
			 inner join Precio pre on pro.IdProducto=pre.IdProducto
			 inner join INSERTED ds on ds.IdPrecio = pre.IdPrecio
		  END
		  ELSE
		  BEGIN
			RAISERROR ('No Hay Stock suficiente para satisfacer la cantidad solicitada. Verifique e intente nuevamente.', 16, 1)
			ROLLBACK TRANSACTION
		  END
	  END
END
GO
------------------------------------------------------------------------------------------------------------

---------------------------------Trigger para ActualizarStock al insertarCompra-----------------------------------
CREATE TRIGGER tg_detalleSolicitudCompra_insert ON DetalleSolicitudCompra FOR INSERT
AS
BEGIN
	DECLARE @stock INT
	DECLARE @cantidad INT
	SELECT @stock = pro.Stock ,@cantidad = dsc.Cantidad FROM Producto  pro  
		inner join  Precio pre on pro.IdProducto=pre.IdProducto 
		inner join INSERTED dsc ON dsc.IdPrecio = pre.IdPrecio
	  BEGIN
		UPDATE pro SET pro.Stock = pro.Stock + dsc.Cantidad
		 FROM Producto pro
		 inner join Precio pre on pro.IdProducto=pre.IdProducto
		 inner join INSERTED dsc on dsc.IdPrecio = pre.IdPrecio
	  END
END
GO
----------------------------------------------------------------------------------------------------------------

---------------------------------Trigger para ActualizarStock al Anular una Solicitud de Venta de Producto------------------
CREATE TRIGGER tg_Solicitud_update_Producto ON Solicitud FOR UPDATE
AS
BEGIN
	DECLARE @Estado INT
	DECLARE @CodProducto INT
	DECLARE @Cantidad Int
	SELECT @Estado = Sol.EstadoSolicitud, @CodProducto=pro.IdProducto, @Cantidad=ds.Cantidad FROM Producto Pro  
		inner join  Precio pre on pro.IdProducto=pre.IdProducto 
		inner join DetalleSolicitud ds on pre.IdPrecio=ds.IdPrecio
		inner join INSERTED Sol ON ds.IdSolicitud = Sol.IdSolicitud
	  IF (@Estado=2)
	  BEGIN
		 UPDATE pro SET pro.Stock = pro.Stock + ds.Cantidad
		 FROM Producto pro
		 inner join Precio pre on pro.IdProducto=pre.IdProducto
		 inner join DetalleSolicitud ds on ds.IdPrecio = pre.IdPrecio
		 inner join INSERTED Sol ON ds.IdSolicitud = Sol.IdSolicitud
	  END
END
GO
------------------------------------------------------------------------------------------------------------------

---------------------------------Trigger para actualizar e eliminar, al Anular una Solicitud de Venta de Servicio------------------
CREATE TRIGGER tg_Solicitud_update_Servicio ON Solicitud FOR UPDATE
AS
BEGIN
	DECLARE @Estado INT
	DECLARE @IdSolicitud int
	DECLARE @TipoPago int
	SELECT @IdSolicitud=Sol.IdSolicitud,@TipoPago=Sol.TipoPago,@Estado=Sol.EstadoSolicitud FROM INSERTED Sol  
	IF(@TipoPago=1)
	BEGIN
	SELECT @IdSolicitud=Sol.IdSolicitud, @Estado = Sol.EstadoSolicitud FROM Pago pa  
		 inner join DetalleSolicitud ds on pa.IdSolicitud = ds.IdSolicitud
		 inner join INSERTED Sol ON ds.IdSolicitud = Sol.IdSolicitud
	  IF (@Estado=2)
	  BEGIN
	   UPDATE pa SET pa.EstadoPago = 0
		 FROM Pago pa
		 inner join DetalleSolicitud ds on pa.IdSolicitud = ds.IdSolicitud
		 inner join INSERTED Sol ON ds.IdSolicitud = Sol.IdSolicitud
		delete from Horario where Horario.IdSolicitud=@IdSolicitud
		delete from Asistencia where Asistencia.IdSolicitud=@IdSolicitud
	  END
	END
	ELSE IF (@Estado=2)
	BEGIN
		delete from Horario where Horario.IdSolicitud=@IdSolicitud
		delete from Asistencia where Asistencia.IdSolicitud=@IdSolicitud
	END
END
GO
------------------------------------------------------------------------------------------------------------------
drop trigger tg_Solicitud_update

select * from precio
update Precio Set NombrePrecio=6.4 where Precio.IdPrecio=4
drop view VEmpleadosActivo	
select * from VClienteGeneral
SELECT * FROM  Persona
update Permiso set NombrePermiso='Ver Reportes' where Permiso.IdPermiso=36
update Descuento set Monto=60 where Descuento.IdDescuento=2
delete RolPermiso
drop table Rolpermiso
select * from VRolPermiso
INSERT INTO Sucursal VALUES(0,'--- Seleccionar ---',null,null)
go
delete from Permiso where Permiso.IdPermiso=37
SELECT * FROM Permiso
update Categoria set EstadoCategoria=1 where Categoria.IdCategoria=2
	select * from DetalleSolicitud
	select * from BitacoraLogin
	select * from BitacoraCliente
	delete from Sucursal
	drop table Descuento
	drop table Persona
	drop table Cliente
	drop table Empleado
	drop table Solicitud
	update Bitacora set HoraSalida='09:13:00' where IdBitacora=2
	update Producto set Stock=20 where IdProducto=3
	drop view VClienteSolicitudGeneral
	delete from DetalleSolicitud where IdSolicitud=17
	insert into DetalleSolicitud values (17,1,1)
	insert into DetalleSolicitud values (17,2,1)
	insert into DetalleSolicitud values (17,3,1)
	
select * from VClienteSolicitudGeneral
select * from Factura
select * from DetalleSolicitudCompra
select * from VClienteSolicitudGeneral
update Pago set IdPago=2 where IdPago=58
Delete Servicio where IdServicio=5
go
select * from VClienteSolicitudGeneral vc where vc.CédulaIdentidad=8965698 order by vc.CodVenta desc 
select * from Asistencia
select * from Plazo  
select * from VClienteGeneral
select * from Horario ho inner join Turno tu on ho.IdTurno=tu.IdTurno




