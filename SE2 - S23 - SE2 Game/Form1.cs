using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SE2___S23___SE2_Game.Game;
using SE2___S23___SE2_Game.Entities;

namespace SE2___S23___SE2_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size size = new Size(30, 30);
            Point position = new Point(0, 0);
            World.Instance.Create(picGameWorld.Size, new Point(10, 10));
            World.Instance.CreatePlayer(size, position, 100);
            Focus();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            World.Instance.Update();
            picGameWorld.Refresh();
        }

        private void picGameWorld_Paint(object sender, PaintEventArgs e)
        {
            World.Instance.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            World.Instance.Player.Interaction(e.KeyCode);
        }
    }
}
