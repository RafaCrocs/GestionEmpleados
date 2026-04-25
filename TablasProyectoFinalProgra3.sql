create database GestionEmpleadosOficial
go

use GestionEmpleadosOficial
go

create table Sucursales (
	IdSucursal int primary key identity(1,1),
	Nombre varchar(50) not null unique,
	Direccion varchar(100) not null,
	Telefono varchar(20) not null,
	FechaCreacion date not null default getdate()
);
go

create table Roles (
	IdRol int primary key identity(1,1),
	Nombre varchar(50) not null unique,
	Descripcion varchar(100) not null
);
go

create table Usuarios (
	IdUsuario int primary key identity(1,1),
	IdSucursal int not null,
	Nombre varchar(50) not null,
	Apellidos varchar(50) not null,
	Identificacion varchar(50) not null unique,
	IdRol int not null,
	Correo varchar(100) not null unique,
	Contrasenna varchar(255) not null,
	FechaCreacion date not null default getdate(),
	Activo bit not null,

	Constraint FK_Usuarios_Sucursales foreign key (IdSucursal) references Sucursales(IdSucursal),
	Constraint FK_Usuarios_Roles foreign key (IdRol) references Roles(IdRol)

);
go


create table Puestos (
	IdPuesto int primary key identity(1,1),
	Nombre varchar(50) not null unique,
	SalarioReportado decimal(18, 2) not null,
	PorcentajeSeguro decimal(18, 2) not null,
	Seguro decimal(18, 2) not null
);
go


create table Empleados (
	IdEmpleado int primary key identity(1,1),
	IdSucursal int not null,
	Identificacion varchar(50) not null unique,
	Nombre varchar(50) not null,
	Apellidos varchar(50) not null,
	Telefono varchar(20) not null,
	Correo varchar(100) not null,
	Contrasenna varchar(255) not null,
	FechaNacimiento date not null,
	FechaIngreso date not null default getdate(),
	FechaSalida date null,
	IdPuesto int not null,
	SalarioReal decimal(18, 2) not null,
	SalarioReportado decimal(18, 2) not null,
	Seguro decimal(18, 2) not null,
	ValorHora decimal(18, 2) not null,
	Bonificacion decimal(18, 2) not null,
	PagaSeguro bit not null,
	Estado varchar(50) not null

	Constraint FK_Empleados_Puestos foreign key (IdPuesto) references Puestos(IdPuesto),
	Constraint FK_Empleados_Sucursales foreign key (IdSucursal) references Sucursales(IdSucursal),
	Constraint CK_Empleados_Estado check (Estado IN ('Activo', 'Inactivo', 'Vacaciones', 'Incapacidad'))
);
go



create table RegistroHoras (
	IdDispositivo int primary key identity(1,1),
	IdEmpleado int not null,
	Fecha date not null,
	HoraEntrada datetime not null,
	HoraSalida datetime null,
	HorasTrabajadas decimal (18,2) null,
	HorasExtra decimal (18,2) null,
	HorasDobles decimal (18,2) null,

	Constraint FK_RegistroHoras_Empleados foreign key (IdEmpleado) references Empleados(IdEmpleado)
);
go

create table Incapacidades (
	IdIncapacidad int primary key identity(1,1),
	IdEmpleado int not null,
	FechaInicio date not null default getdate(),
	FechaFin date not null,
	TipoIncapacidad varchar(50) not null,
	DiasAPagar int not null,
	DiasPagados int not null,
	FactorSalario decimal(18, 2) not null,

	Constraint FK_Incapacidades_Empleados foreign key (IdEmpleado) references Empleados(IdEmpleado)
);
go

create table Vacaciones (
	IdVacacion int primary key identity(1,1),
	IdEmpleado int not null,
	FechaInicio date not null default getdate(),
	FechaFin date not null,
	FactorSalario decimal(18, 2) not null,
	Aprobadas bit not null,
	Constraint FK_Vacaciones_Empleados foreign key (IdEmpleado) references Empleados(IdEmpleado)
);
go

create table Adelantos (
	IdAdelanto int primary key identity(1,1),
	IdEmpleado int not null,
	Monto decimal(18, 2) not null,
	Fecha date not null default getdate(),
	Detalle varchar(100) default null,
	Constraint FK_Adelantos_Empleados foreign key (IdEmpleado) references Empleados(IdEmpleado)
);
go

create table Prestamos (
	IdPrestamo int primary key identity(1,1),
	IdEmpleado int not null,
	Monto decimal(18, 2) not null,
	SugerenciaDeRebajo decimal(18, 2) null,
	FechaInicio date not null default getdate(),
	MontoRestante decimal(18, 2) not null,
	MontoPagado decimal(18, 2) default 0,
	Detalle varchar(100) not null,

	Constraint FK_Prestamos_Empleados foreign key (IdEmpleado) references Empleados(IdEmpleado)
);
go

create table RegistroPrestamos (
	IdRegistro int primary key identity(1,1),
	IdPrestamo int not null,
	IdEmpleado int not null,
	NombreEmpleado varchar(100) not null,
	MontoPagado decimal(18, 2) not null,
	Fecha date not null default getdate(),
	Constraint FK_RegistroPrestamos_Prestamos foreign key (IdPrestamo) references Prestamos(IdPrestamo),
	Constraint FK_RegistroPrestamos_Empleados foreign key (IdEmpleado) references Empleados(IdEmpleado)
);
go


create table RegistroPagos (
	IdPago int primary key identity(1,1),
	IdEmpleado int not null,
	NombreEmpleado varchar(100) not null,
	HorasTrabajadas decimal(18, 2) not null,
	HorasExtra decimal(18, 2) not null,
	DiasAusentes int not null,
	DiasIncapacitados int not null,
	DiasDobles int not null,
	SalarioReal decimal(18, 2) not null,
	SalarioPagado decimal(18, 2) not null,
	SalarioReportado decimal(18, 2) not null,
	Seguro decimal(18, 2) not null,
	Adelanto decimal(18, 2) not null,
	Prestamo decimal(18, 2) not null,
	Bonificacion decimal(18, 2) not null,
	Fecha date not null default getdate()

	Constraint FK_RegistroPagos_Empleados foreign key (IdEmpleado) references Empleados(IdEmpleado)
);
go


Create table DiaFestivo (
	IdDiaFestivo int primary key identity(1,1),
	Nombre varchar(50) not null unique,
	Fecha date not null unique,
	SePagaDoble bit not null,
	Activo bit not null
);
go

insert into Roles (Nombre, Descripcion) values
('Admin', 'Administrador del sistema con acceso completo'),
('Gerente', 'Gerente de sucursal con acceso a reportes y gestión de empleados'),
('Empleado', 'Empleado regular con acceso a su información personal y registro de horas');
go

insert into Sucursales (Nombre, Direccion, Telefono, FechaCreacion) values
('San Ramon', 'Alajuela, San Ramon', '5555-5555', '2026-04-13'),
('Liberia', 'Liberia, Guardia', '1234-5678', '2026-04-13'),
('Orotina', 'Alajuela, Orotina', '8765-4321', '2026-04-13'),
('Chaverri', 'Sarchi', '5555-1234', '2026-04-13'),
('Eloy Alfaro', 'Sarchi', '1234-5555', '2026-04-13')
go

insert into Usuarios (IdSucursal, Nombre, Apellidos, Identificacion, IdRol, Correo, Contrasenna, Activo) values
(1, 'Jose', 'Cruz', '123', 1, 'josecruz23@ulatina.co.cr', '123', 1),
(1, 'Oscar', 'Gonzalez', '208600681', 2, 'oscar@ulatina.co.cr', '123', 1),
(1, 'Maria', 'Lopez', '208600682', 3, 'maria@ulatina.co.cr', '123', 1)
go

create or alter view VW_Empleados
as
select
	e.IdEmpleado,
	e.Identificacion,
	e.Nombre,
	e.Apellidos,
	e.Telefono,
	e.Correo,
	e.Contrasenna,
	e.FechaNacimiento,
	e.FechaIngreso,
	e.FechaSalida,
	p.IdPuesto,
	p.Nombre AS NombrePuesto,
	s.IdSucursal,
	e.SalarioReportado,
	e.SalarioReal,
	s.Nombre AS NombreSucursal,
	e.ValorHora,
	e.Bonificacion,
	e.Seguro,
	e.PagaSeguro,
	e.Estado
from Empleados e
join Puestos p on e.IdPuesto = p.IdPuesto
join Sucursales s on e.IdSucursal = s.IdSucursal
go

--Insertar Puesto y Seguro
create or alter procedure SP_InsertarPuesto_Seguro(
	@Nombre varchar(50),
	@SalarioReportado decimal(18, 2),
	@PorcentajeSeguro decimal(18, 2),
	@Mensaje varchar(500) output,
	@Resultado bit output
)
as
begin
	begin try
		if exists (select 1 from Puestos where Nombre = @Nombre)
		begin
			set @Mensaje = 'Ya existe un puesto con ese nombre'
			set @Resultado = 0;
			return;
		end
		else
		begin
			
				insert into Puestos (Nombre, SalarioReportado, PorcentajeSeguro, Seguro)
				values (@Nombre, @SalarioReportado, @PorcentajeSeguro, (@SalarioReportado * @PorcentajeSeguro/100))
				set @Resultado = 1;
		end
	end try
	begin catch
		set @Mensaje = 'Ocurrió un error al insertar el puesto'			
		set @Resultado = 0;
		return;		
	end catch
end
go
-- Editar Puesto y Seguro
create or alter procedure SP_Editar_Puesto_Seguro(
	@IdPuesto int,
	@Nombre varchar(50),
	@SalarioReportado decimal(18, 2),
	@PorcentajeSeguro decimal(18, 2),
	@Mensaje varchar(500) output,
	@Resultado bit output
)
as
begin
	begin try
		if not exists (select 1 from Puestos where IdPuesto = @IdPuesto)
		begin
			set @Mensaje = 'No existe un puesto con ese ID'
			set @Resultado = 0;
			return;
		end
		else
		begin
			update Puestos
			set Nombre = @Nombre,
				SalarioReportado = @SalarioReportado,
				PorcentajeSeguro = @PorcentajeSeguro,
				Seguro = (@SalarioReportado * @PorcentajeSeguro/100)
			where IdPuesto = @IdPuesto;

			set @Resultado = 1;
		end
	end try
	begin catch
		set @Mensaje = 'Ocurrió un error al editar el puesto y seguro'
		set @Resultado = 0;
		return;
	end catch
end
go

create or alter procedure SP_Eliminar_Puesto_Seguro(
	@IdPuesto int,
	@Resultado bit output,
	@Mensaje varchar(500) output
)
as
begin
	begin try
		if not exists (select 1 from Puestos where IdPuesto = @IdPuesto)
		begin
			set @Mensaje = 'No existe un puesto con ese ID'
			set @Resultado = 0;
			return;
		end
		else if exists (select 1 from Empleados where IdPuesto = @IdPuesto)
		begin
			set @Mensaje = 'No se puede eliminar puestos si existen empleados asignados con ese puesto'
			set @Resultado = 0;
			return;
		end
		else
		begin
			delete from Puestos where IdPuesto = @IdPuesto
			set @Resultado = 1;
		end
	end try
	begin catch
		set @Mensaje = 'Ocurrió un error al eliminar el puesto'
		set @Resultado = 0;
		return;
	end catch
end
go


create or alter view VW_Puestos_Seguros
as
select
	a.IdPuesto,
	a.Nombre AS NombrePuesto,
	a.SalarioReportado,
	a.PorcentajeSeguro,
	a.Seguro
	from Puestos a
go
--Logica para Insertar Empleados

create or alter procedure SP_InsertarEmpleado(
	@IdSucursal int,
	@Identificacion varchar(50),
	@Nombre varchar(50),
	@Apellidos varchar(50),
	@Telefono varchar(20),
	@Correo varchar(100),
	@Contrasenna varchar(255),
	@FechaNacimiento date,
	@IdPuesto int,
	@ValorHora decimal(18, 2),
	@SalarioReportado decimal(18, 2),
	@SalarioReal decimal(18, 2),
	@Bonificacion decimal(18, 2),
	@Seguro decimal(18, 2),
	@PagaSeguro bit,
	@Estado varchar(50),
	@Resultado bit output,
	@Mensaje varchar(500) output
)
as
begin
	if exists (select 1 from Empleados where Identificacion = @Identificacion)
	begin
		set @Mensaje = 'Ya existe un empleado con esa identificación'
		set @Resultado = 0;
		return;
	end
	else

	begin
		insert into Empleados (IdSucursal, Identificacion, Nombre, Apellidos, Telefono, Correo, Contrasenna, FechaNacimiento, IdPuesto, ValorHora, SalarioReal, SalarioReportado, Seguro, Bonificacion, PagaSeguro, Estado)
		values (@IdSucursal, @Identificacion, @Nombre, @Apellidos, @Telefono, @Correo, @Contrasenna, @FechaNacimiento, @IdPuesto, @ValorHora, @SalarioReal, @SalarioReportado, @Seguro, @Bonificacion, @PagaSeguro, @Estado)
		set @Resultado = 1;
	end
end
go

create or alter procedure SP_EditarEmpleado(
	@IdEmpleado int,
	@IdSucursal int,
	@Identificacion varchar(50),
	@Nombre varchar(50),
	@Apellidos varchar(50),
	@Telefono varchar(20),
	@Correo varchar(100),
	@Contrasenna varchar(255),
	@FechaNacimiento date,
	@IdPuesto int,
	@ValorHora decimal(18, 2),
	@SalarioReal decimal(18, 2),
	@SalarioReportado decimal(18, 2),
	@Bonificacion decimal(18, 2),
	@Seguro decimal(18, 2),
	@PagaSeguro bit,
	@Estado varchar(50),
	@Resultado bit output,
	@Mensaje varchar(500) output
)
as
begin
	begin try
		if not exists (select 1 from Empleados where IdEmpleado = @IdEmpleado)
		begin
			set @Mensaje = 'No existe un empleado con ese ID'
			set @Resultado = 0;
			return;
		end
		else if exists (select 1 from Empleados where Identificacion = @Identificacion and IdEmpleado != @IdEmpleado)
		begin
			set @Mensaje = 'Ya existe otro empleado con esa identificación'
			set @Resultado = 0;
			return;
		end
		else
		begin
			update Empleados
			set IdSucursal = @IdSucursal,
				Identificacion = @Identificacion,
				Nombre = @Nombre,
				Apellidos = @Apellidos,
				Telefono = @Telefono,
				Correo = @Correo,
				Contrasenna = @Contrasenna,
				FechaNacimiento = @FechaNacimiento,
				IdPuesto = @IdPuesto,
				ValorHora = @ValorHora,
				SalarioReal = @SalarioReal,
				SalarioReportado = @SalarioReportado,
				Bonificacion = @Bonificacion,
				Seguro = @Seguro,
				PagaSeguro = @PagaSeguro,
				Estado = @Estado
			where IdEmpleado = @IdEmpleado
			set @Resultado = 1;
		end
	end try
	begin catch
		set @Mensaje = 'Ocurrió un error al editar el empleado'
		set @Resultado = 0;
		return;
	end catch
end
go


create or alter procedure SP_Eliminar_Empleado(
	@IdEmpleado int,
	@Resultado bit output,
	@Mensaje varchar(500) output
)
as
begin
	if exists (select * from Adelantos where IdEmpleado = @IdEmpleado)
	begin
		set @Mensaje = 'No se puede eliminar el empleado porque tiene adelantos pendientes'
		set @Resultado = 0;
		return;
	end
	else if exists (select 1 from Incapacidades where IdEmpleado = @IdEmpleado)
	begin
		set @Mensaje = 'No se puede eliminar el empleado porque tiene incapacidades registradas'
		set @Resultado = 0;
		return;
	end
	else if exists (select 1 from Prestamos where IdEmpleado = @IdEmpleado)
	begin
		set @Mensaje = 'No se puede eliminar el empleado porque tiene préstamos pendientes'
		set @Resultado = 0;
		return;
	end
	else if exists (select 1 from RegistroHoras where IdEmpleado = @IdEmpleado)
	begin
		set @Mensaje = 'No se puede eliminar el empleado porque tiene registros de Salarios'
		set @Resultado = 0;
		return;
	end
	else
	begin
		delete from Empleados where IdEmpleado = @IdEmpleado
		set @Resultado = 1;
	end
end
go



create or alter procedure SP_InsertarAdelanto(
	@IdEmpleado int,
	@NombreEmpleado varchar(100),
	@Monto decimal(18, 2),
	@Detalle varchar(100),
	@Mensaje varchar(500) output,
	@Resultado bit output
	)
	as
	begin
	begin try
		-- Ver los adelantos previos del empleado
			declare @TotalPrevio decimal(18, 2);
			declare @SalarioReal decimal(18, 2);

			select @TotalPrevio = isnull(sum(Monto), 0)
			from Adelantos
			where IdEmpleado = @IdEmpleado;

			select @SalarioReal = SalarioReal
			from Empleados e
			join Puestos p on e.IdPuesto = p.IdPuesto
			where e.IdEmpleado = @IdEmpleado;

			select @NombreEmpleado = Nombre + ' ' + Apellidos
			from Empleados
			where IdEmpleado = @IdEmpleado;
		--Monto Negativo
		if(@Monto <= 0)
		begin
			set @Mensaje = 'El monto del adelanto debe ser positivo'
			set @Resultado = 0;
			return;
		end
		-- Limite de adelanto
		if(@TotalPrevio + @Monto > @SalarioReal)
		begin
			set @Mensaje = 'El monto total de adelantos no puede exceder el salario base del empleado'
			set @Resultado = 0;
			return;
		end
		else
		begin
			insert into Adelantos (IdEmpleado, Monto, Detalle)
			values (@IdEmpleado, @Monto, @Detalle)
			set @Resultado = 1;
		end
	end try
	begin catch
		set @Mensaje = 'Ocurrió un error al insertar el adelanto'
		set @Resultado = 0;
		return;
	end catch
	end
go

-- Vista para mostrar los adelantos con el nombre del empleado
create or alter view VW_AdelantosEmpleados
as
select
    a.IdAdelanto,
	e.IdEmpleado,
    e.Nombre + ' ' + e.Apellidos as Nombre,
    a.Monto,
    a.Fecha,
    a.Detalle
from dbo.Adelantos a
INNER JOIN dbo.Empleados e ON a.IdEmpleado = e.IdEmpleado
go

-- Procedimiento almacenado para insertar un préstamo
create or alter procedure SP_InsertarPrestamo(
	@IdEmpleado int,
	@Monto decimal(18, 2),
	@SugerenciaDeRebajo decimal(18, 2),
	@Detalle varchar(100),
	@Mensaje varchar(500) output,
	@Resultado bit output
)
as
begin
	begin try
		if exists (select 1 from Prestamos where IdEmpleado = @IdEmpleado)
		begin
			declare @NombreEmpleado varchar(100);
			select @NombreEmpleado = Nombre + ' ' + Apellidos from Empleados where IdEmpleado = @IdEmpleado;
			set @Mensaje = @NombreEmpleado + ' ya tiene un préstamo pendiente'
			set @Resultado = 0;
			return;
		end

		if(@Monto <= 0)
		begin
			set @Mensaje = 'El monto del préstamo debe ser positivo'
			set @Resultado = 0;
			return;
		end
		if(@SugerenciaDeRebajo < 0)
		begin
			set @Mensaje = 'La sugerencia de rebajo no puede ser negativa'
			set @Resultado = 0;
			return;
		end
			
		declare @MontoRestante decimal(18, 2);

		set @MontoRestante = @Monto;
		insert into Prestamos (IdEmpleado, Monto, SugerenciaDeRebajo, MontoRestante, Detalle)
		values (@IdEmpleado, @Monto, @SugerenciaDeRebajo, @MontoRestante, @Detalle)
		set @Resultado = 1;
		set @Mensaje = 'Préstamo insertado exitosamente';
	end try
	begin catch
		set @Mensaje = 'Ocurrió un error al insertar el prestamo'
		set @Resultado = 0;
		return;
	end catch
end
go

--Procedimiento almacenado para Editar un préstamo
create or alter procedure SP_EditarPrestamo(
	@IdPrestamo int,
	@Monto  decimal(18, 2),
	@SugerenciaDeRebajo decimal(18, 2),
	@Detalle varchar(100),
	@Mensaje varchar(500) output,
	@Resultado bit output
)
as
begin
	begin try
		if(@Monto <= 0)
		begin
			set @Mensaje = 'El monto del préstamo debe ser positivo'
			set @Resultado = 0;
			return;
		end
		
		declare @CambioEnMonto decimal(18, 2);
		select @CambioEnMonto = Monto - @Monto from Prestamos where IdPrestamo = @IdPrestamo;
		update Prestamos
		set Monto = @Monto,
			SugerenciaDeRebajo = @SugerenciaDeRebajo,
			MontoRestante = @Monto + @CambioEnMonto,
			Detalle = @Detalle
		where IdPrestamo = @IdPrestamo
		set @Resultado = 1;
		set @Mensaje = 'Préstamo editado exitosamente';
	end try
	begin catch
		set @Mensaje = 'Ocurrió un error al editar el prestamo'
		set @Resultado = 0;
		return;
	end catch
end
go


--Procedimiento almacenado para eliminar un préstamo
create  or alter procedure SP_EliminarPrestamo(
	@IdPrestamo int,
	@Resultado bit output,
	@Mensaje varchar(500) output
)
as
begin
	begin try
		delete from Prestamos where IdPrestamo = @IdPrestamo
		set @Resultado = 1;
		set @Mensaje = 'Préstamo eliminado exitosamente';
	end try
	begin catch
		set @Mensaje = 'Ocurrió un error al eliminar el prestamo'
		set @Resultado = 0;
		return;
	end catch
end
go

--Procedimiento almacenado para registrar entrada y salida de empleados
create or alter PROCEDURE SP_RegistrarEntradaSalida(
	@IdEmpleado int,
	@TipoRegistro varchar(10),
	@Mensaje varchar(500) output,
	@Resultado bit output
)
as
begin
	begin try
		declare @HoraSalida DATETIME
		declare @HorasTrabajadas DECIMAL(18,2) = 0
		declare @HorasExtra DECIMAL(18,2) = 0
		declare @HorasDobles DECIMAL(18,2) = 0
		declare @EsDiaFestivo BIT = 0
		declare @FechaActual DATE = CAST(GETDATE() AS DATE)
		declare @HoraEntrada DATETIME

		if(@TipoRegistro = 'Entrada')
		begin
			insert into RegistroHoras (IdEmpleado, Fecha, HoraEntrada)
			values (@IdEmpleado, @FechaActual, GETDATE())
			set @Mensaje = 'Se registro la entrada'
			set @Resultado = 1
		end
		else if(@TipoRegistro = 'Salida')
		begin
			select @HoraEntrada = HoraEntrada 
			from RegistroHoras 
			where IdEmpleado = @IdEmpleado 
			  AND Fecha = @FechaActual 
			  AND HoraSalida IS NULL
			
			-- Calcular las horas trabajadas
			set @HoraSalida = GETDATE()
			set @HorasTrabajadas = DATEDIFF(MINUTE, @HoraEntrada, @HoraSalida) / 60.0
			
			-- Verificar si es día festivo
			if EXISTS (select 1 from DiaFestivo 
			           where Fecha = @FechaActual 
			             AND SePagaDoble = 1 
			             AND Activo = 1)
			begin
				set @EsDiaFestivo = 1
			end
			
			-- Calcular distribución de horas
			if @EsDiaFestivo = 1
			begin
				set @HorasDobles = @HorasTrabajadas
				set @HorasTrabajadas = 0
				set @HorasExtra = 0
			end
			else
			begin
				-- Día normal: separar horas normales y extras
				if @HorasTrabajadas > 8
				begin
					set @HorasExtra = @HorasTrabajadas - 8
					set @HorasTrabajadas = 8
				end
				else
				begin
					set @HorasExtra = 0
				end
				set @HorasDobles = 0
			end
			
			-- Actualizar registro
			UPDATE RegistroHoras
			set HoraSalida = @HoraSalida,
				HorasTrabajadas = @HorasTrabajadas,
				HorasExtra = @HorasExtra,
				HorasDobles = @HorasDobles
			where IdEmpleado = @IdEmpleado 
			  AND Fecha = @FechaActual 
			  AND HoraSalida IS NULL
			  
			set @Mensaje = 'Salida registrada'
			set @Resultado = 1
		end
	end try
	begin catch
		set @Mensaje = 'Error'
		set @Resultado = 0
	end catch
end
go

--Ver deducciones de un empleado
create or alter procedure SP_VerDeduccionesEmpleado(
	@IdEmpleado int
)
as
begin
	declare @Puesto varchar(50)
	declare @TotalAdelantos decimal(18,2) = 0
	declare @TotalPrestamos decimal(18,2) = 0
	declare @HorasTrabajadas decimal(18,2) = 0
	declare @HorasExtra decimal(18,2) = 0
	declare @Bonificacion decimal(18,2) = 0
	declare @SalarioReal decimal(18,2) = 0
	declare @SalarioReportado decimal(18,2) = 0
	declare @Seguro decimal(18,2) = 0
	declare @ValorHora decimal(18,2) = 0
	
	-- Obetener ValorHora, Salario Real y Salario Reportado 
	select @SalarioReal = SalarioReal,
			@ValorHora = ValorHora,
			@Seguro = Seguro,
			@SalarioReportado = SalarioReportado
	from Empleados
	where IdEmpleado = @IdEmpleado

	-- Obtener Puesto
	select @Puesto = p.Nombre
	from Empleados e
	join Puestos p on e.IdPuesto = p.IdPuesto
	where e.IdEmpleado = @IdEmpleado

	-- Calcular adelantos
	select @TotalAdelantos = ISNULL(SUM(Monto), 0) 
	from Adelantos 
	where IdEmpleado = @IdEmpleado
	
	-- Calcular préstamos
	select @TotalPrestamos = ISNULL(SUM(SugerenciaDeRebajo), 0) 
	from Prestamos 
	where IdEmpleado = @IdEmpleado

	--Calcular Horas
	select @HorasTrabajadas = ISNULL(SUM(HorasTrabajadas), 0)
	from RegistroHoras
	where IdEmpleado = @IdEmpleado and Fecha = cast(getdate() as date)

	--Calcular Horas Extra
	if(@HorasTrabajadas > 8)
	begin
		set @HorasTrabajadas = @HorasTrabajadas + ((@HorasTrabajadas - 8) * 0.5)
	end
	-- Ver Bonificación
	select @Bonificacion = Bonificacion
	from Empleados
	where IdEmpleado = @IdEmpleado
	
	-- Retornar resultados
	select 
		e.IdEmpleado,
		e.Nombre + ' ' + e.Apellidos as NombreEmpleado,
		@Puesto as Puesto,
		@SalarioReal as SalarioReal,
		@SalarioReportado as SalarioReportado,
		@TotalAdelantos as TotalAdelantos,
		@TotalPrestamos as Rebajo_de_Prestamo,
		@Seguro as Seguro,
		@ValorHora as ValorHora,
		@HorasTrabajadas as HorasTrabajadas,
		@HorasExtra as HorasExtra,
		@Bonificacion as Bonificacion
	from Empleados e
	where e.IdEmpleado = @IdEmpleado
end
go




create or alter procedure SP_PagarSalario(
	@IdEmpleado int,
	@Seguro decimal(18, 2),
	@Adelanto decimal(18, 2),
	@RebajoDePrestamo decimal(18, 2),
	@HorasTrabajadas decimal(18, 2),
	@HorasExtra decimal(18, 2),
	@DiasAusentes int,
	@DiasIncapacitados int,
	@DiasDobles int,
	@Bonificacion decimal(18, 2),
	@SalarioReal decimal(18, 2),
	@SalarioPagado decimal(18, 2),
	@SalarioReportado decimal(18, 2),
	@Mensaje varchar(500) output,
	@Resultado bit output
)
as
begin
	begin try
		declare @NombreEmpleado varchar(100)
		declare @ValorHora decimal(18, 2)


		select @NombreEmpleado = Nombre + ' ' + Apellidos + ' ' + Identificacion,
				@ValorHora = ValorHora
		from Empleados
		where IdEmpleado = @IdEmpleado

		insert into RegistroPagos (IdEmpleado, NombreEmpleado, HorasTrabajadas, HorasExtra,DiasAusentes, DiasIncapacitados, DiasDobles, SalarioReal,SalarioPagado, SalarioReportado, Seguro, Adelanto, Prestamo, Bonificacion)
					values (@IdEmpleado, @NombreEmpleado, @HorasTrabajadas, @HorasExtra,@DiasAusentes, @DiasIncapacitados, @DiasDobles, @SalarioReal, @SalarioPagado , @SalarioReportado, @Seguro,@Adelanto,@RebajoDePrestamo,@Bonificacion)

		delete from Adelantos where IdEmpleado = @IdEmpleado;

		update Prestamos set
							MontoRestante = MontoRestante - @RebajoDePrestamo, 
							MontoPagado = MontoPagado + @RebajoDePrestamo
		where IdEmpleado = @IdEmpleado;

		insert into RegistroPrestamos (IdPrestamo, IdEmpleado, NombreEmpleado, MontoPagado)
		select IdPrestamo, @IdEmpleado, @NombreEmpleado, @RebajoDePrestamo
		from Prestamos
		where IdEmpleado = @IdEmpleado and MontoRestante > 0
		
		set @Mensaje = 'Salario pagado exitosamente';
		set @Resultado = 1;
	end try
	begin catch
		set @Mensaje = 'Ocurrió un error al pagar el salario'
		set @Resultado = 0;
	end catch
end
go

create or alter procedure SP_VerRegistroPagos(
	@IdEmpleado int = null,
	@Fecha date = null
)
as
begin
	select
	NombreEmpleado,
	HorasTrabajadas,
	HorasExtra,
	DiasAusentes,
	DiasIncapacitados,
	DiasDobles,
	SalarioReal,
	SalarioPagado,
	SalarioReportado,
	Seguro,
	Adelanto,
	Prestamo,
	Bonificacion,
	Fecha
	from RegistroPagos
	where (@IdEmpleado is null or IdEmpleado = @IdEmpleado) AND (@Fecha is null or Fecha = @Fecha)
	order by Fecha desc
end
go


create or alter view VW_RegistroPrestamos
as
select
	IdRegistro,
	IdPrestamo,
	IdEmpleado,
	NombreEmpleado,
	MontoPagado,
	Fecha
from RegistroPrestamos
go
