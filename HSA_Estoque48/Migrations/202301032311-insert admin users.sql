PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

INSERT INTO usuarios (nome, isAdmin) VALUES ('EDSON', 1);
INSERT INTO usuarios (nome, isAdmin) VALUES ('CANDIDED', 1);

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;