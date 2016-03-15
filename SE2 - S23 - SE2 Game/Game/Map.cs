using SE2___S23___SE2_Game.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2___S23___SE2_Game.Game
{
    public class Map
    {
        public Size MapSize { get; set; }
        public Size CellSize { get; set; }
        public Point CellCount { get; set; }
        
      


        public Map(Size mapSize, Point cellCount)
        {
            this.MapSize = mapSize;
            this.CellCount = cellCount;
            this.CellSize = new Size(mapSize.Width / cellCount.X,
                                     mapSize.Height / cellCount.Y);
        }

        public void Draw(Graphics g)
        {
            for (int x = 1; x < this.CellCount.X; x++)
            {
                g.DrawLine(Pens.LightGray, x * this.CellSize.Width, 0,
                    x * this.CellSize.Width, this.MapSize.Height);
            }
            for (int y = 1; y < this.CellCount.Y; y++)
            {
                g.DrawLine(Pens.LightGray, 0, y * this.CellSize.Width,
                    this.MapSize.Width, y * this.CellSize.Width);
            }

        }


    }
}
