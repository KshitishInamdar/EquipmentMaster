CREATE TABLE [dbo].[Equipment] (
    [ID]             INT           IDENTITY (1, 1) NOT NULL,
    [NAME]           VARCHAR (30)  NOT NULL,
    [Year]           INT           NOT NULL,
    [Make]           VARCHAR (30)  NOT NULL,
    [EquipmentModel] VARCHAR (30)  NULL,
    [Description]    VARCHAR (100) NULL,
    CONSTRAINT [Equipment_pk] PRIMARY KEY CLUSTERED ([ID] ASC)
);

