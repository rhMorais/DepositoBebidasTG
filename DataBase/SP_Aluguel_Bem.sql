IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_Aluguel_BemInserir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_Aluguel_BemInserir]
GO

CREATE PROCEDURE [dbo].[TGDB_Aluguel_BemInserir]									
	@idped int,
	@idbem int,
	@qtde int, 
	@total money,
	@inicio date,
	@fim date

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Aluguel_Bem.sql
	Objetivo..........: Inserir um Aluguel_Bem
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_Aluguel_BemInserir]

	*/

	BEGIN
		INSERT INTO [dbo].[Aluguel_Bem] (idped, idbem, qtde, total, inicio, fim)
			VALUES (@idped, @idbem, @qtde, @total, @inicio, @fim)									
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_Aluguel_BemEditar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_Aluguel_BemEditar]
GO

CREATE PROCEDURE [dbo].[TGDB_Aluguel_BemEditar]				
	@idped int,
	@idbem int,
	@qtde int, 
	@total money,
	@inicio date,
	@fim date

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Aluguel_Bem.sql
	Objetivo..........: Editar um Aluguel_Bem
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_Aluguel_BemEditar]

	*/
	BEGIN
		update Aluguel_Bem
			set qtde = @qtde,
				total = @total,
				inicio = @inicio,
				fim = @fim
			where idped = @idped and idbem = @idbem
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_Aluguel_BemExcluir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_Aluguel_BemExcluir]
GO

CREATE PROCEDURE [dbo].[TGDB_Aluguel_BemExcluir]				
	@idped int,
	@idbem int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Aluguel_Bem.sql
	Objetivo..........: Excluir um Aluguel_Bem
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_Aluguel_BemExcluir]

	*/

	BEGIN
		delete Aluguel_Bem
			where idped = @idped and idbem = @idbem
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_Aluguel_BemListar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_Aluguel_BemListar]
GO

CREATE PROCEDURE [dbo].[TGDB_Aluguel_BemListar]					
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Aluguel_Bem.sql
	Objetivo..........: Listar um Aluguel_Bem
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_Aluguel_BemListar]

	*/

	BEGIN
		select	a.idped, 
				b.descricao,
				a.qtde,
				a.total, 
				a.inicio,
				a.fim
			from Aluguel_Bem a inner join Bemalugavel b
				on a.idbem = b.idbem
	END
GO

