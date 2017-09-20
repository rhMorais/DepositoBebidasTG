IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_ClienteInserir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_ClienteInserir]
GO

CREATE PROCEDURE [dbo].[TGDB_ClienteInserir]							
	@nome varchar(70), 
	@cpf varchar(15), 
	@endereco varchar(255),
	@bairro varchar(50), 
	@cidade varchar(50), 
	@telefone varchar(15), 
	@celular varchar(15),
	@email varchar(255)

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Cliente.sql
	Objetivo..........: Inserir um Cliente
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_ClienteInserir]

	*/

	BEGIN
		INSERT INTO [dbo].[Cliente] (nome, cpf, endereco, bairro, cidade, telefone, celular, email)
			VALUES (@nome, @cpf, @endereco, @bairro, @cidade, @telefone, @celular, @email)									
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_ClienteEditar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_ClienteEditar]
GO

CREATE PROCEDURE [dbo].[TGDB_ClienteEditar]				
	@idcli int,
	@nome varchar(70), 
	@cpf varchar(15), 
	@endereco varchar(255),
	@bairro varchar(50), 
	@cidade varchar(50), 
	@telefone varchar(15), 
	@celular varchar(15),
	@email varchar(255)

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Cliente.sql
	Objetivo..........: Editar um Cliente
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_ClienteEditar]

	*/

	BEGIN
		update Cliente 
			set nome = @nome,
				cpf = @cpf,
				endereco = @endereco,
				bairro = @bairro,
				cidade = @cidade,
				telefone = @telefone,
				celular = @celular, 
				email = @email
			where idcli = @idcli
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_ClienteExcluir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_ClienteExcluir]
GO

CREATE PROCEDURE [dbo].[TGDB_ClienteExcluir]				
	@idcli int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Cliente.sql
	Objetivo..........: Excluir um Cliente
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_ClienteExcluir]

	*/

	BEGIN
		delete Cliente 
			where idcli = @idcli									
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_ClienteListar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_ClienteListar]
GO

CREATE PROCEDURE [dbo].[TGDB_ClienteListar]					
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Cliente.sql
	Objetivo..........: Excluir um Cliente
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_ClienteListar]

	*/

	BEGIN
		select	nome,
				cpf,
				endereco,
				bairro,
				cidade,
				telefone,
				celular, 
				email
			from Cliente
	END
GO

