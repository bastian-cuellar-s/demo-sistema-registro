CREATE TABLE [dbo].[demandado] (
    [id_demandado]  INT          IDENTITY (1, 1) NOT NULL,
    [nombre]        VARCHAR (50) NOT NULL,
    [rut]           VARCHAR (15) NOT NULL,
    [representante] VARCHAR (50) NULL,
    CONSTRAINT [PK_demandado] PRIMARY KEY CLUSTERED ([id_demandado] ASC),
    UNIQUE NONCLUSTERED ([rut] ASC)
);

