CREATE TABLE IF NOT EXISTS historico (
    dataMovimentacao      DATE,
    usuario               STRING,
    quantidadeMovimentada DOUBLE,
    tipoMovimentacao      STRING,
    produtoId             INTEGER,
    solicitante           STRING,
    pedidoCentroCusto     STRING,
    notaFiscal            STRING,
    obs                   STRING
);
