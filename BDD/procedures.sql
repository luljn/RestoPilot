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

-- Procédure pour afficher les recettes
CREATE PROCEDURE AfficherRecettes
AS
BEGIN
    SELECT IdRecette, Intitule, tmpCuisson, tmpPreparation, tmpRepos, NbrePers, Prix, Type
    FROM Recettes;
END;
    GO
    EXEC AfficherRecettes;GO

-- Procédure pour afficher les étapes d'une recette
    CREATE PROCEDURE AfficherEtapesParRecette
    @IdRecette INT
    AS
    BEGIN
        SELECT IdEtape, NumEtape, Temps, Description
        FROM Etapes
        WHERE IdRecette = @IdRecette;
    END;GO
-- Remplacez 1 par l'ID de la recette que vous souhaitez afficher
        EXEC AfficherEtapesParRecette @IdRecette = 1;GO

