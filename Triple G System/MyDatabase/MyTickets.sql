CREATE TABLE [dbo].[MyTickets]
(
	lid int identity (1,1) PRIMARY KEY,
	[emailAddress] VARCHAR(250) NOT NULL, 
	[departing] VARCHAR(250) NOT NULL, 
    [arriving] VARCHAR(250) NOT NULL, 
	[date] VARCHAR(250) NOT NULL,
	[time] VARCHAR(250) NOT NULL,
	[quantity] INT NOT NULL,
	[coach] VARCHAR(250) NOT NULL,
    [price] DECIMAL NOT NULL
    

)
