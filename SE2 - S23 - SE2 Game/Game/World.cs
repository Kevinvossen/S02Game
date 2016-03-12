using SE2___S23___SE2_Game.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2___S23___SE2_Game.Game
{
    public class World
    {
        public Player Player { get; set; }
        public Map Map { get; private set; }
        public bool GameWon { get; private set; }
        public bool GameOver { get; private set; }
        public Cell Cell { get; set; }

        public static World Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new World();
                }
                return instance;
            }
        }
        private static World instance;

        private World()
        {
           
        }

        public void Update()
        {
           
        }

        public void Draw(Graphics g)
        {
            this.Cell.Draw(g);
            this.Player.Draw(g);
        }

        public void Create(Size mapSize, Point cellCount)
        {
            this.Map = new Map(mapSize, cellCount);
        }

        public void CreatePlayer(Size size, Point position, int hitpoints)
        {
            this.Player = new Player(size, position, hitpoints);
        }
    }
}
