CREATE TABLE [dbo].[Inventario] (
    [IdInventario] INT         NOT NULL,
    [IdProductos]  INT         NOT NULL,
    [Unidades]     NCHAR (500) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdInventario] ASC),
    CONSTRAINT [IdInventario] FOREIGN KEY ([IdInventario]) REFERENCES [dbo].[Inventario] ([IdInventario]), 
    CONSTRAINT [idproductos] FOREIGN KEY ([IdProductos]) REFERENCES [dbo].[Detalle de Venta]([IdProductos])
);

