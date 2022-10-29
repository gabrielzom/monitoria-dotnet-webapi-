CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `tab_generos` (
    `id` int NOT NULL AUTO_INCREMENT,
    `descricao` varchar(40) CHARACTER SET utf8mb4 NOT NULL,
    `criado_em` DATETIME NOT NULL,
    `atualizado_em` DATETIME NULL,
    `criado_por` int NOT NULL,
    `atualizado_por` int NULL,
    CONSTRAINT `pk_tab_generos` PRIMARY KEY (`id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `tab_jogos` (
    `id` int NOT NULL AUTO_INCREMENT,
    `titulo` varchar(40) CHARACTER SET utf8mb4 NOT NULL,
    `valor` DECIMAL(10,2) NOT NULL,
    `faixa_etaria` int NOT NULL,
    `genero_id` int NOT NULL,
    `criado_em` DATETIME NOT NULL,
    `atualizado_em` DATETIME NULL,
    `criado_por` int NOT NULL,
    `atualizado_por` int NULL,
    CONSTRAINT `PK_tab_jogos` PRIMARY KEY (`id`),
    CONSTRAINT `FK_tab_jogos_tab_generos_genero_id` FOREIGN KEY (`genero_id`) REFERENCES `tab_generos` (`id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE INDEX `IX_tab_jogos_genero_id` ON `tab_jogos` (`genero_id`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20221029140919_MigracaoJogoGenero', '6.0.10');

COMMIT;

