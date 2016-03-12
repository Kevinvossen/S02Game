using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SE2___S23___SE2_Game.Game;
using System.Windows.Forms;

namespace SE2___S23___SE2_Game.Entities
{
    public class Player
    {
        public Size Size { get; private set; }
        public Point Position { get; set; }
        public bool PowerUp { get; set; }
        public int HitPoints { get; set; }
        Point newPosition;
        
        public Player(Size size, Point position, int hitpoints)
        {
            this.Size = size;
            this.Position = position;
            this.HitPoints = hitpoints;
            this.newPosition = new Point(0, 0);
        }

        public void Update()
        {
            

        }
        public void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.DeepSkyBlue);
            g.FillEllipse(brush, GetRectForPlayer());
            g.DrawEllipse(Pens.Black, GetRectForPlayer());

        }

        public Rectangle GetRectForPlayer()
        {

            Map map = World.Instance.Map;
            Rectangle rect = new Rectangle(Position.X, Position.Y, map.CellSize.Width, map.CellSize.Height);

            return rect;
                                          
        }
        public void Interaction(Keys keyCode)
        {
            if (IsWithinBoundaries(newPosition))
            {

                switch (keyCode)
                {
                    case Keys.Up:
                        this.newPosition.Y = this.Position.Y - World.Instance.Map.CellSize.Height;
                        break;
                    case Keys.Down:
                        this.newPosition.Y = this.Position.Y + World.Instance.Map.CellSize.Height;
                        break;
                    case Keys.Left:
                        this.newPosition.X = this.Position.X - World.Instance.Map.CellSize.Width;
                        break;
                    case Keys.Right:
                        this.newPosition.X = this.Position.X + World.Instance.Map.CellSize.Width;
                        break;
                    default:
                        this.newPosition = this.Position;
                        break;
                }

                this.Position = newPosition;
            }
                                  
            
        }

        public bool IsWithinBoundaries(Point position)
        {
            if (this.newPosition.X < (World.Instance.Map.CellCount.X * World.Instance.Map.CellSize.Width) &&
                this.newPosition.Y < (World.Instance.Map.CellCount.Y * World.Instance.Map.CellSize.Height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
