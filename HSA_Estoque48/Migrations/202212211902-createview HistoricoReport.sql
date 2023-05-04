CREATE VIEW HistoricoReport AS
    SELECT h.dataMovimentacao,
           h.usuario,
           h.quantidadeMovimentada,
           h.tipoMovimentacao,
           h.produtoId,
           p.descricao,
           h.solicitante,
           h.pedidoCentroCusto,
           h.notaFiscal,
           h.obs
      FROM historico AS h
           JOIN
           produtos AS p ON h.produtoId = p.id;