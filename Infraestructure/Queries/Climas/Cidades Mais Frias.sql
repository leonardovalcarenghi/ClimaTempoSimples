
--> OBTER CIDADES MAIS FRIAS HOJE:
DECLARE @MaisFrias TABLE (Id INT, CidadeId INT, TemperaturaMinima NUMERIC(3, 1));
INSERT INTO @MaisFrias
SELECT DISTINCT TOP(@Total) Id, CidadeId, MIN(TemperaturaMinima)
FROM PrevisaoClima
WHERE DataPrevisao = CONVERT(DATE, GETDATE())
GROUP BY Id, CidadeId
ORDER BY MIN(TemperaturaMinima), CidadeId, Id

--> MONTAR DADOS:
SELECT 	
	[MQ].Id,
	[MQ].TemperaturaMinima,
	[TemperaturaMaxima] = ( SELECT [TemperaturaMaxima] FROM [PrevisaoClima] WHERE Id = [MQ].Id ),
	[Clima] = ( SELECT [Clima] FROM [PrevisaoClima] WHERE Id = [MQ].Id ),
	[DataPrevisao] = ( SELECT [DataPrevisao] FROM [PrevisaoClima] WHERE Id = [MQ].Id ),
	[UF] = ( SELECT [UF] FROM [Estado] WHERE Id = ( SELECT [EstadoId] FROM [Cidade] WHERE Id = [MQ].CidadeId )),
	[Cidade] = ( SELECT [Nome] FROM [Cidade] WHERE Id = [MQ].CidadeId )
	FROM @MaisFrias AS [MQ]
ORDER BY TemperaturaMinima, [Cidade] ASC