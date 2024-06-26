--esta base de datos esta creada mediante Azure con el motor de BD SQL Server
--el objetivo de crear la base de datos en la nube es para no cambiar el codigo dentro del proyecto
--Para asi tener un proyecto mas limpio
--nombre para conectar a la base de datod: josue
--Contrase�a: Biblioteca123$
--Si se modificaran elementos preguntar primeramente y luego utulizar las funciones alter Column, drop, etc. 
--Para no eliminar la base de datos

--se crea la base de datos e inserta datos de prueba
CREATE TABLE Usuarios --se crea la tabla usuarios donde se alojaran todos los usuarios
(
	CodigoUser INT IDENTITY NOT NULL PRIMARY KEY,
	UserName VARCHAR(40) NOT NULL,
	UserPassword VARCHAR(40) NOT NULL,
	UserRol VARCHAR(25) NOT NULL
)
INSERT INTO Usuarios VALUES ('josue72', 'josue0074', 'Administrador', 'San Salvador')--se crea el primer usuario para verificar la funcionalidad de esta

CREATE TABLE Editorial --se crea la tabla editorial donde se alojaran todas las editoriales
(
	CodigoEditorial INT IDENTITY NOT NULL PRIMARY KEY,
	NombreEditorial VARCHAR(50) NOT NULL,
	CorreoEditorial VARCHAR(50) NOT NULL,
	DireccionEditorial VARCHAR(255) NOT NULL,
	NumeroEditorial VARCHAR(9) NOT NULL,
)
INSERT INTO Editorial VALUES ('Santillana', 'correo@santillana.com', 'San Salvador', '2222-2222')--se crea la primera editorial para verificar la funcionalidad de esta

CREATE TABLE Categoria --se crea la tabla categoria donde se alojaran todas las categorias
(
	CodigoCategoria INT IDENTITY NOT NULL PRIMARY KEY,
	NombreCategoria VARCHAR(50) NOT NULL,
	DescripcionCategoria VARCHAR(255) NOT NULL,
)
INSERT INTO Categoria VALUES ('Realismo Magico', 'Es un genero literario que se caracteriza por la inclusion de elementos magicos o fantasticos en una narracion realista')--se crea la primera categoria para verificar la funcionalidad de esta

CREATE TABLE Autores --se crea la tabla autores donde se alojaran todos los autores
(
	CodigoAutor INT IDENTITY NOT NULL PRIMARY KEY,
	NombreAutor VARCHAR(50) NOT NULL,
	FechaNacAutor DATE NOT NULL,
	CodCategoria INT NOT NULL,--nombre de la llave foranea
	CONSTRAINT fk_idCategoria FOREIGN KEY (CodCategoria) REFERENCES Categoria(CodigoCategoria) ON UPDATE CASCADE ON DELETE CASCADE--referencia a la tabla categoria y se le agrega la propiedad de actualizar y eliminar en cascada
)
INSERT INTO Autores VALUES ('Gabriel Garcia Marquez', '06-03-1899', 1)--se crea el primer autor para verificar la funcionalidad de esta

CREATE TABLE Libros --se crea la tabla libros donde se alojaran todos los libros
(
	ISBN VARCHAR(20) NOT NULL PRIMARY KEY,
	NombreLibro VARCHAR(50) NOT NULL,
	Autor INT NOT NULL,--nombre de la llave foranea
	CONSTRAINT fk_idAutor FOREIGN KEY (Autor) REFERENCES Autores(CodigoAutor) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla autores y se le agrega la propiedad de actualizar y eliminar en cascada
	Editorial INT NOT NULL,--nombre de la llave foranea 
	CONSTRAINT fk_idEditorial FOREIGN KEY (Editorial) REFERENCES Editorial(CodigoEditorial) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla editorial y se le agrega la propiedad de actualizar y eliminar en cascada
	Categoria INT NOT NULL,--nombre de la llave foranea
	CONSTRAINT fk_idCategoria_L FOREIGN KEY (Categoria) REFERENCES Categoria(CodigoCategoria) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla categoria y se le agrega la propiedad de actualizar y eliminar en cascada
	StockLibro INT NOT NULL,
	PrecioLibro DECIMAL(5,2) NOT NULL,
	EstadoLibro VARCHAR(50) --sirve para saber si el libro se encuentra libre o prestado
)
--ISBN--Nombre del libro --Codigo del autor--Codigo de la editorial--Codigo de la categoria--Stock del libro--Precio del libro--Estado del libro
INSERT INTO Libros VALUES ('978-1-234567-89-0', 'Cien a�os de soledad', 1, 1, 1, 10, 15.00, 'Libre')--se crea el primer libro para verificar la funcionalidad de esta
INSERT INTO Libros VALUES ('978-1-234567-89-1', 'El coronel no tiene quien le escriba', 1, 1, 1, 10, 10.00, 'Libre')--se crea el segundo libro para verificar la funcionalidad de esta
INSERT INTO Libros VALUES ('978-1-234567-89-2', 'El amor en los tiempos del colera', 1, 1, 1, 10, 20.00, 'Libre')--se crea el tercer libro para verificar la funcionalidad de esta

CREATE TABLE Compras  --se crea la tabla compras donde se alojaran todas las compras
(
	CodigoCompra INT IDENTITY NOT NULL PRIMARY KEY,
	Usuario INT, --nombre de la llave foranea
	CONSTRAINT fk_idUsuario_C FOREIGN KEY (Usuario) REFERENCES Usuarios(CodigoUser) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla usuarios y se le agrega la propiedad de actualizar y eliminar en cascada
	FechaCompra DATE NOT NULL,
	Total DECIMAL(5,2)
)

INSERT INTO Compras VALUES (1, '10-06-2023', 0) --se crea la primera compra para verificar la funcionalidad de esta

CREATE TABLE DetalleCompras ( --se crea la tabla DetalleCompras donde se alojaran todos los items que el usuario compre
	CodigoDetalleCompra INT IDENTITY NOT NULL PRIMARY KEY,
	CodigoCompra INT NOT NULL,--nombre de la llave foranea
	CONSTRAINT fk_idCompra FOREIGN KEY (CodigoCompra) REFERENCES Compras(CodigoCompra) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla compras y se le agrega la propiedad de actualizar y eliminar en cascada
	Libro VARCHAR(20) NOT NULL,--nombre de la llave foranea	
	CONSTRAINT fk_idLibro FOREIGN KEY (Libro) REFERENCES Libros(ISBN) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla libros y se le agrega la propiedad de actualizar y eliminar en cascada
	PrecioLibro DECIMAL(5,2) NOT NULL,
	Cantidad INT NOT NULL,
	SubTotal DECIMAL(5,2) NOT NULL
);

--se crea la tabla prestamo donde se alojaran todos los prestamos
CREATE TABLE Prestamo(
CodigoPrestamo INT IDENTITY NOT NULL PRIMARY KEY,
Usuario INT, --nombre de la llave foranea
CONSTRAINT fk_idUsuario_pre FOREIGN KEY (Usuario) REFERENCES Usuarios(CodigoUser) ON UPDATE NO ACTION ON DELETE NO ACTION,
FechaPrestamo DATE NOT NULL,
Estado VARCHAR(10)--aqui se guardara si el libro esta aprobado o no
)

INSERT INTO Prestamo VALUES (1, '10-06-2023', 'Aprobado') --se crea el primer prestamo para verificar la funcionalidad de esta

--se crea la tabla DetallePrestamo donde se alojaran todos los items que el usuario pida prestado
CREATE TABLE DetallePrestamo(
CodigoDetallePrestamo INT IDENTITY NOT NULL PRIMARY KEY,
CodigoPrestamo INT Not null,
CONSTRAINT fk_idPrestamo_Pre FOREIGN KEY (CodigoPrestamo) REFERENCES Prestamo(CodigoPrestamo) ON UPDATE NO ACTION ON DELETE NO ACTION,
Libro VARCHAR(20) NOT NULL,--nombre de la llave foranea	
CONSTRAINT fk_idLibro_Pre FOREIGN KEY (Libro) REFERENCES Libros(ISBN) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla libros y se le agrega la propiedad de actualizar y eliminar en cascada
Cantidad INT NOT NULL,
);

--procedimiento almacenado para insertar compras
CREATE PROCEDURE InsertarCompra
	@Usuario VARCHAR(50),
	@FechaCompra VARCHAR(20),
	@Total DECIMAL(5,2)
AS
BEGIN
	DECLARE @IdUsuario INT;
	-- Obtenemos el ID del usuario a partir de su nombre
	SELECT @IdUsuario = CodigoUser
	FROM Usuarios
	WHERE UserName = @Usuario;
	-- Insertamos la compra
	INSERT INTO Compras (Usuario, FechaCompra, Total)
	VALUES (@IdUsuario, CONVERT(DATETIME, @FechaCompra, 103), @Total);
END
--fin del procedimiento

EXEC InsertarCompra josue72, '10-06-2023',0--se ejecuta el procedimiento almacenado para verificar la funcionalidad de esta



--procedimiento almacenado para insertar el detalle de la compra
CREATE PROCEDURE InsertarDetalleCompra
    @CodigoCompra INT,
    @NombreLibro VARCHAR(50),
    @PrecioLibro DECIMAL(5,2),
    @Cantidad INT,
    @SubTotal DECIMAL(5,2)
AS
BEGIN
    DECLARE @ISBN VARCHAR(20)

    -- Obtener el ISBN del libro bas�ndose en el nombre del libro
    SELECT @ISBN = ISBN
    FROM Libros
    WHERE NombreLibro = @NombreLibro

    -- Insertar el detalle de la compra utilizando el ISBN
    INSERT INTO DetalleCompras (CodigoCompra, Libro, PrecioLibro, Cantidad, SubTotal)
    VALUES (@CodigoCompra, @ISBN, @PrecioLibro, @Cantidad, @SubTotal)

    -- Actualizar el total de la compra
    EXEC ActualizarTotalCompra @CodigoCompra;
END
--fin del procedimiento almacenado
EXEC InsertarDetalleCompra 1, 'Cien a�os de soledad', 15.00, 1, 15.00 --se ejecuta el procedimiento almacenado para verificar la funcionalidad de esta
--consulta personalizada para mostrar el nombre del libro en vez del codigo de este
SELECT D.CodigoDetalleCompra, D.CodigoCompra, L.NombreLibro AS Libro, D.PrecioLibro, D.Cantidad, D.SubTotal
FROM DetalleCompras D
INNER JOIN Libros L ON D.Libro = L.ISBN;
--procedimiento almacenado para actualizar el total de la compra
CREATE PROCEDURE ActualizarTotalCompras
AS
BEGIN
    DECLARE @CodigoCompra INT

    -- Cursor para recorrer todas las compras
    DECLARE actualizarCursor CURSOR FOR
    SELECT CodigoCompra
    FROM Compras

    OPEN actualizarCursor
    FETCH NEXT FROM actualizarCursor INTO @CodigoCompra

    -- Iterar sobre todas las compras y actualizar el total
    WHILE @@FETCH_STATUS = 0
    BEGIN
        DECLARE @NuevoTotal DECIMAL(5,2)

        -- Calcular el nuevo total sumando los subtotales de los detalles de compra
        SELECT @NuevoTotal = SUM(SubTotal)
        FROM DetalleCompras
        WHERE CodigoCompra = @CodigoCompra

        -- Actualizar el total en la tabla Compras
        UPDATE Compras
        SET Total = @NuevoTotal
        WHERE CodigoCompra = @CodigoCompra

        FETCH NEXT FROM actualizarCursor INTO @CodigoCompra
    END

    CLOSE actualizarCursor
    DEALLOCATE actualizarCursor
END
--fin del procedimiento almacenado
EXEC ActualizarTotalCompras--se ejecuta el procedimiento almacenado para verificar la funcionalidad de esta

SELECT C.*
FROM Compras C
JOIN Usuarios U ON C.Usuario = U.CodigoUser
WHERE U.UserName LIKE '%Josue%';

--procedimiento almacenado para eliminar un item o detalle dentro de la tabla DetalleCompras
CREATE PROCEDURE EliminarDetalleCompra
    @CodigoDetalleCompra INT
AS
BEGIN
    -- Verificar si el detalle de compra existe
    IF EXISTS (SELECT 1 FROM DetalleCompras WHERE CodigoDetalleCompra = @CodigoDetalleCompra)
    BEGIN
        -- Eliminar el detalle de compra
        DELETE FROM DetalleCompras WHERE CodigoDetalleCompra = @CodigoDetalleCompra;

        -- Actualizar el total de la compra
        EXEC ActualizarTotalCompras;

        -- Mensaje de �xito
        PRINT 'Detalle de compra eliminado exitosamente.';
    END
    ELSE
    BEGIN
        -- Mensaje de error si el detalle de compra no existe
        PRINT 'No se encontr� el detalle de compra para eliminar.';
    END
END
--fin del procedimiento almacenado

-- Procedimiento almacenado para actualizar StockLibro en Libros
CREATE PROCEDURE ActualizarStockLibro
AS
BEGIN
    DECLARE @ISBN VARCHAR(20);
    DECLARE @SumaCantidad INT;

    -- Cursor para recorrer los detalles de compra y calcular la suma de cantidades por libro
    DECLARE actualizarCursor CURSOR FOR
    SELECT D.Libro, SUM(D.Cantidad) AS SumaCantidad
    FROM DetalleCompras D
    JOIN Compras C ON D.CodigoCompra = C.CodigoCompra
    GROUP BY D.Libro;

    OPEN actualizarCursor
    FETCH NEXT FROM actualizarCursor INTO @ISBN, @SumaCantidad;

    -- Iterar sobre los detalles de compra y actualizar StockLibro en Libros
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Actualizar StockLibro en Libros con la suma de cantidades
        UPDATE Libros
        SET StockLibro = @SumaCantidad
        WHERE ISBN = @ISBN;

        FETCH NEXT FROM actualizarCursor INTO @ISBN, @SumaCantidad;
    END

    CLOSE actualizarCursor
    DEALLOCATE actualizarCursor
END
--fin del procedimiento almacenado



CREATE PROCEDURE InsertarPrestamo
	@Usuario VARCHAR(50),
	@FechaPrestamo VARCHAR(20),
	@Estado VARCHAR(10)
AS
BEGIN
	DECLARE @IdUsuario INT;

	SELECT @IdUsuario = CodigoUser
	FROM Usuarios
	WHERE UserName = @Usuario;

	INSERT INTO Prestamo (Usuario, FechaPrestamo, Estado)
	VALUES (@IdUsuario, CONVERT(DATETIME, @FechaPrestamo, 103), @Estado);
END

CREATE PROCEDURE InsertarDetallePrestamo
    @CodigoPrestamo INT,
    @NombreLibro VARCHAR(50),
    @Cantidad INT
AS
BEGIN
    DECLARE @ISBN VARCHAR(20)

    -- Obtener el ISBN del libro bas�ndose en el nombre del libro
    SELECT @ISBN = ISBN
    FROM Libros
    WHERE NombreLibro = @NombreLibro

    -- Insertar el detalle de la compra utilizando el ISBN
    INSERT INTO DetallePrestamo(CodigoPrestamo, Libro, Cantidad)
    VALUES (@CodigoPrestamo, @ISBN, @Cantidad)
END

EXEC ActualizarStockLibro --se ejecuta el procedimiento almacenado para verificar la funcionalidad de esta
SELECT Cantidad FROM DetalleCompras WHERE Libro = '' --se verifica que la cantidad del libro sea 1

SELECT L.StockLibro FROM Libros L INNER JOIN Categoria C ON L.Categoria = C.CodigoCategoria WHERE C.NombreCategoria = 'Terror' AND L.NombreLibro = 'El principito'

-- Procedimiento almacenado para actualizar el StockLibro en Libros al realizar un pr�stamo
CREATE PROCEDURE ActualizarStockPrestamo
AS
BEGIN
    DECLARE @ISBN VARCHAR(20);
    DECLARE @CantidadPrestamo INT;

    -- Cursor para recorrer los detalles de pr�stamo y obtener la cantidad por libro
    DECLARE actualizarCursor CURSOR FOR
    SELECT DP.Libro, DP.Cantidad
    FROM DetallePrestamo DP
    JOIN Prestamo P ON DP.CodigoPrestamo = P.CodigoPrestamo;

    OPEN actualizarCursor
    FETCH NEXT FROM actualizarCursor INTO @ISBN, @CantidadPrestamo;

    -- Iterar sobre los detalles de pr�stamo y actualizar StockLibro en Libros
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Actualizar StockLibro en Libros restando la cantidad de pr�stamo
        UPDATE Libros
        SET StockLibro = StockLibro - @CantidadPrestamo
        WHERE ISBN = @ISBN;

        FETCH NEXT FROM actualizarCursor INTO @ISBN, @CantidadPrestamo;
    END

    CLOSE actualizarCursor;
    DEALLOCATE actualizarCursor;
END
EXEC ActualizarStockPrestamo

--se crea una vista donde iran el contador de cuantas veces dicho libro fue prestado
-- Crear la vista que incluye el contador de pr�stamos
CREATE VIEW VistaLibrosConContador AS
SELECT
    L.ISBN,
    L.NombreLibro,
    L.Autor,
    L.Editorial,
    L.Categoria,
    L.StockLibro,
    L.PrecioLibro,
    L.EstadoLibro,
    ISNULL(DP.ContadorLibro, 0) AS ContadorPrestamos
FROM Libros L
LEFT JOIN (
    SELECT DP.Libro, COUNT(*) AS ContadorLibro
    FROM DetallePrestamo DP
    INNER JOIN Prestamo P ON DP.CodigoPrestamo = P.CodigoPrestamo
    WHERE P.Estado = 'Aprobado'
    GROUP BY DP.Libro
) DP ON L.ISBN = DP.Libro;

SELECT * FROM VistaLibrosConContador;
