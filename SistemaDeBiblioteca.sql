--esta base de datos esta creada mediante Azure con el motor de BD SQL Server
--el objetivo de crear la base de datos en la nube es para no cambiar el codigo dentro del proyecto
--Para asi tener un proyecto mas limpio
--nombre para conectar a la base de datod: josue
--Contraseña: Biblioteca123$
--Si se modificaran elementos preguntar primeramente y luego utulizar las funciones alter Column, drop, etc. 
--Para no eliminar la base de datos
CREATE TABLE Usuarios --se crea la tabla usuarios donde se alojaran todos los usuarios
(
	CodigoUser INT IDENTITY NOT NULL PRIMARY KEY,
	UserName VARCHAR(40) NOT NULL,
	UserPassword VARCHAR(40) NOT NULL,
	UserRol VARCHAR(25) NOT NULL,
	UserDepartamento VARCHAR(50) NOT NULL
)

INSERT INTO Usuarios VALUES ('josue72', 'josue0074', 'Administrador', 'San Salvador')--se crea el primer usuario para verificar la funcionalidad de esta

SELECT * FROM Usuarios

CREATE TABLE Editorial --se crea la tabla editorial donde se alojaran todas las editoriales
(
	CodigoEditorial INT IDENTITY NOT NULL PRIMARY KEY,
	NombreEditorial VARCHAR(50) NOT NULL,
	CorreoEditorial VARCHAR(50) NOT NULL,
	DireccionEditorial VARCHAR(255) NOT NULL,
	NumeroEditorial VARCHAR(9) NOT NULL,
)

INSERT INTO Editorial VALUES ('Editorial Santillana', 'santillana@gmail.com', 'San Salvador', '2505-8920')--se crea la primera editorial para verificar la funcionalidad de esta

CREATE TABLE Categoria --se crea la tabla categoria donde se alojaran todas las categorias
(
	CodigoCategoria INT IDENTITY NOT NULL PRIMARY KEY,
	NombreCategoria VARCHAR(50) NOT NULL,
	DescripcionCategoria VARCHAR(255) NOT NULL,
)
INSERT INTO Categoria VALUES ('Realismo Magico', 'Es un genero literario que se caracteriza por la inclusion de elementos magicos o fantasticos en una narracion realista')--se crea la primera categoria para verificar la funcionalidad de esta
--consulta personalizada para mostrar el nombre de la categoria en vez del codigo de la categoria
SELECT CodigoCategoria, NombreCategoria FROM Categoria

CREATE TABLE Autores --se crea la tabla autores donde se alojaran todos los autores
(
	CodigoAutor INT IDENTITY NOT NULL PRIMARY KEY,
	NombreAutor VARCHAR(50) NOT NULL,
	FechaNacAutor DATE NOT NULL,
	CodCategoria INT NOT NULL,--nombre de la llave foranea
	CONSTRAINT fk_idCategoria FOREIGN KEY (CodCategoria) REFERENCES Categoria(CodigoCategoria) ON UPDATE CASCADE ON DELETE CASCADE--referencia a la tabla categoria y se le agrega la propiedad de actualizar y eliminar en cascada
)
--es una consulta personalizada para mostrar el nombre de la categoria en vez del codigo de la categoria
SELECT A.CodigoAutor, A.NombreAutor, A.FechaNacAutor, C.NombreCategoria AS CodCategoria --sirve para indicar que el campo CodCategoria llevara el nombre de la categoria
FROM Autores A
INNER JOIN Categoria C ON A.CodCategoria = C.CodigoCategoria;

SELECT CodigoAutor, NombreAutor, CONVERT(VARCHAR(10), FechaNacAutor, 103) AS FechaNacFormateada, CodCategoria FROM Autores; --transformar el formato 'AAAA-MM-DD' a 'DD-MM-AAAA'

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
INSERT INTO Libros VALUES ('978-1-234567-89-0', 'Cien años de soledad', 1, 1, 1, 10, 15.00, 'Libre')--se crea el primer libro para verificar la funcionalidad de esta
INSERT INTO Libros VALUES ('978-1-234567-89-1', 'El coronel no tiene quien le escriba', 1, 1, 1, 10, 10.00, 'Libre')--se crea el segundo libro para verificar la funcionalidad de esta
INSERT INTO Libros VALUES ('978-1-234567-89-2', 'El amor en los tiempos del colera', 1, 1, 1, 10, 20.00, 'Libre')--se crea el tercer libro para verificar la funcionalidad de esta
--consulta personalizada para mostrar el nombre del autor, editorial y categoria en vez del codigo de estos
SELECT L.ISBN, L.NombreLibro, A.NombreAutor AS Autor, E.NombreEditorial AS Editorial, C.NombreCategoria AS Categoria, L.StockLibro, L.PrecioLibro, L.EstadoLibro
FROM Libros L
INNER JOIN Autores A ON L.Autor = A.CodigoAutor
INNER JOIN Editorial E ON L.Editorial = E.CodigoEditorial
INNER JOIN Categoria C ON L.Categoria = C.CodigoCategoria;

CREATE TABLE Compras 
(
	CodigoCompra INT IDENTITY NOT NULL PRIMARY KEY,
	Usuario INT, --nombre de la llave foranea
	CONSTRAINT fk_idUsuario_C FOREIGN KEY (Usuario) REFERENCES Usuarios(CodigoUser) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla usuarios y se le agrega la propiedad de actualizar y eliminar en cascada
	FechaCompra DATE NOT NULL,
	Total DECIMAL(5,2)
)
SELECT CodigoCompra, Usuario,CONVERT(VARCHAR(10), FechaCompra, 103) AS FechaCompraFormateada, Total FROM Compras; --transformar el formato 'AAAA-MM-DD' a 'DD-MM-AAAA'
--consulta personalizada para mostrar el nombre del usuario Y fecha formateada en vez del codigo de estos
SELECT CodigoCompra, U.UserName AS Usuario,CONVERT(VARCHAR(10), FechaCompra, 103) AS FechaCompraFormateada, Total FROM Compras C
INNER JOIN Usuarios U ON C.Usuario = U.CodigoUser;

SELECT C.CodigoCompra, U.UserName AS Usuario, CONVERT(VARCHAR(10), C.FechaCompra, 103) AS FechaCompraFormateada, C.Total 
FROM Compras C 
INNER JOIN Usuarios U ON C.Usuario = U.CodigoUser 
WHERE C.FechaCompra = CONVERT(DATE, '28/09/2023', 103)
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
EXEC InsertarCompra josue72, '10-06-2023',0

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

    -- Obtener el ISBN del libro basándose en el nombre del libro
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
EXEC InsertarDetalleCompra 1, 'Cien años de soledad', 15.00, 1, 15.00 --se ejecuta el procedimiento almacenado para verificar la funcionalidad de esta
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
