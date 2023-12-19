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

-- Jeu de données pour Tables
INSERT INTO Tables (Capacite) VALUES
                                  (2), (2), (2), (2), (2), (2), (2), (2), (2), (2), -- 10 tables de 2 personnes
                                  (4), (4), (4), (4), (4), (4), (4), (4), (4), (4), -- 10 tables de 4 personnes
                                  (6), (6), (6), (6), (6), -- 5 tables de 6 personnes
                                  (8), (8), (8), (8), (8), -- 5 tables de 8 personnes
                                  (10), (10); -- 2 tables de 10 personnes

-- Jeu de données pour Clients
INSERT INTO Clients (Reservation, idTable) VALUES
                                               (1, 1), (0, 2), (1, 5); -- 3 clients

-- Jeu de données pour Ingredients
INSERT INTO Ingredients (Nom, QuantiteParPiece) VALUES
                                                    ('Riz a sushi', 500),
                                                    ('Saumon frais', 200),
                                                    (N'Bœuf tranche', 300),
                                                    ('Fromage a la creme', 250),
                                                    ('Feuilles de nori', 100),
                                                    ('Matcha en poudre', 50);

-- Jeu de données pour ZoneStockage
INSERT INTO ZoneStockage (Type, Quantite, IdIngredient) VALUES
                                                            ('Zone de denrees', 500, 1),
                                                            ('Zone de denrees', 300, 2),
                                                            ('Zone de denrees', 200, 3),
                                                            ('Chambre Froide', 150, 4),
                                                            ('Congelateur', 100, 5),
                                                            ('Chambre Froide', 100, 6);

-- Jeu de données pour Recettes
INSERT INTO Recettes (Intitule, tmpCuisson, tmpPreparation, tmpRepos, NbrePers, Type) VALUES
                                                                                          ('Hamburger americain', '00:15:00', '00:20:00', '00:05:00', 2, 'plat'),
                                                                                          ('Ratatouille francaise', '00:30:00', '00:20:00', '00:15:00', 4, 'plat'),
                                                                                          ('Sushi japonais', '00:20:00', '00:15:00', '00:10:00', 2, 'entree'),
                                                                                          ('Ndole camerounais', '01:00:00', '00:30:00', '00:20:00', 6, 'plat'),
                                                                                          ('Sauce arachide camerounaise', '00:45:00', '00:20:00', '00:15:00', 4, 'plat');

-- Jeu de données pour Etapes (liées aux recettes ci-dessus)
INSERT INTO Etapes (IdRecette, NumEtape, Temps, Description) VALUES
                                                                 (1, 1, '00:10:00', 'Cuire le steak et preparer les garnitures'),
                                                                 (1, 2, '00:05:00', 'Assembler le hamburger'),
                                                                 (2, 1, '00:15:00', 'Couper et preparer les legumes'),
                                                                 (2, 2, '00:15:00', 'Cuire les legumes au four'),
                                                                 (3, 1, '00:10:00', 'Preparer le riz et le poisson'),
                                                                 (3, 2, '00:05:00', 'Assembler les sushis'),
                                                                 (4, 1, '00:30:00', 'Preparer les legumes et la viande'),
                                                                 (4, 2, '00:20:00', 'Cuire le Ndole'),
                                                                 (5, 1, '00:20:00', 'Preparer la sauce et les ingredients'),
                                                                 (5, 2, '00:15:00', 'Cuire les ingredients dans la sauce');

-- Jeu de données pour Ingredients (liés aux recettes ci-dessus)
INSERT INTO Ingredients (Nom, QuantiteParPiece) VALUES
                                                    ('Steak hache', 200),
                                                    ('Pain a hamburger', 1),
                                                    ('Fromage cheddar', 100),
                                                    ('Laitue', 1),
                                                    ('Tomate', 2),
                                                    ('Aubergine', 2),
                                                    ('Courgette', 2),
                                                    ('Poivron rouge', 1),
                                                    ('Oignon', 1),
                                                    ('Riz a sushi', 300),
                                                    ('Saumon frais', 150),
                                                    ('Feuilles de nori', 10),
                                                    ('Feuilles de ndole', 1),
                                                    ('Arachides', 100),
                                                    (N'Viande de bœuf', 300),
                                                    ('Poivre', 1),
                                                    ('Poulet', 400),
                                                    ('Pate arachide', 200),
                                                    ('Oignon', 1),
                                                    ('Tomate', 2),
                                                    ('Poivre', 1);

-- Jeu de données pour Menus avec thèmes
INSERT INTO Menus (Nom) VALUES
                            ('Menu Americain'),
                            ('Menu Francais'),
                            ('Menu Asiatique'),
                            ('Menu Fusion Internationale'),
                            ('Menu Vegetarien'),
                            ('Menu Grillades'),
                            ('Menu Gourmet'),
                            ('Menu Rapide'),
                            ('Menu Exotique'),
                            ('Menu Camerounais'),
                            ('Menu Akwaba (Accueil Camerounais)'),
                            ('Menu Savane Epicee'),
                            ('Menu Douceur Tropicale'),
                            ('Menu Festin Bamileke'),
                            ('Menu Delices du Littoral'),
                            ('Menu Terroir Bamileke'),
                            ('Menu Saveurs du Nord'),
                            ('Menu Pimente de Ouest'),
                            ('Menu Raffinement Bassa'),
                            ('Menu Tradition Sawa'),
                            ('Menu Authentique Ndop'),
                            ('Menu Gourmandises Grassfields'),
                            ('Menu Creole Camerounais'),
                            ('Menu Delices de Adamaoua'),
                            ('Menu Evasion Bafia'),
                            ('Menu Generosite des Grills'),
                            ('Menu Top 3 Plats du Cameroun'),
                            ('Menu Tendresse Haut-Nkam'),
                            ('Menu Succulents Sawa'),
                            ('Menu Inspirations Foumban'),
                            ('Menu Variete Douala'),
                            ('Menu Delices de la Vallee'),
                            ('Menu Escale Beti'),
                            ('Menu Parfums de LEst'),
                            ('Menu Richesses du Sud'),
                            ('Menu Decouverte du Nord-Ouest'),
                            ('Menu Fusion des Cultures'),
                            ('Menu Simple'),
                            ('Menu Express'),
                            ('Menu Harmonie des Saveurs');
