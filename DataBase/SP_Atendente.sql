IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_AtendenteInserir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_AtendenteInserir]
GO

CREATE PROCEDURE [dbo].[TGDB_AtendenteInserir]									
	@nome varchar(70)
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Atendente.sql
	Objetivo..........: Inserir um Atendente
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_AtendenteInserir]

	*/

	BEGIN
		INSERT INTO [dbo].[Atendente] (nome)
			VALUES (@nome)									
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_AtendenteEditar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_AtendenteEditar]
GO

CREATE PROCEDURE [dbo].[TGDB_AtendenteEditar]				
	@idaten int,
	@nome varchar(70) 

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Atendente.sql
	Objetivo..........: Editar um Atendente
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_AtendenteEditar]

	*/

	BEGIN
		update Atendente 
			set nome = @nome				
			where idaten = @idaten
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_AtendenteExcluir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_AtendenteExcluir]
GO

CREATE PROCEDURE [dbo].[TGDB_AtendenteExcluir]				
	@idaten int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Atendente.sql
	Objetivo..........: Excluir um Atendente
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_AtendenteExcluir]

	*/

	BEGIN
		delete Atendente
			where idaten = @idaten									
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_AtendenteListar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_AtendenteListar]
GO

CREATE PROCEDURE [dbo].[TGDB_AtendenteListar]					
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Atendente.sql
	Objetivo..........: Excluir um Atendente
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_AtendenteListar]

	*/

	BEGIN
		select	nome,
				idaten
			from Atendente
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_AtendenteSelecionar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_AtendenteSelecionar]
GO

CREATE PROCEDURE [dbo].[TGDB_AtendenteSelecionar]					
	@idaten int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Atendente.sql
	Objetivo..........: Selecionar um Atendente
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_AtendenteSelecionar] 1

	*/

	BEGIN
		select	nome,
				idaten
			from Atendente
			where idaten = @idaten
	END
GO
