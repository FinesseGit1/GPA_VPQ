CREATE TABLE [dbo].[tbl_Product] (
    [id]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [Code]        NVARCHAR (10)  NULL,
    [Name]        NVARCHAR (100) NULL,
    [Description] NVARCHAR (500) NULL,
    [CrBy]        INT            NULL,
    [CrOn]        DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

