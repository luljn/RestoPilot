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

-- Plats
INSERT INTO Recettes (Intitule, tmpCuisson, tmpPreparation, tmpRepos, NbrePers, Type) VALUES
                                                                                          ('Ratatouille francaise', '00:30:00', '00:20:00', '00:15:00', 4, 'plat'),
                                                                                          ('Ndole camerounais', '01:00:00', '00:30:00', '00:20:00', 6, 'plat'),
                                                                                          ('Sauce arachide camerounaise', '00:45:00', '00:20:00', '00:15:00', 4, 'plat'),
                                                                                          ('Poulet Grille', '00:30:00', '00:15:00', '00:10:00', 2, 'plat'),
                                                                                          ('Spaghetti Bolognaise', '00:20:00', '00:20:00', '00:05:00', 4, 'plat'),
                                                                                          ('Sushi Assorti', '00:25:00', '00:15:00', '00:10:00', 2, 'plat'),
                                                                                          ('Salade Cesar', '00:15:00', '00:10:00', '00:05:00', 2, 'plat'),
                                                                                          ('Brochette de Boeuf', '00:25:00', '00:15:00', '00:10:00', 2, 'plat'),
                                                                                          ('Blancs de Poulet a la creme et au miel +riz','00:05:00','00:10:00','00:00:00',2,'plat'),
                                                                                          ('Burger Americain', '00:15:00', '00:20:00', '00:05:00', 1, 'plat'),
                                                                                          ('Pizza Ndole', '01:30:00', '00:30:00', '00:15:00', 4, 'plat'),
                                                                                          ('Lasagnes Vegetariennes', '00:40:00', '00:20:00', '00:15:00', 4, 'plat'), -- Menu Végétarien
                                                                                          ('Assortiment de Grillades', '00:30:00', '00:20:00', '00:15:00', 2, 'plat'), -- Menu Grillades
                                                                                          ('Filet Mignon Truffe', '00:25:00', '00:15:00', '00:10:00', 2, 'plat'), -- Menu Gourmet
                                                                                          ('Burger Express', '00:15:00', '00:10:00', '00:05:00', 2, 'plat'), -- Menu Rapide
                                                                                          ('Salade Legere aux Herbes Fraiches', '00:10:00', '00:10:00', '00:05:00', 2, 'entree'), -- Menu Léger
                                                                                          ('Poulet Yassa a la Mangue', '00:35:00', '00:20:00', '00:15:00', 4, 'plat'), -- Menu Savane Épicée
                                                                                          ('Mango Sticky Rice', '00:20:00', '00:10:00', '00:10:00', 2, 'dessert'); -- Menu Douceur Tropicale
-- Plats spéciaux pour chaque menu
-- INSERT INTO Recettes (Intitule, tmpCuisson, tmpPreparation, tmpRepos, NbrePers, Type) VALUES
--                                                                                           ('Tournedos Rossini', '00:20:00', '00:15:00', '00:10:00', 2, 'plat'), -- Menu Fusion Internationale
--                                                                                           ('Poulet DG', '00:40:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Festin Bamiléké
--                                                                                           ('Cari de Poisson Exotique', '00:35:00', '00:20:00', '00:15:00', 4, 'plat'), -- Menu Exotique
--                                                                                           ('Brochettes de Poisson', '00:25:00', '00:15:00', '00:10:00', 2, 'plat'), -- Menu Délices du Littoral
--                                                                                           ('Mbongo Tchobi', '01:00:00', '00:30:00', '00:20:00', 6, 'plat'), -- Menu Terroir Bamiléké
--                                                                                           ('Taro et Sauce Gombo', '00:30:00', '00:20:00', '00:15:00', 4, 'plat'), -- Menu Saveurs du Nord
--                                                                                           ('Poulet a la Moambe', '00:40:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Pimenté de l'Ouest
--                                                                                           ('Filet de Perche à letouffee', '00:25:00', '00:15:00', '00:10:00', 2, 'plat'), -- Menu Raffinement Bassa
--                                                                                           ('Poulet Nyembwe', '00:40:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Tradition Sawa
--                                                                                           ('Achu et Porc Grille', '00:40:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Authentique Ndop
--                                                                                           ('Fufu et Ndole', '00:45:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Akwaba (Accueil Camerounais)
--                                                                                           ('Taros aux epices Grassfields', '00:30:00', '00:20:00', '00:15:00', 4, 'plat'), -- Menu Gourmandises Grassfields
--                                                                                           ('Bouillie Plantain et Sauce Gombo', '00:35:00', '00:20:00', '00:15:00', 4, 'plat'), -- Menu Créole Camerounais
--                                                                                           ('Poulet Kapsiki', '00:40:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Délices de l'Adamaoua
--                                                                                           ('Soja aux Crevettes', '00:25:00', '00:15:00', '00:10:00', 2, 'plat'), -- Menu Évasion Bafia
--                                                                                           ('Brochettes Genereuses', '00:30:00', '00:20:00', '00:15:00', 2, 'plat'), -- Menu Générosité des Grills
--                                                                                           ('Crevettes Yassa', '00:35:00', '00:20:00', '00:15:00', 4, 'plat'), -- Menu Top 3 Plats du Cameroun
--                                                                                           ('Poulet DG au Ndop', '00:40:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Tendresse Haut-Nkam
--                                                                                           ('Sangha au Miel', '00:40:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Succulents Sawa
--                                                                                           ('Ndolé au Poulet', '00:45:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Inspirations Foumban
--                                                                                           ('Bœuf Sauté Douala', '00:30:00', '00:20:00', '00:15:00', 2, 'plat'), -- Menu Variété Douala
--                                                                                           ('Moelleux Nkui', '00:25:00', '00:20:00', '00:10:00', 4, 'dessert'), -- Menu Délices de la Vallée
--                                                                                           ('Makossa au Poulet', '00:30:00', '00:20:00', '00:15:00', 2, 'plat'), -- Menu Escale Béti
--                                                                                           ('Eru Blanc a la Viande', '00:40:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Parfums de l'Est
--                                                                                           ('Fruits de Mer du Sud', '00:25:00', '00:15:00', '00:10:00', 2, 'plat'), -- Menu Richesses du Sud
--                                                                                           ('Poulet à la Noix de Coco', '00:40:00', '00:30:00', '00:20:00', 4, 'plat'), -- Menu Découverte du Nord-Ouest
--                                                                                           ('Pizza Ndole', '00:20:00', '00:15:00', '00:10:00', 2, 'plat'), -- Menu Fusion des Cultures
--                                                                                           ('Salade Mixte', '00:10:00', '00:10:00', '00:05:00', 2, 'entree'), -- Menu Simple
--                                                                                           ('Wrap Végétarien', '00:15:00', '00:10:00', '00:05:00', 2, 'plat'), -- Menu Express
--                                                                                           ('Plateau de Fromages', '00:10:00', '00:10:00', '00:05:00', 2, 'entree'); -- Menu Harmonie des Saveurs
                                                                                          
-- Entrées
INSERT INTO Recettes (Intitule, tmpCuisson, tmpPreparation, tmpRepos, NbrePers, Type) VALUES
                                                                                          ('Sushi japonais', '00:20:00', '00:15:00', '00:10:00', 2, 'entree'),
                                                                                          ('Bruschetta Tomate Basilic', '00:10:00', '00:10:00', '00:05:00', 2, 'entree'),
                                                                                          ('Soupe Misos', '00:15:00', '00:10:00', '00:05:00', 2, 'entree'),
                                                                                          ('Beignets de Crevettes', '00:15:00', '00:20:00', '00:10:00', 4, 'entree'),
                                                                                          ('Caprese Salad', '00:10:00', '00:10:00', '00:05:00', 2, 'entree'),
                                                                                          ('Nems au Poulet', '00:15:00', '00:20:00', '00:10:00', 4, 'entree'),
                                                                                          ('Salade de Fruits de Mer', '00:15:00', '00:10:00', '00:05:00', 2, 'entree'),
                                                                                          ('Quiche Lorraine','00:15:00','00:35:00','00:00:00',6,'entree'),
                                                                                          ('feuillete au crabe','00:10:00','00:20:00','',4,'entree'),
                                                                                          ('Oeufs cocotte','00:10:00','00:20:00','',4,'entree');

-- Desserts
INSERT INTO Recettes (Intitule, tmpCuisson, tmpPreparation, tmpRepos, NbrePers, Type) VALUES
                                                                                          ('Cheesecake aux Fruits Rouges', '00:45:00', '00:30:00', '01:00:00', 4, 'dessert'),
                                                                                          ('Creme Brulee', '00:30:00', '00:15:00', '01:00:00', 4, 'dessert'),
                                                                                          ('Crepes Nature', '00:00:00', '00:10:00', '01:00:00', 10, 'dessert'),
                                                                                          ('Mochi Glace', '00:30:00', '00:20:00', '01:00:00', 4, 'dessert'),
                                                                                          ('Tarte au Citron Meringuee', '00:40:00', '00:30:00', '01:00:00', 4, 'dessert'),
                                                                                          ('Fondant au Chocolat', '00:25:00', '00:20:00', '00:10:00', 4, 'dessert'),
                                                                                          ('Salade de Fruits Exotiques', '00:20:00', '00:15:00', '00:10:00', 2, 'dessert'),
                                                                                          ('Gaufre','00:20:00','2:00:00','00:00:00',10,'dessert'),
                                                                                          ('Tiramisu','00:10:00','00:00:00','1:00:00',4,'dessert'),
                                                                                          ('Madeleine','00:45:00','00:15:00','00:00:00',10,'dessert');

-- Jeu de données pour Etapes (liées aux recettes ci-dessus)
-- Jeu de données pour Etapes
INSERT INTO Etapes (IdRecette, NumEtape, Temps, Description) VALUES
        -- Ratatouille française
        (2, 1, '00:15:00', 'Couper et preparer les legumes'),
        (2, 2, '00:15:00', 'Cuire les legumes au four'),
        (2, 3, '00:10:00', 'Assembler la ratatouille'),
        
        -- Ndole camerounais
        (4, 1, '00:30:00', 'Preparer les legumes et la viande'),
        (4, 2, '00:20:00', 'Cuire le Ndole'),
        (4, 3, '00:15:00', 'Preparer le riz et servir'),
        
        -- Sauce arachide camerounaise
        (5, 1, '00:20:00', 'Preparer la sauce et les ingredients'),
        (5, 2, '00:15:00', 'Cuire les ingredients dans la sauce'),
        (5, 3, '00:10:00', 'Servir avec un accompagnement'),
        
        -- Poulet Grille
        (13, 1, '00:15:00', 'Preparer le poulet et les epices'),
        (13, 2, '00:10:00', 'Griller le poulet'),
        (13, 3, '00:05:00', 'Servir avec des accompagnements'),
        
        -- Spaghetti Bolognaise
        (14, 1, '00:10:00', 'Cuire les pates'),
        (14, 2, '00:20:00', 'Preparer la sauce bolognaise'),
        (14, 3, '00:05:00', 'Servir les pates avec la sauce'),
        
        -- Sushi Assorti
        (3, 1, '00:15:00', 'Preparer le riz et le poisson'),
        (3, 2, '00:10:00', 'Assembler les sushis'),
        (3, 3, '00:10:00', 'Servir avec de la sauce soja'),
        
        -- Salade Cesar
        (15, 1, '00:10:00', 'Preparer la laitue et les ingredients'),
        (15, 2, '00:10:00', 'Preparer la sauce Cesar'),
        (15, 3, '00:05:00', 'Melanger et servir'),
        
        -- Brochette de Boeuf
        (16, 1, '00:15:00', 'Mariner la viande'),
        (16, 2, '00:10:00', 'Enfiler la viande sur des brochettes'),
        (16, 3, '00:10:00', 'Griller les brochettes'),
        
        -- Blancs de Poulet a la creme et au miel + riz
        (17, 1, '00:05:00', 'Cuire le poulet a la creme et au miel'),
        (17, 2, '00:10:00', 'Cuire le riz'),
        (17, 3, '00:00:00', 'Servir le poulet sur le riz'),
        
        -- Burger Americain
        (18, 1, '00:15:00', 'Cuire le steak et preparer les garnitures'),
        (18, 2, '00:20:00', 'Assembler le hamburger'),
        (18, 3, '00:05:00', 'Servir avec des frites'),
        
        -- Pizza Ndole
        (19, 1, '00:30:00', 'Preparer la pate a pizza'),
        (19, 2, '00:30:00', 'Etaler la sauce Ndole sur la pizza'),
        (19, 3, '00:15:00', 'Cuire la pizza au four'),
        
        -- Lasagnes Vegetariennes
        (20, 1, '00:20:00', 'Preparer la sauce tomate'),
        (20, 2, '00:20:00', 'Superposer les couches de lasagnes et de legumes'),
        (20, 3, '00:15:00', 'Cuire au four jusqua ce que le fromage soit dore'),
        
        -- Assortiment de Grillades
        (21, 1, '00:20:00', 'Mariner les viandes pour grillades'),
        (21, 2, '00:15:00', 'Griller les viandes a la perfection'),
        (21, 3, '00:15:00', 'Servir avec des sauces'),
        
        -- Filet Mignon Truffe
        (22, 1, '00:15:00', 'Preparer le filet mignon'),
        (22, 2, '00:15:00', 'Cuire a la perfection'),
        (22, 3, '00:10:00', 'Garnir de truffes et servir'),
        
        -- Burger Express
        (23, 1, '00:15:00', 'Cuire rapidement le steak'),
        (23, 2, '00:10:00', 'Assembler le hamburger rapidement'),
        (23, 3, '00:05:00', 'Servir avec des frites'),
        
        -- Salade Legere aux Herbes Fraiches
        (24, 1, '00:10:00', 'Preparer les herbes fraiches et les legumes'),
        (24, 2, '00:10:00', 'Assaisonner legerement'),
        (24, 3, '00:05:00', 'Melanger et servir'),
        
        -- Poulet Yassa a la Mangue
        (25, 1, '00:20:00', 'Preparer le poulet Yassa'),
        (25, 2, '00:10:00', 'Ajouter la mangue pour une touche sucree'),
        (25, 3, '00:15:00', 'Servir avec du riz'),
        
        -- Mango Sticky Rice
        (26, 1, '00:15:00', 'Cuire le riz gluant'),
        (26, 2, '00:10:00', 'Preparer la sauce sucree aux mangues'),
        (26, 3, '00:10:00', 'Servir le riz avec la sauce aux mangues');

--Entrees
INSERT INTO Etapes (IdRecette, NumEtape, Temps, Description) VALUES
-- Sushi japonais                                                                 
                                                                 (27, 1, '00:10:00', 'Preparer le riz et le poisson'),
                                                                 (27, 2, '00:05:00', 'Assembler les sushis'),
                                                                 (27, 3, '00:05:00', 'Servir avec de la sauce soja'),

-- Bruschetta Tomate Basilic
                                                                 (28, 1, '00:05:00', 'Couper les tomates et preparer le basilic'),
                                                                 (28, 2, '00:05:00', 'Melanger les ingredients sur des tranches de pain'),
                                                                 (28, 3, '00:05:00', 'Cuire au four et servir'),

-- Soupe Misos
                                                                 (29, 1, '00:10:00', 'Preparer le bouillon miso'),
                                                                 (29, 2, '00:05:00', 'Ajouter les ingredients et cuire'),
                                                                 (29, 3, '00:05:00', 'Servir chaud'),

-- Beignets de Crevettes
                                                                 (30, 1, '00:15:00', 'Preparer la pate a beignets et les crevettes'),
                                                                 (30, 2, '00:10:00', 'Tremper les crevettes dans la pate'),
                                                                 (30, 3, '00:10:00', 'Frire jusqua ce quils soient dores'),

-- Caprese Salad
                                                                 (31, 1, '00:10:00', 'Couper les tomates et la mozzarella'),
                                                                 (31, 2, '00:05:00', 'Disposer les tranches sur un plat'),
                                                                 (31, 3, '00:05:00', 'Arroser dhuile dolive et de basilic'),

-- Nems au Poulet
                                                                 (32, 1, '00:15:00', 'Preparer le melange de poulet et les feuilles de riz'),
                                                                 (32, 2, '00:10:00', 'Envelopper et plier les nems'),
                                                                 (32, 3, '00:10:00', 'Frire jusqua ce quils soient croustillants'),
-- Salade de Fruits de Mer
                                                                 (33, 1, '00:10:00', 'Preparer les fruits de mer et les legumes'),
                                                                 (33, 2, '00:05:00', 'Melanger avec une vinaigrette legere'),
                                                                 (33, 3, '00:05:00', 'Servir frais'),
-- Quiche Lorraine
                                                                 (34, 1, '00:15:00', 'Preparer la pate et la garniture'),
                                                                 (34, 2, '00:25:00', 'Verser la garniture sur la pate et cuire au four'),
                                                                 (34, 3, '00:00:00', 'Laisser refroidir avant de servir'),
-- Feuillete au Crabe
                                                                 (35, 1, '00:10:00', 'Preparer la farce au crabe'),
                                                                 (35, 2, '00:20:00', 'Remplir les feuilletes et cuire au four'),
                                                                 (35, 3, '00:00:00', 'Servir chaud'),
-- Oeufs Cocotte
                                                                 (36, 1, '00:10:00', N'Preparer les œufs et la creme'),
                                                                 (36, 2, '00:20:00', 'Mettre dans des ramequins et cuire au four'),
                                                                 (36, 3, '00:00:00', 'Servir avec du pain grille');


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
                            ('Menu Vegetarien'),
                            ('Menu Grillades'),
                            ('Menu Gourmet'),
                            ('Menu Rapide'),
                            ('Menu Exotique'),
                            ('Menu Leger'),
                            ('Menu Akwaba (Accueil Camerounais)'),
                            ('Menu Savane Epicee'),
                            ('Menu Douceur Tropicale');
--                             ('Menu Festin Bamileke'),
--                             ('Menu Delices du Littoral'),
--                             ('Menu Terroir Bamileke'),
--                             ('Menu Saveurs du Nord'),
--                             ('Menu Pimente de Ouest'),
--                             ('Menu Raffinement Bassa'),
--                             ('Menu Tradition Sawa'),
--                             ('Menu Authentique Ndop'),
--                             ('Menu Gourmandises Grassfields'),
--                             ('Menu Creole Camerounais'),
--                             ('Menu Delices de Adamaoua'),
--                             ('Menu Evasion Bafia'),
--                             ('Menu Generosite des Grills'),
--                             ('Menu Top 3 Plats du Cameroun'),
--                             ('Menu Tendresse Haut-Nkam'),
--                             ('Menu Succulents Sawa'),
--                             ('Menu Inspirations Foumban'),
--                             ('Menu Variete Douala'),
--                             ('Menu Delices de la Vallee'),
--                             ('Menu Escale Beti'),
--                             ('Menu Parfums de LEst'),
--                             ('Menu Richesses du Sud'),
--                             ('Menu Decouverte du Nord-Ouest'),
--                             ('Menu Fusion des Cultures'),
--                             ('Menu Simple'),
--                             ('Menu Express'),
--                             ('Menu Harmonie des Saveurs');


