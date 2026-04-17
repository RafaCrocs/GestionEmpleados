create database GestionEmpleados17
go

use GestionEmpleados17
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
	SalarioBase decimal(18, 2) not null,
);
go

create table Seguros (
	IdSeguro int primary key identity(1,1),
	IdPuesto int not null,
	PorcentajeEmpleado decimal(5, 2) not null,
	MontoEmpleado decimal(18, 2) not null,
	PorcentajeEmpresa decimal(5, 2) not null,
	MontoEmpresa decimal(18, 2) not null,
	Constraint FK_Seguros_Puestos foreign key (IdPuesto) references Puestos(IdPuesto)
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
	Cuotas int not null,
	CuotasRestantes int not null,
	MontoAPagarPorCuota decimal(18, 2) not null,
	FechaInicio date not null default getdate(),
	MontoRestante decimal(18, 2) not null,
	MontoPagado decimal(18, 2) default 0,
	Detalle varchar(100) not null,

	Constraint FK_Prestamos_Empleados foreign key (IdEmpleado) references Empleados(IdEmpleado)
);
go

create table RegistroPagos (
	IdPago int primary key identity(1,1),
	IdEmpleado int not null,
	Fecha date not null default getdate(),
	Deducciones decimal(18, 2) not null,
	Monto decimal(18, 2) not null,
	Detalle varchar(100) not null,

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
('Sucursal Central', 'Liberia, Guardia', '1234-5678', '2026-04-13'),
('Sucursal Alajuela', 'Alajuela, Alajuela', '8765-4321', '2026-04-13'),
('Sucursal San José', 'San José, San José', '5555-5555', '2026-04-13');
go

insert into Usuarios (IdSucursal, Nombre, Apellidos, Identificacion, IdRol, Correo, Contrasenna, Activo) values
(1, 'Jose', 'Cruz', '123', 1, 'josecruz23@ulatina.co.cr', '123', 1),
(1, 'Oscar', 'Gonzalez', '208600681', 2, 'oscar@ulatina.co.cr', '123', 1),
(1, 'Maria', 'Lopez', '208600682', 3, 'maria@ulatina.co.cr', '123', 1)
go


insert into Puestos (Nombre, SalarioBase) values
('Cajero', 419755.80),
('Salonero', 373092.42),
('Cocinero', 491884.55);
go

select
	a.IdPuesto,
	a.Nombre AS NombrePuesto,
	a.SalarioBase,
	b.PorcentajeEmpleado,
	b.MontoEmpleado,
	b.PorcentajeEmpresa,
	b.MontoEmpresa
	from Puestos a
	join Seguros b on a.IdPuesto = b.IdPuesto
go

insert into Seguros (IdPuesto, PorcentajeEmpleado, MontoEmpleado,PorcentajeEmpresa, MontoEmpresa) values
(1, 9.5, 419755.80*(9.5/100), 26.5, 419755.80*(26.5/100)),
(2, 9.5, 373092.42 *(9.5/100), 26.5, 373092.42*(26.5/100)),
(3, 9.5, 491884.55 *(9.5/100), 26.5, 491884.55*(26.5/100));
go

--Logica para Insertar Empleados
insert into Empleados (IdSucursal, Identificacion, Nombre, Apellidos, Telefono, Correo, Contrasenna, FechaNacimiento, IdPuesto, ValorHora, Bonificacion, PagaSeguro, Estado) values
(1, '208600681', 'Gary', 'Perez', '1234-5678', 'gary@lkjasd.com', '123', '2003-04-12', 1,419755.80/240, 0, 1, 'Activo'),
(1, '208600682', 'Ana', 'Gomez', '8765-4321', 'ana@lkjas.com', '123', '1990-08-20', 2, 373092.42/240, 50000, 1,  'Activo'),
(3, '208600683', 'Luis', 'Martinez', '5555-5555', 'luis@asds.com', '123', '2001-01-03', 3, 491884.55/240, 14000, 1,  'Activo')
go

create procedure SP_InsertarEmpleado(
	@IdSucursal int,
	@Identificacion varchar(50),
	@Nombre varchar(50),
	@Apellidos varchar(50),
	@Telefono varchar(20),
	@Correo varchar(100),
	@Contrasenna varchar(255),
	@FechaNacimiento date,
	@IdPuesto int,
	@Bonificacion decimal(18, 2),
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
	declare @ValorHora decimal(18, 2);
	select @ValorHora = SalarioBase / 240 from Puestos where IdPuesto = @IdPuesto;
		insert into Empleados (IdSucursal, Identificacion, Nombre, Apellidos, Telefono, Correo, Contrasenna, FechaNacimiento, IdPuesto, ValorHora, Bonificacion, PagaSeguro, Estado)
		values (@IdSucursal, @Identificacion, @Nombre, @Apellidos, @Telefono, @Correo, @Contrasenna, @FechaNacimiento, @IdPuesto, @ValorHora, @Bonificacion, @PagaSeguro, @Estado)
		set @Resultado = 1;
	end
end
go

create procedure SP_EliminarEmpleado(
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
	else
	begin
		delete from Empleados where IdEmpleado = @IdEmpleado
		set @Resultado = 1;
	end
end
go



create procedure SP_InsertarAdelanto(
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
			declare @SalarioBaseEmpleado decimal(18, 2);

			select @TotalPrevio = isnull(sum(Monto), 0)
			from Adelantos
			where IdEmpleado = @IdEmpleado;

			select @SalarioBaseEmpleado = SalarioBase
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
		if(@TotalPrevio + @Monto > @SalarioBaseEmpleado)
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

insert into Adelantos (IdEmpleado, Monto, Detalle) values
(1, 100000, 'Adelanto para gastos personales'),
(2, 50000, 'Adelanto para compra de uniformes'),
(3, 200000, 'Adelanto para emergencia familiar')
go

insert into Prestamos (IdEmpleado, Monto, Cuotas, CuotasRestantes, MontoAPagarPorCuota, MontoRestante, Detalle) values
(1, 300000, 3, 3, 100000, 300000, 'Préstamo para compra de electrodomésticos'),
(2, 150000, 5, 5, 30000, 150000, 'Préstamo para reparación de vehículo'),
(3, 500000, 10, 10, 50000, 500000, 'Préstamo para gastos médicos')

-- Vista para mostrar los adelantos con el nombre del empleado
select
    a.IdAdelanto,
	e.IdEmpleado,
    e.Nombre + ' ' + e.Apellidos as Nombre,
    a.Monto,
    a.Fecha,
    a.Detalle
from dbo.Adelantos a
INNER JOIN dbo.Empleados e ON a.IdEmpleado = e.IdEmpleado
order by a.IdAdelanto desc
go

-- Procedimiento almacenado para insertar un préstamo
create procedure SP_InsertarPrestamo(
	@IdEmpleado int,
	@Monto decimal(18, 2),
	@Cuotas int,
	@Detalle varchar(100),
	@Mensaje varchar(500) output,
	@Resultado bit output
)
as
begin
	begin try
		if exists (select 1 from Prestamos where IdEmpleado = @IdEmpleado and CuotasRestantes > 0)
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
		if(@Cuotas <= 0)
		begin
			set @Mensaje = 'El número de cuotas debe ser mayor a cero'
			set @Resultado = 0;
			return;
		end

		declare @CuotasRestantes int;
		declare @MontoAPagarPorCuota decimal(18, 2);
		declare @MontoRestante decimal(18, 2);

		set @CuotasRestantes = @Cuotas;
		set @MontoAPagarPorCuota = @Monto / @Cuotas;
		set @MontoRestante = @Monto;
		insert into Prestamos (IdEmpleado, Monto, Cuotas, CuotasRestantes, MontoAPagarPorCuota, MontoRestante, Detalle)
		values (@IdEmpleado, @Monto, @Cuotas, @CuotasRestantes, @MontoAPagarPorCuota, @MontoRestante, @Detalle)
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
create procedure SP_EditarPrestamo(
	@IdPrestamo int,
	@Monto  decimal(18, 2),
	@Cuotas int,
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
		if(@Cuotas <= 0)
		begin
			set @Mensaje = 'El número de cuotas debe ser mayor a cero'
			set @Resultado = 0;
			return;
		end
		declare @CambioEnMonto decimal(18, 2);
		select @CambioEnMonto = Monto - @Monto from Prestamos where IdPrestamo = @IdPrestamo;
		update Prestamos
		set Monto = @Monto,
			Cuotas = @Cuotas,
			CuotasRestantes = @Cuotas,
			MontoAPagarPorCuota = @Monto / @Cuotas,
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
create procedure SP_EliminarPrestamo(
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


-- Vista para mostrar los préstamos con el nombre del empleado
select
	a.IdPrestamo,
	e.IdEmpleado,
	e.Nombre + ' ' + e.Apellidos + ' ' + e.Identificacion AS NombreEmpleado,
	a.Monto,
	a.MontoRestante,
	a.CuotasRestantes,
	a.MontoAPagarPorCuota,
	a.MontoPagado,
	a.FechaInicio,
	a.Detalle
	from Prestamos a
inner join Empleados e on a.IdEmpleado = e.IdEmpleado
order by a.IdPrestamo desc
go


--Procedimiento almacenado para registrar entrada y salida de empleados
create PROCEDURE SP_RegistrarEntradaSalida(
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
			wehre IdEmpleado = @IdEmpleado 
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
create procedure SP_VerDeduccionesEmpleado(
	@IdEmpleado int
)
as
begin
	declare @TotalAdelantos decimal(18,2) = 0
	declare @TotalPrestamos decimal(18,2) = 0
	declare @Seguro decimal(18,2) = 0
	declare @HorasTrabajadas decimal(18,2) = 0
	declare @HorasExtra decimal(18,2) = 0
	declare @SalarioBase decimal(18,2) = 0
	declare @Salario decimal(18,2) = 0
	
	-- Obtener salario base del empleado
	select @SalarioBase = SalarioBase
	from Empleados e
	join Puestos p on e.IdPuesto = p.IdPuesto
	where e.IdEmpleado = @IdEmpleado
	-- Calcular adelantos
	select @TotalAdelantos = ISNULL(SUM(Monto), 0) 
	from Adelantos 
	where IdEmpleado = @IdEmpleado
	
	-- Calcular préstamos
	select @TotalPrestamos = ISNULL(SUM(MontoAPagarPorCuota), 0) 
	from Prestamos 
	where IdEmpleado = @IdEmpleado
	
	-- Calcular seguro
	select @Seguro = case when e.PagaSeguro = 1 then ISNULL(s.MontoEmpleado, 0) else 0 end
	from Empleados e
	LEFT JOIN Seguros s on e.IdPuesto = s.IdPuesto
	where e.IdEmpleado = @IdEmpleado

	--Calcular Horas
	select @HorasTrabajadas = ISNULL(SUM(HorasTrabajadas), 0)
	from RegistroHoras
	where IdEmpleado = @IdEmpleado and Fecha = cast(getdate() as date)

	--Calcular Horas Extra
	if(@HorasTrabajadas > 8)
	begin
		set @HorasTrabajadas = @HorasTrabajadas + ((@HorasTrabajadas - 8) * 0.5)
	end

	--Calcular Salario
	set @Salario = @SalarioBase - @TotalAdelantos - @TotalPrestamos - @Seguro

	
	-- Retornar resultados
	select 
		e.IdEmpleado,
		e.Nombre + ' ' + e.Apellidos as NombreEmpleado,
		@SalarioBase as SalarioBase,
		@TotalAdelantos as TotalAdelantos,
		@TotalPrestamos as Rebajo_de_Prestamo,
		@Seguro as Seguro,
		@HorasTrabajadas as HorasTrabajadas,
		@HorasExtra as HorasExtra,
		@Salario as SalarioFinal
	from Empleados e
	where e.IdEmpleado = @IdEmpleado
end
go


create procedure SP_PagarSalario(
	@IdEmpleado int,
	@Mensaje varchar(500) output,
	@Resultado bit output
)
as
begin
	begin try
		declare @SalarioBase decimal(18, 2);
		declare @TotalAdelantos decimal(18, 2);
		declare @RebajoPrestamo decimal(18, 2);
		declare @Seguro decimal(18, 2);
		declare @SalarioFinal decimal(18, 2);


		select @SalarioBase = SalarioBase
		from Empleados e
		join Puestos p on e.IdPuesto = p.IdPuesto
		where e.IdEmpleado = @IdEmpleado;

		delete from Adelantos where IdEmpleado = @IdEmpleado;


		update Prestamos set CuotasRestantes = CuotasRestantes - 1,
							MontoRestante = MontoRestante - MontoAPagarPorCuota, 
							MontoPagado = MontoPagado + MontoAPagarPorCuota
		where IdEmpleado = @IdEmpleado and CuotasRestantes > 0;
		if(select CuotasRestantes from Prestamos where IdEmpleado = @IdEmpleado) = 0
		begin
			delete from Prestamos where IdEmpleado = @IdEmpleado and CuotasRestantes = 0;
		end


		set @Mensaje = 'Salario pagado exitosamente';
		set @Resultado = 1;
	end try
	begin catch
		set @Mensaje = 'Ocurrió un error al pagar el salario'
		set @Resultado = 0;
	end catch
end