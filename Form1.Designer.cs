namespace WCSharpExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BTN_GotoPath = new System.Windows.Forms.Button();
            this.TXTB_Path = new System.Windows.Forms.TextBox();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconosGrandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_LargeIcon = new System.Windows.Forms.Button();
            this.BTN_List = new System.Windows.Forms.Button();
            this.BTN_Tile = new System.Windows.Forms.Button();
            this.TXT_Elements = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.vistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devToolsToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // devToolsToolStripMenuItem
            // 
            this.devToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consolaToolStripMenuItem});
            this.devToolsToolStripMenuItem.Name = "devToolsToolStripMenuItem";
            this.devToolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devToolsToolStripMenuItem.Text = "Dev Tools";
            // 
            // consolaToolStripMenuItem
            // 
            this.consolaToolStripMenuItem.Name = "consolaToolStripMenuItem";
            this.consolaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.consolaToolStripMenuItem.Text = "Console";
            this.consolaToolStripMenuItem.Click += new System.EventHandler(this.consolaToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 56);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(1077, 485);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 4;
            this.listView1.TileSize = new System.Drawing.Size(256, 64);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imageres_162.png");
            this.imageList1.Images.SetKeyName(1, "shell32_1004.png");
            this.imageList1.Images.SetKeyName(2, "imageres_15.png");
            this.imageList1.Images.SetKeyName(3, "imageres_19.png");
            this.imageList1.Images.SetKeyName(4, "RarExtLogo.altform-unplated_targetsize-64.png");
            this.imageList1.Images.SetKeyName(5, "shell32_63008.png");
            this.imageList1.Images.SetKeyName(6, "cs.png");
            this.imageList1.Images.SetKeyName(7, "resx.png");
            this.imageList1.Images.SetKeyName(8, "sln.png");
            // 
            // BTN_GotoPath
            // 
            this.BTN_GotoPath.Location = new System.Drawing.Point(1014, 27);
            this.BTN_GotoPath.Name = "BTN_GotoPath";
            this.BTN_GotoPath.Size = new System.Drawing.Size(75, 23);
            this.BTN_GotoPath.TabIndex = 1;
            this.BTN_GotoPath.Text = "Ir a la ruta";
            this.BTN_GotoPath.UseVisualStyleBackColor = true;
            this.BTN_GotoPath.Click += new System.EventHandler(this.BTN_GotoPath_Click);
            // 
            // TXTB_Path
            // 
            this.TXTB_Path.Location = new System.Drawing.Point(68, 28);
            this.TXTB_Path.Name = "TXTB_Path";
            this.TXTB_Path.Size = new System.Drawing.Size(940, 20);
            this.TXTB_Path.TabIndex = 5;
            // 
            // BTN_Back
            // 
            this.BTN_Back.Location = new System.Drawing.Point(12, 27);
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.Size = new System.Drawing.Size(50, 23);
            this.BTN_Back.TabIndex = 6;
            this.BTN_Back.Text = "Atrás";
            this.BTN_Back.UseVisualStyleBackColor = true;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconosGrandesToolStripMenuItem,
            this.mosaicosToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.vistaToolStripMenuItem.Text = "Vista";
            // 
            // iconosGrandesToolStripMenuItem
            // 
            this.iconosGrandesToolStripMenuItem.Name = "iconosGrandesToolStripMenuItem";
            this.iconosGrandesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iconosGrandesToolStripMenuItem.Text = "Iconos grandes";
            this.iconosGrandesToolStripMenuItem.Click += new System.EventHandler(this.iconosGrandesToolStripMenuItem_Click);
            // 
            // mosaicosToolStripMenuItem
            // 
            this.mosaicosToolStripMenuItem.Name = "mosaicosToolStripMenuItem";
            this.mosaicosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mosaicosToolStripMenuItem.Text = "Mosaicos";
            this.mosaicosToolStripMenuItem.Click += new System.EventHandler(this.mosaicosToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // BTN_LargeIcon
            // 
            this.BTN_LargeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_LargeIcon.BackgroundImage")));
            this.BTN_LargeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_LargeIcon.Location = new System.Drawing.Point(1065, 545);
            this.BTN_LargeIcon.Name = "BTN_LargeIcon";
            this.BTN_LargeIcon.Size = new System.Drawing.Size(24, 24);
            this.BTN_LargeIcon.TabIndex = 7;
            this.BTN_LargeIcon.UseVisualStyleBackColor = true;
            this.BTN_LargeIcon.Click += new System.EventHandler(this.BTN_LargeIcon_Click);
            // 
            // BTN_List
            // 
            this.BTN_List.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_List.BackgroundImage")));
            this.BTN_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_List.Location = new System.Drawing.Point(1042, 545);
            this.BTN_List.Name = "BTN_List";
            this.BTN_List.Size = new System.Drawing.Size(24, 24);
            this.BTN_List.TabIndex = 8;
            this.BTN_List.UseVisualStyleBackColor = true;
            this.BTN_List.Click += new System.EventHandler(this.BTN_List_Click);
            // 
            // BTN_Tile
            // 
            this.BTN_Tile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Tile.BackgroundImage")));
            this.BTN_Tile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Tile.Location = new System.Drawing.Point(1019, 545);
            this.BTN_Tile.Name = "BTN_Tile";
            this.BTN_Tile.Size = new System.Drawing.Size(24, 24);
            this.BTN_Tile.TabIndex = 9;
            this.BTN_Tile.UseVisualStyleBackColor = true;
            this.BTN_Tile.Click += new System.EventHandler(this.BTN_Tile_Click);
            // 
            // TXT_Elements
            // 
            this.TXT_Elements.AutoSize = true;
            this.TXT_Elements.Location = new System.Drawing.Point(12, 551);
            this.TXT_Elements.Name = "TXT_Elements";
            this.TXT_Elements.Size = new System.Drawing.Size(71, 13);
            this.TXT_Elements.TabIndex = 10;
            this.TXT_Elements.Text = "Nº Elementos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 574);
            this.Controls.Add(this.TXT_Elements);
            this.Controls.Add(this.BTN_Tile);
            this.Controls.Add(this.BTN_List);
            this.Controls.Add(this.BTN_LargeIcon);
            this.Controls.Add(this.BTN_Back);
            this.Controls.Add(this.TXTB_Path);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BTN_GotoPath);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WCSharpExplorer";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consolaToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BTN_GotoPath;
        private System.Windows.Forms.TextBox TXTB_Path;
        private System.Windows.Forms.Button BTN_Back;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconosGrandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.Button BTN_LargeIcon;
        private System.Windows.Forms.Button BTN_List;
        private System.Windows.Forms.Button BTN_Tile;
        private System.Windows.Forms.Label TXT_Elements;
    }
}

