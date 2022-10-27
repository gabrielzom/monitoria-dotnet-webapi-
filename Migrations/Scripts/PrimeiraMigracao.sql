CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `jogo` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `nome` varchar(40) CHARACTER SET utf8mb4 NOT NULL,
    `valor` DECIMAL(10,2) NOT NULL,
    `criado_em` DATETIME NOT NULL,
    `atualizado_em` DATETIME NULL,
    `criado_por` int NOT NULL,
    `atualizado_por` int NULL,
    CONSTRAINT `id` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20221027201559_PrimeiraMigracao', '6.0.10');

COMMIT;

