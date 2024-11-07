CREATE DATABASE DictionaryDB;
GO

USE DictionaryDB;
GO

CREATE TABLE Dictionary
(   ID INT PRIMARY KEY IDENTITY(1,1),             -- Auto-incrementing primary key
    English_Word VARCHAR(255) NOT NULL,            -- Column for English word
    Hungarian_Translation VARCHAR(255)             -- Column for Hungarian translation
);
GO

SELECT * FROM Dictionary;
GO