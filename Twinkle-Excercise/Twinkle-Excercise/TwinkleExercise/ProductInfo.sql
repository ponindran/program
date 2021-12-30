CREATE TABLE [dbo].[ProductInfo] (
    [ProductId]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [ShortDesc]   NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Image]       NVARCHAR (MAX) NULL,
    [CreatedOn]   DATETIME2 (7)  NOT NULL, 
    CONSTRAINT [PK_ProductInfo] PRIMARY KEY ([ProductId])
);