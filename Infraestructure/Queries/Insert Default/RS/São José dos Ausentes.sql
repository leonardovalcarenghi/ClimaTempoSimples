-- CIDADE --
DECLARE @CityID INT = 3

-- DIAS --
DECLARE @Today DATETIME = GETDATE();
DECLARE @Day1 DATETIME = @Today;
DECLARE @Day2 DATETIME = DATEADD(DAY, 1, @Today);
DECLARE @Day3 DATETIME = DATEADD(DAY, 2, @Today);
DECLARE @Day4 DATETIME = DATEADD(DAY, 3, @Today);
DECLARE @Day5 DATETIME = DATEADD(DAY, 4, @Today);
DECLARE @Day6 DATETIME = DATEADD(DAY, 5, @Today);
DECLARE @Day7 DATETIME = DATEADD(DAY, 6, @Today);
DECLARE @Day8 DATETIME = DATEADD(DAY, 7, @Today);

-------------------- São José dos Ausentes --------------------

-- Dia 1:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day1, 'Chuvoso', 7, 16);

---- Dia 2:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day2, 'Nublado', 5, 17);

---- Dia 3:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day3, 'Ensolarado', 6, 18);

-- Dia 4:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day4, 'Ensolarado', 6, 19);

-- Dia 5:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day5, 'Ensolarado', 8, 22);

-- Dia 6:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day6, 'Chuvoso', 8, 17);

-- Dia 7:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day7, 'Chuvoso', 12, 22);

-- Dia 8:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day8, 'Chuvoso', 11, 15);