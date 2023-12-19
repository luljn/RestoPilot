using Microsoft.Xna.Framework;
using Restaurant.Model.Salle.Movement;
using RestaurantSimulator.Model.Salle.Components;
using RestaurantSimulator.Model.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.Model.Salle.Characters
{

    public class HotelMaster : Position
    {

        private int tile = 32;
        private List<RankChief> rankChiefs;

        public List<RankChief> RankChiefs
        {
            get => rankChiefs;
            set => rankChiefs = value;
        }

        public HotelMaster() : base()
        {
            this.rankChiefs = new List<RankChief>();

            this.rankChiefs.Add(new RankChief(new Vector2(11 * tile, 15 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(10, new Rectangle(16 * tile, 14 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(10, new Rectangle(4 * tile, 7 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(4, new Rectangle(1 * tile, 14 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(8, new Rectangle(12 * tile, 7 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(4, new Rectangle(12 * tile, 1 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(4, new Rectangle(18 * tile, 1 * tile, 5 * tile, 5 * tile)));

            this.rankChiefs.Add(new RankChief(new Vector2(12 * tile, 15 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(10, new Rectangle(33 * tile, 20 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(4, new Rectangle(24 * tile, 1 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(8, new Rectangle(32 * tile, 1 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(4, new Rectangle(25 * tile, 13 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(8, new Rectangle(22 * tile, 7 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(10, new Rectangle(30 * tile, 7 * tile, 5 * tile, 5 * tile)));

        }

        public HotelMaster(int posX, int posY) : base(posX, posY)
        {
            this.rankChiefs = new List<RankChief>();

            this.rankChiefs.Add(new RankChief());
            this.rankChiefs.Add(new RankChief());

            this.rankChiefs[0].Squares[0].Tables.Add(new Table(10, new Rectangle(16 * tile, 14 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(10, new Rectangle(4 * tile, 7 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(4, new Rectangle(1 * tile, 14 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(8, new Rectangle(12 * tile, 7 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(4, new Rectangle(12 * tile, 1 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[0].Squares[0].Tables.Add(new Table(4, new Rectangle(18 * tile, 1 * tile, 5 * tile, 5 * tile)));

            this.rankChiefs[1].Squares[0].Tables.Add(new Table(10, new Rectangle(33 * tile, 20 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(4, new Rectangle(24 * tile, 1 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(8, new Rectangle(32 * tile, 1 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(4, new Rectangle(25 * tile, 13 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(8, new Rectangle(22 * tile, 7 * tile, 5 * tile, 5 * tile)));
            this.rankChiefs[1].Squares[0].Tables.Add(new Table(10, new Rectangle(30 * tile, 7 * tile, 5 * tile, 5 * tile)));
        }
    }
}