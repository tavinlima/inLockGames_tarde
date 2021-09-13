USE inlock_games_tarde;
GO

 SELECT * FROM USUARIO;
 GO

 SELECT * FROM ESTUDIO;
 GO

 SELECT * FROM JOGOS;
 GO

 SELECT nomeEstudio, nomeJogo FROM JOGOS
 RIGHT JOIN ESTUDIO
 ON JOGOS.idEstudio = ESTUDIO.idEstudio;
 GO

 SELECT idUsuario, email, senha FROM USUARIO
 WHERE email = 'admin@admin.com' AND senha = 'admin';
 GO

 SELECT idUsuario, email, senha FROM USUARIO
 WHERE email = 'cliente@cliente.com' AND senha = 'cliente';
 GO

 SELECT idJogo, nomeJogo FROM JOGOS 
 WHERE idJogo = 2;
 GO

 SELECT idEstudio, nomeEstudio FROM ESTUDIO
 WHERE idEstudio = 3;
 GO

 SELECT ISNULL(idJogo, 0), ISNULL(JOGOS.idEstudio, 0), ISNULL(nomeEstudio, 'Não cadastrado'), ISNULL(nomeJogo, 'Não cadastrado'), ISNULL(descricao, 'Sem descrição'), ISNULL(dataLancamento, ''), ISNULL(valor, 0)  FROM JOGOS 
 FULL OUTER JOIN ESTUDIO ON JOGOS.idEstudio = ESTUDIO.idEstudio