using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGameForm
{
    public partial class MazeGame : Form
    {
        public MazeGame()
        {
            InitializeComponent();
        }

        private void Finish_Mouse_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Well Done!!");
            Application.Exit();
        }

        private void Start_Mouse_Enter(object sender, EventArgs e)
        {
            Point startPoint = panel1.Location;
            Cursor.Position = PointToScreen(startPoint);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void LoadGame_(object sender, EventArgs e)
        {
            DialogResult dialogOpen = MessageBox.Show("Get your cursor through the maze without touching the walls!");
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }

      
    }
}
