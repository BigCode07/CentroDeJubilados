namespace FullProgram
{
    partial class Query
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query));
            this.DatosActaDeAsamblea = new System.Windows.Forms.GroupBox();
            this.txtHclinica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskFCarga = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.dgvLegajos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CajaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeyNomGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HClinicaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagenGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCargaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.lblAllReg = new System.Windows.Forms.Label();
            this.lblRegFilter = new System.Windows.Forms.Label();
            this.DatosActaDeAsamblea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLegajos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosActaDeAsamblea
            // 
            this.DatosActaDeAsamblea.BackColor = System.Drawing.Color.Cornsilk;
            this.DatosActaDeAsamblea.Controls.Add(this.txtHclinica);
            this.DatosActaDeAsamblea.Controls.Add(this.label1);
            this.DatosActaDeAsamblea.Controls.Add(this.label3);
            this.DatosActaDeAsamblea.Controls.Add(this.mskFCarga);
            this.DatosActaDeAsamblea.Controls.Add(this.txtUsuario);
            this.DatosActaDeAsamblea.Controls.Add(this.label2);
            this.DatosActaDeAsamblea.Controls.Add(this.txtDni);
            this.DatosActaDeAsamblea.Controls.Add(this.label11);
            this.DatosActaDeAsamblea.Controls.Add(this.txtNombre);
            this.DatosActaDeAsamblea.Controls.Add(this.label12);
            this.DatosActaDeAsamblea.Controls.Add(this.txtCaja);
            this.DatosActaDeAsamblea.Controls.Add(this.label13);
            this.DatosActaDeAsamblea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosActaDeAsamblea.Location = new System.Drawing.Point(12, 20);
            this.DatosActaDeAsamblea.Name = "DatosActaDeAsamblea";
            this.DatosActaDeAsamblea.Size = new System.Drawing.Size(514, 301);
            this.DatosActaDeAsamblea.TabIndex = 0;
            this.DatosActaDeAsamblea.TabStop = false;
            this.DatosActaDeAsamblea.Text = "Datos Historias Clinicas";
            // 
            // txtHclinica
            // 
            this.txtHclinica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHclinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHclinica.Location = new System.Drawing.Point(199, 134);
            this.txtHclinica.Name = "txtHclinica";
            this.txtHclinica.Size = new System.Drawing.Size(227, 31);
            this.txtHclinica.TabIndex = 3;
            this.txtHclinica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "HClinica:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "F.Carga:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mskFCarga
            // 
            this.mskFCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.mskFCarga.Location = new System.Drawing.Point(199, 208);
            this.mskFCarga.Mask = "00/00/0000";
            this.mskFCarga.Name = "mskFCarga";
            this.mskFCarga.Size = new System.Drawing.Size(227, 31);
            this.mskFCarga.TabIndex = 5;
            this.mskFCarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(199, 171);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 31);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Usuario:";
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(199, 97);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(227, 31);
            this.txtDni.TabIndex = 2;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(79, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Dni:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(199, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 31);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Nombre:";
            // 
            // txtCaja
            // 
            this.txtCaja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(199, 23);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(227, 31);
            this.txtCaja.TabIndex = 0;
            this.txtCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(79, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Caja:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(291, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 31);
            this.btnClear.TabIndex = 9;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.AllClear);
            // 
            // btnAddDate
            // 
            this.btnAddDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.btnAddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDate.ForeColor = System.Drawing.Color.White;
            this.btnAddDate.Location = new System.Drawing.Point(70, 3);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(165, 31);
            this.btnAddDate.TabIndex = 6;
            this.btnAddDate.Text = "Buscar";
            this.btnAddDate.UseVisualStyleBackColor = false;
            this.btnAddDate.Click += new System.EventHandler(this.QueryData);
            this.btnAddDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // dgvLegajos
            // 
            this.dgvLegajos.AllowUserToAddRows = false;
            this.dgvLegajos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLegajos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLegajos.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvLegajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLegajos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CajaGrid,
            this.ApeyNomGrid,
            this.DniGrid,
            this.HClinicaGrid,
            this.ImagenGrid,
            this.UsuarioGrid,
            this.FechaCargaGrid,
            this.Modificar,
            this.Eliminar});
            this.dgvLegajos.Location = new System.Drawing.Point(12, 370);
            this.dgvLegajos.Name = "dgvLegajos";
            this.dgvLegajos.Size = new System.Drawing.Size(1097, 139);
            this.dgvLegajos.TabIndex = 366;
            this.dgvLegajos.TabStop = false;
            this.dgvLegajos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CallDgv);
            this.dgvLegajos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CallImage);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CajaGrid
            // 
            this.CajaGrid.HeaderText = "Caja";
            this.CajaGrid.Name = "CajaGrid";
            // 
            // ApeyNomGrid
            // 
            this.ApeyNomGrid.HeaderText = "Nombre";
            this.ApeyNomGrid.Name = "ApeyNomGrid";
            // 
            // DniGrid
            // 
            this.DniGrid.HeaderText = "Dni";
            this.DniGrid.Name = "DniGrid";
            // 
            // HClinicaGrid
            // 
            this.HClinicaGrid.HeaderText = "HClinica";
            this.HClinicaGrid.Name = "HClinicaGrid";
            // 
            // ImagenGrid
            // 
            this.ImagenGrid.HeaderText = "Imagen";
            this.ImagenGrid.Name = "ImagenGrid";
            // 
            // UsuarioGrid
            // 
            this.UsuarioGrid.HeaderText = "Usuario";
            this.UsuarioGrid.Name = "UsuarioGrid";
            this.UsuarioGrid.ReadOnly = true;
            // 
            // FechaCargaGrid
            // 
            this.FechaCargaGrid.HeaderText = "Fecha Carga";
            this.FechaCargaGrid.Name = "FechaCargaGrid";
            this.FechaCargaGrid.ReadOnly = true;
            // 
            // Modificar
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.Modificar.DefaultCellStyle = dataGridViewCellStyle9;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            this.Modificar.ToolTipText = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle10;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAddDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 37);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(532, 20);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(577, 344);
            this.axAcroPDF1.TabIndex = 383;
            this.axAcroPDF1.TabStop = false;
            // 
            // lblAllReg
            // 
            this.lblAllReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAllReg.AutoSize = true;
            this.lblAllReg.Location = new System.Drawing.Point(50, 516);
            this.lblAllReg.Name = "lblAllReg";
            this.lblAllReg.Size = new System.Drawing.Size(0, 13);
            this.lblAllReg.TabIndex = 384;
            // 
            // lblRegFilter
            // 
            this.lblRegFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRegFilter.AutoSize = true;
            this.lblRegFilter.Location = new System.Drawing.Point(812, 516);
            this.lblRegFilter.Name = "lblRegFilter";
            this.lblRegFilter.Size = new System.Drawing.Size(0, 13);
            this.lblRegFilter.TabIndex = 385;
            // 
            // Query
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1121, 537);
            this.Controls.Add(this.lblRegFilter);
            this.Controls.Add(this.lblAllReg);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLegajos);
            this.Controls.Add(this.DatosActaDeAsamblea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Query";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.Query_Load);
            this.DatosActaDeAsamblea.ResumeLayout(false);
            this.DatosActaDeAsamblea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLegajos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox DatosActaDeAsamblea;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.DataGridView dgvLegajos;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mskFCarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAllReg;
        private System.Windows.Forms.Label lblRegFilter;
        private System.Windows.Forms.TextBox txtHclinica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApeyNomGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn HClinicaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagenGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCargaGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}