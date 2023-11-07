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
	Libros VARCHAR(20) NOT NULL,--nombre de la llave foranea
	CONSTRAINT fk_idLibro_C FOREIGN KEY (Libros) REFERENCES Libros(ISBN) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla libros y se le agrega la propiedad de actualizar y eliminar en cascada
	Editorial INT,--nombre de la llave foranea
	CONSTRAINT fk_idEditoria_C FOREIGN KEY (Editorial) REFERENCES Editorial(CodigoEditorial) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla editorial y se le agrega la propiedad de actualizar y eliminar en cascada
	Usuario INT, --nombre de la llave foranea
	CONSTRAINT fk_idUsuario_C FOREIGN KEY (Usuario) REFERENCES Usuarios(CodigoUser) ON UPDATE NO ACTION ON DELETE NO ACTION,--referencia a la tabla usuarios y se le agrega la propiedad de actualizar y eliminar en cascada
	FechaCompra DATE NOT NULL,
	Total DECIMAL(5,2) NOT NULL
)
SELECT CodigoCompra, Libros, Editorial, Usuario,CONVERT(VARCHAR(10), FechaCompra, 103) AS FechaCompraFormateada, Total FROM Compras; --transformar el formato 'AAAA-MM-DD' a 'DD-MM-AAAA'

--consulta para insetar una compra
INSERT INTO Compras VALUES ('978-1-234567-89-0', 1, 1, '01-01-2021', @TotalCompra);--se crea la primera compra para verificar la funcionalidad de esta
INSERT INTO Compras VALUES ('978-1-234567-89-1', 1, 1, '01-01-2021', @TotalCompra);
INSERT INTO Compras VALUES ('978-1-234567-89-2', 1, 1, '01-01-2021', @TotalCompra);
-- Consulta para calcular el total de una compra
DECLARE @TotalCompra DECIMAL(5, 2) SET @TotalCompra = (SELECT SUM(PrecioLibro) FROM Libros WHERE ISBN = '978-1-234567-89-2');
--consulta para actualizar el total de una compra
UPDATE Compras SET Total = @TotalCompra WHERE Libros = '978-1-234567-89-2'

CREATE TABLE ComprasAgrupadas ( --se crea la tabla compras agrupadas donde se alojaran todas las compras agrupadas por usuario y fecha de compra
    IdCompraAgrupada INT IDENTITY NOT NULL PRIMARY KEY,
    Usuario INT,
    FechaCompra DATE,
    TotalCompra DECIMAL(5, 2)
);
SELECT idCompraAgrupada, Usuario,CONVERT(VARCHAR(10), FechaCompra, 103) AS FechaCompraFormateada, TotalCompra FROM ComprasAgrupadas; --transformar el formato 'AAAA-MM-DD' a 'DD-MM-AAAA'
-- Agrupar compras por usuario y fecha y calcular el total
INSERT INTO ComprasAgrupadas (Usuario, FechaCompra, TotalCompra)
SELECT Usuario, FechaCompra, SUM(Total)
FROM Compras
GROUP BY Usuario, FechaCompra;
--esta consulta muestra la compra total segun el usuario o la fecha de compra
SELECT * FROM ComprasAgrupadas WHERE Usuario = 1 --se muestra la compra total segun la fecha de compra



