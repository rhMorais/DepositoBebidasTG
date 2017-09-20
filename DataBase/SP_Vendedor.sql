IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_VendedorInserir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_VendedorInserir]
GO

CREATE PROCEDURE [dbo].[TGDB_VendedorInserir]				
	@nome varchar(70),
	@telefone varchar(15),
	@celular varchar(15),
	@empresa varchar(50)

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Vendedor.sql
	Objetivo..........: Inserir um vendedor
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_VendedorInserir]

	*/

	BEGIN
		INSERT INTO [dbo].[Vendedor] (nome, telefone, celular, empresa)
			VALUES (@nome, @telefone, @celular, @empresa)									
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_VendedorEditar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_VendedorEditar]
GO

CREATE PROCEDURE [dbo].[TGDB_VendedorEditar]				
	@idven int,
	@nome varchar(70),
	@telefone varchar(15),
	@celular varchar(15),
	@empresa varchar(50)

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Vendedor.sql
	Objetivo..........: Editar um vendedor
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_VendedorEditar]

	*/

	BEGIN
		update vendedor 
			set nome = @nome,
				telefone = @telefone,
				celular = @celular,
				empresa = @empresa 
			where idven = @idven															
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_VendedorExcluir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_VendedorExcluir]
GO

CREATE PROCEDURE [dbo].[TGDB_VendedorExcluir]				
	@idven int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Vendedor.sql
	Objetivo..........: Excluir um vendedor
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_VendedorExcluir]

	*/

	BEGIN
		delete vendedor 
			where idven = @idven									
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_VendedorListar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_VendedorListar]
GO

CREATE PROCEDURE [dbo].[TGDB_VendedorListar]					
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Vendedor.sql
	Objetivo..........: Excluir um vendedor
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_VendedorListar]

	*/

	BEGIN
		select	idven,
				nome,
				telefone,
				celular, 
				empresa 												
			from vendedor
	END
GO

