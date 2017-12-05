IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_ProdutoInserir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_ProdutoInserir]
GO

CREATE PROCEDURE [dbo].[TGDB_ProdutoInserir]						
	@descricao varchar(50),
	@preco money,
	@idvendedor int

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Produto.sql
	Objetivo..........: Inserir um Produto
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_ProdutoInserir]

	*/

	BEGIN
		INSERT INTO [dbo].[Produto] (descricao, preco, idvendedor)
			VALUES (@descricao, @preco, @idvendedor)									
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_ProdutoEditar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_ProdutoEditar]
GO

CREATE PROCEDURE [dbo].[TGDB_ProdutoEditar]				
	@idpro int,		
	@descricao varchar(50),
	@preco money,
	@idvendedor int

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Produto.sql
	Objetivo..........: Editar um Produto
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_ProdutoEditar]

	*/

	BEGIN
		update produto 
			set descricao = @descricao,
				preco = @preco,
				idvendedor = @idvendedor			 				
			where idpro = @idpro															
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_ProdutoExcluir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_ProdutoExcluir]
GO

CREATE PROCEDURE [dbo].[TGDB_ProdutoExcluir]				
	@idpro int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Produto.sql
	Objetivo..........: Excluir um Produto
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_ProdutoExcluir]

	*/

	BEGIN
		delete produto 
			where idpro = @idpro									
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_ProdutoListar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_ProdutoListar]
GO

CREATE PROCEDURE [dbo].[TGDB_ProdutoListar]					
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Produto.sql
	Objetivo..........: Excluir um Produto
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_ProdutoListar]

	*/

	BEGIN
		select	idpro,
				descricao, 
				preco,
				v.nome as nome														
			from produto p inner join Vendedor v 
				on p.idvendedor = v.idven
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_ProdutoSelecionar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_ProdutoSelecionar]
GO

CREATE PROCEDURE [dbo].[TGDB_ProdutoSelecionar]		
	@idpro	int		
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Produto.sql
	Objetivo..........: Selecionar um Produto
	Autor.............: Rafael Morais
 	Data..............: 07/11/2017
	Ex................: EXEC [dbo].[TGDB_ProdutoSelecionar]

	*/

	BEGIN
		select	idpro,
				descricao, 
				preco,
				v.nome as nome														
			from produto p inner join Vendedor v 
				on p.idvendedor = v.idven
			where idpro = @idpro
	END
GO