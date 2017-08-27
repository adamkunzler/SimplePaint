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
            this.imgCanvas = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.imgOpen = new System.Windows.Forms.PictureBox();
            this.imgSave = new System.Windows.Forms.PictureBox();
            this.imgUndo = new System.Windows.Forms.PictureBox();
            this.imgRedo = new System.Windows.Forms.PictureBox();
            this.pnlTools = new System.Windows.Forms.FlowLayoutPanel();
            this.imgBrush = new System.Windows.Forms.PictureBox();
            this.imgFill = new System.Windows.Forms.PictureBox();
            this.imgText = new System.Windows.Forms.PictureBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCanvas)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRedo)).BeginInit();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgText)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPalette, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlCanvas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTools, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1746, 861);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlPalette
            // 
            this.pnlPalette.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.pnlPalette, 3);
            this.pnlPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPalette.Location = new System.Drawing.Point(3, 714);
            this.pnlPalette.Name = "pnlPalette";
            this.pnlPalette.Size = new System.Drawing.Size(1740, 144);
            this.pnlPalette.TabIndex = 5;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Controls.Add(this.imgCanvas);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(153, 3);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1440, 705);
            this.pnlCanvas.TabIndex = 1;
            // 
            // imgCanvas
            // 
            this.imgCanvas.BackColor = System.Drawing.Color.AliceBlue;
            this.imgCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgCanvas.Location = new System.Drawing.Point(0, 0);
            this.imgCanvas.Name = "imgCanvas";
            this.imgCanvas.Size = new System.Drawing.Size(1440, 705);
            this.imgCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCanvas.TabIndex = 0;
            this.imgCanvas.TabStop = false;
            this.imgCanvas.Click += new System.EventHandler(this.imgCanvas_Click);
            this.imgCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.imgCanvas_Paint);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMenu.Controls.Add(this.imgOpen);
            this.pnlMenu.Controls.Add(this.imgSave);
            this.pnlMenu.Controls.Add(this.imgUndo);
            this.pnlMenu.Controls.Add(this.imgRedo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMenu.Location = new System.Drawing.Point(2, 2);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(146, 707);
            this.pnlMenu.TabIndex = 3;
            // 
            // imgOpen
            // 
            this.imgOpen.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_open;
            this.imgOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOpen.Location = new System.Drawing.Point(3, 3);
            this.imgOpen.Name = "imgOpen";
            this.imgOpen.Size = new System.Drawing.Size(140, 140);
            this.imgOpen.TabIndex = 0;
            this.imgOpen.TabStop = false;
            this.imgOpen.Click += new System.EventHandler(this.imgOpen_Click);
            this.imgOpen.Paint += new System.Windows.Forms.PaintEventHandler(this.imgOpen_Paint);
            this.imgOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgMenuItem_MouseDown);
            this.imgOpen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgMenuItem_MouseUp);
            // 
            // imgSave
            // 
            this.imgSave.BackgroundImage = global::SimplePaint.UI.Properties.Resources.save1;
            this.imgSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSave.Location = new System.Drawing.Point(3, 149);
            this.imgSave.Name = "imgSave";
            this.imgSave.Size = new System.Drawing.Size(140, 140);
            this.imgSave.TabIndex = 1;
            this.imgSave.TabStop = false;
            this.imgSave.Click += new System.EventHandler(this.imgSave_Click);
            this.imgSave.Paint += new System.Windows.Forms.PaintEventHandler(this.imgSave_Paint);
            this.imgSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgMenuItem_MouseDown);
            this.imgSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgMenuItem_MouseUp);
            // 
            // imgUndo
            // 
            this.imgUndo.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_undo;
            this.imgUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgUndo.Location = new System.Drawing.Point(3, 295);
            this.imgUndo.Name = "imgUndo";
            this.imgUndo.Size = new System.Drawing.Size(140, 140);
            this.imgUndo.TabIndex = 2;
            this.imgUndo.TabStop = false;
            this.imgUndo.Click += new System.EventHandler(this.imgUndo_Click);
            this.imgUndo.Paint += new System.Windows.Forms.PaintEventHandler(this.imgUndo_Paint);
            this.imgUndo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgMenuItem_MouseDown);
            this.imgUndo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgMenuItem_MouseUp);
            // 
            // imgRedo
            // 
            this.imgRedo.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_redo2;
            this.imgRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgRedo.Location = new System.Drawing.Point(3, 441);
            this.imgRedo.Name = "imgRedo";
            this.imgRedo.Size = new System.Drawing.Size(140, 140);
            this.imgRedo.TabIndex = 3;
            this.imgRedo.TabStop = false;
            this.imgRedo.Click += new System.EventHandler(this.imgRedo_Click);
            this.imgRedo.Paint += new System.Windows.Forms.PaintEventHandler(this.imgRedo_Paint);
            this.imgRedo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgMenuItem_MouseDown);
            this.imgRedo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgMenuItem_MouseUp);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlTools.Controls.Add(this.imgBrush);
            this.pnlTools.Controls.Add(this.imgFill);
            this.pnlTools.Controls.Add(this.imgText);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTools.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlTools.Location = new System.Drawing.Point(1599, 3);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(144, 705);
            this.pnlTools.TabIndex = 6;
            // 
            // imgBrush
            // 
            this.imgBrush.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_brush;
            this.imgBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBrush.Location = new System.Drawing.Point(3, 3);
            this.imgBrush.Name = "imgBrush";
            this.imgBrush.Size = new System.Drawing.Size(140, 140);
            this.imgBrush.TabIndex = 2;
            this.imgBrush.TabStop = false;
            this.imgBrush.Visible = false;
            this.imgBrush.Click += new System.EventHandler(this.img_Click);
            this.imgBrush.Paint += new System.Windows.Forms.PaintEventHandler(this.toolBoxItem_Paint);
            // 
            // imgFill
            // 
            this.imgFill.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_bucket;
            this.imgFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFill.Location = new System.Drawing.Point(3, 149);
            this.imgFill.Name = "imgFill";
            this.imgFill.Size = new System.Drawing.Size(140, 140);
            this.imgFill.TabIndex = 3;
            this.imgFill.TabStop = false;
            this.imgFill.Click += new System.EventHandler(this.img_Click);
            this.imgFill.Paint += new System.Windows.Forms.PaintEventHandler(this.toolBoxItem_Paint);
            // 
            // imgText
            // 
            this.imgText.BackgroundImage = global::SimplePaint.UI.Properties.Resources.img_text;
            this.imgText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgText.Location = new System.Drawing.Point(3, 295);
            this.imgText.Name = "imgText";
            this.imgText.Size = new System.Drawing.Size(140, 140);
            this.imgText.TabIndex = 4;
            this.imgText.TabStop = false;
            this.imgText.Click += new System.EventHandler(this.img_Click);
            this.imgText.Paint += new System.Windows.Forms.PaintEventHandler(this.toolBoxItem_Paint);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Title = "Open Image File";
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.Dlg_FileOk);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1762, 900);
            this.Name = "PaintForm";
            this.Text = "PaintForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCanvas)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRedo)).EndInit();
            this.pnlTools.ResumeLayout(false);
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
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}