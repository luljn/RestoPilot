-- Utilisation du schema par defaut
USE master;
GO

-- Suppression de la base de données si elle existe déjà
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'RestoPilot')
    DROP DATABASE RestoPilot;
GO

-- Création de la base de données
CREATE DATABASE RestoPilot;
GO

USE RestoPilot;
GO

-- Copyright
/*
   RestoPilot Database
   Copyright (C) 2023 Ken-Andre and Group 6
   
   Description: 
   This database is designed for a restaurant management simulation system.
   It includes tables for managing tables, clients, orders, recipes, ingredients, menus, and more.

   Note: Please refer to the documentation for detailed information on the database schema and relationships.
*/


-- Création de la table des tables
CREATE TABLE Tables (
                        idTable INT PRIMARY KEY IDENTITY(1,1),
                        Capacite INT CHECK (Capacite <= 10) --La capacite maximale qu'une table peut avoir est de 10 pers.
);

-- Création de la table des clients
CREATE TABLE Clients (
                         IdClient INT PRIMARY KEY IDENTITY(1,1),
                         Reservation BIT,
                         idTable INT FOREIGN KEY REFERENCES Tables(idTable)
);

-- Création de la table des commandes
CREATE TABLE Commandes (
                           IdCommande INT PRIMARY KEY IDENTITY(1,1),
                           Date_cmd DATETIME,
                           IdClient INT FOREIGN KEY REFERENCES Clients(IdClient)
);

-- Création de la table des boissons
CREATE TABLE Boissons (
                          IdBoisson INT PRIMARY KEY IDENTITY(1,1),
                          Nom VARCHAR(50),
                          Prix DECIMAL(10, 2)
);

-- Création de la table des recettes
CREATE TABLE Recettes (
                          IdRecette INT PRIMARY KEY IDENTITY(1,1),
                          Intitule VARCHAR(100),
                          tmpCuisson TIME,
                          tmpPreparation TIME,
                          tmpRepos TIME,
                          NbrePers INT,
                          Prix MONEY,
                          Type VARCHAR(20) CHECK (Type IN ('entree', 'plat', 'dessert'))
);

-- Création de la table des menus
CREATE TABLE Menus (
    IdMenu INT PRIMARY KEY IDENTITY(1,1),
    Nom Varchar(100),
    
);

-- Création de la table de la contenance des menus
CREATE TABLE ContenanceMenu (
                                IdMenu INT FOREIGN KEY REFERENCES Menus(IdMenu),
                                IdBoisson INT FOREIGN KEY REFERENCES Boissons(IdBoisson),
                                IdRecette INT FOREIGN KEY REFERENCES Recettes(IdRecette)
);

-- Création de la table des étapes
CREATE TABLE Etapes (
                        IdEtape INT PRIMARY KEY IDENTITY(1,1),
                        NumEtape INT,
                        Temps TIME,
                        Description VARCHAR(MAX),
                        IdRecette INT FOREIGN KEY REFERENCES Recettes(IdRecette)
);

-- Création de la table des ustensiles
CREATE TABLE Ustensiles (
                            IdUstensile INT PRIMARY KEY IDENTITY(1,1),
                            Nom VARCHAR(50),
                            Nombre INT,
                            TempsNettoyage TIME
);



-- Création de la table des ingrédients
CREATE TABLE Ingredients (
                             IdIngredient INT PRIMARY KEY IDENTITY(1,1),
                             Nom VARCHAR(50),
                             QuantiteParPiece INT,
);

-- Création de la table de la zone de stockage
CREATE TABLE ZoneStockage (
                              IdStock INT PRIMARY KEY IDENTITY(1,1),
                              Type VARCHAR(50) CHECK (Type IN ('Zone de denrees', 'Chambre Froide', 'Congelateur')),
                              Quantite INT, --Quantite disponible
                              IdIngredient INT FOREIGN KEY REFERENCES Ingredients(IdIngredient)
);
-- Création de la table du nécessaire pour les étapes
CREATE TABLE NecessaireEtape (
                                 IdEtape INT FOREIGN KEY REFERENCES Etapes(IdEtape),
                                 IdUstensile INT FOREIGN KEY REFERENCES Ustensiles(IdUstensile),
                                 IdIngredient INT FOREIGN KEY REFERENCES Ingredients(IdIngredient)
);

-- Création de la table de la contenance des commandes (après avoir créé Recettes et Boissons)
CREATE TABLE ContenanceCmd (
                               IdCommande INT FOREIGN KEY REFERENCES Commandes(IdCommande),
                               IdRecette INT FOREIGN KEY REFERENCES Recettes(IdRecette),
                               IdBoisson INT FOREIGN KEY REFERENCES Boissons(IdBoisson)
);
