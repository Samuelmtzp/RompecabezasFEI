
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/16/2023 14:08:46
-- Generated from EDMX file: C:\Users\samue\OneDrive - Universidad Veracruzana\UV\Semestre 5\Tecnologías\RompecabezasFei\ServidorRompecabezasFei\Datos\ModeloDatosRompecabezasFei.edmx
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
IF OBJECT_ID(N'[dbo].[FK_JugadorOrigen_SolicitudAmistad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SolicitudAmistad] DROP CONSTRAINT [FK_JugadorOrigen_SolicitudAmistad];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorDestino_SolicitudAmistad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SolicitudAmistad] DROP CONSTRAINT [FK_JugadorDestino_SolicitudAmistad];
GO
IF OBJECT_ID(N'[dbo].[FK_Jugador1Amigo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Amigo] DROP CONSTRAINT [FK_Jugador1Amigo];
GO
IF OBJECT_ID(N'[dbo].[FK_Jugador2Amigo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Amigo] DROP CONSTRAINT [FK_Jugador2Amigo];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorSala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sala] DROP CONSTRAINT [FK_JugadorSala];
GO
IF OBJECT_ID(N'[dbo].[FK_SalaPartida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Partida] DROP CONSTRAINT [FK_SalaPartida];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorJugador_Partida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jugador_Partida] DROP CONSTRAINT [FK_JugadorJugador_Partida];
GO
IF OBJECT_ID(N'[dbo].[FK_PartidaJugador_Partida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jugador_Partida] DROP CONSTRAINT [FK_PartidaJugador_Partida];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[SolicitudAmistad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SolicitudAmistad];
GO
IF OBJECT_ID(N'[dbo].[Cuenta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cuenta];
GO
IF OBJECT_ID(N'[dbo].[Jugador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jugador];
GO
IF OBJECT_ID(N'[dbo].[Amigo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Amigo];
GO
IF OBJECT_ID(N'[dbo].[Sala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sala];
GO
IF OBJECT_ID(N'[dbo].[Partida]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Partida];
GO
IF OBJECT_ID(N'[dbo].[Jugador_Partida]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jugador_Partida];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SolicitudAmistad'
CREATE TABLE [dbo].[SolicitudAmistad] (
    [Estado] int  NOT NULL,
    [FechaEnvioSolicitud] nvarchar(max)  NOT NULL,
    [IdJugadorOrigen] int  NOT NULL,
    [IdJugadorDestino] int  NOT NULL
);
GO

-- Creating table 'Cuenta'
CREATE TABLE [dbo].[Cuenta] (
    [IdCuenta] int IDENTITY(1,1) NOT NULL,
    [Correo] nvarchar(max)  NOT NULL,
    [Contrasena] nvarchar(max)  NOT NULL,
    [Jugador_IdJugador] int  NOT NULL
);
GO

-- Creating table 'Jugador'
CREATE TABLE [dbo].[Jugador] (
    [IdJugador] int IDENTITY(1,1) NOT NULL,
    [NombreJugador] nvarchar(max)  NOT NULL,
    [NumeroAvatar] smallint  NOT NULL
);
GO

-- Creating table 'Amigo'
CREATE TABLE [dbo].[Amigo] (
    [IdAmigo] int IDENTITY(1,1) NOT NULL,
    [IdJugador1] int  NOT NULL,
    [IdJugador2] int  NOT NULL
);
GO

-- Creating table 'Sala'
CREATE TABLE [dbo].[Sala] (
    [IdSala] int IDENTITY(1,1) NOT NULL,
    [Codigo] int  NOT NULL,
    [MaximoJugadores] int  NOT NULL,
    [MinimoJugadores] int  NOT NULL,
    [IdAnfitrion] int  NOT NULL
);
GO

-- Creating table 'Partida'
CREATE TABLE [dbo].[Partida] (
    [IdPartida] int IDENTITY(1,1) NOT NULL,
    [Dificultad] int  NOT NULL,
    [IdSala] int  NOT NULL
);
GO

-- Creating table 'Jugador_Partida'
CREATE TABLE [dbo].[Jugador_Partida] (
    [Puntaje] int  NOT NULL,
    [IdJugador] int  NOT NULL,
    [IdPartida] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdJugadorOrigen], [IdJugadorDestino] in table 'SolicitudAmistad'
ALTER TABLE [dbo].[SolicitudAmistad]
ADD CONSTRAINT [PK_SolicitudAmistad]
    PRIMARY KEY CLUSTERED ([IdJugadorOrigen], [IdJugadorDestino] ASC);
GO

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

-- Creating primary key on [IdAmigo] in table 'Amigo'
ALTER TABLE [dbo].[Amigo]
ADD CONSTRAINT [PK_Amigo]
    PRIMARY KEY CLUSTERED ([IdAmigo] ASC);
GO

-- Creating primary key on [IdSala] in table 'Sala'
ALTER TABLE [dbo].[Sala]
ADD CONSTRAINT [PK_Sala]
    PRIMARY KEY CLUSTERED ([IdSala] ASC);
GO

-- Creating primary key on [IdPartida] in table 'Partida'
ALTER TABLE [dbo].[Partida]
ADD CONSTRAINT [PK_Partida]
    PRIMARY KEY CLUSTERED ([IdPartida] ASC);
GO

-- Creating primary key on [IdPartida], [IdJugador] in table 'Jugador_Partida'
ALTER TABLE [dbo].[Jugador_Partida]
ADD CONSTRAINT [PK_Jugador_Partida]
    PRIMARY KEY CLUSTERED ([IdPartida], [IdJugador] ASC);
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
ADD CONSTRAINT [FK_JugadorOrigen_SolicitudAmistad]
    FOREIGN KEY ([IdJugadorOrigen])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdJugadorDestino] in table 'SolicitudAmistad'
ALTER TABLE [dbo].[SolicitudAmistad]
ADD CONSTRAINT [FK_JugadorDestino_SolicitudAmistad]
    FOREIGN KEY ([IdJugadorDestino])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorDestino_SolicitudAmistad'
CREATE INDEX [IX_FK_JugadorDestino_SolicitudAmistad]
ON [dbo].[SolicitudAmistad]
    ([IdJugadorDestino]);
GO

-- Creating foreign key on [IdJugador1] in table 'Amigo'
ALTER TABLE [dbo].[Amigo]
ADD CONSTRAINT [FK_Jugador1Amigo]
    FOREIGN KEY ([IdJugador1])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Jugador1Amigo'
CREATE INDEX [IX_FK_Jugador1Amigo]
ON [dbo].[Amigo]
    ([IdJugador1]);
GO

-- Creating foreign key on [IdJugador2] in table 'Amigo'
ALTER TABLE [dbo].[Amigo]
ADD CONSTRAINT [FK_Jugador2Amigo]
    FOREIGN KEY ([IdJugador2])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Jugador2Amigo'
CREATE INDEX [IX_FK_Jugador2Amigo]
ON [dbo].[Amigo]
    ([IdJugador2]);
GO

-- Creating foreign key on [IdAnfitrion] in table 'Sala'
ALTER TABLE [dbo].[Sala]
ADD CONSTRAINT [FK_JugadorSala]
    FOREIGN KEY ([IdAnfitrion])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorSala'
CREATE INDEX [IX_FK_JugadorSala]
ON [dbo].[Sala]
    ([IdAnfitrion]);
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

-- Creating foreign key on [IdJugador] in table 'Jugador_Partida'
ALTER TABLE [dbo].[Jugador_Partida]
ADD CONSTRAINT [FK_JugadorJugador_Partida]
    FOREIGN KEY ([IdJugador])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorJugador_Partida'
CREATE INDEX [IX_FK_JugadorJugador_Partida]
ON [dbo].[Jugador_Partida]
    ([IdJugador]);
GO

-- Creating foreign key on [IdPartida] in table 'Jugador_Partida'
ALTER TABLE [dbo].[Jugador_Partida]
ADD CONSTRAINT [FK_PartidaJugador_Partida]
    FOREIGN KEY ([IdPartida])
    REFERENCES [dbo].[Partida]
        ([IdPartida])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------