

/****************** RESETAR BANCO DE DADOS ******************/
IF (@Reset = 1) BEGIN
	DELETE [PrevisaoClima]
	DELETE [Cidade]
	DELETE [Estado]
END



/****************** ADICIONAR ESTADOS *****************/

-- RS --
INSERT INTO [Estado] (Id, Nome, UF)
VALUES (1, 'Rio Grande do Sul', 'RS');

-- SP --
INSERT INTO [Estado] (Id, Nome, UF)
VALUES (2, 'São Paulo', 'SP');

-- RJ --
INSERT INTO [Estado] (Id, Nome, UF)
VALUES (3, 'Rio de Janeiro', 'RJ');



/***************** ADICIONAR CIDADES ******************/

-- RS --
INSERT INTO [Cidade] (Id, EstadoId, Nome)
VALUES (1, 1, 'Porto Alegre')

INSERT INTO [Cidade] (Id, EstadoId, Nome)
VALUES (2, 1, 'Gramado')

INSERT INTO [Cidade] (Id, EstadoId, Nome)
VALUES (3, 1, 'São José dos Ausentes')


-- SP --
INSERT INTO [Cidade] (Id, EstadoId, Nome)
VALUES (4, 2, 'São Paulo')

INSERT INTO [Cidade] (Id, EstadoId, Nome)
VALUES (5, 2, 'São Bernardo do Campo')

INSERT INTO [Cidade] (Id, EstadoId, Nome)
VALUES (6, 2, 'Guarulhos')


-- RJ --
INSERT INTO [Cidade] (Id, EstadoId, Nome)
VALUES (7, 3, 'Rio de Janeiro')

INSERT INTO [Cidade] (Id, EstadoId, Nome)
VALUES (8, 3, 'Niterói')

INSERT INTO [Cidade] (Id, EstadoId, Nome)
VALUES (9, 3, 'Petrópolis')