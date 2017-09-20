create database BancoDeposito
Use BancoDeposito

/* Vendedor ( idven, nome, telefone, empresa)
Pordutos(idpro, descricao, preco, idvendedor) 
Cliente (idcli, nome, cpf, endereco, bairro, cidade, telefone, celular,e-mail)
Atendente(idaten, nome) 
Login (username*, senha, idate) 
Belalugavael ( idbem, descricao, NumPatrimonio, vlaluguel)
Pedido(idped, idobs, vltotal, idaten, idcli) 
Aluguel_bem(idped, idbem, qtde, inicio, fim)
Pedido_produto(idped, idpro, qtde)*/

create table Vendedor(
	idven int 
		constraint pk_v primary key identity(1,1),
	nome varchar(70),
	telefone varchar(15),
	celular varchar(15),
	empresa varchar(50)
)

insert into vendedor values
	('Joao', '9999-9999','37234444','comercial ltda'),
	('Mario', '8888-8888','37235555','Master ltda'),
	('Inacio', '7777-7777','37236666','RL ltda')

create table Produto(
	idpro int
		constraint pk_p primary key identity(1,1),
	descricao varchar (50), 
	preco	money, 
	idvendedor int
		constraint fk_p foreign key references Vendedor(idven)
)

insert into Produto values
	('Carvão', 10.00, 1),
	('Agua mineral', 2.00, 2),
	('Cerveja skol', 5.00, 2),
	('Gelo', 15.00, 3)
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
insert into cliente values	
	('Nestor', '123456789', 'Rua Um, 123', 'Aeroporto', 'Franca', '11111111', '4444444', 'n@bol.com'),
	('Mauricio', '987654321', 'Rua Sete, 3455', 'Noemia', 'Franca', '22222222', '55555555', 'm@hotmail.com'),
	('Elenicie', '5678901233', 'Rua Flor, 999', 'Leporace', 'Franca', '33333333', '666666666', 'e@yahoo.com')

Create table Atendente(
	idaten INT 
		constraint pk_a primary key identity(1,1),
	nome varchar(70)
	) 
insert into atendente values
	('kaka'),
	('zezim'),
	('CJ')

Create table Loginn (
	username varchar(20)
		constraint pk_l primary key, 
	senha varchar(12), 
	idaten int
		constraint fk_l foreign key references Atendente(idaten) 
		)
insert into loginn values
	('kaka', 123, 1),
	('zezim', 123, 2),
	('CJ', 123, 3)

Create table Bemalugavel ( 
	idbem int
		constraint pk_ba primary key identity(1,1), 
	descricao varchar(70), 
	NumPatrimonio varchar(50), 
	vlaluguel money
	)
insert into Bemalugavel values
	('Mesa com 4 cadeiras', 'M001', 5.00),
	('Freezer', 'F001', 50.00)
	
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
insert into Pedido values
	('nda', 0, 0, 1, 1),
	('nda', 0, 0, 2, 2),
	('nda', 0, 0, 3, 3),
	('nda', 0, 0, 1, 1)

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
	
insert into Aluguel_bem values 
	( 1, 1, 0, 0, '23/05/2010', '24/05/2010'),
	( 2, 2, 0, 0, '23/04/2010', '25/04/2010')

create table Pedido_produto(
	idped int	
		constraint fk_pa1 foreign key references Pedido(idped), 
	idpro int
		constraint fk_pa2 foreign key references Produto(idpro), 
	qtde int,
	total money
	)
	
insert into pedido_produto values
	( 1, 2, 0, 0),
	( 2, 1, 0, 0),
	( 3, 3, 0, 0)


create view consultaProduto
as
select p.idpro, p.descricao, p.preco, v.nome, v.empresa 
from produto p inner join Vendedor v on p.idvendedor = v.idven

select * from consultaProduto


create procedure sp_consultaproduto
@id int
as
begin
	select p.idpro, p.descricao, p.preco, v.nome, v.empresa
	from produto p inner join vendedor v
		on p.idvendedor = v.idven
	where p.idpro = @id		
end

exec sp_consultaproduto 2