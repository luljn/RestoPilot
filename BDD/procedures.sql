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
    END;
GO
-- Remplacez 1 par l'ID de la recette que vous souhaitez afficher
        EXEC AfficherEtapesParRecette @IdRecette = 1;
GO


-- Supprimer la procedure carte aléatoire
drop procedure if exists dbo.GenererCarteAleatoire
go
-- Procédure pour générer une carte aléatoire
CREATE PROCEDURE GenererCarteAleatoire
AS
BEGIN
    -- Créer une table temporaire pour stocker les recettes aléatoires
    CREATE TABLE #CarteTemp (
                                NomMenu VARCHAR(100),
                                IdRecette VARCHAR(100),
                                NomRecette VARCHAR(100),
--                                 Type VARCHAR(20),
                                Prix MONEY
    );

    -- Insérer 10 entrées aléatoires
    INSERT INTO #CarteTemp
    SELECT TOP 10 'Menu Entrees' AS NomMenu,R.IdRecette, R.Intitule, R.Prix
    FROM Recettes R
    WHERE R.Type = 'entree'
    ORDER BY NEWID();

    -- Insérer 9 plats aléatoires
    INSERT INTO #CarteTemp
    SELECT TOP 9 'Menu Plats' AS NomMenu,R.IdRecette, R.Intitule, R.Prix
    FROM Recettes R
    WHERE R.Type = 'plat'
    ORDER BY NEWID();

    -- Insérer 10 desserts aléatoires
    INSERT INTO #CarteTemp
    SELECT TOP 10 'Menu Desserts' AS NomMenu,R.IdRecette, R.Intitule, R.Prix
    FROM Recettes R
    WHERE R.Type = 'dessert'
    ORDER BY NEWID();

    -- Sélectionner un plat spécial de l'un des menus
    INSERT INTO #CarteTemp
    SELECT TOP 1 M.Nom AS NomMenu,R.IdRecette, R.Intitule, R.Prix
    FROM Menus M
             INNER JOIN ContenanceMenu CM ON M.IdMenu = CM.IdMenu
             INNER JOIN Recettes R ON CM.IdRecette = R.IdRecette
    WHERE R.Type = 'plat'
    ORDER BY NEWID();

    -- Sélectionner 2/3 boissons aléatoires
    INSERT INTO #CarteTemp
    SELECT TOP 2 'Menu Boissons' AS NomMenu,B.IdBoisson, B.Nom, B.Prix
    FROM Boissons B
    ORDER BY NEWID();

    -- Sélectionner le résultat final
    SELECT *
    FROM #CarteTemp
    ORDER BY NomMenu, NEWID();

    -- Supprimer la table temporaire
    DROP TABLE #CarteTemp;
END;
    GO
    EXEC GenererCarteAleatoire;
