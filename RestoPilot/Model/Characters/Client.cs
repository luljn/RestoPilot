using RestaurantSimulator.Model.Shared;
using System.Collections.Generic;

namespace RestaurantSimulator.Model.Salle.Characters
{
    public class Client
    {
        private Recette entree;
        private Recette plate;
        private Recette dessert;
        private Dictionary<string, int> strategy;

        public Recette Entree { get => entree; set => entree = value; }
        public Recette Plate { get => plate; set => plate = value; }
        public Recette Dessert { get => dessert; set => dessert = value; }
        public Dictionary<string, int> Strategy { get => strategy; set => strategy = value; }

        public Client()
        {
            this.entree = null;
            this.plate = null;
            this.dessert = null;
            this.strategy = new Dictionary<string, int>();
        }
    }
}