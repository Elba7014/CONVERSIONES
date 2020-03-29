CREATE TABLE [dbo].[Detalle de Venta] (
    [IdProductos]      INT         NOT NULL,
    [Descripción]      NCHAR (100) NOT NULL,
    [Unidades]         NCHAR (500) NOT NULL,
    [Precio Unitario]  NCHAR (10)  NOT NULL,
    [Fecha de comprar] DATE        NOT NULL,
    [Precio total]     NCHAR (10)  NOT NULL,
    [IdEmpleado]       INT         NOT NULL,
    [IdFactura] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([IdProductos]),
    CONSTRAINT [Id_Empleado] FOREIGN KEY ([IdEmpleado]) REFERENCES [dbo].[Empleados] ([IdEmpleado]), 



);

