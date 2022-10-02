DECLARE @MaisQuentes TABLE (Id INT, CidadeId INT, TemperaturaMaxima NUMERIC(3, 1));
INSERT INTO @MaisQuentes
SELECT DISTINCT TOP(@parameter) Id, CidadeId, MAX(TemperaturaMaxima)
FROM PrevisaoClima
WHERE DataPrevisao =  CONVERT(DATE, GETDATE())
GROUP BY Id, CidadeId
ORDER BY MAX(TemperaturaMaxima) DESC, CidadeId, Id

SELECT 	
	[MQ].Id,
	[MQ].TemperaturaMaxima,
	[TemperaturaMinima] = ( SELECT [TemperaturaMinima] FROM [PrevisaoClima] WHERE Id = [MQ].Id ),
	[Clima] = ( SELECT [Clima] FROM [PrevisaoClima] WHERE Id = [MQ].Id ),
	[DataPrevisao] = ( SELECT [DataPrevisao] FROM [PrevisaoClima] WHERE Id = [MQ].Id ),
	[UF] = ( SELECT [UF] FROM [Estado] WHERE Id = ( SELECT [EstadoId] FROM [Cidade] WHERE Id = [MQ].CidadeId )),
	[Estado] = ( SELECT [Nome] FROM [Estado] WHERE Id = ( SELECT [EstadoId] FROM [Cidade] WHERE Id = [MQ].CidadeId )),
	[Cidade] = ( SELECT [Nome] FROM [Cidade] WHERE Id = [MQ].CidadeId )
	FROM @MaisQuentes AS [MQ]
ORDER BY TemperaturaMaxima DESC, [Cidade] ASC