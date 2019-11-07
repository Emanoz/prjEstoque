CREATE DATABASE bdEstoque;

USE bdEstoque;

CREATE TABLE USUARIO
(
	CodUsuario int primary key identity,
	Usuario varchar(30) not null,
	Nome varchar(80) not null,
	Cargo varchar(30) not null, 
	Pin varchar(10) not null, 
	Senha varchar (20) not null
)

CREATE TABLE ESTOQUE
(
	CodEstoque int primary key identity,
	[Local] varchar (80) not null
)

CREATE TABLE CATEGORIA
(
	CodCategoria int primary key identity,
	Descricao varchar (500) not null
)

CREATE TABLE EQUIPAMENTO 
(
	CodEquipamento int primary key identity,
	Descricao varchar (500) not null, 
	NumSerie varchar(30) not null,
	Estado varchar (10) not null,
	CodCategoria int references CATEGORIA, 
	Pertencente varchar(50) not null,
	Patrimonio varchar(30) not null,
)

CREATE TABLE TERMO_DE_EMPRESTIMO
(
	CodTermo int primary key identity, 
	DataRetirada datetime not null, 
	RG varchar(30) not null,
	DataDevolucao datetime,
	CodEquipamento int references EQUIPAMENTO
)

CREATE TABLE MOVIMENTACAO
(
	CodMovimentacao int primary key identity,
	CodUsuario int references USUARIO,
	CodEquipamento int references EQUIPAMENTO,
	CodEstoque int references ESTOQUE,
	Estado varchar (10) not null, 
	DataMovimentacao datetime
)