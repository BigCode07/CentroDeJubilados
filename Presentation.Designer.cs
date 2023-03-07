namespace FullProgram
{
    partial class Presentation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentation));
            this.BackgroundPicture = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.CtlUsuario1 = new AxUsuarioOcx1.AxCtlUsuario();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtlUsuario1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPicture
            // 
            this.BackgroundPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPicture.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundPicture.Image")));
            this.BackgroundPicture.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPicture.Name = "BackgroundPicture";
            this.BackgroundPicture.Size = new System.Drawing.Size(336, 259);
            this.BackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundPicture.TabIndex = 0;
            this.BackgroundPicture.TabStop = false;
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1500;
            this.Time.Tick += new System.EventHandler(this.Timer);
            // 
            // CtlUsuario1
            // 
            this.CtlUsuario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CtlUsuario1.Enabled = true;
            this.CtlUsuario1.Location = new System.Drawing.Point(0, 227);
            this.CtlUsuario1.Name = "CtlUsuario1";
            this.CtlUsuario1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("CtlUsuario1.OcxState")));
            this.CtlUsuario1.Size = new System.Drawing.Size(336, 32);
            this.CtlUsuario1.TabIndex = 337;
            this.CtlUsuario1.Visible = false;
            // 
            // Presentation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 259);
            this.Controls.Add(this.CtlUsuario1);
            this.Controls.Add(this.BackgroundPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Presentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentation";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtlUsuario1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundPicture;
        private System.Windows.Forms.Timer Time;
        private AxUsuarioOcx1.AxCtlUsuario CtlUsuario1;
    }
}