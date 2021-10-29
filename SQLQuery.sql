CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL , 
    [Name] VARCHAR(50) NOT NULL, 
    [Age] SMALLINT NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id]) 
)


select * from

[dbo].[Table] 

where Age=34 or name='dhoni'

insert into [dbo].[Table] 
values (2,'rohit',34,'76565')
