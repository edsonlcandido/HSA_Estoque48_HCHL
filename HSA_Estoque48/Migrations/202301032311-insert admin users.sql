PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

INSERT INTO usuarios (id, nome, isAdmin) VALUES (1, 'EDSON', 1);
INSERT INTO usuarios (id, nome, isAdmin) VALUES (2, 'CANDIDED', 1);
INSERT INTO usuarios (id, nome, isAdmin) VALUES (3, 'MARIANDA', 1);
INSERT INTO usuarios (id, nome, isAdmin) VALUES (4, 'SILVAMRA', 1);
INSERT INTO usuarios (id, nome, isAdmin) VALUES (5, 'BRAGACAS', 1);

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;