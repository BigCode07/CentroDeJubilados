using FullProgram;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace FullProgram
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        CentroDeJubiladosEntities db = new CentroDeJubiladosEntities();

        private void showMessage(string msg, int duration)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duration;
                time.Tick += timeTick;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(msg);
            }
        }

        private void timeTick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        }


        private void QueryData(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            lblAllReg.Text = "";
            lblRegFilter.Text = "";
            dgvLegajos.Rows.Clear();

            IQueryable<HClinica> hClinicas = db.HClinicas;



            if (txtCaja.Text != "")
            {
                int caja = Convert.ToInt32(txtCaja.Text);
                hClinicas = hClinicas.Where(a => a.Caja == caja);
            }

            if (txtDni.Text != "")
            {
                int dni = Convert.ToInt32(txtDni.Text);
                hClinicas = hClinicas.Where(a => a.Dni == dni);
            }

            if (txtNombre.Text != "")
            {
                hClinicas = hClinicas.Where(l => l.ApeyNom.Contains(txtNombre.Text));
            }

            if (txtHclinica.Text != "")
            {

                hClinicas = hClinicas.Where(l => l.HClinica1 == txtHclinica.Text);
            }


            if (mskFCarga.MaskCompleted == true)
            {
                DateTime fcarga = Convert.ToDateTime(mskFCarga.Text);
                hClinicas = hClinicas.Where(a => a.FCarga == fcarga);
            }

            if (txtUsuario.Text != "")
            {
                hClinicas = hClinicas.Where(a => a.Usuario == txtUsuario.Text);
            }

            lblAllReg.Text += "Registros Total En Base:" + " " + db.HClinicas.ToList().Count();
            lblRegFilter.Text +="Registros Filtrados"+" "+ hClinicas.Count();

            if (hClinicas.Count() > 0)
            {

                foreach (var h in hClinicas.ToList())
                {
                    dgvLegajos.Rows.Add(h.Id, h.Caja, h.ApeyNom, h.Dni, h.HClinica1, h.Imagen, h.Usuario, h.FCarga);
                }
            }
            else
            {
                showMessage("No hay registros", 1500);
            }

        }

        private void CallDgv(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvLegajos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("Seguro desea Eliminar este Registro?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var reg = db.HClinicas.Find(dgvLegajos.CurrentRow.Cells[0].Value);
                        db.HClinicas.Remove(reg);
                        db.SaveChanges();
                        showMessage("Registro Eliminado", 1250);
                        UpdateData();
                     
                    }
                    catch { MessageBox.Show("Error en la operacion, verifique o complete datos faltantes"); }
                }

            }


            if (dgvLegajos.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                if (MessageBox.Show("Seguro desea modificar este registro?", "Modificar?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var hc = db.HClinicas.Find(dgvLegajos.CurrentRow.Cells[0].Value);

                        if (dgvLegajos.CurrentRow.Cells[1].Value != null)
                        {
                            hc.Caja = Convert.ToInt32(dgvLegajos.CurrentRow.Cells[1].Value);
                        }

                        if (dgvLegajos.CurrentRow.Cells[2].Value != null)
                        {
                            hc.ApeyNom = dgvLegajos.CurrentRow.Cells[2].Value.ToString();
                        }

                        if (dgvLegajos.CurrentRow.Cells[3].Value != null)
                        {
                            hc.Dni = Convert.ToInt32(dgvLegajos.CurrentRow.Cells[3].Value);
                        }

                        if (dgvLegajos.CurrentRow.Cells[4].Value != null)
                        {
                            hc.HClinica1 = dgvLegajos.CurrentRow.Cells[4].Value.ToString();
                        }


                        if (dgvLegajos.CurrentRow.Cells[5].Value != null)
                        {
                            hc.Imagen = dgvLegajos.CurrentRow.Cells[5].Value.ToString();
                        }


                        db.SaveChanges();
                        showMessage("Registro Modificado", 1000);
                        UpdateData();
                       
                    }
                    catch { MessageBox.Show("Error en la operacion, verifique o complete datos faltantes"); }
                }
            }
        }

        private void CallImage(object sender, DataGridViewCellEventArgs e)
        {
            axAcroPDF1.src = ConfigurationManager.AppSettings["images"] + "\\" + dgvLegajos.CurrentRow.Cells["Imagen"].Value.ToString();

        }

        private void Desplace(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void AllClear(object sender, EventArgs e)
        {

            txtDni.Text = txtHclinica.Text = txtNombre.Text = txtCaja.Text = txtUsuario.Text = mskFCarga.Text  = "";
            dgvLegajos.Rows.Clear();
            txtCaja.Focus();

        }

        private void Query_Load(object sender, EventArgs e)
        {

            lblAllReg.Text +="Registros Total En Base:"+" "+db.HClinicas.ToList().Count();
            txtCaja.Focus();
        }


    }
}
