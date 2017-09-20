IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_Pedido_ProdutoInserir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_Pedido_ProdutoInserir]
GO

CREATE PROCEDURE [dbo].[TGDB_Pedido_ProdutoInserir]									
	@idped int,	
	@idpro int,
	@qtde int,
	@total money

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Pedido_Produto.sql
	Objetivo..........: Inserir um Pedido_Produto
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_Pedido_ProdutoInserir]

	*/
	
	BEGIN
		INSERT INTO [dbo].[Pedido_Produto] (idped, idpro, qtde, total)
			VALUES (@idped, @idpro, @qtde, @total)									
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_Pedido_ProdutoEditar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_Pedido_ProdutoEditar]
GO

CREATE PROCEDURE [dbo].[TGDB_Pedido_ProdutoEditar]				
	@idped int,	
	@idpro int,
	@qtde int,
	@total money

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Pedido_Produto.sql
	Objetivo..........: Editar um Pedido_Produto
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_Pedido_ProdutoEditar]

	*/
	BEGIN
		update Pedido_Produto
			set qtde = @qtde,
				total = @total
			where idped = @idped and idpro = @idpro
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_Pedido_ProdutoExcluir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_Pedido_ProdutoExcluir]
GO

CREATE PROCEDURE [dbo].[TGDB_Pedido_ProdutoExcluir]				
	@idped int,
	@idpro int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Pedido_Produto.sql
	Objetivo..........: Excluir um Pedido_Produto
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_Pedido_ProdutoExcluir]

	*/

	BEGIN
		delete Pedido_Produto
			where idped = @idped and idpro = @idpro
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_Pedido_ProdutoListar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_Pedido_ProdutoListar]
GO

CREATE PROCEDURE [dbo].[TGDB_Pedido_ProdutoListar]					
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Pedido_Produto.sql
	Objetivo..........: Excluir um Pedido_Produto
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_Pedido_ProdutoListar]

	*/

	BEGIN
		select	idped, 
				idpro, 
				qtde,
				total 				
			from Pedido_Produto
	END
GO

