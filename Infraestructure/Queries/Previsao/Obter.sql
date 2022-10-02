
SELECT 
	TOP(7) *,
	[UF] = ( SELECT [UF] FROM [Estado] WHERE Id = ( SELECT [EstadoId] FROM [Cidade] WHERE Id = [PC].CidadeId )),
	[Cidade] = ( SELECT [Nome] FROM [Cidade] WHERE Id = [PC].CidadeId )
FROM [PrevisaoClima] AS [PC]
WHERE CidadeId = @CidadeId