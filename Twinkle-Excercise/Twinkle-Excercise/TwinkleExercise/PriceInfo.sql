CREATE TABLE [dbo].[PriceInfo] (
    [ProductId] INT           NOT NULL,
    [Price]     FLOAT (53)    NOT NULL,
    [CreatedOn] DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_PriceInfo] PRIMARY KEY CLUSTERED ([ProductId] ASC),
    CONSTRAINT [FK_PriceInfo_ProductInfo_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[ProductInfo] ([ProductId]) ON DELETE CASCADE
);

