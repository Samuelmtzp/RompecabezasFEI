
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/07/2023 15:27:26
-- Generated from EDMX file: C:\Users\samue\OneDrive - Universidad Veracruzana\UV\Semestre 5\Tecnologías\RompecabezasFei\RompecabezasFeiServidor\Datos\ModeloDatosRompecabezasFei.edmx
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

IF OBJECT_ID(N'[dbo].[FK_JugadorAmigo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Amigo] DROP CONSTRAINT [FK_JugadorAmigo];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorAmigo1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Amigo] DROP CONSTRAINT [FK_JugadorAmigo1];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorJugador_Partida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Juego] DROP CONSTRAINT [FK_JugadorJugador_Partida];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorSala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sala] DROP CONSTRAINT [FK_JugadorSala];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorSolicitudAmistad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Solicitud] DROP CONSTRAINT [FK_JugadorSolicitudAmistad];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorSolicitudAmistad1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Solicitud] DROP CONSTRAINT [FK_JugadorSolicitudAmistad1];
GO
IF OBJECT_ID(N'[dbo].[FK_PartidaJugador_Partida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Juego] DROP CONSTRAINT [FK_PartidaJugador_Partida];
GO
IF OBJECT_ID(N'[dbo].[FK_SalaPartida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResultadosPartida] DROP CONSTRAINT [FK_SalaPartida];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioJugador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [FK_UsuarioJugador];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Amigo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Amigo];
GO
IF OBJECT_ID(N'[dbo].[Juego]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Juego];
GO
IF OBJECT_ID(N'[dbo].[Jugador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jugador];
GO
IF OBJECT_ID(N'[dbo].[ResultadosPartida]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResultadosPartida];
GO
IF OBJECT_ID(N'[dbo].[Sala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sala];
GO
IF OBJECT_ID(N'[dbo].[Solicitud]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Solicitud];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Jugador'
CREATE TABLE [dbo].[Jugador] (
    [IdJugador] int IDENTITY(1,1) NOT NULL,
    [NombreJugador] nvarchar(max)  NOT NULL,
    [NumeroAvatar] smallint  NOT NULL,
    [Usuario_IdUsuario] int  NOT NULL
);
GO

-- Creating table 'Solicitud'
CREATE TABLE [dbo].[Solicitud] (
    [Estado] smallint  NOT NULL,
    [IdJugadorOrigen] int  NOT NULL,
    [IdJugadorDestino] int  NOT NULL,
    [FechaEnvioSolicitud] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ResultadosPartida'
CREATE TABLE [dbo].[ResultadosPartida] (
    [IdPartida] int IDENTITY(1,1) NOT NULL,
    [Dificultad] smallint  NOT NULL,
    [SalaIdSala] int  NOT NULL
);
GO

-- Creating table 'Juego'
CREATE TABLE [dbo].[Juego] (
    [Puntaje] int  NOT NULL,
    [IdJugador] int  NOT NULL,
    [IdPartida] int  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [Correo] nvarchar(max)  NOT NULL,
    [Contrasena] nvarchar(max)  NOT NULL
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
    [MaximoJugadores] smallint  NOT NULL,
    [MinimoJugadores] smallint  NOT NULL,
    [IdAnfitrion] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdJugador] in table 'Jugador'
ALTER TABLE [dbo].[Jugador]
ADD CONSTRAINT [PK_Jugador]
    PRIMARY KEY CLUSTERED ([IdJugador] ASC);
GO

-- Creating primary key on [IdJugadorOrigen], [IdJugadorDestino] in table 'Solicitud'
ALTER TABLE [dbo].[Solicitud]
ADD CONSTRAINT [PK_Solicitud]
    PRIMARY KEY CLUSTERED ([IdJugadorOrigen], [IdJugadorDestino] ASC);
GO

-- Creating primary key on [IdPartida] in table 'ResultadosPartida'
ALTER TABLE [dbo].[ResultadosPartida]
ADD CONSTRAINT [PK_ResultadosPartida]
    PRIMARY KEY CLUSTERED ([IdPartida] ASC);
GO

-- Creating primary key on [IdJugador], [IdPartida] in table 'Juego'
ALTER TABLE [dbo].[Juego]
ADD CONSTRAINT [PK_Juego]
    PRIMARY KEY CLUSTERED ([IdJugador], [IdPartida] ASC);
GO

-- Creating primary key on [IdUsuario] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdJugador1] in table 'Amigo'
ALTER TABLE [dbo].[Amigo]
ADD CONSTRAINT [FK_JugadorAmigo]
    FOREIGN KEY ([IdJugador1])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorAmigo'
CREATE INDEX [IX_FK_JugadorAmigo]
ON [dbo].[Amigo]
    ([IdJugador1]);
GO

-- Creating foreign key on [IdJugador2] in table 'Amigo'
ALTER TABLE [dbo].[Amigo]
ADD CONSTRAINT [FK_JugadorAmigo1]
    FOREIGN KEY ([IdJugador2])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorAmigo1'
CREATE INDEX [IX_FK_JugadorAmigo1]
ON [dbo].[Amigo]
    ([IdJugador2]);
GO

-- Creating foreign key on [IdJugadorOrigen] in table 'Solicitud'
ALTER TABLE [dbo].[Solicitud]
ADD CONSTRAINT [FK_JugadorSolicitudAmistad]
    FOREIGN KEY ([IdJugadorOrigen])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdJugadorDestino] in table 'Solicitud'
ALTER TABLE [dbo].[Solicitud]
ADD CONSTRAINT [FK_JugadorSolicitudAmistad1]
    FOREIGN KEY ([IdJugadorDestino])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorSolicitudAmistad1'
CREATE INDEX [IX_FK_JugadorSolicitudAmistad1]
ON [dbo].[Solicitud]
    ([IdJugadorDestino]);
GO

-- Creating foreign key on [IdJugador] in table 'Juego'
ALTER TABLE [dbo].[Juego]
ADD CONSTRAINT [FK_JugadorJugador_Partida]
    FOREIGN KEY ([IdJugador])
    REFERENCES [dbo].[Jugador]
        ([IdJugador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
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

-- Creating foreign key on [IdPartida] in table 'Juego'
ALTER TABLE [dbo].[Juego]
ADD CONSTRAINT [FK_PartidaJugador_Partida]
    FOREIGN KEY ([IdPartida])
    REFERENCES [dbo].[ResultadosPartida]
        ([IdPartida])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PartidaJugador_Partida'
CREATE INDEX [IX_FK_PartidaJugador_Partida]
ON [dbo].[Juego]
    ([IdPartida]);
GO

-- Creating foreign key on [SalaIdSala] in table 'ResultadosPartida'
ALTER TABLE [dbo].[ResultadosPartida]
ADD CONSTRAINT [FK_SalaPartida]
    FOREIGN KEY ([SalaIdSala])
    REFERENCES [dbo].[Sala]
        ([IdSala])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalaPartida'
CREATE INDEX [IX_FK_SalaPartida]
ON [dbo].[ResultadosPartida]
    ([SalaIdSala]);
GO

-- Creating foreign key on [Usuario_IdUsuario] in table 'Jugador'
ALTER TABLE [dbo].[Jugador]
ADD CONSTRAINT [FK_JugadorUsuario]
    FOREIGN KEY ([Usuario_IdUsuario])
    REFERENCES [dbo].[Usuario]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorUsuario'
CREATE INDEX [IX_FK_JugadorUsuario]
ON [dbo].[Jugador]
    ([Usuario_IdUsuario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------