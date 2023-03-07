namespace FullProgram
{
    partial class Digitize
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Digitize));
            this.dgvAA = new System.Windows.Forms.DataGridView();
            this.CajaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HClinicaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.gbLegajosAfiliados = new System.Windows.Forms.GroupBox();
            this.txtHclinica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAA)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbLegajosAfiliados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAA
            // 
            this.dgvAA.AllowUserToAddRows = false;
            this.dgvAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAA.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CajaDgv,
            this.NombreDgv,
            this.DniDgv,
            this.HClinicaGrid});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAA.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAA.Location = new System.Drawing.Point(12, 402);
            this.dgvAA.Name = "dgvAA";
            this.dgvAA.Size = new System.Drawing.Size(1097, 123);
            this.dgvAA.TabIndex = 6;
            this.dgvAA.TabStop = false;
            // 
            // CajaDgv
            // 
            this.CajaDgv.HeaderText = "Caja";
            this.CajaDgv.Name = "CajaDgv";
            // 
            // NombreDgv
            // 
            this.NombreDgv.HeaderText = "Nombre";
            this.NombreDgv.Name = "NombreDgv";
            // 
            // DniDgv
            // 
            this.DniDgv.HeaderText = "Dni";
            this.DniDgv.Name = "DniDgv";
            // 
            // HClinicaGrid
            // 
            this.HClinicaGrid.HeaderText = "HClinica";
            this.HClinicaGrid.Name = "HClinicaGrid";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.BtnAdd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 56);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(284, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 35);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClearAll);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(25, 10);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(211, 35);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Cargar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.AddData);
            this.BtnAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // gbLegajosAfiliados
            // 
            this.gbLegajosAfiliados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbLegajosAfiliados.BackColor = System.Drawing.Color.Cornsilk;
            this.gbLegajosAfiliados.Controls.Add(this.txtHclinica);
            this.gbLegajosAfiliados.Controls.Add(this.label3);
            this.gbLegajosAfiliados.Controls.Add(this.txtDni);
            this.gbLegajosAfiliados.Controls.Add(this.label2);
            this.gbLegajosAfiliados.Controls.Add(this.txtNombre);
            this.gbLegajosAfiliados.Controls.Add(this.label1);
            this.gbLegajosAfiliados.Controls.Add(this.checkBox3);
            this.gbLegajosAfiliados.Controls.Add(this.txtCaja);
            this.gbLegajosAfiliados.Controls.Add(this.label11);
            this.gbLegajosAfiliados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLegajosAfiliados.Location = new System.Drawing.Point(12, 20);
            this.gbLegajosAfiliados.Name = "gbLegajosAfiliados";
            this.gbLegajosAfiliados.Size = new System.Drawing.Size(514, 314);
            this.gbLegajosAfiliados.TabIndex = 0;
            this.gbLegajosAfiliados.TabStop = false;
            this.gbLegajosAfiliados.Text = "Datos Historias Clinicas";
            // 
            // txtHclinica
            // 
            this.txtHclinica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHclinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHclinica.Location = new System.Drawing.Point(230, 158);
            this.txtHclinica.Name = "txtHclinica";
            this.txtHclinica.Size = new System.Drawing.Size(180, 31);
            this.txtHclinica.TabIndex = 3;
            this.txtHclinica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "HClinica:";
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(230, 121);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(180, 31);
            this.txtDni.TabIndex = 2;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dni:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(230, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 31);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(230, 258);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 19);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.TabStop = false;
            this.checkBox3.Text = "Interfaz";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // txtCaja
            // 
            this.txtCaja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(230, 47);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(180, 31);
            this.txtCaja.TabIndex = 0;
            this.txtCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(89, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Caja:";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(532, 20);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(577, 376);
            this.axAcroPDF1.TabIndex = 380;
            this.axAcroPDF1.TabStop = false;
            // 
            // Digitize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1121, 537);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvAA);
            this.Controls.Add(this.gbLegajosAfiliados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Digitize";
            this.Text = "Digitize";
            this.Load += new System.EventHandler(this.StartProgram);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAA)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.gbLegajosAfiliados.ResumeLayout(false);
            this.gbLegajosAfiliados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAA;
    
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox gbLegajosAfiliados;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label2;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.TextBox txtHclinica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn HClinicaGrid;
    }
}