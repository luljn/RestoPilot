using Restaurant.Model.Salle.Movement;
using RestaurantSimulator.Model.Salle.Movement;

namespace Restaurant.Model.Salle.Characters
{
    public class Commis : Position, IMove
    {
        public Commis(int posX, int posY) : base(posX, posY) { }
        public Commis() : base() { }

        public void Move(int posX, int posY)
        {
            this.PosX = posX;
            this.PosY = posY;
        }
    }
}