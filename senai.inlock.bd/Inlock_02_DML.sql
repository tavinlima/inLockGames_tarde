USE inlock_games_tarde;
GO

INSERT INTO TIPO_USUARIO(titulo)
VALUES ('ADMINISTRADOR'),('CLIENTE')
GO

INSERT INTO USUARIO(idTipoUsuario, email, senha)
VALUES (1, 'admin@admin.com', 'admin'),(2, 'cliente@cliente.com', 'cliente')
GO

INSERT INTO ESTUDIO(nomeEstudio)
VALUES ('Blizzard'),('Rockstar Studios'),('Square Enix')
GO

INSERT INTO JOGOS(idEstudio, nomeJogo, descricao, dataLancamento, valor)
VALUES (1, 'Diablo 3', '� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�.', '15/05/2012', 'R$ 99,00'), (2, 'Red Dead Redemption II', 'Jogo eletr�nico de a��o-aventura western.', '26/10/2018', 'R$ 120,00')
GO