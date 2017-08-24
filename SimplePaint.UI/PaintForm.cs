using FloodFill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint.UI
{
    public partial class PaintForm : Form
    {
        private Random _random = new Random();
        private string _openedFileName;
        private PictureBox _selectedAction = null;
        private FloodFiller _bucketTool;
        private Color _selectedColor = Color.Black;

        public PaintForm()
        {
            InitializeComponent();

            Text = "Simple Paint";
            

            dlgOpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dlgOpenFile.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp;";

            for (int i = 0; i < 21; i++)
            {
                var clrBox = new PictureBox
                {
                    BackColor = GetRandomColor(),
                    Width = 56,
                    Height = 56
                };
                clrBox.Click += ClrBox_Click;
                pnlPalette.Controls.Add(clrBox);
            }            
        }
                
        private void ClrBox_Click(object sender, EventArgs e)
        {
            _selectedColor = ((PictureBox)sender).BackColor;
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
            if (sender == _selectedAction) return;

            ((PictureBox)sender).BorderStyle = BorderStyle.None;
            ((PictureBox)sender).BackColor = Color.LightGray;
        }

        private void img_Click(object sender, EventArgs e)
        {
            _selectedAction = sender as PictureBox;
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
            ((PictureBox)sender).BackColor = Color.White;
        }

        private void imgOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog(this) != DialogResult.OK) return;

            _openedFileName = dlgOpenFile.FileName;
            var image = new Bitmap(_openedFileName);
                        
            // scale image to canvas
            var width = (float)imgCanvas.ClientSize.Width;
            var height = (float)imgCanvas.ClientSize.Height;
            float scale = Math.Min(width / image.Width, height / image.Height);

            imgCanvas.Image = new Bitmap((int)width, (int)height);
                        
            var gfx = Graphics.FromImage(imgCanvas.Image);
            gfx.InterpolationMode = InterpolationMode.High;
            gfx.CompositingQuality = CompositingQuality.HighQuality;
            gfx.SmoothingMode = SmoothingMode.AntiAlias;

            var scaleWidth = (int)(image.Width * scale);
            var scaleHeight = (int)(image.Height * scale);            
            gfx.DrawImage(image, new Rectangle(((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight));
            gfx.Dispose();
            
            imgCanvas.Refresh();            
        }

        private void imgSave_Click(object sender, EventArgs e)
        {
            GetImageFromCanvas();
            MessageBox.Show("Not implemented");
        }

        private void imgBrush_Click(object sender, EventArgs e)
        {

        }

        private void imgCanvas_Click(object sender, EventArgs e)
        {
            if (_selectedAction == null) return;

            if(_selectedAction.Name == "imgFill")
            {
                DoBucketFill();
            }
        }        

        private void DoBucketFill()
        {
            var image = GetImageFromCanvas();
            var position = imgCanvas.PointToClient(Cursor.Position);
            FloodFill(image, position, Color.White, _selectedColor);

            var gfx = Graphics.FromImage(imgCanvas.Image);
            gfx.DrawImage(image, 0, 0);
            gfx.Dispose();
            imgCanvas.Refresh();
        }

        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            if (targetColor.ToArgb().Equals(replacementColor.ToArgb()))
            {
                return;
            }

            Stack<Point> pixels = new Stack<Point>();

            pixels.Push(pt);
            while (pixels.Count != 0)
            {
                Point temp = pixels.Pop();
                int y1 = temp.Y;
                while (y1 >= 0 && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    y1--;
                }
                y1++;
                bool spanLeft = false;
                bool spanRight = false;
                while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));
                        spanLeft = true;
                    }
                    else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }
                    if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));
                        spanRight = true;
                    }
                    else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }
                    y1++;
                }

            }            
        }

        private Bitmap GetImageFromCanvas()
        {
            var bmp = new Bitmap(imgCanvas.ClientSize.Width, imgCanvas.ClientSize.Height);            
            imgCanvas.DrawToBitmap(bmp, imgCanvas.ClientRectangle);
            bmp.Save("C:\\temp\\myImage.bmp");
            return bmp;            
        }        
    }
}
