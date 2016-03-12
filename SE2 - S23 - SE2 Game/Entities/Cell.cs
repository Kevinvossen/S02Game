using SE2___S23___SE2_Game.Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SE2___S23___SE2_Game.Entities
{
    public class Cell
    {
        public Point Position { get; set; }
        public Size Size { get; set; }
        
        public Cell(Size size, Point position)
        {
            this.Size = size;
            this.Position = position;
        }

        public void Draw(Graphics g)
        {
            for (int x = 1; x < World.Instance.Map.CellCount.X; x++)
            {
                g.DrawLine(Pens.LightGray, x * World.Instance.Map.CellSize.Width, 0,
                    x * World.Instance.Map.CellSize.Width, World.Instance.Map.MapSize.Height);
            }
            for (int y = 1; y < World.Instance.Map.CellCount.Y; y++)
            {
                g.DrawLine(Pens.LightGray, 0, y * World.Instance.Map.CellSize.Width,
                    World.Instance.Map.MapSize.Width, y * World.Instance.Map.CellSize.Width);
            }

        }


    }


}
