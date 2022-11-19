CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `tab_bancodados` (
    `id` int NOT NULL AUTO_INCREMENT,
    `dialeto` varchar(30) CHARACTER SET utf8mb4 NOT NULL,
    `versao` varchar(15) CHARACTER SET utf8mb4 NOT NULL,
    `conexao` varchar(512) CHARACTER SET utf8mb4 NOT NULL,
    `criado_em` DATETIME NOT NULL DEFAULT NOW(),
    `atualizado_em` DATETIME NULL,
    `criado_por` longtext CHARACTER SET utf8mb4 NOT NULL,
    `atualizado_por` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_tab_bancodados` PRIMARY KEY (`id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `tab_generos` (
    `id` int NOT NULL AUTO_INCREMENT,
    `descricao` varchar(40) CHARACTER SET utf8mb4 NOT NULL,
    `criado_em` DATETIME NOT NULL DEFAULT NOW(),
    `atualizado_em` DATETIME NULL,
    `criado_por` longtext CHARACTER SET utf8mb4 NOT NULL,
    `atualizado_por` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `pk_tab_generos` PRIMARY KEY (`id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `tab_permissoes` (
    `id` int NOT NULL AUTO_INCREMENT,
    `nivel` varchar(30) CHARACTER SET utf8mb4 NOT NULL,
    `criado_em` DATETIME NOT NULL DEFAULT NOW(),
    `atualizado_em` DATETIME NULL,
    `criado_por` longtext CHARACTER SET utf8mb4 NOT NULL,
    `atualizado_por` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `pk_tab_permissoes` PRIMARY KEY (`id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `tab_servidores` (
    `id` int NOT NULL AUTO_INCREMENT,
    `nome` varchar(30) CHARACTER SET utf8mb4 NOT NULL,
    `regiao` varchar(30) CHARACTER SET utf8mb4 NOT NULL,
    `ip_publico` varchar(15) CHARACTER SET utf8mb4 NOT NULL,
    `ip_privado` varchar(15) CHARACTER SET utf8mb4 NOT NULL,
    `sistema_operacional` varchar(30) CHARACTER SET utf8mb4 NOT NULL,
    `banco_dados_id` int NOT NULL,
    `criado_em` DATETIME NOT NULL DEFAULT NOW(),
    `atualizado_em` DATETIME NULL,
    `criado_por` longtext CHARACTER SET utf8mb4 NOT NULL,
    `atualizado_por` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_tab_servidores` PRIMARY KEY (`id`),
    CONSTRAINT `FK_tab_servidores_tab_bancodados_banco_dados_id` FOREIGN KEY (`banco_dados_id`) REFERENCES `tab_bancodados` (`id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `tab_jogos` (
    `id` int NOT NULL AUTO_INCREMENT,
    `titulo` varchar(40) CHARACTER SET utf8mb4 NOT NULL,
    `valor` DECIMAL(10,2) NOT NULL,
    `faixa_etaria` int NOT NULL,
    `genero_id` int NOT NULL,
    `criado_em` DATETIME NOT NULL DEFAULT NOW(),
    `atualizado_em` DATETIME NULL,
    `criado_por` longtext CHARACTER SET utf8mb4 NOT NULL,
    `atualizado_por` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_tab_jogos` PRIMARY KEY (`id`),
    CONSTRAINT `FK_tab_jogos_tab_generos_genero_id` FOREIGN KEY (`genero_id`) REFERENCES `tab_generos` (`id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `tab_jogadores` (
    `id` int NOT NULL AUTO_INCREMENT,
    `nome` varchar(30) CHARACTER SET utf8mb4 NOT NULL,
    `sobrenome` varchar(30) CHARACTER SET utf8mb4 NOT NULL,
    `nascimento` DATETIME NOT NULL,
    `email` varchar(80) CHARACTER SET utf8mb4 NOT NULL,
    `usuario` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
    `senha` varchar(512) CHARACTER SET utf8mb4 NOT NULL,
    `moderador` tinyint(1) NULL,
    `gerente` tinyint(1) NULL,
    `suporte` tinyint(1) NULL,
    `desenvolvedor` tinyint(1) NULL,
    `permissao_id` int NOT NULL,
    `criado_em` DATETIME NOT NULL DEFAULT NOW(),
    `atualizado_em` DATETIME NULL,
    `criado_por` longtext CHARACTER SET utf8mb4 NOT NULL,
    `atualizado_por` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_tab_jogadores` PRIMARY KEY (`id`),
    CONSTRAINT `FK_tab_jogadores_tab_permissoes_permissao_id` FOREIGN KEY (`permissao_id`) REFERENCES `tab_permissoes` (`id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `tab_salas` (
    `id` int NOT NULL AUTO_INCREMENT,
    `fechada_em` DATETIME NOT NULL,
    `servidor_id` int NOT NULL,
    `jogo_id` int NOT NULL,
    `criado_em` DATETIME NOT NULL DEFAULT NOW(),
    `atualizado_em` DATETIME NULL,
    `criado_por` longtext CHARACTER SET utf8mb4 NOT NULL,
    `atualizado_por` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_tab_salas` PRIMARY KEY (`id`),
    CONSTRAINT `FK_tab_salas_tab_jogos_jogo_id` FOREIGN KEY (`jogo_id`) REFERENCES `tab_jogos` (`id`) ON DELETE CASCADE,
    CONSTRAINT `FK_tab_salas_tab_servidores_servidor_id` FOREIGN KEY (`servidor_id`) REFERENCES `tab_servidores` (`id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `tab_salajogadores` (
    `id` int NOT NULL AUTO_INCREMENT,
    `sala_id` int NOT NULL,
    `jogador_id` int NOT NULL,
    `criado_em` DATETIME NOT NULL DEFAULT NOW(),
    `atualizado_em` DATETIME NULL,
    `criado_por` longtext CHARACTER SET utf8mb4 NOT NULL,
    `atualizado_por` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_tab_salajogadores` PRIMARY KEY (`id`),
    CONSTRAINT `FK_tab_salajogadores_tab_jogadores_jogador_id` FOREIGN KEY (`jogador_id`) REFERENCES `tab_jogadores` (`id`) ON DELETE CASCADE,
    CONSTRAINT `FK_tab_salajogadores_tab_salas_sala_id` FOREIGN KEY (`sala_id`) REFERENCES `tab_salas` (`id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE INDEX `IX_tab_jogadores_permissao_id` ON `tab_jogadores` (`permissao_id`);

CREATE INDEX `IX_tab_jogos_genero_id` ON `tab_jogos` (`genero_id`);

CREATE INDEX `IX_tab_salajogadores_jogador_id` ON `tab_salajogadores` (`jogador_id`);

CREATE INDEX `IX_tab_salajogadores_sala_id` ON `tab_salajogadores` (`sala_id`);

CREATE INDEX `IX_tab_salas_jogo_id` ON `tab_salas` (`jogo_id`);

CREATE INDEX `IX_tab_salas_servidor_id` ON `tab_salas` (`servidor_id`);

CREATE INDEX `IX_tab_servidores_banco_dados_id` ON `tab_servidores` (`banco_dados_id`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20221031034705_PrimeiraMigracao', '6.0.10');

COMMIT;

START TRANSACTION;

ALTER TABLE `tab_servidores` MODIFY COLUMN `criado_por` VARCHAR(80) CHARACTER SET utf8mb4 NOT NULL DEFAULT 'admin@master';

ALTER TABLE `tab_servidores` MODIFY COLUMN `atualizado_por` varchar(80) CHARACTER SET utf8mb4 NULL;

ALTER TABLE `tab_salas` MODIFY COLUMN `criado_por` VARCHAR(80) CHARACTER SET utf8mb4 NOT NULL DEFAULT 'admin@master';

ALTER TABLE `tab_salas` MODIFY COLUMN `atualizado_por` varchar(80) CHARACTER SET utf8mb4 NULL;

ALTER TABLE `tab_salajogadores` MODIFY COLUMN `criado_por` VARCHAR(80) CHARACTER SET utf8mb4 NOT NULL DEFAULT 'admin@master';

ALTER TABLE `tab_salajogadores` MODIFY COLUMN `atualizado_por` varchar(80) CHARACTER SET utf8mb4 NULL;

ALTER TABLE `tab_permissoes` MODIFY COLUMN `criado_por` VARCHAR(80) CHARACTER SET utf8mb4 NOT NULL DEFAULT 'admin@master';

ALTER TABLE `tab_permissoes` MODIFY COLUMN `atualizado_por` varchar(80) CHARACTER SET utf8mb4 NULL;

ALTER TABLE `tab_jogos` MODIFY COLUMN `criado_por` VARCHAR(80) CHARACTER SET utf8mb4 NOT NULL DEFAULT 'admin@master';

ALTER TABLE `tab_jogos` MODIFY COLUMN `atualizado_por` varchar(80) CHARACTER SET utf8mb4 NULL;

ALTER TABLE `tab_jogadores` MODIFY COLUMN `criado_por` VARCHAR(80) CHARACTER SET utf8mb4 NOT NULL DEFAULT 'admin@master';

ALTER TABLE `tab_jogadores` MODIFY COLUMN `atualizado_por` varchar(80) CHARACTER SET utf8mb4 NULL;

ALTER TABLE `tab_generos` MODIFY COLUMN `criado_por` VARCHAR(80) CHARACTER SET utf8mb4 NOT NULL DEFAULT 'admin@master';

ALTER TABLE `tab_generos` MODIFY COLUMN `atualizado_por` varchar(80) CHARACTER SET utf8mb4 NULL;

ALTER TABLE `tab_bancodados` MODIFY COLUMN `criado_por` VARCHAR(80) CHARACTER SET utf8mb4 NOT NULL DEFAULT 'admin@master';

ALTER TABLE `tab_bancodados` MODIFY COLUMN `atualizado_por` varchar(80) CHARACTER SET utf8mb4 NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20221031035912_PrimeiraMigracaoCriadoPor', '6.0.10');

COMMIT;

