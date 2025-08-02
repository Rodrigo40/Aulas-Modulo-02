Create database sysvendaDB;
USE sysvendaDB;

create table users (
	id INT identity PRIMARY KEY,
	nome VARCHAR(50) NOT NULL UNIQUE,
	email VARCHAR(100) NOT NULL UNIQUE,
	password VARCHAR(255) NOT NULL,
	DataCadastro datetime not null default getdate(),
	DataAtualizacao datetime not null default getdate(),
);	


create table produto (
	id INT identity PRIMARY KEY,
	nome VARCHAR(50) NOT NULL UNIQUE,
	descricao VARCHAR(100) NOT NULL UNIQUE,
	quantidade decimal,
	preco decimal,
	DataCadastro datetime not null default getdate(),
	DataAtualizacao datetime not null default getdate(),
);	
create table cliente (
	id INT identity PRIMARY KEY,
	nome VARCHAR(50) NOT NULL UNIQUE,
	DataCadastro datetime not null default getdate(),
	DataAtualizacao datetime not null default getdate(),
);	
create table venda (
	id INT identity PRIMARY KEY,
	idUser int,
	idCliente int,
	idProduto int,
	DataVenda datetime not null default getdate(),
	totalVenda decimal(10,2),
	foreign key (idUser) references users(id),
	foreign key (idCliente) references cliente(id),
	foreign key (idProduto) references produto(id)
);	
create table detalheVenda (
	id INT identity PRIMARY KEY,
	idVenda int,
	idProduto int,
	quantidade decimal,
    preco decimal,
    total decimal,
	descricao VARCHAR(100),
	DataCadastro datetime not null default getdate(),
	foreign key (idVenda) references venda(id),
	foreign key (idProduto) references produto(id)
);	


select * from users
select * from cliente
select * from produto
select * from venda
select * from detalheVenda
------------------------------------------------------------------
--Store Procedures--
------------------------------------------------------------------

CREATE PROCEDURE sp_CadastrarUser
	@nome VARCHAR(50),
	@email VARCHAR(100),
	@password VARCHAR(50)
	as
	insert into users (nome, email, password)
	values (@nome, @email, @password);
	go
	-- Atualiza a data de cadastro para o momento atual
	CREATE PROCEDURE sp_AtualizarUser
	@id INT,
	@nome VARCHAR(50),
	@email VARCHAR(100),
	@password VARCHAR(50)
	as
	update users set nome = @nome, email = @email, password = @password, DataAtualizacao = getdate()
	where id = @id;
	go

	-- Exclui um usuário pelo ID
	CREATE PROCEDURE sp_ExcluirUser
	@id INT
	as
	delete from users where id = @id;
	go

	-- Consulta todos os usuários
	CREATE PROCEDURE sp_GetUsers
	as
	select * from users;
	go
	-- 
	-- Consulta para o login
	CREATE PROCEDURE sp_Login
	@email varchar(50),
	@password varchar(50)
	as
	select * from users where email=@email and password=@password;
	go
	-- Consulta um usuário pelo ID
	CREATE PROCEDURE sp_ConsultarUserPorId
	@id INT
	as
	select * from users where id = @id;
	go
	-- Definir Usuario padrao
	Create proc sp_DifinirUserPadrao
	as
     insert into users
	 (nome,email,password)
	 values
	 ('Administrador','admin@gmail.com','admin')
	go