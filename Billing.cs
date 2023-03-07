
using System.Linq;
using FullProgram;
using System.Windows.Forms;
using System;

namespace FullProgram
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

    

        private void SelectDates(object sender, DateRangeEventArgs e)
        {
            CentroDeJubiladosEntities db = new CentroDeJubiladosEntities();
            label1.Text = "";
            IQueryable<HClinica> hClinicas = db.HClinicas;

            DateTime fechaInicio = Convert.ToDateTime(monthCalendar.SelectionStart);
            DateTime fechaFin = Convert.ToDateTime(monthCalendar.SelectionEnd);

            hClinicas = hClinicas.Where(a => a.FCarga >= fechaInicio && a.FCarga <= fechaFin);
            label1.Text += "Registros Encontrados: " + hClinicas.Count();

        }
    }
}
