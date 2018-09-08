CREATE TABLE `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `Usuarios` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nome` varchar(100) NULL,
    `Celular` longtext NULL,
    `DataNascimento` datetime(6) NOT NULL,
    `Email` varchar(100) NULL,
    CONSTRAINT `PK_Usuarios` PRIMARY KEY (`Id`)
);

CREATE TABLE `Pedidos` (
    `Id` char(36) NOT NULL,
    `DataCompra` datetime(6) NOT NULL,
    `UsuarioId` int NULL,
    CONSTRAINT `PK_Pedidos` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Pedidos_Usuarios_UsuarioId` FOREIGN KEY (`UsuarioId`) REFERENCES `Usuarios` (`Id`) ON DELETE NO ACTION
);

CREATE TABLE `Produtos` (
    `Id` char(36) NOT NULL,
    `Preco` double NOT NULL,
    `Descricao` longtext NULL,
    `Nome` longtext NULL,
    `SKU` longtext NULL,
    `PedidoId` char(36) NULL,
    CONSTRAINT `PK_Produtos` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Produtos_Pedidos_PedidoId` FOREIGN KEY (`PedidoId`) REFERENCES `Pedidos` (`Id`) ON DELETE NO ACTION
);

CREATE INDEX `IX_Pedidos_UsuarioId` ON `Pedidos` (`UsuarioId`);

CREATE INDEX `IX_Produtos_PedidoId` ON `Produtos` (`PedidoId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20180904181325_PrimeiraVersao', '2.1.1-rtm-30846');

