create database bdEstoque
go

create table tbEndereco (
	id int identity(1,1) not null primary key,
	cep nvarchar(8) not null,
	referencia nvarchar(MAX) null
)
go

create table tbFornecedor (
	id int identity(1,1) not null primary key,
	id_endereco int not null foreign key references tbEndereco(id),
	nome nvarchar(80) not null,
	telefone nvarchar(9) not null,
	email nvarchar(100) null,
	tipoProduto nvarchar(40) not null,
	cpf nvarchar(11) null,
	cnpj nvarchar(14) null,
)
go

create table tbCategoria (
	id int identity(1,1) not null primary key,
	descricao nvarchar(20) not null
)
go

create table tbProduto (
	id int identity(1,1) not null primary key,
	id_fornecedor int not null foreign key references tbFornecedor(id),
	id_categoria int not null foreign key references tbCategoria(id),
	quantidade int null,
	cadastrado_em datetime not null,
	valor_varejo float null
)
go

create table tbComposicao (
	id int identity(1,1) not null primary key,
	id_produto_1 int not null foreign key references tbProduto(id),
	id_produto_2 int not null foreign key references tbProduto(id),
	id_produto_3 int not null foreign key references tbProduto(id),
	quantidade_1 int not null,
	quantidade_2 int not null,
	quantidade_3 int not null
)
go