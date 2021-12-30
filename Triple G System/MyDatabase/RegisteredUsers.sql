CREATE TABLE [dbo].[RegisteredUsers]
(
	lid int identity (1,1) PRIMARY KEY,
    [emailAddress] VARCHAR(250) NOT NULL, 
    [password] VARCHAR(250) NOT NULL
)
