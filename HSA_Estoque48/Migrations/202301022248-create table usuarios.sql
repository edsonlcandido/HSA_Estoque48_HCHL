CREATE TABLE IF NOT EXISTS usuarios (
    id      INTEGER PRIMARY KEY AUTOINCREMENT
                    UNIQUE,
    nome    TEXT,
    isAdmin BOOLEAN
);