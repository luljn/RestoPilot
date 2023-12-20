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
-- Jeu de données unifié pour Ingredients
INSERT INTO Ingredients (Nom, QuantiteParPiece) VALUES
                                                    ('Courgette', 2),
                                                    ('Aubergine', 1),
                                                    ('Poivron rouge', 1),
                                                    ('Poivron jaune', 1),
                                                    ('Oignon', 1),
                                                    ('Ail', 2),
                                                    ('Tomates', 4),
                                                    ('Herbes de Provence', 1),
                                                    ('Huile dolive', 1),
                                                    ('Feuilles de Ndole', 1),
                                                    ('Viande boeuf ', 500),
                                                    ('Crevettes', 200),
                                                    ('Huile rouge', 1),
                                                    ('Arachides', 100),
                                                    ('Sel', 1),
                                                    ('Viande poulet', 500),
                                                    ('Poivron vert', 1),
                                                    ('Poivre', 1),
                                                    ('Paprika', 1),
                                                    ('Spaghetti', 400),
                                                    ('Viande hachee', 500),                   
                                                    ('Vin rouge', 1),
                                                    ('Concentre de tomate', 2),
                                                    ('Parmesan rape', 1),
                                                    ('Riz a sushi', 2),
                                                    ('Vinaigre de riz', 1),
                                                    ('Sucre', 1),
                                                    ('Poisson frais saumon, thon', 300),
                                                    ('Feuilles dalgues nori', 10),
                                                    ('Avocat', 2),
                                                    ('Concombre', 1),
                                                    ('Sauce soja', 1),
                                                    ('Wasabi', 1),
                                                    ('Gingembre marine', 1),
                                                    ('Laitue romaine', 1),
                                                    ('Croutons', 1),
                                                    ('Sauce Cesar', 1),                              
                                                    ('Herbes', 1),
                                                    ('Brochettes en bois', 1),
                                                    ('Miel', 1),
                                                    ('Riz ordinaire', 1),
                                                    ('Steak hache', 1),
                                                    ('Pain a hamburger', 2),
                                                    ('Fromage cheddar', 2),
                                                    ('Laitue ordinaire', 1),
                                                    ('Oignon rouge', 1),
                                                    ('Ketchup', 1),
                                                    ('Mayonnaise', 1),
                                                    ('Cornichons', 1),
                                                    ('Pate a pizza', 1),
                                                    ('Sauce Ndole', 1),
                                                    ('Fromage rape', 1),
                                                    ('Olives noires', 1),
                                                    ('Poivrons tranches', 1),
                                                    ('Feuilles de lasagne', 1),                                                    
                                                    ('Epinards frais', 200),
                                                    ('Fromage ricotta', 250),
                                                    ('Sachet Sauce tomate', 1),
                                                    ('Cotelettes de porc', 4),                                            
                                                    ('Saucisses de porc', 4),
                                                    ('Marinade huile', 1),
                                                    ('Filet mignon', 2),
                                                    ('Truffes', 1),
                                                    ('Beurre', 100),
                                                    ('Creme fraiche', 200),
                                                    ('Cheesecake aux Fruits Rouges surgele', 1),
                                                    ('Creme Brulee', 1),
                                                    ('Crepes Nature', 1),
                                                    ('Mochi Glace', 1),
                                                    ('Tarte au Citron Meringuee', 1),
                                                    ('Fondant au Chocolat', 1),
                                                    ('Salade de Fruits Exotiques', 1),
                                                    ('Tiramisu', 1),
                                                    ('Bruschetta Tomate Basilic', 1),
                                                    ('Soupe Misos', 1),
                                                    ('Packet Beignets de Crevettes', 150),
                                                    ('Caprese Salad', 1),
                                                    ('Salade de Fruits de Mer', 1),
                                                    ('Quiche Lorraine', 1),
                                                    ('Feuillete au Crabe', 1),
                                                    ('Oeufs cocotte', 1),
                                                    ('Mochi Glace', 1), 
                                                    ('Gaufre', 1),
                                                    ('Madeleine', 1);


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
        (1, 1, '00:15:00', 'Couper et preparer les legumes'),
        (1, 2, '00:15:00', 'Cuire les legumes au four'),
        (1, 3, '00:10:00', 'Assembler la ratatouille'),
        
        -- Ndole camerounais
        (2, 1, '00:30:00', 'Preparer les legumes et la viande'),
        (2, 2, '00:20:00', 'Cuire le Ndole'),
        (2, 3, '00:15:00', 'Preparer le riz et servir'),
        
        -- Sauce arachide camerounaise
        (3, 1, '00:20:00', 'Preparer la sauce et les ingredients'),
        (3, 2, '00:15:00', 'Cuire les ingredients dans la sauce'),
        (3, 3, '00:10:00', 'Servir avec un accompagnement'),
        
        -- Poulet Grille
        (4, 1, '00:15:00', 'Preparer le poulet et les epices'),
        (4, 2, '00:10:00', 'Griller le poulet'),
        (4, 3, '00:05:00', 'Servir avec des accompagnements'),
        
        -- Spaghetti Bolognaise
        (5, 1, '00:10:00', 'Cuire les pates'),
        (5, 2, '00:20:00', 'Preparer la sauce bolognaise'),
        (5, 3, '00:05:00', 'Servir les pates avec la sauce'),
        
        -- Sushi Assorti
        (6, 1, '00:15:00', 'Preparer le riz et le poisson'),
        (6, 2, '00:10:00', 'Assembler les sushis'),
        (6, 3, '00:10:00', 'Servir avec de la sauce soja'),
        
        -- Salade Cesar
        (7, 1, '00:10:00', 'Preparer la laitue et les ingredients'),
        (7, 2, '00:10:00', 'Preparer la sauce Cesar'),
        (7, 3, '00:05:00', 'Melanger et servir'),
        
        -- Brochette de Boeuf
        (8, 1, '00:15:00', 'Mariner la viande'),
        (8, 2, '00:10:00', 'Enfiler la viande sur des brochettes'),
        (8, 3, '00:10:00', 'Griller les brochettes'),
        
        -- Blancs de Poulet a la creme et au miel + riz
        (9, 1, '00:05:00', 'Cuire le poulet a la creme et au miel'),
        (9, 2, '00:10:00', 'Cuire le riz'),
        (9, 3, '00:00:00', 'Servir le poulet sur le riz'),
        
        -- Burger Americain
        (10, 1, '00:15:00', 'Cuire le steak et preparer les garnitures'),
        (10, 2, '00:20:00', 'Assembler le hamburger'),
        (10, 3, '00:05:00', 'Servir avec des frites'),
        
        -- Pizza Ndole
        (11, 1, '00:30:00', 'Preparer la pate a pizza'),
        (11, 2, '00:30:00', 'Etaler la sauce Ndole sur la pizza'),
        (11, 3, '00:15:00', 'Cuire la pizza au four'),
        
        -- Lasagnes Vegetariennes
        (12, 1, '00:20:00', 'Preparer la sauce tomate'),
        (12, 2, '00:20:00', 'Superposer les couches de lasagnes et de legumes'),
        (12, 3, '00:15:00', 'Cuire au four jusqua ce que le fromage soit dore'),
        
        -- Assortiment de Grillades
        (13, 1, '00:20:00', 'Mariner les viandes pour grillades'),
        (13, 2, '00:15:00', 'Griller les viandes a la perfection'),
        (13, 3, '00:15:00', 'Servir avec des sauces'),
        
        -- Filet Mignon Truffe
        (14, 1, '00:15:00', 'Preparer le filet mignon'),
        (14, 2, '00:15:00', 'Cuire a la perfection'),
        (14, 3, '00:10:00', 'Garnir de truffes et servir'),
        
        -- Burger Express
        (15, 1, '00:15:00', 'Cuire rapidement le steak'),
        (15, 2, '00:10:00', 'Assembler le hamburger rapidement'),
        (15, 3, '00:05:00', 'Servir avec des frites'),
        
        -- Salade Legere aux Herbes Fraiches
        (16, 1, '00:10:00', 'Preparer les herbes fraiches et les legumes'),
        (16, 2, '00:10:00', 'Assaisonner legerement'),
        (16, 3, '00:05:00', 'Melanger et servir'),
        
        -- Poulet Yassa a la Mangue
        (17, 1, '00:20:00', 'Preparer le poulet Yassa'),
        (17, 2, '00:10:00', 'Ajouter la mangue pour une touche sucree'),
        (17, 3, '00:15:00', 'Servir avec du riz'),
        
        -- Mango Sticky Rice
        (18, 1, '00:15:00', 'Cuire le riz gluant'),
        (18, 2, '00:10:00', 'Preparer la sauce sucree aux mangues'),
        (18, 3, '00:10:00', 'Servir le riz avec la sauce aux mangues');

--Entrees
INSERT INTO Etapes (IdRecette, NumEtape, Temps, Description) VALUES
-- Sushi japonais                                                                 
                                                                 (19, 1, '00:10:00', 'Preparer le riz et le poisson'),
                                                                 (19, 2, '00:05:00', 'Assembler les sushis'),
                                                                 (19, 3, '00:05:00', 'Servir avec de la sauce soja'),

-- Bruschetta Tomate Basilic
                                                                 (20, 1, '00:05:00', 'Couper les tomates et preparer le basilic'),
                                                                 (20, 2, '00:05:00', 'Melanger les ingredients sur des tranches de pain'),
                                                                 (20, 3, '00:05:00', 'Cuire au four et servir'),

-- Soupe Misos
                                                                 (21, 1, '00:10:00', 'Preparer le bouillon miso'),
                                                                 (21, 2, '00:05:00', 'Ajouter les ingredients et cuire'),
                                                                 (21, 3, '00:05:00', 'Servir chaud'),

-- Beignets de Crevettes
                                                                 (22, 1, '00:15:00', 'Preparer la pate a beignets et les crevettes'),
                                                                 (22, 2, '00:10:00', 'Tremper les crevettes dans la pate'),
                                                                 (22, 3, '00:10:00', 'Frire jusqua ce quils soient dores'),

-- Caprese Salad
                                                                 (23, 1, '00:10:00', 'Couper les tomates et la mozzarella'),
                                                                 (23, 2, '00:05:00', 'Disposer les tranches sur un plat'),
                                                                 (23, 3, '00:05:00', 'Arroser dhuile dolive et de basilic'),

-- Nems au Poulet
                                                                 (24, 1, '00:15:00', 'Preparer le melange de poulet et les feuilles de riz'),
                                                                 (24, 2, '00:10:00', 'Envelopper et plier les nems'),
                                                                 (24, 3, '00:10:00', 'Frire jusqua ce quils soient croustillants'),
-- Salade de Fruits de Mer
                                                                 (25, 1, '00:10:00', 'Preparer les fruits de mer et les legumes'),
                                                                 (25, 2, '00:05:00', 'Melanger avec une vinaigrette legere'),
                                                                 (25, 3, '00:05:00', 'Servir frais'),
-- Quiche Lorraine
                                                                 (26, 1, '00:15:00', 'Preparer la pate et la garniture'),
                                                                 (26, 2, '00:25:00', 'Verser la garniture sur la pate et cuire au four'),
                                                                 (26, 3, '00:00:00', 'Laisser refroidir avant de servir'),
-- Feuillete au Crabe
                                                                 (27, 1, '00:10:00', 'Preparer la farce au crabe'),
                                                                 (27, 2, '00:20:00', 'Remplir les feuilletes et cuire au four'),
                                                                 (27, 3, '00:00:00', 'Servir chaud'),
-- Oeufs Cocotte
                                                                 (28, 1, '00:10:00', N'Preparer les œufs et la creme'),
                                                                 (28, 2, '00:20:00', 'Mettre dans des ramequins et cuire au four'),
                                                                 (28, 3, '00:00:00', 'Servir avec du pain grille');


--Desserts
-- Jeu de données pour Etapes (liées aux recettes ci-dessus)
-- Assurez-vous d'ajuster les valeurs des colonnes IdRecette, NumEtape, Temps, Description en fonction de votre schéma réel
INSERT INTO Etapes (IdRecette, NumEtape, Temps, Description) VALUES
                                                                 (29, 1, '00:15:00', 'Preparer la base du cheesecake'),
                                                                 (29, 2, '00:10:00', 'Battre le fromage avec le sucre'),
                                                                 (29, 3, '00:10:00', 'Incorporer les oeufs et la vanille'),
                                                                 (29, 4, '00:10:00', 'Verser sur la base et cuire au four'),
                                                                 (29, 5, '00:00:00', 'Refrigerer avec les fruits rouges'),

                                                                 (30, 1, '00:15:00', 'Preparer la creme avec la vanille'),
                                                                 (30, 2, '00:10:00', 'Verser dans des ramequins et cuire au four'),
                                                                 (30, 3, '00:05:00', 'Refroidir et saupoudrer de sucre'),
                                                                 (30, 4, '00:05:00', 'Carameliser au chalumeau'),

                                                                 (31, 1, '00:05:00', 'Melanger la farine, les oeufs, le lait et le sucre'),
                                                                 (31, 2, '00:05:00', 'Cuire les crepes dans une poele chaude'),
                                                                 (31, 3, '00:00:00', 'Servir avec le garnissage souhaite'),

                                                                 (32, 1, '00:10:00', 'Preparer la pate de mochi'),
                                                                 (32, 2, '00:10:00', 'Former des boules avec la glace'),
                                                                 (32, 3, '00:00:00', 'Envelopper les boules avec le mochi'),

                                                                 (33, 1, '00:15:00', 'Preparer la pate et la garniture au citron'),
                                                                 (33, 2, '00:20:00', 'Cuire la pate et verser la garniture'),
                                                                 (33, 3, '00:10:00', 'Faire la meringue et la cuire au four'),

                                                                 (34, 1, '00:10:00', 'Faire fondre le chocolat et le beurre'),
                                                                 (34, 2, '00:10:00', 'Melanger avec le sucre et les oeufs'),
                                                                 (34, 3, '00:05:00', 'Ajouter la farine et cuire au four'),

                                                                 (35, 1, '00:10:00', 'Preparer les fruits exotiques'),
                                                                 (35, 2, '00:05:00', 'Melanger avec un sirop leger'),
                                                                 (35, 3, '00:05:00', 'Servir frais'),

                                                                 (36, 1, '00:10:00', 'Preparer la pate a gaufres'),
                                                                 (36, 2, '00:10:00', 'Cuire dans un gaufrier chaud'),
                                                                 (36, 3, '00:00:00', 'Servir avec le topping de votre choix'),

                                                                 (37, 1, '00:10:00', 'Preparer la creme au mascarpone'),
                                                                 (37, 2, '00:10:00', 'Tremper les biscuits dans le cafe'),
                                                                 (37, 3, '00:10:00', 'Alterner les couches dans un plat'),

                                                                 (38, 1, '00:20:00', 'Battre les oeufs et le sucre jusqua ce que le melange blanchisse'),
                                                                 (38, 2, '00:10:00', 'Ajouter la farine et le beurre fondu'),
                                                                 (38, 3, '00:05:00', 'Remplir les moules et cuire au four');

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


