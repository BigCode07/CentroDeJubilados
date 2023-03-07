using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FullProgram
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size
            //this.BackColor = Color.FromArgb(98, 102, 244);//Border color
        }

        public string UsuarioMenu;
        public string Contador;

        //Fields
        private int borderSize = 0;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnScroll_Click(object sender, EventArgs e)
        {
            if(panelMenu.Width == 235)
            {
                panelMenu.Width = 60;
            }
            else
            {
                panelMenu.Width = 235;
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void OpenChildForm(object formhijo)
        {
            if (this.MainScreen1.Controls.Count > 0)
                this.MainScreen1.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MainScreen1.Controls.Add(fh);
            this.MainScreen1.Tag = fh;
            fh.Show();
        }

        private void Digitizes(object sender, EventArgs e)
        {
            var fm = new Digitize();
            Digitize.usuarioAdd = this.UsuarioMenu;
            Digitize.Contador = this.Contador; 
            OpenChildForm(fm);
        }

        private void Adds(object sender, EventArgs e)
        {
            var fm = new Add();
            Add.usuarioAdd = this.UsuarioMenu;
            Add.Contador = this.Contador;
            OpenChildForm(fm);
        }

        private void Query(object sender, EventArgs e)
        {
            var fm = new Query();
            OpenChildForm(fm);
        }

        private void Billing(object sender, EventArgs e)
        {
            var fm = new Billing();
            OpenChildForm(fm);
        }

        private void Home(object sender, EventArgs e)
        {
            var fm = new Home();
            OpenChildForm(fm);
        }

        private void ProjectStart(object sender, EventArgs e)
        {
            var fm = new Home();
            OpenChildForm(fm);
        }

       
    }
}
