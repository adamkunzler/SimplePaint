using System;
using System.Collections.Generic;
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
        private Font _menuItemFont = new Font(new FontFamily("Cambria"), 20, FontStyle.Regular, GraphicsUnit.Pixel);
        private StringFormat _menuItemFormat = new StringFormat()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        private PictureBox _selectedAction = null;
        
        private Color _selectedColor = Color.Black;
        

        public PaintForm()
        {
            InitializeComponent();

            Text = "Simple Paint";

            // init the canvas image
            var width = (float)imgCanvas.ClientSize.Width;
            var height = (float)imgCanvas.ClientSize.Height;
            imgCanvas.Image = new Bitmap((int)width, (int)height);

            // init open file dialog
            dlgOpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dlgOpenFile.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp;";

            // init color palette
            InitColorPalette();    
        }

        #region Private Methods - Color Palette

        private void InitColorPalette()
        {
            var colors = GetPaletteColors();
            var paletteSquareDim = 140;
            for (int i = 0; i < colors.Length; i++)
            {
                var clrBox = new PictureBox
                {
                    BackColor = colors[i],
                    Width = paletteSquareDim,
                    Height = paletteSquareDim
                };
                clrBox.Click += ClrBox_Click;
                clrBox.Paint += ClrBox_Paint;
                pnlPalette.Controls.Add(clrBox);
            }
        }

        private void ClrBox_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            if (((PictureBox)sender).BackColor == _selectedColor)
            {
                DrawBorderOnControl(sender as Control, e.Graphics);
            }
        }

        private void DrawBorderOnControl(Control control, Graphics gfx)
        {
            if (control == null) return;

            var r = control.ClientRectangle;
            r.Height -= 1;
            r.Width -= 1;

            GraphicsPath rr = new GraphicsPath();
            rr.AddLine(r.X, r.Y, r.X + r.Width, r.Y);
            rr.AddLine(r.X + r.Width, r.Y, r.X + r.Width, r.Y + r.Height);
            rr.AddLine(r.X + r.Width, r.Y + r.Height, r.X, r.Y + r.Height);
            rr.AddLine(r.X, r.Y + r.Height, r.X, r.Y);

            using (var p = new Pen(Color.FromArgb(30, 144, 255), 10f))
            {
                gfx.DrawPath(p, rr);
            }
        }

        private void ClrBox_Click(object sender, EventArgs e)
        {            
            foreach (var control in pnlPalette.Controls)
            {
                if (!(control is PictureBox)) continue;

                var pb = (PictureBox)control;
                pb.BorderStyle = BorderStyle.None;
            }

            _selectedColor = ((PictureBox)sender).BackColor;

            pnlPalette.Refresh();
        }

        #endregion Private Methods - Color Palette

        #region Event Handlers - Menu Items

        private void img_Click(object sender, EventArgs e)
        {            
            _selectedAction = sender as PictureBox;
            pnlTools.Refresh();
        }

        private void toolBoxItem_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            if (sender == _selectedAction)
            {
                DrawBorderOnControl(sender as Control, e.Graphics);
            }
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

        private void imgMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
            ((PictureBox)sender).BackColor = Color.White;
        }

        private void imgMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender == _selectedAction) return;

            ((PictureBox)sender).BorderStyle = BorderStyle.None;
            ((PictureBox)sender).BackColor = Color.LightGray;
        }

        #endregion Event Handlers - Menu Items

        #region Private Methods - Canvas

        private void imgCanvas_Click(object sender, EventArgs e)
        {
            if (_selectedAction == null) return;

            switch(_selectedAction.Name)
            {
                case "imgFill":
                    DoBucketFill();
                    break;
                case "imgText":
                    DoEnterText();
                    break;
                case "imgBrush":
                    DoBrush();
                    break;
            }            
        }

        #endregion Private Methods - Canvas

        #region Private Methods - Text Tool

        private void DoEnterText()
        {

        }

        #endregion Private Methods - Text Tool

        #region Private Methods - Brush Tool

        private void DoBrush()
        {

        }

        #endregion Private Methods - Brush Tool

        #region Private Methods - Bucket Tool

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

        #endregion Private Methods - Bucket Tool

        private Bitmap GetImageFromCanvas()
        {
            var bmp = new Bitmap(imgCanvas.ClientSize.Width, imgCanvas.ClientSize.Height);            
            imgCanvas.DrawToBitmap(bmp, imgCanvas.ClientRectangle);
            bmp.Save("C:\\temp\\myImage.bmp");
            return bmp;            
        }

        #region Private Methods - Colors

        /// <summary>
        /// Returns colors for the palette.
        /// By default it'll return Black, Gray, White, and the 7 
        /// rainbow colors (red, orange, yellow, green, blue, indigo, 
        /// violet). If includeLightShades is true, it'll also
        /// return light shades of the rainbow colors.
        /// </summary>
        /// <param name="includeLightShades"></param>
        /// <returns></returns>
        private Color[] GetPaletteColors(bool includeLightShades = false)
        {
            var colors = new List<Color>();

            colors.Add(Color.Black);
            colors.Add(Color.Gray);
            colors.Add(Color.White);

            var brown = Color.FromArgb(139, 69, 19);
            colors.Add(brown);
            if (includeLightShades) colors.Add(ControlPaint.Light(brown));

            var red = Color.FromArgb(255, 0, 0);
            colors.Add(red);
            if(includeLightShades) colors.Add(ControlPaint.Light(red));
            
            var orange = Color.FromArgb(255, 127, 0);
            colors.Add(orange);
            if (includeLightShades) colors.Add(ControlPaint.Light(orange));
            
            var yellow = Color.FromArgb(255, 255, 0);
            colors.Add(yellow);
            if (includeLightShades) colors.Add(ControlPaint.Light(yellow));
           
            var green = Color.FromArgb(0, 255, 0);
            colors.Add(green);
            if (includeLightShades) colors.Add(ControlPaint.Light(green));
            
            var blue = Color.FromArgb(0, 0, 255);
            colors.Add(blue);
            if (includeLightShades) colors.Add(ControlPaint.Light(blue));
            
            var indigo = Color.FromArgb(75, 0, 130);
            colors.Add(indigo);
            if (includeLightShades) colors.Add(ControlPaint.Light(indigo));
            
            var violet = Color.FromArgb(148, 0, 211);
            colors.Add(violet);
            if (includeLightShades) colors.Add(ControlPaint.Light(violet));
            
            var pink = Color.FromArgb(255, 92, 161);
            colors.Add(pink);
            if (includeLightShades) colors.Add(ControlPaint.Light(pink));

            return colors.ToArray();
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));

        }

        #endregion Private Methods - Colors

        #region Event Handlers - Menu Items Paint

        private void imgOpen_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);            
            e.Graphics.DrawString("Open", _menuItemFont, Brushes.Black, imgOpen.ClientRectangle, _menuItemFormat);            
        }
        
        private void imgSave_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawString("Save", _menuItemFont, Brushes.Black, imgOpen.ClientRectangle, _menuItemFormat);
        }

        private void imgUndo_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawString("Undo", _menuItemFont, Brushes.Black, imgOpen.ClientRectangle, _menuItemFormat);
        }

        private void imgRedo_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawString("Redo", _menuItemFont, Brushes.Black, imgOpen.ClientRectangle, _menuItemFormat);
        }


        #endregion Event Handlers - Menu Items Paint        
    }
}
