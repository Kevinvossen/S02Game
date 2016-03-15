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




    }


}
