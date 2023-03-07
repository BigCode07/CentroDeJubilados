namespace FullProgram
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.btnMinize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnScroll = new System.Windows.Forms.PictureBox();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Tittle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnBilling = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDigitize = new System.Windows.Forms.Button();
            this.MainScreen1 = new System.Windows.Forms.Panel();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnScroll)).BeginInit();
            this.panelPicture.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.PanelTitle.Controls.Add(this.btnMinize);
            this.PanelTitle.Controls.Add(this.btnMaximize);
            this.PanelTitle.Controls.Add(this.button1);
            this.PanelTitle.Controls.Add(this.btnScroll);
            this.PanelTitle.Controls.Add(this.panelPicture);
            this.PanelTitle.Controls.Add(this.Tittle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(1181, 50);
            this.PanelTitle.TabIndex = 1;
            // 
            // btnMinize
            // 
            this.btnMinize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinize.BackgroundImage")));
            this.btnMinize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinize.FlatAppearance.BorderSize = 0;
            this.btnMinize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinize.Location = new System.Drawing.Point(1082, 12);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(25, 25);
            this.btnMinize.TabIndex = 12;
            this.btnMinize.UseVisualStyleBackColor = true;
            this.btnMinize.Click += new System.EventHandler(this.Minimize);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(1113, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.Maximize);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1144, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Exit);
            // 
            // btnScroll
            // 
            this.btnScroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScroll.Image = ((System.Drawing.Image)(resources.GetObject("btnScroll.Image")));
            this.btnScroll.Location = new System.Drawing.Point(73, 7);
            this.btnScroll.Name = "btnScroll";
            this.btnScroll.Size = new System.Drawing.Size(35, 35);
            this.btnScroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnScroll.TabIndex = 9;
            this.btnScroll.TabStop = false;
            this.btnScroll.Click += new System.EventHandler(this.btnScroll_Click);
            // 
            // panelPicture
            // 
            this.panelPicture.Controls.Add(this.panelLogo);
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(60, 50);
            this.panelPicture.TabIndex = 5;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(60, 50);
            this.panelLogo.TabIndex = 1;
            // 
            // Tittle
            // 
            this.Tittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.ForeColor = System.Drawing.Color.White;
            this.Tittle.Location = new System.Drawing.Point(470, 7);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(334, 31);
            this.Tittle.TabIndex = 4;
            this.Tittle.Text = "CENTRO DE JUBILADOS";
            this.Tittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Maroon;
            this.panelMenu.Controls.Add(this.BtnBilling);
            this.panelMenu.Controls.Add(this.BtnExit);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.BtnQuery);
            this.panelMenu.Controls.Add(this.BtnAdd);
            this.panelMenu.Controls.Add(this.BtnDigitize);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(60, 537);
            this.panelMenu.TabIndex = 2;
            // 
            // BtnBilling
            // 
            this.BtnBilling.FlatAppearance.BorderSize = 0;
            this.BtnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBilling.ForeColor = System.Drawing.Color.White;
            this.BtnBilling.Image = ((System.Drawing.Image)(resources.GetObject("BtnBilling.Image")));
            this.BtnBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBilling.Location = new System.Drawing.Point(5, 216);
            this.BtnBilling.Name = "BtnBilling";
            this.BtnBilling.Size = new System.Drawing.Size(221, 45);
            this.BtnBilling.TabIndex = 5;
            this.BtnBilling.Text = "Facturacion";
            this.BtnBilling.UseVisualStyleBackColor = true;
            this.BtnBilling.Click += new System.EventHandler(this.Billing);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(5, 480);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(221, 45);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Salir";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.Exit);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(5, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 45);
            this.button5.TabIndex = 3;
            this.button5.Text = "Inicio";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Home);
            // 
            // BtnQuery
            // 
            this.BtnQuery.FlatAppearance.BorderSize = 0;
            this.BtnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuery.ForeColor = System.Drawing.Color.White;
            this.BtnQuery.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuery.Image")));
            this.BtnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuery.Location = new System.Drawing.Point(5, 165);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(221, 45);
            this.BtnQuery.TabIndex = 2;
            this.BtnQuery.Text = "Consulta";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.Query);
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(5, 114);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(221, 45);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Carga";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.Adds);
            // 
            // BtnDigitize
            // 
            this.BtnDigitize.FlatAppearance.BorderSize = 0;
            this.BtnDigitize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDigitize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDigitize.ForeColor = System.Drawing.Color.White;
            this.BtnDigitize.Image = ((System.Drawing.Image)(resources.GetObject("BtnDigitize.Image")));
            this.BtnDigitize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDigitize.Location = new System.Drawing.Point(5, 63);
            this.BtnDigitize.Name = "BtnDigitize";
            this.BtnDigitize.Size = new System.Drawing.Size(221, 45);
            this.BtnDigitize.TabIndex = 0;
            this.BtnDigitize.Text = "Digitalizacion";
            this.BtnDigitize.UseVisualStyleBackColor = true;
            this.BtnDigitize.Click += new System.EventHandler(this.Digitizes);
            // 
            // MainScreen1
            // 
            this.MainScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(186)))));
            this.MainScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainScreen1.Location = new System.Drawing.Point(60, 50);
            this.MainScreen1.Name = "MainScreen1";
            this.MainScreen1.Size = new System.Drawing.Size(1121, 537);
            this.MainScreen1.TabIndex = 3;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 587);
            this.Controls.Add(this.MainScreen1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProjectStart);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnScroll)).EndInit();
            this.panelPicture.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnScroll;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel MainScreen1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMinize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button BtnDigitize;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnBilling;
    }
}

