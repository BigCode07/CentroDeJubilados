using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using WindowsApplication1;

namespace FullProgram
{
    public partial class Digitize : Form
    {
        public Digitize()
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
            var existe = db.HClinicas.SingleOrDefault(a => a.Dni == dni && a.ApeyNom == txtNombre.Text && a.HClinica1 ==txtHclinica.Text);
            if (existe != null)
            {
                return true;
            }
            else { return false; };

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

      

        private void StartProgram(object sender, EventArgs e)
        {
            txtCaja.Focus();
        }

        private void ClearAll(object sender, EventArgs e)
        {

            txtDni.Text = txtHclinica.Text = txtNombre.Text = txtCaja.Text = "";
            dgvAA.Rows.Clear();
            txtCaja.Focus();

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
                dgvAA.Rows.Add(txtCaja.Text, txtNombre.Text, txtDni.Text, txtHclinica.Text);
            }
            else
            {
                MessageBox.Show("Cuidado, ya hay una imagen creada.", "Mensaje de aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (MessageBox.Show("Desea agragarle hojas?, presione SI para continuar y NO para cancelar", "Interfile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            int cant = Scan();
            for (int i = 0; i < cant; i++)
            {
                Contador.ToString();
            }

            Clear();

        }

        private int Scan()
        {

            int cant = 0;
            string archivo = txtNombre.Text + "-" + txtDni.Text + "-"+txtHclinica.Text+".pdf";
            string ruta = ConfigurationManager.AppSettings["Images"];
            comprobarDiretorio(ruta);
            ruta = ruta + @"\" + archivo;
            bool bandera = true;

            showMessage("Escaneando", 500);
            while (bandera)
            {

                if (checkBox3.Checked)
                {
                    EZTwain.SetHideUI(false);
                }
                else
                {
                    EZTwain.SetHideUI(true);
                }

                // EZTwain.SetHideUI(true);
                EZTwain.SetJpegQuality(75);
                if (EZTwain.OpenDefaultSource())
                {

                    EZTwain.EnableDuplex(true);
                    EZTwain.SetBlankPageMode(1);
                    EZTwain.SelectFeeder(true);
                    EZTwain.SetBlankPageThreshold(0.005);
                    EZTwain.SetFileAppendFlag(true);
                    EZTwain.SetPixelType(0);
                    EZTwain.SetResolution(200);
                    // If you can't get a Window handle, use IntPtr.Zero:
                    EZTwain.AcquireMultipageFile(this.Handle, ruta);
                    cant += EZTwain.MultipageCount();


                }
                if (EZTwain.LastErrorCode() != 0)
                {
                    EZTwain.ReportLastError("Unable to scan.");
                }

                agregar(ruta);

                if (MessageBox.Show("Desea agregar otra hoja a este Lote?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    txtCaja.Focus();
                    bandera = false;

                }
            }

            int dni = Convert.ToInt32(txtDni.Text);
            var update = db.HClinicas.SingleOrDefault(a => a.Dni == dni && a.ApeyNom == txtNombre.Text && a.HClinica1 == txtHclinica.Text);
            update.Imagen = archivo;
            db.SaveChanges();

            showMessage("Se actualizaron los datos del registro", 1000);
            return cant;
        }

        private void agregar(string nombre)
        {

            axAcroPDF1.LoadFile(nombre);
            axAcroPDF1.Show();

        }

        private void comprobarDiretorio(string dire)
        {
            DirectoryInfo DIR = new DirectoryInfo(dire);

            if (!DIR.Exists)
            {
                DIR.Create();
            }

        }

   
    }
}
