CREATE TABLE usuarios (
    id      INTEGER PRIMARY KEY AUTOINCREMENT
                    UNIQUE,
    nome    TEXT,
    isAdmin BOOLEAN
);