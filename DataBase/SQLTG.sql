Use BancoDepositoTG

/* Vendedor ( idven, nome, telefone, empresa)
Pordutos(idpro, descricao, preco, idvendedor) 
Cliente (idcli, nome, cpf, endereco, bairro, cidade, telefone, celular,e-mail)
Atendente(idaten, nome) 
Login (username*, senha, idate) 
Belalugavael ( idbem, descricao, NumPatrimonio, vlaluguel)
Pedido(idped, idobs, vltotal, idaten, idcli) 
Aluguel_bem(idped, idbem, qtde, inicio, fim)
Pedido_produto(idped, idpro, qtde)*/
go
create table Vendedor(
	idven int 
		constraint pk_v primary key identity(1,1),
	nome varchar(70),
	telefone varchar(15),
	celular varchar(15),
	empresa varchar(50)
)
go
create table Produto(
	idpro int
		constraint pk_p primary key identity(1,1),
	descricao varchar (50), 
	preco	money, 
	idvendedor int
		constraint fk_p foreign key references Vendedor(idven)
)
go

Create table Cliente (
	idcli int	
		constraint pk_c primary key identity(1,1), 
	nome varchar(70), 
	cpf varchar(15), 
	endereco varchar(255), 
	bairro varchar(50), 
	cidade varchar(50), 
	telefone varchar(15), 
	celular varchar(15),
	email varchar(255)
	)
go
Create table Atendente(
	idaten INT 
		constraint pk_a primary key identity(1,1),
	nome varchar(70)
	) 
	go
Create table Bemalugavel ( 
	idbem int
		constraint pk_ba primary key identity(1,1), 
	descricao varchar(70), 
	NumPatrimonio varchar(50), 
	vlaluguel money
	)
	go
create table Pedido(
	idped int
		constraint pk_pe primary key identity (1,1), 
	idobs varchar(255), 
	desconto money,
	vltotal money, 
	idaten int
		constraint fk_pe1 foreign key references Atendente(idaten), 
	idcli int
		constraint fk_pe2 foreign key references Cliente(idcli)
	) 	
go
create table Aluguel_bem(
	idped int
		constraint fk_ab1 foreign key references Pedido(idped), 
	idbem int
		constraint fk_ab2 foreign key references Bemalugavel(idbem),
	qtde int, 
	total money,
	inicio date, 
	fim date
	)
go
create table Pedido_produto(
	idped int	
		constraint fk_pa1 foreign key references Pedido(idped), 
	idpro int
		constraint fk_pa2 foreign key references Produto(idpro), 
	qtde int,
	total money
	)
