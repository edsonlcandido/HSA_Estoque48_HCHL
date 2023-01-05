PRAGMA foreign_keys = 0;

CREATE TABLE sqlitestudio_temp_table AS SELECT *
                                          FROM produtos;

DROP TABLE produtos;

CREATE TABLE produtos (
    id               TEXT    DEFAULT (0) 
                             PRIMARY KEY
                             UNIQUE,
    descricao        TEXT    DEFAULT ('PRODUTO SEM CADASTRO'),
    quantidadeMinima REAL    DEFAULT (0),
    quantidadeMaxima REAL    DEFAULT (0),
    quantidadeTotal  REAL    DEFAULT (0),
    leadTime         INTEGER DEFAULT (0),
    tipo             TEXT    DEFAULT ('TBD'),
    unidade          TEXT    DEFAULT ('TBD'),
    localizacao      TEXT    DEFAULT ('ALMOXARIFADO'),
    caixa            TEXT    DEFAULT ('TBD'),
    obs              TEXT    DEFAULT ('') 
);

INSERT INTO produtos (
                         id,
                         descricao,
                         quantidadeMinima,
                         quantidadeMaxima,
                         quantidadeTotal,
                         leadTime,
                         tipo,
                         unidade,
                         localizacao,
                         caixa
                     )
                     SELECT id,
                            descricao,
                            quantidadeMinima,
                            quantidadeMaxima,
                            quantidadeTotal,
                            leadTime,
                            tipo,
                            unidade,
                            localizacao,
                            caixa
                       FROM sqlitestudio_temp_table;

DROP TABLE sqlitestudio_temp_table;

PRAGMA foreign_keys = 1;