
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/22/2022 18:04:44
-- Generated from EDMX file: D:\Escola\2º Semestre\Dev de Apps\Github\DA\projetoDA\da_pl2_projeto\da_pl2_projeto\GereRestaurante.edmx
-- --------------------------------------------------
CREATE DATABASE [RestGest];
SET QUOTED_IDENTIFIER OFF;
GO
USE [RestGest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MetodoPagamentoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentos] DROP CONSTRAINT [FK_MetodoPagamentoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_PagamentoPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentos] DROP CONSTRAINT [FK_PagamentoPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoEstado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_PedidoEstado];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_PedidoCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_TrabalhadorPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_TrabalhadorPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_MoradaPessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas] DROP CONSTRAINT [FK_MoradaPessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteTrabalhador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_RestauranteTrabalhador];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantePedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_RestaurantePedido];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Restaurantes] DROP CONSTRAINT [FK_RestauranteMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuRestaurante_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuRestaurante] DROP CONSTRAINT [FK_ItemMenuRestaurante_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuRestaurante_Restaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuRestaurante] DROP CONSTRAINT [FK_ItemMenuRestaurante_Restaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuPedido_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuPedido] DROP CONSTRAINT [FK_ItemMenuPedido_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuPedido_Pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuPedido] DROP CONSTRAINT [FK_ItemMenuPedido_Pedido];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItensMenu] DROP CONSTRAINT [FK_CategoriaItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Trabalhador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_Trabalhador_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MetodosPagamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetodosPagamento];
GO
IF OBJECT_ID(N'[dbo].[Pagamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagamentos];
GO
IF OBJECT_ID(N'[dbo].[PedidoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidoSet];
GO
IF OBJECT_ID(N'[dbo].[Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estados];
GO
IF OBJECT_ID(N'[dbo].[Pessoas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas];
GO
IF OBJECT_ID(N'[dbo].[Moradas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Moradas];
GO
IF OBJECT_ID(N'[dbo].[Restaurantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurantes];
GO
IF OBJECT_ID(N'[dbo].[ItensMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItensMenu];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Cliente];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Trabalhador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Trabalhador];
GO
IF OBJECT_ID(N'[dbo].[ItemMenuRestaurante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenuRestaurante];
GO
IF OBJECT_ID(N'[dbo].[ItemMenuPedido]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenuPedido];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MetodosPagamento'
CREATE TABLE [dbo].[MetodosPagamento] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MetodoDePagamento] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Pagamentos'
CREATE TABLE [dbo].[Pagamentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(7,2)  NOT NULL,
    [MetodoPagamentoId] int  NOT NULL,
    [PedidoId] int  NOT NULL
);
GO

-- Creating table 'PedidoSet'
CREATE TABLE [dbo].[PedidoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ValorTotal] decimal(7,2)  NOT NULL,
    [EstadoId] int  NOT NULL,
    [ClienteId] int  NOT NULL,
    [TrabalhadorId] int  NOT NULL,
    [RestauranteId] int  NOT NULL
);
GO

-- Creating table 'Estados'
CREATE TABLE [dbo].[Estados] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EstadoInt] int  NOT NULL
);
GO

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telemovel] int  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'Moradas'
CREATE TABLE [dbo].[Moradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Restaurantes'
CREATE TABLE [dbo].[Restaurantes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'ItensMenu'
CREATE TABLE [dbo].[ItensMenu] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fotografia] varbinary(max)  NULL,
    [Ingredientes] nvarchar(max)  NOT NULL,
    [Preco] decimal(7,2)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL,
    [CategoriaId] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [TotalGasto] decimal(7,2)  NOT NULL,
    [NumContribuinte] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Trabalhador'
CREATE TABLE [dbo].[Pessoas_Trabalhador] (
    [Salario] decimal(7,2)  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [RestauranteId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenuRestaurante'
CREATE TABLE [dbo].[ItemMenuRestaurante] (
    [ItemMenuRestaurante_Restaurante_Id] int  NOT NULL,
    [Restaurante_Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenuPedido'
CREATE TABLE [dbo].[ItemMenuPedido] (
    [ItemMenu_Id] int  NOT NULL,
    [Pedido_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MetodosPagamento'
ALTER TABLE [dbo].[MetodosPagamento]
ADD CONSTRAINT [PK_MetodosPagamento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [PK_Pagamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [PK_PedidoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Estados'
ALTER TABLE [dbo].[Estados]
ADD CONSTRAINT [PK_Estados]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Moradas'
ALTER TABLE [dbo].[Moradas]
ADD CONSTRAINT [PK_Moradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [PK_Restaurantes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItensMenu'
ALTER TABLE [dbo].[ItensMenu]
ADD CONSTRAINT [PK_ItensMenu]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [PK_Pessoas_Trabalhador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ItemMenuRestaurante_Restaurante_Id], [Restaurante_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [PK_ItemMenuRestaurante]
    PRIMARY KEY CLUSTERED ([ItemMenuRestaurante_Restaurante_Id], [Restaurante_Id] ASC);
GO

-- Creating primary key on [ItemMenu_Id], [Pedido_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [PK_ItemMenuPedido]
    PRIMARY KEY CLUSTERED ([ItemMenu_Id], [Pedido_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MetodoPagamentoId] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [FK_MetodoPagamentoPagamento]
    FOREIGN KEY ([MetodoPagamentoId])
    REFERENCES [dbo].[MetodosPagamento]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MetodoPagamentoPagamento'
CREATE INDEX [IX_FK_MetodoPagamentoPagamento]
ON [dbo].[Pagamentos]
    ([MetodoPagamentoId]);
GO

-- Creating foreign key on [PedidoId] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [FK_PagamentoPedido]
    FOREIGN KEY ([PedidoId])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoPedido'
CREATE INDEX [IX_FK_PagamentoPedido]
ON [dbo].[Pagamentos]
    ([PedidoId]);
GO

-- Creating foreign key on [EstadoId] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_PedidoEstado]
    FOREIGN KEY ([EstadoId])
    REFERENCES [dbo].[Estados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoEstado'
CREATE INDEX [IX_FK_PedidoEstado]
ON [dbo].[PedidoSet]
    ([EstadoId]);
GO

-- Creating foreign key on [ClienteId] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_PedidoCliente]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoCliente'
CREATE INDEX [IX_FK_PedidoCliente]
ON [dbo].[PedidoSet]
    ([ClienteId]);
GO

-- Creating foreign key on [TrabalhadorId] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_TrabalhadorPedido]
    FOREIGN KEY ([TrabalhadorId])
    REFERENCES [dbo].[Pessoas_Trabalhador]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhadorPedido'
CREATE INDEX [IX_FK_TrabalhadorPedido]
ON [dbo].[PedidoSet]
    ([TrabalhadorId]);
GO

-- Creating foreign key on [Morada_Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [FK_MoradaPessoa]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MoradaPessoa'
CREATE INDEX [IX_FK_MoradaPessoa]
ON [dbo].[Pessoas]
    ([Morada_Id]);
GO

-- Creating foreign key on [RestauranteId] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_RestauranteTrabalhador]
    FOREIGN KEY ([RestauranteId])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteTrabalhador'
CREATE INDEX [IX_FK_RestauranteTrabalhador]
ON [dbo].[Pessoas_Trabalhador]
    ([RestauranteId]);
GO

-- Creating foreign key on [RestauranteId] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_RestaurantePedido]
    FOREIGN KEY ([RestauranteId])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantePedido'
CREATE INDEX [IX_FK_RestaurantePedido]
ON [dbo].[PedidoSet]
    ([RestauranteId]);
GO

-- Creating foreign key on [Morada_Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [FK_RestauranteMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteMorada'
CREATE INDEX [IX_FK_RestauranteMorada]
ON [dbo].[Restaurantes]
    ([Morada_Id]);
GO

-- Creating foreign key on [ItemMenuRestaurante_Restaurante_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [FK_ItemMenuRestaurante_ItemMenu]
    FOREIGN KEY ([ItemMenuRestaurante_Restaurante_Id])
    REFERENCES [dbo].[ItensMenu]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Restaurante_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [FK_ItemMenuRestaurante_Restaurante]
    FOREIGN KEY ([Restaurante_Id])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuRestaurante_Restaurante'
CREATE INDEX [IX_FK_ItemMenuRestaurante_Restaurante]
ON [dbo].[ItemMenuRestaurante]
    ([Restaurante_Id]);
GO

-- Creating foreign key on [ItemMenu_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_ItemMenu]
    FOREIGN KEY ([ItemMenu_Id])
    REFERENCES [dbo].[ItensMenu]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Pedido_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_Pedido]
    FOREIGN KEY ([Pedido_Id])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuPedido_Pedido'
CREATE INDEX [IX_FK_ItemMenuPedido_Pedido]
ON [dbo].[ItemMenuPedido]
    ([Pedido_Id]);
GO

-- Creating foreign key on [CategoriaId] in table 'ItensMenu'
ALTER TABLE [dbo].[ItensMenu]
ADD CONSTRAINT [FK_CategoriaItemMenu]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaItemMenu'
CREATE INDEX [IX_FK_CategoriaItemMenu]
ON [dbo].[ItensMenu]
    ([CategoriaId]);
GO

-- Creating foreign key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------