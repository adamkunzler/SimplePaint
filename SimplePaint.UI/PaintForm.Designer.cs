namespace SimplePaint.UI
{
    partial class PaintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.imgCanvas = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.imgOpen = new System.Windows.Forms.PictureBox();
            this.imgSave = new System.Windows.Forms.PictureBox();
            this.imgBrush = new System.Windows.Forms.PictureBox();
            this.imgFill = new System.Windows.Forms.PictureBox();
            this.pnlPalette = new System.Windows.Forms.FlowLayoutPanel();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCanvas)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFill)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.pnlCanvas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlPalette, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1012, 547);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Controls.Add(this.imgCanvas);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(103, 3);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(706, 541);
            this.pnlCanvas.TabIndex = 1;
            // 
            // imgCanvas
            // 
            this.imgCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgCanvas.Location = new System.Drawing.Point(0, 0);
            this.imgCanvas.Name = "imgCanvas";
            this.imgCanvas.Size = new System.Drawing.Size(706, 541);
            this.imgCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCanvas.TabIndex = 0;
            this.imgCanvas.TabStop = false;
            this.imgCanvas.Click += new System.EventHandler(this.imgCanvas_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMenu.Controls.Add(this.imgOpen);
            this.pnlMenu.Controls.Add(this.imgSave);
            this.pnlMenu.Controls.Add(this.imgBrush);
            this.pnlMenu.Controls.Add(this.imgFill);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMenu.Location = new System.Drawing.Point(2, 2);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(96, 543);
            this.pnlMenu.TabIndex = 3;
            // 
            // imgOpen
            // 
            this.imgOpen.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_open;
            this.imgOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOpen.Location = new System.Drawing.Point(3, 3);
            this.imgOpen.Name = "imgOpen";
            this.imgOpen.Size = new System.Drawing.Size(90, 90);
            this.imgOpen.TabIndex = 0;
            this.imgOpen.TabStop = false;
            this.imgOpen.Click += new System.EventHandler(this.imgOpen_Click);
            this.imgOpen.MouseEnter += new System.EventHandler(this.img_MouseEnter);
            this.imgOpen.MouseLeave += new System.EventHandler(this.img_MouseLeave);
            // 
            // imgSave
            // 
            this.imgSave.BackgroundImage = global::SimplePaint.UI.Properties.Resources.save1;
            this.imgSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSave.Location = new System.Drawing.Point(3, 99);
            this.imgSave.Name = "imgSave";
            this.imgSave.Size = new System.Drawing.Size(90, 90);
            this.imgSave.TabIndex = 1;
            this.imgSave.TabStop = false;
            this.imgSave.Click += new System.EventHandler(this.imgSave_Click);
            this.imgSave.MouseEnter += new System.EventHandler(this.img_MouseEnter);
            this.imgSave.MouseLeave += new System.EventHandler(this.img_MouseLeave);
            // 
            // imgBrush
            // 
            this.imgBrush.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_brush;
            this.imgBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBrush.Location = new System.Drawing.Point(3, 195);
            this.imgBrush.Name = "imgBrush";
            this.imgBrush.Size = new System.Drawing.Size(90, 90);
            this.imgBrush.TabIndex = 2;
            this.imgBrush.TabStop = false;
            this.imgBrush.Visible = false;
            this.imgBrush.Click += new System.EventHandler(this.img_Click);
            this.imgBrush.MouseEnter += new System.EventHandler(this.img_MouseEnter);
            this.imgBrush.MouseLeave += new System.EventHandler(this.img_MouseLeave);
            // 
            // imgFill
            // 
            this.imgFill.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_bucket;
            this.imgFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFill.Location = new System.Drawing.Point(3, 291);
            this.imgFill.Name = "imgFill";
            this.imgFill.Size = new System.Drawing.Size(90, 90);
            this.imgFill.TabIndex = 3;
            this.imgFill.TabStop = false;
            this.imgFill.Click += new System.EventHandler(this.img_Click);
            this.imgFill.MouseEnter += new System.EventHandler(this.img_MouseEnter);
            this.imgFill.MouseLeave += new System.EventHandler(this.img_MouseLeave);
            // 
            // pnlPalette
            // 
            this.pnlPalette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPalette.Location = new System.Drawing.Point(815, 3);
            this.pnlPalette.Name = "pnlPalette";
            this.pnlPalette.Size = new System.Drawing.Size(194, 541);
            this.pnlPalette.TabIndex = 4;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Title = "Open Image File";
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "PaintForm";
            this.Text = "PaintForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCanvas)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.FlowLayoutPanel pnlMenu;
        private System.Windows.Forms.FlowLayoutPanel pnlPalette;
        private System.Windows.Forms.PictureBox imgOpen;
        private System.Windows.Forms.PictureBox imgSave;
        private System.Windows.Forms.PictureBox imgBrush;
        private System.Windows.Forms.PictureBox imgFill;
        private System.Windows.Forms.PictureBox imgCanvas;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
    }
}