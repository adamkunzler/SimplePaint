using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint.UI
{
    public partial class PaintForm : Form
    {
        private Random _random = new Random();

        public PaintForm()
        {
            InitializeComponent();
            Text = "Simple Paint";
            
            for(int i = 0; i < 21; i++)
            {
                pnlPalette.Controls.Add(new PictureBox
                {
                    BackColor = GetRandomColor(),
                    Width = 56,
                    Height = 56
                });
            }

        }
       
        private Color GetRandomColor()
        {
            return Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));

        }

        private void img_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;            
            ((PictureBox)sender).BackColor = Color.White;
        }

        private void img_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.None;
            ((PictureBox)sender).BackColor = Color.LightGray;
        }

        private void imgOpen_Click(object sender, EventArgs e)
        {

        }

        private void imgSave_Click(object sender, EventArgs e)
        {

        }

        private void imgBrush_Click(object sender, EventArgs e)
        {

        }

        private void imgFill_Click(object sender, EventArgs e)
        {

        }
    }
}
