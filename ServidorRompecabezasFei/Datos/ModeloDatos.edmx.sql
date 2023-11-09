
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/07/2023 23:09:13
-- Generated from EDMX file: C:\Users\samue\OneDrive - Universidad Veracruzana\UV\Semestre 5\Tecnologías\RompecabezasFei\ServidorRompecabezasFei\Datos\ModeloDatos.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cuenta'
CREATE TABLE [dbo].[Cuenta] (
    [Correo] nvarchar(65)  NOT NULL,
    [Contrasena] nvarchar(45)  NOT NULL,
    [Jugador_NombreJugador] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Jugador'
CREATE TABLE [dbo].[Jugador] (
    [NombreJugador] nvarchar(15)  NOT NULL,
    [NumeroAvatar] int  NOT NULL
);
GO

-- Creating table 'SolicitudAmistad'
CREATE TABLE [dbo].[SolicitudAmistad] (
    [NombreJugadorOrigen] nvarchar(15)  NOT NULL,
    [NombreJugadorDestino] nvarchar(15)  NOT NULL,
    [Estado] int  NOT NULL,
    [FechaEnvioSolicitud] datetime  NOT NULL
);
GO

-- Creating table 'Amigo'
CREATE TABLE [dbo].[Amigo] (
    [NombreJugadorA] nvarchar(15)  NOT NULL,
    [NombreJugadorB] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Sala'
CREATE TABLE [dbo].[Sala] (
    [Codigo] nchar(36)  NOT NULL,
    [MaximoJugadores] int  NOT NULL,
    [MinimoJugadores] int  NOT NULL,
    [NombreAnfitrion] nvarchar(15)  NULL
);
GO

-- Creating table 'Partida'
CREATE TABLE [dbo].[Partida] (
    [NumeroPartida] int  NOT NULL,
    [CodigoSala] nchar(36)  NOT NULL,
    [Dificultad] int  NOT NULL
);
GO

-- Creating table 'ResultadoPartida'
CREATE TABLE [dbo].[ResultadoPartida] (
    [NombreJugador] nvarchar(15)  NOT NULL,
    [Puntaje] int  NOT NULL,
    [EsGanador] bit  NOT NULL,
    [NumeroPartida] int  NOT NULL,
    [CodigoSala] nchar(36)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Correo] in table 'Cuenta'
ALTER TABLE [dbo].[Cuenta]
ADD CONSTRAINT [PK_Cuenta]
    PRIMARY KEY CLUSTERED ([Correo] ASC);
GO

-- Creating primary key on [NombreJugador] in table 'Jugador'
ALTER TABLE [dbo].[Jugador]
ADD CONSTRAINT [PK_Jugador]
    PRIMARY KEY CLUSTERED ([NombreJugador] ASC);
GO

-- Creating primary key on [NombreJugadorOrigen], [NombreJugadorDestino] in table 'SolicitudAmistad'
ALTER TABLE [dbo].[SolicitudAmistad]
ADD CONSTRAINT [PK_SolicitudAmistad]
    PRIMARY KEY CLUSTERED ([NombreJugadorOrigen], [NombreJugadorDestino] ASC);
GO

-- Creating primary key on [NombreJugadorA], [NombreJugadorB] in table 'Amigo'
ALTER TABLE [dbo].[Amigo]
ADD CONSTRAINT [PK_Amigo]
    PRIMARY KEY CLUSTERED ([NombreJugadorA], [NombreJugadorB] ASC);
GO

-- Creating primary key on [Codigo] in table 'Sala'
ALTER TABLE [dbo].[Sala]
ADD CONSTRAINT [PK_Sala]
    PRIMARY KEY CLUSTERED ([Codigo] ASC);
GO

-- Creating primary key on [NumeroPartida], [CodigoSala] in table 'Partida'
ALTER TABLE [dbo].[Partida]
ADD CONSTRAINT [PK_Partida]
    PRIMARY KEY CLUSTERED ([NumeroPartida], [CodigoSala] ASC);
GO

-- Creating primary key on [NombreJugador], [NumeroPartida], [CodigoSala] in table 'ResultadoPartida'
ALTER TABLE [dbo].[ResultadoPartida]
ADD CONSTRAINT [PK_ResultadoPartida]
    PRIMARY KEY CLUSTERED ([NombreJugador], [NumeroPartida], [CodigoSala] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Jugador_NombreJugador] in table 'Cuenta'
ALTER TABLE [dbo].[Cuenta]
ADD CONSTRAINT [FK_CuentaJugador]
    FOREIGN KEY ([Jugador_NombreJugador])
    REFERENCES [dbo].[Jugador]
        ([NombreJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CuentaJugador'
CREATE INDEX [IX_FK_CuentaJugador]
ON [dbo].[Cuenta]
    ([Jugador_NombreJugador]);
GO

-- Creating foreign key on [NombreJugadorOrigen] in table 'SolicitudAmistad'
ALTER TABLE [dbo].[SolicitudAmistad]
ADD CONSTRAINT [FK_JugadorSolicitudAmistad]
    FOREIGN KEY ([NombreJugadorOrigen])
    REFERENCES [dbo].[Jugador]
        ([NombreJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NombreJugadorDestino] in table 'SolicitudAmistad'
ALTER TABLE [dbo].[SolicitudAmistad]
ADD CONSTRAINT [FK_JugadorSolicitudAmistad1]
    FOREIGN KEY ([NombreJugadorDestino])
    REFERENCES [dbo].[Jugador]
        ([NombreJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorSolicitudAmistad1'
CREATE INDEX [IX_FK_JugadorSolicitudAmistad1]
ON [dbo].[SolicitudAmistad]
    ([NombreJugadorDestino]);
GO

-- Creating foreign key on [NombreJugadorA] in table 'Amigo'
ALTER TABLE [dbo].[Amigo]
ADD CONSTRAINT [FK_JugadorAmigo]
    FOREIGN KEY ([NombreJugadorA])
    REFERENCES [dbo].[Jugador]
        ([NombreJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NombreJugadorB] in table 'Amigo'
ALTER TABLE [dbo].[Amigo]
ADD CONSTRAINT [FK_JugadorAmigo1]
    FOREIGN KEY ([NombreJugadorB])
    REFERENCES [dbo].[Jugador]
        ([NombreJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorAmigo1'
CREATE INDEX [IX_FK_JugadorAmigo1]
ON [dbo].[Amigo]
    ([NombreJugadorB]);
GO

-- Creating foreign key on [NombreJugador] in table 'ResultadoPartida'
ALTER TABLE [dbo].[ResultadoPartida]
ADD CONSTRAINT [FK_JugadorResultadoPartida]
    FOREIGN KEY ([NombreJugador])
    REFERENCES [dbo].[Jugador]
        ([NombreJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NombreAnfitrion] in table 'Sala'
ALTER TABLE [dbo].[Sala]
ADD CONSTRAINT [FK_JugadorSala]
    FOREIGN KEY ([NombreAnfitrion])
    REFERENCES [dbo].[Jugador]
        ([NombreJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorSala'
CREATE INDEX [IX_FK_JugadorSala]
ON [dbo].[Sala]
    ([NombreAnfitrion]);
GO

-- Creating foreign key on [CodigoSala] in table 'Partida'
ALTER TABLE [dbo].[Partida]
ADD CONSTRAINT [FK_SalaPartida]
    FOREIGN KEY ([CodigoSala])
    REFERENCES [dbo].[Sala]
        ([Codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalaPartida'
CREATE INDEX [IX_FK_SalaPartida]
ON [dbo].[Partida]
    ([CodigoSala]);
GO

-- Creating foreign key on [NumeroPartida], [CodigoSala] in table 'ResultadoPartida'
ALTER TABLE [dbo].[ResultadoPartida]
ADD CONSTRAINT [FK_PartidaResultadoPartida]
    FOREIGN KEY ([NumeroPartida], [CodigoSala])
    REFERENCES [dbo].[Partida]
        ([NumeroPartida], [CodigoSala])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PartidaResultadoPartida'
CREATE INDEX [IX_FK_PartidaResultadoPartida]
ON [dbo].[ResultadoPartida]
    ([NumeroPartida], [CodigoSala]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------