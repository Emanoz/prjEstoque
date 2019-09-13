CREATE TABLE USUARIO
(
	CodUsuario int primary key identity,
	Nome varchar(80) not null,
	Cargo varchar(30) not null, 
	Pin varchar(10) not null, 
	Senha varchar (20) not null
)

CREATE TABLE ESTOQUE
(
	CodEstoque int primary key identity, 
	Quantidade int not null, 
	[Local] varchar (80) not null
)

CREATE TABLE CATEGORIA
(
	CodCategoria int primary key identity,
	Descri��o varchar (500) not null
)

CREATE TABLE EQUIPAMENTO 
(
	CodEquipamento int primary key identity,
	Descri��o varchar (500) not null, 
	NumSerie varchar(30) not null,
	Estado varchar (10) not null,
	CodCategoria int references CATEGORIA(CodCategoria), 
	Pertencente varchar(50) not null,
	Patrimonio int not null,
)

CREATE TABLE TERMO_DE_EMPRESTIMO
(
	CodTermo int primary key identity, 
	DataRetirada datetime not null, 
	CaminhoDigitalizado varchar (100) not null,
	RG int not null,
	DataDevolu��o datetime,
	CodEquipamento int references EQUIPAMENTO(CodEquipamento)
)

CREATE TABLE MOVIMENTA��O
(
	CodMovimenta��o int primary key identity,
	CodUsuario int references USUARIO(CodUsuario),
	CodEquipamento int references EQUIPAMENTO(CodEquipamento),
	CodEstoque int references ESTOQUE(CodEstoque),
	Estado varchar (10) not null, 
	DataMovimenta��o datetime
)