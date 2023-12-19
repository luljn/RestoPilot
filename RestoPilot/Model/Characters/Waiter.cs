using Restaurant.Model.Salle.Movement;
using RestaurantSimulator.Model.Salle.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.Model.Salle.Characters
{
    public class Waiter : Position, IMove
    {
        public Waiter(int posX, int posY) : base(posX, posY)
        {
        }
        public Waiter() : base() { }

        public void Move(int posX, int posY)
        {
            this.PosX = posX;
            this.PosY = posY;
        }
    }
}