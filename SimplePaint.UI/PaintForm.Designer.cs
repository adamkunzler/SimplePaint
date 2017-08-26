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
            this.pnlPalette = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTools = new System.Windows.Forms.FlowLayoutPanel();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.imgCanvas = new System.Windows.Forms.PictureBox();
            this.imgOpen = new System.Windows.Forms.PictureBox();
            this.imgSave = new System.Windows.Forms.PictureBox();
            this.imgUndo = new System.Windows.Forms.PictureBox();
            this.imgRedo = new System.Windows.Forms.PictureBox();
            this.imgBrush = new System.Windows.Forms.PictureBox();
            this.imgFill = new System.Windows.Forms.PictureBox();
            this.imgText = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgText)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPalette, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlCanvas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTools, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 861);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlPalette
            // 
            this.pnlPalette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlPalette, 3);
            this.pnlPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPalette.Location = new System.Drawing.Point(3, 764);
            this.pnlPalette.Name = "pnlPalette";
            this.pnlPalette.Size = new System.Drawing.Size(1178, 94);
            this.pnlPalette.TabIndex = 5;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Controls.Add(this.imgCanvas);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(103, 3);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(978, 755);
            this.pnlCanvas.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMenu.Controls.Add(this.imgOpen);
            this.pnlMenu.Controls.Add(this.imgSave);
            this.pnlMenu.Controls.Add(this.imgUndo);
            this.pnlMenu.Controls.Add(this.imgRedo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMenu.Location = new System.Drawing.Point(2, 2);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(96, 757);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.imgBrush);
            this.pnlTools.Controls.Add(this.imgFill);
            this.pnlTools.Controls.Add(this.imgText);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTools.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlTools.Location = new System.Drawing.Point(1087, 3);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(94, 755);
            this.pnlTools.TabIndex = 6;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Title = "Open Image File";
            // 
            // imgCanvas
            // 
            this.imgCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgCanvas.Location = new System.Drawing.Point(0, 0);
            this.imgCanvas.Name = "imgCanvas";
            this.imgCanvas.Size = new System.Drawing.Size(978, 755);
            this.imgCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCanvas.TabIndex = 0;
            this.imgCanvas.TabStop = false;
            this.imgCanvas.Click += new System.EventHandler(this.imgCanvas_Click);
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
            this.imgOpen.Paint += new System.Windows.Forms.PaintEventHandler(this.imgOpen_Paint);
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
            this.imgSave.Paint += new System.Windows.Forms.PaintEventHandler(this.imgSave_Paint);
            this.imgSave.MouseEnter += new System.EventHandler(this.img_MouseEnter);
            this.imgSave.MouseLeave += new System.EventHandler(this.img_MouseLeave);
            // 
            // imgUndo
            // 
            this.imgUndo.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_undo;
            this.imgUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgUndo.Location = new System.Drawing.Point(3, 195);
            this.imgUndo.Name = "imgUndo";
            this.imgUndo.Size = new System.Drawing.Size(90, 90);
            this.imgUndo.TabIndex = 2;
            this.imgUndo.TabStop = false;
            this.imgUndo.Paint += new System.Windows.Forms.PaintEventHandler(this.imgUndo_Paint);
            // 
            // imgRedo
            // 
            this.imgRedo.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_redo2;
            this.imgRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgRedo.Location = new System.Drawing.Point(3, 291);
            this.imgRedo.Name = "imgRedo";
            this.imgRedo.Size = new System.Drawing.Size(90, 90);
            this.imgRedo.TabIndex = 3;
            this.imgRedo.TabStop = false;
            this.imgRedo.Paint += new System.Windows.Forms.PaintEventHandler(this.imgRedo_Paint);
            // 
            // imgBrush
            // 
            this.imgBrush.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_brush;
            this.imgBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBrush.Location = new System.Drawing.Point(3, 3);
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
            this.imgFill.Location = new System.Drawing.Point(3, 99);
            this.imgFill.Name = "imgFill";
            this.imgFill.Size = new System.Drawing.Size(90, 90);
            this.imgFill.TabIndex = 3;
            this.imgFill.TabStop = false;
            this.imgFill.Click += new System.EventHandler(this.img_Click);
            this.imgFill.MouseEnter += new System.EventHandler(this.img_MouseEnter);
            this.imgFill.MouseLeave += new System.EventHandler(this.img_MouseLeave);
            // 
            // imgText
            // 
            this.imgText.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_text;
            this.imgText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgText.Location = new System.Drawing.Point(3, 195);
            this.imgText.Name = "imgText";
            this.imgText.Size = new System.Drawing.Size(90, 90);
            this.imgText.TabIndex = 4;
            this.imgText.TabStop = false;
            this.imgText.Click += new System.EventHandler(this.img_Click);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "PaintForm";
            this.Text = "PaintForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.FlowLayoutPanel pnlMenu;
        private System.Windows.Forms.PictureBox imgOpen;
        private System.Windows.Forms.PictureBox imgSave;
        private System.Windows.Forms.PictureBox imgBrush;
        private System.Windows.Forms.PictureBox imgFill;
        private System.Windows.Forms.PictureBox imgCanvas;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.FlowLayoutPanel pnlPalette;
        private System.Windows.Forms.FlowLayoutPanel pnlTools;
        private System.Windows.Forms.PictureBox imgText;
        private System.Windows.Forms.PictureBox imgUndo;
        private System.Windows.Forms.PictureBox imgRedo;
    }
}