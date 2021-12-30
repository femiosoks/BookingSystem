CREATE TABLE [dbo].[Destinations]
(
    lid int identity (1,1) PRIMARY KEY,
    [departing] VARCHAR(250) NOT NULL, 
    [arriving] VARCHAR(250) NOT NULL, 
    [price] DECIMAL NOT NULL,
    [coach] VARCHAR(250) NOT NULL
)

