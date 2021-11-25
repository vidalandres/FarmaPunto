CREATE TABLE [dbo].[TablaMedicamentos] (
    [CodigoMedicamento] VARCHAR (50) NOT NULL,
    [NombreMedicamento] VARCHAR (50) NOT NULL,
    [Cantidad]          INT          NOT NULL,
    [ValorUnitario]     DECIMAL (18) NOT NULL,
    [Detalle]           VARCHAR (50) NOT NULL,
    [Proveedor]         VARCHAR (50) NOT NULL,
    [Impuesto] DECIMAL NOT NULL, 
    [Iva] DECIMAL NOT NULL, 
    [PrecioVenta] DECIMAL NOT NULL, 
    PRIMARY KEY CLUSTERED ([CodigoMedicamento] ASC)
);

