create database Torneio;
use Torneio;

create table Clube(
	idClube int auto_increment primary key,
    nomeClube varchar(50) unique
);

create table Jogador(
	idJogador int auto_increment primary key,
    nomeJogador varchar(50),
    clubeJogador int,
		foreign key(clubeJogador) references Clube(idClube)
);

create table Jogo(
	idJogo int auto_increment primary key,
    clubeCasa int,
		foreign key(clubeCasa) references Clube(idClube),
	clubeFora int,
		foreign key(clubeFora) references Clube(idClube)
);

create table Gol(
	idGol int auto_increment primary key,
    tempoGol int,
    jogadorGol int,
		foreign key(jogadorGol) references Jogador(idJogador),
	jogoGol int,
		foreign key(jogoGol) references Jogo(idJogo)
);



create function GolsCasa(id int) returns int
	return (
		select count(*) from Gol where jogoGol = id and jogadorGol in (select idJogador from Jogador where clubeJogador = (select clubeCasa from Jogo where idJogo = id))
	);

create function GolsFora(id int) returns int
	return (
		select count(*) from Gol where jogoGol = id and jogadorGol in (select idJogador from Jogador where clubeJogador = (select clubeFora from Jogo where idJogo = id))
	);

create function Vitorias(id int) returns int
	return(
		select count(*) from Jogo 
			where (clubeCasa = id and GolsCasa(idJogo) > GolsFora(idJogo)) or (clubeFora = id and GolsCasa(idJogo) < GolsFora(idJogo))
	);

create function Empates(id int) returns int
	return(
		select count(*) from Jogo 
			where (clubeCasa = id and GolsCasa(idJogo) = GolsFora(idJogo)) or (clubeFora = id and GolsCasa(idJogo) = GolsFora(idJogo))
	);

create function Derrotas(id int) returns int
	return(
		select count(*) from Jogo 
			where (clubeCasa = id and GolsCasa(idJogo) < GolsFora(idJogo)) or (clubeFora = id and GolsCasa(idJogo) > GolsFora(idJogo))
	);


select
	idJogo,
	(select nomeClube from Clube where idClube = clubeCasa) as Casa,
	GolsCasa(idJogo) as "Gols casa",
	GolsFora(idJogo) as 'Gols fora',
	(select nomeClube from Clube where idClube = clubeFora) as Fora
from Jogo;

select
	idJogador,
	nomeJogador as Nome,
	(select nomeClube from Clube where idClube = clubeJogador) as Clube,
	(select count(*) from Gol where jogadorGol = idJogador) as Gols
from Jogador order by Gols desc;

select
	idClube, 
	row_number() over(order by Pontos desc) as Posição,
	nomeClube,
	3*Vitorias(idClube) + Empates(idClube) as Pontos,
	(select count(*) from Jogo where clubeCasa = idClube or clubeFora = idClube) as Jogos
from Clube; 


select tempoGol, jogadorGol from Gol where jogoGol = id order by tempoGol;

