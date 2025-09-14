Create database Proyecto_Farmacia1;
Use Proyecto_Farmacia1;


																						--Proveedores
CREATE TABLE Proveedores (
    IdProveedor INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Telefono NVARCHAR(20),
    Direccion NVARCHAR(200),
    Email NVARCHAR(100)
);


																						--Medicamentos
CREATE TABLE Medicamentos (
    IdMedicamento INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    NombreGenerico NVARCHAR(100),
    Categoria NVARCHAR(50),
    Estante NVARCHAR(50),
    PrecioVenta DECIMAL(10,2),
    PrecioProveedor DECIMAL(10,2),
    Stock INT,
    IdProveedor INT,
    FOREIGN KEY (IdProveedor) REFERENCES Proveedores(IdProveedor)
);




																						--Clientes
CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Telefono NVARCHAR(20),
    Email NVARCHAR(100),
    Direccion NVARCHAR(200)
);

																						--Empleados

CREATE TABLE Empleados (
    IdEmpleado INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Cargo NVARCHAR(50),
    Telefono NVARCHAR(20),
    Email NVARCHAR(100)
);

																						--Ventas

CREATE TABLE Ventas (
    IdVenta INT PRIMARY KEY IDENTITY,
    Fecha DATETIME DEFAULT GETDATE(),
    IdCliente INT,
    IdEmpleado INT,
    Total DECIMAL(10,2),
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
);


																						--Detalle venta
CREATE TABLE DetalleVenta (
    IdDetalle INT PRIMARY KEY IDENTITY,
    IdVenta INT,
    IdMedicamento INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10,2),
    FOREIGN KEY (IdVenta) REFERENCES Ventas(IdVenta),
    FOREIGN KEY (IdMedicamento) REFERENCES Medicamentos(IdMedicamento)
);

																						--Compras

CREATE TABLE Compras (
    IdCompra INT PRIMARY KEY IDENTITY,
    IdProveedor INT,
    FechaCompra DATE,
    IdMedicamento INT,
    CantidadComprada INT,
    PrecioUnidad DECIMAL(10,2),
    FOREIGN KEY (IdProveedor) REFERENCES Proveedores(IdProveedor),
    FOREIGN KEY (IdMedicamento) REFERENCES Medicamentos(IdMedicamento)
);


                                                                            --Restricciones

ALTER TABLE Medicamentos
ADD CONSTRAINT UQ_Medicamentos_Nombre UNIQUE (Nombre);


ALTER TABLE Medicamentos
ADD CONSTRAINT CH_Medicamentos_PrecioVenta CHECK (PrecioVenta > 0);


ALTER TABLE Medicamentos
ADD CONSTRAINT CH_Medicamentos_PrecioProveedor CHECK (PrecioProveedor > 0);


ALTER TABLE Medicamentos
ADD CONSTRAINT CH_Medicamentos_Stock CHECK (Stock >= 0);




																						--Procedimientos almacenados

CREATE PROCEDURE SP_insertar_datos_proveedor
	@Nombre VARCHAR(50),
	@Telefono CHAR(14),
	@Direccion VARCHAR(200),
	@Email VARCHAR(100)
	
AS
BEGIN
	INSERT INTO Proveedores VALUES (@Nombre, @Telefono,@Direccion, @Email );
END;

EXEC SP_insertar_datos_proveedor 'Farmacéutica del Caribe', '1-809-687-1234', 'Avenida Central #55, Santo Domingo', 'info@farmadelcaribe.com';
EXEC SP_insertar_datos_proveedor 'Distribuidora Médica Estrella', '1-829-588-9876', 'Calle Principal #10, Santiago', 'ventas@distribuidoraestrella.do';
EXEC SP_insertar_datos_proveedor 'Suplidora Farmacéutica Global', '1-849-285-5555', 'Autopista Duarte Km 12, La Vega', 'servicioalcliente@sfglobal.net';
EXEC SP_insertar_datos_proveedor 'Importadora de Medicamentos Unidos', '1-809-221-4444', 'Avenida Winston Churchill #100, Torre Empresarial, Piso 8', 'importmed@imu.com.do';
EXEC SP_insertar_datos_proveedor 'Laboratorios FarmaSalud', '1-829-777-3322', 'Zona Industrial, Calle #3, San Cristóbal', 'contacto@farmasalud.com';
EXEC SP_insertar_datos_proveedor 'Comercializadora de Productos Médicos', '1-849-999-1100', 'Avenida 27 de Febrero #345, Plaza Comercial', 'comercialmed@cpm.do';
EXEC SP_insertar_datos_proveedor 'Droguería Nacional', '1-809-532-8899', 'Calle Independencia #78, Baní', 'pedidos@droguerianacional.com.do';
EXEC SP_insertar_datos_proveedor 'Proveedor Integral de Salud', '1-829-472-6543', 'Carretera Mella Km 9.5, Santo Domingo Este', 'info@proinsalud.net';
EXEC SP_insertar_datos_proveedor 'Suministros Médicos del Este', '1-849-637-2211', 'Avenida San Vicente de Paúl #21, Los Mina', 'sumedeste@sme.do';
EXEC SP_insertar_datos_proveedor 'Corporación Farmacéutica Dominicana', '1-809-567-0011', 'Avenida Abraham Lincoln #456, Edificio Profesional', 'corpofarma@cfd.com.do';
EXEC SP_insertar_datos_proveedor 'Alliance Healthcare Dominicana', '1-829-876-5432', 'Calle Proyecto #12, Arroyo Hondo', 'alliance.do@ahc.net';
EXEC SP_insertar_datos_proveedor 'McKesson Medical Supplies RD', '1-849-357-9876', 'Zona Franca Industrial, La Romana', 'mckessonrd@mms.com';
EXEC SP_insertar_datos_proveedor 'Cardinal Health Dominicana', '1-809-741-2233', 'Avenida Charles de Gaulle #50, Villa Mella', 'cardinal.do@ch.org';
EXEC SP_insertar_datos_proveedor 'AmerisourceBergen Caribe', '1-829-695-4455', 'Calle Bohechio #77, Ensanche Bella Vista', 'abc.caribe@abc.com';
EXEC SP_insertar_datos_proveedor 'Medline Industries SRL', '1-849-488-6677', 'Parque Industrial ITABO, Haina', 'medline.srl@medline.net';
EXEC SP_insertar_datos_proveedor 'BSN Medical Dominicana', '1-809-245-8899', 'Avenida Máximo Gómez #321, Centro de la Ciudad', 'bsn.do@bsnmedical.com';
EXEC SP_insertar_datos_proveedor 'Johnson & Johnson Caribe', '1-829-935-1122', 'Edificio Metropolitano, Suite 402', 'jnj.caribe@jnj.com';
EXEC SP_insertar_datos_proveedor 'Procter & Gamble Dominicana', '1-849-518-3344', 'Avenida Núñez de Cáceres #150, Plaza Galería', 'pg.do@pg.com';
EXEC SP_insertar_datos_proveedor 'Unilever Caribe', '1-809-620-5566', 'Autopista 30 de Mayo #88, Mirador Sur', 'unilever.caribe@unilever.com';
EXEC SP_insertar_datos_proveedor 'Colgate-Palmolive Dominicana', '1-829-750-7788', 'Calle Barahona #99, Gazcue', 'colgate.do@colpal.com';

----------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_insertar_datos_medicamento
    @Nombre NVARCHAR(100),
    @NombreGenerico NVARCHAR(100),
    @Categoria NVARCHAR(50),
    @Estante NVARCHAR(50),
    @PrecioVenta DECIMAL(10,2),
    @PrecioProveedor DECIMAL(10,2),
    @Stock INT,
    @IdProveedor INT
AS
BEGIN
    INSERT INTO Medicamentos (
        Nombre, NombreGenerico, Categoria, Estante,
        PrecioVenta, PrecioProveedor,Stock, IdProveedor
		)
    VALUES (
        @Nombre, @NombreGenerico, @Categoria, @Estante,
        @PrecioVenta, @PrecioProveedor,@Stock,@IdProveedor
    );
END;



EXEC SP_insertar_datos_medicamento 'Paracetamol 500mg', 'Acetaminofén', 'Analgésico', 'Estante B1', 5.50, 2.75, 'paracetamol.jpg', 250, 3;
EXEC SP_insertar_datos_medicamento 'Amoxicilina 250mg', 'Amoxicilina Trihidrato', 'Antibiótico', 'Estante C3', 12.00, 6.00, 'amoxicilina.jpg', 180, 7;
EXEC SP_insertar_datos_medicamento 'Ibuprofeno 200mg', 'Ibuprofeno', 'Antiinflamatorio', 'Estante B2', 7.25, 3.60, 'ibuprofeno.jpg', 300, 15;
EXEC SP_insertar_datos_medicamento 'Aspirina 100mg', 'Ácido Acetilsalicílico', 'Analgésico', 'Estante A1', 3.00, 1.50, 'aspirina.jpg', 400, 1;
EXEC SP_insertar_datos_medicamento 'Omeprazol 20mg', 'Omeprazol', 'Protector Gástrico', 'Estante D1', 15.50, 7.75, 'omeprazol.jpg', 120, 11;
EXEC SP_insertar_datos_medicamento 'Loratadina 10mg', 'Loratadina', 'Antihistamínico', 'Estante A2', 9.00, 4.50, 'loratadina.jpg', 200, 5;
EXEC SP_insertar_datos_medicamento 'Salbutamol Inhalador', 'Salbutamol', 'Broncodilatador', 'Estante E2', 25.00, 12.50, 'salbutamol.jpg', 80, 18;
EXEC SP_insertar_datos_medicamento 'Vitamin C 1000mg', 'Ácido Ascórbico', 'Suplemento Vitamínico', 'Estante F1', 11.75, 5.90, 'vitamina_c.jpg', 150, 9;
EXEC SP_insertar_datos_medicamento 'Complejo B Forte', 'Tiamina, Riboflavina, Niacina...', 'Suplemento Vitamínico', 'Estante F2', 18.00, 9.00, 'complejo_b.jpg', 100, 13;
EXEC SP_insertar_datos_medicamento 'Naproxeno 500mg', 'Naproxeno Sódico', 'Antiinflamatorio', 'Estante B3', 14.25, 7.10, 'naproxeno.jpg', 160, 19;
EXEC SP_insertar_datos_medicamento 'Cetirizina 10mg', 'Cetirizina Diclorhidrato', 'Antihistamínico', 'Estante A3', 10.50, 5.25, 'cetirizina.jpg', 220, 2;
EXEC SP_insertar_datos_medicamento 'Metformina 500mg', 'Metformina Clorhidrato', 'Antidiabético', 'Estante C4', 22.00, 11.00, 'metformina.jpg', 90, 16;
EXEC SP_insertar_datos_medicamento 'Atorvastatina 20mg', 'Atorvastatina Cálcica', 'Hipolipemiante', 'Estante D2', 35.00, 17.50, 'atorvastatina.jpg', 70, 8;
EXEC SP_insertar_datos_medicamento 'Clotrimazol Crema', 'Clotrimazol', 'Antifúngico', 'Estante E3', 16.75, 8.40, 'clotrimazol.jpg', 130, 14;
EXEC SP_insertar_datos_medicamento 'Ambroxol Jarabe', 'Ambroxol Clorhidrato', 'Mucolítico', 'Estante C5', 12.50, 6.25, 'ambroxol.jpg', 190, 6;
EXEC SP_insertar_datos_medicamento 'Ácido Fólico 400mcg', 'Ácido Pteroilmonoglutámico', 'Suplemento Vitamínico', 'Estante F3', 8.00, 4.00, 'acido_folico.jpg', 280, 10;
EXEC SP_insertar_datos_medicamento 'Diclofenaco Sódico 75mg', 'Diclofenaco Sódico', 'Antiinflamatorio', 'Estante B4', 11.00, 5.50, 'diclofenaco.jpg', 170, 17;
EXEC SP_insertar_datos_medicamento 'Montelukast 10mg', 'Montelukast Sódico', 'Antiasmático', 'Estante E4', 28.50, 14.25, 'montelukast.jpg', 110, 4;
EXEC SP_insertar_datos_medicamento 'Ranitidina 150mg', 'Ranitidina Clorhidrato', 'Antiulceroso', 'Estante D3', 19.25, 9.60, 'ranitidina.jpg', 140, 12;
EXEC SP_insertar_datos_medicamento 'Multivitamínico Adulto', 'Vitaminas y Minerales', 'Suplemento Vitamínico', 'Estante F4', 21.00, 10.50, 'multivitaminico.jpg', 95, 20;



----------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SP_insertar_datos_compra
    @IdProveedor INT,
    @FechaCompra DATE,
    @IdMedicamento INT,
    @CantidadComprada INT,
    @PrecioUnidad DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Compras (IdProveedor, FechaCompra, IdMedicamento, CantidadComprada, PrecioUnidad)
    VALUES (@IdProveedor, @FechaCompra, @IdMedicamento, @CantidadComprada, @PrecioUnidad);
END;

EXEC SP_insertar_datos_compra 1, '2025-05-16', 20, 179, 33.72;
EXEC SP_insertar_datos_compra 15, '2025-05-09', 5, 90, 23.76;
EXEC SP_insertar_datos_compra 9, '2025-05-11', 14, 147, 19.0;
EXEC SP_insertar_datos_compra 19, '2025-05-05', 8, 77, 52.0;
EXEC SP_insertar_datos_compra 4, '2025-05-04', 6, 57, 27.16;
EXEC SP_insertar_datos_compra 13, '2025-05-08', 11, 52, 24.81;
EXEC SP_insertar_datos_compra 20, '2025-05-03', 6, 22, 96.0;
EXEC SP_insertar_datos_compra 11, '2025-05-01', 18, 143, 32.04;
EXEC SP_insertar_datos_compra 9, '2025-05-08', 11, 103, 12.32;
EXEC SP_insertar_datos_compra 8, '2025-05-03', 13, 61, 53.53;
EXEC SP_insertar_datos_compra 17, '2025-05-11', 8, 189, 47.13;
EXEC SP_insertar_datos_compra 10, '2025-05-07', 10, 157, 85.14;
EXEC SP_insertar_datos_compra 15, '2025-05-19', 6, 157, 71.52;
EXEC SP_insertar_datos_compra 2, '2025-05-05', 4, 185, 39.71;
EXEC SP_insertar_datos_compra 10, '2025-05-06', 18, 74, 18.09;
EXEC SP_insertar_datos_compra 16, '2025-05-17', 10, 156, 83.71;
EXEC SP_insertar_datos_compra 15, '2025-05-11', 18, 67, 43.76;
EXEC SP_insertar_datos_compra 13, '2025-05-08', 13, 159, 62.07;
EXEC SP_insertar_datos_compra 14, '2025-05-20', 13, 194, 77.41;
EXEC SP_insertar_datos_compra 15, '2025-05-14', 5, 147, 62.77;

----------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SP_insertar_datos_cliente
    @Nombre NVARCHAR(100),
    @Telefono NVARCHAR(20),
    @Email NVARCHAR(100),
    @Direccion NVARCHAR(200)
AS
BEGIN
    INSERT INTO Clientes (Nombre, Telefono, Email, Direccion)
    VALUES (@Nombre, @Telefono, @Email, @Direccion);
END;

EXEC SP_insertar_datos_cliente 'Ana Pérez', '1-809-555-2211', 'ana.perez@dominio.net', 'Avenida Principal #123, Sector Central';
EXEC SP_insertar_datos_cliente 'Carlos López', '1-829-987-6543', 'carlos.lopez@otrodominio.com', 'Calle Secundaria #45, Barrio Alto';
EXEC SP_insertar_datos_cliente 'María Rodríguez', '1-849-222-3344', 'maria_r@mailrapido.do', 'Residencial Las Flores, Edificio A, Apartamento 1B';
EXEC SP_insertar_datos_cliente 'Pedro Sánchez', '1-809-777-8899', 'p.sanchez@servidor.com.do', 'Carretera Mella, Km 8.5, Local 3';
EXEC SP_insertar_datos_cliente 'Laura Gómez', '1-829-333-4455', 'laurag@miemail.net', 'Callejon sin salida #7, Zona Tranquila';
EXEC SP_insertar_datos_cliente 'Javier Vargas', '1-849-555-6677', 'javierv@emailpro.org', 'Avenida Independencia #567, Plaza Comercial, Local 20';
EXEC SP_insertar_datos_cliente 'Sofía Díaz', '1-809-111-2233', 'sofia.d@dominio.com', 'Calle El Sol #10, Urbanización Moderna';
EXEC SP_insertar_datos_cliente 'Manuel Torres', '1-829-888-9900', 'manuelt@otrocorreo.do', 'Avenida Duarte #321, Esquina con Calle 27 de Febrero';
EXEC SP_insertar_datos_cliente 'Carmen Ruiz', '1-849-444-5566', 'carmenr@mail.com', 'Calle Los Pinos #15, Sector Jardines';
EXEC SP_insertar_datos_cliente 'Ricardo Castro', '1-809-666-7788', 'ricardo.c@servidor.net', 'Autopista Las Américas, Salida #9';
EXEC SP_insertar_datos_cliente 'Elena Núñez', '1-829-222-9911', 'elena.n@miemail.com.do', 'Calle La Luna #22, Residencial Nuevo Amanecer';
EXEC SP_insertar_datos_cliente 'Gabriel Soto', '1-849-777-3355', 'gabriels@emailrapido.net', 'Avenida Pasteur #44, Edificio Caribe, Piso 5';
EXEC SP_insertar_datos_cliente 'Isabel Méndez', '1-809-333-6699', 'isabelm@dominio.org', 'Calle El Conde #101, Zona Colonial';
EXEC SP_insertar_datos_cliente 'Fernando Rojas', '1-829-555-1122', 'fernandor@otrodominio.net', 'Avenida Luperón #789, Plaza del Mar, Local 112';
EXEC SP_insertar_datos_cliente 'Patricia Flores', '1-849-111-8833', 'patriciaf@mailpro.com', 'Calle Primavera #30, Urbanización Tranquila II';
EXEC SP_insertar_datos_cliente 'Daniel Jiménez', '1-809-999-4466', 'danielj@servidor.do', 'Carretera Sánchez, Km 12, Entrada Principal';
EXEC SP_insertar_datos_cliente 'Rosa Vargas', '1-829-444-7700', 'rosav@miemail.org', 'Calle Las Rosas #5, Sector Bella Vista';
EXEC SP_insertar_datos_cliente 'Andrés Díaz', '1-849-888-2244', 'andresd@email.net', 'Avenida Winston Churchill #654, Torre Empresarial, Oficina 3A';
EXEC SP_insertar_datos_cliente 'Silvia Torres', '1-809-222-5588', 'silviat@dominio.net.do', 'Calle Los Almendros #18, Residencial Paraíso';
EXEC SP_insertar_datos_cliente 'Héctor Ruiz', '1-829-777-9922', 'hectorr@otrocorreo.com', 'Avenida John F. Kennedy #987, Plaza Central, Nivel 2';

-----------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SP_insertar_datos_empleado
    @Nombre NVARCHAR(100),
    @Cargo NVARCHAR(50),
    @Telefono NVARCHAR(20),
    @Email NVARCHAR(100)
AS
BEGIN
    INSERT INTO Empleados (Nombre, Cargo, Telefono, Email)
    VALUES (@Nombre, @Cargo, @Telefono, @Email);
END;

EXEC SP_insertar_datos_empleado 'Juan Pérez', 'Farmacéutico', '1-809-333-1001', 'juanperez@email.com';
EXEC SP_insertar_datos_empleado 'María López', 'Cajera', '1-809-333-1002', 'marialopez@email.com';
EXEC SP_insertar_datos_empleado 'Carlos Gómez', 'Administrador', '1-809-333-1003', 'carlosgomez@email.com';
EXEC SP_insertar_datos_empleado 'Ana Rodríguez', 'Farmacéutica', '1-809-333-1004', 'anarodriguez@email.com';
EXEC SP_insertar_datos_empleado 'Luis Fernández', 'Repartidor', '1-809-333-1005', 'luisfernandez@email.com';
EXEC SP_insertar_datos_empleado 'Sofía Ramírez', 'Cajera', '1-809-333-1006', 'sofiaramirez@email.com';
EXEC SP_insertar_datos_empleado 'José Morales', 'Almacén', '1-809-333-1007', 'josemorales@email.com';
EXEC SP_insertar_datos_empleado 'Laura Peña', 'Supervisora', '1-809-333-1008', 'laurapena@email.com';
EXEC SP_insertar_datos_empleado 'Pedro Jiménez', 'Farmacéutico', '1-809-333-1009', 'pedrojimenez@email.com';
EXEC SP_insertar_datos_empleado 'Carmen Torres', 'Recepcionista', '1-809-333-1010', 'carmentorres@email.com';
EXEC SP_insertar_datos_empleado 'Miguel Herrera', 'Seguridad', '1-809-333-1011', 'miguelherrera@email.com';
EXEC SP_insertar_datos_empleado 'Lucía Vargas', 'Encargada de inventario', '1-809-333-1012', 'luciavargas@email.com';
EXEC SP_insertar_datos_empleado 'Daniel Soto', 'Farmacéutico', '1-809-333-1013', 'danielsoto@email.com';
EXEC SP_insertar_datos_empleado 'Paola Castro', 'Cajera', '1-809-333-1014', 'paolacastro@email.com';
EXEC SP_insertar_datos_empleado 'Ricardo Díaz', 'Contador', '1-809-333-1015', 'ricardodiaz@email.com';
EXEC SP_insertar_datos_empleado 'Mónica Gil', 'Asistente', '1-809-333-1016', 'monicagil@email.com';
EXEC SP_insertar_datos_empleado 'Francisco Núñez', 'Farmacéutico', '1-809-333-1017', 'francisconunez@email.com';
EXEC SP_insertar_datos_empleado 'Patricia Blanco', 'Supervisora', '1-809-333-1018', 'patriciablanco@email.com';
EXEC SP_insertar_datos_empleado 'Ángel Ruiz', 'Almacén', '1-809-333-1019', 'angelruiz@email.com';
EXEC SP_insertar_datos_empleado 'Verónica Medina', 'Recepcionista', '1-809-333-1020', 'veronicamedina@email.com';

-----------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SP_insertar_datos_venta
    @Fecha DATETIME,
    @IdCliente INT,
    @IdEmpleado INT,
    @Total DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Ventas (Fecha, IdCliente, IdEmpleado, Total)
    VALUES (@Fecha, @IdCliente, @IdEmpleado, @Total);
END;

EXEC SP_insertar_datos_venta '2025-05-01 09:15:00', 5, 1, 235.75;
EXEC SP_insertar_datos_venta '2025-05-01 14:30:00', 12, 3, 580.20;
EXEC SP_insertar_datos_venta '2025-05-02 11:00:00', 2, 2, 112.50;
EXEC SP_insertar_datos_venta '2025-05-02 16:45:00', 18, 4, 765.90;
EXEC SP_insertar_datos_venta '2025-05-03 10:30:00', 9, 5, 340.15;
EXEC SP_insertar_datos_venta '2025-05-03 15:00:00', 15, 2, 910.40;
EXEC SP_insertar_datos_venta '2025-05-04 12:15:00', 3, 1, 188.60;
EXEC SP_insertar_datos_venta '2025-05-04 17:30:00', 20, 3, 455.30;
EXEC SP_insertar_datos_venta '2025-05-05 09:45:00', 7, 4, 620.85;
EXEC SP_insertar_datos_venta '2025-05-05 15:45:00', 11, 5, 295.00;
EXEC SP_insertar_datos_venta '2025-05-06 11:30:00', 16, 1, 842.70;
EXEC SP_insertar_datos_venta '2025-05-06 17:00:00', 4, 2, 315.55;
EXEC SP_insertar_datos_venta '2025-05-07 10:00:00', 19, 3, 518.90;
EXEC SP_insertar_datos_venta '2025-05-07 16:15:00', 8, 4, 790.25;
EXEC SP_insertar_datos_venta '2025-05-08 12:45:00', 14, 5, 260.40;
EXEC SP_insertar_datos_venta '2025-05-08 18:00:00', 1, 1, 955.10;
EXEC SP_insertar_datos_venta '2025-05-09 09:30:00', 10, 2, 412.85;
EXEC SP_insertar_datos_venta '2025-05-09 15:15:00', 17, 3, 680.50;
EXEC SP_insertar_datos_venta '2025-05-10 11:45:00', 6, 4, 375.95;
EXEC SP_insertar_datos_venta '2025-05-10 17:45:00', 13, 5, 815.20;

-----------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SP_insertar_datos_detalleventa
    @IdVenta INT,
    @IdMedicamento INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10,2)
AS
BEGIN
    INSERT INTO DetalleVenta (IdVenta, IdMedicamento, Cantidad, PrecioUnitario)
    VALUES (@IdVenta, @IdMedicamento, @Cantidad, @PrecioUnitario);
END;

EXEC SP_insertar_datos_detalleventa 1, 1, 3, 150.00;
EXEC SP_insertar_datos_detalleventa 2, 2, 2, 200.00;
EXEC SP_insertar_datos_detalleventa 3, 3, 1, 300.00;
EXEC SP_insertar_datos_detalleventa 4, 4, 5, 500.00;
EXEC SP_insertar_datos_detalleventa 5, 5, 1, 100.00;
EXEC SP_insertar_datos_detalleventa 6, 6, 4, 400.00;
EXEC SP_insertar_datos_detalleventa 7, 7, 2, 220.00;
EXEC SP_insertar_datos_detalleventa 8, 8, 3, 330.00;
EXEC SP_insertar_datos_detalleventa 9, 9, 1, 110.00;
EXEC SP_insertar_datos_detalleventa 10, 10, 2, 210.00;
EXEC SP_insertar_datos_detalleventa 11, 11, 3, 310.00;
EXEC SP_insertar_datos_detalleventa 12, 12, 4, 420.00;
EXEC SP_insertar_datos_detalleventa 13, 13, 1, 115.00;
EXEC SP_insertar_datos_detalleventa 14, 14, 2, 225.00;
EXEC SP_insertar_datos_detalleventa 15, 15, 3, 335.00;
EXEC SP_insertar_datos_detalleventa 16, 16, 1, 120.00;
EXEC SP_insertar_datos_detalleventa 17, 17, 2, 230.00;
EXEC SP_insertar_datos_detalleventa 18, 18, 3, 340.00;
EXEC SP_insertar_datos_detalleventa 19, 19, 1, 125.00;
EXEC SP_insertar_datos_detalleventa 20, 20, 2, 240.00;

--------------------------------------------------------------------------consultar
select * from Proveedores
select * from Medicamentos
select * from Clientes
select * from Compras
select * from Ventas
select * from DetalleVenta


-------------------------------------------------------------------------Triggers
CREATE TRIGGER TR_ActualizarStockVenta
ON DetalleVenta
AFTER INSERT
AS
BEGIN
    -- Evitar que el trigger se ejecute si no hay filas insertadas
    IF @@ROWCOUNT = 0
        RETURN;

    -- Actualizar el stock en la tabla Medicamentos por cada artículo vendido
    UPDATE m
    SET m.Stock = m.Stock - i.Cantidad
    FROM Medicamentos m
    INNER JOIN inserted i ON m.IdMedicamento = i.IdMedicamento;
	
END;
------------------------------------------------------------------------------------
CREATE TRIGGER TR_ActualizarStockCompra
ON Compras
AFTER INSERT
AS
BEGIN
    -- Evitar que el trigger se ejecute si no hay filas insertadas
    IF @@ROWCOUNT = 0
        RETURN;

    -- Actualizar el stock en la tabla Medicamentos por cada artículo comprado
    UPDATE m
    SET m.Stock = m.Stock + i.CantidadComprada
    FROM Medicamentos m
    INNER JOIN inserted i ON m.IdMedicamento = i.IdMedicamento;
END;
-----------------------------------------------------------------------------------------
CREATE TRIGGER TR_CalcularTotalVenta
ON Ventas
After INSERT
AS
BEGIN
    -- Evitar que el trigger se ejecute si el total ya está definido (podría haber lógica para permitir ingresos manuales en ciertos casos)
    IF (SELECT Total FROM inserted) IS NOT NULL
        RETURN;

    -- Calcular el total de la venta basado en los detalles de venta
    UPDATE Ventas
    SET Total = (SELECT SUM(dv.Cantidad * dv.PrecioUnitario)
                 FROM DetalleVenta dv
                 WHERE dv.IdVenta = (SELECT IdVenta FROM inserted))
    WHERE IdVenta = (SELECT IdVenta FROM inserted);
END;
--------------------------------------------------------------------------------------------
-- Historial de Ventas
CREATE TABLE HistorialVenta (
    IdHistorialVenta INT PRIMARY KEY IDENTITY,
    IdVenta INT,
    IdEmpleado INT,
    FechaVenta DATETIME,
    NombreMedicamento NVARCHAR(100),
    CantidadVendida INT,
    IdMedicamento INT, -- Agregar la columna IdMedicamento
    FOREIGN KEY (IdVenta) REFERENCES Ventas(IdVenta),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado),
    FOREIGN KEY (IdMedicamento) REFERENCES Medicamentos(IdMedicamento)
);

-- Paso 2: Crear el trigger de nuevo con las nuevas columnas
CREATE TRIGGER TR_InsertarHistorialVenta
ON DetalleVenta
AFTER INSERT
AS
BEGIN
    
    INSERT INTO HistorialVenta (
        IdVenta,
        IdEmpleado,
        FechaVenta,
        NombreMedicamento,
        CantidadVendida,
        IdMedicamento,
        PrecioUnitario, -- ¡Nueva columna!
        Total           -- ¡Nueva columna!
    )
    SELECT
        i.IdVenta,
        v.IdEmpleado,
        v.Fecha,
        m.Nombre,
        i.Cantidad,
        i.IdMedicamento,
        i.PrecioUnitario, -- Valor del PrecioUnitario del DetalleVenta
        v.Total           -- Valor del Total de la tabla Ventas
    FROM inserted i
    INNER JOIN Ventas v ON i.IdVenta = v.IdVenta
    INNER JOIN Medicamentos m ON i.IdMedicamento = m.IdMedicamento;
END;

select *  from HistorialVenta

-- Agregamos la columna PrecioUnitario para el costo del medicamento en esa línea
ALTER TABLE HistorialVenta
ADD PrecioUnitario DECIMAL(10, 2);

-- Agregamos la columna Total para el total general de la venta (se repetirá por cada línea de la misma venta)
ALTER TABLE HistorialVenta
ADD Total DECIMAL(10, 2);

 -- Tabla Compras (modificada para incluir IdEmpleado)
CREATE TABLE Compras (
    IdCompra INT PRIMARY KEY IDENTITY,
    IdProveedor INT,
    FechaCompra DATE,
    IdMedicamento INT,
    CantidadComprada INT,
    PrecioUnidad DECIMAL(10,2),
    IdEmpleado INT, -- Agregar la columna IdEmpleado
    FOREIGN KEY (IdProveedor) REFERENCES Proveedores(IdProveedor),
    FOREIGN KEY (IdMedicamento) REFERENCES Medicamentos(IdMedicamento),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado) -- Agregar la clave foránea a Empleados
);

select * from Compras


-- Tabla Historial de Compras
CREATE TABLE HistorialCompras (
    IdHistorialCompra INT PRIMARY KEY IDENTITY,
    IdCompra INT,
    IdProveedor INT,
    FechaCompra DATE,
    NombreMedicamento NVARCHAR(100),
    CantidadComprada INT,
    PrecioUnidad DECIMAL(10,2),
    IdEmpleado INT,
    FOREIGN KEY (IdCompra) REFERENCES Compras(IdCompra),
    FOREIGN KEY (IdProveedor) REFERENCES Proveedores(IdProveedor),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado) 
);



-- Trigger para registrar las compras en el historial
CREATE TRIGGER TR_InsertarHistorialCompra
ON Compras
AFTER INSERT
AS
BEGIN
    -- Insertar un registro en el HistorialCompras por cada compra realizada
    INSERT INTO HistorialCompras (IdCompra, IdProveedor, FechaCompra, NombreMedicamento, CantidadComprada, PrecioUnidad, IdEmpleado)
    SELECT
        i.IdCompra,
        i.IdProveedor,
        i.FechaCompra,
        m.Nombre,
        i.CantidadComprada,
        i.PrecioUnidad,
        i.IdEmpleado 
    FROM inserted i
    INNER JOIN Medicamentos m ON i.IdMedicamento = m.IdMedicamento;
END;

----------Historial usuarios
CREATE TABLE HistorialUsuarios (
    IdHistorialUsuario INT PRIMARY KEY IDENTITY,
    Nombre_Usuario NVARCHAR(50),
    Contraseña NVARCHAR(50),
    Rol NVARCHAR(50),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

INSERT INTO HistorialUsuarios (Nombre_Usuario, Contraseña, Rol)
VALUES ('Admin', 'Admin', 'Administrador');

INSERT INTO HistorialUsuarios (Nombre_Usuario, Contraseña, Rol)
VALUES ('Compra', 'Compra', 'Comprador');

INSERT INTO HistorialUsuarios (Nombre_Usuario, Contraseña, Rol)
VALUES ('Venta', 'Venta', 'Vendedor');

----------------------------------


