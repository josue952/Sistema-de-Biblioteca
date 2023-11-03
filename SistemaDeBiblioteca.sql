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

CREATE TABLE Autores --se crea la tabla autores donde se alojaran todos los autores
(
	CodigoAutor INT IDENTITY NOT NULL PRIMARY KEY,
	NombreAutor VARCHAR(50) NOT NULL,
	FechaNacAutor DATE NOT NULL,
	GeneroLiterario VARCHAR(25) NOT NULL
)

SELECT CodigoAutor, NombreAutor, CONVERT(VARCHAR(10), FechaNacAutor, 103) AS FechaNacFormateada, GeneroLiterario FROM Autores; --transformar el formato 'AAAA-MM-DD' a 'DD/MM/AAAA'

CREATE TABLE Libros --se crea la tabla libros donde se alojaran todos los libros
(
	ISBN VARCHAR(15) IDENTITY NOT NULL PRIMARY KEY,
	NombreLibro VARCHAR(50) NOT NULL,
	CodAutor INT NOT NULL,--nombre de la llave foranea
	CONSTRAINT fk_idAutor FOREIGN KEY (CodAutor) REFERENCES Autores(CodigoAutor) ON UPDATE CASCADE ON DELETE CASCADE,--referencia a la tabla autores y se le agrega la propiedad de actualizar y eliminar en cascada
	CodEditorial INT NOT NULL,--nombre de la llave foranea 
	CONSTRAINT fk_idEditorial FOREIGN KEY (CodEditorial) REFERENCES Editorial(CodigoEditoria) ON UPDATE CASCADE ON DELETE CASCADE,--referencia a la tabla editorial y se le agrega la propiedad de actualizar y eliminar en cascada
	CategoriaLibro VARCHAR(50) NOT NULL,--id
	StockLibro INT NOT NULL,
	PrecioLibro DECIMAL(5,2) NOT NULL,
	EstadoLibro VARCHAR(50) --sirve para saber si el libro se encuentra libre o prestado
)