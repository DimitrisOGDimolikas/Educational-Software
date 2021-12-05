CREATE TABLE [dbo].[Students] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (50) NOT NULL,
    [SecondName] VARCHAR (50) NOT NULL,
    [Score1] INT NOT NULL DEFAULT 0, 
    [Score2] INT NOT NULL DEFAULT 0, 
    [Score3] INT NOT NULL DEFAULT 0, 
    [Score4] INT NOT NULL DEFAULT 0, 
    [Score5] INT NOT NULL DEFAULT 0, 
    [Score6] INT NOT NULL DEFAULT 0, 
    [Score7] INT NOT NULL DEFAULT 0, 
    [Score8] INT NOT NULL DEFAULT 0, 
    [Score9] INT NOT NULL DEFAULT 0, 
    [Score10] INT NOT NULL DEFAULT 0, 
    [Average] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
