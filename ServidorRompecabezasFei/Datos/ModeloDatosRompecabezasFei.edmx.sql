
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/25/2023 21:09:22
-- Generated from EDMX file: C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Datos\ModeloDatosRompecabezasFei.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RompecabezasFEI];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CuentaJugador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cuenta] DROP CONSTRAINT [FK_CuentaJugador];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorSolicitudAmistad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SolicitudAmistad] DROP CONSTRAINT [FK_JugadorSolicitudAmistad];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorSolicitudAmistad1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SolicitudAmistad] DROP CONSTRAINT [FK_JugadorSolicitudAmistad1];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorAmistad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Amistad] DROP CONSTRAINT [FK_JugadorAmistad];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorAmistad1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Amistad] DROP CONSTRAINT [FK_JugadorAmistad1];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorResultadoPartida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResultadoPartida] DROP CONSTRAINT [FK_JugadorResultadoPartida];
GO
IF OBJECT_ID(N'[dbo].[FK_SalaPartida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Partida] DROP CONSTRAINT [FK_SalaPartida];
GO
IF OBJECT_ID(N'[dbo].[FK_PartidaResultadoPartida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResultadoPartida] DROP CONSTRAINT [FK_PartidaResultadoPartida];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorSala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sala] DROP CONSTRAINT [FK_JugadorSala];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cuenta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cuenta];
GO
IF OBJECT_ID(N'[dbo].[Jugador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jugador];
GO
IF OBJECT_ID(N'[dbo].[SolicitudAmistad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SolicitudAmistad];
GO
IF OBJECT_ID(N'[dbo].[Amistad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Amistad];
GO
IF OBJECT_ID(N'[dbo].[Sala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sala];
GO
IF OBJECT_ID(N'[dbo].[ResultadoPartida]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResultadoPartida];
GO
IF OBJECT_ID(N'[dbo].[Partida]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Partida];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cuenta'
CREATE TABLE [dbo].[Cuenta] (
    [IdCuenta] int IDENTITY(1,1) NOT NULL,
    [Correo] nvarchar(65)  NOT NULL,
    [Contrasena] nchar(128)  NOT NULL,
    [Jugador_IdJugador] int  NOT NULL
);
GO

-- Creating table 'Jugador'
CREATE TABLE [dbo].[Jugador] (
    [IdJugador] int IDENTITY(1,1) NOT NULL,
    [NombreJugador] nvarchar(15)  NOT NULL,
    [NumeroAvatar] int  NOT NULL
);
GO

-- Creating table 'SolicitudAmistad'
CREATE TABLE [dbo].[SolicitudAmistad] (
    [IdJugadorOrigen] int  NOT NULL,
    [IdJugadorDestino] int  NOT NULL
);
GO

-- Creating table 'Amistad'
CREATE TABLE [dbo].[Amistad] (
    [IdJugadorA] int  NOT NULL,
    [IdJugadorB] int  NOT NULL
);
GO

-- Creating table 'Sala'
CREATE TABLE [dbo].[Sala] (
    [IdSala] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(36)  NOT NULL,
    [MaximoJugadores] int  NOT NULL,
    [MinimoJugadores] int  NOT NULL
);
GO

-- Creating table 'ResultadoPartida'
CREATE TABLE [dbo].[ResultadoPartida] (
    [IdJugador] int  NOT NULL,
    [IdPartida] int  NOT NULL,
    [Puntaje] int  NOT NULL,
    [EsGanador] bit  NOT NULL
);
GO

-- Creating table 'Partida'
CREATE TABLE [dbo].[Partida] (
    [IdPartida] int IDENTITY(1,1) NOT NULL,
    [IdSala] int  NOT NULL,
    [Dificultad] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCuenta] in table 'Cuenta'
ALTER TABLE [dbo].[Cuenta]
ADD CONSTRAINT [PK_Cuenta]
    PRIMARY KEY CLUSTERED ([IdCuenta] ASC);
GO

-- Creating primary key on [IdJugador] in table 'Jugador'
ALTER TABLE [dbo].[Jugador]
ADD CONSTRAINT [PK_Jugador]
    PRIMARY KEY CLUSTERED ([IdJugador] ASC);
GO

-- Creating primary key on [IdJugadorOrigen], [IdJugadorDestino] in table 'SolicitudAmistad'
ALTER TABLE [dbo].[SolicitudAmistad]
ADD CONSTRAINT [PK_SolicitudAmistad]
    PRIMARY KEY CLUSTERED ([IdJugadorOrigen], [IdJugadorDestino] ASC);
GO

-- Creating primary key on [IdJugadorA], [IdJugadorB] in table 'Amistad'
ALTER TABLE [dbo].[Amistad]
ADD CONSTRAINT [PK_Amistad]
    PRIMARY KEY CLUSTERED ([IdJugadorA], [IdJugadorB] ASC);
GO

-- Creating primary key on [IdSala] in table 'Sala'
ALTER TABLE [dbo].[Sala]
ADD CONSTRAINT [PK_Sala]
    PRIMARY KEY CLUSTERED ([IdSala] ASC);
GO

-- Creating primary key on [IdJugador], [IdPartida] in table 'ResultadoPartida'
ALTER TABLE [dbo].[ResultadoPartida]
ADD CONSTRAINT [PK_ResultadoPartida]
    PRIMARY KEY CLUSTERED ([IdJugador], [IdPartida] ASC);
GO

-- Creating primary key on [IdPartida] in table 'Partida'
ALTER TABLE [dbo].[Partida]
ADD CONSTRAINT [PK_Partida]
    PRIMARY KEY CLUSTERED ([IdPartida] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Jugador_IdJugador] in table 'Cuenta'
ALTER TABLE [dbo].[Cuenta]
ADD CONSTRAINT [FK_CuentaJugador]
    FOREIGN KEY ([Jugador_IdJugador])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CuentaJugador'
CREATE INDEX [IX_FK_CuentaJugador]
ON [dbo].[Cuenta]
    ([Jugador_IdJugador]);
GO

-- Creating foreign key on [IdJugadorOrigen] in table 'SolicitudAmistad'
ALTER TABLE [dbo].[SolicitudAmistad]
ADD CONSTRAINT [FK_JugadorSolicitudAmistad]
    FOREIGN KEY ([IdJugadorOrigen])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdJugadorDestino] in table 'SolicitudAmistad'
ALTER TABLE [dbo].[SolicitudAmistad]
ADD CONSTRAINT [FK_JugadorSolicitudAmistad1]
    FOREIGN KEY ([IdJugadorDestino])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorSolicitudAmistad1'
CREATE INDEX [IX_FK_JugadorSolicitudAmistad1]
ON [dbo].[SolicitudAmistad]
    ([IdJugadorDestino]);
GO

-- Creating foreign key on [IdJugadorA] in table 'Amistad'
ALTER TABLE [dbo].[Amistad]
ADD CONSTRAINT [FK_JugadorAmistad]
    FOREIGN KEY ([IdJugadorA])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdJugadorB] in table 'Amistad'
ALTER TABLE [dbo].[Amistad]
ADD CONSTRAINT [FK_JugadorAmistad1]
    FOREIGN KEY ([IdJugadorB])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorAmistad1'
CREATE INDEX [IX_FK_JugadorAmistad1]
ON [dbo].[Amistad]
    ([IdJugadorB]);
GO

-- Creating foreign key on [IdJugador] in table 'ResultadoPartida'
ALTER TABLE [dbo].[ResultadoPartida]
ADD CONSTRAINT [FK_JugadorResultadoPartida]
    FOREIGN KEY ([IdJugador])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdSala] in table 'Partida'
ALTER TABLE [dbo].[Partida]
ADD CONSTRAINT [FK_SalaPartida]
    FOREIGN KEY ([IdSala])
    REFERENCES [dbo].[Sala]
        ([IdSala])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalaPartida'
CREATE INDEX [IX_FK_SalaPartida]
ON [dbo].[Partida]
    ([IdSala]);
GO

-- Creating foreign key on [IdPartida] in table 'ResultadoPartida'
ALTER TABLE [dbo].[ResultadoPartida]
ADD CONSTRAINT [FK_PartidaResultadoPartida]
    FOREIGN KEY ([IdPartida])
    REFERENCES [dbo].[Partida]
        ([IdPartida])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PartidaResultadoPartida'
CREATE INDEX [IX_FK_PartidaResultadoPartida]
ON [dbo].[ResultadoPartida]
    ([IdPartida]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------