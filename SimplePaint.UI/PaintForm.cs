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
        #region Private Members

        private Random _random = new Random();
        private string _formTitle = "Simple Paint";
        
        private Font _menuItemFont = new Font(new FontFamily("Cambria"), 20, FontStyle.Regular, GraphicsUnit.Pixel);
        private StringFormat _menuItemFormat = new StringFormat()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        private Color _borderColor = Color.FromArgb(30, 144, 255);
        private float _borderWidth = 10f;
        private string _openDialogFilter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp;";
        private string _saveDialogFilter = "Png Image (.png)|*.png|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|JPEG Image (.jpg)|*.jpeg|Bitmap Image (.bmp)|*.bmp";
        private PictureBox _selectedToolAction = null;        
        private Color _selectedColor = Color.Black;

        private string _openedFileName;
        private string _savedFileName;
        private Bitmap _currentBitmap;
        private Stack<Bitmap> _redo = new Stack<Bitmap>();
        private Stack<Bitmap> _undo = new Stack<Bitmap>();

        #endregion Private Members

        #region Constructors

        public PaintForm()
        {
            InitializeComponent();

            Text = _formTitle;
                                    
            // init the canvas image and bitmap
            ResizeCanvasAndCurrentBitmap();

            // init dialogs
            dlgOpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dlgOpenFile.Filter = _openDialogFilter;
            dlgSaveFile.Filter = _saveDialogFilter;
            dlgSaveFile.AddExtension = true;

            // init color palette
            InitColorPalette();

            _selectedToolAction = imgFill;
        }

        private void ResetForm()
        {
            Text = _formTitle;
            _openedFileName = string.Empty;
            _savedFileName = string.Empty;
        }

        #endregion Constructors

        #region Color Palette

        /// <summary>
        /// Generate PictureBoxes with backgroundColor set to a specified palette color
        /// </summary>
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

        /// <summary>
        /// Draw a border on the selected palette color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClrBox_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            if (((PictureBox)sender).BackColor == _selectedColor)
            {
                DrawBorderOnControl(sender as Control, e.Graphics);
            }
        }
        
        /// <summary>
        /// Set the _selectedColor and add border around selected color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (includeLightShades) colors.Add(ControlPaint.Light(red));

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

        /// <summary>
        /// Get a random color
        /// </summary>
        /// <returns></returns>
        private Color GetRandomColor()
        {
            return Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
        }

        #endregion Color Palette

        #region Event Handlers - Menu and Tool Items

        /// <summary>
        /// Set the selected tool action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void img_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!!");
            return;

            _selectedToolAction = sender as PictureBox;
            pnlTools.Refresh();
        }

        /// <summary>
        /// Draw a border on the selected tool action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBoxItem_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            if (sender == _selectedToolAction)
            {
                DrawBorderOnControl(sender as Control, e.Graphics);
            }
        }
                
        /// <summary>
        /// Set backcolor of clicked menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
            ((PictureBox)sender).BackColor = Color.White;
        }
        
        /// <summary>
        /// Restore default backcolor of clicked menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender == _selectedToolAction) return;

            ((PictureBox)sender).BorderStyle = BorderStyle.None;
            ((PictureBox)sender).BackColor = Color.AliceBlue;
        }

        #endregion Event Handlers - Menu and Tool Items

        #region Undo\Redo

        private void SetRedoPoint()
        {
            var image = new Bitmap(_currentBitmap);
            _redo.Push(image);
        }

        private void DoRedo()
        {
            if (!_redo.Any()) return;

            SetUndoPoint();
            
            var image = _redo.Pop();
            DrawImageToCurrent(image);
        }

        private void SetUndoPoint()
        {
            var image = new Bitmap(_currentBitmap);
            _undo.Push(image);
        }

        private void DoUndo()
        {
            if (!_undo.Any()) return;

            SetRedoPoint();

            var image = _undo.Pop();
            DrawImageToCurrent(image);
        }

        private void imgUndo_Click(object sender, EventArgs e)
        {
            DoUndo();
            imgCanvas.Refresh();
        }

        private void imgRedo_Click(object sender, EventArgs e)
        {
            DoRedo();
            imgCanvas.Refresh();
        }

        private void DrawImageToCurrent(Image image)
        {
            var gfx = Graphics.FromImage(_currentBitmap);
            gfx.DrawImage(image, 0, 0);
            gfx.Dispose();
            image.Dispose();
        }

        #endregion Undo\Redo

        #region Canvas

        /// <summary>
        /// Determine what to do when the Canvas is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgCanvas_Click(object sender, EventArgs e)
        {
            if (_selectedToolAction == null) return;

            switch(_selectedToolAction.Name)
            {
                case "imgFill":
                    SetUndoPoint();
                    DoBucketFill();                    
                    break;
                case "imgText":
                    SetUndoPoint();
                    DoEnterText();                    
                    break;
                case "imgBrush":
                    DoBrush();
                    break;
            }            
        }

        /// <summary>
        /// Draw the currentBitmap to the canvas image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(_currentBitmap, 0, 0);
        }

        private Bitmap GetImageFromCanvas()
        {
            var bmp = new Bitmap(imgCanvas.ClientSize.Width, imgCanvas.ClientSize.Height);
            imgCanvas.DrawToBitmap(bmp, imgCanvas.ClientRectangle);
            bmp.Save("C:\\temp\\myImage.bmp");
            return bmp;
        }

        /// <summary>
        /// Resize the imgCanvas and _currentBitmap to the same dimensions of pnlCanvas
        /// </summary>
        /// <returns></returns>
        private PointF ResizeCanvasAndCurrentBitmap()
        {
            // scale image to canvas\bitmap
            var width = (float)imgCanvas.ClientSize.Width;
            var height = (float)imgCanvas.ClientSize.Height;

            // resize the canvas image and currentBitmap            
            imgCanvas.Image = new Bitmap((int)width, (int)height);
            _currentBitmap = new Bitmap((int)width, (int)height);

            return new PointF(width, height);
        }

        #endregion Canvas

        #region Open Menu Item

        private void imgOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog(this) != DialogResult.OK) return;

            ResetForm();

            // open the image file from a stream so we don't lock the file
            _openedFileName = dlgOpenFile.FileName;
            var image = GetImageFromFile(_openedFileName);

            var dims = ResizeCanvasAndCurrentBitmap();

            var gfx = Graphics.FromImage(_currentBitmap);

            // high koala-t graphics            
            gfx.InterpolationMode = InterpolationMode.High;
            gfx.CompositingQuality = CompositingQuality.HighQuality;
            gfx.SmoothingMode = SmoothingMode.AntiAlias;

            // scale the loaded image and render it to the bitmap
            var scale = Math.Min(dims.X / image.Width, dims.Y / image.Height);
            var scaleWidth = (int)(image.Width * scale);
            var scaleHeight = (int)(image.Height * scale);
            gfx.DrawImage(image, new Rectangle(((int)dims.X - scaleWidth) / 2, ((int)dims.Y - scaleHeight) / 2, scaleWidth, scaleHeight));
            gfx.Dispose();

            imgCanvas.Refresh();
        }

        /// <summary>
        /// Open the an image file via stream
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private Image GetImageFromFile(string filename)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filename);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
            return Image.FromStream(ms);
        }

        #endregion Open Menu Item

        #region Save Menu Item

        private void imgSave_Click(object sender, EventArgs e)
        {
            //GetImageFromCanvas();
            if (string.IsNullOrEmpty(_savedFileName))
            {
                dlgSaveFile.ShowDialog();
            }
            else
            {
                SaveImage();
            }
        }

        private void Dlg_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _savedFileName = dlgSaveFile.FileName;
            SaveImage();
        }

        private void SaveImage()
        {
            var fileNameNoPath = _savedFileName.Substring(_savedFileName.LastIndexOf("\\") + 1);
            var ext = fileNameNoPath.Substring(fileNameNoPath.LastIndexOf(".") + 1);
            Text = $"{_formTitle} - {fileNameNoPath}";
            
            // create a copy of the bitmap to avoid gdi+ errors
            var tempBitmap = new Bitmap(_currentBitmap);
            var imgFormat = GetImageFormat(ext);
            tempBitmap.Save(_savedFileName, imgFormat);
            tempBitmap.Dispose();
        }

        private ImageFormat GetImageFormat(string ext)
        {
            switch(ext.ToLower())
            {
                case "jpeg":                    
                case "jpg":
                    return ImageFormat.Jpeg;
                case "png":
                    return ImageFormat.Png;
                case "gif":
                    return ImageFormat.Gif;
                case "bmp":
                    return ImageFormat.Bmp;
                default:
                    return ImageFormat.Png;
            }
        }

        #endregion Save Menu Item

        #region Text Tool

        private void DoEnterText()
        {

        }

        #endregion Private Methods - Text Tool

        #region Brush Tool

        private void imgBrush_Click(object sender, EventArgs e)
        {

        }

        private void DoBrush()
        {

        }

        #endregion Private Methods - Brush Tool

        #region Bucket Tool

        private void DoBucketFill()
        {            
            var position = imgCanvas.PointToClient(Cursor.Position);
            FloodFill(_currentBitmap, position, Color.White, _selectedColor);
            
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

        #region Private Methods

        /// <summary>
        /// Draw a border on a control
        /// Uses: _borderColor, _borderWidth
        /// </summary>
        /// <param name="control"></param>
        /// <param name="gfx"></param>
        private void DrawBorderOnControl(Control control, Graphics gfx)
        {
            if (control == null) return;

            var rect = control.ClientRectangle;
            rect.Height -= 1;
            rect.Width -= 1;

            var path = new GraphicsPath();
            path.AddLine(rect.X, rect.Y, rect.X + rect.Width, rect.Y);
            path.AddLine(rect.X + rect.Width, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
            path.AddLine(rect.X + rect.Width, rect.Y + rect.Height, rect.X, rect.Y + rect.Height);
            path.AddLine(rect.X, rect.Y + rect.Height, rect.X, rect.Y);

            using (var p = new Pen(_borderColor, _borderWidth))
            {
                gfx.DrawPath(p, path);
            }
        }

        #endregion Private Methods

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
