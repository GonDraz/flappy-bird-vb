Imports System.Data.SQLite
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class DataCommand
    Public Const CreateDatabase = "
CREATE TABLE user (
    name     TEXT PRIMARY KEY
                  NOT NULL
                  UNIQUE,
    password TEXT NOT NULL
);
CREATE TABLE score (
    name  TEXT    NOT NULL
                  ,
    score INTEGER NOT NULL
);
CREATE TABLE application (
    name  TEXT  UNIQUE,
    save INTEGER (0, 1) DEFAULT (0) 
                        NOT NULL
);

insert into application(name,save) values ('vungochaiha',0)
"
End Class
