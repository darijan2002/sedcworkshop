CREATE TABLE [dbo].[MovieGenre]
(
	[MovieId] INT NOT NULL,
	[GenreId] INT NOT NULL,
 
	constraint [PK_MovieGenre] 
		primary key ([MovieId], [GenreId]),
	CONSTRAINT [FK_MovieGenre_Movie] 
		FOREIGN KEY ([MovieId]) 
		REFERENCES [Movie]([MovieId]),
    CONSTRAINT [FK_MovieGenre_Genre] 
		FOREIGN KEY ([GenreId]) 
		REFERENCES [Genre]([GenreId]),
)
