-- CIDADE --
DECLARE @CityID INT = 6;

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

-------------------- Guarulhos --------------------

-- Dia 1:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day1, 'Chuvoso', 14, 23);

---- Dia 2:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day2, 'Ensolarado', 12, 25);

---- Dia 3:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day3, 'Chuvoso', 13, 21);

-- Dia 4:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day4, 'Chuvoso', 12, 20);

-- Dia 5:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day5, 'Nublado', 13, 23);

-- Dia 6:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day6, 'Tempestuoso', 13, 29);

-- Dia 7:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day7, 'Ensolarado', 15, 23);

-- Dia 8:
INSERT INTO PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
VALUES (@CityID, @Day8, 'Ensolarado', 17, 26);