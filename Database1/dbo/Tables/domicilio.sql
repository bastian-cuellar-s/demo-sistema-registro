CREATE TABLE [dbo].[domicilio] (
    [id_domicilio]    INT           IDENTITY (1, 1) NOT NULL,
    [direcc]          VARCHAR (200) NOT NULL,
    [razon]           VARCHAR (100) NOT NULL,
    [fk_id_demandado] INT           NOT NULL,
    CONSTRAINT [PK_domicilio] PRIMARY KEY CLUSTERED ([id_domicilio] ASC),
    CONSTRAINT [fk_id_demandado] FOREIGN KEY ([fk_id_demandado]) REFERENCES [dbo].[demandado] ([id_demandado]) ON DELETE CASCADE
);

