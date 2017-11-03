CREATE TABLE [dbo].[Client] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [Clients]     NVARCHAR (MAX)  NULL,
    [Description] NVARCHAR (MAX)  NULL,
    [Finish]      DATETIME2 (7)   NOT NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [Start]       DATETIME2 (7)   NOT NULL,
    [Stage] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([ID] ASC)
);

