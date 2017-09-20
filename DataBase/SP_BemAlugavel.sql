IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_BemalugavelInserir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_BemalugavelInserir]
GO

CREATE PROCEDURE [dbo].[TGDB_BemalugavelInserir]									
	@descricao varchar(70), 
	@NumPatrimonio varchar(50),
	@vlaluguel money

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Bemalugavel.sql
	Objetivo..........: Inserir um Bemalugavel
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_BemalugavelInserir]

	*/

	BEGIN
		INSERT INTO [dbo].[Bemalugavel] (descricao, NumPatrimonio, vlaluguel)
			VALUES (@descricao, @NumPatrimonio, @vlaluguel)									
	END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_BemalugavelEditar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_BemalugavelEditar]
GO

CREATE PROCEDURE [dbo].[TGDB_BemalugavelEditar]				
	@idbem int,
	@descricao varchar(70), 
	@NumPatrimonio varchar(50),
	@vlaluguel money 

	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Bemalugavel.sql
	Objetivo..........: Editar um Bemalugavel
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_BemalugavelEditar]

	*/

	BEGIN
		update Bemalugavel
			set descricao = @descricao,
				NumPatrimonio = @NumPatrimonio,
				vlaluguel = @vlaluguel				
			where idbem = @idbem
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_BemalugavelExcluir]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_BemalugavelExcluir]
GO

CREATE PROCEDURE [dbo].[TGDB_BemalugavelExcluir]				
	@idbem int
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Bemalugavel.sql
	Objetivo..........: Excluir um Bemalugavel
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_BemalugavelExcluir]

	*/

	BEGIN
		delete Bemalugavel
			where idbem = @idbem
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TGDB_BemalugavelListar]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[TGDB_BemalugavelListar]
GO

CREATE PROCEDURE [dbo].[TGDB_BemalugavelListar]					
	AS

	/*
	Documentação
	Arquivo Fonte.....: SP_Bemalugavel.sql
	Objetivo..........: Excluir um Bemalugavel
	Autor.............: Rafael Morais
 	Data..............: 19/09/2017
	Ex................: EXEC [dbo].[TGDB_BemalugavelListar]

	*/

	BEGIN
		select	idbem,
				descricao,
				NumPatrimonio,
				vlaluguel
			from Bemalugavel
	END
GO

