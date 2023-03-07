
using FullProgram;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace FullProgram
{
    public partial class Add : Form
    {

        public Add()
        {
            InitializeComponent();
        }



        CentroDeJubiladosEntities db = new CentroDeJubiladosEntities();

        public static string usuarioAdd;
        public static object Contador;

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

        private bool Exist()
        {

            int dni = Convert.ToInt32(txtDni.Text);
            var existe = db.HClinicas.SingleOrDefault(a => a.Dni == dni && a.ApeyNom == txtNombre.Text && a.HClinica1 == txtHclinica.Text);
            if (existe != null)
            {
                return true;
            }
            else { return false; };

        }

        private void AddData(object sender, EventArgs e)
        {


            HClinica hClinica = new HClinica();

            if (txtCaja.Text == "" && txtNombre.Text == "" && txtDni.Text == "")
            {
                showMessage("Faltan datos de cargar", 1500);
                txtCaja.Focus();
                return;
            }
            if (!Exist())
            {

                hClinica.Caja = Convert.ToInt32(txtCaja.Text);
                hClinica.HClinica1 = txtHclinica.Text;
                hClinica.Dni = Convert.ToInt32(txtDni.Text);
                hClinica.ApeyNom = txtNombre.Text;
                hClinica.FCarga = DateTime.Now;
                hClinica.Usuario = usuarioAdd;
                db.HClinicas.Add(hClinica);
                db.SaveChanges();
                showMessage("Se cargaron los datos", 1000);
                dgv.Rows.Add(txtCaja.Text, txtNombre.Text, txtDni.Text, txtHclinica.Text);
            }
            else { showMessage("Ya existe un registro", 2000); }

            Clear();
        }

        private void Clear()
        {
            txtDni.Text = txtHclinica.Text = txtNombre.Text = "";
            txtNombre.Focus();

        }

        private void Desplace(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void DesplaceType(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void StartProgram(object sender, EventArgs e)
        {
            txtCaja.Focus();
        }

        private void ClearAll(object sender, EventArgs e)
        {
            txtDni.Text = txtHclinica.Text = txtNombre.Text = txtCaja.Text = "";
            dgv.Rows.Clear();
            txtCaja.Focus();

        }

    }
}
