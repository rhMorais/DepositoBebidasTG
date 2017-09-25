IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_PedidoInserir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_PedidoInserir]
GO

CREATE PROCEDURE [dbo].[TGDB_PedidoInserir]									
	@idobs varchar(255),
	@desconto money,
	@vltotal money, 
	@idaten int,
	@idcli int

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Pedido.sql
	Objetivo..........: Inserir um Pedido
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_PedidoInserir]

	*/

	BEGIN
		INSERT INTO [dbo].[Pedido] (idobs, desconto, vltotal, idaten, idcli)
			VALUES (@idobs, @desconto, @vltotal, @idaten, @idcli)									
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_PedidoEditar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_PedidoEditar]
GO

CREATE PROCEDURE [dbo].[TGDB_PedidoEditar]				
	@idped int,
	@idobs varchar(255),
	@desconto money,
	@vltotal money, 
	@idaten int,
	@idcli int

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Pedido.sql
	Objetivo..........: Editar um Pedido
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_PedidoEditar]

	*/
	select * from pedido
	BEGIN
		update Pedido
			set idobs = @idobs,
				desconto = @desconto,
				vltotal = @vltotal,
				idaten = @idaten,
				idcli = @idcli
			where idped = @idped
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_PedidoExcluir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_PedidoExcluir]
GO

CREATE PROCEDURE [dbo].[TGDB_PedidoExcluir]				
	@idped int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Pedido.sql
	Objetivo..........: Excluir um Pedido
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_PedidoExcluir]

	*/

	BEGIN
		delete Pedido
			where idped = @idped
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_PedidoListar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_PedidoListar]
GO

CREATE PROCEDURE [dbo].[TGDB_PedidoListar]					
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Pedido.sql
	Objetivo..........: Excluir um Pedido
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_PedidoListar]

	*/

	BEGIN
		select	p.idped,
				p.idobs,
				p.desconto,
				p.vltotal, 								
				a.nome, 								
				c.nome 
			from Pedido p inner join cliente c
				on c.idcli = p.idcli
						inner join atendende a
				on a.idaten = p.idaten

	END
GO

