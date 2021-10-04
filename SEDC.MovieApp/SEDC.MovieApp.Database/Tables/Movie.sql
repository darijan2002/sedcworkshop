﻿CREATE TABLE [dbo].[Movie]
(
	[MovieId] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Title] NVARCHAR(60) NOT NULL,
	[Description] NVARCHAR(150),
	[Year] INT,
	[UserId] INT NOT NULL, 
    CONSTRAINT [FK_Movie_User] FOREIGN KEY ([UserId]) REFERENCES [User]([UserId]),
);

--CREATE CONSTRAINT(